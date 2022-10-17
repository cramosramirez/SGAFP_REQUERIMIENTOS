<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleMUNICIPIO
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
        Dim CODIGO_MUNICIPIOLabel As System.Windows.Forms.Label
        Dim CODIGO_REGIONLabel As System.Windows.Forms.Label
        Dim CODIGO_DEPARTAMENTOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaMUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_MUNICIPIOTextBox = New System.Windows.Forms.TextBox
        Me.CODIGO_REGIONcbxREGION = New SGAFP.WinUC.cbxREGION
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO = New SGAFP.WinUC.cbxDEPARTAMENTO
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CODIGO_MUNICIPIOLabel = New System.Windows.Forms.Label
        CODIGO_REGIONLabel = New System.Windows.Forms.Label
        CODIGO_DEPARTAMENTOLabel = New System.Windows.Forms.Label
        NOMBRELabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaMUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_MUNICIPIOLabel
        '
        CODIGO_MUNICIPIOLabel.Location = New System.Drawing.Point(6, 14)
        CODIGO_MUNICIPIOLabel.Name = "CODIGO_MUNICIPIOLabel"
        CODIGO_MUNICIPIOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_MUNICIPIOLabel.TabIndex = 0
        CODIGO_MUNICIPIOLabel.Text = "Codigo municipio:"
        '
        'CODIGO_REGIONLabel
        '
        CODIGO_REGIONLabel.Location = New System.Drawing.Point(6, 40)
        CODIGO_REGIONLabel.Name = "CODIGO_REGIONLabel"
        CODIGO_REGIONLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_REGIONLabel.TabIndex = 2
        CODIGO_REGIONLabel.Text = "Codigo region:"
        '
        'CODIGO_DEPARTAMENTOLabel
        '
        CODIGO_DEPARTAMENTOLabel.Location = New System.Drawing.Point(6, 66)
        CODIGO_DEPARTAMENTOLabel.Name = "CODIGO_DEPARTAMENTOLabel"
        CODIGO_DEPARTAMENTOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_DEPARTAMENTOLabel.TabIndex = 4
        CODIGO_DEPARTAMENTOLabel.Text = "Codigo departamento:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.Location = New System.Drawing.Point(6, 92)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(135, 13)
        NOMBRELabel.TabIndex = 6
        NOMBRELabel.Text = "Nombre:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 118)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 8
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 144)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 10
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaMUNICIPIOBindingSource
        '
        Me.ListaMUNICIPIOBindingSource.DataSource = GetType(SGAFP.EL.MUNICIPIO)
        '
        'CODIGO_MUNICIPIOTextBox
        '
        Me.CODIGO_MUNICIPIOTextBox.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_MUNICIPIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMUNICIPIOBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CODIGO_MUNICIPIOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CODIGO_MUNICIPIOTextBox.Name = "CODIGO_MUNICIPIOTextBox"
        Me.CODIGO_MUNICIPIOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_MUNICIPIOTextBox.TabIndex = 1
        Me.CODIGO_MUNICIPIOTextBox.ReadOnly = True
        Me.CODIGO_MUNICIPIOTextBox.MaxLength = 2
        '
        'CODIGO_REGIONcbxREGION
        '
        Me.CODIGO_REGIONcbxREGION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaMUNICIPIOBindingSource, "CODIGO_REGION", True))
        Me.CODIGO_REGIONcbxREGION.Location = New System.Drawing.Point(144, 34)
        Me.CODIGO_REGIONcbxREGION.Name = "CODIGO_REGIONcbxREGION"
        Me.CODIGO_REGIONcbxREGION.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_REGIONcbxREGION.TabIndex = 3
        Me.CODIGO_REGIONcbxREGION.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_REGIONcbxREGION.Enabled = False
        '
        'CODIGO_DEPARTAMENTOcbxDEPARTAMENTO
        '
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaMUNICIPIOBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Location = New System.Drawing.Point(144, 60)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Name = "CODIGO_DEPARTAMENTOcbxDEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.TabIndex = 5
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = False
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMUNICIPIOBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(144, 86)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRETextBox.TabIndex = 7
        Me.NOMBRETextBox.MaxLength = 60
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaMUNICIPIOBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 112)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 9
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaMUNICIPIOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 138)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 11
        '
        'ucDetalleMUNICIPIO
        '
        Me.AutoScroll = True
        Me.Controls.Add(CODIGO_MUNICIPIOLabel)
        Me.Controls.Add(Me.CODIGO_MUNICIPIOTextBox)
        Me.Controls.Add(CODIGO_REGIONLabel)
        Me.Controls.Add(Me.CODIGO_REGIONcbxREGION)
        Me.Controls.Add(CODIGO_DEPARTAMENTOLabel)
        Me.Controls.Add(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleMUNICIPIO"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaMUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaMUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_MUNICIPIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_REGIONcbxREGION As SGAFP.WinUC.cbxREGION
    Friend WithEvents CODIGO_DEPARTAMENTOcbxDEPARTAMENTO As SGAFP.WinUC.cbxDEPARTAMENTO
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
