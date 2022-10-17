Imports System.Collections.Generic
Imports System.Data

Partial Class controles_ucVistaDetalleCALENDARIZACION
    Inherits ucBase

    Private _Enabled As Boolean = True
    Private _sError As String
    Private mComponente As New cACCION_FORMATIVA
    Private mEntidad As ACCION_FORMATIVA
    Public Event Mensaje(ByVal sMensaje As String, ByVal esAlerta As Boolean)

    Public ReadOnly Property ReferenciaUID As String
        Get
            Return Me.lblREFERENCIA.Text
        End Get
    End Property

    Public Property Nuevo As Boolean
        Get
            If Me.ViewState("Nuevo") IsNot Nothing Then
                Return CBool(Me.ViewState("Nuevo"))
            Else
                Return 0
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("Nuevo") = value
        End Set
    End Property
    Public Property ID_GRUPO_SELEC As Integer
        Get
            If Me.ViewState("ID_GRUPO_SELEC") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_GRUPO_SELEC"))
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            Me.Nuevo = True
            Me.ViewState("ID_GRUPO_SELEC") = value
            Me.EsNuevaCalendarizacionPECentro()
            Me.InfoPorGRUPO_SELECCION()
        End Set
    End Property
    Public Property ID_PROGRAMA_FORMACION As Integer
        Get
            If Me.ViewState("ID_PROGRAMA_FORMACION") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_PROGRAMA_FORMACION"))
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            Me.ViewState("ID_PROGRAMA_FORMACION") = value
        End Set
    End Property

    Public Property LISTA_CALE_FECHA As listaCALE_FECHA
        Set(value As listaCALE_FECHA)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaCALE_FECHA) Else Return New listaCALE_FECHA
        End Get
    End Property

    Public Sub EsNuevaCalendarizacionPECentro()
        Me.cbxPROVEEDOR_AF.ClientEnabled = False
        Me.cbxSITIO_CAPACITACION.ClientEnabled = False
        Me.txtNO_COMPRA_LICITACION.ClientEnabled = False
        Me.txtNUM_CONTRATO.ClientEnabled = False
        Me.txtCODIGO_PROGRAMA.ClientEnabled = False
        Me.txtNOMBRE_ACCION_FORMATIVA.ClientEnabled = False
        Me.txtCODIGO_GRUPO.ClientEnabled = False
        Me.txtDURACION.ClientEnabled = True
        Me.txtCOSTO_X_PARTICIPANTE.ClientEnabled = False
        Me.cbxEJERCICIO.ClientEnabled = Me.Nuevo
        Me.cbxMES.ClientEnabled = Me.Nuevo
        Me.trSITIO_CAPACITACION.Visible = False
        Me.txtLUGAR_EJECUCION.Text = ""
        Me.cbxDEPARTAMENTO_EJECUCION.Value = Nothing
        Me.txtCODI_FORMADOR.Text = ""
        Me.txtNOMBRE_FORMADOR.Text = ""
        Me.txtCODI_FORMADOR.ClientEnabled = True
        Me.txtNOMBRE_FORMADOR.ClientEnabled = False
        Me.CargarMunicipioEjecucion()
        Me.TabCalendarizacion.ActiveTabIndex = 0

        If Me.Nuevo Then
            Me.cbxEJERCICIO.Value = Today.Year.ToString
            Me.cbxMES.SelectedIndex = Today.Month - 1
        End If
    End Sub

    Public Sub InfoPorGRUPO_SELECCION()
        Dim lGrupoSele As GRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(ID_GRUPO_SELEC)
        Dim lAccionContra As ACCION_CONTRATADA
        Dim lContrato As CONTRATO_BOLPROS
        Dim lOferta As CONTRATO_COMPRA
        Dim lprograma As SIFP.EL.Programas

        If lGrupoSele IsNot Nothing Then
            lAccionContra = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoSele.ID_ACCION_CONTRATADA)
            If lAccionContra IsNot Nothing Then
                lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContra.ID_CONTRATO)
                If lContrato IsNot Nothing Then
                    ID_PROGRAMA_FORMACION = lContrato.ID_PROGRAMA_FORMACION
                    lOferta = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
                    If lOferta IsNot Nothing Then

                        Me.cbxPROVEEDOR_AF.Value = CInt(lContrato.ID_PROVEEDOR_AF)
                        Me.txtNO_COMPRA_LICITACION.Text = lOferta.NO_CONTRATO_COMPRA
                        Me.txtNUM_CONTRATO.Text = lContrato.NUM_CONTRATO
                        Me.txtCODIGO_PROGRAMA.Text = lAccionContra.CODIGO_PROGRAMA
                        lprograma = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccionContra.CODIGO_PROGRAMA)
                        If lprograma IsNot Nothing Then
                            Me.txtCODIGO_PROGRAMA.Text += " - " + lprograma.nombre_programa
                        End If
                        Me.txtNOMBRE_ACCION_FORMATIVA.Text = Utilerias.QuitarAcentos(lprograma.nombre_programa.ToUpper) 'lAccionContra.NOMBRE_ACCION_FORMATIVA
                        Me.txtCODIGO_GRUPO.Text = "-"
                        Me.txtDURACION.Text = ""
                        Me.txtCOSTO_X_PARTICIPANTE.Text = lAccionContra.COSTO_PARTICIPANTE

                        Me.cbxDEPARTAMENTO_EJECUCION.Value = lAccionContra.CODIGO_DEPARTAMENTO
                        Me.CargarMunicipioEjecucion()
                        Me.cbxMUNICIPIO_EJECUCION.Value = lAccionContra.CODIGO_MUNICIPIO
                        Me.txtLUGAR_EJECUCION.Text = lGrupoSele.LUGAR_EJECUCION
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CargarMeses()
        Dim lista As List(Of String) = Utilerias.ObtenerListaMeses

        For i As Integer = 0 To lista.Count - 1
            Me.cbxMES.Items.Add(lista(i))
        Next
    End Sub

    Private Sub CargarCentrosFormacion()
        Dim lista As New listaSITIO_CAPACITACION

        If Me.cbxPROVEEDOR_AF.Value IsNot Nothing OrElse Me.cbxPROVEEDOR_AF.Value > 0 Then
            lista = (New cSITIO_CAPACITACION).ObtenerListaPorPROVEEDOR_AF(Me.cbxPROVEEDOR_AF.Value, False, False, "NOMBRE_SITIO")
        End If
        If lista Is Nothing Then lista = New listaSITIO_CAPACITACION

        Me.cbxSITIO_CAPACITACION.DataSource = lista
        Me.cbxSITIO_CAPACITACION.DataBind()
    End Sub

    Protected Sub cbxPROVEEDOR_AF_ValueChanged(sender As Object, e As EventArgs) Handles cbxPROVEEDOR_AF.ValueChanged
        Me.CargarCentrosFormacion()
    End Sub

    Protected Sub controles_ucVistaDetalleCALENDARIZACION_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarMeses()
        End If
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim listaCaleFecha As listaCALE_FECHA = LISTA_CALE_FECHA
        Dim lCaleFecha As CALE_FECHA
        Dim lCaleHorario As CALE_HORARIO
        Dim fAux As Date
        Dim sError As New StringBuilder
        Dim existeFechaEnProgra As Boolean = False
        Dim tHoraIni As DateTime
        Dim tHoraFin As DateTime
        Dim fIniMes As DateTime
        Dim fFinMes As DateTime

        If Me.txtDURACION.Text = "" Then
            sError.Append("* Ingrese la duracion en horas") : sError.Append("<br>")
        End If
        If Me.cbxEJERCICIO.Value Is Nothing AndAlso ID_PROGRAMA_FORMACION = ProgramasFormacion.EMPRESA_CENTRO Then
            sError.Append("* Seleccione el ejercicio") : sError.Append("<br>")
        End If
        If Me.cbxMES.Value Is Nothing AndAlso ID_PROGRAMA_FORMACION = ProgramasFormacion.EMPRESA_CENTRO Then
            sError.Append("* Seleccione el mes en que ingresara la programacion") : sError.Append("<br>")
        End If

        fIniMes = New DateTime(cbxEJERCICIO.Value, cbxMES.SelectedIndex + 1, 1)
        fFinMes = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, fIniMes))

        If Me.dteFechaInicio.Value Is Nothing OrElse Me.dteFechaFinalizacion.Value Is Nothing Then
            sError.Append("* Ingrese las fechas de inicio y finalizacion") : sError.Append("<br>")
        Else
            If Me.dteFechaInicio.Date > Me.dteFechaFinalizacion.Date Then
                sError.Append("* La fecha de inicio no puede ser mayor que la fecha de finalizacion") : sError.Append("<br>")
            End If
            If Me.dteFechaInicio.Date < fIniMes OrElse Me.dteFechaFinalizacion.Date > fFinMes Then
                sError.Append("* Las fechas de inicio y finalizacion de la programacion deben estar comprendidas dentro del mes seleccionado") : sError.Append("<br>")
            End If
        End If

        If Not Me.chkLunes.Checked AndAlso Not Me.chkMartes.Checked AndAlso Not Me.chkMiercoles.Checked AndAlso Not Me.chkJueves.Checked AndAlso _
            Not Me.chkViernes.Checked AndAlso Not Me.chkSabado.Checked AndAlso Not Me.chkDomingo.Checked Then
            sError.Append("* Marque los dias de la semana en que se impartira el curso") : sError.Append("<br>")
        End If
        If tmeHoraInicio.Value Is Nothing OrElse Me.tmeHoraFin.Value Is Nothing Then
            sError.Append("* Ingrese el horario") : sError.Append("<br>")
        End If
        If tmeHoraInicio.DateTime = Me.tmeHoraFin.DateTime Then
            sError.Append("* La hora de inicio no puede ser igual que la hora final") : sError.Append("<br>")
        End If
        If tmeHoraInicio.DateTime > Me.tmeHoraFin.DateTime Then
            sError.Append("* La hora de inicio no puede ser mayor que la hora final") : sError.Append("<br>")
        End If
        If sError.ToString <> "" Then
            RaiseEvent Mensaje(sError.ToString, True)
            Return
        End If
        fAux = Me.dteFechaInicio.Date
        tHoraIni = New DateTime(Me.tmeHoraInicio.DateTime.Year, Me.tmeHoraInicio.DateTime.Month, Me.tmeHoraInicio.DateTime.Day, Me.tmeHoraInicio.DateTime.Hour, Me.tmeHoraInicio.DateTime.Minute, 0)
        tHoraFin = New DateTime(Me.tmeHoraFin.DateTime.Year, Me.tmeHoraFin.DateTime.Month, Me.tmeHoraFin.DateTime.Day, Me.tmeHoraFin.DateTime.Hour, Me.tmeHoraFin.DateTime.Minute, 0)

        'Verificar los posibles conflictos
        While fAux <= Me.dteFechaFinalizacion.Date
            If Me.EsHorarioEnConflicto(listaCaleFecha, fAux, tHoraIni, tHoraFin) Then
                RaiseEvent Mensaje("Existe conflicto con un horario ya ingresado en la fecha " + fAux.ToString("dd/MM/yyyy"), True)
                Return
            End If

            fAux = fAux.AddDays(1)
        End While

        fAux = Me.dteFechaInicio.Date
        While fAux <= Me.dteFechaFinalizacion.Date
            If (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Monday AndAlso chkLunes.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Tuesday AndAlso chkMartes.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Wednesday AndAlso chkMiercoles.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Thursday AndAlso chkJueves.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Friday AndAlso chkViernes.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Saturday AndAlso chkSabado.Checked) OrElse _
               (dteFechaInicio.Date.DayOfWeek = DayOfWeek.Sunday AndAlso chkDomingo.Checked) Then

                'Inicializar entidad FECHA
                lCaleFecha = New CALE_FECHA
                lCaleFecha.ID_CALE = ObtenerIdFecha(listaCaleFecha)
                lCaleFecha.FECHA = fAux
                lCaleFecha.fkHORARIO = New listaCALE_HORARIO
                lCaleFecha.MINUTOS = 0
                lCaleFecha.HORARIO = ""
                lCaleFecha.REFERENCIA = Me.lblREFERENCIA.Text

                'Obtener fecha si ya existe en el listado
                If listaCaleFecha IsNot Nothing AndAlso listaCaleFecha.Count > 0 Then
                    For i As Integer = 0 To listaCaleFecha.Count - 1
                        If listaCaleFecha(i).FECHA = fAux Then
                            lCaleFecha = listaCaleFecha(i)
                            existeFechaEnProgra = True
                            Exit For
                        End If
                    Next
                End If

                'Agregar horario a la fecha
                lCaleHorario = New CALE_HORARIO
                lCaleHorario.ID_HORA = ObtenerIdHorario(lCaleFecha.fkHORARIO)
                lCaleHorario.ID_CALE = lCaleFecha.ID_CALE
                lCaleHorario.HORA_INI = tHoraIni
                lCaleHorario.HORA_FIN = tHoraFin
                lCaleHorario.MINUTOS = Math.Abs(DateDiff(DateInterval.Minute, tHoraFin, tHoraIni))
                If lCaleFecha.fkHORARIO Is Nothing Then lCaleFecha.fkHORARIO = New listaCALE_HORARIO
                lCaleFecha.fkHORARIO.Add(lCaleHorario)
                lCaleFecha.fkHORARIO.SortByColum("HORA_INI", ComponentModel.ListSortDirection.Ascending)
                'Actualizar horario y minutos en fecha
                Dim dTotalMinutos As Decimal = 0
                Dim sHorario As String = ""
                For i As Integer = 0 To lCaleFecha.fkHORARIO.Count - 1
                    lCaleHorario = lCaleFecha.fkHORARIO(i)
                    If i = 0 Then
                        sHorario = "DE " + lCaleHorario.HORA_INI.ToString("hh:mm tt") + " A " + lCaleHorario.HORA_FIN.ToString("hh:mm tt")
                    Else
                        sHorario = sHorario + " Y DE " + lCaleHorario.HORA_INI.ToString("hh:mm tt") + " A " + lCaleHorario.HORA_FIN.ToString("hh:mm tt")
                    End If
                    dTotalMinutos += lCaleHorario.MINUTOS
                Next
                lCaleFecha.HORARIO = sHorario.ToUpper
                lCaleFecha.MINUTOS = dTotalMinutos

                'Si la fecha existe en listado actualizar sino agregar
                If existeFechaEnProgra Then
                    If listaCaleFecha IsNot Nothing AndAlso listaCaleFecha.Count > 0 Then
                        For i As Integer = 0 To listaCaleFecha.Count - 1
                            If listaCaleFecha(i).FECHA = fAux Then
                                listaCaleFecha(i) = lCaleFecha
                                Exit For
                            End If
                        Next
                    End If
                Else
                    listaCaleFecha.Add(lCaleFecha)
                End If
            End If

            fAux = fAux.AddDays(1)
        End While

        Me.LISTA_CALE_FECHA = listaCaleFecha
        Me.ReCargarDetalleProgramacion()

        Me.dteFechaInicio.Value = Nothing
        Me.dteFechaInicio.Text = ""
        Me.dteFechaFinalizacion.Value = Nothing
        Me.dteFechaFinalizacion.Text = ""
        Me.chkLunes.Checked = False
        Me.chkMartes.Checked = False
        Me.chkMiercoles.Checked = False
        Me.chkJueves.Checked = False
        Me.chkViernes.Checked = False
        Me.chkSabado.Checked = False
        Me.chkDomingo.Checked = False
        Me.tmeHoraInicio.Value = Nothing
        Me.tmeHoraFin.Value = Nothing
    End Sub

    Private Function EsHorarioEnConflicto(ByVal lista As listaCALE_FECHA, ByVal pFecha As Date, ByVal pHoraIni As Date, ByVal pHoraFin As Date) As Boolean
        Dim listaHorario As listaCALE_HORARIO

        If lista IsNot Nothing AndAlso lista.Count > 0 Then

            For i As Integer = 0 To lista.Count - 1
                If lista(i).FECHA = pFecha Then
                    listaHorario = lista(i).fkHORARIO
                    If listaHorario IsNot Nothing AndAlso listaHorario.Count > 0 Then

                        For j As Integer = 0 To listaHorario.Count - 1
                            If (listaHorario(j).HORA_INI <= pHoraIni AndAlso pHoraIni <= listaHorario(j).HORA_FIN) OrElse _
                                (listaHorario(j).HORA_INI <= pHoraFin AndAlso pHoraFin <= listaHorario(j).HORA_FIN) Then
                                Return True
                            End If
                        Next
                    End If
                End If
            Next
        End If

        Return False
    End Function

    Public Sub ReCargarDetalleProgramacion()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCALE_FECHA1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.ActualizarResumenProgramacion()
        End If
    End Sub

    Private Sub CargarMunicipioEjecucion()
        cbxMUNICIPIO_EJECUCION.SelectedIndex = -1
        odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = Me.cbxDEPARTAMENTO_EJECUCION.Value
        cbxMUNICIPIO_EJECUCION.DataBind()
    End Sub

    Private Sub ActualizarResumenProgramacion()
        Dim lista As listaCALE_FECHA = Me.LISTA_CALE_FECHA
        Dim fIni As Date
        Dim fFin As Date
        Dim totalMinutos As Integer = 0

        Me.lblFechaInicioReal.Text = ""
        Me.lblFechaFinalizacionReal.Text = ""
        Me.lblHorasTotales.Text = ""
        Me.lblHorario.Text = ""

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                If i = 0 Then fIni = lista(i).FECHA
                If i = lista.Count - 1 Then fFin = lista(i).FECHA
                totalMinutos += lista(i).MINUTOS
            Next

            Me.lblFechaInicioReal.Text = fIni.ToString("dd/MM/yyyy")
            Me.lblFechaFinalizacionReal.Text = fFin.ToString("dd/MM/yyyy")

            If totalMinutos < 60 Then
                Me.lblHorasTotales.Text = "0:" + Format(totalMinutos, "0#")
            Else
                Me.lblHorasTotales.Text = Format(Math.Truncate(totalMinutos / 60), "0") + ":" + Format(totalMinutos Mod 60, "0#")
            End If
            Me.lblHorario.Text = ExpresionHorarioReal()
        End If
    End Sub

    Private Function TotalMinutosCalendarizacion() As Decimal
        Dim lista As listaCALE_FECHA = Me.LISTA_CALE_FECHA
        Dim totalMinutos As Decimal = 0

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                totalMinutos += lista(i).MINUTOS
            Next
        End If

        Return totalMinutos
    End Function

    Private Function ExpresionHorarioReal() As String
        Dim tblTodosHorarios As New DataTable
        Dim tblFechasHorarios As New DataTable
        Dim tblHorarios As New DataTable

        Dim lResult As New StringBuilder
        Dim Condicion As New StringBuilder
        Dim Id As Decimal = 1
        Dim listaFechas As listaCALE_FECHA = Me.LISTA_CALE_FECHA

        With tblTodosHorarios.Columns
            .Add("ID", System.Type.GetType("System.Decimal"))
            .Add("FECHA", System.Type.GetType("System.DateTime"))
            .Add("EXPHORARIO", System.Type.GetType("System.String"))
        End With

        With tblFechasHorarios.Columns
            .Add("ID", System.Type.GetType("System.Decimal"))
            .Add("EXPFECHA", System.Type.GetType("System.String"))
            .Add("EXPHORARIO", System.Type.GetType("System.String"))
        End With

        '   ***************************************************************
        '   Llenar DataTable (tblHorarios) con todos los horarios existentes
        For Each lFecha As CALE_FECHA In listaFechas
            Dim fila As DataRow = tblTodosHorarios.NewRow
            fila("ID") = Id
            fila("FECHA") = lFecha.FECHA
            fila("EXPHORARIO") = lFecha.HORARIO
            tblTodosHorarios.Rows.Add(fila)
            Id += 1
        Next

        Id = 1
        For Each dr As DataRow In tblTodosHorarios.Select("ID > 0", "FECHA ASC")
            Dim dtrResult As DataRow()
            Dim fechaAnterior As Date = #12:00:00 AM#
            Dim expresionFecha As New StringBuilder

            'Obtener todas las fechas que aplican al horario obtenido siempre que no exista el horario en: tblFechasHorarios
            Condicion = New StringBuilder
            Condicion.Append("EXPHORARIO = '")
            Condicion.Append(dr("EXPHORARIO"))
            Condicion.Append("'")

            If tblFechasHorarios.Select(Condicion.ToString, "ID ASC").Length = 0 Then
                dtrResult = tblTodosHorarios.Select(Condicion.ToString, "FECHA ASC")
                For Each fila As DataRow In dtrResult
                    Dim estaFecha As Date = CDate(fila("FECHA"))
                    If fechaAnterior = #12:00:00 AM# Then
                        expresionFecha.Append(estaFecha.Day.ToString)
                    ElseIf fechaAnterior.Month = estaFecha.Month Then
                        expresionFecha.Append(",")
                        expresionFecha.Append(estaFecha.Day.ToString)
                    Else
                        expresionFecha.Append(" ")
                        expresionFecha.Append(fechaAnterior.ToString("MMMM/yy").ToUpper)
                        expresionFecha.Append(", ")
                        expresionFecha.Append(estaFecha.Day.ToString)
                    End If
                    fechaAnterior = estaFecha
                Next
                expresionFecha.Append(" ")
                expresionFecha.Append(fechaAnterior.ToString("MMMM/yy").ToUpper)

                Dim drFechasHorarios As DataRow = tblFechasHorarios.NewRow
                drFechasHorarios("ID") = Id
                drFechasHorarios("EXPFECHA") = expresionFecha.ToString
                drFechasHorarios("EXPHORARIO") = dr("EXPHORARIO")

                tblFechasHorarios.Rows.Add(drFechasHorarios)
                Id += 1
            End If
        Next
        For Each fila As DataRow In tblFechasHorarios.Rows
            lResult.Append(fila("EXPFECHA"))
            lResult.Append(" ")
            lResult.AppendLine(fila("EXPHORARIO") + " ")
        Next

        Return lResult.ToString.Trim
    End Function

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.LISTA_CALE_FECHA = New listaCALE_FECHA
        Me.ReCargarDetalleProgramacion()
    End Sub

    Private Function ObtenerIdFecha(ByVal lista As listaCALE_FECHA) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CALE > Id Then
                Id = lista(i).ID_CALE
            End If
        Next
        Return (Id + 1)
    End Function

    Private Function ObtenerIdHorario(ByVal lista As listaCALE_HORARIO) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_HORA > Id Then
                Id = lista(i).ID_HORA
            End If
        Next
        Return (Id + 1)
    End Function

    Protected Sub cbxDEPARTAMENTO_EJECUCION_ValueChanged(sender As Object, e As EventArgs) Handles cbxDEPARTAMENTO_EJECUCION.ValueChanged
        CargarMunicipioEjecucion()
    End Sub

    Protected Sub ucListaCALE_FECHA1_Eliminado(ID_CALE As Decimal) Handles ucListaCALE_FECHA1.Eliminado
        Me.ReCargarDetalleProgramacion()
    End Sub


    Public ReadOnly Property CodigoGrupo As String
        Get
            If Me.ViewState("CodigoGrupo") Is Nothing Then
                Return ""
            Else
                Return Me.ViewState("CodigoGrupo")
            End If
        End Get
    End Property


    Public Function Actualizar() As String
        Me.ViewState("CodigoGrupo") = ""

        Dim sError As New String("")
        Dim alDatos As New ArrayList

        Dim bAccionFormativa As New cACCION_FORMATIVA
        Dim bAccionDetalle As New cACCION_FORMATIVA_DETALLE
        Dim lAccionFormativa As ACCION_FORMATIVA
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE
        Dim lAccionGrupoSele As GRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(Me.ID_GRUPO_SELEC)
        Dim lAccionContratada As ACCION_CONTRATADA
        Dim bAccionContratada As New cACCION_CONTRATADA
        Dim lContrato As CONTRATO_BOLPROS
        Dim listaSolicitudes As listaSOLICITUD_PRESELECCION_EC
        Dim lSolicitudIns As SOLICITUD_INSCRIPCION_AF
        Dim bSolicitudIns As New cSOLICITUD_INSCRIPCION_AF
        Dim lSolicitudEC As SOLICITUD_INSCRIPCION_EC
        Dim bSolicitudEC As New cSOLICITUD_INSCRIPCION_EC

        Dim lPartiAF As PARTICIPANTE_AF
        Dim bPartiAF As New cPARTICIPANTE_AF

        Dim lTermino As TERMINO_REFERENCIA_AF
        Dim bTermino As New cTERMINO_REFERENCIA_AF

        Dim lstGrupoAccion As listaGRUPO_ACCION_CONTRATADA
        Dim lGrupoAccion As GRUPO_ACCION_CONTRATADA
        Dim bGrupoAccion As New cGRUPO_ACCION_CONTRATADA
        Dim totalInscritos As Decimal = 0

        If Me.txtDURACION.Text = "" Then
            sError = "Ingrese la duracion"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.LISTA_CALE_FECHA Is Nothing OrElse Me.LISTA_CALE_FECHA.Count = 0 Then
            sError = "Ingrese la calendarizacion del grupo"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.TotalMinutosCalendarizacion <> (CDec(Me.txtDURACION.Value) * 60) Then
            sError = "Las horas calendarizadas deben coincidir con la duracion"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.txtLUGAR_EJECUCION.Text = "" Then
            sError = "Ingrese el lugar de ejecución"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.cbxDEPARTAMENTO_EJECUCION.Value Is Nothing Then
            sError = "Ingrese el departamento de ejecucion"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.cbxMUNICIPIO_EJECUCION.Value Is Nothing Then
            sError = "Ingrese el municipio de ejecucion"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If
        If Me.txtNOMBRE_FORMADOR.Text = "" Then
            sError = "Ingrese el nombre del formador"
            RaiseEvent Mensaje(sError, True)
            Return sError
        End If

        If lAccionGrupoSele IsNot Nothing Then
            lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lAccionGrupoSele.ID_ACCION_CONTRATADA)
            If lAccionContratada IsNot Nothing Then
                lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)

                If lContrato IsNot Nothing Then

                    If Me.LISTA_CALE_FECHA(0).FECHA < lContrato.FECHA_INI_EJEC OrElse Me.LISTA_CALE_FECHA(Me.LISTA_CALE_FECHA.Count - 1).FECHA > lContrato.FECHA_FIN_EJEC Then
                        sError = "La fecha de inicio y finalizacion deben estar comprendidas dentro del periodo de ejecucion del contrato. El periodo de ejecucion del contrato es del " + _
                                lContrato.FECHA_INI_EJEC.ToString("dd/MM/yyyy") + " al " + lContrato.FECHA_FIN_EJEC.ToString("dd/MM/yyyy")
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    If Me.LISTA_CALE_FECHA(0).FECHA < lAccionGrupoSele.FECHA_INICIO OrElse Me.LISTA_CALE_FECHA(Me.LISTA_CALE_FECHA.Count - 1).FECHA > lAccionGrupoSele.FECHA_FIN Then
                        sError = "La fecha de inicio y finalizacion deben estar comprendidas dentro del periodo de ejecucion del grupo. El periodo de ejecucion del grupo es del " + _
                                lAccionGrupoSele.FECHA_INICIO.ToString("dd/MM/yyyy") + " al " + lAccionGrupoSele.FECHA_FIN.ToString("dd/MM/yyyy")
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    'Ingresar en ACCION_FORMATIVA
                    lAccionFormativa = New ACCION_FORMATIVA
                    lAccionFormativa.ID_ACCION_FORMATIVA = 0
                    lAccionFormativa.ID_OFERTA_FORMATIVA = -1
                    lAccionFormativa.ID_SITIO_CAPACITACION = -1
                    lAccionFormativa.ID_PROVEEDOR_AF = lContrato.ID_PROVEEDOR_AF
                    lAccionFormativa.ID_TEMA_CURSO = ObtenerIdTemaCurso(lAccionContratada.ID_ACCION_CONTRATADA)
                    lAccionFormativa.ID_EJERCICIO = Me.LISTA_CALE_FECHA(0).FECHA.Year
                    lAccionFormativa.NOMBRE_ACCION_FORMATIVA = txtNOMBRE_ACCION_FORMATIVA.Text.ToUpper
                    lAccionFormativa.CODIGO_GRUPO = lAccionGrupoSele.CODIGO + "-" + CStr(bAccionFormativa.ObtenerCorrelativoCodigoEC(lAccionGrupoSele.CODIGO + "-"))
                    lAccionFormativa.NUMERO_PARTICIPANTES = 20
                    lAccionFormativa.PARTICIPANTES_INSCRITOS = 0
                    lAccionFormativa.FECHA_INICIO = Me.LISTA_CALE_FECHA(0).FECHA
                    lAccionFormativa.FECHA_FIN = Me.LISTA_CALE_FECHA(Me.LISTA_CALE_FECHA.Count - 1).FECHA
                    lAccionFormativa.HORARIO = lblHorario.Text.ToUpper
                    lAccionFormativa.NOTAS = ""
                    lAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula
                    lAccionFormativa.DURACION_HORAS = Me.txtDURACION.Value
                    lAccionFormativa.COSTO_X_PARTICIPANTE = lAccionContratada.COSTO_PARTICIPANTE
                    lAccionFormativa.LASTUPDATE = Now
                    lAccionFormativa.USERID = Me.ObtenerUsuario
                    lAccionFormativa.FECHA_INICIO_REAL = Me.LISTA_CALE_FECHA(0).FECHA
                    lAccionFormativa.FECHA_FIN_REAL = Me.LISTA_CALE_FECHA(Me.LISTA_CALE_FECHA.Count - 1).FECHA
                    lAccionFormativa.OBSERVACIONES = ""
                    lAccionFormativa.ID_ACCION_CONTRATADA = -1
                    lAccionFormativa.CODI_FORMADOR = txtCODI_FORMADOR.Text
                    lAccionFormativa.NOMBRE_FORMADOR = txtNOMBRE_FORMADOR.Text.ToUpper
                    If bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa) <= 0 Then
                        sError = "No se logro registrar la accion formativa. " + bAccionFormativa.sError
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    Me.ViewState("CodigoGrupo") = lAccionFormativa.CODIGO_GRUPO

                    'Asignar el ID_ACCION_CONTRATADA una vez creado el curso para evitar generación automática de tablas auxiliares
                    lAccionFormativa.ID_ACCION_CONTRATADA = lAccionContratada.ID_ACCION_CONTRATADA
                    bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa)

                    'Ingresar en ACCION_FORMATIVA_DETALLE
                    lAccionDetalle = New ACCION_FORMATIVA_DETALLE
                    lAccionDetalle.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                    lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                    lAccionDetalle.ID_MODALIDAD_FORMACION = 1
                    lAccionDetalle.ID_CONTRATO = -1
                    lAccionDetalle.ID_FUENTE = -1
                    lAccionDetalle.NO_CONVOCATORIA = -1
                    lAccionDetalle.CODIGO_DEPARTAMENTO = Me.cbxDEPARTAMENTO_EJECUCION.Value
                    lAccionDetalle.CODIGO_MUNICIPIO = Me.cbxMUNICIPIO_EJECUCION.Value
                    lAccionDetalle.LUGAR_EJECUCION = Me.txtLUGAR_EJECUCION.Text.Trim.ToUpper
                    lAccionDetalle.TELEFONO = ""
                    lAccionDetalle.CONTACTO = ""
                    lAccionDetalle.USERID = Me.ObtenerUsuario
                    lAccionDetalle.LASTUPDATE = Now
                    lAccionDetalle.ID_GRUPO_SELEC = Me.ID_GRUPO_SELEC
                    If bAccionDetalle.AgregarACCION_FORMATIVA_DETALLE(lAccionDetalle) <= 0 Then
                        sError = "No se logro registrar la informacion complementaria del grupo."
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    'Ingresar TDR
                    lTermino = New TERMINO_REFERENCIA_AF
                    lTermino.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                    If lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                        lTermino.TDR = lContrato.NUM_CONTRATO + "-" + lAccionContratada.NUM_ITEM.ToString
                        lTermino.RESOLUCION = "C" + lContrato.NUM_CONTRATO + " I" + lAccionContratada.NUM_ITEM.ToString
                    Else
                        lTermino.TDR = lContrato.NUM_CONTRATO
                        lTermino.RESOLUCION = lContrato.NUM_CONTRATO
                    End If
                    lTermino.MONTO_ADJUDICADO = Math.Round(lAccionContratada.MONTO / lAccionContratada.CANT_CURSOS, 6)
                    lTermino.USERID = Me.ObtenerUsuario
                    lTermino.LASTUPDATE = Now
                    lTermino.CORRELATIVO_GRUPO = -1
                    lTermino.ID_SOLICITUD = -1
                    If bTermino.AgregarTERMINO_REFERENCIA_AF(lTermino) <= 0 Then
                        sError = "No se logro registrar el termino de referencia."
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    'Ingresar GRUPO ACCION
                    lGrupoAccion = New GRUPO_ACCION_CONTRATADA
                    lGrupoAccion.ID_GRUPO_ACCION = 0
                    lGrupoAccion.ID_ACCION_CONTRATADA = lAccionContratada.ID_ACCION_CONTRATADA
                    lGrupoAccion.ID_GRUPO_AF = -1
                    lGrupoAccion.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                    lGrupoAccion.USUARIO_CREACION = Me.ObtenerUsuario
                    lGrupoAccion.FECHA_CREACION = Now
                    lGrupoAccion.USERID = Me.ObtenerUsuario
                    lGrupoAccion.LASTUPDATE = Now
                    lGrupoAccion.MONTO = Math.Round(lAccionContratada.MONTO / lAccionContratada.CANT_CURSOS, 6)
                    lGrupoAccion.HABILITADO = 1
                    If bGrupoAccion.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAccion) <= 0 Then
                        sError = "No se logro registrar el grupo accion formativa."
                        RaiseEvent Mensaje(sError, True)
                        Return sError
                    End If

                    lstGrupoAccion = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(lAccionContratada.ID_ACCION_CONTRATADA)
                    If lstGrupoAccion IsNot Nothing Then
                        lAccionContratada.CANT_CURSOS = lstGrupoAccion.Count
                        bAccionContratada.ActualizarACCION_CONTRATADA(lAccionContratada)
                    End If

                    'Ingresar en SOLICITUD_INSCRIPCION_AF
                    listaSolicitudes = (New cSOLICITUD_PRESELECCION_EC).ObtenerListaPorGRUPO_SELECCION(Me.ID_GRUPO_SELEC)

                    If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
                        For Each lSoliEC As SOLICITUD_PRESELECCION_EC In listaSolicitudes

                            If lSoliEC.ID_TIPO_SELECC = Enumeradores.TipoSeleccionEC.Titular OrElse _
                                lSoliEC.ID_TIPO_SELECC = Enumeradores.TipoSeleccionEC.Suplente Then

                                lSolicitudIns = New SOLICITUD_INSCRIPCION_AF
                                lSolicitudIns.ID_SOLICITUD = 0
                                lSolicitudIns.FECHA_PRESENTACION = lAccionFormativa.FECHA_INICIO_REAL
                                lSolicitudIns.ID_PARTICIPANTE = lSoliEC.ID_PARTICIPANTE
                                lSolicitudIns.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                                lSolicitudIns.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
                                lSolicitudIns.NOMBRES = lSoliEC.NOMBRES
                                lSolicitudIns.APELLIDOS = lSoliEC.APELLIDOS
                                lSolicitudIns.DUI = lSoliEC.DUI
                                lSolicitudIns.TIPO_DOCTO = lSoliEC.TIPO_DOCTO
                                lSolicitudIns.NUM_DOCTO = lSoliEC.NUM_DOCTO
                                lSolicitudIns.NIT = lSoliEC.NIT
                                lSolicitudIns.ISSS = lSoliEC.ISSS
                                lSolicitudIns.ID_TIPO_SOLICITUD = Enumeradores.TipoSolicitud.EMPRESA_CENTRO
                                lSolicitudIns.ID_PAIS = lSoliEC.ID_PAIS
                                lSolicitudIns.DEPARTAMENTO_NAC = lSoliEC.DEPARTAMENTO_NAC
                                lSolicitudIns.MUNICIPIO_NAC = lSoliEC.MUNICIPIO_NAC
                                lSolicitudIns.FECHA_NACIMIENTO = lSoliEC.FECHA_NACIMIENTO
                                lSolicitudIns.GENERO = lSoliEC.GENERO
                                lSolicitudIns.EDAD = lSoliEC.EDAD
                                lSolicitudIns.MIEMBROS_GRUPO_FAMILIAR = lSoliEC.MIEMBROS_GRUPO_FAMILIAR
                                lSolicitudIns.ID_ESTADO_CIVIL = lSoliEC.ID_ESTADO_CIVIL
                                lSolicitudIns.ES_JEFE_HOGAR = lSoliEC.ES_JEFE_HOGAR
                                lSolicitudIns.TIENE_HIJOS = lSoliEC.TIENE_HIJOS
                                lSolicitudIns.NO_DE_HIJOS = lSoliEC.NO_DE_HIJOS
                                lSolicitudIns.SE_DEDICA_ALGUNA_PROFESION = lSoliEC.SE_DEDICA_ALGUNA_PROFESION
                                lSolicitudIns.PROFESION_OFICIO = lSoliEC.PROFESION_OFICIO
                                lSolicitudIns.DIRECCION = lSoliEC.DIRECCION
                                lSolicitudIns.CODIGO_DEPARTAMENTO = lSoliEC.CODIGO_DEPARTAMENTO
                                lSolicitudIns.CODIGO_MUNICIPIO = lSoliEC.CODIGO_MUNICIPIO
                                lSolicitudIns.TELEFONO = lSoliEC.TELEFONO
                                lSolicitudIns.MOVIL = lSoliEC.MOVIL
                                lSolicitudIns.EMAIL = lSoliEC.EMAIL
                                lSolicitudIns.CON_DISCAPACIDAD = lSoliEC.CON_DISCAPACIDAD
                                lSolicitudIns.DISC_OTRA = lSoliEC.DISC_OTRA
                                lSolicitudIns.ID_LEE_ESCRIBE = -1
                                lSolicitudIns.ID_NIVEL_ACADEMICO = lSoliEC.ID_NIVEL_ACADEMICO
                                lSolicitudIns.OTRA_EDUCACION_FORMAL = lSoliEC.OTRA_EDUCACION_FORMAL
                                lSolicitudIns.TITULO_CERTIFICADO_OBTENIDO = lSoliEC.TITULO_CERTIFICADO_OBTENIDO
                                lSolicitudIns.ESTUDIA_ACTUALMENTE = lSoliEC.ESTUDIA_ACTUALMENTE
                                lSolicitudIns.ID_TIEMPO_DEJO_ESTUDIAR = lSoliEC.ID_TIEMPO_DEJO_ESTUDIAR
                                lSolicitudIns.RECIBIO_CURSO_ANTERIOR = lSoliEC.RECIBIO_CURSO_ANTERIOR
                                lSolicitudIns.BENEF_PROM_EMP_ACT = lSoliEC.BENEF_PROM_EMP_ACT
                                lSolicitudIns.BENEF_OBT_EMPLEO = lSoliEC.BENEF_OBT_EMPLEO
                                lSolicitudIns.BENEF_OBT_ING_EXTRA = lSoliEC.BENEF_OBT_ING_EXTRA
                                lSolicitudIns.BENEF_CAMB_EMP_X_CURSO = lSoliEC.BENEF_CAMB_EMP_X_CURSO
                                lSolicitudIns.BENEF_TRAB_CTA_PROPIA = lSoliEC.BENEF_TRAB_CTA_PROPIA
                                lSolicitudIns.BENEF_OTRO = lSoliEC.BENEF_OTRO
                                lSolicitudIns.OCUACT_TRABAJA = lSoliEC.OCUACT_TRABAJA
                                lSolicitudIns.OCUACT_ESTUDIA = lSoliEC.OCUACT_ESTUDIA
                                lSolicitudIns.OCUACT_DESOCUPADO = 0
                                lSolicitudIns.OCUACT_OFICIO_HOGAR = lSoliEC.OCUACT_OFICIO_HOGAR
                                lSolicitudIns.OCUACT_BUSCA_TRABAJO = lSoliEC.OCUACT_BUSCA_TRAB
                                lSolicitudIns.OCUACT_OTRA = lSoliEC.OCUACT_OTRA
                                lSolicitudIns.ID_TIPO_EMPLEO = -1
                                lSolicitudIns.SECTOR_EMPLEO = -1
                                lSolicitudIns.TRABAJO_ANTERIOR = lSoliEC.TRABAJO_ANTERIOR
                                lSolicitudIns.RECIBE_INGRESOS = lSoliEC.RECIBE_INGRESOS
                                lSolicitudIns.MANERA_OBT_ING_TRABAJO = lSoliEC.MANERA_OBT_ING_TRABAJO
                                lSolicitudIns.MANERA_OBT_ING_AYUDA_FAM = lSoliEC.MANERA_OBT_ING_AYUDA_FAM
                                lSolicitudIns.MANERA_OBT_ING_REMESA = lSoliEC.MANERA_OBT_ING_REMESA
                                lSolicitudIns.MANERA_OBT_ING_PENSION = 0
                                lSolicitudIns.MANERA_OBT_ING_OTRO = lSoliEC.MANERA_OBT_ING_OTRO
                                lSolicitudIns.EXPFOR_PROMOCION_EMPLEO = 0
                                lSolicitudIns.EXPFOR_CAMBIAR_EMPLEO = 0
                                lSolicitudIns.EXPFOR_OBTENER_EMPLEO = lSoliEC.EXPFOR_OBTENER_EMPLEO
                                lSolicitudIns.EXPFOR_TRABAJAR_CTA_PROPIA = lSoliEC.EXPFOR_TRABAJAR_CTA_PROPIA
                                lSolicitudIns.EXPFOR_INGRESOS_EXTRAS = lSoliEC.EXPFOR_INGRESOS_EXTRAS
                                lSolicitudIns.EXPFOR_NINGUNO = 0
                                lSolicitudIns.EXPFOR_OTRO = lSoliEC.EXPFOR_OTRO
                                lSolicitudIns.CURSO_REL_TRAB_ACTUAL = 0
                                lSolicitudIns.CURSO_REL_TRAB_NUEVO = 0
                                lSolicitudIns.NOMBRE_REFERENCIA = lSoliEC.NOMBRE_REFERENCIA
                                lSolicitudIns.ID_REFERENCIA = lSoliEC.ID_REFERENCIA
                                lSolicitudIns.EXPFOR_OTRO = lSoliEC.EXPFOR_OTRO
                                lSolicitudIns.CURSO_REL_TRAB_ACTUAL = 0
                                lSolicitudIns.CURSO_REL_TRAB_NUEVO = 0
                                lSolicitudIns.NOMBRE_REFERENCIA = lSoliEC.NOMBRE_REFERENCIA
                                lSolicitudIns.ID_REFERENCIA = lSoliEC.ID_REFERENCIA
                                lSolicitudIns.DIRECCION_REFERENCIA = lSoliEC.DIRECCION_REFERENCIA
                                lSolicitudIns.DEPARTAMENTO_REFERENCIA = lSoliEC.DEPARTAMENTO_REFERENCIA
                                lSolicitudIns.MUNICIPIO_REFERENCIA = lSoliEC.MUNICIPIO_REFERENCIA
                                lSolicitudIns.TELEFONO_REFERENCIA = lSoliEC.TELEFONO_REFERENCIA
                                lSolicitudIns.MOVIL_REFERENCIA = lSoliEC.MOVIL_REFERENCIA
                                lSolicitudIns.EMAIL_REFERENCIA = lSoliEC.EMAIL_REFERENCIA
                                lSolicitudIns.SUGERENCIAS = lSoliEC.SUGERENCIAS
                                lSolicitudIns.USERID = Me.ObtenerUsuario
                                lSolicitudIns.LASTUPDATE = Now
                                lSolicitudIns.TIPO_EMPLEO_OTRO = ""

                                bSolicitudIns.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitudIns)
                                totalInscritos += 1

                                lSolicitudEC = New SOLICITUD_INSCRIPCION_EC
                                lSolicitudEC.ID_SOLICITUD = lSolicitudIns.ID_SOLICITUD
                                lSolicitudEC.ID_SOLIC_PRESELEC = lSoliEC.ID_SOLIC_PRESELEC
                                lSolicitudEC.ID_ACTI_ECONOMICA = lSoliEC.ID_ACTI_ECONOMICA
                                lSolicitudEC.ID_AREA_EMPRESA = lSoliEC.ID_AREA_EMPRESA
                                lSolicitudEC.ID_GRUPO_SELEC = lSoliEC.ID_GRUPO_SELEC
                                lSolicitudEC.ID_INGRESO_MES = lSoliEC.ID_INGRESO_MES
                                lSolicitudEC.ID_MOTIVO_DEJO_ESTU = lSoliEC.ID_MOTIVO_DEJO_ESTU
                                lSolicitudEC.ID_MOTIVO_DEJO_TRAB = lSoliEC.ID_MOTIVO_DEJO_TRAB
                                lSolicitudEC.ID_TIEMPO_NOTRAB = lSoliEC.ID_TIEMPO_NOTRAB
                                lSolicitudEC.ID_TIPO_SELECC = lSoliEC.ID_TIPO_SELECC
                                lSolicitudEC.ID_ULT_SALARIO_MES = lSoliEC.ID_ULT_SALARIO_MES
                                lSolicitudEC.MANERA_OBT_ING_BECA = lSoliEC.MANERA_OBT_ING_BECA
                                lSolicitudEC.MOTIVO_ELIGIO_CARRERA = lSoliEC.MOTIVO_ELIGIO_CARRERA
                                lSolicitudEC.OCUACT_ESTU_TRAB = lSoliEC.OCUACT_ESTU_TRAB
                                lSolicitudEC.OTRO_MOTIVO_DEJO_ESTU = lSoliEC.OTRO_MOTIVO_DEJO_ESTU
                                lSolicitudEC.USUARIO_CREA = Me.ObtenerUsuario
                                lSolicitudEC.USUARIO_ACT = Me.ObtenerUsuario
                                lSolicitudEC.FECHA_ACT = Now
                                lSolicitudEC.FECHA_CREACION = Now

                                bSolicitudEC.AgregarSOLICITUD_INSCRIPCION_EC(lSolicitudEC)

                                lPartiAF = New PARTICIPANTE_AF
                                lPartiAF.ID_PARTICIPANTE = lSoliEC.ID_PARTICIPANTE
                                lPartiAF.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                                lPartiAF.ID_SOLICITUD = lSolicitudIns.ID_SOLICITUD
                                lPartiAF.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Inscrito
                                lPartiAF.FECHA_INSCRIPCION = lAccionFormativa.FECHA_INICIO_REAL
                                lPartiAF.NOTA_FINAL = -1
                                lPartiAF.PORC_ASISTENCIA = 100
                                lPartiAF.ENTREGA_DIPLOMA = 0
                                lPartiAF.NOTAS = 0
                                lPartiAF.USERID = Me.ObtenerUsuario
                                lPartiAF.LASTUPDATE = Now
                                lPartiAF.ES_CAPACITADO = 1

                                bPartiAF.AgregarPARTICIPANTE_AF(lPartiAF)
                            End If
                        Next
                    End If

                    'Actualizar cantidad de inscritos
                    lAccionFormativa.NUMERO_PARTICIPANTES = totalInscritos
                    lAccionFormativa.PARTICIPANTES_INSCRITOS = totalInscritos
                    bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa)


                    ' ================================== ASISTENCIA ============================

                    Dim lstCaleFechas As listaCALE_FECHA = LISTA_CALE_FECHA
                    Dim lstCaleHoras As listaCALE_HORARIO
                    Dim bAsistencia As New cASISTENCIA_AF
                    Dim lAsistencia As ASISTENCIA_AF
                    Dim bAsistenciaHorario As New cASISTENCIA_AF_HORARIO
                    Dim lAsistenciaHorario As ASISTENCIA_AF_HORARIO

                    'Ingresar en ASISTENCIA_AF
                    If lstCaleFechas IsNot Nothing AndAlso lstCaleFechas.Count > 0 Then
                        For Each lEntidad As CALE_FECHA In lstCaleFechas

                            lAsistencia = New ASISTENCIA_AF
                            lAsistencia.ID_ASISTENCIA_AF = 0
                            lAsistencia.FECHA = lEntidad.FECHA
                            lAsistencia.ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                            lAsistencia.INSTRUCTOR = ""
                            lAsistencia.NOTAS = ""
                            lAsistencia.LASTUPDATE = Now
                            lAsistencia.USERID = Me.ObtenerUsuario
                            lAsistencia.CANTIDAD_HORAS = lEntidad.MINUTOS

                            bAsistencia.ActualizarASISTENCIA_AF(lAsistencia)


                            'Ingresar en ASISTENCIA_AF_HORARIO
                            If lEntidad.fkHORARIO IsNot Nothing AndAlso lEntidad.fkHORARIO.Count > 0 Then

                                lstCaleHoras = lEntidad.fkHORARIO
                                For Each lHorario As CALE_HORARIO In lstCaleHoras

                                    lAsistenciaHorario = New ASISTENCIA_AF_HORARIO
                                    lAsistenciaHorario.ID_ASISTENCIA_AF_HORARIO = 0
                                    lAsistenciaHorario.ID_ASISTENCIA_AF = lAsistencia.ID_ASISTENCIA_AF
                                    lAsistenciaHorario.HORA_INICIO = lHorario.HORA_INI
                                    lAsistenciaHorario.HORA_FIN = lHorario.HORA_FIN
                                    lAsistenciaHorario.CANTIDAD_MINUTOS = lHorario.MINUTOS
                                    bAsistenciaHorario.ActualizarASISTENCIA_AF_HORARIO(lAsistenciaHorario)
                                Next
                            End If
                        Next
                    End If

                    If Me.Nuevo Then
                        RaiseEvent Mensaje("Se ha realizado la calendarizacion del grupo. El codigo asignado es: " + lAccionFormativa.CODIGO_GRUPO, True)
                    End If
                End If
            End If
        End If

        Return ""
    End Function

    Private Function ObtenerIdTemaCurso(ByVal ID_ACCION_CONTRATADA As Decimal) As Decimal
        Dim idTemaCurso As Decimal = -1
        Dim lAccionContra As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(ID_ACCION_CONTRATADA)

        If lAccionContra IsNot Nothing Then

            Dim listaTemas As listaCURSO_TEMA = (New cCURSO_TEMA).ObtenerListaPorCODIGO_PROGRAMA(lAccionContra.CODIGO_PROGRAMA)
            If listaTemas IsNot Nothing AndAlso listaTemas.Count > 0 Then
                'Tema curso existe
                For i As Integer = 0 To listaTemas.Count - 1
                    If Utilerias.QuitarAcentos(listaTemas(i).TEMA_CURSO.Trim.ToUpper) = Utilerias.QuitarAcentos(lAccionContra.NOMBRE_ACCION_FORMATIVA.Trim.ToUpper) Then
                        idTemaCurso = listaTemas(i).ID_TEMA_CURSO
                        Exit For
                    End If
                Next
            End If

            'No existe tema curso
            If idTemaCurso = -1 Then
                Dim lCursoTema As New CURSO_TEMA
                Dim bCursoTema As New cCURSO_TEMA
                Dim lPrograma As SIFP.EL.Programas

                lCursoTema.ID_AREA_FORMACION = -1

                lPrograma = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccionContra.CODIGO_PROGRAMA.Trim)
                If lPrograma IsNot Nothing Then
                    Dim lArea As SIFP.EL.Areas
                    Dim bAreaFormacion As New cAREA_FORMACION
                    Dim lstAreaFormacion As listaAREA_FORMACION

                    lArea = (New SIFP.BL.cAreas).ObtenerAreas(lPrograma.codigo_area)
                    If lArea IsNot Nothing Then
                        'Verificar si existe el area formativa
                        lstAreaFormacion = (New cAREA_FORMACION).ObtenerListaPorNOMBRE(lArea.descripcion)
                        If lstAreaFormacion IsNot Nothing AndAlso lstAreaFormacion.Count > 0 Then
                            lCursoTema.ID_AREA_FORMACION = lstAreaFormacion(0).ID_AREA_FORMACION
                        Else
                            'Crear Area
                            Dim lAreaFormacion As New AREA_FORMACION
                            lAreaFormacion.ID_AREA_FORMACION = 0
                            lAreaFormacion.AREA_FORMACION = lArea.descripcion.Trim.ToUpper
                            lAreaFormacion.NOTAS = Nothing
                            lAreaFormacion.CODIGO_AREA = lArea.codigo_area.Trim
                            lAreaFormacion.USERID = Me.ObtenerUsuario
                            lAreaFormacion.LASTUPDATE = Now

                            bAreaFormacion.ActualizarAREA_FORMACION(lAreaFormacion)
                            lCursoTema.ID_AREA_FORMACION = lAreaFormacion.ID_AREA_FORMACION
                        End If
                    End If

                End If

                'Crear tema curso
                lCursoTema.ID_TEMA_CURSO = 0
                lCursoTema.ID_SUBAREA_FORMACION = -1
                lCursoTema.TEMA_CURSO = Me.txtNOMBRE_ACCION_FORMATIVA.Text.ToUpper
                lCursoTema.DURACION_HORAS = lAccionContra.DURACION
                lCursoTema.FECHA_ACREDITACION = Today
                lCursoTema.NOTAS = ""
                lCursoTema.CODIGO_PROGRAMA = lAccionContra.CODIGO_PROGRAMA.Trim
                lCursoTema.REF_ID_TEMA_CURSO = -1
                lCursoTema.USERID = Me.ObtenerUsuario
                lCursoTema.LASTUPDATE = Now

                bCursoTema.ActualizarCURSO_TEMA(lCursoTema)
                idTemaCurso = lCursoTema.ID_TEMA_CURSO
            End If
        End If

        Return idTemaCurso
    End Function


    Protected Sub txtCODI_FORMADOR_ValueChanged(sender As Object, e As EventArgs) Handles txtCODI_FORMADOR.ValueChanged
        Me.txtNOMBRE_FORMADOR.Text = ""

        If Me.txtCODI_FORMADOR.Text.Trim <> "" Then
            Dim lSrvFormadores As New ServicioFORMADOREScliente.ServicioFORMADORESClient
            Dim lEntidad As New ServicioFORMADOREScliente.FORMADOR

            lEntidad = lSrvFormadores.ObtenerFORMADOR_PorNIT(Me.txtCODI_FORMADOR.Text)
            If lEntidad IsNot Nothing Then
                If lEntidad.ID_ESTADO_FORMA <> 1 Then
                    RaiseEvent Mensaje("El Formador " + lEntidad.NOMBRES + " " + lEntidad.APELLIDOS + " con numero de NIT: " + Utilerias.FormatearNIT(Me.txtCODI_FORMADOR.Text.Trim) + " no esta acreditado", True)
                    Me.txtCODI_FORMADOR.Text = ""
                    Return
                End If
                Me.txtNOMBRE_FORMADOR.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            Else
                RaiseEvent Mensaje("No existe Formador con numero de NIT: " + Utilerias.FormatearNIT(Me.txtCODI_FORMADOR.Text.Trim), True)
                Me.txtCODI_FORMADOR.Text = ""
            End If
        End If
    End Sub
End Class
