Imports DevExpress.Web.ASPxEditors
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView
Imports System.Collections.Generic


Partial Class controles_ucAsistenciaAccionFormativaHoras
    Inherits ucBase


    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") Is Nothing Then Return 0
            Return Me.ViewState("ID_ACCION_FORMATIVA")
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("ID_ACCION_FORMATIVA") = value

            If value > 0 Then
                Dim Detalle As listaASISTENCIA_AF
                Dim Asistencia As New cASISTENCIA_AF

                Detalle = Asistencia.ObtenerListaPorACCION_FORMATIVA(value, , , "FECHA", "")
                If Detalle IsNot Nothing AndAlso Detalle.Count > 0 Then
                    SetAsistenciaAF(Detalle(0).ID_ASISTENCIA_AF, True)
                End If
                Inicializar()
            End If
        End Set
    End Property

    Public Property ID_INFORME_FINAL_AF() As Decimal
        Get
            If Me.ViewState("ID_INFORME_FINAL_AF") Is Nothing Then Return 0
            Return Me.ViewState("ID_INFORME_FINAL_AF")
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("ID_INFORME_FINAL_AF") = value

            If value > 0 Then
                Dim lEntidad As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(value)
                Me.ViewState("ID_ACCION_FORMATIVA") = lEntidad.ID_ACCION_FORMATIVA
                Dim Detalle As listaASISTENCIA_AF
                Dim Asistencia As New cASISTENCIA_AF

                Detalle = Asistencia.ObtenerListaPorINFORME_FINAL_AF(value, "FECHA", "")
                If Detalle IsNot Nothing AndAlso Detalle.Count > 0 Then
                    SetAsistenciaAF(Detalle(0).ID_ASISTENCIA_AF, True)
                End If
                Inicializar()
            End If
        End Set
    End Property

    Public Property TamanoPagina() As Decimal
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Decimal)
            Me.dxgvLista.SettingsPager.PageSize = value
        End Set
    End Property

    Public Property ES_INFORME_FINAL() As Boolean
        Get
            If Me.ViewState("ES_INFORME_FINAL") Is Nothing Then Return False
            Return Me.ViewState("ES_INFORME_FINAL")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("ES_INFORME_FINAL") = value
        End Set
    End Property

    Private Property ID_ASISTENCIA_AF() As Decimal
        Get
            If Not Me.hfParametros.Contains("IdAsistenciaAF") Then Return 0
            Return Me.hfParametros("IdAsistenciaAF")
        End Get
        Set(ByVal value As Decimal)
            If Not Me.hfParametros.Contains("IdAsistenciaAF") Then hfParametros.Add("IdAsistenciaAF", value) Else hfParametros("IdAsistenciaAF") = value
        End Set
    End Property

    Private Property ID_PARTICIPANTE() As Decimal
        Get
            If Not Me.hfParametros.Contains("IdParticipante") Then Return 0
            Return Me.hfParametros("IdParticipante")
        End Get
        Set(ByVal value As Decimal)
            If Not Me.hfParametros.Contains("IdParticipante") Then hfParametros.Add("IdParticipante", value) Else hfParametros("IdParticipante") = value
        End Set
    End Property

    Private Sub SetAsistenciaAF(ByVal IdAsistenciaAF As Decimal, Optional ByVal MostrarFecha As Boolean = False)
        Dim eAsistencia As ASISTENCIA_AF
        Dim Asistencia As New cASISTENCIA_AF
        Dim AsistenciaHorario As New cASISTENCIA_AF_HORARIO

        eAsistencia = Asistencia.ObtenerASISTENCIA_AF(IdAsistenciaAF)
        Me.lblFecha.Text = eAsistencia.FECHA.ToString("dddd, dd DE MMMM yyyy ").ToUpper
        Me.lblHorario.Text = AsistenciaHorario.ExpresionHorarioPorDia(IdAsistenciaAF)

        If MostrarFecha Then Me.ASPxCalendar1.VisibleDate = eAsistencia.FECHA
        Me.ASPxCalendar1.SelectedDate = eAsistencia.FECHA

        Me.ID_ASISTENCIA_AF = IdAsistenciaAF
    End Sub

    Private Sub ConfigurarEdicion()
        If EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse EstaEnRol(RolDeUsuario.Proveedor) OrElse EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse _
            EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) Then
            If ID_INFORME_FINAL_AF > 0 Then
                Dim eAsistencia As ASISTENCIA_AF
                Dim eInformeEjecucion As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL_AF)
                eAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
                Me.dxgvLista.Columns("REPLICAR_INASISTENCIA").Visible = (eInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                    eInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones)

                Me.dxgvLista.Columns("COLUMNA_EDICION").Visible = (eInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                    eInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones)

            ElseIf ID_ACCION_FORMATIVA > 0 Then
                Dim eAccionFormativa As ACCION_FORMATIVA
                Dim eAsistencia As ASISTENCIA_AF

                eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
                eAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
                Me.dxgvLista.Columns("REPLICAR_INASISTENCIA").Visible = (eAccionFormativa.CODIGO_ESTADO_AF = _
                        eAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Finalizada OrElse _
                        eAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada) AndAlso (eAsistencia.FECHA < eAccionFormativa.FECHA_FIN_REAL)

                Me.dxgvLista.Columns("COLUMNA_EDICION").Visible = (eAccionFormativa.CODIGO_ESTADO_AF = _
                        eAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Finalizada OrElse _
                        eAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada)
            End If
        Else
            Me.dxgvLista.Columns("REPLICAR_INASISTENCIA").Visible = False
            Me.dxgvLista.Columns("COLUMNA_EDICION").Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Carga los días del Curso en el Calendario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDiasCurso(ByRef e As DevExpress.Web.ASPxEditors.DayRenderEventArgs)
        Dim Detalle As listaASISTENCIA_AF
        If ID_INFORME_FINAL_AF > 0 Then
            Detalle = (New cASISTENCIA_AF).ObtenerListaPorINFORME_FINAL_AF(ID_INFORME_FINAL_AF, "FECHA")
        Else
            Detalle = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        End If
        If Detalle IsNot Nothing Then
            For Each eAsistencia In Detalle
                If e.Day.DateTime.Date = eAsistencia.FECHA Then
                    e.Controls.Add(CrearMarca(eAsistencia.FECHA, eAsistencia.ID_ASISTENCIA_AF))
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Crea un control HyperLink para agregar a un día del Calendario
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CrearMarca(ByVal FECHA As Date, ByVal ID_ASISTENCIA_AF As Decimal) As Control
        Dim Link As New HyperLink
        With Link
            .Text = FECHA.Day.ToString
            .NavigateUrl = String.Format("javascript:MostrarParticipantes('{0}');", ID_ASISTENCIA_AF.ToString)
            .Font.Bold = True
        End With
        Return Link
    End Function

    Private Sub Inicializar()
        If Me.ID_ACCION_FORMATIVA > 0 Then
            If Me.ID_ASISTENCIA_AF > 0 Then
                Dim eAsistenciaAF As ASISTENCIA_AF = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
                Me.CargarAsistencia(Me.ID_ACCION_FORMATIVA, eAsistenciaAF.ID_ASISTENCIA_AF)
            End If
            ConfigurarEdicion()
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "FuncionParticipantes", GenerarFuncionJSParticipantes, True)
            Me.ASPxCalendar1.VisibleDate = Today
            Me.ID_ACCION_FORMATIVA = 0
            Me.ID_ASISTENCIA_AF = 0
        Else
            Inicializar()
        End If
    End Sub

    Protected Function GenerarFuncionJSParticipantes() As String
        Dim script As New StringBuilder

        script.Append("var postponedCallbackValue = null; ")
        script.Append("function MostrarParticipantes(IdAsistenciaAF) { ")
        script.Append(" if(CallbackPanel.InCallback()) {")
        script.Append("     postponedCallbackValue = IdAsistenciaAF; ")
        script.Append(" } ")
        script.Append(" else { ")
        script.Append("     parametros = IdAsistenciaAF; ")
        script.Append("     CallbackPanel.PerformCallback(parametros); ")
        script.Append(" } ")
        script.Append("} ")
        
        Return script.ToString
    End Function

    Protected Sub ASPxCalendar1_DayRender(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxEditors.DayRenderEventArgs) Handles ASPxCalendar1.DayRender
        CargarDiasCurso(e)
    End Sub

    Protected Sub CargarAsistencia(ByVal IdAccionFormativa As Decimal, ByVal IdAsistenciaAF As Decimal)
        'Mostrar listado de participantes
        Me.odsListaAsistencia.SelectParameters("ID_ASISTENCIA_AF").DefaultValue = IdAsistenciaAF
        Me.odsListaAsistencia.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = IdAccionFormativa
        Me.dxgvLista.DataBind()
    End Sub

    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ID_PARTICIPANTE")
        Next i
        e.Properties("cpKeyValues") = keyValues
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        End If
        If e.Column.FieldName = "HORAS_ASISTIDAS" Then
            Dim TotalMinutos As Decimal = e.GetListSourceFieldValue("HORAS_ASISTENCIA")
            If TotalMinutos < 60 Then
                e.Value = CDate("0:" + Format(TotalMinutos, "0#"))
            Else
                e.Value = CDate(Format(Math.Truncate(TotalMinutos / 60), "0") + ":" + Format(TotalMinutos Mod 60, "0#"))
            End If
        End If
    End Sub


    'Protected Sub dxgvLista_RowDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs) Handles dxgvLista.RowDeleting
    '    e.Values("")
    '    ActualizarInforme()
    'End Sub

    'Protected Sub dxgvLista_RowInserted(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertedEventArgs) Handles dxgvLista.RowInserted
    '    e.NewValues("")
    '    ActualizarInforme()
    'End Sub

    'Protected Sub dxgvLista_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatedEventArgs) Handles dxgvLista.RowUpdated
    '    ActualizarInforme()
    'End Sub

    Protected Sub dxgvLista_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        e.NewValues("HORAS_ASISTENCIA") = (CDate(e.NewValues("HORAS_ASISTIDAS")).Hour * 60) + CDate(e.NewValues("HORAS_ASISTIDAS")).Minute
    End Sub

    Protected Sub dxgvLista_RowValidating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataValidationEventArgs) Handles dxgvLista.RowValidating
        For Each columna As GridViewColumn In Me.dxgvLista.Columns
            Dim dataColumn As GridViewDataColumn = TryCast(columna, GridViewDataColumn)
            If dataColumn Is Nothing Then
                Continue For
            End If
            If e.NewValues(dataColumn.FieldName) Is Nothing AndAlso dataColumn.FieldName <> "JUSTIFICACION" AndAlso _
                dataColumn.FieldName <> "CORRELATIVO" AndAlso _
                dataColumn.FieldName <> "ID_PARTICIPANTE" AndAlso _
                dataColumn.FieldName <> "ID_ASISTENCIA_DET" Then

                e.Errors(dataColumn) = "Campo no puede estar vacío."
            End If
        Next columna

        Dim eAsistenciaAF As ASISTENCIA_AF = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
        Dim HorasAsistidas As Decimal = 0

        If e.NewValues("HORAS_ASISTIDAS") IsNot Nothing Then
            HorasAsistidas = CDec(((CDate(e.NewValues("HORAS_ASISTIDAS")).Hour * 60) + CDate(e.NewValues("HORAS_ASISTIDAS")).Minute))
        End If

        If e.NewValues("HORAS_ASISTIDAS") IsNot Nothing AndAlso HorasAsistidas > eAsistenciaAF.CANTIDAD_HORAS Then
            AddError(e.Errors, Me.dxgvLista.Columns("HORAS_ASISTIDAS"), "Horas asistidas no puede exceder a " + Utilerias.ConvertirMinutosAFormatoHoras(eAsistenciaAF.CANTIDAD_HORAS) + " horas")
        End If
        If e.NewValues("ASISTIO") IsNot Nothing AndAlso e.NewValues("ASISTIO").ToString = "1" Then
            If e.NewValues("HORAS_ASISTIDAS") IsNot Nothing AndAlso HorasAsistidas = 0 Then
                AddError(e.Errors, Me.dxgvLista.Columns("HORAS_ASISTIDAS"), "Horas asistidas no puede ser cero")
            End If
            If e.NewValues("PRESENTA_JUSTIFICACION") IsNot Nothing AndAlso e.NewValues("PRESENTA_JUSTIFICACION").ToString = "1" Then
                AddError(e.Errors, Me.dxgvLista.Columns("ASISTIO"), "No se puede marcar como asistente e inasistente al mismo tiempo.")
            End If
        End If
        If e.NewValues("ASISTIO") IsNot Nothing AndAlso e.NewValues("ASISTIO").ToString = "0" Then
            If e.NewValues("HORAS_ASISTIDAS") IsNot Nothing AndAlso HorasAsistidas > 0 Then
                AddError(e.Errors, Me.dxgvLista.Columns("HORAS_ASISTIDAS"), "Horas asistidas debe ser cero ya que el participante no asistió")
            End If
        End If
        If e.NewValues("PRESENTA_JUSTIFICACION") IsNot Nothing AndAlso (e.NewValues("PRESENTA_JUSTIFICACION").ToString = "1") Then
            If e.NewValues("JUSTIFICACION") IsNot Nothing Then
                If e.NewValues("JUSTIFICACION").ToString.Trim = "" Then
                    AddError(e.Errors, Me.dxgvLista.Columns("JUSTIFICACION"), "Escriba la justificación de la inasistencia.")
                End If
            Else
                AddError(e.Errors, Me.dxgvLista.Columns("JUSTIFICACION"), "Escriba la justificación de la inasistencia.")
            End If
        End If
        If e.NewValues("PRESENTA_JUSTIFICACION") IsNot Nothing AndAlso (e.NewValues("PRESENTA_JUSTIFICACION").ToString = "0") Then
            If e.NewValues("JUSTIFICACION") IsNot Nothing AndAlso e.NewValues("JUSTIFICACION").ToString.Trim <> String.Empty Then
                AddError(e.Errors, Me.dxgvLista.Columns("JUSTIFICACION"), "Marque la casilla JUSTIFICO para guardar la justificación.")
            End If
        End If

        If String.IsNullOrEmpty(e.RowError) AndAlso e.Errors.Count > 0 Then
            e.RowError = "Por favor, corriga los errores."
        End If
    End Sub

    Private Sub AddError(ByVal errors As Dictionary(Of GridViewColumn, String), ByVal column As GridViewColumn, ByVal errorText As String)
        If errors.ContainsKey(column) Then
            Return
        End If
        errors(column) = errorText
    End Sub

    Protected Sub odsListaAsistencia_Updating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles odsListaAsistencia.Updating
        Dim AsistenciaDet As New cASISTENCIA_AF_DET
        Dim eAsistenciaAF As ASISTENCIA_AF
        Dim lRet As Integer = 0

        eAsistenciaAF = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)

        e.InputParameters("ID_ASISTENCIA_AF") = Me.ID_ASISTENCIA_AF
        If e.InputParameters("JUSTIFICACION") IsNot Nothing Then e.InputParameters("JUSTIFICACION") = e.InputParameters("JUSTIFICACION").ToString.ToUpper

        If e.InputParameters("ASISTIO").ToString = "1" AndAlso CDec(e.InputParameters("HORAS_ASISTENCIA")) = eAsistenciaAF.CANTIDAD_HORAS Then
            If CDec(e.InputParameters("ID_ASISTENCIA_DET")) > 0 Then
                lRet = AsistenciaDet.EliminarASISTENCIA_AF_DET(CDec(e.InputParameters("ID_ASISTENCIA_DET")))
                If lRet <= 0 Then
                    Me.AsignarMensaje("Error al Actualizar Asistencia:" + AsistenciaDet.sError, True)
                End If
            End If
            e.Cancel = True
        End If
    End Sub

    'Private Sub ActualizarInforme(ByVal ID_ASISTENCIA_AF As Decimal)
    '    Dim InformeFinalAF As New cINFORME_FINAL_AF
    '    Dim eAsistenciaAF As ASISTENCIA_AF

    '    eAsistenciaAF = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
    '    If eAsistenciaAF IsNot Nothing Then InformeFinalAF.GenerarInformeFinal(eAsistenciaAF.ID_ACCION_FORMATIVA)
    'End Sub

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanel.Callback
        Dim parametros() As String
        parametros = e.Parameter.Split(";")

        CallbackPanel.JSProperties.Clear()
        CallbackPanel.JSProperties.Add("cpResultCallback", "")

        Select Case parametros(0)
            Case "Inasistencia"
                Dim mensaje As New StringBuilder
                Dim eAsistencia As ASISTENCIA_AF
                Dim eAccionFormativa As ACCION_FORMATIVA
                Dim eParticipante As PARTICIPANTE

                eAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
                If eAsistencia IsNot Nothing Then
                    Me.ID_PARTICIPANTE = Convert.ToDecimal(parametros(1))

                    eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(eAsistencia.ID_ACCION_FORMATIVA)
                    eParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(Me.ID_PARTICIPANTE)

                    mensaje.Append("Esta opción generara inasistencia del participante ")
                    mensaje.Append(eParticipante.APELLIDOS)
                    mensaje.Append(", ")
                    mensaje.Append(eParticipante.NOMBRES)
                    mensaje.Append(" para los días del curso comprendidos entre el ")
                    mensaje.Append(eAsistencia.FECHA.ToString("dd/MM/yyyy"))
                    mensaje.Append(" y el ")
                    mensaje.Append(eAccionFormativa.FECHA_FIN_REAL.ToString("dd/MM/yyyy"))
                    mensaje.Append(". Escriba la justificación en el caso que el participante justifique su inasistencia.")
                    Me.popuplblInfo.Text = mensaje.ToString
                    Me.popupmmoJustificacion.Text = ""
                    CallbackPanel.JSProperties("cpResultCallback") = "MostrarPopupInasistencia"
                End If

            Case "ReplicarInasistencia"
                Dim listaAsistencia As New listaASISTENCIA_AF
                Dim eAsistencia As ASISTENCIA_AF
                Dim criterios As New List(Of SGAFP.EL.Criteria)
                Dim Justificacion As String = parametros(1).Trim.ToUpper
                Dim lRet As Integer = 0

                eAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)

                If eAsistencia IsNot Nothing Then
                    criterios.Add(New SGAFP.EL.Criteria("ID_ACCION_FORMATIVA", "=", Me.ID_ACCION_FORMATIVA, " AND "))
                    criterios.Add(New SGAFP.EL.Criteria("FECHA", ">=", eAsistencia.FECHA.ToString("dd/MM/yyyy"), ""))

                    listaAsistencia = (New cASISTENCIA_AF).ObtenerListaPorBusqueda(New ASISTENCIA_AF, criterios.ToArray, "FECHA", "ASC")
                    If listaAsistencia IsNot Nothing AndAlso listaAsistencia.Count > 0 Then
                        For Each lEntidad As ASISTENCIA_AF In listaAsistencia
                            Dim bAsistenciaDetalle As New cASISTENCIA_AF_DET
                            Dim eAsistenciaDetalle As New ASISTENCIA_AF_DET
                            Dim listaAsistenciaDetalle As listaASISTENCIA_AF_DET

                            eAsistenciaDetalle.ID_ASISTENCIA_AF = lEntidad.ID_ASISTENCIA_AF
                            eAsistenciaDetalle.ID_ASISTENCIA_DET = 0
                            eAsistenciaDetalle.ID_PARTICIPANTE = Me.ID_PARTICIPANTE
                            eAsistenciaDetalle.ASISTIO = "0"
                            eAsistenciaDetalle.HORAS_ASISTENCIA = 0
                            If Justificacion <> "" Then
                                eAsistenciaDetalle.PRESENTA_JUSTIFICACION = "1"
                                eAsistenciaDetalle.JUSTIFICACION = Justificacion
                            Else
                                eAsistenciaDetalle.PRESENTA_JUSTIFICACION = "0"
                                eAsistenciaDetalle.JUSTIFICACION = ""
                            End If

                            criterios.Clear()
                            criterios.Add(New SGAFP.EL.Criteria("ID_ASISTENCIA_AF", "=", lEntidad.ID_ASISTENCIA_AF, " AND "))
                            criterios.Add(New SGAFP.EL.Criteria("ID_PARTICIPANTE", "=", Me.ID_PARTICIPANTE, ""))
                            listaAsistenciaDetalle = bAsistenciaDetalle.ObtenerListaPorBusqueda(New ASISTENCIA_AF_DET, criterios.ToArray)

                            If listaAsistenciaDetalle IsNot Nothing AndAlso listaAsistenciaDetalle.Count > 0 Then eAsistenciaDetalle.ID_ASISTENCIA_DET = listaAsistenciaDetalle(0).ID_ASISTENCIA_DET

                            lRet = bAsistenciaDetalle.ActualizarASISTENCIA_AF_DET(eAsistenciaDetalle)
                            If lRet <= 0 Then
                                Me.AsignarMensaje("Error al Replicar Inasistencia:" + bAsistenciaDetalle.sError, True)
                                Exit For
                            End If
                        Next
                    End If
                End If
                CallbackPanel.JSProperties("cpResultCallback") = ""
                Me.dxgvLista.DataBind()
                'ActualizarInforme()

            Case Else
                Dim IdAsistenciaAF As Decimal

                'Obtener ID_ASISTENCIA_AF enviada a través de Callback
                IdAsistenciaAF = Decimal.Parse(parametros(0))
                Me.SetAsistenciaAF(IdAsistenciaAF)

                'Cargar asistencia
                Me.CargarAsistencia(Me.ID_ACCION_FORMATIVA, IdAsistenciaAF)
                ConfigurarEdicion()
                CallbackPanel.JSProperties("cpResultCallback") = ""
        End Select
    End Sub

    Protected Sub CallbackPanel_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CustomJSPropertiesEventArgs) Handles CallbackPanel.CustomJSProperties
        If Me.ID_ASISTENCIA_AF > 0 Then
            Dim Asistencia As New cASISTENCIA_AF
            Dim eAsistencia As ASISTENCIA_AF

            eAsistencia = Asistencia.ObtenerASISTENCIA_AF(Me.ID_ASISTENCIA_AF)
            If eAsistencia.CANTIDAD_HORAS < 60 Then
                e.Properties.Add("cpHorasTotales", "0")
                e.Properties.Add("cpMinutosTotales", eAsistencia.CANTIDAD_HORAS.ToString)
            Else
                e.Properties.Add("cpHorasTotales", Format(Math.Truncate(eAsistencia.CANTIDAD_HORAS / 60), "#"))
                e.Properties.Add("cpMinutosTotales", Format(eAsistencia.CANTIDAD_HORAS Mod 60, "#"))
            End If
        Else
            e.Properties.Add("cpHorasTotales", "0")
            e.Properties.Add("cpMinutosTotales", "0")
        End If
    End Sub
End Class
