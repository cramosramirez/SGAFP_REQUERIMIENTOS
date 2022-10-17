<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleEVALUACION_AF
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
        Dim ID_EVALUACION_AFLabel As System.Windows.Forms.Label
        Dim ID_ACCION_FORMATIVALabel As System.Windows.Forms.Label
        Dim FECHA_EVALUACIONLabel As System.Windows.Forms.Label
        Dim TEMA_EVALUACIONLabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Dim EVALUADORLabel As System.Windows.Forms.Label
        Dim TIPO_EVALUACIONLabel As System.Windows.Forms.Label
        Dim PORC_APROBACIONLabel As System.Windows.Forms.Label
        Dim PORC_REPROBADOSLabel As System.Windows.Forms.Label
        Me.ListaEVALUACION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EVALUACION_AFTextBox = New System.Windows.Forms.TextBox
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.FECHA_EVALUACIONDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TEMA_EVALUACIONTextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        Me.EVALUADORTextBox = New System.Windows.Forms.TextBox
        Me.TIPO_EVALUACIONTextBox = New System.Windows.Forms.TextBox
        Me.PORC_APROBACIONTextBox = New System.Windows.Forms.TextBox
        Me.PORC_REPROBADOSTextBox = New System.Windows.Forms.TextBox
        ID_EVALUACION_AFLabel = New System.Windows.Forms.Label
        ID_ACCION_FORMATIVALabel = New System.Windows.Forms.Label
        FECHA_EVALUACIONLabel = New System.Windows.Forms.Label
        TEMA_EVALUACIONLabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        EVALUADORLabel = New System.Windows.Forms.Label
        TIPO_EVALUACIONLabel = New System.Windows.Forms.Label
        PORC_APROBACIONLabel = New System.Windows.Forms.Label
        PORC_REPROBADOSLabel = New System.Windows.Forms.Label
        CType(Me.ListaEVALUACION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_EVALUACION_AFLabel
        '
        ID_EVALUACION_AFLabel.Location = New System.Drawing.Point(6, 14)
        ID_EVALUACION_AFLabel.Name = "ID_EVALUACION_AFLabel"
        ID_EVALUACION_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_EVALUACION_AFLabel.TabIndex = 0
        ID_EVALUACION_AFLabel.Text = "Id evaluacion af:"
        '
        'ID_ACCION_FORMATIVALabel
        '
        ID_ACCION_FORMATIVALabel.Location = New System.Drawing.Point(6, 40)
        ID_ACCION_FORMATIVALabel.Name = "ID_ACCION_FORMATIVALabel"
        ID_ACCION_FORMATIVALabel.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_FORMATIVALabel.TabIndex = 2
        ID_ACCION_FORMATIVALabel.Text = "Id accion formativa:"
        '
        'FECHA_EVALUACIONLabel
        '
        FECHA_EVALUACIONLabel.Location = New System.Drawing.Point(6, 66)
        FECHA_EVALUACIONLabel.Name = "FECHA_EVALUACIONLabel"
        FECHA_EVALUACIONLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_EVALUACIONLabel.TabIndex = 4
        FECHA_EVALUACIONLabel.Text = "Fecha evaluacion:"
        '
        'TEMA_EVALUACIONLabel
        '
        TEMA_EVALUACIONLabel.Location = New System.Drawing.Point(6, 92)
        TEMA_EVALUACIONLabel.Name = "TEMA_EVALUACIONLabel"
        TEMA_EVALUACIONLabel.Size = New System.Drawing.Size(135, 13)
        TEMA_EVALUACIONLabel.TabIndex = 6
        TEMA_EVALUACIONLabel.Text = "Tema evaluacion:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 118)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 8
        NOTASLabel.Text = "Notas:"
        '
        'EVALUADORLabel
        '
        EVALUADORLabel.Location = New System.Drawing.Point(6, 144)
        EVALUADORLabel.Name = "EVALUADORLabel"
        EVALUADORLabel.Size = New System.Drawing.Size(135, 13)
        EVALUADORLabel.TabIndex = 10
        EVALUADORLabel.Text = "Evaluador:"
        '
        'TIPO_EVALUACIONLabel
        '
        TIPO_EVALUACIONLabel.Location = New System.Drawing.Point(6, 170)
        TIPO_EVALUACIONLabel.Name = "TIPO_EVALUACIONLabel"
        TIPO_EVALUACIONLabel.Size = New System.Drawing.Size(135, 13)
        TIPO_EVALUACIONLabel.TabIndex = 12
        TIPO_EVALUACIONLabel.Text = "Tipo evaluacion:"
        '
        'PORC_APROBACIONLabel
        '
        PORC_APROBACIONLabel.Location = New System.Drawing.Point(6, 196)
        PORC_APROBACIONLabel.Name = "PORC_APROBACIONLabel"
        PORC_APROBACIONLabel.Size = New System.Drawing.Size(135, 13)
        PORC_APROBACIONLabel.TabIndex = 14
        PORC_APROBACIONLabel.Text = "Porc aprobacion:"
        '
        'PORC_REPROBADOSLabel
        '
        PORC_REPROBADOSLabel.Location = New System.Drawing.Point(6, 222)
        PORC_REPROBADOSLabel.Name = "PORC_REPROBADOSLabel"
        PORC_REPROBADOSLabel.Size = New System.Drawing.Size(135, 13)
        PORC_REPROBADOSLabel.TabIndex = 16
        PORC_REPROBADOSLabel.Text = "Porc reprobados:"
        '
        'ListaEVALUACION_AFBindingSource
        '
        Me.ListaEVALUACION_AFBindingSource.DataSource = GetType(SGAFP.EL.EVALUACION_AF)
        '
        'ID_EVALUACION_AFTextBox
        '
        Me.ID_EVALUACION_AFTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_EVALUACION_AFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "ID_EVALUACION_AF", True))
        Me.ID_EVALUACION_AFTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_EVALUACION_AFTextBox.Name = "ID_EVALUACION_AFTextBox"
        Me.ID_EVALUACION_AFTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EVALUACION_AFTextBox.TabIndex = 1
        Me.ID_EVALUACION_AFTextBox.ReadOnly = True
        '
        'ID_ACCION_FORMATIVAcbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaEVALUACION_AFBindingSource, "ID_ACCION_FORMATIVA", True))
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Location = New System.Drawing.Point(144, 34)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVAcbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.TabIndex = 3
        '
        'FECHA_EVALUACIONDateTimePicker
        '
        Me.FECHA_EVALUACIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaEVALUACION_AFBindingSource, "FECHA_EVALUACION", True))
        Me.FECHA_EVALUACIONDateTimePicker.Location = New System.Drawing.Point(144, 60)
        Me.FECHA_EVALUACIONDateTimePicker.Name = "FECHA_EVALUACIONDateTimePicker"
        Me.FECHA_EVALUACIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_EVALUACIONDateTimePicker.TabIndex = 5
        '
        'TEMA_EVALUACIONTextBox
        '
        Me.TEMA_EVALUACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "TEMA_EVALUACION", True))
        Me.TEMA_EVALUACIONTextBox.Location = New System.Drawing.Point(144, 86)
        Me.TEMA_EVALUACIONTextBox.Name = "TEMA_EVALUACIONTextBox"
        Me.TEMA_EVALUACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TEMA_EVALUACIONTextBox.TabIndex = 7
        Me.TEMA_EVALUACIONTextBox.MaxLength = 100
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 9
        Me.NOTASTextBox.MaxLength = 255
        '
        'EVALUADORTextBox
        '
        Me.EVALUADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "EVALUADOR", True))
        Me.EVALUADORTextBox.Location = New System.Drawing.Point(144, 138)
        Me.EVALUADORTextBox.Name = "EVALUADORTextBox"
        Me.EVALUADORTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EVALUADORTextBox.TabIndex = 11
        Me.EVALUADORTextBox.MaxLength = 100
        '
        'TIPO_EVALUACIONTextBox
        '
        Me.TIPO_EVALUACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "TIPO_EVALUACION", True))
        Me.TIPO_EVALUACIONTextBox.Location = New System.Drawing.Point(144, 164)
        Me.TIPO_EVALUACIONTextBox.Name = "TIPO_EVALUACIONTextBox"
        Me.TIPO_EVALUACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TIPO_EVALUACIONTextBox.TabIndex = 13
        Me.TIPO_EVALUACIONTextBox.MaxLength = 1
        '
        'PORC_APROBACIONTextBox
        '
        Me.PORC_APROBACIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "PORC_APROBACION", True))
        Me.PORC_APROBACIONTextBox.Location = New System.Drawing.Point(144, 190)
        Me.PORC_APROBACIONTextBox.Name = "PORC_APROBACIONTextBox"
        Me.PORC_APROBACIONTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PORC_APROBACIONTextBox.TabIndex = 15
        '
        'PORC_REPROBADOSTextBox
        '
        Me.PORC_REPROBADOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACION_AFBindingSource, "PORC_REPROBADOS", True))
        Me.PORC_REPROBADOSTextBox.Location = New System.Drawing.Point(144, 216)
        Me.PORC_REPROBADOSTextBox.Name = "PORC_REPROBADOSTextBox"
        Me.PORC_REPROBADOSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PORC_REPROBADOSTextBox.TabIndex = 17
        '
        'ucDetalleEVALUACION_AF
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_EVALUACION_AFLabel)
        Me.Controls.Add(Me.ID_EVALUACION_AFTextBox)
        Me.Controls.Add(ID_ACCION_FORMATIVALabel)
        Me.Controls.Add(Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA)
        Me.Controls.Add(FECHA_EVALUACIONLabel)
        Me.Controls.Add(Me.FECHA_EVALUACIONDateTimePicker)
        Me.Controls.Add(TEMA_EVALUACIONLabel)
        Me.Controls.Add(Me.TEMA_EVALUACIONTextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Controls.Add(EVALUADORLabel)
        Me.Controls.Add(Me.EVALUADORTextBox)
        Me.Controls.Add(TIPO_EVALUACIONLabel)
        Me.Controls.Add(Me.TIPO_EVALUACIONTextBox)
        Me.Controls.Add(PORC_APROBACIONLabel)
        Me.Controls.Add(Me.PORC_APROBACIONTextBox)
        Me.Controls.Add(PORC_REPROBADOSLabel)
        Me.Controls.Add(Me.PORC_REPROBADOSTextBox)
        Me.Name = "ucDetalleEVALUACION_AF"
        Me.Size = New System.Drawing.Size(382, 268)
        CType(Me.ListaEVALUACION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEVALUACION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_EVALUACION_AFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ACCION_FORMATIVAcbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA
    Friend WithEvents FECHA_EVALUACIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TEMA_EVALUACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EVALUADORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIPO_EVALUACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PORC_APROBACIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PORC_REPROBADOSTextBox As System.Windows.Forms.TextBox

End Class
