
Partial Class controles_ucCriteriosParticipanteExoneradoDoc
    Inherits ucBase


    Public ReadOnly Property idProveedor() As Decimal
        Get
            If Me.ddlPROVEEDOR_AF1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlPROVEEDOR_AF1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property idSitioCapacitacion() As Decimal
        Get
            If Me.ddlSITIO_CAPACITACION1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlSITIO_CAPACITACION1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property estado() As Decimal
        Get
            If Me.ddlEstado.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlEstado.SelectedValue)
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        If Not Me.EstaEnRol(RolDeUsuario.Administrador) Then

            If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) OrElse Me.EstaEnRol(RolDeUsuario.JefeHTP) Then
                If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
                    Me.ddlPROVEEDOR_AF1.RecuperarPorTECNICO(Me.ObtenerUsuario())
                Else
                    Me.ddlPROVEEDOR_AF1.Recuperar()
                End If
                Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
                Me.ddlPROVEEDOR_AF1.SelectedValue = -1
                Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
                Return
            End If

            If Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF()
                If Not Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                    Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                    Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                    Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
                End If

                Me.trProveedor.Visible = False
                Me.trCentroFormacion.Visible = Not (Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso Not Me.EstaEnRol(RolDeUsuario.Proveedor))
            End If

            If Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF()
                Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                Me.ddlSITIO_CAPACITACION1.SelectedValue = Me.ObtenerIdSitioCapacitacion()
                Me.trProveedor.Visible = False
                Me.trCentroFormacion.Visible = False
            End If

            Return
        Else
            Me.ddlPROVEEDOR_AF1.Recuperar()
            Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
            Me.ddlPROVEEDOR_AF1.SelectedValue = -1

            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
            Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
        End If
       

        Me.trProveedor.Visible = True
        Me.trCentroFormacion.Visible = True
    End Sub

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
            Me.ddlSITIO_CAPACITACION1.RecuperarPorTECNICO(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ObtenerUsuario())
        Else
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        End If
        Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
        Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
    End Sub
End Class
