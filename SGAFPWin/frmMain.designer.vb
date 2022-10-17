Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Demos.RibbonSimplePad
Partial Public Class frmMain

#Region "Designer generated code"
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup
        Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup
        Dim GalleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup
        Dim GalleryItemGroup4 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem
        Me.gddFont = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
        Me.beiFontSize = New DevExpress.XtraBars.BarEditItem
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.bbiFontColorPopup = New DevExpress.XtraBars.BarButtonItem
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem
        Me.rgbiFont = New DevExpress.XtraBars.RibbonGalleryBarItem
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem
        Me.RibbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
        Me.rpReportes1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGeneralMantenimientos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpPagoAcciones = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGeneralPago = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpMantenimiento1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGeneralMantenimiento = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpPreferencias = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribbonPageGroupSkin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpAyuda = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.pmNew = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.pccAppMenu = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.pcAppMenuFileLabels = New DevExpress.XtraEditors.PanelControl
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.pmMain = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.rpgReportesRegistro = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpRegistroBeneficiarios = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGeneralDuplicados = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpDuplicados = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        CType(Me.gddFont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pccAppMenu.SuspendLayout()
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iAbout
        '
        Me.iAbout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.iAbout.Caption = "&Acerca de"
        Me.iAbout.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
        Me.iAbout.Description = "Despliega informacion del Sistema"
        Me.iAbout.Hint = "Despliega la Informacion Acerca de..."
        Me.iAbout.Id = 22
        Me.iAbout.ImageIndex = 28
        Me.iAbout.Name = "iAbout"
        '
        'gddFont
        '
        '
        'gddFont
        '
        Me.gddFont.Gallery.Appearance.ItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gddFont.Gallery.Appearance.ItemCaption.Options.UseFont = True
        Me.gddFont.Gallery.Appearance.ItemCaption.Options.UseTextOptions = True
        Me.gddFont.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gddFont.Gallery.Appearance.ItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gddFont.Gallery.Appearance.ItemDescription.Options.UseTextOptions = True
        Me.gddFont.Gallery.Appearance.ItemDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gddFont.Gallery.Appearance.ItemDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gddFont.Gallery.ColumnCount = 1
        Me.gddFont.Gallery.FixedImageSize = False
        GalleryItemGroup1.Caption = "Main"
        Me.gddFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.gddFont.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.gddFont.Gallery.RowCount = 6
        Me.gddFont.Gallery.ShowGroupCaption = False
        Me.gddFont.Gallery.ShowItemText = True
        Me.gddFont.Gallery.SizeMode = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
        Me.gddFont.ItemLinks.Add(Me.beiFontSize)
        Me.gddFont.ItemLinks.Add(Me.bbiFontColorPopup)
        Me.gddFont.Name = "gddFont"
        Me.gddFont.Ribbon = Me.ribbonControl1
        '
        'beiFontSize
        '
        Me.beiFontSize.Caption = "Font Size"
        Me.beiFontSize.Edit = Me.repositoryItemSpinEdit1
        Me.beiFontSize.Hint = "Font Size"
        Me.beiFontSize.Id = 27
        Me.beiFontSize.Name = "beiFontSize"
        '
        'repositoryItemSpinEdit1
        '
        Me.repositoryItemSpinEdit1.AutoHeight = False
        Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemSpinEdit1.IsFloatValue = False
        Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
        Me.repositoryItemSpinEdit1.UseParentBackground = True
        '
        'bbiFontColorPopup
        '
        Me.bbiFontColorPopup.ActAsDropDown = True
        Me.bbiFontColorPopup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiFontColorPopup.Caption = "Font Color"
        Me.bbiFontColorPopup.Description = "Formats the selected text with the color you click"
        Me.bbiFontColorPopup.DropDownControl = Me.popupControlContainer1
        Me.bbiFontColorPopup.Hint = "Formats the selected text with the color you click"
        Me.bbiFontColorPopup.Id = 36
        Me.bbiFontColorPopup.Name = "bbiFontColorPopup"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.popupControlContainer1.LookAndFeel.SkinName = "Black"
        Me.popupControlContainer1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationButtonText = Nothing
        Me.ribbonControl1.ApplicationIcon = Global.SGAFP.My.Resources.Resources.logo
        Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))})
        '
        '
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.ExpandCollapseItem.Name = ""
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.iAbout, Me.rgbiSkins, Me.beiFontSize, Me.rgbiFont, Me.bbiFontColorPopup, Me.BarEditItem1})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 202
        Me.ribbonControl1.MiniToolbars.Add(Me.RibbonMiniToolbar1)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpReportes1, Me.rpPagoAcciones, Me.rpMantenimiento1, Me.rpPreferencias, Me.rpAyuda})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.RepositoryItemPictureEdit1})
        Me.ribbonControl1.SelectedPage = Me.rpReportes1
        Me.ribbonControl1.Size = New System.Drawing.Size(796, 148)
        Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
        Me.ribbonControl1.TransparentEditors = True
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        GalleryItemGroup2.Caption = "Main Skins"
        GalleryItemGroup3.Caption = "Office Skins"
        Me.rgbiSkins.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup2, GalleryItemGroup3})
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 13
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'rgbiFont
        '
        Me.rgbiFont.Caption = "Font"
        '
        'rgbiFont
        '
        Me.rgbiFont.Gallery.AllowHoverImages = True
        GalleryItemGroup4.Caption = "Main"
        Me.rgbiFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup4})
        Me.rgbiFont.GalleryDropDown = Me.gddFont
        Me.rgbiFont.Id = 29
        Me.rgbiFont.Name = "rgbiFont"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem1.CanOpenEdit = False
        Me.BarEditItem1.Edit = Nothing
        Me.BarEditItem1.Id = 92
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 130
        '
        'rpReportes1
        '
        Me.rpReportes1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGeneralMantenimientos})
        Me.rpReportes1.Name = "rpReportes1"
        Me.rpReportes1.Text = "Reportes"
        Me.rpReportes1.Visible = False
        '
        'rpgGeneralMantenimientos
        '
        Me.rpgGeneralMantenimientos.Name = "rpgGeneralMantenimientos"
        Me.rpgGeneralMantenimientos.ShowCaptionButton = False
        Me.rpgGeneralMantenimientos.Text = "Generales"
        '
        'rpPagoAcciones
        '
        Me.rpPagoAcciones.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGeneralPago})
        Me.rpPagoAcciones.Name = "rpPagoAcciones"
        Me.rpPagoAcciones.Text = "Pago Acciones Formativas"
        Me.rpPagoAcciones.Visible = False
        '
        'rpgGeneralPago
        '
        Me.rpgGeneralPago.Name = "rpgGeneralPago"
        Me.rpgGeneralPago.ShowCaptionButton = False
        Me.rpgGeneralPago.Text = "General"
        '
        'rpMantenimiento1
        '
        Me.rpMantenimiento1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGeneralMantenimiento})
        Me.rpMantenimiento1.Name = "rpMantenimiento1"
        Me.rpMantenimiento1.Text = "Mantenimiento"
        Me.rpMantenimiento1.Visible = False
        '
        'rpgGeneralMantenimiento
        '
        Me.rpgGeneralMantenimiento.Name = "rpgGeneralMantenimiento"
        Me.rpgGeneralMantenimiento.ShowCaptionButton = False
        Me.rpgGeneralMantenimiento.Text = "General"
        '
        'rpPreferencias
        '
        Me.rpPreferencias.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroupSkin})
        Me.rpPreferencias.Name = "rpPreferencias"
        Me.rpPreferencias.Text = "Preferencias"
        '
        'ribbonPageGroupSkin
        '
        Me.ribbonPageGroupSkin.ItemLinks.Add(Me.rgbiSkins)
        Me.ribbonPageGroupSkin.Name = "ribbonPageGroupSkin"
        Me.ribbonPageGroupSkin.ShowCaptionButton = False
        Me.ribbonPageGroupSkin.Text = "Skins"
        '
        'rpAyuda
        '
        Me.rpAyuda.Name = "rpAyuda"
        Me.rpAyuda.Text = "Ayuda"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.AllowFocused = False
        Me.RepositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.UseParentBackground = True
        '
        'ribbonStatusBar1
        '
        Me.ribbonStatusBar1.ItemLinks.Add(Me.BarEditItem1)
        Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 560)
        Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
        Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.ribbonStatusBar1.Size = New System.Drawing.Size(796, 23)
        '
        'pmNew
        '
        Me.pmNew.Name = "pmNew"
        Me.pmNew.Ribbon = Me.ribbonControl1
        '
        'pccAppMenu
        '
        Me.pccAppMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pccAppMenu.Controls.Add(Me.pcAppMenuFileLabels)
        Me.pccAppMenu.Controls.Add(Me.labelControl1)
        Me.pccAppMenu.Controls.Add(Me.panelControl1)
        Me.pccAppMenu.Location = New System.Drawing.Point(0, 0)
        Me.pccAppMenu.LookAndFeel.SkinName = "Black"
        Me.pccAppMenu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pccAppMenu.Name = "pccAppMenu"
        Me.pccAppMenu.Ribbon = Me.ribbonControl1
        Me.pccAppMenu.Size = New System.Drawing.Size(310, 162)
        Me.pccAppMenu.TabIndex = 3
        Me.pccAppMenu.Visible = False
        '
        'pcAppMenuFileLabels
        '
        Me.pcAppMenuFileLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcAppMenuFileLabels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcAppMenuFileLabels.Location = New System.Drawing.Point(10, 19)
        Me.pcAppMenuFileLabels.Name = "pcAppMenuFileLabels"
        Me.pcAppMenuFileLabels.Size = New System.Drawing.Size(300, 143)
        Me.pcAppMenuFileLabels.TabIndex = 2
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.labelControl1.LineVisible = True
        Me.labelControl1.Location = New System.Drawing.Point(10, 0)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(300, 19)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Recent Documents:"
        '
        'panelControl1
        '
        Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelControl1.Location = New System.Drawing.Point(0, 0)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(10, 162)
        Me.panelControl1.TabIndex = 1
        '
        'defaultLookAndFeel1
        '
        Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
        '
        'pmMain
        '
        Me.pmMain.MenuCaption = "Edit Menu"
        Me.pmMain.Name = "pmMain"
        Me.pmMain.Ribbon = Me.ribbonControl1
        Me.pmMain.ShowCaption = True
        '
        'imageCollection3
        '
        Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
        Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection3.Images.SetKeyName(2, "search.png")
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Configuración"
        Me.BarButtonItem12.Id = 135
        Me.BarButtonItem12.LargeImageIndex = 16
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BackgroundWorker1
        '
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'rpgReportesRegistro
        '
        Me.rpgReportesRegistro.Name = "rpgReportesRegistro"
        Me.rpgReportesRegistro.ShowCaptionButton = False
        Me.rpgReportesRegistro.Text = "Reportes"
        '
        'rpRegistroBeneficiarios
        '
        Me.rpRegistroBeneficiarios.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgReportesRegistro})
        Me.rpRegistroBeneficiarios.Name = "rpRegistroBeneficiarios"
        Me.rpRegistroBeneficiarios.Text = "Registro de Beneficiarios"
        '
        'rpgGeneralDuplicados
        '
        Me.rpgGeneralDuplicados.Name = "rpgGeneralDuplicados"
        Me.rpgGeneralDuplicados.ShowCaptionButton = False
        Me.rpgGeneralDuplicados.Text = "General"
        '
        'rpDuplicados
        '
        Me.rpDuplicados.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGeneralDuplicados})
        Me.rpDuplicados.Name = "rpDuplicados"
        Me.rpDuplicados.Text = "Duplicados"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Generales"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(796, 583)
        Me.Controls.Add(Me.ribbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar1
        Me.Text = "Gestion y Admón. de la Formacion Profesional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gddFont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pccAppMenu.ResumeLayout(False)
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private components As System.ComponentModel.IContainer
    Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Public ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private rpReportes1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private pmNew As DevExpress.XtraBars.PopupMenu
    Private pmMain As DevExpress.XtraBars.PopupMenu
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents gddFont As DevExpress.XtraBars.Ribbon.GalleryDropDown
    Private beiFontSize As DevExpress.XtraBars.BarEditItem
    Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private rpPreferencias As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroupSkin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiFont As DevExpress.XtraBars.RibbonGalleryBarItem
    Private bbiFontColorPopup As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private pccAppMenu As DevExpress.XtraBars.PopupControlContainer
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private pcAppMenuFileLabels As DevExpress.XtraEditors.PanelControl
    Private imageCollection3 As DevExpress.Utils.ImageCollection
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpAyuda As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents rpgGeneralMantenimientos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents rpgReportesRegistro As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpRegistroBeneficiarios As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgGeneralDuplicados As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpDuplicados As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpPagoAcciones As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgGeneralPago As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpMantenimiento1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgGeneralMantenimiento As DevExpress.XtraBars.Ribbon.RibbonPageGroup

End Class
