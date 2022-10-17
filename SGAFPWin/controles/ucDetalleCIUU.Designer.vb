<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCIUU
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
        Dim CIUULabel As System.Windows.Forms.Label
        Dim DESCRIPCION_CIIULabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaCIUUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CIUUTextBox = New System.Windows.Forms.TextBox
        Me.DESCRIPCION_CIIUTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CIUULabel = New System.Windows.Forms.Label
        DESCRIPCION_CIIULabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaCIUUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CIUULabel
        '
        CIUULabel.Location = New System.Drawing.Point(6, 14)
        CIUULabel.Name = "CIUULabel"
        CIUULabel.Size = New System.Drawing.Size(135, 13)
        CIUULabel.TabIndex = 0
        CIUULabel.Text = "Ciuu:"
        '
        'DESCRIPCION_CIIULabel
        '
        DESCRIPCION_CIIULabel.Location = New System.Drawing.Point(6, 40)
        DESCRIPCION_CIIULabel.Name = "DESCRIPCION_CIIULabel"
        DESCRIPCION_CIIULabel.Size = New System.Drawing.Size(135, 13)
        DESCRIPCION_CIIULabel.TabIndex = 2
        DESCRIPCION_CIIULabel.Text = "Descripcion ciiu:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 66)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 4
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 92)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 6
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaCIUUBindingSource
        '
        Me.ListaCIUUBindingSource.DataSource = GetType(SGAFP.EL.CIUU)
        '
        'CIUUTextBox
        '
        Me.CIUUTextBox.BackColor = System.Drawing.Color.Linen
        Me.CIUUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUUBindingSource, "CIUU", True))
        Me.CIUUTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CIUUTextBox.Name = "CIUUTextBox"
        Me.CIUUTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CIUUTextBox.TabIndex = 1
        Me.CIUUTextBox.ReadOnly = True
        Me.CIUUTextBox.MaxLength = 14
        '
        'DESCRIPCION_CIIUTextBox
        '
        Me.DESCRIPCION_CIIUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUUBindingSource, "DESCRIPCION_CIIU", True))
        Me.DESCRIPCION_CIIUTextBox.Location = New System.Drawing.Point(144, 34)
        Me.DESCRIPCION_CIIUTextBox.Name = "DESCRIPCION_CIIUTextBox"
        Me.DESCRIPCION_CIIUTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCION_CIIUTextBox.TabIndex = 3
        Me.DESCRIPCION_CIIUTextBox.MaxLength = 250
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaCIUUBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 5
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaCIUUBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 7
        '
        'ucDetalleCIUU
        '
        Me.AutoScroll = True
        Me.Controls.Add(CIUULabel)
        Me.Controls.Add(Me.CIUUTextBox)
        Me.Controls.Add(DESCRIPCION_CIIULabel)
        Me.Controls.Add(Me.DESCRIPCION_CIIUTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleCIUU"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaCIUUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCIUUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCION_CIIUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
