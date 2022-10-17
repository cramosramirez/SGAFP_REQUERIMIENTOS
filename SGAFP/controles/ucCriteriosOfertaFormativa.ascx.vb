
Partial Class controles_ucCriteriosOfertaFormativa
    Inherits ucBase

    Public ReadOnly Property idEjercicio() As String
        Get
            Return Me.ddlEJERCICIO1.SelectedValue
        End Get
    End Property

    Public ReadOnly Property idProveedor() As Decimal
        Get
            If Me.ddlPROVEEDOR_AF1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlPROVEEDOR_AF1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property idAreaFormacion() As Decimal
        Get
            If Me.ddlAREA_FORMACION1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlAREA_FORMACION1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property nombreAccionFormativa() As String
        Get
            Return NOMBRE_CURSOTextBox.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.ddlAREA_FORMACION1.Recuperar()
        Me.ddlAREA_FORMACION1.AgregarTodosNumerico()
        Me.ddlAREA_FORMACION1.SelectedValue = -1
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
        Me.ddlPROVEEDOR_AF1.SelectedValue = -1
        If Me.EstaEnRol(RolDeUsuario.Administrador) Or Me.EstaEnRol(RolDeUsuario.Proveedor) Or _
            Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Or Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Or _
            Me.EstaEnRol(RolDeUsuario.JefeHTP) Or Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
            Me.ddlEJERCICIO1.Recuperar()
        Else
            Me.ddlEJERCICIO1.Recuperar()
            If Not Me.ddlEJERCICIO1.Items.FindByValue(Now.Year) Is Nothing Then
                Me.ddlEJERCICIO1.SelectedValue = Now.Year
            End If
            Me.ddlEJERCICIO1.Enabled = False
        End If
    End Sub

End Class
