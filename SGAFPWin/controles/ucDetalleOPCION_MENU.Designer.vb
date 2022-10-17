<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleOPCION_MENU
    Inherits SGAFP.ucBaseDetalleMant

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
        Dim ID_OPCION_MENULabel As System.Windows.Forms.Label
        Dim OPCION_MENULabel As System.Windows.Forms.Label
        Dim OPCION_SISTEMALabel As System.Windows.Forms.Label
        Dim URLLabel As System.Windows.Forms.Label
        Dim PAGINA_HTMLLabel As System.Windows.Forms.Label
        Dim OBJETO_USUARIOLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaOPCION_MENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_OPCION_MENUTextBox = New System.Windows.Forms.TextBox
        Me.OPCION_MENUTextBox = New System.Windows.Forms.TextBox
        Me.OPCION_SISTEMATextBox = New System.Windows.Forms.TextBox
        Me.URLTextBox = New System.Windows.Forms.TextBox
        Me.PAGINA_HTMLTextBox = New System.Windows.Forms.TextBox
        Me.OBJETO_USUARIOTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_OPCION_MENULabel = New System.Windows.Forms.Label
        OPCION_MENULabel = New System.Windows.Forms.Label
        OPCION_SISTEMALabel = New System.Windows.Forms.Label
        URLLabel = New System.Windows.Forms.Label
        PAGINA_HTMLLabel = New System.Windows.Forms.Label
        OBJETO_USUARIOLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaOPCION_MENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_OPCION_MENULabel
        '
        ID_OPCION_MENULabel.Location = New System.Drawing.Point(6, 14)
        ID_OPCION_MENULabel.Name = "ID_OPCION_MENULabel"
        ID_OPCION_MENULabel.Size = New System.Drawing.Size(135, 13)
        ID_OPCION_MENULabel.TabIndex = 0
        ID_OPCION_MENULabel.Text = "Id opcion menu:"
        '
        'OPCION_MENULabel
        '
        OPCION_MENULabel.Location = New System.Drawing.Point(6, 40)
        OPCION_MENULabel.Name = "OPCION_MENULabel"
        OPCION_MENULabel.Size = New System.Drawing.Size(135, 13)
        OPCION_MENULabel.TabIndex = 2
        OPCION_MENULabel.Text = "Opcion menu:"
        '
        'OPCION_SISTEMALabel
        '
        OPCION_SISTEMALabel.Location = New System.Drawing.Point(6, 66)
        OPCION_SISTEMALabel.Name = "OPCION_SISTEMALabel"
        OPCION_SISTEMALabel.Size = New System.Drawing.Size(135, 13)
        OPCION_SISTEMALabel.TabIndex = 4
        OPCION_SISTEMALabel.Text = "Opcion sistema:"
        '
        'URLLabel
        '
        URLLabel.Location = New System.Drawing.Point(6, 92)
        URLLabel.Name = "URLLabel"
        URLLabel.Size = New System.Drawing.Size(135, 13)
        URLLabel.TabIndex = 6
        URLLabel.Text = "Url:"
        '
        'PAGINA_HTMLLabel
        '
        PAGINA_HTMLLabel.Location = New System.Drawing.Point(6, 118)
        PAGINA_HTMLLabel.Name = "PAGINA_HTMLLabel"
        PAGINA_HTMLLabel.Size = New System.Drawing.Size(135, 13)
        PAGINA_HTMLLabel.TabIndex = 8
        PAGINA_HTMLLabel.Text = "Pagina html:"
        '
        'OBJETO_USUARIOLabel
        '
        OBJETO_USUARIOLabel.Location = New System.Drawing.Point(6, 144)
        OBJETO_USUARIOLabel.Name = "OBJETO_USUARIOLabel"
        OBJETO_USUARIOLabel.Size = New System.Drawing.Size(135, 13)
        OBJETO_USUARIOLabel.TabIndex = 10
        OBJETO_USUARIOLabel.Text = "Objeto usuario:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 170)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 12
        NOTASLabel.Text = "Notas:"
        '
        'ListaOPCION_MENUBindingSource
        '
        Me.ListaOPCION_MENUBindingSource.DataSource = GetType(SGAFP.EL.OPCION_MENU)
        '
        'ID_OPCION_MENUTextBox
        '
        Me.ID_OPCION_MENUTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_OPCION_MENUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "ID_OPCION_MENU", True))
        Me.ID_OPCION_MENUTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_OPCION_MENUTextBox.Name = "ID_OPCION_MENUTextBox"
        Me.ID_OPCION_MENUTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_OPCION_MENUTextBox.TabIndex = 1
        Me.ID_OPCION_MENUTextBox.ReadOnly = True
        '
        'OPCION_MENUTextBox
        '
        Me.OPCION_MENUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "OPCION_MENU", True))
        Me.OPCION_MENUTextBox.Location = New System.Drawing.Point(144, 34)
        Me.OPCION_MENUTextBox.Name = "OPCION_MENUTextBox"
        Me.OPCION_MENUTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OPCION_MENUTextBox.TabIndex = 3
        Me.OPCION_MENUTextBox.MaxLength = 60
        '
        'OPCION_SISTEMATextBox
        '
        Me.OPCION_SISTEMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "OPCION_SISTEMA", True))
        Me.OPCION_SISTEMATextBox.Location = New System.Drawing.Point(144, 60)
        Me.OPCION_SISTEMATextBox.Name = "OPCION_SISTEMATextBox"
        Me.OPCION_SISTEMATextBox.Size = New System.Drawing.Size(200, 20)
        Me.OPCION_SISTEMATextBox.TabIndex = 5
        Me.OPCION_SISTEMATextBox.MaxLength = 1
        '
        'URLTextBox
        '
        Me.URLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "URL", True))
        Me.URLTextBox.Location = New System.Drawing.Point(144, 86)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(200, 20)
        Me.URLTextBox.TabIndex = 7
        Me.URLTextBox.MaxLength = 200
        '
        'PAGINA_HTMLTextBox
        '
        Me.PAGINA_HTMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "PAGINA_HTML", True))
        Me.PAGINA_HTMLTextBox.Location = New System.Drawing.Point(144, 112)
        Me.PAGINA_HTMLTextBox.Name = "PAGINA_HTMLTextBox"
        Me.PAGINA_HTMLTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PAGINA_HTMLTextBox.TabIndex = 9
        Me.PAGINA_HTMLTextBox.MaxLength = 200
        '
        'OBJETO_USUARIOTextBox
        '
        Me.OBJETO_USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "OBJETO_USUARIO", True))
        Me.OBJETO_USUARIOTextBox.Location = New System.Drawing.Point(144, 138)
        Me.OBJETO_USUARIOTextBox.Name = "OBJETO_USUARIOTextBox"
        Me.OBJETO_USUARIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OBJETO_USUARIOTextBox.TabIndex = 11
        Me.OBJETO_USUARIOTextBox.MaxLength = 200
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaOPCION_MENUBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 164)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 13
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleOPCION_MENU
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_OPCION_MENULabel)
        Me.Controls.Add(Me.ID_OPCION_MENUTextBox)
        Me.Controls.Add(OPCION_MENULabel)
        Me.Controls.Add(Me.OPCION_MENUTextBox)
        Me.Controls.Add(OPCION_SISTEMALabel)
        Me.Controls.Add(Me.OPCION_SISTEMATextBox)
        Me.Controls.Add(URLLabel)
        Me.Controls.Add(Me.URLTextBox)
        Me.Controls.Add(PAGINA_HTMLLabel)
        Me.Controls.Add(Me.PAGINA_HTMLTextBox)
        Me.Controls.Add(OBJETO_USUARIOLabel)
        Me.Controls.Add(Me.OBJETO_USUARIOTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleOPCION_MENU"
        Me.Size = New System.Drawing.Size(382, 216)
        CType(Me.ListaOPCION_MENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOPCION_MENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_OPCION_MENUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OPCION_MENUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OPCION_SISTEMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents URLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAGINA_HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBJETO_USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
