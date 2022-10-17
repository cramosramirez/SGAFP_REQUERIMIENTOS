<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleAREA_SUPERVISION
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
        Dim ID_AREA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim AREA_SUPERVISIONLabel As System.Windows.Forms.Label
        Dim SANCIONATORIALabel As System.Windows.Forms.Label
        Dim MONTO_SANCIONLabel As System.Windows.Forms.Label
        Dim TIEMPO_SANCIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaAREA_SUPERVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_AREA_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.AREA_SUPERVISIONTextBox = New System.Windows.Forms.TextBox
        Me.SANCIONATORIATextBox = New System.Windows.Forms.TextBox
        Me.MONTO_SANCIONTextBox = New System.Windows.Forms.TextBox
        Me.TIEMPO_SANCIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_AREA_SUPERVISIONLabel = New System.Windows.Forms.Label
        AREA_SUPERVISIONLabel = New System.Windows.Forms.Label
        SANCIONATORIALabel = New System.Windows.Forms.Label
        MONTO_SANCIONLabel = New System.Windows.Forms.Label
        TIEMPO_SANCIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaAREA_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_AREA_SUPERVISIONLabel
        '
        ID_AREA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 14)
        ID_AREA_SUPERVISIONLabel.Name = "ID_AREA_SUPERVISIONLabel"
        ID_AREA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_AREA_SUPERVISIONLabel.TabIndex = 0
        ID_AREA_SUPERVISIONLabel.Text = "Id area supervision:"
        '
        'AREA_SUPERVISIONLabel
        '
        AREA_SUPERVISIONLabel.Location = New System.Drawing.Point(6, 40)
        AREA_SUPERVISIONLabel.Name = "AREA_SUPERVISIONLabel"
        AREA_SUPERVISIONLabel.Size = New System.Drawing.Size(135, 13)
        AREA_SUPERVISIONLabel.TabIndex = 2
        AREA_SUPERVISIONLabel.Text = "Area supervision:"
        '
        'SANCIONATORIALabel
        '
        SANCIONATORIALabel.Location = New System.Drawing.Point(6, 66)
        SANCIONATORIALabel.Name = "SANCIONATORIALabel"
        SANCIONATORIALabel.Size = New System.Drawing.Size(135, 13)
        SANCIONATORIALabel.TabIndex = 4
        SANCIONATORIALabel.Text = "Sancionatoria:"
        '
        'MONTO_SANCIONLabel
        '
        MONTO_SANCIONLabel.Location = New System.Drawing.Point(6, 92)
        MONTO_SANCIONLabel.Name = "MONTO_SANCIONLabel"
        MONTO_SANCIONLabel.Size = New System.Drawing.Size(135, 13)
        MONTO_SANCIONLabel.TabIndex = 6
        MONTO_SANCIONLabel.Text = "Monto sancion:"
        '
        'TIEMPO_SANCIONLabel
        '
        TIEMPO_SANCIONLabel.Location = New System.Drawing.Point(6, 118)
        TIEMPO_SANCIONLabel.Name = "TIEMPO_SANCIONLabel"
        TIEMPO_SANCIONLabel.Size = New System.Drawing.Size(135, 13)
        TIEMPO_SANCIONLabel.TabIndex = 8
        TIEMPO_SANCIONLabel.Text = "Tiempo sancion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 144)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 10
        NOTASLabel.Text = "Notas:"
        '
        'ListaAREA_SUPERVISIONBindingSource
        '
        Me.ListaAREA_SUPERVISIONBindingSource.DataSource = GetType(SGAFP.EL.AREA_SUPERVISION)
        '
        'ID_AREA_SUPERVISIONTextBox
        '
        Me.ID_AREA_SUPERVISIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_AREA_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "ID_AREA_SUPERVISION", True))
        Me.ID_AREA_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_AREA_SUPERVISIONTextBox.Name = "ID_AREA_SUPERVISIONTextBox"
        Me.ID_AREA_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_AREA_SUPERVISIONTextBox.TabIndex = 1
        Me.ID_AREA_SUPERVISIONTextBox.ReadOnly = True
        '
        'AREA_SUPERVISIONTextBox
        '
        Me.AREA_SUPERVISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "AREA_SUPERVISION", True))
        Me.AREA_SUPERVISIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.AREA_SUPERVISIONTextBox.Name = "AREA_SUPERVISIONTextBox"
        Me.AREA_SUPERVISIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AREA_SUPERVISIONTextBox.TabIndex = 3
        Me.AREA_SUPERVISIONTextBox.MaxLength = 60
        '
        'SANCIONATORIATextBox
        '
        Me.SANCIONATORIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "SANCIONATORIA", True))
        Me.SANCIONATORIATextBox.Location = New System.Drawing.Point(144, 60)
        Me.SANCIONATORIATextBox.Name = "SANCIONATORIATextBox"
        Me.SANCIONATORIATextBox.Size = New System.Drawing.Size(200, 20)
        Me.SANCIONATORIATextBox.TabIndex = 5
        Me.SANCIONATORIATextBox.MaxLength = 1
        '
        'MONTO_SANCIONTextBox
        '
        Me.MONTO_SANCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "MONTO_SANCION", True))
        Me.MONTO_SANCIONTextBox.Location = New System.Drawing.Point(144, 86)
        Me.MONTO_SANCIONTextBox.Name = "MONTO_SANCIONTextBox"
        Me.MONTO_SANCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MONTO_SANCIONTextBox.TabIndex = 7
        '
        'TIEMPO_SANCIONTextBox
        '
        Me.TIEMPO_SANCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "TIEMPO_SANCION", True))
        Me.TIEMPO_SANCIONTextBox.Location = New System.Drawing.Point(144, 112)
        Me.TIEMPO_SANCIONTextBox.Name = "TIEMPO_SANCIONTextBox"
        Me.TIEMPO_SANCIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIEMPO_SANCIONTextBox.TabIndex = 9
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_SUPERVISIONBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 138)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 11
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleAREA_SUPERVISION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_AREA_SUPERVISIONLabel)
        Me.Controls.Add(Me.ID_AREA_SUPERVISIONTextBox)
        Me.Controls.Add(AREA_SUPERVISIONLabel)
        Me.Controls.Add(Me.AREA_SUPERVISIONTextBox)
        Me.Controls.Add(SANCIONATORIALabel)
        Me.Controls.Add(Me.SANCIONATORIATextBox)
        Me.Controls.Add(MONTO_SANCIONLabel)
        Me.Controls.Add(Me.MONTO_SANCIONTextBox)
        Me.Controls.Add(TIEMPO_SANCIONLabel)
        Me.Controls.Add(Me.TIEMPO_SANCIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleAREA_SUPERVISION"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaAREA_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaAREA_SUPERVISIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_AREA_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AREA_SUPERVISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SANCIONATORIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents MONTO_SANCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIEMPO_SANCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
