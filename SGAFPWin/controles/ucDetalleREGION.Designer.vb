<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleREGION
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
        Dim CODIGO_REGIONLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaREGIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_REGIONTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CODIGO_REGIONLabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaREGIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_REGIONLabel
        '
        CODIGO_REGIONLabel.Location = New System.Drawing.Point(6, 14)
        CODIGO_REGIONLabel.Name = "CODIGO_REGIONLabel"
        CODIGO_REGIONLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_REGIONLabel.TabIndex = 0
        CODIGO_REGIONLabel.Text = "Codigo region:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.Location = New System.Drawing.Point(6, 40)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(135, 13)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "Nombre:"
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
        'ListaREGIONBindingSource
        '
        Me.ListaREGIONBindingSource.DataSource = GetType(SGAFP.EL.REGION)
        '
        'CODIGO_REGIONTextBox
        '
        Me.CODIGO_REGIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_REGIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaREGIONBindingSource, "CODIGO_REGION", True))
        Me.CODIGO_REGIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CODIGO_REGIONTextBox.Name = "CODIGO_REGIONTextBox"
        Me.CODIGO_REGIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_REGIONTextBox.TabIndex = 1
        Me.CODIGO_REGIONTextBox.ReadOnly = True
        Me.CODIGO_REGIONTextBox.MaxLength = 2
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaREGIONBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRETextBox.TabIndex = 3
        Me.NOMBRETextBox.MaxLength = 20
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaREGIONBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 5
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaREGIONBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 7
        '
        'ucDetalleREGION
        '
        Me.AutoScroll = True
        Me.Controls.Add(CODIGO_REGIONLabel)
        Me.Controls.Add(Me.CODIGO_REGIONTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleREGION"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaREGIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaREGIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_REGIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
