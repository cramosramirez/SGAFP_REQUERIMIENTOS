<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaOPCION_MENU
    Inherits SGAFP.ucBaseLista

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ListaOPCION_MENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaOPCION_MENUDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_OPCION_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOPCION_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOPCION_SISTEMA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxURL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPAGINA_HTML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOBJETO_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaOPCION_MENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOPCION_MENUDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaOPCION_MENUBindingSource
        '
        Me.ListaOPCION_MENUBindingSource.DataSource = GetType(SGAFP.EL.OPCION_MENU)
        '
        'ListaOPCION_MENUDataGridView
        '
        Me.ListaOPCION_MENUDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaOPCION_MENUDataGridView.AutoGenerateColumns = False
        Me.ListaOPCION_MENUDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_OPCION_MENU, Me.DataGridViewTextBoxOPCION_MENU, Me.DataGridViewTextBoxOPCION_SISTEMA, Me.DataGridViewTextBoxURL, Me.DataGridViewTextBoxPAGINA_HTML, Me.DataGridViewTextBoxOBJETO_USUARIO, Me.DataGridViewTextBoxNOTAS})
        Me.ListaOPCION_MENUDataGridView.DataSource = Me.ListaOPCION_MENUBindingSource
        Me.ListaOPCION_MENUDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaOPCION_MENUDataGridView.Name = "ListaOPCION_MENUDataGridView"
        Me.ListaOPCION_MENUDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaOPCION_MENUDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_OPCION_MENU
        '
        Me.DataGridViewTextBoxID_OPCION_MENU.DataPropertyName = "ID_OPCION_MENU"
        Me.DataGridViewTextBoxID_OPCION_MENU.HeaderText = "Id opcion menu"
        Me.DataGridViewTextBoxID_OPCION_MENU.Name = "DataGridViewTextBoxID_OPCION_MENU"
        '
        'DataGridViewTextBoxOPCION_MENU
        '
        Me.DataGridViewTextBoxOPCION_MENU.DataPropertyName = "OPCION_MENU"
        Me.DataGridViewTextBoxOPCION_MENU.HeaderText = "Opcion menu"
        Me.DataGridViewTextBoxOPCION_MENU.Name = "DataGridViewTextBoxOPCION_MENU"
        '
        'DataGridViewTextBoxOPCION_SISTEMA
        '
        Me.DataGridViewTextBoxOPCION_SISTEMA.DataPropertyName = "OPCION_SISTEMA"
        Me.DataGridViewTextBoxOPCION_SISTEMA.HeaderText = "Opcion sistema"
        Me.DataGridViewTextBoxOPCION_SISTEMA.Name = "DataGridViewTextBoxOPCION_SISTEMA"
        '
        'DataGridViewTextBoxURL
        '
        Me.DataGridViewTextBoxURL.DataPropertyName = "URL"
        Me.DataGridViewTextBoxURL.HeaderText = "Url"
        Me.DataGridViewTextBoxURL.Name = "DataGridViewTextBoxURL"
        '
        'DataGridViewTextBoxPAGINA_HTML
        '
        Me.DataGridViewTextBoxPAGINA_HTML.DataPropertyName = "PAGINA_HTML"
        Me.DataGridViewTextBoxPAGINA_HTML.HeaderText = "Pagina html"
        Me.DataGridViewTextBoxPAGINA_HTML.Name = "DataGridViewTextBoxPAGINA_HTML"
        '
        'DataGridViewTextBoxOBJETO_USUARIO
        '
        Me.DataGridViewTextBoxOBJETO_USUARIO.DataPropertyName = "OBJETO_USUARIO"
        Me.DataGridViewTextBoxOBJETO_USUARIO.HeaderText = "Objeto usuario"
        Me.DataGridViewTextBoxOBJETO_USUARIO.Name = "DataGridViewTextBoxOBJETO_USUARIO"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaOPCION_MENU
        '
        Me.Controls.Add(Me.ListaOPCION_MENUDataGridView)
        Me.Name = "ucListaOPCION_MENU"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaOPCION_MENUDataGridView, 0)
        CType(Me.ListaOPCION_MENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOPCION_MENUDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOPCION_MENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaOPCION_MENUDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_OPCION_MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOPCION_MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOPCION_SISTEMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxURL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPAGINA_HTML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOBJETO_USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
