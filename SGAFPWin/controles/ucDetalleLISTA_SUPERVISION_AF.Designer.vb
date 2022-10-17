<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleLISTA_SUPERVISION_AF
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
        Dim ID_LISTA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim LISTA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaLISTA_SUPERVISION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_LISTA_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.LISTA_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_LISTA_SUPERVISIONLabel = New System.Windows.Forms.Label
        LISTA_SUPERVISIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaLISTA_SUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LISTA_SUPERVISIONLabel
        '
        ID_LISTA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 14)
        ID_LISTA_SUPERVISIONLabel.Name = "ID_LISTA_SUPERVISIONLabel"
        ID_LISTA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_LISTA_SUPERVISIONLabel.TabIndex = 0
        ID_LISTA_SUPERVISIONLabel.Text = "Id lista supervision:"
        '
        'LISTA_SUPERVISIONLabel
        '
        LISTA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 40)
        LISTA_SUPERVISIONLabel.Name = "LISTA_SUPERVISIONLabel"
        LISTA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        LISTA_SUPERVISIONLabel.TabIndex = 2
        LISTA_SUPERVISIONLabel.Text = "Lista supervision:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 66)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 4
        NOTASLabel.Text = "Notas:"
        '
        'ListaLISTA_SUPERVISION_AFBindingSource
        '
        Me.ListaLISTA_SUPERVISION_AFBindingSource.DataSource = GetType(SGAFP.EL.LISTA_SUPERVISION_AF)
        '
        'ID_LISTA_SUPERVISIONTextBox
        '
        Me.ID_LISTA_SUPERVISIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_LISTA_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaLISTA_SUPERVISION_AFBindingSource, "ID_LISTA_SUPERVISION", True))
        Me.ID_LISTA_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_LISTA_SUPERVISIONTextBox.Name = "ID_LISTA_SUPERVISIONTextBox"
        Me.ID_LISTA_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_LISTA_SUPERVISIONTextBox.TabIndex = 1
        Me.ID_LISTA_SUPERVISIONTextBox.ReadOnly = True
        '
        'LISTA_SUPERVISIONTextBox
        '
        Me.LISTA_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaLISTA_SUPERVISION_AFBindingSource, "LISTA_SUPERVISION", True))
        Me.LISTA_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.LISTA_SUPERVISIONTextBox.Name = "LISTA_SUPERVISIONTextBox"
        Me.LISTA_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LISTA_SUPERVISIONTextBox.TabIndex = 3
        Me.LISTA_SUPERVISIONTextBox.MaxLength = 100
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaLISTA_SUPERVISION_AFBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 5
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleLISTA_SUPERVISION_AF
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_LISTA_SUPERVISIONLabel)
        Me.Controls.Add(Me.ID_LISTA_SUPERVISIONTextBox)
        Me.Controls.Add(LISTA_SUPERVISIONLabel)
        Me.Controls.Add(Me.LISTA_SUPERVISIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleLISTA_SUPERVISION_AF"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaLISTA_SUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaLISTA_SUPERVISION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_LISTA_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LISTA_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
