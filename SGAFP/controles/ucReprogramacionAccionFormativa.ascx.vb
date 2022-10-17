Imports System.Collections.Generic
Imports System.Text.StringBuilder
Imports System.Data
Imports SGAFP.DL.DS_DL

Partial Class controles_ucReProgramacionAccionFormativa
    Inherits ucBase


#Region " Propiedades "
    Dim _dtASISTENCIA_AF_REPROG As New ASISTENCIA_AF_REPROGDataTable
    Public ReadOnly Property dtASISTENCIA_AF_REPROG() As ASISTENCIA_AF_REPROGDataTable
        Get
            Return _dtASISTENCIA_AF_REPROG
        End Get
    End Property

    Dim _dtASISTENCIA_AF_HORARIO_REPROG As New ASISTENCIA_AF_HORARIO_REPROGDataTable
    Public ReadOnly Property dtASISTENCIA_AF_HORARIO_REPROG() As ASISTENCIA_AF_HORARIO_REPROGDataTable
        Get
            Return _dtASISTENCIA_AF_HORARIO_REPROG
        End Get
    End Property

    Public ReadOnly Property FECHA_INICIO_REAL() As Object
        Get
            If _dtASISTENCIA_AF_REPROG.Rows.Count = 0 Then Return Nothing

            Dim FechaInicioReal As Object
            FechaInicioReal = _dtASISTENCIA_AF_REPROG.Compute("MIN(FECHA)", "ID_ASISTENCIA_AF <> -1")
            If Not IsDBNull(FechaInicioReal) Then
                Return FechaInicioReal
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property FECHA_FIN_REAL() As Object
        Get
            If _dtASISTENCIA_AF_REPROG.Rows.Count = 0 Then Return Nothing

            Dim FechaFinReal As Object
            FechaFinReal = _dtASISTENCIA_AF_REPROG.Compute("MAX(FECHA)", "ID_ASISTENCIA_AF <> -1")
            If Not IsDBNull(FechaFinReal) Then
                Return FechaFinReal
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property HORARIO_REAL() As String
        Get
            Return ExpresionHorarioReal()
        End Get
    End Property

    Dim _HORAS_TOTALES As String
    Private ReadOnly Property HORAS_TOTALES() As String
        Get
            Dim sumObject As Object

            sumObject = dtASISTENCIA_AF_HORARIO_REPROG.Compute("SUM(CANTIDAD_MINUTOS)", "ID_ASISTENCIA_AF <> -1")
            If Not IsDBNull(sumObject) Then
                Return Utilerias.ConvertirMinutosAFormatoHoras(CDec(sumObject))
            Else
                Return "0:00"
            End If
        End Get
    End Property

    Dim _MINUTOS_TOTALES As Decimal
    Public ReadOnly Property MINUTOS_TOTALES() As Decimal
        Get
            Dim sumObject As Object

            sumObject = dtASISTENCIA_AF_HORARIO_REPROG.Compute("SUM(CANTIDAD_MINUTOS)", "ID_ASISTENCIA_AF <> -1")
            If Not IsDBNull(sumObject) Then
                Return CDec(sumObject)
            Else
                Return 0
            End If
        End Get
    End Property

    Private _TieneCambios As Boolean
    Public ReadOnly Property TieneCambios() As Boolean
        Get
            Return _TieneCambios
        End Get
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal value As Boolean)
            _PermitirEditar = value
            Me.PanelParametros.Visible = value
        End Set
    End Property

    Public Sub Resaltar_FechaInicioReal(ByVal resaltar As Boolean)
        If Not resaltar Then
            Me.lblFechaInicioReal.BackColor = Drawing.Color.White
        Else
            Me.lblFechaInicioReal.BackColor = Drawing.Color.Yellow
        End If
    End Sub

    Public Sub Resaltar_FechaFinReal(ByVal resaltar As Boolean)
        If Not resaltar Then
            Me.lblFechaFinalizacionReal.BackColor = Drawing.Color.White
        Else
            Me.lblFechaFinalizacionReal.BackColor = Drawing.Color.Yellow
        End If
    End Sub

    Private Property ID_ACCION_FORMATIVA() As Decimal
        Set(ByVal value As Decimal)
            Me.ViewState("reprogIdAccionFormativa") = value
        End Set
        Get
            If Me.ViewState("reprogIdAccionFormativa") = Nothing Then Return 0 Else Return Me.ViewState("reprogIdAccionFormativa")
        End Get
    End Property

