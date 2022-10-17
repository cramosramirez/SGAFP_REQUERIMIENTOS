<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleTIPO_SOLICITUD
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
        Dim ID_TIPO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim CODIGO_PROCESOLabel As System.Windows.Forms.Label
        Dim TIPO_SOLICITUDLabel As System.Windows.Forms.Label
        Dim TABLA_RELACIONALLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaTIPO_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_TIPO_SOLICITUDTextBox = New System.Windows.Forms.TextBox
        Me.CODIGO_PROCESOcbxPROCESO = New SGAFP.WinUC.cbxPROCESO
        Me.TIPO_SOLICITUDTextBox = New System.Windows.Forms.TextBox
        Me.TABLA_RELACIONALTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        ID_TIPO_SOLICITUDLabel = New System.Windows.Forms.Label
        CODIGO_PROCESOLabel = New System.Windows.Forms.Label
        TIPO_SOLICITUDLabel = New System.Windows.Forms.Label
        TABLA_RELACIONALLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaTIPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_TIPO_SOLICITUDLabel
        '
        ID_TIPO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 14)
        ID_TIPO_SOLICITUDLabel.Name = "ID_TIPO_SOLICITUDLabel"
        ID_TIPO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_SOLICITUDLabel.TabIndex = 0
        ID_TIPO_SOLICITUDLabel.Text = "Id tipo solicitud:"
        '
        'CODIGO_PROCESOLabel
        '
        CODIGO_PROCESOLabel.Location = New System.Drawing.Point(6, 40)
        CODIGO_PROCESOLabel.Name = "CODIGO_PROCESOLabel"
        CODIGO_PROCESOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_PROCESOLabel.TabIndex = 2
        CODIGO_PROCESOLabel.Text = "Codigo proceso:"
        '
        'TIPO_SOLICITUDLabel
        '
        TIPO_SOLICITUDLabel.Location = New System.Drawing.Point(6, 66)
        TIPO_SOLICITUDLabel.Name = "TIPO_SOLICITUDLabel"
        TIPO_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        TIPO_SOLICITUDLabel.TabIndex = 4
        TIPO_SOLICITUDLabel.Text = "Tipo solicitud:"
        '
        'TABLA_RELACIONALLabel
        '
        TABLA_RELACIONALLabel.Location = New System.Drawing.Point(6, 92)
        TABLA_RELACIONALLabel.Name = "TABLA_RELACIONALLabel"
        TABLA_RELACIONALLabel.Size = New System.Drawing.Size(135, 13)
        TABLA_RELACIONALLabel.TabIndex = 6
        TABLA_RELACIONALLabel.Text = "Tabla relacional:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 118)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 8
        NOTASLabel.Text = "Notas:"
        '
        'USERIDLabel
        '
        USERIDLabel.Location = New System.Drawing.Point(6, 144)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(135, 13)
        USERIDLabel.TabIndex = 10
        USERIDLabel.Text = "Userid:"
        '
        'LASTUPDATELabel
        '
        LASTUPDATELabel.Location = New System.Drawing.Point(6, 170)
        LASTUPDATELabel.Name = "LASTUPDATELabel"
        LASTUPDATELabel.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabel.TabIndex = 12
        LASTUPDATELabel.Text = "Lastupdate:"
        '
        'ListaTIPO_SOLICITUDBindingSource
        '
        Me.ListaTIPO_SOLICITUDBindingSource.DataSource = GetType(SGAFP.EL.TIPO_SOLICITUD)
        '
        'ID_TIPO_SOLICITUDTextBox
        '
        Me.ID_TIPO_SOLICITUDTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_TIPO_SOLICITUDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_SOLICITUDBindingSource, "ID_TIPO_SOLICITUD", True))
        Me.ID_TIPO_SOLICITUDTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_TIPO_SOLICITUDTextBox.Name = "ID_TIPO_SOLICITUDTextBox"
        Me.ID_TIPO_SOLICITUDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_SOLICITUDTextBox.TabIndex = 1
        Me.ID_TIPO_SOLICITUDTextBox.ReadOnly = True
        '
        'CODIGO_PROCESOcbxPROCESO
        '
        Me.CODIGO_PROCESOcbxPROCESO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaTIPO_SOLICITUDBindingSource, "CODIGO_PROCESO", True))
        Me.CODIGO_PROCESOcbxPROCESO.Location = New System.Drawing.Point(144, 34)
        Me.CODIGO_PROCESOcbxPROCESO.Name = "CODIGO_PROCESOcbxPROCESO"
        Me.CODIGO_PROCESOcbxPROCESO.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_PROCESOcbxPROCESO.TabIndex = 3
        '
        'TIPO_SOLICITUDTextBox
        '
        Me.TIPO_SOLICITUDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_SOLICITUDBindingSource, "TIPO_SOLICITUD", True))
        Me.TIPO_SOLICITUDTextBox.Location = New System.Drawing.Point(144, 60)
        Me.TIPO_SOLICITUDTextBox.Name = "TIPO_SOLICITUDTextBox"
        Me.TIPO_SOLICITUDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_SOLICITUDTextBox.TabIndex = 5
        Me.TIPO_SOLICITUDTextBox.MaxLength = 60
        '
        'TABLA_RELACIONALTextBox
        '
        Me.TABLA_RELACIONALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_SOLICITUDBindingSource, "TABLA_RELACIONAL", True))
        Me.TABLA_RELACIONALTextBox.Location = New System.Drawing.Point(144, 86)
        Me.TABLA_RELACIONALTextBox.Name = "TABLA_RELACIONALTextBox"
        Me.TABLA_RELACIONALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TABLA_RELACIONALTextBox.TabIndex = 7
        Me.TABLA_RELACIONALTextBox.MaxLength = 40
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_SOLICITUDBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 9
        Me.NOTASTextBox.MaxLength = 255
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaTIPO_SOLICITUDBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 138)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 11
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaTIPO_SOLICITUDBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 164)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 13
        '
        'ucDetalleTIPO_SOLICITUD
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_TIPO_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_TIPO_SOLICITUDTextBox)
        Me.Controls.Add(CODIGO_PROCESOLabel)
        Me.Controls.Add(Me.CODIGO_PROCESOcbxPROCESO)
        Me.Controls.Add(TIPO_SOLICITUDLabel)
        Me.Controls.Add(Me.TIPO_SOLICITUDTextBox)
        Me.Controls.Add(TABLA_RELACIONALLabel)
        Me.Controls.Add(Me.TABLA_RELACIONALTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetalleTIPO_SOLICITUD"
        Me.Size = New System.Drawing.Size(382, 216)
        CType(Me.ListaTIPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_SOLICITUDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_TIPO_SOLICITUDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO_PROCESOcbxPROCESO As SGAFP.WinUC.cbxPROCESO
    Friend WithEvents TIPO_SOLICITUDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TABLA_RELACIONALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
