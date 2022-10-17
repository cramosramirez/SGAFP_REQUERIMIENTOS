Imports System.Collections.Generic

Partial Class controles_ucFacturaBolproes
    Inherits ucBase

    Dim mListaRoles As New List(Of String)

    Public Sub Inicializar()
        Me.AsignarTituloOpcion("Registro de Factura de " + (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(Me.ObtenerIdProveedorAF).NOMBRE_PROVEEDOR)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        If EstaEnRol(RolDeUsuario.Bolproes) Then
            Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png", "onclick", "e.processOnServer=false;Guardar();")
            Me.ucBarraNavegacion1.CrearOpcion("AgregarCursos", "Agregar cursos a la factura", False, "~/imagenes/Agregar.gif", "onclick", "e.processOnServer=false;MostrarBusqueda();")
            Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Cancelar.gif", "onclick", "e.processOnServer=false;Cancelar();")
        End If
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucListaINFORME_FINAL_AF1.DataSource = New listaINFORME_FINAL_AF
        CargarProgramas()
    End Sub

    Private Sub CargarProgramas()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        mListaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        Me.odsProgramaFormacion.DataBind()
        Me.cbxProgramaFormacion.DataBind()
    End Sub

    Private Sub CargarContratos()
        odsContratoBolproes.SelectParameters("ID_PROGRAMA_FORMACION").DefaultValue = Me.cbxProgramaFormacion.Value.ToString
        odsContratoBolproes.SelectParameters("ID_TIPO_CONTRA").DefaultValue = Enumeradores.TipoContratacion.BOLPROS
        odsContratoBolproes.SelectParameters("asColumnaOrden").DefaultValue = "NUM_CONTRATO"
        odsContratoBolproes.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        odsContratoBolproes.DataBind()
        cbxContrato.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Inicializar()
        End If
    End Sub

    Protected Sub odsProgramaFormacion_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsProgramaFormacion.Selecting
        If e.InputParameters("listaRoles") Is Nothing Then e.InputParameters("listaRoles") = mListaRoles
    End Sub

    Protected Sub cFacturaBolproes_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cFacturaBolproes.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        cFacturaBolproes.JSProperties.Clear()
        cFacturaBolproes.JSProperties.Add("cpResultCallback", "")

        Select Case parametros(0)
            Case "Guardar"
                Dim lFactura As New cFACTURA_AF
                Dim lCriterios As New List(Of Criteria)
                Dim lEntidadEnca As New FACTURA_AF
                Dim lInformesFacturar As New listaINFORME_FINAL_AF

                lInformesFacturar = TryCast(ucListaINFORME_FINAL_AF1.DataSource, listaINFORME_FINAL_AF)
                If cbxProgramaFormacion.Value Is Nothing Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Seleccione el Programa."
                    Return
                End If
                If Me.speRegNumeroDocumento.Value Is Nothing OrElse Not IsNumeric(Me.speRegNumeroDocumento.Value) Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "N° de Documento inválido. Por favor verifique."
                    Return
                End If
                If Me.cbxRegTipoDocumento.Value Is Nothing Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Seleccione el Tipo de Documento."
                    Return
                End If
                If Me.dteRegFechaEmision.Value Is Nothing Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Digite la fecha del documento."
                    Return
                End If
                If lInformesFacturar.Count = 0 Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Agregue Cursos a la factura."
                    Return
                End If

                lEntidadEnca.ID_FACTURA_AF = 0
                lEntidadEnca.ID_PROVEEDOR_AF = Me.ObtenerIdProveedorAF
                lEntidadEnca.NUMERO_DOCUMENTO = Me.speRegNumeroDocumento.Value.ToString
                lEntidadEnca.TIPO_DOCUMENTO = Me.cbxRegTipoDocumento.Value
                lEntidadEnca.FECHA_DOCUMENTO = Me.dteRegFechaEmision.Date
                lEntidadEnca.NUMERO_QUEDAN = -1
                lEntidadEnca.ESTADO = Enumeradores.EstadoFactura.Emitida
                lEntidadEnca.USERID = Me.ObtenerUsuario
                lEntidadEnca.LASTUPDATE = Now
                If lFactura.ActualizarFACTURA_AF(lEntidadEnca) = 1 Then
                    For Each lInforme As INFORME_FINAL_AF In lInformesFacturar
                        If (New cFACTURA_DET).AgregarFACTURA_DET(0, lEntidadEnca.ID_FACTURA_AF, lInforme.ID_INFORME_FINAL, Me.ObtenerUsuario, Now) <> 1 Then
                            cFacturaBolproes.JSProperties("cpResultCallback") = "No se pudo Registrar la Factura"
                            Return
                        End If
                    Next
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Factura registrada con exito!"
                Else
                    cFacturaBolproes.JSProperties("cpResultCallback") = "No se pudo Registrar la Factura"
                End If

            Case "MostrarBusqueda"
                CargarContratos()
                Me.cbxContrato.SelectedIndex = -1
                Me.speNumItem.Value = 0
                Me.ucListaINFORME_FINAL_AF2.CargarDatosPorInformeFacturarCallback("BuscarDatos", New String() {"CargarDatosPorFacturarContratoItemBolpros", -1, -1, -1})
                cFacturaBolproes.JSProperties("cpResultCallback") = "MostrarPopupCursos"

            Case "BuscarCursos"
                Dim idContrato As Decimal
                If cbxContrato.Value Is Nothing Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Seleccione el Contrato."
                    Return
                End If
                If speNumItem.Value Is Nothing OrElse speNumItem.Value = 0 Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Ingrese el N° de Item."
                    Return
                End If
                idContrato = cbxContrato.Value
                Me.ucListaINFORME_FINAL_AF2.CargarDatosPorInformeFacturarCallback("BuscarDatos", New String() {"CargarDatosPorFacturarContratoItemBolpros", Me.cbxProgramaFormacion.Value, idContrato, Me.speNumItem.Value})
                CargarContratos()
                cbxContrato.SelectedItem = cbxContrato.Items.FindByValue(idContrato)

            Case "AgregarCursos"
                Dim lInformesFacturar As New listaINFORME_FINAL_AF
                Dim lListaInformesOrigen As listaINFORME_FINAL_AF = ucListaINFORME_FINAL_AF2.DevolverSeleccionados
                lInformesFacturar = TryCast(ucListaINFORME_FINAL_AF1.DataSource, listaINFORME_FINAL_AF)

                If lListaInformesOrigen.Count = 0 Then
                    cFacturaBolproes.JSProperties("cpResultCallback") = "Seleccione al menos un curso."
                    Return
                End If
                For Each lEntidad As INFORME_FINAL_AF In lListaInformesOrigen
                    If lInformesFacturar.BuscarPorId(lEntidad.ID_INFORME_FINAL) Is Nothing Then
                        lInformesFacturar.Add(lEntidad)
                    End If
                Next
                Me.ucListaINFORME_FINAL_AF1.DataSource = lInformesFacturar
                cFacturaBolproes.JSProperties("cpResultCallback") = "OcultarPopupCursos"

            Case "LimpiarBusqueda"
                Me.speNumItem.Value = 0
                Me.cbxContrato.SelectedIndex = 0
        End Select
    End Sub
End Class
