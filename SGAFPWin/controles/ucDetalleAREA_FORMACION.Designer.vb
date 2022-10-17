<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleAREA_FORMACION
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
        Dim ID_AREA_FORMACIONLabel As System.Windows.Forms.Label
        Dim AREA_FORMACIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaAREA_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_AREA_FORMACIONTextBox = New System.Windows.Forms.TextBox
        Me.AREA_FORMACIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_AREA_FORMACIONLabel = New System.Windows.Forms.Label
        AREA_FORMACIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaAREA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_AREA_FORMACIONLabel
        '
        ID_AREA_FORMACIONLabel.Location = New System.Drawing.Point(6, 14)
        ID_AREA_FORMACIONLabel.Name = "ID_AREA_FORMACIONLabel"
        ID_AREA_FORMACIONLabel.Size = New System.Drawing.Size(135, 13)
        ID_AREA_FORMACIONLabel.TabIndex = 0
        ID_AREA_FORMACIONLabel.Text = "Id area formacion:"
        '
        'AREA_FORMACIONLabel
        '
        AREA_FORMACIONLabel.Location = New System.Drawing.Point(6, 40)
        AREA_FORMACIONLabel.Name = "AREA_FORMACIONLabel"
        AREA_FORMACIONLabel.Size = New System.Drawing.Size(135, 13)
        AREA_FORMACIONLabel.TabIndex = 2
        AREA_FORMACIONLabel.Text = "Area formacion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 66)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 4
        NOTASLabel.Text = "Notas:"
        '
        'ListaAREA_FORMACIONBindingSource
        '
        Me.ListaAREA_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.AREA_FORMACION)
        '
        'ID_AREA_FORMACIONTextBox
        '
        Me.ID_AREA_FORMACIONTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_AREA_FORMACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_FORMACIONBindingSource, "ID_AREA_FORMACION", True))
        Me.ID_AREA_FORMACIONTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_AREA_FORMACIONTextBox.Name = "ID_AREA_FORMACIONTextBox"
        Me.ID_AREA_FORMACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_AREA_FORMACIONTextBox.TabIndex = 1
        Me.ID_AREA_FORMACIONTextBox.ReadOnly = True
        '
        'AREA_FORMACIONTextBox
        '
        Me.AREA_FORMACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_FORMACIONBindingSource, "AREA_FORMACION", True))
        Me.AREA_FORMACIONTextBox.Location = New System.Drawing.Point(144, 34)
        Me.AREA_FORMACIONTextBox.Name = "AREA_FORMACIONTextBox"
        Me.AREA_FORMACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AREA_FORMACIONTextBox.TabIndex = 3
        Me.AREA_FORMACIONTextBox.MaxLength = 50
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaAREA_FORMACIONBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 5
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleAREA_FORMACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_AREA_FORMACIONLabel)
        Me.Controls.Add(Me.ID_AREA_FORMACIONTextBox)
        Me.Controls.Add(AREA_FORMACIONLabel)
        Me.Controls.Add(Me.AREA_FORMACIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleAREA_FORMACION"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaAREA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaAREA_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_AREA_FORMACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AREA_FORMACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
