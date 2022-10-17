<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleNIVEL_ACADEMICO
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
        Dim NIVEL_ACADEMICOLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaNIVEL_ACADEMICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NIVEL_ACADEMICOTextBox = New System.Windows.Forms.TextBox
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        NIVEL_ACADEMICOLabel = New System.Windows.Forms.Label
        DESCRIPCIONLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIVEL_ACADEMICOLabel
        '
        NIVEL_ACADEMICOLabel.Location = New System.Drawing.Point(6, 14)
        NIVEL_ACADEMICOLabel.Name = "NIVEL_ACADEMICOLabel"
        NIVEL_ACADEMICOLabel.Size = New System.Drawing.Size(135, 13)
        NIVEL_ACADEMICOLabel.TabIndex = 0
        NIVEL_ACADEMICOLabel.Text = "Nivel academico:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.Location = New System.Drawing.Point(6, 40)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(135, 13)
        DESCRIPCIONLabel.TabIndex = 2
        DESCRIPCIONLabel.Text = "Descripcion:"
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
        'ListaNIVEL_ACADEMICOBindingSource
        '
        Me.ListaNIVEL_ACADEMICOBindingSource.DataSource = GetType(SGAFP.EL.NIVEL_ACADEMICO)
        '
        'NIVEL_ACADEMICOTextBox
        '
        Me.NIVEL_ACADEMICOTextBox.BackColor = System.Drawing.Color.Linen
        Me.NIVEL_ACADEMICOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaNIVEL_ACADEMICOBindingSource, "NIVEL_ACADEMICO", True))
        Me.NIVEL_ACADEMICOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.NIVEL_ACADEMICOTextBox.Name = "NIVEL_ACADEMICOTextBox"
        Me.NIVEL_ACADEMICOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIVEL_ACADEMICOTextBox.TabIndex = 1
        Me.NIVEL_ACADEMICOTextBox.ReadOnly = True
        Me.NIVEL_ACADEMICOTextBox.MaxLength = 5
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaNIVEL_ACADEMICOBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCIONTextBox.TabIndex = 3
        Me.DESCRIPCIONTextBox.MaxLength = 50
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaNIVEL_ACADEMICOBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 5
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaNIVEL_ACADEMICOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 7
        '
        'ucDetalleNIVEL_ACADEMICO
        '
        Me.AutoScroll = True
        Me.Controls.Add(NIVEL_ACADEMICOLabel)
        Me.Controls.Add(Me.NIVEL_ACADEMICOTextBox)
        Me.Controls.Add(DESCRIPCIONLabel)
        Me.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleNIVEL_ACADEMICO"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaNIVEL_ACADEMICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NIVEL_ACADEMICOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
