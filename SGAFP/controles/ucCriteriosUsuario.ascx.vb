
Partial Class controles_ucCriteriosUsuario
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

    Public ReadOnly Property Usuario() As String
        Get
            Return Me.USUARIOTextBox.Text.Trim
        End Get
    End Property

    Public ReadOnly Property Correo() As String
        Get
            Return Me.CORREOTextBox.Text.Trim
        End Get
    End Property

    Private Sub CargarDatos()
        Select Case True
            Case Me.EstaEnRol(RolDeUsuario.Administrador), Me.EstaEnRol(RolDeUsuario.JefeHTP)
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
                Me.ddlPROVEEDOR_AF1.SelectedValue = -1

                Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1

            Case Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                Me.ddlPROVEEDOR_AF1.RecuperarPorTECNICO(Me.ObtenerUsuario)

                Me.ddlSITIO_CAPACITACION1.RecuperarPorTECNICO(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ObtenerUsuario())
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
        End Select
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        Select Case True
            Case Me.EstaEnRol(RolDeUsuario.Administrador), Me.EstaEnRol(RolDeUsuario.JefeHTP)
                Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1

            Case Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                Me.ddlSITIO_CAPACITACION1.RecuperarPorTECNICO(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ObtenerUsuario())
        End Select
    End Sub
End Class
