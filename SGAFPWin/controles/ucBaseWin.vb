Imports System.Configuration.ConfigurationManager
Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.XtraEditors

Public Class ucBaseWin
    Inherits DevExpress.XtraEditors.XtraUserControl

    Private components As System.ComponentModel.IContainer
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Delegate Sub SetPropiedadCallBack(ByRef control As Object, ByVal valor As Object, ByVal propiedad As String)
    Dim d As New SetPropiedadCallBack(AddressOf SetPropiedad)

    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal esError As Boolean = False)
        If Not esError Then
            XtraMessageBox.Show(asMensaje, AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show(asMensaje, AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            XtraMessageBox.Show(String.Format("Suceso inesperado : {0}", asMensaje), AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("Suceso inesperado : " + asMensaje, AppSettings("nombreSistema"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function Preguntar(ByVal asMensaje As String) As System.Windows.Forms.DialogResult
        Return XtraMessageBox.Show(asMensaje, AppSettings("nombreSistema"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    End Function

    Public Function EstaEnRol(ByVal asRol As String) As Boolean
        Return System.Threading.Thread.CurrentPrincipal.IsInRole(asRol)
    End Function

    Public Overridable Sub EjecutarOpcion(ByVal asComando As String)
        'If asOpcion = "Ayuda Dinámica" Then
        '    EjecutarAyuda()
        'End If
    End Sub

    'Public Sub EjecutarAyuda()
    '    Help.ShowHelp(Me.ParentForm, "RED.chm", archivoAyuda)
    'End Sub

    Protected Sub AgregarOpcion(ByVal asComando As String, ByVal asTexto As String)
        Me.AgregarOpcion(asComando, asTexto, Nothing)
    End Sub

    ''' <summary>
    ''' Permite Agregar una opcion a un ToolBar(ej. Me.AgregarOpcion("PlanillaPagos", "Planilla de Pagos", My.Resources.pro, True)) 
    ''' </summary>
    ''' <param name="asComando"></param>
    ''' <param name="asTexto"></param>
    ''' <param name="aiImagenIcono"></param>
    ''' <param name="abVerTexto"></param>
    ''' <remarks></remarks>
    Protected Sub AgregarOpcion(ByVal asComando As String, ByVal asTexto As String, ByVal aiImagenIcono As Image, Optional ByVal abVerTexto As Boolean = False)
        If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).AgregarOpcion(asComando, asTexto, aiImagenIcono, abVerTexto)
    End Sub

    Public archivoAyuda As String

    'Public Sub AgregarOpcionAyuda(ByVal asAccion As String)
    '    archivoAyuda = asAccion
    '    'Me.AgregarOpcion("Ayuda Dinámica", My.Resources.DB_reload, True)
    'End Sub

    Protected Sub DeshabilitarOpcion(ByVal asTexto As String)
        If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).DeshabilitarOpcion(asTexto)
    End Sub

    Protected Sub HabilitarOpcion(ByVal asTexto As String)
        If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).HabilitarOpcion(asTexto)
    End Sub

    Protected Sub HabilitarOpciones()
        If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).HabilitarOpciones()
    End Sub

    Protected Sub DeshabilitarOpciones()
        If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).DeshabilitarOpciones()
    End Sub

    'Protected Sub LimpiarOpciones()
    '    If Not Me.ParentForm Is Nothing Then CType(Me.ParentForm, frmBase).LimpiarOpciones()
    'End Sub


    Public ReadOnly Property usuarioActualizacion() As String
        Get
            Return "" 'EL.configuracion.usuarioActualizacion
        End Get
    End Property

    Public Sub SetToolStripStatus(ByVal aText As String, ByVal aWaitCursor As Boolean)
        'frmPrincipal.SetToolStripStatus(aText)
        If aWaitCursor Then
            Me.Cursor = Cursors.AppStarting
            Me.ParentForm.Cursor = Cursors.AppStarting
        Else
            Me.Cursor = Cursors.Arrow
            Me.ParentForm.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BackgroundWorker1
        '
        '
        'ucBaseWin
        '
        Me.Name = "ucBaseWin"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Sub numericTextboxKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tb As TextBox = CType(sender, TextBox)
        If IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(tb.Text & e.KeyChar)
        ElseIf e.KeyChar = "." Then
            If Not (tb.SelectedText = "." Or IsNumeric(tb.Text & e.KeyChar)) Then
                e.Handled = True
            End If
        ElseIf Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub AgregarValidacionTextBoxNumerico(ByVal aTextBox As TextBox)
        AddHandler aTextBox.KeyPress, AddressOf numericTextboxKeyPress
    End Sub

    Public Sub AgregarValidacionTextBoxNumerico(ByVal aTextBox As MaskedTextBox)
        AddHandler aTextBox.KeyPress, AddressOf numericMaskedTextboxKeyPress
    End Sub

    Protected Sub numericMaskedTextboxKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tb As MaskedTextBox = CType(sender, MaskedTextBox)
        If IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(tb.Text & e.KeyChar)
        ElseIf e.KeyChar = "." Then
            If Not (tb.SelectedText = "." Or IsNumeric(tb.Text & e.KeyChar)) Then
                e.Handled = True
            End If
        ElseIf Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Overridable Sub InicializarParaReporte()

    End Sub

    'Private _listaCriteriosReporte As New List(Of FISDL.EL.Criteria)
    'Public Property listaCriteriosReporte() As List(Of FISDL.EL.Criteria)
    '    Get
    '        Return _listaCriteriosReporte
    '    End Get
    '    Set(ByVal value As List(Of FISDL.EL.Criteria))
    '        _listaCriteriosReporte = value
    '    End Set
    'End Property

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim asComando As String = CType(e.Argument, String)
        Me.BackgroundWorker_DoWork(asComando, e)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.BackgroundWorker_RunWorkerCompleted(e)
    End Sub

    Public Overridable Sub BackgroundWorker_DoWork(ByVal asComando As String, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Public Overridable Sub BackgroundWorker_RunWorkerCompleted(ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)

    End Sub

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Public ReadOnly Property SubProcesoPrincipalActivo() As Boolean
        Get
            Return CType(My.Application.OpenForms(1), frmMain).BackgroundWorker1.IsBusy
        End Get
    End Property

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
End Class
