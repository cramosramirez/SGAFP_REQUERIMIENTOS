Imports DevExpress.Web.ASPxEditors
Imports SQLMembershipProvider.EL
Imports SQLMembershipProvider.BL
Imports DevExpress.Web.ASPxTreeList

Partial Class controles_ucGestionOpcionesPorRol
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()

        ConfigurarOpcionMenu(40)

        'Me.AsignarTituloOpcion("Gestionar Opciones por Rol", "~/imagenes/pro.png")
        'Me.CrearOpcion("Agregar", "Agregar", False, "~/imagenes/Agregar.gif", "onclick", "if(cbRoles.GetValue()!=null){tlOpciones.StartEditNewNode();}else{AsignarMensaje('Debe de seleccionar un Rol');}e.processOnServer=false;")
        'Me.CargarOpciones()
        Dim mRoles() As String = Roles.GetAllRoles
        For Each rol As String In mRoles
            Dim lCriterios(0) As SQLMembershipProvider.EL.Criteria
            lCriterios(0) = New SQLMembershipProvider.EL.Criteria("RoleName", "=", rol, "")
            Dim lRoles As SQLMembershipProvider.EL.listaAspnet_Roles
            lRoles = (New SQLMembershipProvider.BL.cAspnet_Roles).ObtenerListaPorBusqueda(New SQLMembershipProvider.EL.Aspnet_Roles, lCriterios)
            If lRoles.Count > 0 Then
                Me.cbRoles.Items.Add(rol, lRoles(0).RoleId)
            Else
                Me.cbRoles.Items.Add(rol, rol)
            End If
        Next
    End Sub

    Protected Sub tlOpciones_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs) Handles tlOpciones.CustomCallback
        Dim argumentos() As String = e.Argument.Split(";")
        If argumentos.Length > 0 Then
            If argumentos(0) = "Recuperar" Then
                'Dim l As New SQLMembershipProvider.EL.listaOpcionesPorRol
                'l = (New SQLMembershipProvider.BL.cOpcionesPorRol).ObtenerListaPorAspnet_Roles(New Guid(Me.cbRoles.Value.ToString))
                tlOpciones.DataBind()
                'Dim a As Integer = 0
            End If

        End If
    End Sub

    'Protected Sub ucBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
    '    Me.tlOpciones.StartEditNewNode(0)
    'End Sub

    Protected Sub tlOpciones_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListHtmlRowEventArgs) Handles tlOpciones.HtmlRowPrepared
        If e.RowKind = DevExpress.Web.ASPxTreeList.TreeListRowKind.EditForm Then
            Dim cbOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcion")
            Dim chkHabilitado As ASPxCheckBox = tlOpciones.FindEditFormTemplateControl("chkHabilitado")
            If e.NodeKey Is Nothing Then
                cbOpcion.SelectedIndex = 0
                cbOpcion.ClientEnabled = True
                chkHabilitado.Checked = True
            Else
                cbOpcion.ClientEnabled = False
                cbOpcion.Value = e.NodeKey
                Dim lOpcion As OpcionesPorRol = (New cOpcionesPorRol).ObtenerOpcionesPorRol(New Guid(Me.cbRoles.Value.ToString()), CInt(e.NodeKey))
                chkHabilitado.Checked = lOpcion.Habilitado
            End If
        End If
    End Sub

    Public Function GetOpcionMenu(ByVal container As TreeListDataCellTemplateContainer) As String
        Dim lOpcion As OpcionesMenu
        lOpcion = (New cOpcionesMenu).ObtenerOpcionesMenu(CInt(container.NodeKey))
        Return lOpcion.DescripcionMenu
    End Function

    Public Function GetOpcionURL(ByVal container As TreeListDataCellTemplateContainer) As String
        Dim lOpcion As OpcionesMenu
        lOpcion = (New cOpcionesMenu).ObtenerOpcionesMenu(CInt(container.NodeKey))
        Return lOpcion.UrlOpcion
    End Function

    Protected Sub tlOpciones_NodeDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs) Handles tlOpciones.NodeDeleting
        e.Values("RoleId") = New Guid(Me.cbRoles.SelectedItem.Value.ToString())

        If (New cOpcionesPorRol).EliminarOpcionesPorRol(New Guid(Me.cbRoles.SelectedItem.Value.ToString()), e.Keys(0)) < 0 Then

        End If
        e.Cancel = True
    End Sub

    Protected Sub tlOpciones_NodeInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles tlOpciones.NodeInserting
        Dim cbOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcion")
        Dim chkHabilitado As ASPxCheckBox = tlOpciones.FindEditFormTemplateControl("chkHabilitado")
        e.NewValues("RoleId") = Me.cbRoles.SelectedItem.Value
        e.NewValues("IdOpcionMenu") = cbOpcion.Value
        e.NewValues("Habilitado") = chkHabilitado.Checked
    End Sub

    Protected Sub tlOpciones_NodeUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles tlOpciones.NodeUpdating
        Dim cbOpcion As ASPxComboBox = tlOpciones.FindEditFormTemplateControl("cbOpcion")
        Dim chkHabilitado As ASPxCheckBox = tlOpciones.FindEditFormTemplateControl("chkHabilitado")
        e.NewValues("RoleId") = New Guid(Me.cbRoles.SelectedItem.Value.ToString())
        e.NewValues("IdOpcionMenu") = CInt(cbOpcion.Value)
        e.NewValues("Habilitado") = chkHabilitado.Checked
    End Sub

    Protected Sub callSync_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs) Handles callSync.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        Dim opciones() As String = parametros(1).Split(",")
        Dim cOpcionesDesa As New cOpcionesPorRol
        'Dim cOpcionesProd As New cOpcionesPorRol("LocalSqlServerProd")

        'Dim RolSeleccionado As Guid = New Guid(parametros(0))

        'For Each lOpcion As String In opciones
        '    Dim lOpcionMenu As OpcionesPorRol = cOpcionesDesa.ObtenerOpcionesPorRol(RolSeleccionado, CInt(lOpcion))
        '    Dim lOpcionMenuProd As OpcionesPorRol = cOpcionesProd.ObtenerOpcionesPorRol(RolSeleccionado, lOpcionMenu.IdOpcionMenu)
        '    If lOpcionMenuProd Is Nothing Then
        '        If cOpcionesProd.AgregarOpcionesPorRol(lOpcionMenu) < 0 Then

        '        End If
        '    Else
        '        If cOpcionesProd.ActualizarOpcionesPorRol(lOpcionMenu) < 0 Then

        '        End If
        '    End If
        'Next
        e.Result = "Opcion(es) por Rol sincronizada(s) satisfactoriamente."
    End Sub

End Class
