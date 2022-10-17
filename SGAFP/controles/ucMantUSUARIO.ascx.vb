Imports DevExpress.Web
Imports SQLMembershipProvider.EL
Imports System.Collections.Generic

Partial Class controles_ucMantUsuario
    Inherits ucBase

    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.CrearOpcion("BuscarUsuarios", "Buscar Usuarios", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("Sincronizar", "Sincronizar", False, "~/imagenes/exportar.gif") ', "onclick", "grid.GetSelectedFieldValues('USUARIO',Sincronizar);")
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InicializarLista()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarUsuarios" Then
            Me.ucListaUSUARIO1.CargarDatosPorCRITERIOS(Me.ucCriteriosUSUARIO1.idProveedor, Me.ucCriteriosUSUARIO1.idSitioCapacitacion, Me.ucCriteriosUSUARIO1.Usuario, Me.ucCriteriosUSUARIO1.Correo)
        End If
        If CommandName = "Sincronizar" Then
            Me.Sincronizar()
        End If
    End Sub

    Private Sub Sincronizar()
        Dim listaU As listaUSUARIO = Me.ucListaUSUARIO1.DevolverSeleccionados()
        'If Not listaU Is Nothing AndAlso listaU.Count > 0 Then
        '    Dim cUsuariosDesa As New cAspnet_Users
        '    Dim cUsuariosProd As New cAspnet_Users("LocalSqlServerProd")

        '    Dim cUsuariosOraDesa As New cUSUARIO
        '    Dim cUsuariosOraProd As New cUSUARIO("ConnectionStringProd")

        '    Dim cMembershipDesa As New cAspnet_Membership
        '    Dim cMembershipProd As New cAspnet_Membership("LocalSqlServerProd")

        '    Dim cUserInRolesDesa As New cAspnet_UsersInRoles
        '    Dim cUserInRolesProd As New cAspnet_UsersInRoles("LocalSqlServerProd")

        '    Dim cEmailsDesa As New cAspnet_EmailsAdicionales
        '    Dim cEmailsProd As New cAspnet_EmailsAdicionales("LocalSqlServerProd")

        '    For Each usuarioOracle As USUARIO In listaU

        '        usuarioOracle = cUsuariosOraDesa.ObtenerUSUARIO(usuarioOracle.USUARIO)
        '        Dim usuarioOracleProd As USUARIO = cUsuariosOraProd.ObtenerUSUARIO(usuarioOracle.USUARIO)

        '        If usuarioOracleProd Is Nothing Then
        '            If cUsuariosOraProd.AgregarUSUARIO(usuarioOracle) < 0 Then

        '            End If
        '        Else
        '            If cUsuariosOraProd.ActualizarUSUARIO(usuarioOracle) < 0 Then

        '            End If
        '        End If

        '        Dim usuarioCreado As Boolean = False

        '        Dim criterios As New List(Of Criteria)
        '        criterios.Add(New Criteria("UserName", "=", usuarioOracle.USUARIO, ""))
        '        Dim lUsuarios As listaAspnet_Users = cUsuariosDesa.ObtenerListaPorBusqueda(New Aspnet_Users, criterios.ToArray())
        '        Dim lUsuario As Aspnet_Users = lUsuarios(0)

        '        Dim lUsuarioProd As Aspnet_Users = cUsuariosProd.ObtenerAspnet_Users(lUsuario.UserId)
        '        If lUsuarioProd Is Nothing Then
        '            If cUsuariosProd.AgregarAspnet_Users(lUsuario) < 0 Then

        '            End If

        '            usuarioCreado = True

        '        Else
        '            If cUsuariosProd.ActualizarAspnet_Users(lUsuario) < 0 Then

        '            End If
        '        End If

        '        Dim lMembership As Aspnet_Membership = cMembershipDesa.ObtenerAspnet_Membership(lUsuario.UserId)
        '        Dim lMembershipProd As Aspnet_Membership = cMembershipProd.ObtenerAspnet_Membership(lUsuario.UserId)

        '        If lMembershipProd Is Nothing Then
        '            If cMembershipProd.AgregarAspnet_Membership(lMembership) < 0 Then

        '            End If
        '        End If

        '        Dim listaUserInRoles As listaAspnet_UsersInRoles = cUserInRolesDesa.ObtenerListaPorAspnet_Users(lUsuario.UserId)
        '        Dim listaUserInRolesProd As listaAspnet_UsersInRoles = cUserInRolesProd.ObtenerListaPorAspnet_Users(lUsuario.UserId)

        '        If Not listaUserInRolesProd Is Nothing Then
        '            For Each lUserInRolesProd As Aspnet_UsersInRoles In listaUserInRolesProd
        '                If cUserInRolesProd.EliminarAspnet_UsersInRoles(lUserInRolesProd.UserId, lUserInRolesProd.RoleId) < 0 Then

        '                End If
        '            Next
        '        End If

        '        For Each lUserInRoles As Aspnet_UsersInRoles In listaUserInRoles
        '            If cUserInRolesProd.AgregarAspnet_UsersInRoles(lUserInRoles) < 0 Then

        '            End If
        '        Next

        '        Dim lEmails As Aspnet_EmailsAdicionales = cEmailsDesa.ObtenerAspnet_EmailsAdicionales(lUsuario.UserName)
        '        Dim lEmailsProd As Aspnet_EmailsAdicionales = cEmailsProd.ObtenerAspnet_EmailsAdicionales(lUsuario.UserName)

        '        If Not lEmails Is Nothing Then
        '            If lEmailsProd Is Nothing Then
        '                If cEmailsProd.AgregarAspnet_EmailsAdicionales(lEmails) < 0 Then

        '                End If
        '            Else
        '                If cEmailsProd.ActualizarAspnet_EmailsAdicionales(lEmails) < 0 Then

        '                End If
        '            End If
        '        End If

        '    Next

        '    Me.AsignarMensaje("Usuario(s) sincronizado(s) satisfactoriamente.")
        'Else
        '    Me.AsignarMensaje("Debe de Seleccionar al Menos un Usuario.")
        'End If
    End Sub

    Protected Sub callSync_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs) Handles callSync.Callback
        Dim usuarios() As String = e.Parameter.Split(",")
        Dim cUsuariosDesa As New cAspnet_Users
        'Dim cUsuariosProd As New cAspnet_Users("LocalSqlServerProd")
        'For Each usuario As String In usuarios
        '    Dim criterios As New List(Of Criteria)
        '    criterios.Add(New Criteria("UserName", "=", usuario, ""))
        '    Dim lUsuarios As listaAspnet_Users = cUsuariosDesa.ObtenerListaPorBusqueda(New Aspnet_Users, criterios.ToArray())
        '    Dim lUsuario As SQLMembershipProvider.EL.Aspnet_Users = lUsuarios(0)

        '    Dim lUsuarioProd As Aspnet_Users = cUsuariosProd.ObtenerAspnet_Users(lUsuario.UserId)
        '    If lUsuarioProd Is Nothing Then
        '        If cUsuariosProd.AgregarAspnet_Users(lUsuario) < 0 Then

        '        End If
        '    Else
        '        If cUsuariosProd.ActualizarAspnet_Users(lUsuario) < 0 Then

        '        End If
        '    End If
        'Next
        e.Result = "Usuario(s) sincronizado(s) satisfactoriamente."
    End Sub

End Class