#End Region

    'Cargar DataTables por el parámetro proporcionado   

    Public Sub CargarReProgramacion(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal)
        Me._dtASISTENCIA_AF_REPROG.Clear()
        Me._dtASISTENCIA_AF_HORARIO_REPROG.Clear()

        Dim adapterAsistencia As New SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AF_REPROGTableAdapter
        adapterAsistencia.Fill(Me._dtASISTENCIA_AF_REPROG, ID_ACCION_FORMATIVA_REPROG)

        Dim adapterAsistenciaHorario As New SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AF_HORARIO_REPROGTableAdapter
        adapterAsistenciaHorario.Fill(Me._dtASISTENCIA_AF_HORARIO_REPROG, ID_ACCION_FORMATIVA_REPROG)

        Me.CargarDatos()
        Me.ActualizarVariablesProgramacion()
    End Sub

    Public Sub CargarProgramacion(ByVal ID_ACCION_FORMATIVA As Decimal)
        Me._dtASISTENCIA_AF_REPROG.Clear()
        Me._dtASISTENCIA_AF_HORARIO_REPROG.Clear()

        Dim adapterAsistencia As New SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AFTableAdapter
        Dim adapterAsistenciaHorario As New SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AF_HORARIOTableAdapter
        Dim dtAsistencia As New ASISTENCIA_AFDataTable
        Dim dtAsistenciaHorario As New ASISTENCIA_AF_HORARIODataTable

        adapterAsistencia.Fill(dtAsistencia, ID_ACCION_FORMATIVA)

        For Each fila As ASISTENCIA_AFRow In dtAsistencia
            Me._dtASISTENCIA_AF_REPROG.AddASISTENCIA_AF_REPROGRow(fila.ID_ASISTENCIA_AF, 0, fila.FECHA, fila.CANTIDAD_HORAS, fila.INSTRUCTOR, fila.NOTAS, fila.USERID, fila.LASTUPDATE)
        Next
        adapterAsistenciaHorario.Fill(dtAsistenciaHorario, ID_ACCION_FORMATIVA)

        For Each fila As ASISTENCIA_AF_HORARIORow In dtAsistenciaHorario
            Dim mDataRow As ASISTENCIA_AF_HORARIO_REPROGRow = Me._dtASISTENCIA_AF_HORARIO_REPROG.NewRow()
            mDataRow.ID_ASISTENCIA_AF = fila.ID_ASISTENCIA_AF
            mDataRow.ID_ASISTENCIA_AF_HORARIO = fila.ID_ASISTENCIA_AF_HORARIO
            mDataRow.HORA_INICIO = fila.HORA_INICIO
            mDataRow.HORA_FIN = fila.HORA_FIN
            mDataRow.CANTIDAD_MINUTOS = fila.CANTIDAD_MINUTOS

            Me._dtASISTENCIA_AF_HORARIO_REPROG.AddASISTENCIA_AF_HORARIO_REPROGRow(mDataRow)
        Next
        Me.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        Me.CargarDatos()
        Me.ActualizarVariablesProgramacion()
    End Sub

    Public Sub Limpiar()
        Me._dtASISTENCIA_AF_REPROG.Clear()
        Me._dtASISTENCIA_AF_HORARIO_REPROG.Clear()
        Session.Remove("ASISTENCIA_AF_REPROG")
        Session.Remove("ASISTENCIA_AF_HORARIO_REPROG")
        Session.Remove("TIENE_CAMBIOS")
        Me.CargarDatos()
        Me.ActualizarVariablesProgramacion()
    End Sub

    Public Function ValidarHorarioParaFormador(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal CODI_FORMADOR As String) As String
        Dim bPrograRetro As New cACCION_PROGRA_RETRO
        Dim listaPrograRetro As listaACCION_PROGRA_RETRO
        Dim sCad As New StringBuilder
        Dim ds As DataSet
        Dim bAccionFormativa As New cACCION_FORMATIVA
        Dim idAccion As Int32 = -1

        For Each _dr As ASISTENCIA_AF_REPROGRow In Me.dtASISTENCIA_AF_REPROG
            Dim Condicion As New StringBuilder

            Condicion.Append("ID_ASISTENCIA_AF = ")
            Condicion.Append(_dr.ID_ASISTENCIA_AF)

            For Each dr As ASISTENCIA_AF_HORARIO_REPROGRow In Me.dtASISTENCIA_AF_HORARIO_REPROG.Select(Condicion.ToString, "HORA_INICIO ASC")
                Dim fechaInicio As DateTime = New DateTime(_dr.FECHA.Year, _dr.FECHA.Month, _dr.FECHA.Day, dr.HORA_INICIO.Hour, dr.HORA_INICIO.Minute, 0)
                Dim fechaFin As DateTime = New DateTime(_dr.FECHA.Year, _dr.FECHA.Month, _dr.FECHA.Day, dr.HORA_FIN.Hour, dr.HORA_FIN.Minute, 0)

                ds = bAccionFormativa.ObtenerAccionFormativa_Horario_enConflictoFormador(CODI_FORMADOR, ID_ACCION_FORMATIVA, fechaInicio, fechaFin)

                If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                    Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
                    listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(lAccion.ID_PROVEEDOR_AF, _
                                                                                            lAccion.ID_EJERCICIO, _
                                                                                            lAccion.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.HorarioSimultaneoInstructor, _
                                                                                            1)
                    If listaPrograRetro IsNot Nothing AndAlso listaPrograRetro.Count > 0 Then
                        If listaPrograRetro(0).FECHA_PROGRAMO = #12:00:00 AM# Then
                            listaPrograRetro(0).ID_ACCION_FORMATIVA = lAccion.ID_ACCION_FORMATIVA
                            listaPrograRetro(0).USUARIO_PROGRAMO = lAccion.USERID
                            listaPrograRetro(0).FECHA_PROGRAMO = Now
                            listaPrograRetro(0).USERID = lAccion.USERID
                            listaPrograRetro(0).LASTUPDATE = Now
                        End If
                    Else
                        For j As Int32 = 0 To ds.Tables(0).Rows.Count - 1
                            If idAccion <> ds.Tables(0).Rows(j)("ID_ACCION_FORMATIVA") Then
                                idAccion = ds.Tables(0).Rows(j)("ID_ACCION_FORMATIVA")
                                sCad.Append("El formador imparte el curso " + ds.Tables(0).Rows(j)("NOMBRE_ACCION_FORMATIVA") + " " + ds.Tables(0).Rows(j)("CODIGO_GRUPO") + " que posee un horario simultaneo con el curso actual en la(s) fecha(s) " + vbCrLf)
                            End If
                            sCad.Append(CDate(ds.Tables(0).Rows(j)("INICIO")).ToShortDateString + " y horario de " + Format(ds.Tables(0).Rows(j)("INICIO"), "hh:mm tt") + " a " + Format(ds.Tables(0).Rows(j)("FIN"), "hh:mm tt") + vbCrLf)
                        Next
                    End If
                End If
            Next
        Next

        'TODO: Quitar validación para ofertas 140/2017 y 109/2017
        Dim lOfertaCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If lOfertaCompra IsNot Nothing AndAlso (lOfertaCompra.NO_CONTRATO_COMPRA = "140/2017" OrElse lOfertaCompra.NO_CONTRATO_COMPRA = "109/2017") Then
            Return ""
        End If

        Return sCad.ToString
    End Function

    Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles ASPxCallbackPanel1.Callback
        If e.Parameter = "Programar" Then
            If ASPxCallbackPanel1.JSProperties.ContainsKey("ASPxCallbackPanel1") Then ASPxCallbackPanel1.JSProperties.Remove("ASPxCallbackPanel1")

            'Configurar las fechas de acuerdo a la selección hecha
            Dim FechaInicial As Date = Me.dteFechaInicio.Date
            Dim FechaFinal As Date = Me.dteFechaFinalizacion.Date
            Dim FechaProc As Date = FechaInicial
            Dim HoraInicio As DateTime = Me.tmeHoraInicio.DateTime
            Dim HoraFin As DateTime = Me.tmeHoraFin.DateTime
            Dim Cantidad_Horas As Decimal = 0

            'Validar que el tiempo trasncurrido entre hora inicial y hora final sean horas completas sin minutos
            'Cantidad_Horas = DateAndTime.DateDiff(DateInterval.Minute, HoraInicio, HoraFin) / 60
            'If Cantidad_Horas - Decimal.Truncate(Cantidad_Horas) > 0 Then
            '    ASPxCallbackPanel1.JSProperties.Add("cpResultado", "El tiempo transcurrido entre la Hora Inicial y la Hora Final deben representar horas completas sin minutos")
            '    Return
            'End If

            'Validar que el nuevo horario sea válido para los días seleccionados
            While FechaProc <= FechaFinal
                If ExisteFechaEnDiaSeleccionado(FechaProc) Then
                    Dim eASISTENCIA_AF As ASISTENCIA_AF_REPROG = ObtenerASISTENCIA_AF_REPROG(FechaProc)

                    If Not eASISTENCIA_AF Is Nothing Then
                        If Not Me.EsHorarioValidoEnDia(eASISTENCIA_AF.ID_ASISTENCIA_AF, HoraInicio, HoraFin) Then
                            ASPxCallbackPanel1.JSProperties.Add("cpResultado", "El Horario seleccionado no es válido para la fecha " + eASISTENCIA_AF.FECHA.ToString("dd/MM/yyyy"))
                            Return
                        End If
                    End If
                End If
                FechaProc = FechaProc.AddDays(1)
            End While

            FechaProc = FechaInicial

            While FechaProc <= FechaFinal
                If ExisteFechaEnDiaSeleccionado(FechaProc) Then
                    Dim eASISTENCIA_AF_REPROG As ASISTENCIA_AF_REPROG = ObtenerASISTENCIA_AF_REPROG(FechaProc)
                    Dim IdAsistenciaAF As Decimal
                    Dim eASISTENCIA_AF_HORARIO_REPROG As New ASISTENCIA_AF_HORARIO_REPROG

                    If Not eASISTENCIA_AF_REPROG Is Nothing Then
                        IdAsistenciaAF = eASISTENCIA_AF_REPROG.ID_ASISTENCIA_AF
                    Else
                        'Agregar nueva asistencia   
                        IdAsistenciaAF = Me.NuevoID_ASISTENCIA_AF_REPROG
                        AgregarASISTENCIA_AF(IdAsistenciaAF, 0, FechaProc, "", "", Me.ObtenerUsuario, Now, DateAndTime.DateDiff(DateInterval.Minute, HoraInicio, HoraFin)) '/ 60)
                    End If

                    'Agregar nuevo horario
                    Me.AgregarASISTENCIA_AF_HORARIO(IdAsistenciaAF, NuevoID_ASISTENCIA_AF_HORARIO_REPROG(IdAsistenciaAF), HoraInicio, HoraFin, DateAndTime.DateDiff(DateInterval.Minute, HoraInicio, HoraFin))
                    'Actualizar la cantidad de horas ASISTENCIA_AF 
                    If Not eASISTENCIA_AF_REPROG Is Nothing Then Me.ActualizaASISTENCIA_AF_CANTIDAD_HORAS(IdAsistenciaAF)
                    Session("TIENE_CAMBIOS") = True
                End If
                FechaProc = FechaProc.AddDays(1)
            End While
        Else
            Me._dtASISTENCIA_AF_REPROG.Clear()
            Me._dtASISTENCIA_AF_HORARIO_REPROG.Clear()
        End If

        Me.CargarDatos()
        Me.ActualizarVariablesProgramacion()
    End Sub

    Private Sub ActualizarVariablesProgramacion()
        If FECHA_INICIO_REAL Is Nothing Then
            Me.lblFechaInicioReal.Text = ""
        Else
            Me.lblFechaInicioReal.Text = CDate(FECHA_INICIO_REAL).ToString("dd/MM/yyyy")
        End If
        If FECHA_FIN_REAL Is Nothing Then
            Me.lblFechaFinalizacionReal.Text = ""
        Else
            Me.lblFechaFinalizacionReal.Text = CDate(FECHA_FIN_REAL).ToString("dd/MM/yyyy")
        End If
        Me.lblHorasTotales.Text = Me.HORAS_TOTALES.ToString
        Me.lblHorario.Text = Me.ExpresionHorarioReal
    End Sub

    Private Function EsHorarioValidoEnDia(ByVal ID_ASISTENCIA_AF As Decimal, ByVal HORA_INICIO As Date, ByVal HORA_FIN As Date) As Boolean
        Dim drResult() As DataRow
        Dim sHORA_INICIO As String = "'" + HORA_INICIO.ToString() + "'"
        Dim sHORA_FIN As String = "'" + HORA_FIN.ToString() + "'"
        Dim Expresion As New StringBuilder

        Expresion.Append("ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString + " AND (")
        Expresion.Append("(" + sHORA_INICIO + " <= HORA_INICIO AND " + sHORA_FIN + " >= HORA_INICIO AND " + sHORA_FIN + " <= HORA_FIN) OR ")
        Expresion.Append("(" + sHORA_INICIO + " >= HORA_INICIO AND " + sHORA_INICIO + " <= HORA_FIN AND  " + sHORA_FIN + " >= HORA_FIN)")
        Expresion.Append(")")
        drResult = _dtASISTENCIA_AF_HORARIO_REPROG.Select(Expresion.ToString)
        If drResult.Length > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function AgregarASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal, _
                                          ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, _
                                          ByVal FECHA As Date, _
                                          ByVal INSTRUCTOR As String, _
                                          ByVal NOTAS As String, _
                                          ByVal USERID As String, _
                                          ByVal LASTUPDATE As Date, _
                                          ByVal CANTIDAD_HORAS As Decimal) As Decimal

        Dim dr As ASISTENCIA_AF_REPROGRow = _dtASISTENCIA_AF_REPROG.NewASISTENCIA_AF_REPROGRow
        With dr
            .ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            .ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
            .FECHA = FECHA
            .INSTRUCTOR = INSTRUCTOR
            .NOTAS = NOTAS
            .USERID = USERID
            .LASTUPDATE = LASTUPDATE
            .CANTIDAD_HORAS = CANTIDAD_HORAS
        End With

        Me._dtASISTENCIA_AF_REPROG.Rows.Add(dr)
    End Function

    Private Function AgregarASISTENCIA_AF_HORARIO(ByVal ID_ASISTENCIA_AF As Decimal, _
                                                  ByVal ID_ASISTENCIA_AF_HORARIO As Decimal, _
                                                  ByVal HORA_INICIO As Date, _
                                                  ByVal HORA_FIN As Date, _
                                                  ByVal CANTIDAD_MINUTOS As Decimal) As Decimal

        Dim dr As ASISTENCIA_AF_HORARIO_REPROGRow = _dtASISTENCIA_AF_HORARIO_REPROG.NewASISTENCIA_AF_HORARIO_REPROGRow

        With dr
            .ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            .ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO
            .HORA_INICIO = HORA_INICIO
            .HORA_FIN = HORA_FIN
            .CANTIDAD_MINUTOS = CANTIDAD_MINUTOS
        End With
        Me._dtASISTENCIA_AF_HORARIO_REPROG.Rows.Add(dr)
    End Function

    Private Sub ActualizaASISTENCIA_AF_CANTIDAD_HORAS(ByVal ID_ASISTENCIA_AF As Decimal)
        Dim drResult() As DataRow
        Dim TotalMinutos As Decimal = 0

        drResult = _dtASISTENCIA_AF_HORARIO_REPROG.Select("ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString)
        For Each dr As DataRow In drResult
            TotalMinutos += dr("CANTIDAD_MINUTOS")
        Next

        drResult = _dtASISTENCIA_AF_REPROG.Select("ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString)
        drResult(0).BeginEdit()
        drResult(0)("CANTIDAD_HORAS") = TotalMinutos '/ 60
        drResult(0).EndEdit()
    End Sub

    Private Function ObtenerASISTENCIA_AF_REPROG(ByVal fecha As Date) As ASISTENCIA_AF_REPROG
        Dim drResult() As DataRow

        drResult = _dtASISTENCIA_AF_REPROG.Select("FECHA = #" + fecha.ToString("MM/dd/yyyy") + "#")
        If drResult.Length > 0 Then
            Dim eASISTENCIA_AS As New ASISTENCIA_AF_REPROG
            With eASISTENCIA_AS
                .ID_ASISTENCIA_AF = drResult(0)("ID_ASISTENCIA_AF")
                .ID_ACCION_FORMATIVA_REPROG = drResult(0)("ID_ACCION_FORMATIVA_REPROG")
                .FECHA = drResult(0)("FECHA")
                .INSTRUCTOR = drResult(0)("INSTRUCTOR")
                .NOTAS = drResult(0)("NOTAS")
                .USERID = drResult(0)("USERID")
                .LASTUPDATE = drResult(0)("LASTUPDATE")
                .CANTIDAD_HORAS = drResult(0)("CANTIDAD_HORAS")
            End With
            Return eASISTENCIA_AS
        Else
            Return Nothing
        End If
    End Function

    Private Function ExisteFechaEnDiaSeleccionado(ByVal fecha As Date) As Boolean
        Select Case fecha.DayOfWeek
            Case DayOfWeek.Monday
                If Me.chkLunes.Checked Then Return True
            Case DayOfWeek.Tuesday
                If Me.chkMartes.Checked Then Return True
            Case DayOfWeek.Wednesday
                If Me.chkMiercoles.Checked Then Return True
            Case DayOfWeek.Thursday
                If Me.chkJueves.Checked Then Return True
            Case DayOfWeek.Friday
                If Me.chkViernes.Checked Then Return True
            Case DayOfWeek.Saturday
                If Me.chkSabado.Checked Then Return True
            Case DayOfWeek.Sunday
                If Me.chkDomingo.Checked Then Return True
        End Select
        Return False
    End Function

    Private Function NuevoID_ASISTENCIA_AF_REPROG() As Decimal
        Dim maxObject As Object

        maxObject = Me.dtASISTENCIA_AF_REPROG.Compute("Max(ID_ASISTENCIA_AF)", "ID_ASISTENCIA_AF <> -1")
        If Not IsDBNull(maxObject) Then
            Return Convert.ToDecimal(maxObject) + 1
        Else
            Return 1
        End If
    End Function

    Private Function NuevoID_ASISTENCIA_AF_HORARIO_REPROG(ByVal ID_ASISTENCIA_AF As Decimal) As Decimal
        Dim maxObject As Object

        maxObject = Me.dtASISTENCIA_AF_HORARIO_REPROG.Compute("Max(ID_ASISTENCIA_AF_HORARIO)", "ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString)
        If Not IsDBNull(maxObject) Then
            Return Convert.ToDecimal(maxObject) + 1
        Else
            Return 1
        End If
    End Function

    Private Sub CargarDatos()
        Me.dgProgCurso.DataSource = dtASISTENCIA_AF_REPROG
        Me.dgProgCurso.KeyFieldName = "ID_ASISTENCIA_AF"
        Me.dgProgCurso.DataBind()

        Session("ASISTENCIA_AF_REPROG") = Me._dtASISTENCIA_AF_REPROG
        Session("ASISTENCIA_AF_HORARIO_REPROG") = Me._dtASISTENCIA_AF_HORARIO_REPROG
    End Sub

    Private Function ExpresionHorarioPorDia(ByVal ID_ASISTENCIA_AF As Decimal) As String
        Dim drResult() As DataRow
        Dim sHorario As New StringBuilder

        Dim Conta As Integer = 0

        drResult = dtASISTENCIA_AF_HORARIO_REPROG.Select("ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString, "HORA_INICIO ASC")
        For Each dr As DataRow In drResult
            If Conta > 0 Then
                sHorario.Append(" Y ")
            End If
            sHorario.Append("DE ")
            sHorario.Append(Date.Parse(dr("HORA_INICIO")).ToString("h:mmtt").ToUpper)
            sHorario.Append(" A ")
            sHorario.Append(Date.Parse(dr("HORA_FIN")).ToString("h:mmtt").ToUpper)
            Conta += 1
        Next

        Return sHorario.ToString
    End Function

    Private Function CalcularHorasCapacitacionPorDia(ByVal ID_ASISTENCIA_AF As Decimal) As String
        Dim sumObject As Object
        Dim TotalMinutos As Decimal

        sumObject = dtASISTENCIA_AF_HORARIO_REPROG.Compute("SUM(CANTIDAD_MINUTOS)", "ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString)
        If Not IsDBNull(sumObject) Then
            TotalMinutos = CDec(sumObject)

            If TotalMinutos < 60 Then
                Return "0:" + Format(TotalMinutos, "0#")
            Else
                Return Format(Math.Truncate(TotalMinutos / 60), "0") + ":" + Format(TotalMinutos Mod 60, "0#")
            End If
        Else
            Return "0:00"
        End If
    End Function

    Private Function ExpresionHorarioReal() As String
        Dim tblTodosHorarios As New DataTable
        Dim tblFechasHorarios As New DataTable
        Dim tblHorarios As New DataTable

        Dim lResult As New StringBuilder
        Dim Condicion As New StringBuilder
        Dim Id As Decimal = 1

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
        For Each dr As DataRow In _dtASISTENCIA_AF_REPROG.Select("ID_ASISTENCIA_AF > 0", "FECHA ASC")
            Dim fila As DataRow = tblTodosHorarios.NewRow
            fila("ID") = Id
            fila("FECHA") = dr("FECHA")
            fila("EXPHORARIO") = Me.ExpresionHorarioPorDia(dr("ID_ASISTENCIA_AF"))
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

    Private Function ReordenarPorDiaSemana(ByVal mTabla As DataTable) As DataRow()
        If mTabla.Rows.Count > 0 Then
            'Agregamos la columna DIA_SEMANA para guardar el día de la semana que representa cada fecha
            If Not mTabla.Columns.Contains("DIA_SEMANA") Then
                mTabla.Columns.Add("DIA_SEMANA", System.Type.GetType("System.Decimal"))
            End If
            For Each dr As DataRow In mTabla.Select()
                dr("DIA_SEMANA") = Me.ValorDiaSemana(dr("FECHA"))
            Next

            'Si el Día de la Semana de la Fecha de Inicio del Curso es Menor al día de la semana de cualquier otra fecha del curso
            'entonces ordernar primero por Dia de la Semana y luego por Fecha
            Dim drPorFecha() As DataRow = mTabla.Select("ID_ASISTENCIA_AF > 0", "FECHA ASC")
            Dim drPorDiaSemana() As DataRow = mTabla.Select("ID_ASISTENCIA_AF > 0", "DIA_SEMANA ASC")

            If drPorFecha(0)("DIA_SEMANA") > drPorDiaSemana(0)("DIA_SEMANA") Then
                Return mTabla.Select("ID_ASISTENCIA_AF > 0", "DIA_SEMANA, FECHA ASC")
            End If
        End If
        Return mTabla.Select
    End Function

    Protected Sub dgProgCurso_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dgProgCurso.CustomButtonCallback
        If e.ButtonID = "cbEliminar" Then
            Dim dr As DataRow = Me.dgProgCurso.GetDataRow(e.VisibleIndex)

            For Each dr2 As DataRow In Me._dtASISTENCIA_AF_HORARIO_REPROG.Select("ID_ASISTENCIA_AF=" + dr("ID_ASISTENCIA_AF").ToString)
                Me._dtASISTENCIA_AF_HORARIO_REPROG.Rows.Remove(dr2)
            Next
            Me._dtASISTENCIA_AF_HORARIO_REPROG.AcceptChanges()

            Me._dtASISTENCIA_AF_REPROG.Rows.Remove(dr)
            Me._dtASISTENCIA_AF_REPROG.AcceptChanges()
            Me.dgProgCurso.DataBind()
            Session("TIENE_CAMBIOS") = True
        End If
    End Sub

    Protected Sub dgProgCurso_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dgProgCurso.CustomButtonInitialize
        If Not Me._PermitirEditar AndAlso e.ButtonID = "cbEliminar" Then
            e.Visible = DevExpress.Utils.DefaultBoolean.False
        Else
            e.Visible = DevExpress.Utils.DefaultBoolean.True
        End If
    End Sub

    Protected Sub dgProgCurso_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dgProgCurso.CustomJSProperties
        CrearCustomJSProperties(e)
    End Sub

    Protected Sub CrearCustomJSProperties(ByRef e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs)
        If FECHA_INICIO_REAL Is Nothing Then
            e.Properties("cpFECHA_INICIO_REAL") = ""
        Else
            e.Properties("cpFECHA_INICIO_REAL") = CDate(FECHA_INICIO_REAL).ToString("dd/MM/yyyy")
        End If
        If FECHA_FIN_REAL Is Nothing Then
            e.Properties("cpFECHA_FIN_REAL") = ""
        Else
            e.Properties("cpFECHA_FIN_REAL") = CDate(FECHA_FIN_REAL).ToString("dd/MM/yyyy")
        End If
        If Me.MINUTOS_TOTALES = 0 Then
            e.Properties("cpHORAS_TOTALES") = ""
        Else
            e.Properties("cpHORAS_TOTALES") = Me.HORAS_TOTALES.ToString
        End If
        e.Properties("cpHORARIO_REAL") = Me.ExpresionHorarioReal
    End Sub

    Protected Sub dgProgCurso_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dgProgCurso.CustomUnboundColumnData
        If e.Column.FieldName = "HORARIO" Then
            e.Value = Me.ExpresionHorarioPorDia(e.GetListSourceFieldValue("ID_ASISTENCIA_AF"))
        End If
        If e.Column.FieldName = "HORAS_CAPACITACION" Then
            e.Value = Me.CalcularHorasCapacitacionPorDia(e.GetListSourceFieldValue("ID_ASISTENCIA_AF"))
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Session("ASISTENCIA_AF_REPROG") = Nothing
            Session("ASISTENCIA_AF_HORARIO_REPROG") = Nothing
        End If
        If Not Session("ASISTENCIA_AF_REPROG") Is Nothing Then Me._dtASISTENCIA_AF_REPROG = Session("ASISTENCIA_AF_REPROG")
        If Not Session("ASISTENCIA_AF_HORARIO_REPROG") Is Nothing Then Me._dtASISTENCIA_AF_HORARIO_REPROG = Session("ASISTENCIA_AF_HORARIO_REPROG")
        If Not Session("TIENE_CAMBIOS") Is Nothing Then Me._TieneCambios = Session("TIENE_CAMBIOS")
        Me.CargarDatos()
        Me.ActualizarVariablesProgramacion()
    End Sub

    Private Function ValorDiaSemana(ByVal fecha As Date) As Integer
        Select Case fecha.DayOfWeek
            Case 0
                Return 7
            Case Else
                Return fecha.DayOfWeek
        End Select
    End Function

    Private Function NombreDiaSemana(ByVal Dia As Integer) As String
        Return DateAndTime.WeekdayName(Dia, False, Microsoft.VisualBasic.FirstDayOfWeek.Monday).ToUpper
    End Function

    Public Sub Actualizar(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal EsNuevaReprogramacion As Boolean)
        Dim AsistenciaAF As New cASISTENCIA_AF_REPROG
        Dim AsistenciaAF_Horario As New cASISTENCIA_AF_HORARIO_REPROG
        Dim eAsistenciaAF As ASISTENCIA_AF_REPROG
        Dim Condicion As StringBuilder

        If EsNuevaReprogramacion Then
            For Each _dr As ASISTENCIA_AF_REPROGRow In Me._dtASISTENCIA_AF_REPROG
                eAsistenciaAF = New ASISTENCIA_AF_REPROG
                eAsistenciaAF.ID_ASISTENCIA_AF = 0
                eAsistenciaAF.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
                Me.ActualizarASISTENCIA_AF_REPROG_PorFila(eAsistenciaAF, _dr)

                'Agregar Horario para el Día de Asistencia
                Me.AgregarASISTENCIA_AF_HORARIO_REPROG_PorTabla(eAsistenciaAF.ID_ASISTENCIA_AF, _dr.ID_ASISTENCIA_AF, Me._dtASISTENCIA_AF_HORARIO_REPROG)
            Next
        Else
            'Eliminar en ASISTENCIA_AF_REPROG los días que no estén en el DataTable ASISTENCIA_AF
            Dim listaAsistencia As listaASISTENCIA_AF_REPROG = AsistenciaAF.ObtenerListaPorACCION_FORMATIVA_REPROG(ID_ACCION_FORMATIVA_REPROG)
            For Each _Asistencia As ASISTENCIA_AF_REPROG In listaAsistencia
                Condicion = New StringBuilder
                Condicion.Append("FECHA = #")
                Condicion.Append(_Asistencia.FECHA.ToString("MM/dd/yyyy"))
                Condicion.Append("#")

                If Me.dtASISTENCIA_AF_REPROG.Select(Condicion.ToString).Length = 0 Then
                    AsistenciaAF.EliminarASISTENCIA_AF_REPROG(_Asistencia.ID_ASISTENCIA_AF)
                End If
            Next

            'Agregar/Actualizar Cambios en el horario de los días de asistencia
            For Each _dr As ASISTENCIA_AF_REPROGRow In Me._dtASISTENCIA_AF_REPROG
                eAsistenciaAF = AsistenciaAF.ObtenerASISTENCIA_AFPorIdAccionFormativaReprog_Fecha(_dr.ID_ACCION_FORMATIVA_REPROG, _dr.FECHA)

                If eAsistenciaAF Is Nothing Then
                    'Agregar ASISTENCIA_AF
                    eAsistenciaAF = New ASISTENCIA_AF_REPROG
                    eAsistenciaAF.ID_ASISTENCIA_AF = 0
                    eAsistenciaAF.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
                    Me.ActualizarASISTENCIA_AF_REPROG_PorFila(eAsistenciaAF, _dr)


                    'Agregar Horario para Día de Asitencia de Asistencia
                    Me.AgregarASISTENCIA_AF_HORARIO_REPROG_PorTabla(eAsistenciaAF.ID_ASISTENCIA_AF, _dr.ID_ASISTENCIA_AF, Me._dtASISTENCIA_AF_HORARIO_REPROG)
                Else
                    'Actualizar ASISTENCIA_AF si CANTIDAD_HORAS es diferente 
                    If eAsistenciaAF.CANTIDAD_HORAS <> _dr.CANTIDAD_HORAS Then
                        eAsistenciaAF.CANTIDAD_HORAS = _dr.CANTIDAD_HORAS
                        AsistenciaAF.ActualizarASISTENCIA_AF_REPROG(eAsistenciaAF, TipoConcurrencia.Pesimistica)
                    End If

                    'Eliminar horario y agregarlo nuevamente
                    AsistenciaAF_Horario.EliminarASISTENCIA_AF_HORARIO_REPROGPorID_ASISTENCIA_AF(eAsistenciaAF.ID_ASISTENCIA_AF)

                    'Agregar Horario para la Fecha de Asistencia
                    Me.AgregarASISTENCIA_AF_HORARIO_REPROG_PorTabla(eAsistenciaAF.ID_ASISTENCIA_AF, _dr.ID_ASISTENCIA_AF, Me._dtASISTENCIA_AF_HORARIO_REPROG)
                End If
            Next
        End If
    End Sub
   

    Protected Sub ActualizarASISTENCIA_AF_REPROG_PorFila(ByRef eASISTENCIA_AF As ASISTENCIA_AF_REPROG, ByVal dr As SGAFP.DL.DS_DL.ASISTENCIA_AF_REPROGRow)
        Dim AsistenciaAF As New cASISTENCIA_AF_REPROG
        With eASISTENCIA_AF
            .FECHA = dr.FECHA
            .INSTRUCTOR = dr.INSTRUCTOR
            .NOTAS = dr.NOTAS
            .CANTIDAD_HORAS = dr.CANTIDAD_HORAS
        End With
        AsistenciaAF.ActualizarASISTENCIA_AF_REPROG(eASISTENCIA_AF, TipoConcurrencia.Pesimistica)
    End Sub

    Protected Sub AgregarASISTENCIA_AF_HORARIO_REPROG_PorTabla(ByVal ID_ASISTENCIA_AF As Decimal, ByVal dtID_ASISTENCIA_AF As Decimal, ByVal dt As SGAFP.DL.DS_DL.ASISTENCIA_AF_HORARIO_REPROGDataTable)
        Dim AsistenciaAF_Horario As New cASISTENCIA_AF_HORARIO_REPROG
        Dim eAsistenciaAF_Horario As ASISTENCIA_AF_HORARIO_REPROG
        Dim Condicion As New StringBuilder

        Condicion.Append("ID_ASISTENCIA_AF = ")
        Condicion.Append(dtID_ASISTENCIA_AF.ToString)
        For Each dr As ASISTENCIA_AF_HORARIO_REPROGRow In dt.Select(Condicion.ToString, "HORA_INICIO ASC")
            eAsistenciaAF_Horario = New ASISTENCIA_AF_HORARIO_REPROG

            With eAsistenciaAF_Horario
                .ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
                .ID_ASISTENCIA_AF_HORARIO = 0
                .HORA_INICIO = dr.HORA_INICIO
                .HORA_FIN = dr.HORA_FIN
                .CANTIDAD_MINUTOS = dr.CANTIDAD_MINUTOS
            End With

            AsistenciaAF_Horario.ActualizarASISTENCIA_AF_HORARIO_REPROG(eAsistenciaAF_Horario, TipoConcurrencia.Pesimistica)
        Next
    End Sub

    Protected Sub dgProgCurso_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dgProgCurso.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            Dim eAccionFormativaReprog As ACCION_FORMATIVA_REPROG
            Dim eAsistenciaAF As New ASISTENCIA_AF
            Dim dr As DataRow = dgProgCurso.GetDataRow(e.VisibleIndex)

            If dr IsNot Nothing Then
                eAccionFormativaReprog = (New cACCION_FORMATIVA_REPROG).ObtenerACCION_FORMATIVA_REPROG(dr("ID_ACCION_FORMATIVA_REPROG"))
                If eAccionFormativaReprog IsNot Nothing Then
                    eAsistenciaAF = (New cASISTENCIA_AF).ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(eAccionFormativaReprog.ID_ACCION_FORMATIVA, dr("FECHA"))
                    If eAsistenciaAF IsNot Nothing AndAlso eAsistenciaAF.ID_ASISTENCIA_AF > 0 Then
                        If eAsistenciaAF.CANTIDAD_HORAS <> dr("CANTIDAD_HORAS") Then
                            For i As Integer = 0 To e.Row.Cells.Count - 1
                                e.Row.Cells(i).Style.Add("background-color", "Yellow")
                            Next
                        End If
                    Else
                        For i As Integer = 0 To e.Row.Cells.Count - 1
                            e.Row.Cells(i).Style.Add("background-color", "Yellow")
                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub dgProgCurso_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dgProgCurso.HtmlRowPrepared

    End Sub
End Class
