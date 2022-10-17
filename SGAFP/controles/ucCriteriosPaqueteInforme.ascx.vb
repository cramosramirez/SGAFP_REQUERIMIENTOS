
Partial Class controles_ucCriteriosPaqueteInforme
    Inherits ucBase

    <System.ComponentModel.DefaultValue(False)> _
    Public Property VerTecnico() As Boolean
        Get
            Return Me.trTecnico.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTecnico.Visible = value
        End Set
    End Property
  
    Public ReadOnly Property IdTecnico() As String
        Get
            Return Me.ddlUSUARIO1.SelectedValue
        End Get
    End Property

    Public ReadOnly Property IdPaquete() As Decimal
        Get
            If Me.txtID_PAQUETE.Text = "" Then
                Return -1
            Else
                Return Convert.ToDecimal(Me.txtID_PAQUETE.Text)
            End If
        End Get
    End Property

    Public ReadOnly Property FechaCreacion() As Object
        Get
            If IsDate(Me.dteFECHA.Value) Then
                Return Me.dteFECHA.Value
            End If
            Return Nothing
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    ''' <summary>
    ''' Configura el Control dependiendo del Rol del Usuario Conectado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Me.ddlUSUARIO1.RecuperarPorPERFIL(Enumeradores.RolDeUsuario.TecnicoCentroHTP)
        If Not Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
            Me.ddlUSUARIO1.AgregarTodosCadena()
            Me.ddlUSUARIO1.SelectedValue = ""
        Else
            Me.ddlUSUARIO1.SelectedValue = Me.ObtenerUsuario
            Me.ddlUSUARIO1.Enabled = False
        End If
    End Sub

End Class
