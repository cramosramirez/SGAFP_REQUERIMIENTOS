Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports System.Configuration.ConfigurationSettings
Imports System.Web.Security
Imports SQLMembershipProvider.BL
Imports System.Resources

Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    Private mFrmLogin As frmLogin
    Private _mp As cmembershipProvider
    Private _mpUsuario As cmembershipUser
    Private _Usuario As String
    Private _Base As String
    'Private _ListaGrupos As listaGruposUsuario
    Dim dirManuales As String = AppSettings("dirManuales")
    'Dim frmManejoPeriodosSeguimiento As frmAdministracionPeriodosSeguimiento

    Private _ListaOpciones As New List(Of OpcionMenu)

    Private _ListaOpcionesAbiertas As New ArrayList
    Private _ListaOpcionesMenuHabilitadas As New SQLMembershipProvider.EL.listaOpcionesMenu

    Public ReadOnly Property Usuario() As String
        Get
            Return Me._Usuario
        End Get
    End Property

    Private _CodigoEmpleado As String

    Public ReadOnly Property CodigoEmpleado() As String
        Get
            Return Me._CodigoEmpleado
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        ''CreateColorPopup(popupControlContainer1)
        InitSkinGallery()
        ''InitFontGallery()
        ''InitColorGallery()
    End Sub

    Private fCurrentFontItem, fCurrentColorItem As GalleryItem

    Private Sub Pad_ShowPopupMenu(ByVal sender As Object, ByVal e As EventArgs)
        pmMain.ShowPopup(Control.MousePosition)
    End Sub

    Private Function ObtenerFormularioAbierto(ByVal tipoFormulario As Type, Optional ByVal aTituloForma As String = "") As Form
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(i).GetType Is tipoFormulario Then
                If aTituloForma <> String.Empty Then
                    If Me.MdiChildren(i).Text = aTituloForma Then
                        Return Me.MdiChildren(i)
                    End If
                Else
                    Return Me.MdiChildren(i)
                End If
            End If
        Next
        Return Nothing
    End Function

#Region "SkinGallery"
    Private Sub InitSkinGallery()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.OfficeSkins.Register()
        Dim imageButton As SimpleButton = New SimpleButton()
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            If cnt.SkinName <> "Pumpkin" Then
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
                Dim gItem As GalleryItem = New GalleryItem()
                Dim groupIndex As Integer = 0
                If cnt.SkinName.IndexOf("Office") > -1 Then
                    groupIndex = 1
                End If
                rgbiSkins.Gallery.Groups(groupIndex).Items.Add(gItem)
                gItem.Caption = cnt.SkinName

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)
                gItem.Caption = cnt.SkinName
                gItem.Hint = cnt.SkinName
                rgbiSkins.Gallery.Groups(1).Visible = False
            End If
        Next cnt
    End Sub
    Private Function GetSkinImage(ByVal button As SimpleButton, ByVal width As Integer, ByVal height As Integer, ByVal indent As Integer) As Bitmap
        Dim image As Bitmap = New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(image)
            Dim info As StyleObjectInfoArgs = New StyleObjectInfoArgs(New GraphicsCache(g))
            info.Bounds = New Rectangle(0, 0, width, height)
            button.LookAndFeel.Painter.GroupPanel.DrawObject(info)
            button.LookAndFeel.Painter.Border.DrawObject(info)
            info.Bounds = New Rectangle(indent, indent, width - indent * 2, height - indent * 2)
            button.LookAndFeel.Painter.Button.DrawObject(info)
        End Using
        Return image
    End Function

    Private Sub rgbiSkins_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiSkins.Gallery.ItemClick
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        My.Settings.SkinSeleccionado = e.Item.Caption
        My.Settings.Save()
    End Sub

    Private Sub rgbiSkins_Gallery_InitDropDownGallery(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs) Handles rgbiSkins.Gallery.InitDropDownGallery
        e.PopupGallery.CreateFrom(rgbiSkins.Gallery)
        e.PopupGallery.AllowFilter = False
        e.PopupGallery.ShowItemText = True
        e.PopupGallery.ShowGroupCaption = True
        e.PopupGallery.AllowHoverImages = False
        For Each galleryGroup As GalleryItemGroup In e.PopupGallery.Groups
            For Each item As GalleryItem In galleryGroup.Items
                item.Image = item.HoverImage
            Next item
        Next galleryGroup
        e.PopupGallery.ColumnCount = 2
        e.PopupGallery.ImageSize = New Size(70, 36)
    End Sub
