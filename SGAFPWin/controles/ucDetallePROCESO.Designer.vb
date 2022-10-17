<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePROCESO
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
        Dim CODIGO_PROCESOLabel As System.Windows.Forms.Label
        Dim NOMBRE_PROCESOLabel As System.Windows.Forms.Label
        Dim DURACIONLabel As System.Windows.Forms.Label
        Dim UNIDAD_DE_TIEMPOLabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim LASTUPDATELabel As System.Windows.Forms.Label
        Me.ListaPROCESOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_PROCESOTextBox = New System.Windows.Forms.TextBox
        Me.NOMBRE_PROCESOTextBox = New System.Windows.Forms.TextBox
        Me.DURACIONTextBox = New System.Windows.Forms.TextBox
        Me.UNIDAD_DE_TIEMPOTextBox = New System.Windows.Forms.TextBox
        Me.USERIDTextBox = New System.Windows.Forms.TextBox
        Me.LASTUPDATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        CODIGO_PROCESOLabel = New System.Windows.Forms.Label
        NOMBRE_PROCESOLabel = New System.Windows.Forms.Label
        DURACIONLabel = New System.Windows.Forms.Label
        UNIDAD_DE_TIEMPOLabel = New System.Windows.Forms.Label
        USERIDLabel = New System.Windows.Forms.Label
        LASTUPDATELabel = New System.Windows.Forms.Label
        CType(Me.ListaPROCESOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO_PROCESOLabel
        '
        CODIGO_PROCESOLabel.Location = New System.Drawing.Point(6, 14)
        CODIGO_PROCESOLabel.Name = "CODIGO_PROCESOLabel"
        CODIGO_PROCESOLabel.Size = New System.Drawing.Size(135, 13)
        CODIGO_PROCESOLabel.TabIndex = 0
        CODIGO_PROCESOLabel.Text = "Codigo proceso:"
        '
        'NOMBRE_PROCESOLabel
        '
        NOMBRE_PROCESOLabel.Location = New System.Drawing.Point(6, 40)
        NOMBRE_PROCESOLabel.Name = "NOMBRE_PROCESOLabel"
        NOMBRE_PROCESOLabel.Size = New System.Drawing.Size(135, 13)
        NOMBRE_PROCESOLabel.TabIndex = 2
        NOMBRE_PROCESOLabel.Text = "Nombre proceso:"
        '
        'DURACIONLabel
        '
        DURACIONLabel.Location = New System.Drawing.Point(6, 66)
        DURACIONLabel.Name = "DURACIONLabel"
        DURACIONLabel.Size = New System.Drawing.Size(135, 13)
        DURACIONLabel.TabIndex = 4
        DURACIONLabel.Text = "Duracion:"
        '
        'UNIDAD_DE_TIEMPOLabel
        '
        UNIDAD_DE_TIEMPOLabel.Location = New System.Drawing.Point(6, 92)
        UNIDAD_DE_TIEMPOLabel.Name = "UNIDAD_DE_TIEMPOLabel"
        UNIDAD_DE_TIEMPOLabel.Size = New System.Drawing.Size(135, 13)
        UNIDAD_DE_TIEMPOLabel.TabIndex = 6
        UNIDAD_DE_TIEMPOLabel.Text = "Unidad de tiempo:"
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
        'ListaPROCESOBindingSource
        '
        Me.ListaPROCESOBindingSource.DataSource = GetType(SGAFP.EL.PROCESO)
        '
        'CODIGO_PROCESOTextBox
        '
        Me.CODIGO_PROCESOTextBox.BackColor = System.Drawing.Color.Linen
        Me.CODIGO_PROCESOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPROCESOBindingSource, "CODIGO_PROCESO", True))
        Me.CODIGO_PROCESOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.CODIGO_PROCESOTextBox.Name = "CODIGO_PROCESOTextBox"
        Me.CODIGO_PROCESOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_PROCESOTextBox.TabIndex = 1
        Me.CODIGO_PROCESOTextBox.ReadOnly = True
        Me.CODIGO_PROCESOTextBox.MaxLength = 2
        '
        'NOMBRE_PROCESOTextBox
        '
        Me.NOMBRE_PROCESOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPROCESOBindingSource, "NOMBRE_PROCESO", True))
        Me.NOMBRE_PROCESOTextBox.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRE_PROCESOTextBox.Name = "NOMBRE_PROCESOTextBox"
        Me.NOMBRE_PROCESOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_PROCESOTextBox.TabIndex = 3
        Me.NOMBRE_PROCESOTextBox.MaxLength = 50
        '
        'DURACIONTextBox
        '
        Me.DURACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPROCESOBindingSource, "DURACION", True))
        Me.DURACIONTextBox.Location = New System.Drawing.Point(144, 60)
        Me.DURACIONTextBox.Name = "DURACIONTextBox"
        Me.DURACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DURACIONTextBox.TabIndex = 5
        '
        'UNIDAD_DE_TIEMPOTextBox
        '
        Me.UNIDAD_DE_TIEMPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPROCESOBindingSource, "UNIDAD_DE_TIEMPO", True))
        Me.UNIDAD_DE_TIEMPOTextBox.Location = New System.Drawing.Point(144, 86)
        Me.UNIDAD_DE_TIEMPOTextBox.Name = "UNIDAD_DE_TIEMPOTextBox"
        Me.UNIDAD_DE_TIEMPOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UNIDAD_DE_TIEMPOTextBox.TabIndex = 7
        Me.UNIDAD_DE_TIEMPOTextBox.MaxLength = 1
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPROCESOBindingSource, "USERID", True))
        Me.USERIDTextBox.Location = New System.Drawing.Point(144, 112)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextBox.TabIndex = 9
        Me.USERIDTextBox.MaxLength = 16
        '
        'LASTUPDATEDateTimePicker
        '
        Me.LASTUPDATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaPROCESOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateTimePicker.Location = New System.Drawing.Point(144, 138)
        Me.LASTUPDATEDateTimePicker.Name = "LASTUPDATEDateTimePicker"
        Me.LASTUPDATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateTimePicker.TabIndex = 11
        '
        'ucDetallePROCESO
        '
        Me.AutoScroll = True
        Me.Controls.Add(CODIGO_PROCESOLabel)
        Me.Controls.Add(Me.CODIGO_PROCESOTextBox)
        Me.Controls.Add(NOMBRE_PROCESOLabel)
        Me.Controls.Add(Me.NOMBRE_PROCESOTextBox)
        Me.Controls.Add(DURACIONLabel)
        Me.Controls.Add(Me.DURACIONTextBox)
        Me.Controls.Add(UNIDAD_DE_TIEMPOLabel)
        Me.Controls.Add(Me.UNIDAD_DE_TIEMPOTextBox)
        Me.Controls.Add(USERIDLabel)
        Me.Controls.Add(Me.USERIDTextBox)
        Me.Controls.Add(LASTUPDATELabel)
        Me.Controls.Add(Me.LASTUPDATEDateTimePicker)
        Me.Name = "ucDetallePROCESO"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaPROCESOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROCESOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_PROCESOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_PROCESOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DURACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNIDAD_DE_TIEMPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTUPDATEDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
