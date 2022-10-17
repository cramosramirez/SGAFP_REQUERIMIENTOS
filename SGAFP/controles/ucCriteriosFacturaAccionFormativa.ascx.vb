Imports System.Collections.Generic

Partial Class controles_ucCriteriosFacturaAccionFormativa
    Inherits ucBase
    Dim mListaRoles As New List(Of String)

#Region " Propiedades "

    Public Property VerResolucion() As Boolean
        Get
            Return Me.trResolucion.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trResolucion.Visible = value
        End Set
    End Property

    Public Property VerProveedor() As Boolean
        Get
            Return Me.cbxProveedor.ClientVisible
        End Get
        Set(ByVal value As Boolean)
            Me.lblProveedor.ClientVisible = value
            Me.cbxProveedor.ClientVisible = value
            Me.lblNIT.ClientVisible = value
            Me.txtNIT.ClientVisible = value
        End Set
    End Property

    Public Property VerNumeroDocumento() As Boolean
        Get
            Return Me.trDocumento.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDocumento.Visible = value
        End Set
    End Property

    Public Property PROGRAMA_FORMACION As Object
        Get
            If Me.cbxProgramaFormacion.Value Is Nothing Then
                Return -1
            Else
                Return CDec(Me.cbxProgramaFormacion.Value)
            End If
        End Get
        Set(x As Object)
            Me.cbxProgramaFormacion.Value = x
        End Set
    End Property
#End Region
    
    Private Sub Inicializar()
        If Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionHTP) OrElse _
            Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) Then
            Me.odsProveedor.DataBind()
            Me.cbxProveedor.DataBind()
            Me.cbxProveedor.Items.FindByValue(CDec(Me.ObtenerIdProveedorAF)).Selected = True
            Me.cbxProgramaFormacion.DataBind()
        End If
        CargarProgramas()
    End Sub

    Private Sub CargarProgramas()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        mListaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        Me.odsProgramaFormacion.DataBind()
        Me.cbxProgramaFormacion.DataBind()

        Me.cbxProgramaFormacion.SelectedIndex = -1
        If Me.cbxProgramaFormacion.Value IsNot Nothing Then Session("ID_PROGRAMA_FORMACION") = CDec(Me.cbxProgramaFormacion.Value)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Inicializar()
        Else
            If Session("ID_PROGRAMA_FORMACION") IsNot Nothing Then
                Me.cbxProgramaFormacion.SelectedItem = Me.cbxProgramaFormacion.Items.FindByValue(CDec(Session("ID_PROGRAMA_FORMACION")))
            End If
        End If
    End Sub

    Protected Sub odsProgramaFormacion_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsProgramaFormacion.Selecting
        If e.InputParameters("listaRoles") Is Nothing Then e.InputParameters("listaRoles") = mListaRoles
    End Sub

    Protected Sub cbxProgramaFormacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProgramaFormacion.SelectedIndexChanged
        Session("ID_PROGRAMA_FORMACION") = CDec(Me.cbxProgramaFormacion.Value)
    End Sub
End Class
