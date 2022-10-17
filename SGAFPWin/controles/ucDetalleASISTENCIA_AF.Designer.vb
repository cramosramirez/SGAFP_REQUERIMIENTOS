<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleASISTENCIA_AF
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
        Dim ID_ASISTENCIA_AFLabel As System.Windows.Forms.Label
        Dim ID_ACCION_FORMATIVALabel As System.Windows.Forms.Label
        Dim FECHALabel As System.Windows.Forms.Label
        Dim INSTRUCTORLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaASISTENCIA_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ASISTENCIA_AFTextBox = New System.Windows.Forms.TextBox
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.FECHADateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.INSTRUCTORTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_ASISTENCIA_AFLabel = New System.Windows.Forms.Label
        ID_ACCION_FORMATIVALabel = New System.Windows.Forms.Label
        FECHALabel = New System.Windows.Forms.Label
        INSTRUCTORLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaASISTENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ASISTENCIA_AFLabel
        '
        ID_ASISTENCIA_AFLabel.Location = New System.Drawing.Point(6, 14)
        ID_ASISTENCIA_AFLabel.Name = "ID_ASISTENCIA_AFLabel"
        ID_ASISTENCIA_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_ASISTENCIA_AFLabel.TabIndex = 0
        ID_ASISTENCIA_AFLabel.Text = "Id asistencia af:"
        '
        'ID_ACCION_FORMATIVALabel
        '
        ID_ACCION_FORMATIVALabel.Location = New System.Drawing.Point(6, 40)
        ID_ACCION_FORMATIVALabel.Name = "ID_ACCION_FORMATIVALabel"
        ID_ACCION_FORMATIVALabel.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_FORMATIVALabel.TabIndex = 2
        ID_ACCION_FORMATIVALabel.Text = "Id accion formativa:"
        '
        'FECHALabel
        '
        FECHALabel.Location = New System.Drawing.Point(6, 66)
        FECHALabel.Name = "FECHALabel"
        FECHALabel.Size = New System.Drawing.Size(135, 13)
        FECHALabel.TabIndex = 4
        FECHALabel.Text = "Fecha:"
        '
        'INSTRUCTORLabel
        '
        INSTRUCTORLabel.Location = New System.Drawing.Point(6, 92)
        INSTRUCTORLabel.Name = "INSTRUCTORLabel"
        INSTRUCTORLabel.Size = New System.Drawing.Size(135, 13)
        INSTRUCTORLabel.TabIndex = 6
        INSTRUCTORLabel.Text = "Instructor:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 118)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 8
        NOTASLabel.Text = "Notas:"
        '
        'ListaASISTENCIA_AFBindingSource
        '
        Me.ListaASISTENCIA_AFBindingSource.DataSource = GetType(SGAFP.EL.ASISTENCIA_AF)
        '
        'ID_ASISTENCIA_AFTextBox
        '
        Me.ID_ASISTENCIA_AFTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_ASISTENCIA_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AFBindingSource, "ID_ASISTENCIA_AF", True))
        Me.ID_ASISTENCIA_AFTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_ASISTENCIA_AFTextBox.Name = "ID_ASISTENCIA_AFTextBox"
        Me.ID_ASISTENCIA_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_ASISTENCIA_AFTextBox.TabIndex = 1
        Me.ID_ASISTENCIA_AFTextBox.ReadOnly = True
        '
        'ID_ACCION_FORMATIVAcbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaASISTENCIA_AFBindingSource, "ID_ACCION_FORMATIVA", True))
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Location = New System.Drawing.Point(144, 34)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVAcbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.TabIndex = 3
        '
        'FECHADateTimePicker
        '
        Me.FECHADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaASISTENCIA_AFBindingSource, "FECHA", True))
        Me.FECHADateTimePicker.Location = New System.Drawing.Point(144, 60)
        Me.FECHADateTimePicker.Name = "FECHADateTimePicker"
        Me.FECHADateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHADateTimePicker.TabIndex = 5
        '
        'INSTRUCTORTextBox
        '
        Me.INSTRUCTORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AFBindingSource, "INSTRUCTOR", True))
        Me.INSTRUCTORTextBox.Location = New System.Drawing.Point(144, 86)
        Me.INSTRUCTORTextBox.Name = "INSTRUCTORTextBox"
        Me.INSTRUCTORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.INSTRUCTORTextBox.TabIndex = 7
        Me.INSTRUCTORTextBox.MaxLength = 255
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaASISTENCIA_AFBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 9
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetalleASISTENCIA_AF
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_ASISTENCIA_AFLabel)
        Me.Controls.Add(Me.ID_ASISTENCIA_AFTextBox)
        Me.Controls.Add(ID_ACCION_FORMATIVALabel)
        Me.Controls.Add(Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA)
        Me.Controls.Add(FECHALabel)
        Me.Controls.Add(Me.FECHADateTimePicker)
        Me.Controls.Add(INSTRUCTORLabel)
        Me.Controls.Add(Me.INSTRUCTORTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleASISTENCIA_AF"
        Me.Size = New System.Drawing.Size(382, 164)
        CType(Me.ListaASISTENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaASISTENCIA_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_ASISTENCIA_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ACCION_FORMATIVAcbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA
    Friend WithEvents FECHADateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents INSTRUCTORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