#End Region

    Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim process As Process = New Process()
        process.StartInfo.FileName = "http://www.devexpress.com"
        process.StartInfo.Verb = "Open"
        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        process.Start()
    End Sub

    Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
        Dim dlg1 As New frmAcercaDe
        dlg1.ShowDialog()
    End Sub

    Private Function TextByCaption(ByVal caption As String) As String
        Return caption.Replace("&", "")
    End Function

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ribbonControl1.ForceInitialize()
        ribbonControl1.Minimized = True

        If My.Settings.SkinSeleccionado <> "" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.SkinSeleccionado)
        End If
        For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
            Dim item As BarCheckItem = ribbonControl1.Items.CreateCheckItem(skin.SkinName, False)
            item.Tag = skin.SkinName
            AddHandler item.ItemClick, AddressOf OnPaintStyleClick
        Next skin
        Me.Text += String.Format(" - Versión {0}", My.Application.Info.Version.ToString)

        If Not iniciarLogin() Then
            Application.Exit()
        End If
    End Sub

    Private Function iniciarLogin() As Boolean
        mFrmLogin = New frmLogin
        AddHandler Me.mFrmLogin.Closing, AddressOf Me.mFrmLogin_Close
        Dim dResult As System.Windows.Forms.DialogResult
        dResult = mFrmLogin.ShowDialog(Me)
        If dResult <> DialogResult.OK Then
            Me.Close()
            Return False
        End If

        Try
            _mp = CType(Membership.Provider, cmembershipProvider)
            _mpUsuario = _mp.ObtenerUsuario(Me.Usuario)
            System.Threading.Thread.CurrentPrincipal = New System.Security.Principal.GenericPrincipal(New System.Security.Principal.GenericIdentity(Me.Usuario), _mp.ObtenerRoles(Me.Usuario).ToArray)
            If _mpUsuario IsNot Nothing Then
                EL.configuracion.usuarioActualiza = _mpUsuario.UserName
                SQLMembershipProvider.EL.configuracion.Usuario = _mp.GetUser(Me.Usuario, False)
            End If

            Me.Text = EL.configuracion.tituloAplicacion & " - Usuario: [" & Me._Usuario & "] - Nombre: " + Me._mpUsuario.Nombre + " " + String.Format(" Versión {0}", My.Application.Info.Version.ToString)
            Me.GenerarMenu()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insaforp")
            Return False
        End Try
        Return True
    End Function

