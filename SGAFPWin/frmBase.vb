Imports System.Configuration.ConfigurationManager
Imports DevExpress.XtraEditors

Public Class frmBase
    Inherits DevExpress.XtraEditors.XtraForm

    Delegate Sub SetPropiedadCallBack(ByRef control As Object, ByVal valor As Object, ByVal propiedad As String)
    Dim d As New SetPropiedadCallBack(AddressOf SetPropiedad)
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItemCerrar As DevExpress.XtraBars.BarButtonItem

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarButtonItemCerrar = New DevExpress.XtraBars.BarButtonItem
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItemCerrar})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItemCerrar)})
        Me.Bar1.Text = "Tools"
        Me.Bar1.Visible = False
        '
        'BarButtonItemCerrar
        '
        Me.BarButtonItemCerrar.Caption = "Cerrar"
        Me.BarButtonItemCerrar.Glyph = Global.SGAFP.My.Resources.Resources.door
        Me.BarButtonItemCerrar.Id = 0
        Me.BarButtonItemCerrar.Name = "BarButtonItemCerrar"
        Me.BarButtonItemCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        Me.Bar3.Visible = False
        '
        'frmBase
        '
        Me.ClientSize = New System.Drawing.Size(441, 299)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBase"
        Me.Text = "frmBase"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property VerBarraOpciones() As Boolean
        Get
            Return Me.Bar1.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.Bar1.Visible = value
            'Me.Bar2.Visible = value
            'Me.Bar3.Visible = value
        End Set
    End Property

    Public ListaOpciones As List(Of OpcionBarra) = New List(Of OpcionBarra)

    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal esError As Boolean = False)
        If Not esError Then
            XtraMessageBox.Show(asMensaje, AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            XtraMessageBox.Show(String.Format("Suceso inesperado : {0}", asMensaje), AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function Preguntar(ByVal asMensaje As String, Optional ByVal botones As MessageBoxButtons = MessageBoxButtons.YesNo) As System.Windows.Forms.DialogResult
        Return XtraMessageBox.Show(asMensaje, AppSettings("nombreSistema"), botones, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    End Function

    Public Function IngresarMotivo(ByVal asTitulo As String, ByVal asMensaje As String, ByRef asMotivo As String) As System.Windows.Forms.DialogResult
        Dim fMotivo As New frmMotivoCambio
        Dim lRet As DialogResult
        fMotivo.Text = asTitulo
        fMotivo.LabelMensaje.Text = asMensaje
        fMotivo.MemoEditMotivo.Text = ""
        lRet = fMotivo.ShowDialog()
        asMotivo = fMotivo.MemoEditMotivo.Text
        Return lRet
    End Function

    Public Function EstaEnRol(ByVal asRol As String) As Boolean
        Return System.Threading.Thread.CurrentPrincipal.IsInRole(asRol)
    End Function

    Public ReadOnly Property usuarioActualizacion() As String
        Get
            Return EL.configuracion.usuarioActualiza
        End Get
    End Property

    Public IdControl As Integer = 10

    Public Sub AgregarOpcion(ByVal asComando As String, ByVal asTexto As String, ByVal aiImagenIcono As Image, Optional ByVal abVerTexto As Boolean = False)
        If Not Me.VerBarraOpciones Then
            Me.VerBarraOpciones = True
        End If

        Dim lPredicado As New PredicateLlaveOpcionBarra
        lPredicado.Texto = asTexto
        If Not Me.ListaOpciones Is Nothing AndAlso Me.ListaOpciones.Exists(AddressOf lPredicado.ExisteOpcion) Then Return
        'CType(Me.ParentForm, frmPrincipal).AddMenuOption(asTexto, aiImagenIcono, abOpcionBarra, abVerTexto)
        Dim lOpcion As New OpcionBarra
        lOpcion.Texto = asTexto
        lOpcion.Comando = asComando
        lOpcion.Habilitado = True
        lOpcion.Icono = aiImagenIcono
        lOpcion.VerTexto = abVerTexto
        Me.ListaOpciones.Add(lOpcion)

        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Dim BarButtonItem1 As New DevExpress.XtraBars.BarButtonItem
        BarButtonItem1.Caption = lOpcion.Texto
        If Not lOpcion.Icono Is Nothing Then
            BarButtonItem1.Glyph = lOpcion.Icono
        End If
        BarButtonItem1.Width = 16
        'BarButtonItem1.Glyph.Size.Height = 16
        'BarButtonItem1.Glyph.Size.Width = 16
        BarButtonItem1.Id = IdControl
        BarButtonItem1.Name = "BarButtonItem" + IdControl.ToString
        BarButtonItem1.Tag = lOpcion.Comando

        If Not lOpcion.Icono Is Nothing Then
            If lOpcion.VerTexto Then
                BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            Else
                BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Standard
            End If
        Else
            BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        End If

        AddHandler BarButtonItem1.ItemClick, AddressOf BarButtonItem1_ItemClick

        lOpcion.ControlName = "BarButtonItem" + IdControl.ToString

        IdControl += 1

        Me.BarManager1.Items.Add(BarButtonItem1)

        Me.Bar1.LinksPersistInfo.Add(New DevExpress.XtraBars.LinkPersistInfo(BarButtonItem1))

        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

        'CType(Me.ParentForm, frmPrincipal).AddMenuOption(asTexto, aiImagenIcono, abOpcionBarra, abVerTexto)
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim band As Boolean = False
        For Each lControl As Control In Me.Controls
            If lControl.GetType().BaseType Is GetType(ucBaseWin) Then
                CType(lControl, ucBaseWin).EjecutarOpcion(CType(e.Item, DevExpress.XtraBars.BarButtonItem).Tag)
                band = True
                Exit For
            End If
        Next
        If Not band Then
            Me.EjecutarOpcion(CType(e.Item, DevExpress.XtraBars.BarButtonItem).Tag)
        End If
    End Sub
    Public Overridable Sub EjecutarOpcion(ByVal asComando As String)
        'If asOpcion = "Ayuda Dinámica" Then
        '    EjecutarAyuda()
        'End If
    End Sub
    ''' <summary>
    ''' Permite Deshabilitar una opcion seleccionada del ToolBar(ej.Me.DeshabilitarOpcion("Carta al Banco"))
    ''' </summary>
    ''' <param name="asTexto"></param>
    ''' <remarks></remarks>
    Public Sub DeshabilitarOpcion(ByVal asTexto As String)
        'CType(Me.ParentForm, frmPrincipal).DisableMenuOption(asTexto)
        Dim lPredicado As New PredicateLlaveOpcionBarra
        lPredicado.Texto = asTexto
        If Me.ListaOpciones.Exists(AddressOf lPredicado.ExisteOpcion) Then
            Dim lOpcion As OpcionBarra = Me.ListaOpciones.Find(AddressOf lPredicado.ExisteOpcion)
            lOpcion.Habilitado = False
            Me.BarManager1.Items(lOpcion.ControlName).Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Permite Habilitar una opcion seleccionada del ToolBar(ej.Me.HabilitarOpcion("Carta al Banco"))
    ''' </summary>
    ''' <param name="asTexto"></param>
    ''' <remarks></remarks>
    Public Sub HabilitarOpcion(ByVal asTexto As String)
        'CType(Me.ParentForm, frmPrincipal).EnableMenuOption(asTexto)
        Dim lPredicado As New PredicateLlaveOpcionBarra
        lPredicado.Texto = asTexto
        If Me.ListaOpciones.Exists(AddressOf lPredicado.ExisteOpcion) Then
            Dim lOpcion As OpcionBarra = Me.ListaOpciones.Find(AddressOf lPredicado.ExisteOpcion)
            lOpcion.Habilitado = True
            Me.BarManager1.Items(lOpcion.ControlName).Enabled = True
        End If
    End Sub

    Public Sub HabilitarOpciones()
        If Not Me.ListaOpciones Is Nothing AndAlso Me.ListaOpciones.Count > 0 Then
            'CType(Me.ParentForm, frmPrincipal).EnableOptions()
            ListaOpciones.ForEach(AddressOf CrearOpcion)
        End If
    End Sub

    Private Sub CrearOpcion(ByVal aOpcion As OpcionBarra)
        Me.AgregarOpcion(aOpcion.Comando, aOpcion.Texto, aOpcion.Icono, aOpcion.VerTexto)
        If aOpcion.Habilitado Then
            Me.HabilitarOpcion(aOpcion.Texto)
        Else
            Me.DeshabilitarOpcion(aOpcion.Texto)
        End If
    End Sub

    Public Sub DeshabilitarOpciones()
        If Not Me.ListaOpciones Is Nothing AndAlso Me.ListaOpciones.Count > 0 Then
            'CType(Me.ParentForm, frmPrincipal).EnableOptions()
            ListaOpciones.ForEach(AddressOf CrearOpcion)
        End If
    End Sub

    'Public Sub LimpiarOpciones()
    '    If Not Me.ListaOpciones Is Nothing AndAlso Me.ListaOpciones.Count > 0 Then
    '        'If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmPrincipal).ClearOptions()
    '    End If
    'End Sub

    Private Sub BarButtonItemCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemCerrar.ItemClick
        Me.Close()
    End Sub

    Public Sub AsignarValor(ByRef control As Control, ByVal valor As Object, ByVal propiedad As String)
        If control.InvokeRequired Then
            Me.Invoke(d, New Object() {control, valor, propiedad})
        Else
            Me.SetPropiedad(control, valor, propiedad)
        End If
    End Sub

    Private Sub SetPropiedad(ByRef control As Object, ByVal valor As Object, ByVal propiedad As String)
        Dim p() As System.Reflection.PropertyInfo = control.GetType.GetProperties()
        For Each pi As System.Reflection.PropertyInfo In p
            If pi.Name = propiedad Then
                pi.SetValue(control, valor, Nothing)
                Exit For
            End If
        Next
    End Sub

    Public Sub InvocarMetodo(ByVal invocadorMetodo As MethodInvoker)
        Me.Invoke(invocadorMetodo)
    End Sub

    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

'Public Class OpcionMenu

'    Public Texto As String = ""
'    Public Habilitado As Boolean = True
'    Public Icono As Image = Nothing
'    Public ModuloSistema As enumModuloSistema = enumModuloSistema.Mantenimientos
'    Public GrupoModuloSistema As enumGrupoModuloSistema = enumGrupoModuloSistema.CatalogosMantenimientos
'    Public EstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles
'    Public EjecutarAsincrono As Boolean
'    Public TipoVentanaInicio As Type

'    Private Sub New()

'    End Sub

'    Public Sub New(ByVal asTexto As String, ByVal abHabilitado As Boolean, ByVal aiIcono As Image, ByVal aModuloSistema As enumModuloSistema, ByVal aEstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
'        Me.Texto = asTexto
'        Me.Habilitado = abHabilitado
'        Me.Icono = aiIcono
'        Me.ModuloSistema = aModuloSistema
'        Me.EstiloDeBoton = aEstiloDeBoton
'        Me.EjecutarAsincrono = aEjecutarAsincrono
'        Me.TipoVentanaInicio = aTipoVentanaInicio
'    End Sub

'    Public Sub New(ByVal asTexto As String, ByVal abHabilitado As Boolean, ByVal aiIcono As Image, ByVal aModuloSistema As enumModuloSistema, ByVal aGrupoModuloSistema As enumGrupoModuloSistema, ByVal aEstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
'        Me.Texto = asTexto
'        Me.Habilitado = abHabilitado
'        Me.Icono = aiIcono
'        Me.ModuloSistema = aModuloSistema
'        Me.GrupoModuloSistema = aGrupoModuloSistema
'        Me.EstiloDeBoton = aEstiloDeBoton
'        Me.EjecutarAsincrono = aEjecutarAsincrono
'        Me.TipoVentanaInicio = aTipoVentanaInicio
'    End Sub

'End Class

Public Class OpcionMenu

    Public Texto As String = ""
    Public Habilitado As Boolean = True
    Public Icono As Image = Nothing
    Public EstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles
    Public EjecutarAsincrono As Boolean
    Public TipoVentanaInicio As Type

    Private Sub New()

    End Sub

    Public Sub New(ByVal asTexto As String, ByVal abHabilitado As Boolean, ByVal aiIcono As Image, ByVal aEstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
        Me.Texto = asTexto
        Me.Habilitado = abHabilitado
        Me.Icono = aiIcono
        Me.EstiloDeBoton = aEstiloDeBoton
        Me.EjecutarAsincrono = aEjecutarAsincrono
        Me.TipoVentanaInicio = aTipoVentanaInicio
    End Sub

End Class

Public Class OpcionBarra

    Public Comando As String = ""
    Public Texto As String = ""
    Public Habilitado As Boolean = True
    Public Icono As Image = Nothing
    Public VerTexto As Boolean
    Public ControlName As String

    Public Sub New()

    End Sub

    'Public Sub New(ByVal asTexto As String, ByVal abHabilitado As Boolean, ByVal aiIcono As Image, ByVal aModuloSistema As enumModuloSistema, ByVal aEstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
    '    Me.Texto = asTexto
    '    Me.Habilitado = abHabilitado
    '    Me.Icono = aiIcono
    '    Me.ModuloSistema = aModuloSistema
    '    Me.EstiloDeBoton = aEstiloDeBoton
    '    Me.EjecutarAsincrono = aEjecutarAsincrono
    '    Me.TipoVentanaInicio = aTipoVentanaInicio
    'End Sub

    'Public Sub New(ByVal asTexto As String, ByVal abHabilitado As Boolean, ByVal aiIcono As Image, ByVal aModuloSistema As enumModuloSistema, ByVal aGrupoModuloSistema As enumGrupoModuloSistema, ByVal aEstiloDeBoton As DevExpress.XtraBars.Ribbon.RibbonItemStyles, ByVal aEjecutarAsincrono As Boolean, ByVal aTipoVentanaInicio As Type)
    '    Me.Texto = asTexto
    '    Me.Habilitado = abHabilitado
    '    Me.Icono = aiIcono
    '    Me.ModuloSistema = aModuloSistema
    '    Me.GrupoModuloSistema = aGrupoModuloSistema
    '    Me.EstiloDeBoton = aEstiloDeBoton
    '    Me.EjecutarAsincrono = aEjecutarAsincrono
    '    Me.TipoVentanaInicio = aTipoVentanaInicio
    'End Sub

End Class

'Public Class PredicateLlaveOpcionMenu

'    Public Texto As String

'    Public Function ExisteOpcion(ByVal opcion As OpcionMenu) As Boolean
'        Return opcion.Texto = Texto
'    End Function

'    Public Modulo As enumModuloSistema

'    Public Function ModuloOpcion(ByVal opcion As OpcionMenu) As Boolean
'        Return opcion.ModuloSistema = Modulo
'    End Function

'End Class

Public Class PredicateLlaveOpcionMenu

    Public Texto As String

    Public Function ExisteOpcion(ByVal opcion As OpcionMenu) As Boolean
        Return opcion.Texto = Texto
    End Function

End Class

Public Class PredicateLlaveOpcionBarra

    Public Texto As String

    Public Function ExisteOpcion(ByVal opcion As OpcionBarra) As Boolean
        Return opcion.Texto = Texto
    End Function

End Class

Public Enum enumModuloSistema As Integer
    Mantenimientos = 1
    RegistroDeBeneficiarios = 2
    Duplicados = 3
    Incorporacion = 4
    Pagos = 5
    Seguimientos = 6
    Mantenimiento = 7
End Enum

Public Enum enumGrupoModuloSistema As Integer
    CatalogosMantenimientos = 1
    GeneralMantenimientos = 2
    SeguimientosMantenimientos = 3
    DuplicadosMantenimientos = 4
    ConformacionMantenimientos = 5
    GeneralRegistro = 6
    ReportesRegistro = 7
    ActualizacionEdadesRegistro = 8
    GeneralPagos = 9
    PlanillaPagos = 10
    LiquidacionPagos = 11
    ReportesPagos = 12
    ReportesPlanillaPagos = 13
    ReportesLiquidacionPagos = 14
    SolicitudCapacitacion = 14
End Enum
