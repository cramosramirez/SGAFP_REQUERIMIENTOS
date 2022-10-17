Imports System.Collections.Generic

Partial Class controles_ucConvocatoriasMunicipioPATI
    Inherits ucBase

    Public Sub Inicializar()
        Me.AsignarTituloOpcion("Administracion de Convocatorias PATI")
        Me.ucListaMUNICIPIO_CONVOCATORIA1.CargarDatosPorCriteriosCallback("BuscarDatos", New String() {"CargarDatosPorCriterios", -1, "", "", -1})

        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.ucBarraNavegacion1.CrearOpcion("BuscarConvocatorias", "Buscar", False, "~/imagenes/ButtonSearch.png", "onclick", "e.processOnServer=false;CargarConvocatorias();")
        Me.ucBarraNavegacion1.CrearOpcion("RegistrarConvocatoria", "Registrar Convocatoria", False, "~/imagenes/nuevo.png", "onclick", "e.processOnServer=false;RegistrarConvocatoria();")
        Me.ucBarraNavegacion1.CrearOpcion("LiquidacionMunicipio", "Generar Liquidación por Municipio", False, "~/imagenes/dinero2.png", "onclick", "e.processOnServer=false;MostrarCursosPorLiquidar();")
        Me.ucBarraNavegacion1.CrearOpcion("AnexosTAF", "Anexos TAF", False, "~/imagenes/ButtonPrint.png", "onclick", "e.processOnServer=false;MostrarPopupAnexosTAF();")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.dxgvCursosPorLiquidar.GroupBy(dxgvCursosPorLiquidar.Columns("NOMBRE_MUNICIPIO"))
        Me.dxgvCursosPorLiquidar.ExpandAll()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack And Not Page.IsCallback Then
            Inicializar()
        End If
        ActualizarCargarDatosCallback()
    End Sub

    Public Sub ActualizarCargarDatosCallback()
        If hfConvLiq.Contains("CargarCursos") Then
            If hfConvLiq("CargarCursos") = "CargarCursosPorLiquidar" Then
                Me.CargarCursosPorLiquidar(CDec(hfConvLiq("param1")), CDec(hfConvLiq("param2")), hfConvLiq("param3"), hfConvLiq("param4"))
            End If
        End If
    End Sub

    Public Sub CargarCursosPorLiquidarCallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "CargarCursos" Then
            Me.dxgvCursosPorLiquidar.Selection.UnselectAll()
            If hfConvLiq.Contains("CargarCursos") Then hfConvLiq("CargarCursos") = parametros(0) Else hfConvLiq.Add("CargarCursos", parametros(0))
            For i As Integer = 1 To parametros.Length - 1
                If hfConvLiq.Contains("param" + (i).ToString) Then hfConvLiq.Remove("param" + (i).ToString)
            Next
            For i As Integer = 1 To parametros.Length - 1
                hfConvLiq.Add("param" + (i).ToString, parametros(i))
            Next
            Me.ActualizarCargarDatosCallback()
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de las Acciones Formativas y Facturas por liquidar
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	20/12/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarCursosPorLiquidar(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        Me.odsListaCursosPorLiquidar.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE.ToString()
        Me.odsListaCursosPorLiquidar.SelectParameters("NO_CONVOCATORIA").DefaultValue = NO_CONVOCATORIA.ToString()
        Me.odsListaCursosPorLiquidar.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaCursosPorLiquidar.SelectParameters("CODIGO_MUNICIPIO").DefaultValue = CODIGO_MUNICIPIO.ToString()
        Me.odsListaCursosPorLiquidar.DataBind()
        Me.dxgvCursosPorLiquidar.DataSourceID = "odsListaCursosPorLiquidar"
        Me.dxgvCursosPorLiquidar.Visible = True
        Me.dxgvCursosPorLiquidar.DataBind()
        Return 1
    End Function

    Protected Sub cMunicipioConv_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cMunicipioConv.Callback
        Dim param() As String = e.Parameter.Split(";")
        cMunicipioConv.JSProperties.Clear()
        cMunicipioConv.JSProperties.Add("cpResultCallback", "")

        Select Case param(0)
            Case "CargarConvocatorias"
                Me.ucListaMUNICIPIO_CONVOCATORIA1.CargarDatosPorCriteriosCallback("BuscarDatos", New String() {"CargarDatosPorCriterios", param(1), param(2), param(3), param(4)})

            Case "RegistrarConvocatoria"
                Dim lucVista As controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA
                lucVista = TryCast(Me.PopupControlContentControl1.FindControl("ucVistaDetalleMUNICIPIO_CONVOCATORIA1"), controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA)
                If lucVista IsNot Nothing Then lucVista.Nuevo()
                cMunicipioConv.JSProperties("cpResultCallback") = "MostrarPopupRegistroConvocatoria"

            Case "GuardarConvocatoria"
                Dim lucVista As controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA
                Dim lRet As New String("")
                lucVista = TryCast(Me.PopupControlContentControl1.FindControl("ucVistaDetalleMUNICIPIO_CONVOCATORIA1"), controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA)
                lRet = lucVista.Actualizar()
                If lRet = "" Then
                    cMunicipioConv.JSProperties("cpResultCallback") = "Convocatoria registrada con éxito!"
                    lucVista.DataBind()
                Else
                    cMunicipioConv.JSProperties("cpResultCallback") = "Error al Guardar Convocatoria: " + lRet
                End If

            Case "EditarConvocatoria"
                Me.ucVistaDetalleMUNICIPIO_CONVOCATORIA1.CargarMunicipioConvocatoria(CDec(param(1)), CDec(param(2)), param(3), param(4))
                cMunicipioConv.JSProperties("cpResultCallback") = "MostrarPopupEdicion"

            Case "CargarCursosPorLiquidar"
                Me.CargarCursosPorLiquidarCallback("CargarCursos", New String() {param(0), param(1), param(2), param(3), param(4)})
                cMunicipioConv.JSProperties("cpResultCallback") = "MostrarPopupCursosPorLiquidar"

            Case "EliminarLiquidacion"
                Dim lbMunicipioLiqui As New cMUNICIPIO_LIQUIDACION
                Dim lEntidad = lbMunicipioLiqui.ObtenerMUNICIPIO_LIQUIDACION(CDec(param(1)))
                If lbMunicipioLiqui.EliminarMUNICIPIO_LIQUIDACION(CDec(param(1))) = 1 Then
                    'Actualizar Monto Liquidado
                    Dim lConvocatoria As MUNICIPIO_CONVOCATORIA = (New cMUNICIPIO_CONVOCATORIA).ObtenerMUNICIPIO_CONVOCATORIA(lEntidad.ID_FUENTE, lEntidad.NO_CONVOCATORIA, lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO)
                    If lConvocatoria IsNot Nothing Then
                        lConvocatoria.MONTO_LIQUIDADO -= lEntidad.MONTO_LIQUIDADO
                        lConvocatoria.USERID = Me.ObtenerUsuario
                        lConvocatoria.LASTUPDATE = Now
                        If (New cMUNICIPIO_CONVOCATORIA).ActualizarMUNICIPIO_CONVOCATORIA(lConvocatoria) = 1 Then
                            cMunicipioConv.JSProperties("cpResultCallback") = "Liquidación Eliminada con éxito!"
                            Return
                        End If
                    End If
                End If
                cMunicipioConv.JSProperties("cpResultCallback") = "Error al Eliminar Liquidación"

            Case "GenerarLiquidacionPorMunicipio"
                Dim lbLiquidacion As New cMUNICIPIO_LIQUIDACION
                Dim lbDepartamento As New cDEPARTAMENTO
                Dim lbMunicipio As New cMUNICIPIO
                Dim lListaMunicConv As listaMUNICIPIO_CONVOCATORIA
                Dim lListaMunicLiqui As New listaMUNICIPIO_LIQUIDACION
                Dim lRet As Integer
                Dim lFechaLiquidacion As Date = Today
                Dim mLista As New List(Of Decimal)

                lListaMunicConv = (New cMUNICIPIO_CONVOCATORIA).ObtenerListaPorFUENTE_CONVOCATORIA(CDec(param(1)), CDec(param(2)))
                If lListaMunicConv IsNot Nothing AndAlso lListaMunicConv.Count > 0 Then
                    For Each lIdAccion As Decimal In Me.dxgvCursosPorLiquidar.GetSelectedFieldValues("ID_ACCION_FORMATIVA")
                        mLista.Add(lIdAccion)
                    Next
                    If mLista.Count = 0 Then
                        cMunicipioConv.JSProperties("cpResultCallback") = "Seleccione al menos un curso"
                        Return
                    End If

                    lRet = lbLiquidacion.GenerarMunicipioLiquidacion(CDec(param(1)), CDec(param(2)), mLista)
                    If lRet > 0 Then
                        cMunicipioConv.JSProperties("cpResultCallback") = "Liquidación por Municipio Generada con éxito!"
                        cMunicipioConv.JSProperties("cpCommentCallback") = "Se generó Liquidación con fecha: <b>" + String.Format("{0:dd/MM/yyyy}", lFechaLiquidacion) + "</b>"
                    Else
                        cMunicipioConv.JSProperties("cpResultCallback") = "No se generó ninguna Liquidación para el <b>" + String.Format("{0:dd/MM/yyyy}", lFechaLiquidacion) + "</b>"
                    End If
                Else
                    cMunicipioConv.JSProperties("cpResultCallback") = "No se generó ninguna Liquidación. No existen Convocatorias Ingresadas"
                End If

            Case "MostrarPopupAnexosTAF"
                CargarFechasLiquidacion(CDec(param(1)), CDec(param(2)))
                If Me.cbxFechasLiquidacion.Items.Count > 0 Then
                    ConfigurarUrlReportes(CDec(param(1)), CDec(param(2)), _
                            Date.Parse(cbxFechasLiquidacion.Value, New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                Else
                    ConfigurarUrlReportes(CDec(param(1)), CDec(param(2)), Nothing)
                End If
                Me.popupAnexosTAF.ShowOnPageLoad = True
                cMunicipioConv.JSProperties("cpResultCallback") = ""

            Case "ActualizarURLreportes"
                Dim fechaLiq As Date = Date.Parse(param(3), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault)
                CargarFechasLiquidacion(CDec(param(1)), CDec(param(2)))
                cbxFechasLiquidacion.SelectedItem = cbxFechasLiquidacion.Items.FindByValue(fechaLiq.ToString("dd/MM/yyyy"))
                ConfigurarUrlReportes(CDec(param(1)), CDec(param(2)), fechaLiq)
                cMunicipioConv.JSProperties("cpResultCallback") = ""
        End Select
    End Sub

    Private Sub ConfigurarUrlReportes(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal FECHA_ELABORACION As Object)
        Dim strUrlReporte As String = "../Reportes/wfReporteAnexosTAF.aspx?"
        Dim strParametros As New StringBuilder

        strParametros.Append("fte=")
        strParametros.Append(ID_FUENTE.ToString)
        strParametros.Append("&con=")
        strParametros.Append(NO_CONVOCATORIA.ToString)

        Me.lnkTAF3AFec.ClientVisible = False
        Me.lnkTAF3AFec2.ClientVisible = False
        Me.lnkTAF4AFec.ClientVisible = False
        Me.lnkTAF5RevFec.ClientVisible = False
        Me.lnkTAF5Fec.ClientVisible = False
        Me.lnkTAF9Fec.ClientVisible = False

        If FECHA_ELABORACION IsNot Nothing Then
            strParametros.Append("&fliq=")
            strParametros.Append(String.Format("{0:ddMMyyyy}", CDate(FECHA_ELABORACION)))
            If ID_FUENTE = Enumeradores.FuenteFinanciamientoPATI.PATI_BM OrElse ID_FUENTE = Enumeradores.FuenteFinanciamientoPATI.PATI_GOES Then
                lnkTAF3AFec.NavigateUrl = strUrlReporte + "a=3&" + strParametros.ToString
                lnkTAF5RevFec.NavigateUrl = strUrlReporte + "a=51&" + strParametros.ToString
                lnkTAF5Fec.NavigateUrl = strUrlReporte + "a=5&" + strParametros.ToString
                Me.lnkTAF3AFec.Text = "TAF-3A"
                Me.lnkTAF3AFec.ClientVisible = True
                Me.lnkTAF5RevFec.ClientVisible = True
                Me.lnkTAF5Fec.ClientVisible = True
            Else
                Me.lnkTAF4AFec.NavigateUrl = strUrlReporte + "a=4&" + strParametros.ToString
                Me.lnkTAF5RevFec.NavigateUrl = strUrlReporte + "a=51&" + strParametros.ToString
                Me.lnkTAF5Fec.NavigateUrl = strUrlReporte + "a=5&" + strParametros.ToString
                Me.lnkTAF9Fec.NavigateUrl = strUrlReporte + "a=9&" + strParametros.ToString
                Me.lnkTAF4AFec.ClientVisible = True
                Me.lnkTAF5RevFec.ClientVisible = True
                Me.lnkTAF5Fec.ClientVisible = True
                Me.lnkTAF9Fec.ClientVisible = True
            End If
        End If

        If ID_FUENTE = Enumeradores.FuenteFinanciamientoPATI.PATI_USAID Then
            lnkTAF3AFec.NavigateUrl = strUrlReporte + "a=3&idl=1&" + strParametros.ToString
            lnkTAF3AFec2.NavigateUrl = strUrlReporte + "a=3&idl=2&" + strParametros.ToString
            Me.lnkTAF3AFec.Text = "TAF-3A 1er Desembolso"
            Me.lnkTAF3AFec2.Text = "TAF-3A 2do Desembolso"
            Me.lnkTAF3AFec.ClientVisible = True
            Me.lnkTAF3AFec2.ClientVisible = True
        End If
    End Sub

    Private Sub CargarFechasLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal)
        Me.odsFechasLiquidacion.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE
        Me.odsFechasLiquidacion.SelectParameters("NO_CONVOCATORIA").DefaultValue = NO_CONVOCATORIA
        Me.cbxFechasLiquidacion.DataBind()
        If Me.cbxFechasLiquidacion.Items.Count > 0 Then Me.cbxFechasLiquidacion.SelectedIndex = 0
    End Sub
  
End Class
