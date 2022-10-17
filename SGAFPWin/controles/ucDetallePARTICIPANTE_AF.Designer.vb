<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePARTICIPANTE_AF
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
        Dim ID_PARTICIPANTELabel As System.Windows.Forms.Label
        Dim ID_ACCION_FORMATIVALabel As System.Windows.Forms.Label
        Dim ID_SOLICITUDLabel As System.Windows.Forms.Label
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim FECHA_INSCRIPCIONLabel As System.Windows.Forms.Label
        Dim NOTA_FINALLabel As System.Windows.Forms.Label
        Dim PORC_ASISTENCIALabel As System.Windows.Forms.Label
        Dim ENTREGA_DIPLOMALabel As System.Windows.Forms.Label
        Dim NOTASLabel As System.Windows.Forms.Label
        Me.ListaPARTICIPANTE_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE = New SGAFP.WinUC.cbxPARTICIPANTE
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF = New SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox
        Me.FECHA_INSCRIPCIONDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NOTA_FINALTextBox = New System.Windows.Forms.TextBox
        Me.PORC_ASISTENCIATextBox = New System.Windows.Forms.TextBox
        Me.ENTREGA_DIPLOMATextBox = New System.Windows.Forms.TextBox
        Me.NOTASTextBox = New System.Windows.Forms.TextBox
        ID_PARTICIPANTELabel = New System.Windows.Forms.Label
        ID_ACCION_FORMATIVALabel = New System.Windows.Forms.Label
        ID_SOLICITUDLabel = New System.Windows.Forms.Label
        ESTADOLabel = New System.Windows.Forms.Label
        FECHA_INSCRIPCIONLabel = New System.Windows.Forms.Label
        NOTA_FINALLabel = New System.Windows.Forms.Label
        PORC_ASISTENCIALabel = New System.Windows.Forms.Label
        ENTREGA_DIPLOMALabel = New System.Windows.Forms.Label
        NOTASLabel = New System.Windows.Forms.Label
        CType(Me.ListaPARTICIPANTE_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PARTICIPANTELabel
        '
        ID_PARTICIPANTELabel.Location = New System.Drawing.Point(6, 14)
        ID_PARTICIPANTELabel.Name = "ID_PARTICIPANTELabel"
        ID_PARTICIPANTELabel.Size = New System.Drawing.Size(135, 13)
        ID_PARTICIPANTELabel.TabIndex = 0
        ID_PARTICIPANTELabel.Text = "Id participante:"
        '
        'ID_ACCION_FORMATIVALabel
        '
        ID_ACCION_FORMATIVALabel.Location = New System.Drawing.Point(6, 40)
        ID_ACCION_FORMATIVALabel.Name = "ID_ACCION_FORMATIVALabel"
        ID_ACCION_FORMATIVALabel.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_FORMATIVALabel.TabIndex = 2
        ID_ACCION_FORMATIVALabel.Text = "Id accion formativa:"
        '
        'ID_SOLICITUDLabel
        '
        ID_SOLICITUDLabel.Location = New System.Drawing.Point(6, 66)
        ID_SOLICITUDLabel.Name = "ID_SOLICITUDLabel"
        ID_SOLICITUDLabel.Size = New System.Drawing.Size(135, 13)
        ID_SOLICITUDLabel.TabIndex = 4
        ID_SOLICITUDLabel.Text = "Id solicitud:"
        '
        'ESTADOLabel
        '
        ESTADOLabel.Location = New System.Drawing.Point(6, 92)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(135, 13)
        ESTADOLabel.TabIndex = 6
        ESTADOLabel.Text = "Estado:"
        '
        'FECHA_INSCRIPCIONLabel
        '
        FECHA_INSCRIPCIONLabel.Location = New System.Drawing.Point(6, 118)
        FECHA_INSCRIPCIONLabel.Name = "FECHA_INSCRIPCIONLabel"
        FECHA_INSCRIPCIONLabel.Size = New System.Drawing.Size(135, 13)
        FECHA_INSCRIPCIONLabel.TabIndex = 8
        FECHA_INSCRIPCIONLabel.Text = "Fecha inscripcion:"
        '
        'NOTA_FINALLabel
        '
        NOTA_FINALLabel.Location = New System.Drawing.Point(6, 144)
        NOTA_FINALLabel.Name = "NOTA_FINALLabel"
        NOTA_FINALLabel.Size = New System.Drawing.Size(135, 13)
        NOTA_FINALLabel.TabIndex = 10
        NOTA_FINALLabel.Text = "Nota final:"
        '
        'PORC_ASISTENCIALabel
        '
        PORC_ASISTENCIALabel.Location = New System.Drawing.Point(6, 170)
        PORC_ASISTENCIALabel.Name = "PORC_ASISTENCIALabel"
        PORC_ASISTENCIALabel.Size = New System.Drawing.Size(135, 13)
        PORC_ASISTENCIALabel.TabIndex = 12
        PORC_ASISTENCIALabel.Text = "Porc asistencia:"
        '
        'ENTREGA_DIPLOMALabel
        '
        ENTREGA_DIPLOMALabel.Location = New System.Drawing.Point(6, 196)
        ENTREGA_DIPLOMALabel.Name = "ENTREGA_DIPLOMALabel"
        ENTREGA_DIPLOMALabel.Size = New System.Drawing.Size(135, 13)
        ENTREGA_DIPLOMALabel.TabIndex = 14
        ENTREGA_DIPLOMALabel.Text = "Entrega diploma:"
        '
        'NOTASLabel
        '
        NOTASLabel.Location = New System.Drawing.Point(6, 222)
        NOTASLabel.Name = "NOTASLabel"
        NOTASLabel.Size = New System.Drawing.Size(135, 13)
        NOTASLabel.TabIndex = 16
        NOTASLabel.Text = "Notas:"
        '
        'ListaPARTICIPANTE_AFBindingSource
        '
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE_AF)
        '
        'ID_PARTICIPANTEcbxPARTICIPANTE
        '
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaPARTICIPANTE_AFBindingSource, "ID_PARTICIPANTE", True))
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Location = New System.Drawing.Point(144, 8)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Name = "ID_PARTICIPANTEcbxPARTICIPANTE"
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Size = New System.Drawing.Size(200, 20)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.TabIndex = 1
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.BackColor = System.Drawing.Color.Linen
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Enabled = False
        '
        'ID_ACCION_FORMATIVAcbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaPARTICIPANTE_AFBindingSource, "ID_ACCION_FORMATIVA", True))
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Location = New System.Drawing.Point(144, 34)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVAcbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.TabIndex = 3
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.BackColor = System.Drawing.Color.Linen
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = False
        '
        'ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF
        '
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaPARTICIPANTE_AFBindingSource, "ID_SOLICITUD", True))
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Location = New System.Drawing.Point(144, 60)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Name = "ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF"
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Size = New System.Drawing.Size(200, 20)
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.TabIndex = 5
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPARTICIPANTE_AFBindingSource, "ESTADO", True))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(144, 86)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ESTADOTextBox.TabIndex = 7
        Me.ESTADOTextBox.MaxLength = 1
        '
        'FECHA_INSCRIPCIONDateTimePicker
        '
        Me.FECHA_INSCRIPCIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListaPARTICIPANTE_AFBindingSource, "FECHA_INSCRIPCION", True))
        Me.FECHA_INSCRIPCIONDateTimePicker.Location = New System.Drawing.Point(144, 112)
        Me.FECHA_INSCRIPCIONDateTimePicker.Name = "FECHA_INSCRIPCIONDateTimePicker"
        Me.FECHA_INSCRIPCIONDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_INSCRIPCIONDateTimePicker.TabIndex = 9
        '
        'NOTA_FINALTextBox
        '
        Me.NOTA_FINALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPARTICIPANTE_AFBindingSource, "NOTA_FINAL", True))
        Me.NOTA_FINALTextBox.Location = New System.Drawing.Point(144, 138)
        Me.NOTA_FINALTextBox.Name = "NOTA_FINALTextBox"
        Me.NOTA_FINALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTA_FINALTextBox.TabIndex = 11
        '
        'PORC_ASISTENCIATextBox
        '
        Me.PORC_ASISTENCIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPARTICIPANTE_AFBindingSource, "PORC_ASISTENCIA", True))
        Me.PORC_ASISTENCIATextBox.Location = New System.Drawing.Point(144, 164)
        Me.PORC_ASISTENCIATextBox.Name = "PORC_ASISTENCIATextBox"
        Me.PORC_ASISTENCIATextBox.Size = New System.Drawing.Size(200, 20)
        Me.PORC_ASISTENCIATextBox.TabIndex = 13
        '
        'ENTREGA_DIPLOMATextBox
        '
        Me.ENTREGA_DIPLOMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPARTICIPANTE_AFBindingSource, "ENTREGA_DIPLOMA", True))
        Me.ENTREGA_DIPLOMATextBox.Location = New System.Drawing.Point(144, 190)
        Me.ENTREGA_DIPLOMATextBox.Name = "ENTREGA_DIPLOMATextBox"
        Me.ENTREGA_DIPLOMATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ENTREGA_DIPLOMATextBox.TabIndex = 15
        Me.ENTREGA_DIPLOMATextBox.MaxLength = 1
        '
        'NOTASTextBox
        '
        Me.NOTASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaPARTICIPANTE_AFBindingSource, "NOTAS", True))
        Me.NOTASTextBox.Location = New System.Drawing.Point(144, 216)
        Me.NOTASTextBox.Name = "NOTASTextBox"
        Me.NOTASTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextBox.TabIndex = 17
        Me.NOTASTextBox.MaxLength = 255
        '
        'ucDetallePARTICIPANTE_AF
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_PARTICIPANTELabel)
        Me.Controls.Add(Me.ID_PARTICIPANTEcbxPARTICIPANTE)
        Me.Controls.Add(ID_ACCION_FORMATIVALabel)
        Me.Controls.Add(Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA)
        Me.Controls.Add(ID_SOLICITUDLabel)
        Me.Controls.Add(Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF)
        Me.Controls.Add(ESTADOLabel)
        Me.Controls.Add(Me.ESTADOTextBox)
        Me.Controls.Add(FECHA_INSCRIPCIONLabel)
        Me.Controls.Add(Me.FECHA_INSCRIPCIONDateTimePicker)
        Me.Controls.Add(NOTA_FINALLabel)
        Me.Controls.Add(Me.NOTA_FINALTextBox)
        Me.Controls.Add(PORC_ASISTENCIALabel)
        Me.Controls.Add(Me.PORC_ASISTENCIATextBox)
        Me.Controls.Add(ENTREGA_DIPLOMALabel)
        Me.Controls.Add(Me.ENTREGA_DIPLOMATextBox)
        Me.Controls.Add(NOTASLabel)
        Me.Controls.Add(Me.NOTASTextBox)
        Me.Name = "ucDetallePARTICIPANTE_AF"
        Me.Size = New System.Drawing.Size(382, 268)
        CType(Me.ListaPARTICIPANTE_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPARTICIPANTE_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_PARTICIPANTEcbxPARTICIPANTE As SGAFP.WinUC.cbxPARTICIPANTE
    Friend WithEvents ID_ACCION_FORMATIVAcbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA
    Friend WithEvents ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF As SGAFP.WinUC.cbxSOLICITUD_INSCRIPCION_AF
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECHA_INSCRIPCIONDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NOTA_FINALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PORC_ASISTENCIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ENTREGA_DIPLOMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOTASTextBox As System.Windows.Forms.TextBox

End Class
