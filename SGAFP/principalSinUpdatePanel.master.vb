
Partial Class principalSinUpdatePanel
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.MaintainScrollPositionOnPostBack = True

        'If Not Request.IsAuthenticated Then Return

        If Request.IsAuthenticated Then
            If Page.User.IsInRole(RolDeUsuario.Participante) Then
                Dim lUsuario As New USUARIO
                lUsuario = (New cUSUARIO).ObtenerUSUARIO(Page.User.Identity.Name)
                lUsuario.fkID_PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(lUsuario.ID_PARTICIPANTE)
                Me.Label_Usuario.Text = "Usuario: " + lUsuario.fkID_PARTICIPANTE.NOMBRES + " " + lUsuario.fkID_PARTICIPANTE.APELLIDOS + "[" + Page.User.Identity.Name + "]"
                Return
            End If

            If Page.User.IsInRole(RolDeUsuario.Proveedor) Then
                Dim lUsuario As New USUARIO
                lUsuario = (New cUSUARIO).ObtenerUSUARIO(Page.User.Identity.Name)
                lUsuario.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lUsuario.ID_PROVEEDOR_AF)
                Me.Label_Usuario.Text = "Usuario: " + lUsuario.fkID_PROVEEDOR_AF.NOMBRE_PROVEEDOR + "[" + Page.User.Identity.Name + "]"
                Return
            End If

            If Page.User.IsInRole(RolDeUsuario.ProveedorPATI) OrElse Page.User.IsInRole(RolDeUsuario.ProveedorFacturacionPATI) OrElse _
                Page.User.IsInRole(RolDeUsuario.ProveedorPROYESPECIAL) OrElse Page.User.IsInRole(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) Then
                Dim lUsuario As New USUARIO
                lUsuario = (New cUSUARIO).ObtenerUSUARIO(Page.User.Identity.Name)
                lUsuario.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lUsuario.ID_PROVEEDOR_AF)
                Me.Label_Usuario.Text = "Usuario: " + lUsuario.fkID_PROVEEDOR_AF.NOMBRE_PROVEEDOR + "[" + Page.User.Identity.Name + "]"
                Return
            End If

            If Page.User.IsInRole(RolDeUsuario.CentroCapacitador) Then
                Dim lUsuario As New USUARIO
                lUsuario = (New cUSUARIO).ObtenerUSUARIO(Page.User.Identity.Name)
                lUsuario.fkID_SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lUsuario.ID_SITIO_CAPACITACION)
                Me.Label_Usuario.Text = "Usuario: " + lUsuario.fkID_SITIO_CAPACITACION.NOMBRE_SITIO + "[" + Page.User.Identity.Name + "]"
                Return
            End If

            Me.Label_Usuario.Text = "Usuario: [" + Page.User.Identity.Name + "]"

            'Me.CargarMenu()

            Return
        End If

    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        'Buscar los controles del tipo ancestro ucBase y ejecutar la opción
        'CType(Me.contenido.Controls(1), ucBase).EjecutarOpcion(CommandName)
        For Each lControl As Control In Me.contenido.Controls
            If lControl.GetType().BaseType.BaseType.Name = "ucBase" Then
                CType(lControl, ucBase).EjecutarOpcion(CommandName)
            End If
        Next
    End Sub

    Private cMsProvider As New cmembershipProvider
    Private idSistema As Integer = 1

    Public Sub CargarMenu()

        cMsProvider = CType(Membership.Provider, cmembershipProvider)
        Dim lOpciones As SQLMembershipProvider.EL.listaOpcionesMenu
        lOpciones = cMsProvider.ObtenerOpcionesHabilitadasPorUsuario(idSistema, Page.User.Identity.Name, 0)

        ASPxNavBar2.DataSource = GenerateSiteMapHierarchy(lOpciones)
        ASPxNavBar2.DataBind()
    End Sub

    Protected Function GenerateSiteMapHierarchy(ByVal aOpciones As SQLMembershipProvider.EL.listaOpcionesMenu) As SiteMapDataSource
        Dim ret As SiteMapDataSource = New SiteMapDataSource()
        ret.ShowStartingNode = False
        Dim provider As DevExpress.Web.ASPxSiteMapControl.UnboundSiteMapProvider = New DevExpress.Web.ASPxSiteMapControl.UnboundSiteMapProvider("~/Default.aspx", "SGAFP")
        AddNodeToProviderRecursive(provider.RootNode, 0, aOpciones, provider)
        ret.Provider = provider
        Return ret
    End Function

    Private Sub AddNodeToProviderRecursive(ByVal parentNode As SiteMapNode, ByVal parentID As Integer, ByVal aOpciones As SQLMembershipProvider.EL.listaOpcionesMenu, ByVal provider As DevExpress.Web.ASPxSiteMapControl.UnboundSiteMapProvider)

        'Dim childRows As DataRow() = Table.Select("ParentID = " & parentID)
        For Each lOpcion As SQLMembershipProvider.EL.OpcionesMenu In aOpciones
            Dim childNode As SiteMapNode = CreateSiteMapNode(lOpcion, provider)
            provider.AddSiteMapNode(childNode, parentNode)
            Dim lSubOpciones As SQLMembershipProvider.EL.listaOpcionesMenu
            lSubOpciones = cMsProvider.ObtenerOpcionesHabilitadasPorUsuario(idSistema, Page.User.Identity.Name, lOpcion.IdOpcionMenu)
            If lSubOpciones.Count > 0 Then
                AddNodeToProviderRecursive(childNode, lOpcion.IdOpcionMenu, lSubOpciones, provider)
            End If
        Next
    End Sub

    Private Function CreateSiteMapNode(ByVal aOpcion As SQLMembershipProvider.EL.OpcionesMenu, ByVal provider As DevExpress.Web.ASPxSiteMapControl.UnboundSiteMapProvider) As SiteMapNode
        Return provider.CreateNode(aOpcion.UrlOpcion, aOpcion.CodigoMenu, aOpcion.DescripcionMenu, Nothing, New NameValueCollection())
    End Function

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim l As New wsSGAFP

    '    Dim correlativoGrupo As Decimal = 1560
    '    Dim idAccionFormativa As Decimal = 5869
    '    Dim liRet As Integer = l.ProcesarInscripciones(correlativoGrupo, idAccionFormativa)

    'End Sub

End Class

