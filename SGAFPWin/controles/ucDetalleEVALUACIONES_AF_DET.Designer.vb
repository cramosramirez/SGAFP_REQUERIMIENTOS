<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleEVALUACIONES_AF_DET
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
        Dim ID_EVALUACION_DETLabel As System.Windows.Forms.Label
        Dim ID_PARTICIPANTELabel As System.Windows.Forms.Label
        Dim ID_EVALUACION_AFLabel As System.Windows.Forms.Label
        Dim NOTA_OBTENIDALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaEVALUACIONES_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EVALUACION_DETTextBox = New System.Windows.Forms.TextBox
        Me.ID_PARTICIPANTEcbxPARTICIPANTE = New SGAFP.WinUC.cbxPARTICIPANTE
        Me.ID_EVALUACION_AFcbxEVALUACION_AF = New SGAFP.WinUC.cbxEVALUACION_AF
        Me.NOTA_OBTENIDATextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_EVALUACION_DETLabel = New System.Windows.Forms.Label
        ID_PARTICIPANTELabel = New System.Windows.Forms.Label
        ID_EVALUACION_AFLabel = New System.Windows.Forms.Label
        NOTA_OBTENIDALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaEVALUACIONES_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_EVALUACION_DETLabel
        '
        ID_EVALUACION_DETLabel.Location = New System.Drawing.Point(6, 14)
        ID_EVALUACION_DETLabel.Name = "ID_EVALUACION_DETLabel"
        ID_EVALUACION_DETLabel.Size = New System.Drawing.Size(135, 13)
        ID_EVALUACION_DETLabel.TabIndex = 0
        ID_EVALUACION_DETLabel.Text = "Id evaluacion det:"
        '
        'ID_PARTICIPANTELabel
        '
        ID_PARTICIPANTELabel.Location = New System.Drawing.Point(6, 40)
        ID_PARTICIPANTELabel.Name = "ID_PARTICIPANTELabel"
        ID_PARTICIPANTELabel.Size = New System.Drawing.Size(135, 13)
        ID_PARTICIPANTELabel.TabIndex = 2
        ID_PARTICIPANTELabel.Text = "Id participante:"
        '
        'ID_EVALUACION_AFLabel
        '
        ID_EVALUACION_AFLabel.Location = New System.Drawing.Point(6, 66)
        ID_EVALUACION_AFLabel.Name = "ID_EVALUACION_AFLabel"
        ID_EVALUACION_AFLabel.Size = New System.Drawing.Size(135, 13)
        ID_EVALUACION_AFLabel.TabIndex = 4
        ID_EVALUACION_AFLabel.Text = "Id evaluacion af:"
        '
        'NOTA_OBTENIDALabel
        '
        NOTA_OBTENIDALabel.Location = New System.Drawing.Point(6, 92)
        NOTA_OBTENIDALabel.Name = "NOTA_OBTENIDALabel"
        NOTA_OBTENIDALabel.Size = New System.Drawing.Size(135, 13)
        NOTA_OBTENIDALabel.TabIndex = 6
        NOTA_OBTENIDALabel.Text = "Nota obtenida:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 118)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 8
        NOTASLabel.Text = "Notas:"
        '
        'ListaEVALUACIONES_AF_DETBindingSource
        '
        Me.ListaEVALUACIONES_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.EVALUACIONES_AF_DET)
        '
        'ID_EVALUACION_DETTextBox
        '
        Me.ID_EVALUACION_DETTextBox.BackColor = System.Drawing.Color.Linen
        Me.ID_EVALUACION_DETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACIONES_AF_DETBindingSource, "ID_EVALUACION_DET", True))
        Me.ID_EVALUACION_DETTextBox.Location = New System.Drawing.Point(144, 8)
        Me.ID_EVALUACION_DETTextBox.Name = "ID_EVALUACION_DETTextBox"
        Me.ID_EVALUACION_DETTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EVALUACION_DETTextBox.TabIndex = 1
        Me.ID_EVALUACION_DETTextBox.ReadOnly = True
        '
        'ID_PARTICIPANTEcbxPARTICIPANTE
        '
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaEVALUACIONES_AF_DETBindingSource, "ID_PARTICIPANTE", True))
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Location = New System.Drawing.Point(144, 34)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Name = "ID_PARTICIPANTEcbxPARTICIPANTE"
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Size = New System.Drawing.Size(200, 20)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.TabIndex = 3
        '
        'ID_EVALUACION_AFcbxEVALUACION_AF
        '
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaEVALUACIONES_AF_DETBindingSource, "ID_EVALUACION_AF", True))
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.Location = New System.Drawing.Point(144, 60)
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.Name = "ID_EVALUACION_AFcbxEVALUACION_AF"
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.TabIndex = 5
        '
        'NOTA_OBTENIDATextBox
        '
        Me.NOTA_OBTENIDATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACIONES_AF_DETBindingSource, "NOTA_OBTENIDA", True))
        Me.NOTA_OBTENIDATextBox.Location = New System.Drawing.Point(144, 86)
        Me.NOTA_OBTENIDATextBox.Name = "NOTA_OBTENIDATextBox"
        Me.NOTA_OBTENIDATextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTA_OBTENIDATextBox.TabIndex = 7
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaEVALUACIONES_AF_DETBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 112)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 9
        Me.NOTASTextBox.MaxLength = 100
        '
        'ucDetalleEVALUACIONES_AF_DET
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_EVALUACION_DETLabel)
        Me.Controls.Add(Me.ID_EVALUACION_DETTextBox)
        Me.Controls.Add(ID_PARTICIPANTELabel)
        Me.Controls.Add(Me.ID_PARTICIPANTEcbxPARTICIPANTE)
        Me.Controls.Add(ID_EVALUACION_AFLabel)
        Me.Controls.Add(Me.ID_EVALUACION_AFcbxEVALUACION_AF)
        Me.Controls.Add(NOTA_OBTENIDALabel)
        Me.Controls.Add(Me.NOTA_OBTENIDATextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetalleEVALUACIONES_AF_DET"
        Me.Size = New System.Drawing.Size(382, 164)
        CType(Me.ListaEVALUACIONES_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEVALUACIONES_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_EVALUACION_DETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_PARTICIPANTEcbxPARTICIPANTE As SGAFP.WinUC.cbxPARTICIPANTE
    Friend WithEvents ID_EVALUACION_AFcbxEVALUACION_AF As SGAFP.WinUC.cbxEVALUACION_AF
    Friend WithEvents NOTA_OBTENIDATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
