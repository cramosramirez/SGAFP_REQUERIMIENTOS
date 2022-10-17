Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports System.Collections.Generic

Partial Class controles_ucGenerarInformeParcial
    Inherits ucBase
    Private _listaInformeParcial As New listaINFORME_FINAL_AF
    Public Property listaInformeParcial() As listaINFORME_FINAL_AF
        Get
            Return _listaInformeParcial
        End Get
        Set(ByVal value As listaINFORME_FINAL_AF)
            _listaInformeParcial = value
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Set(ByVal value As Decimal)
            Me.ViewState("infIdAccionFormativa") = value
            Inicializar()
        End Set
        Get
            If Me.ViewState("infIdAccionFormativa") = Nothing Then Return 0 Else Return Me.ViewState("infIdAccionFormativa")
        End Get
    End Property


    Public Property FECHA_INICIAL_INFORME() As Date
        Set(ByVal value As Date)
            Me.ViewState("fechaInicial") = value
        End Set
        Get
            If Me.ViewState("fechaInicial") = Nothing Then Return #12:00:00 AM# Else Return Me.ViewState("fechaInicial")
        End Get
    End Property

    Private Sub Inicializar()
        'Obtener la fecha final del último informe presentado
        Dim listaInformes As listaINFORME_FINAL_AF
        Dim listaAsistenciaAF As listaASISTENCIA_AF
        Dim lEntidad As ACCION_FORMATIVA_DETALLE

        listaInformes = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA, False, False, "FECHA_FINAL", "DESC")
        listaAsistenciaAF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA, False, False, "FECHA", "ASC")
        cbxFechaFinPeriodo.Items.Clear()

        If listaAsistenciaAF IsNot Nothing AndAlso listaAsistenciaAF.Count > 0 Then
            If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                For i As Integer = 0 To listaAsistenciaAF.Count - 1
                    If listaAsistenciaAF(i).FECHA > listaInformes(0).FECHA_FINAL Then
                        Me.FECHA_INICIAL_INFORME = listaAsistenciaAF(i).FECHA
                        Exit For
                    End If
                Next
            Else
                Me.FECHA_INICIAL_INFORME = listaAsistenciaAF(0).FECHA
            End If
            lblInicioPeriodo.Text = Me.FECHA_INICIAL_INFORME.ToString("dd/MM/yyy")
            lEntidad = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.ID_ACCION_FORMATIVA)
            Select Case lEntidad.ID_PROGRAMA_FORMACION
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL, Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    Dim ultFechaAntes11marzo As Date
                    For i As Integer = 0 To listaAsistenciaAF.Count - 1
                        If listaAsistenciaAF(i).FECHA <= New DateTime(2020, 3, 11) Then
                            ultFechaAntes11marzo = listaAsistenciaAF(i).FECHA
                        Else
                            Me.cbxFechaFinPeriodo.Items.Add(ultFechaAntes11marzo.ToString("dd/MM/yyyy"))
                            Exit For
                        End If
                    Next
                    Me.dteFechaFinal.Visible = False
                Case Else
                    Me.cbxFechaFinPeriodo.Visible = False
            End Select
        End If

        Me.cbxFechaFinPeriodo.Text = ""
        Me.cbxFechaFinPeriodo.SelectedIndex = -1
        Me.dteFechaFinal.Date = Nothing
        Session("Anexo1") = Nothing
        CargarDatos()
    End Sub

    Protected Sub cpInformeParcial_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cpInformeParcial.Callback
        Dim parametros() As String = e.Parameter.Split(";")

        Select Case parametros(0)
            Case "MostrarInforme"
                Dim lEntidad As New INFORME_FINAL_AF
                Dim bInformeParcial As New cINFORME_FINAL_AF
                Dim fechaFinPeriodo As Date

                If Me.cbxFechaFinPeriodo.Visible Then
                    fechaFinPeriodo = DateTime.Parse(Me.cbxFechaFinPeriodo.Text, New System.Globalization.CultureInfo("fr-FR", False))
                Else
                    fechaFinPeriodo = Me.dteFechaFinal.Date
                End If

                lEntidad = bInformeParcial.GenerarInformePorPeriodoEjecucion(Me.ID_ACCION_FORMATIVA, Me.FECHA_INICIAL_INFORME, fechaFinPeriodo, False)
                If lEntidad Is Nothing Then
                    cpInformeParcial.JSProperties("cpResultCallback") = bInformeParcial.sError
                    Me.cbxFechaFinPeriodo.SelectedIndex = -1
                    Me.dteFechaFinal.Date = Nothing
                    Me.listaInformeParcial = Nothing
                Else
                    Me.listaInformeParcial = New listaINFORME_FINAL_AF
                    Me.listaInformeParcial.Add(lEntidad)
                End If
                Session("Anexo1") = Me.listaInformeParcial
                CargarDatos()
            Case Else
        End Select
    End Sub

    Public Function Actualizar() As String
        If Session("Anexo1") IsNot Nothing AndAlso CType(Session("Anexo1"), listaINFORME_FINAL_AF).Count > 0 Then
            Dim bInformeFinal As New cINFORME_FINAL_AF
            Dim listaInforme As listaINFORME_FINAL_AF

            listaInforme = CType(Session("Anexo1"), listaINFORME_FINAL_AF)
            Dim lInforme As INFORME_FINAL_AF = bInformeFinal.GenerarInformePorPeriodoEjecucion(Me.ID_ACCION_FORMATIVA, Me.FECHA_INICIAL_INFORME, DateTime.Parse(Me.cbxFechaFinPeriodo.Text, New System.Globalization.CultureInfo("fr-FR", False)), True)
            If lInforme Is Nothing Then
                Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & bInformeFinal.sError, True, True)
                Return "Error al Guardar registro."
            End If
        Else
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "No se ha generado la Vista Previa del Informe", True, True)
            Return "Error al Guardar registro."
        End If
        Return ""
    End Function

    Private Sub CargarDatos()
        Me.dgvInformeParcial.DataSource = Session("Anexo1")
        Me.dgvInformeParcial.DataBind()
        If Session("Anexo1") IsNot Nothing AndAlso CType(Session("Anexo1"), listaINFORME_FINAL_AF).Count > 0 Then
            Me.dgvDetalleInformeParcial.DataSource = CType(Session("Anexo1"), listaINFORME_FINAL_AF)(0).INFORME_FINAL_DET_INFORME_FINAL
        Else
            Me.dgvDetalleInformeParcial.DataSource = Nothing
        End If
        Me.dgvDetalleInformeParcial.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then Session("Anexo1") = Nothing
        CargarDatos()
    End Sub

    Protected Sub dgvInformeParcial_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dgvInformeParcial.CustomUnboundColumnData
        Dim lEntidad As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
        If e.Column.FieldName = "Curso" Then
            e.Value = lEntidad.NOMBRE_ACCION_FORMATIVA
        ElseIf e.Column.FieldName = "CodigoGrupo" Then
            e.Value = lEntidad.CODIGO_GRUPO
        ElseIf e.Column.FieldName = "PORCENTAJE_EJECUCION" Then
            If CDec(e.GetListSourceFieldValue("HORAS_DESARROLLADAS")) > 0 Then
                e.Value = Math.Round(CDec(e.GetListSourceFieldValue("HORAS_DESARROLLADAS")) / lEntidad.DURACION_HORAS, 4)
            End If
        ElseIf e.Column.FieldName = "COSTO_X_PARTICIPANTE" Then
            e.Value = lEntidad.COSTO_X_PARTICIPANTE
        ElseIf e.Column.FieldName = "LugarEjecucion" Then
            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lAccionDetalle IsNot Nothing Then
                e.Value = lAccionDetalle.LUGAR_EJECUCION
            End If
        ElseIf e.Column.FieldName = "HorasTotales" Then
            e.Value = lEntidad.DURACION_HORAS
        ElseIf e.Column.FieldName = "HorasAcumuladas" Then
            Dim listaInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
            Dim horasAcumuladas As Decimal = CDec(e.GetListSourceFieldValue("HORAS_DESARROLLADAS"))
            If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                For i As Integer = 0 To listaInformeParcial.Count - 1
                    horasAcumuladas += listaInformeParcial(i).HORAS_DESARROLLADAS
                Next
            End If
            e.Value = horasAcumuladas
        End If
    End Sub

    Protected Sub dgvDetalleInformeParcial_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dgvDetalleInformeParcial.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRES_APELLIDOS" Then
            Dim lParticipante As PARTICIPANTE
            lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(e.GetListSourceFieldValue("ID_PARTICIPANTE"))
            If lParticipante IsNot Nothing Then
                e.Value = String.Format("{0} {1}", lParticipante.APELLIDOS, lParticipante.NOMBRES)
            End If
        ElseIf e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        ElseIf e.Column.FieldName = "NOTA_TEORICA_OBTENIDA" Then
            If CDec(e.GetListSourceFieldValue("NOTA_TEORICA")) < 0 Then e.Value = 0 Else e.Value = CDec(e.GetListSourceFieldValue("NOTA_TEORICA"))
        ElseIf e.Column.FieldName = "NOTA_PRACTICA_OBTENIDA" Then
            If CDec(e.GetListSourceFieldValue("NOTA_PRACTICA")) < 0 Then e.Value = 0 Else e.Value = CDec(e.GetListSourceFieldValue("NOTA_PRACTICA"))
        ElseIf e.Column.FieldName = "NOTA_FINAL" Then
            If CDec(e.GetListSourceFieldValue("NOTA_OBTENIDA")) < 0 Then e.Value = 0 Else e.Value = CDec(e.GetListSourceFieldValue("NOTA_OBTENIDA"))
        End If
    End Sub
End Class
