<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCIUO
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
        Dim CIUOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim DESCRIPCION_NACIONALLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaCIUOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIUOTextBox = New System.Windows.Forms.TextBox
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox
        Me.DESCRIPCION_NACIONALTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CIUOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        DESCRIPCION_NACIONALLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaCIUOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CIUOLabel
        '
        CIUOLabel.Location = New System.Drawing.Point(6, 14)
        CIUOLabel.Name = "CIUOLabel"
        CIUOLabel.Size = New System.Drawing.Size(135, 13)
        CIUOLabel.TabIndex = 0
        CIUOLabel.Text = "Ciuo:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.Location = New System.Drawing.Point(6, 40)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(135, 13)
        DESCRIPCIONLabel.TabIndex = 2
        DESCRIPCIONLabel.Text = "Descripcion:"
        '
        'DESCRIPCION_NACIONALLabel
        '
        DESCRIPCION_NACIONALLabel.Location = New System.Drawing.Point(6, 66)
        DESCRIPCION_NACIONALLabel.Name = "DESCRIPCION_NACIONALLabel"
        DESCRIPCION_NACIONALLabel.Size = New System.Drawing.Size(135, 13)
        DESCRIPCION_NACIONALLabel.TabIndex = 4
        DESCRIPCION_NACIONALLabel.Text = "Descripcion nacional:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 92)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 6
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 118)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 8
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaCIUOBindingSource
        '
        Me.ListaCIUOBindingSource.DataSource = GetType(SGAFP.EL.CIUO)
        '
        'CIUOTextBox
        '
        Me.CIUOTextBox.BackColor = System.Drawing.Color.Linen
        Me.CIUOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUOBindingSource, "CIUO", True))
        Me.CIUOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CIUOTextBox.Name = "CIUOTextBox"
        Me.CIUOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CIUOTextBox.TabIndex = 1
        Me.CIUOTextBox.ReadOnly = True
        Me.CIUOTextBox.MaxLength = 14
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUOBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCIONTextBox.TabIndex = 3
        Me.DESCRIPCIONTextBox.MaxLength = 200
        '
        'DESCRIPCION_NACIONALTextBox
        '
        Me.DESCRIPCION_NACIONALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUOBindingSource, "DESCRIPCION_NACIONAL", True))
        Me.DESCRIPCION_NACIONALTextBox.Location = New System.Drawing.Point(144, 60)
        Me.DESCRIPCION_NACIONALTextBox.Name = "DESCRIPCION_NACIONALTextBox"
        Me.DESCRIPCION_NACIONALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCION_NACIONALTextBox.TabIndex = 5
        Me.DESCRIPCION_NACIONALTextBox.MaxLength = 200
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUOBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 86)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 7
        Me.USERIDTextBox.MaxLength = 14
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCIUOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 112)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 9
        '
        'ucDetalleCIUO
        '
        Me.AutoScroll = True
        Me.Controls.Add(CIUOLabel)
        Me.Controls.Add(Me.CIUOTextBox)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.Controls.Add(DESCRIPCION_NACIONALLabel)
        Me.Controls.Add(Me.DESCRIPCION_NACIONALTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleCIUO"
        Me.Size = New System.Drawing.Size(382, 164)
        CType(Me.ListaCIUOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCIUOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCION_NACIONALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
