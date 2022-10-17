<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleESTADO_SOLICITUD
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
        Dim ID_ESTADO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim ESTADO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaESTADO_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ESTADO_SOLICITUDTextBox = New System.Windows.Forms.TextBox
        Me.ESTADO_SOLICITUDTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_ESTADO_SOLICITUDLabel = New System.Windows.Forms.Label
        ESTADO_SOLICITUDLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaESTADO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ESTADO_SOLICITUDLabel
        '
        ID_ESTADO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 14)
        ID_ESTADO_SOLICITUDLabel.Name = "ID_ESTADO_SOLICITUDLabel"
        ID_ESTADO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_ESTADO_SOLICITUDLabel.TabIndex = 0
        ID_ESTADO_SOLICITUDLabel.Text = "Id estado solicitud:"
        '
        'ESTADO_SOLICITUDLabel
        '
        ESTADO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 40)
        ESTADO_SOLICITUDLabel.Name = "ESTADO_SOLICITUDLabel"
        ESTADO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ESTADO_SOLICITUDLabel.TabIndex = 2
        ESTADO_SOLICITUDLabel.Text = "Estado solicitud:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 66)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 4
        NOTASLabel.Text = "Notas:"
        '
        'ListaESTADO_SOLICITUDBindingSource
        '
        Me.ListaESTADO_SOLICITUDBindingSource.DataSource = GetType(SGAFP.EL.ESTADO_SOLICITUD)
        '
        'ID_ESTADO_SOLICITUDTextBox
        '
        Me.ID_ESTADO_SOLICITUDTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_ESTADO_SOLICITUDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_SOLICITUDBindingSource, "ID_ESTADO_SOLICITUD", True))
        Me.ID_ESTADO_SOLICITUDTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_ESTADO_SOLICITUDTextBox.Name = "ID_ESTADO_SOLICITUDTextBox"
        Me.ID_ESTADO_SOLICITUDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_ESTADO_SOLICITUDTextBox.TabIndex = 1
        Me.ID_ESTADO_SOLICITUDTextBox.ReadOnly = True
        '
        'ESTADO_SOLICITUDTextBox
        '
        Me.ESTADO_SOLICITUDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_SOLICITUDBindingSource, "ESTADO_SOLICITUD", True))
        Me.ESTADO_SOLICITUDTextBox.Location = New System.Drawing.Point(144, 34)
        Me.ESTADO_SOLICITUDTextBox.Name = "ESTADO_SOLICITUDTextBox"
        Me.ESTADO_SOLICITUDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADO_SOLICITUDTextBox.TabIndex = 3
        Me.ESTADO_SOLICITUDTextBox.MaxLength = 60
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaESTADO_SOLICITUDBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 5
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleESTADO_SOLICITUD
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_ESTADO_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_ESTADO_SOLICITUDTextBox)
        Me.Controls.Add(ESTADO_SOLICITUDLabel)
        Me.Controls.Add(Me.ESTADO_SOLICITUDTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleESTADO_SOLICITUD"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaESTADO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaESTADO_SOLICITUDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_ESTADO_SOLICITUDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADO_SOLICITUDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
