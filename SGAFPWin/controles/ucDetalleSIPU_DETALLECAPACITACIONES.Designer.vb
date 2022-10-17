<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSIPU_DETALLECAPACITACIONES
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
        Dim IDDETALLECAPACITACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_CAPACITACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim CONVENIOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ESTADOLabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDETALLECAPACITACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES = New SGAFP.WinUC.cbxSIPU_CAPACITACIONES
        Me.CONVENIOSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ESTADOTextEdit = New DevExpress.XtraEditors.TextEdit
        IDDETALLECAPACITACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_CAPACITACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        CONVENIOLabelControl = New DevExpress.XtraEditors.LabelControl
        ESTADOLabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDDETALLECAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONVENIOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDDETALLECAPACITACIONLabelControl
        '
        IDDETALLECAPACITACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        IDDETALLECAPACITACIONLabelControl.Name = "IDDETALLECAPACITACIONLabelControl"
        IDDETALLECAPACITACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        IDDETALLECAPACITACIONLabelControl.TabIndex = 0
        IDDETALLECAPACITACIONLabelControl.Text = "Iddetallecapacitacion:"
        '
        'ID_CAPACITACIONLabelControl
        '
        ID_CAPACITACIONLabelControl.Location = New System.Drawing.Point(6, 40)
        ID_CAPACITACIONLabelControl.Name = "ID_CAPACITACIONLabelControl"
        ID_CAPACITACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_CAPACITACIONLabelControl.TabIndex = 2
        ID_CAPACITACIONLabelControl.Text = "Id capacitacion:"
        '
        'CONVENIOLabelControl
        '
        CONVENIOLabelControl.Location = New System.Drawing.Point(6, 66)
        CONVENIOLabelControl.Name = "CONVENIOLabelControl"
        CONVENIOLabelControl.Size = New System.Drawing.Size(135, 13)
        CONVENIOLabelControl.TabIndex = 4
        CONVENIOLabelControl.Text = "Convenio:"
        '
        'ESTADOLabelControl
        '
        ESTADOLabelControl.Location = New System.Drawing.Point(6, 92)
        ESTADOLabelControl.Name = "ESTADOLabelControl"
        ESTADOLabelControl.Size = New System.Drawing.Size(135, 13)
        ESTADOLabelControl.TabIndex = 6
        ESTADOLabelControl.Text = "Estado:"
        '
        'ListaSIPU_DETALLECAPACITACIONESBindingSource
        '
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_DETALLECAPACITADO)
        '
        'IDDETALLECAPACITACIONTextEdit
        '
        Me.IDDETALLECAPACITACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.IDDETALLECAPACITACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, "IDDETALLECAPACITACION", True))
        Me.IDDETALLECAPACITACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.IDDETALLECAPACITACIONTextEdit.Name = "IDDETALLECAPACITACIONTextBox"
        Me.IDDETALLECAPACITACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.IDDETALLECAPACITACIONTextEdit.TabIndex = 1
        '
        'ID_CAPACITACIONcbxSIPU_CAPACITACIONES
        '
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, "ID_CAPACITACION", True))
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.Location = New System.Drawing.Point(144, 34)
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.Name = "ID_CAPACITACIONcbxSIPU_CAPACITACIONES"
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.Size = New System.Drawing.Size(200, 20)
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.TabIndex = 3
        '
        'CONVENIOSpinEdit
        '
        Me.CONVENIOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, "CONVENIO", True))
        Me.CONVENIOSpinEdit.Location = New System.Drawing.Point(144, 60)
        Me.CONVENIOSpinEdit.Name = "CONVENIOSpinEdit"
        Me.CONVENIOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CONVENIOSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CONVENIOSpinEdit.TabIndex = 5
        '
        'ESTADOTextEdit
        '
        Me.ESTADOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, "ESTADO", True))
        Me.ESTADOTextEdit.Location = New System.Drawing.Point(144, 86)
        Me.ESTADOTextEdit.Name = "ESTADOTextBox"
        Me.ESTADOTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ESTADOTextEdit.TabIndex = 7
        Me.ESTADOTextEdit.Properties.MaxLength = 1
        '
        'ucDetalleSIPU_DETALLECAPACITACIONES
        '
        Me.AutoScroll = True
        Me.Controls.Add(IDDETALLECAPACITACIONLabelControl)
        Me.Controls.Add(Me.IDDETALLECAPACITACIONTextEdit)
        Me.Controls.Add(ID_CAPACITACIONLabelControl)
        Me.Controls.Add(Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES)
        Me.Controls.Add(CONVENIOLabelControl)
        Me.Controls.Add(Me.CONVENIOSpinEdit)
        Me.Controls.Add(ESTADOLabelControl)
        Me.Controls.Add(Me.ESTADOTextEdit)
        Me.Name = "ucDetalleSIPU_DETALLECAPACITACIONES"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDDETALLECAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONVENIOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_DETALLECAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDETALLECAPACITACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ID_CAPACITACIONcbxSIPU_CAPACITACIONES As SGAFP.WinUC.cbxSIPU_CAPACITACIONES
    Friend WithEvents CONVENIOSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ESTADOTextEdit As DevExpress.XtraEditors.TextEdit

End Class
