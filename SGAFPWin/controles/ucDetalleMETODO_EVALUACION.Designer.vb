<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleMETODO_EVALUACION
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
        Dim ID_METODO_EVALUACIONLabel As System.Windows.Forms.Label
        Dim METODO_EVALUACIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaMETODO_EVALUACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_METODO_EVALUACIONTextBox = New System.Windows.Forms.TextBox
        Me.METODO_EVALUACIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_METODO_EVALUACIONLabel = New System.Windows.Forms.Label
        METODO_EVALUACIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaMETODO_EVALUACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_METODO_EVALUACIONLabel
        '
        ID_METODO_EVALUACIONLabel.Location = New System.Drawing.Point(6, 14)
        ID_METODO_EVALUACIONLabel.Name = "ID_METODO_EVALUACIONLabel"
        ID_METODO_EVALUACIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_METODO_EVALUACIONLabel.TabIndex = 0
        ID_METODO_EVALUACIONLabel.Text = "Id metodo evaluacion:"
        '
        'METODO_EVALUACIONLabel
        '
        METODO_EVALUACIONLabel.Location = New System.Drawing.Point(6, 40)
        METODO_EVALUACIONLabel.Name = "METODO_EVALUACIONLabel"
        METODO_EVALUACIONLabel.Size = New System.Drawing.Size(135, 13)
        METODO_EVALUACIONLabel.TabIndex = 2
        METODO_EVALUACIONLabel.Text = "Metodo evaluacion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 66)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 4
        NOTASLabel.Text = "Notas:"
        '
        'ListaMETODO_EVALUACIONBindingSource
        '
        Me.ListaMETODO_EVALUACIONBindingSource.DataSource = GetType(SGAFP.EL.METODO_EVALUACION)
        '
        'ID_METODO_EVALUACIONTextBox
        '
        Me.ID_METODO_EVALUACIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_METODO_EVALUACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMETODO_EVALUACIONBindingSource, "ID_METODO_EVALUACION", True))
        Me.ID_METODO_EVALUACIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_METODO_EVALUACIONTextBox.Name = "ID_METODO_EVALUACIONTextBox"
        Me.ID_METODO_EVALUACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_METODO_EVALUACIONTextBox.TabIndex = 1
        Me.ID_METODO_EVALUACIONTextBox.ReadOnly = True
        '
        'METODO_EVALUACIONTextBox
        '
        Me.METODO_EVALUACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMETODO_EVALUACIONBindingSource, "METODO_EVALUACION", True))
        Me.METODO_EVALUACIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.METODO_EVALUACIONTextBox.Name = "METODO_EVALUACIONTextBox"
        Me.METODO_EVALUACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.METODO_EVALUACIONTextBox.TabIndex = 3
        Me.METODO_EVALUACIONTextBox.MaxLength = 100
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMETODO_EVALUACIONBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 5
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleMETODO_EVALUACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_METODO_EVALUACIONLabel)
        Me.Controls.Add(Me.ID_METODO_EVALUACIONTextBox)
        Me.Controls.Add(METODO_EVALUACIONLabel)
        Me.Controls.Add(Me.METODO_EVALUACIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleMETODO_EVALUACION"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaMETODO_EVALUACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaMETODO_EVALUACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_METODO_EVALUACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents METODO_EVALUACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
