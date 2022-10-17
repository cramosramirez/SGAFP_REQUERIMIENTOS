Imports DevExpress.XtraEditors.Controls

Public Class wfAdministrarSeguridad

    Private esNuevo As Boolean = False
    Private _mp As SQLMembershipProvider.BL.cmembershipProvider
    Private _listaUSUARIO As listaUSUARIO

    Private Sub ListaUSUARIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaUSUARIOBindingSource.AddingNew
        Dim lUsuario As New USUARIO
        lUsuario.USUARIO = ""
        lUsuario.ID_PARTICIPANTE = -1
        lUsuario.ID_PROVEEDOR_AF = -1
        lUsuario.ID_SITIO_CAPACITACION = -1
        e.NewObject = lUsuario
        esNuevo = True

        Me.lblClave.Visible = True
        Me.txtClave.Visible = True
        Me.txtClave.Text = ""
        Me.txtEmail.Text = ""
        Me.txtPreguntaSeguridad.Text = ""
        Me.lblRespuestaSeguridad.Visible = True
        Me.txtRespuestaSeguridad.Visible = True
        Me.txtRespuestaSeguridad.Text = ""
        Me.chkBloqueado.Checked = False
        Me.chkActivo.Checked = True

        'Me.CargarRolesPorUsuario("")
    End Sub

    Private Sub ListaUSUARIOBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaUSUARIOBindingSource.CurrentChanged
        Dim lUsuario As USUARIO = sender.current
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.Items.Clear()
        Dim lParticipante As New PARTICIPANTE
        lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(lUsuario.ID_PARTICIPANTE)
        If lParticipante Is Nothing OrElse lUsuario.ID_PARTICIPANTE = -1 Then
            lParticipante = New PARTICIPANTE
            lParticipante.ID_PARTICIPANTE = lUsuario.ID_PARTICIPANTE
            lParticipante.NOMBRES = "[Vacio]"
        End If
        Dim listaParticipante As New listaPARTICIPANTE
        listaParticipante.Add(lParticipante)
        Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante
        Me.gleParticipante.EditValue = lUsuario.ID_PARTICIPANTE

        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.CargarPorLista(listaParticipante, "NombresApellidos", "ID_PARTICIPANTE")
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = lUsuario.ID_PARTICIPANTE

        'Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante

        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar(True)
        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = lUsuario.ID_PROVEEDOR_AF

        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.RecuperarPorPROVEEDOR_AF(Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue, False, True)
        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.SelectedValue = lUsuario.ID_SITIO_CAPACITACION

        'Dim listaSitio As listaSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerLista()
        'Dim lSitio As New SITIO_CAPACITACION
        'lSitio.ID_SITIO_CAPACITACION = -1
        'lSitio.NOMBRE_SITIO = "[Vacio]"
        'listaSitio.Add(lSitio)
        'Me.ListaSITIOCAPACITACIONBindingSource.DataSource = listaSitio
        'Me.gleSitioCapacitacion.EditValue = lUsuario.ID_SITIO_CAPACITACION

        'Cargar de Datos de Usuario Seguridad
        Dim luser As Web.Security.MembershipUser
        luser = _mp.GetUser(lUsuario.USUARIO, False)
        If luser Is Nothing Then
            Me.txtClave.Visible = True
            Me.txtClave.Text = ""
            Me.txtEmail.Text = ""
            Me.txtPreguntaSeguridad.Text = ""
            Me.txtRespuestaSeguridad.Visible = True
            Me.txtRespuestaSeguridad.Text = ""
            Me.chkBloqueado.Checked = False
            Me.chkActivo.Checked = True
        Else
            Me.txtClave.Visible = False
            Me.txtClave.Text = ""
            Me.txtEmail.Text = luser.Email
            Me.txtPreguntaSeguridad.Text = luser.PasswordQuestion
            Me.txtRespuestaSeguridad.Visible = False
            Me.txtRespuestaSeguridad.Text = ""
            Me.chkBloqueado.Checked = luser.IsLockedOut
            Me.chkActivo.Checked = luser.IsApproved
        End If

        CargarRoles()
        Me.CargarRolesPorUsuario(lUsuario.USUARIO)

        esNuevo = False
    End Sub

    Private Sub CargarRoles()
        Me.chklbRoles.Items.Clear()
        Dim roles As New ArrayList
        For Each rol As String In Web.Security.Roles.GetAllRoles()
            Me.chklbRoles.Items.Add(New CheckedListBoxItem(rol, rol))
        Next
    End Sub

    Private Sub CargarRolesPorUsuario(ByVal usuario As String)
        Dim rolesDeUsuario() As String
        rolesDeUsuario = Web.Security.Roles.GetRolesForUser(usuario)
        For Each item As CheckedListBoxItem In Me.chklbRoles.Items
            item.CheckState = CheckState.Unchecked
            For Each rol As String In rolesDeUsuario
                If item.Description = rol Then
                    item.CheckState = CheckState.Checked
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub AsignarRolesAUsuario(ByVal usuario As String)
        For Each item As CheckedListBoxItem In Me.chklbRoles.Items
            If item.CheckState = CheckState.Unchecked Then
                If Web.Security.Roles.IsUserInRole(usuario, item.Description) Then
                    Web.Security.Roles.RemoveUserFromRole(usuario, item.Description)
                End If
            Else
                If Not Web.Security.Roles.IsUserInRole(usuario, item.Description) Then
                    Web.Security.Roles.AddUserToRole(usuario, item.Description)
                End If
            End If
        Next
    End Sub

    Private Sub tsbRecuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRecuperar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.CargarDatos()
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.BindingNavigatorDeleteItem.Enabled = True
        Me.BindingNavigatorSaveItem.Enabled = True
        Me.tsbBuscarUsuario.Enabled = True
        Me.tstxtUsuario.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarDatos()
        _mp = CType(Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)

        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.Recuperar()
        Dim listaProveedor As listaPROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerLista
        Dim lProveedor As New PROVEEDOR_AF
        lProveedor.ID_PROVEEDOR_AF = -1
        lProveedor.NOMBRE_PROVEEDOR = "[Vacio]"
        listaProveedor.Add(lProveedor)
        Me.ListaPROVEEDORAFBindingSource.DataSource = listaProveedor

        Dim listaSitio As listaSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerLista()
        Dim lSitio As New SITIO_CAPACITACION
        lSitio.ID_SITIO_CAPACITACION = -1
        lSitio.NOMBRE_SITIO = "[Vacio]"
        listaSitio.Add(lSitio)
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = listaSitio

        _listaUSUARIO = (New cUSUARIO).ObtenerLista()
        Me.ListaUSUARIOBindingSource.DataSource = _listaUSUARIO
        'Me.BindingNavigatorAddNewItem.Enabled = True
        'Me.BindingNavigatorDeleteItem.Enabled = True
        'Me.BindingNavigatorSaveItem.Enabled = True
        'Dim _mp As SQLMembershipProvider.BL.cmembershipProvider
        '_mp = CType(Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        '_mp.GetUser("", False)
        'Dim roles As List(Of SQLMembershipProvider.EL.Aspnet_Roles

    End Sub

    Private Sub tsbBuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscarUsuario.Click
        If Me.tstxtUsuario.Text = "" Then
            Me.AsignarMensaje("Ingresar usuario a buscar", True)
            Return
        End If
        Dim liRet As Integer = CType(Me.ListaUSUARIOBindingSource.DataSource, listaUSUARIO).FindByColum("USUARIO", Me.tstxtUsuario.Text)
        If liRet >= 0 Then
            'Me.ListaUSUARIOBindingNavigator.PositionItem.Text = liRet.ToString
            Me.ListaUSUARIOBindingNavigator.BindingSource.Position = liRet
        Else
            Me.AsignarMensaje("No existe un usuario con ese nombre")
        End If
    End Sub

    Private Sub ListaUSUARIOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Me.ListaUSUARIOBindingSource.EndEdit()
        Dim lUsuario As USUARIO = Me.ListaUSUARIOBindingSource.Current
        Dim res As Web.Security.MembershipCreateStatus
        If esNuevo Then
            If (New cUSUARIO).AgregarUSUARIO(lUsuario) = 1 Then
                Dim luser As Web.Security.MembershipUser
                luser = _mp.GetUser(lUsuario.USUARIO, False)
                If luser Is Nothing Then
                    luser = Web.Security.Membership.CreateUser(lUsuario.USUARIO, Me.txtClave.Text, Me.txtEmail.Text, Me.txtPreguntaSeguridad.Text, Me.txtRespuestaSeguridad.Text, Me.chkActivo.Checked, res)
                    AsignarRolesAUsuario(lUsuario.USUARIO)
                Else
                    AsignarRolesAUsuario(lUsuario.USUARIO)
                End If
            End If
        Else
            If (New cUSUARIO).ActualizarUSUARIO(lUsuario) = 1 Then
                Dim luser As Web.Security.MembershipUser
                luser = _mp.GetUser(lUsuario.USUARIO, False)
                If luser Is Nothing Then
                    luser = Web.Security.Membership.CreateUser(lUsuario.USUARIO, Me.txtClave.Text, Me.txtEmail.Text, Me.txtPreguntaSeguridad.Text, Me.txtRespuestaSeguridad.Text, Me.chkActivo.Checked, res)
                    If res = Web.Security.MembershipCreateStatus.Success Then
                        AsignarRolesAUsuario(lUsuario.USUARIO)
                    End If
                Else
                    luser.IsApproved = Me.chkActivo.Checked
                    If Not Me.chkBloqueado.Checked Then
                        luser.UnlockUser()
                    End If
                    luser.IsApproved = Me.chkActivo.Checked
                    luser.Email = Me.txtEmail.Text
                    Web.Security.Membership.UpdateUser(luser)
                    AsignarRolesAUsuario(lUsuario.USUARIO)
                End If
            End If
        End If

    End Sub

End Class