<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleTIPO_PERSONA
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
        Dim ID_TIPO_PERSONALabel As System.Windows.Forms.Label
        Dim TIPO_PERSONALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaTIPO_PERSONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_TIPO_PERSONATextBox = New System.Windows.Forms.TextBox
        Me.TIPO_PERSONATextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_TIPO_PERSONALabel = New System.Windows.Forms.Label
        TIPO_PERSONALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaTIPO_PERSONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_TIPO_PERSONALabel
        '
        ID_TIPO_PERSONALabel.Location = New System.Drawing.Point(6, 14)
        ID_TIPO_PERSONALabel.Name = "ID_TIPO_PERSONALabel"
        ID_TIPO_PERSONALabel.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_PERSONALabel.TabIndex = 0
        ID_TIPO_PERSONALabel.Text = "Id tipo persona:"
        '
        'TIPO_PERSONALabel
        '
        TIPO_PERSONALabel.Location = New System.Drawing.Point(6, 40)
        TIPO_PERSONALabel.Name = "TIPO_PERSONALabel"
        TIPO_PERSONALabel.Size = New System.Drawing.Size(135, 13)
        TIPO_PERSONALabel.TabIndex = 2
        TIPO_PERSONALabel.Text = "Tipo persona:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 66)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 4
        NOTASLabel.Text = "Notas:"
        '
        'ListaTIPO_PERSONABindingSource
        '
        Me.ListaTIPO_PERSONABindingSource.DataSource = GetType(SGAFP.EL.TIPO_PERSONA)
        '
        'ID_TIPO_PERSONATextBox
        '
        Me.ID_TIPO_PERSONATextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_TIPO_PERSONATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_PERSONABindingSource, "ID_TIPO_PERSONA", True))
        Me.ID_TIPO_PERSONATextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_TIPO_PERSONATextBox.Name = "ID_TIPO_PERSONATextBox"
        Me.ID_TIPO_PERSONATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_PERSONATextBox.TabIndex = 1
        Me.ID_TIPO_PERSONATextBox.ReadOnly = True
        '
        'TIPO_PERSONATextBox
        '
        Me.TIPO_PERSONATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_PERSONABindingSource, "TIPO_PERSONA", True))
        Me.TIPO_PERSONATextBox.Location = New System.Drawing.Point(144, 34)
        Me.TIPO_PERSONATextBox.Name = "TIPO_PERSONATextBox"
        Me.TIPO_PERSONATextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_PERSONATextBox.TabIndex = 3
        Me.TIPO_PERSONATextBox.MaxLength = 40
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_PERSONABindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 5
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleTIPO_PERSONA
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_TIPO_PERSONALabel)
        Me.Controls.Add(Me.ID_TIPO_PERSONATextBox)
        Me.Controls.Add(TIPO_PERSONALabel)
        Me.Controls.Add(Me.TIPO_PERSONATextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleTIPO_PERSONA"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaTIPO_PERSONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_PERSONABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_TIPO_PERSONATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_PERSONATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