#Region "Opciones de Menu"

    Private resourceMan As Global.System.Resources.ResourceManager

    Private resourceCulture As Global.System.Globalization.CultureInfo

    Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SGAFP.Resources", GetType(My.Resources.Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property

    Private Sub GenerarMenu()

        Dim mp As cmembershipProvider

        mp = System.Web.Security.Membership.Provider

        _ListaOpcionesMenuHabilitadas = mp.ObtenerOpcionesHabilitadasPorUsuario(My.Settings.idSistema, Me.Usuario, 0)

        'Me.CrearOpcionesMantenimientos()

        'Dim idNumber As Integer = 186
        'For Each lOpcionMantenimiento As OpcionMenu In Me._ListaOpciones '.FindAll(AddressOf lPredicado.ModuloOpcion)

        '    If lOpcionMantenimiento.Habilitado Then 'True Then 
        '        Dim BarButtonItemOpcion As New DevExpress.XtraBars.BarButtonItem
        '        'BarButtonItemOpcion.Hint = "Otro de Prueba mas"
        '        BarButtonItemOpcion.Tag = lOpcionMantenimiento
        '        BarButtonItemOpcion.Id = idNumber
        '        'BarButtonItemOpcion.LargeImageIndex = 17
        '        BarButtonItemOpcion.Name = "BarButtonItemOpcion" + idNumber.ToString()
        '        If lOpcionMantenimiento.EstiloDeBoton = RibbonItemStyles.Large Then
        '            BarButtonItemOpcion.LargeGlyph = lOpcionMantenimiento.Icono
        '            BarButtonItemOpcion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '            BarButtonItemOpcion.Caption = lOpcionMantenimiento.Texto
        '        Else
        '            BarButtonItemOpcion.Glyph = lOpcionMantenimiento.Icono
        '            BarButtonItemOpcion.RibbonStyle = lOpcionMantenimiento.EstiloDeBoton
        '            If lOpcionMantenimiento.EstiloDeBoton <> RibbonItemStyles.SmallWithoutText Then
        '                BarButtonItemOpcion.Caption = lOpcionMantenimiento.Texto
        '            End If
        '        End If
        '        AddHandler BarButtonItemOpcion.ItemClick, AddressOf BarButtonItemOpcion_ItemClick

        '        Me.ribbonControl1.Items.Add(BarButtonItemOpcion)
        '        Select Case lOpcionMantenimiento.ModuloSistema
        '            Case enumModuloSistema.Mantenimientos
        '                Select Case lOpcionMantenimiento.GrupoModuloSistema
        '                    'Case enumGrupoModuloSistema.CatalogosMantenimientos
        '                    'Me.rpgCatalogos.ItemLinks.Add(BarButtonItemOpcion)
        '                    'Case enumGrupoModuloSistema.SeguimientosMantenimientos
        '                    '    Me.rpgSeguimientos.ItemLinks.Add(BarButtonItemOpcion)
        '                    'Case enumGrupoModuloSistema.ConformacionMantenimientos
        '                    '    Me.rpgConformacionFamilias.ItemLinks.Add(BarButtonItemOpcion)
        '                    'Case enumGrupoModuloSistema.DuplicadosMantenimientos
        '                    '    Me.rpgDuplicados.ItemLinks.Add(BarButtonItemOpcion)
        '                    Case enumGrupoModuloSistema.GeneralMantenimientos
        '                        Me.rpgGeneralMantenimientos.ItemLinks.Add(BarButtonItemOpcion)
        '                End Select
        '            Case enumModuloSistema.Mantenimiento
        '                Select Case lOpcionMantenimiento.GrupoModuloSistema
        '                    Case enumGrupoModuloSistema.CatalogosMantenimientos
        '                        Me.rpgGeneralMantenimiento.ItemLinks.Add(BarButtonItemOpcion)
        '                End Select
        '            Case enumModuloSistema.Pagos
        '                Select Case lOpcionMantenimiento.GrupoModuloSistema
        '                    Case enumGrupoModuloSistema.GeneralPagos
        '                        Me.rpgGeneralPago.ItemLinks.Add(BarButtonItemOpcion)
        '                End Select
        '            Case enumModuloSistema.RegistroDeBeneficiarios
        '                Select Case lOpcionMantenimiento.GrupoModuloSistema
        '                    Case enumGrupoModuloSistema.ReportesRegistro
        '                        Me.rpgReportesRegistro.ItemLinks.Add(BarButtonItemOpcion)
        '                End Select
        '            Case enumModuloSistema.Duplicados
        '                Me.rpgGeneralDuplicados.ItemLinks.Add(BarButtonItemOpcion)
        '        End Select

        '        idNumber += 1

        '    End If
        'Next


        Dim rPages(0) As RibbonPage

        ReDim rPages(_ListaOpcionesMenuHabilitadas.Count + 1)

        Dim index As Integer = 0
        Dim idNumber As Integer = 186

        For Each lOpcionMenu As SQLMembershipProvider.EL.OpcionesMenu In _ListaOpcionesMenuHabilitadas
            Dim rp As New DevExpress.XtraBars.Ribbon.RibbonPage

            rp.Name = "rp" + lOpcionMenu.CodigoMenu.Replace(" ", "")
            rp.Text = lOpcionMenu.CodigoMenu
            rp.KeyTip = lOpcionMenu.DescripcionMenu
            rPages(index) = rp

            Dim lOpcionesGrupos As SQLMembershipProvider.EL.listaOpcionesMenu
            lOpcionesGrupos = mp.ObtenerOpcionesHabilitadasPorUsuario(My.MySettings.Default.idSistema, Me.Usuario, lOpcionMenu.IdOpcionMenu)

            Dim rpGrupos(0) As RibbonPageGroup

            ReDim rpGrupos(lOpcionesGrupos.Count - 1)

            Dim indiceGrupo As Integer = 0

            For Each lOpcionGrupo As SQLMembershipProvider.EL.OpcionesMenu In lOpcionesGrupos
                Dim rpGrupo As New DevExpress.XtraBars.Ribbon.RibbonPageGroup

                rpGrupo.Name = "rPageGroup" + lOpcionGrupo.CodigoMenu.Replace(" ", "")
                rpGrupo.ShowCaptionButton = False
                rpGrupo.Text = lOpcionGrupo.CodigoMenu

                Dim lOpciones As SQLMembershipProvider.EL.listaOpcionesMenu
                lOpciones = mp.ObtenerOpcionesHabilitadasPorUsuario(My.MySettings.Default.idSistema, Me.Usuario, lOpcionGrupo.IdOpcionMenu)

                For Each lOpcion As SQLMembershipProvider.EL.OpcionesMenu In lOpciones


                    Dim objIcono As Object = ResourceManager.GetObject(lOpcion.UrlImagen, resourceCulture)
                    Dim icono As System.Drawing.Bitmap = CType(objIcono, System.Drawing.Bitmap)

                    Dim BarButtonItemOpcion As New DevExpress.XtraBars.BarButtonItem
                    'BarButtonItemOpcion.Hint = "Otro de Prueba mas"

                    BarButtonItemOpcion.Tag = New OpcionMenu(lOpcion.CodigoMenu, True, icono, RibbonItemStyles.Large, False, System.Type.GetType("SGAFP." + lOpcion.UrlOpcion))
                    BarButtonItemOpcion.Id = idNumber
                    'BarButtonItemOpcion.LargeImageIndex = 17
                    BarButtonItemOpcion.Name = "BarButtonItemOpcion" + idNumber.ToString()
                    'If lOpcionMantenimiento.EstiloDeBoton = RibbonItemStyles.Large Then
                    BarButtonItemOpcion.LargeGlyph = icono
                    BarButtonItemOpcion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
                    BarButtonItemOpcion.Caption = lOpcion.CodigoMenu
                    'Else
                    '    BarButtonItemOpcion.Glyph = lOpcionMantenimiento.Icono
                    '    BarButtonItemOpcion.RibbonStyle = lOpcionMantenimiento.EstiloDeBoton
                    '    If lOpcionMantenimiento.EstiloDeBoton <> RibbonItemStyles.SmallWithoutText Then
                    '        BarButtonItemOpcion.Caption = lOpcionMantenimiento.Texto
                    '    End If
                    'End If
                    AddHandler BarButtonItemOpcion.ItemClick, AddressOf BarButtonItemOpcion_ItemClick

                    Me.ribbonControl1.Items.Add(BarButtonItemOpcion)
                    rpGrupo.ItemLinks.Add(BarButtonItemOpcion)

                    idNumber += 1
                Next

                'Me.ribbonPageGroupSkin.ItemLinks.Add(Me.rgbiSkins)
                rpGrupos(indiceGrupo) = rpGrupo
                indiceGrupo += 1
            Next
            rp.Groups.AddRange(rpGrupos)

            index += 1
        Next

        rPages(_ListaOpcionesMenuHabilitadas.Count) = Me.rpPreferencias
        rPages(_ListaOpcionesMenuHabilitadas.Count + 1) = Me.rpAyuda

        Me.ribbonControl1.Pages.Clear()
        Me.ribbonControl1.Pages.AddRange(rPages)

    End Sub

    Private Sub CrearOpcionesMantenimientos()
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.JefeHTP) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("Asignación de Centros de Formación", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmAsignacionCentro_Tecnico)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.CoordinadorPATI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.GerenteUFI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.AuditorExterno) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Ejecución", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmCursosProgramaPATI)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.AuditorExterno) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Pagos", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmCursosProgramaPATI)))
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Participantes", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmAsistenciaNotaParticipantesPATI)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.GerenteUFI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Desembolsos", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmDesembolsosPATI)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.CoordinadorPATI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Asistencia y Nota por Participante", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmAsistenciaNotaParticipantesPATI)))
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Participantes Activos/No Activos", True, My.Resources.users_1, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmParticipantesActivoYNoActivosPATI)))
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Análisis Ejecución", True, My.Resources.stats, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmAnalisisEjecucionPATI)))
        '    Me._ListaOpciones.Add(New OpcionMenu("PATI - Caracteristicas Sociales", True, My.Resources.web, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmAnalisisCaracSocialesPATI)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.TecnicoCentroHTP) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.GerenteGFI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.JefeHTP) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    'Me._ListaOpciones.Add(New OpcionMenu("Solicitudes", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmSolicitudesReport)))
        '    Me._ListaOpciones.Add(New OpcionMenu("VoBo Informes", True, My.Resources.autorizacion, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmInformeFinal)))
        '    Me._ListaOpciones.Add(New OpcionMenu("Ejecución de Programas (HTP/PATI)", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmEjecucionProgramas)))
        'End If

        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.CoordinadorPATI) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("Asociacion TDRs", True, My.Resources.shopping, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmTDRsAsociadosPATI)))
        'End If

        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.TecnicoCentroHTP) OrElse _
        '  Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.GerenteGFI) OrElse _
        '  Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.JefeHTP) OrElse _
        '  Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("Particip. Exonerados (DUI/NIT)", True, My.Resources.autorizacion, enumModuloSistema.Mantenimiento, enumGrupoModuloSistema.CatalogosMantenimientos, RibbonItemStyles.Large, False, GetType(frmMantPARTICIPANTE_EXONERADO_DOC)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Auditor) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("Ejecución de Programas (HTP/PATI)", True, My.Resources.informe, enumModuloSistema.Mantenimientos, enumGrupoModuloSistema.GeneralMantenimientos, RibbonItemStyles.Large, False, GetType(frmEjecucionProgramas)))
        'End If
        'If Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.Administrador) OrElse _
        '   Roles.IsUserInRole(Me.Usuario, Enumeradores.RolDeUsuario.ColaboradorUACIHTP) Then
        '    Me._ListaOpciones.Add(New OpcionMenu("Autorización de Pago", True, My.Resources.autorizacion, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmAutorizacionPago)))
        '    'Me._ListaOpciones.Add(New OpcionMenu("Autorización de Pago", True, My.Resources.autorizacion, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmInformeFinal)))
        '    Me._ListaOpciones.Add(New OpcionMenu("Factura Cursos", True, My.Resources.my_invoices, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmFacturaCursos)))
        'End If

    End Sub

    '    Private Sub CrearOpcionesRegistroDeBeneficiarios()
    '        Me._ListaOpciones.Add(New OpcionMenu("Conformación de Familias", True, Global.RED.My.Resources.Conformacion, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.Large, False, GetType(frmConformarFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Modificación de Registro de Familia", True, Global.RED.My.Resources.ModificarRegistro, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.Large, False, GetType(frmModiRegistroFami)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Registro Familias no Validadas Por Comite Municipal", True, Global.RED.My.Resources.FamiliasNoValidadas, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.Large, False, GetType(frmRegistroFamiliasNoValidadasPorComite)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Actualización Beneficios", True, Global.RED.My.Resources.Conformacion, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.Large, False, GetType(frmActualizacionFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Conformación de Familias", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmParReporteFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Incumplimientos Familia", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReporteIncumplimientosFamilia)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Conformación de Familias por Sectores (Educación/Salud)", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmParConformacionFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte de Beneficiarios Matriculados", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReporteBeneficiariosMatriculados)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Estados de Familia", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReporteEstadosFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Potenciales Beneficiarios PAEBA", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReportePotencialesPAEBA)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte de Información de personas censadas", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmParConformacionFamilias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte beneficiarios sin DUI", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReporteSinDocumento)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Potenciales Familias Beneficiaras del Area Urbana", True, Global.RED.My.Resources.Reportes_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ReportesRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmReportePotencialesFamiliasBeneficiarias)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Registro de Matriculas", True, Global.RED.My.Resources.Consola_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmRegistroMatricula)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Registro de Potenciales Beneficiarios PAEBA", True, Global.RED.My.Resources.Consola_16x16, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.SmallWithText, False, GetType(frmPOTE_BENE_PAEB)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Actualizar Edades Personas", True, Global.RED.My.Resources.Consola, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ActualizacionEdadesRegistro, RibbonItemStyles.Large, False, GetType(frmActualizarEdadesPersonas)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Historial Actualización de Edades", True, Global.RED.My.Resources.Consola, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.ActualizacionEdadesRegistro, RibbonItemStyles.Large, False, GetType(frmReporteActualizacionEdadesPersonas)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Evaluaciones Externas de Adultos Mayores", True, Global.RED.My.Resources.Consola, enumModuloSistema.RegistroDeBeneficiarios, enumGrupoModuloSistema.GeneralRegistro, RibbonItemStyles.Large, False, GetType(frmEvaluacionesExternas)))
    '    End Sub

    '    Private Sub CrearOpcionesDuplicados()
    '        Me._ListaOpciones.Add(New OpcionMenu("Validacion de Duplicados", True, Global.RED.My.Resources.Consola, enumModuloSistema.Duplicados, RibbonItemStyles.Large, False, GetType(frmValidacionDuplicados)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Validar DUI Beneficiario", True, Global.RED.My.Resources.Consola, enumModuloSistema.Duplicados, RibbonItemStyles.Large, False, GetType(frmBuscarDUI)))
    '    End Sub

    '    Private Sub CrearOpcionesIncorporacion()
    '        'Como no hay Grupos solo General, 
    '        'no se incluye el parametro de GrupoModuloSistema
    '        Me._ListaOpciones.Add(New OpcionMenu("Generar Incorporaciones", True, Global.RED.My.Resources.generarIncorporacion, enumModuloSistema.Incorporacion, RibbonItemStyles.Large, False, GetType(frmGenerarIncorporaciones)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Certificar Incorporaciones", True, Global.RED.My.Resources.certificarIncorporacion, enumModuloSistema.Incorporacion, RibbonItemStyles.Large, False, GetType(frmAceptarCertIncorpAMU)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Validar DUI de Actas Precesadas", True, Global.RED.My.Resources.VerificarDui, enumModuloSistema.Incorporacion, RibbonItemStyles.Large, False, GetType(frmValidacionDuisActas)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Validacion DUI", True, Global.RED.My.Resources.DuiVerificado, enumModuloSistema.Incorporacion, RibbonItemStyles.Large, False, GetType(frmReporteValidacionRNPN)))
    '    End Sub

    '    Private Sub CrearOpcionesPagos()
    '        Me._ListaOpciones.Add(New OpcionMenu("Exoneración de Descuentos", True, Global.RED.My.Resources.ExoneracionDescuento, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmPersonasNoDescuentos)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Registro de Tarjetas", True, Global.RED.My.Resources.CreditCards, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmTARJ_BENE)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Ajustes", True, Global.RED.My.Resources.Ajustes, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmREIN_TMC)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reclamos", True, Global.RED.My.Resources.Reclamos, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmReclamos)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Planilla de Pagos", True, Global.RED.My.Resources.ReportesPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.ReportesPlanillaPagos, RibbonItemStyles.Large, False, GetType(frmPlanillaDePagoReporte)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Historial Estados de Planilla", True, Global.RED.My.Resources.ReportesPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.ReportesPlanillaPagos, RibbonItemStyles.Large, False, GetType(frmReporteHistorialEstadosPlanilla)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Crear Planilla de Pagos", True, Global.RED.My.Resources.CrearPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmEncabezadoPlanilla)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Generar Detalle de Planilla de Pagos", True, Global.RED.My.Resources.GenerarPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmPlanillaDePago)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Aprobar Planilla de Pagos", True, Global.RED.My.Resources.AprobarPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmAprobarPlanillaDePago)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Definición de Ubicaciones de Pago de Planilla", True, Global.RED.My.Resources.UbicacionesPago, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmPAGO_PLAN_UBIC)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Mantenimiento de Especificaciones de Partidas o Cheques", True, Global.RED.My.Resources.MantenimientoPartidasCheques, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmIntegrarManttoCuentas)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Generar Partida de Pago y/o Cheque", True, Global.RED.My.Resources.Cheque, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmIntegrarListadoPlanilla)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Cuentas de Obligación por Departamento", True, Global.RED.My.Resources.CuentasObligacion, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmCuentasObligacionDepartamento)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Permisos de Modificación de Liquidación", True, Global.RED.My.Resources.Permisos, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmPERM_PLAN)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Liquidación Planillas", True, Global.RED.My.Resources.Reportes, enumModuloSistema.Pagos, enumGrupoModuloSistema.ReportesLiquidacionPagos, RibbonItemStyles.Large, False, GetType(frmLiquidacionReporte)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Administración Listados de Tarjetas de Pago", True, Global.RED.My.Resources.AdministracionTarjetas, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmListadoTarjetasPago)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Liquidar Planilla de Pagos", True, Global.RED.My.Resources.Liquidacion, enumModuloSistema.Pagos, enumGrupoModuloSistema.LiquidacionPagos, RibbonItemStyles.Large, False, GetType(frmLiquidacion)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Planillas PATI", True, Global.RED.My.Resources.GenerarPlanilla, enumModuloSistema.Pagos, enumGrupoModuloSistema.PlanillaPagos, RibbonItemStyles.Large, False, GetType(frmPlanillaPATI)))
    '    End Sub

    '    Private Sub CrearOpcionesSeguimientos()
    '        Me._ListaOpciones.Add(New OpcionMenu("Administrar Períodos de Seguimiento", True, Global.RED.My.Resources.Periodos, enumModuloSistema.Seguimientos, RibbonItemStyles.Large, False, GetType(frmAdministracionPeriodosSeguimiento)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Control de Seguimientos", True, Global.RED.My.Resources.EstadoPeriodo, enumModuloSistema.Seguimientos, RibbonItemStyles.Large, False, GetType(frmGeneraRptSalud)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Reporte Estado de Periodos", True, Global.RED.My.Resources.Periodos, enumModuloSistema.Seguimientos, RibbonItemStyles.Large, False, GetType(frmReporteEstadoPeriodos)))
    '        Me._ListaOpciones.Add(New OpcionMenu("Registro de Personas a Seguimiento", True, Global.RED.My.Resources.ModificarRegistro, enumModuloSistema.Seguimientos, RibbonItemStyles.Large, False, GetType(frmRegistrarPersonasSeguimiento)))
    '    End Sub

    'Private Sub CrearHabilitacionOpciones()
    '    For Each lOpcion As OpcionMenu In Me._ListaOpciones
    '        Dim habilitar As Boolean = False
    '        For Each mEntidad As OpcionesMenu In Me._ListaOpcionesMenuHabilitadas
    '            If mEntidad.descOpcionMenu = lOpcion.Texto Then
    '                habilitar = True
    '                Exit For
    '            End If
    '        Next
    '        lOpcion.Habilitado = habilitar
    '    Next
    'End Sub

