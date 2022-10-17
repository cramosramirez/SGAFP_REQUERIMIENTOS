Imports SQLMembershipProvider.EL

Partial Class controles_ucGestionRoles
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        ConfigurarOpcionMenu(114)
    End Sub

    Protected Sub grid_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs) Handles grid.RowInserting
        e.NewValues("LoweredRoleName") = e.NewValues("RoleName").ToString().ToLower
        e.NewValues("ApplicationId") = grid.GetRowValues(0, "ApplicationId")
    End Sub

    Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles grid.RowUpdating
        e.NewValues("LoweredRoleName") = e.NewValues("RoleName").ToString().ToLower
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal CommandName As String)
        If CommandName = "Sincronizar" Then
            Sincronizar()
        End If
    End Sub

    Private Sub Sincronizar()
        Dim listaRoles As listaAspnet_Roles
        listaRoles = Me.DevolverSeleccionados()
        If Not listaRoles Is Nothing AndAlso listaRoles.Count > 0 Then
            'Dim cRolesDesa As New cAspnet_Roles
            'Dim cRolesProd As New cAspnet_Roles("LocalSqlServerProd")

            'For Each lRol As Aspnet_Roles In listaRoles

            '    lRol = cRolesDesa.ObtenerAspnet_Roles(lRol.RoleId)

            '    Dim lRolProd As Aspnet_Roles = cRolesProd.ObtenerAspnet_Roles(lRol.RoleId)
            '    If lRolProd Is Nothing Then
            '        If cRolesProd.AgregarAspnet_Roles(lRol) < 0 Then

            '        End If
            '    Else
            '        If cRolesProd.ActualizarAspnet_Roles(lRol) < 0 Then

            '        End If
            '    End If

            'Next
            Me.AsignarMensaje("Rol(es) sincronizado(s) satisfactoriamente.")

        Else
            Me.AsignarMensaje("Debe de Seleccionar al Menos un Rol.")
        End If

    End Sub

    Public Function DevolverSeleccionados() As listaAspnet_Roles
        Dim mLista As New listaAspnet_Roles
        For Each llave As Object In Me.grid.GetSelectedFieldValues("RoleId")
            Dim lEntidad As New Aspnet_Roles
            lEntidad.RoleId = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

End Class
