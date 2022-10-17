Imports DevExpress.Web
Imports System.Collections.Generic

Partial Class controles_ucCriteriosOrdenCompra
    Inherits ucBase
    Dim mListaRoles As New List(Of String)


#Region " Propiedades "
    Public Property VerPrograma() As Boolean
        Get
            Return Me.trPrograma.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPrograma.Visible = value
        End Set
    End Property

    Public Property VerProveedor() As Boolean
        Get
            Return Me.trProveedor.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trProveedor.Visible = value
        End Set
    End Property

    Public Property VerResolucion() As Boolean
        Get
            Return Me.trResolucion.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trResolucion.Visible = value
        End Set
    End Property
#End Region

    Private Sub CargarProgramas()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider

        'Obteniendo los Roles asignados al usuario actual
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        mListaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        Me.cbxProgramaFormacion.DataBind()
        Me.cbxProgramaFormacion.Items(0).Selected = True
    End Sub

    Public Sub CargarProveedores()
        Me.cbxProveedor.DataBind()
        Me.cbxProveedor.Items.Add("[Todos]", -1).Selected = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack And Not Page.IsCallback Then
            CargarProgramas()
            CargarProveedores()
        End If
    End Sub

    Protected Sub odsProgramaFormacion_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsProgramaFormacion.Selecting
        If e.InputParameters.Contains("listaRoles") Then e.InputParameters("listaRoles") = mListaRoles
    End Sub
End Class