#End Region

#Region "Ejecucion de Opciones"

    Private Sub BarButtonItemOpcion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'AbrirFormulario(GetType(frmPrueba))
        Dim lOpcion As OpcionMenu = CType(e.Item, BarButtonItem).Tag
        'If lOpcion.Texto = "Reclamos" Then
        '    If DevExpress.XtraEditors.XtraMessageBox.Show("¿El reclamo de descuento que registrará corresponde a una planilla de fecha anterior al 31 de agosto de 2009?", "Comunidades Solidarias", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        '        ' Ventana de reclamos Red Solidaria(Planillas antes del 31 de agosto de 2009)
        '        'Me._ListaOpciones.Add(New OpcionMenu("Reclamos", True, Global.RED.My.Resources.Consola, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmReclamosCORR_INCU)))
        '        'Me.ProcesarComando(lOpcion.Texto, lOpcion.EjecutarAsincrono, GetType(frmReclamosCORR_INCU))
        '    Else
        '        ' Ventana de reclamos Comunidades Solidarias(Planillas posteriores al 31 de agosto de 2009)
        '        'Me._ListaOpciones.Add(New OpcionMenu("Reclamos", True, Global.RED.My.Resources.Consola, enumModuloSistema.Pagos, enumGrupoModuloSistema.GeneralPagos, RibbonItemStyles.Large, False, GetType(frmReclamos)))
        '        Me.ProcesarComando(lOpcion.Texto, lOpcion.EjecutarAsincrono, lOpcion.TipoVentanaInicio)
        '    End If
        '    Exit Sub
        'End If
        Me.ProcesarComando(lOpcion.Texto, lOpcion.EjecutarAsincrono, lOpcion.TipoVentanaInicio)
    End Sub

    Private Sub ProcesarComando(ByVal asComando As String, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
        Me.Cursor = Cursors.WaitCursor
        Select Case asComando
            Case "Reporte de Información de personas censadas"
                'Dim frm As New frmParConformacionFamilias
                'frm.rptReporte = frmParConformacionFamilias.Reporte.PersonasCensadas
                'AddHandler frm.FormClosing, AddressOf Me.frm_FormClosing
                'frm.MdiParent = Me
                'frm.Show()          
            Case Else
                If Not aEjecutarAsincrono Then
                    Me.AbrirFormulario(aTipoVentanaInicio, True, asComando)
                Else
                    Me.Cursor = Cursors.AppStarting
                    'Me.SetToolStripStatus("Cargando...")
                    Dim args(1) As Object
                    args(0) = asComando
                    args(1) = aTipoVentanaInicio
                    If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync(args)
                    Return
                End If
        End Select
        '    Case "Administrar Convenios"
        '        Me.AdministrarConvenios(True)
        '    Case "Conciliacion Mensual de Convenios"
        '        Me.Cursor = Cursors.AppStarting
        '        Me.SetToolStripStatus("Cargando...")
        '        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync(asComando)
        '        Return
        '    Case "Solicitud de Fondos"
        '        Dim ChildForm As frmSolicitudFondos = Me.ObtenerForma(asComando)
        '        If ChildForm Is Nothing Then
        '            ChildForm = New frmSolicitudFondos
        '            Me.AgregarForma(asComando, ChildForm)
        '        End If
        '        ChildForm.Show(Me.DockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document)
        'End Select
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Dim asComando As String = CType(e.Argument(0), String)
    '    Dim tipoVentana As Type = CType(e.Argument(1), Type)
    '    Dim frm As Form = Me.AbrirFormulario(tipoVentana, False)

    '    'e.Result = tipoVentana
    '    Select Case asComando
    '        Case ""
    '        Case Else
    '    End Select

    '    e.Result = frm

    '    Select Case asComando
    '        Case "Consultar Provisiones"
    '            Me.ObtenerFormularioAbierto()
    '            Dim ChildForm As frmSolicitarProvisiones = Me.ObtenerForma(asComando)
    '            If ChildForm Is Nothing Then
    '                ChildForm = New frmSolicitarProvisiones
    '                ChildForm.Text = "Consultar Provisiones"
    '                ChildForm.TabText = "Consultar Provisiones"
    '                ChildForm.CargarParaConsulta()
    '                Me.AgregarForma(asComando, ChildForm)
    '            End If
    '            e.Result = ChildForm
    '    End Select
    'End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'If CType(e.Result, Boolean) Then

        'End If
        Dim ChildForm As Form = CType(e.Result, Form)
        ChildForm.Show()
        'Me.ToolStripButtonLoading.Visible = False
        'Me.SetToolStripStatus("Listo")
        Me.Cursor = Cursors.Arrow
    End Sub

#End Region

    Private Sub mFrmLogin_Close(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim form As frmLogin
        form = sender
        Me._Usuario = form.Usuario
        'Me._Base = form.Base
        'Me.Text = Me.Text & " - Usuario: " & Me._Usuario & "[" & Me._Base & "]"
    End Sub

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub

    Public Property ApplicationCaption() As String
        Get
            Return ribbonControl1.ApplicationCaption
        End Get
        Set(ByVal value As String)
            ribbonControl1.ApplicationCaption = value
        End Set
    End Property

    Private Sub frm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Public Function AbrirFormulario(ByVal tipoFormulario As Type, Optional ByVal aAbrirFormulario As Boolean = True, Optional ByVal aTituloForma As String = "") As Form
        Dim frm As Form
        frm = Me.ObtenerFormularioAbierto(tipoFormulario, aTituloForma)
        If frm Is Nothing Then
            frm = TryCast(System.Reflection.Assembly.GetAssembly(tipoFormulario).CreateInstance(tipoFormulario.FullName), Form)
            AddHandler frm.FormClosing, AddressOf Me.frm_FormClosing
            frm.Text = aTituloForma
            frm.MdiParent = Me
            If aAbrirFormulario Then
                frm.Show()
            End If
        Else
            frm.Focus()
        End If
        Return frm
    End Function

    Private Sub bbiReporteSolicitudes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Me.AbrirFormulario(GetType(frmSolicitudesReport), True)
        Me.Cursor = Cursors.Default
    End Sub


End Class
