Imports System.Collections.Generic

Partial Class GFI_wfCorreccionDatosParticipante
    Inherits System.Web.UI.Page

    Protected Sub cCDatosParticipante_Callback(sender As Object, e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cCDatosParticipante.Callback
        Dim parametros() As String = e.Parameter.Split(";")

        cCDatosParticipante.JSProperties.Clear()
        cCDatosParticipante.JSProperties.Add("cpResultCallback", "")

        Select Case parametros(0)
            Case "BuscarFichasPATI"
                Dim lDetaFami As New PATI.EL.listaDETA_FAMI
                Dim bDetaFami As New cDETA_FAMI
                Dim lCriterios As New List(Of PATI.EL.Criteria)
                Dim lParticipantes As listaPARTICIPANTE

                Me.txtID_PARTICIPANTE.Text = ""
                Me.txtNOMBRES.Text = ""
                Me.txtAPELLIDOS.Text = ""
                Me.txtFECHA_NACIMIENTO.Text = ""
                Me.txtDEPARTAMENTO.Text = ""
                Me.txtMUNICIPIO.Text = ""
                Me.ucListaFICHA_PATI1.CargarDatosPorCallback("BuscarDatos", parametros)

                lCriterios.Add(New PATI.EL.Criteria("NUME_FAMI", "=", parametros(1), ""))
                lDetaFami = bDetaFami.ObtenerListaPorBusqueda(New PATI.EL.DETA_FAMI, lCriterios.ToArray)
                If lDetaFami IsNot Nothing AndAlso lDetaFami.Count > 0 Then
                    If lDetaFami(0).NUME_DOCU_IDEN.Length = 9 Then
                        'Recuperar participante por DUI
                        lParticipantes = (New cPARTICIPANTE).ObtenerListaPorDUI(lDetaFami(0).NUME_DOCU_IDEN)
                        If lParticipantes IsNot Nothing AndAlso lParticipantes.Count > 0 Then
                            Dim lDepto As DEPARTAMENTO
                            Dim lMuni As MUNICIPIO

                            Me.txtID_PARTICIPANTE.Text = lParticipantes(0).ID_PARTICIPANTE
                            Me.txtNOMBRES.Text = lParticipantes(0).NOMBRES
                            Me.txtAPELLIDOS.Text = lParticipantes(0).APELLIDOS
                            If lParticipantes(0).FECHA_NACIMIENTO <> #12:00:00 AM# Then Me.txtFECHA_NACIMIENTO.Text = lParticipantes(0).FECHA_NACIMIENTO.ToString("dd/MM/yyyy")
                            If lParticipantes(0).CODIGO_DEPARTAMENTO <> "" Then
                                lDepto = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lParticipantes(0).CODIGO_DEPARTAMENTO)
                                If lDepto IsNot Nothing Then Me.txtDEPARTAMENTO.Text = lDepto.NOMBRE
                                If lParticipantes(0).CODIGO_MUNICIPIO <> "" Then
                                    lMuni = (New cMUNICIPIO).ObtenerMUNICIPIO(lParticipantes(0).CODIGO_DEPARTAMENTO, lParticipantes(0).CODIGO_MUNICIPIO)
                                    If lMuni IsNot Nothing Then Me.txtMUNICIPIO.Text = lMuni.NOMBRE
                                End If
                            End If
                        Else
                            cCDatosParticipante.JSProperties("cpResultCallback") = "No se puede recuperar el participante debido a que no se encontro correspondencia con el DUI de ficha pati"
                        End If
                    Else
                        cCDatosParticipante.JSProperties("cpResultCallback") = "No se puede recuperar el participante debido a que no posee numero de DUI"
                    End If
                End If

            Case "GuardarCambios"
                Dim lParticipante As PARTICIPANTE
                Dim bParticipante As New cPARTICIPANTE

                If Me.txtID_PARTICIPANTE.Text = "" Then
                    cCDatosParticipante.JSProperties("cpResultCallback") = "No se puede recuperar el participante debido a que no posee numero de DUI"
                    Return
                End If
                If Me.txtNOMBRES.Text.Trim = "" Then
                    cCDatosParticipante.JSProperties("cpResultCallback") = "Ingrese los nombres del participante"
                    Return
                End If
                If Me.txtAPELLIDOS.Text.Trim = "" Then
                    cCDatosParticipante.JSProperties("cpResultCallback") = "Ingrese los apellidos del participante"
                    Return
                End If
                lParticipante = bParticipante.ObtenerPARTICIPANTE(Convert.ToDecimal(Me.txtID_PARTICIPANTE.Text))
                If lParticipante IsNot Nothing Then
                    lParticipante.NOMBRES = Me.txtNOMBRES.Text.Trim.ToUpper
                    lParticipante.APELLIDOS = Me.txtAPELLIDOS.Text.Trim.ToUpper
                    If bParticipante.ActualizarPARTICIPANTE(lParticipante) <> 1 Then
                        cCDatosParticipante.JSProperties("cpResultCallback") = "Error al guardar: " + bParticipante.sError
                        Return
                    End If
                    cCDatosParticipante.JSProperties("cpResultCallback") = "Los cambios se guardaron con exito"
                    Me.txtNUM_CONVENIO.Text = ""
                    Me.txtID_PARTICIPANTE.Text = ""
                    Me.txtNOMBRES.Text = ""
                    Me.txtAPELLIDOS.Text = ""
                    Me.txtFECHA_NACIMIENTO.Text = ""
                    Me.txtDEPARTAMENTO.Text = ""
                    Me.txtMUNICIPIO.Text = ""
                    Me.ucListaFICHA_PATI1.CargarDatosPorENCA_FICH_PATI(0)
                End If
        End Select
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        End If
    End Sub

    Private Sub Inicializar()
        Me.UcBarraNavegacion1.LimpiarOpciones()
        Me.UcBarraNavegacion1.Navegacion = False
        Me.UcBarraNavegacion1.PermitirAgregar = False
        Me.UcBarraNavegacion1.PermitirEditar = False
        Me.UcBarraNavegacion1.PermitirGuardar = False
        Me.UcBarraNavegacion1.HabilitarEdicion(False)
        Me.UcBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~/imagenes/view.gif", "onclick", "e.processOnServer=false;BuscarFichasPATI();")
        Me.UcBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png", "onclick", "e.processOnServer=false;GuardarCambiosParticipante();")
        Me.UcBarraNavegacion1.CargarOpciones()
    End Sub
End Class
