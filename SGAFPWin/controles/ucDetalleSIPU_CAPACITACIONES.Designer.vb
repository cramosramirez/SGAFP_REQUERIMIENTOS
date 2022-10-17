<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSIPU_CAPACITACIONES
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
        Dim IDCAPACITACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim DESCRIPCIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim IDTIPOCAPACITACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim IDESTADOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHAINICIOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHAFINLabelControl As DevExpress.XtraEditors.LabelControl
        Dim IDMUNICIPIOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_GENERACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaSIPU_CAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDCAPACITACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.DESCRIPCIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES = New SGAFP.WinUC.cbxSIPU_TIPOCAPACITACIONES
        Me.IDESTADOSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHAINICIODateEdit = New DevExpress.XtraEditors.DateEdit
        Me.FECHAFINDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO = New SGAFP.WinUC.cbxSIPU_MUNICIPIO
        Me.ID_GENERACIONcbxSIPU_GENERACION = New SGAFP.WinUC.cbxSIPU_GENERACION
        IDCAPACITACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        DESCRIPCIONLabelControl = New DevExpress.XtraEditors.LabelControl
        IDTIPOCAPACITACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        IDESTADOLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHAINICIOLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHAFINLabelControl = New DevExpress.XtraEditors.LabelControl
        IDMUNICIPIOLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_GENERACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaSIPU_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDCAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDESTADOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHAINICIODateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHAFINDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDCAPACITACIONLabelControl
        '
        IDCAPACITACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        IDCAPACITACIONLabelControl.Name = "IDCAPACITACIONLabelControl"
        IDCAPACITACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        IDCAPACITACIONLabelControl.TabIndex = 0
        IDCAPACITACIONLabelControl.Text = "Idcapacitacion:"
        '
        'DESCRIPCIONLabelControl
        '
        DESCRIPCIONLabelControl.Location = New System.Drawing.Point(6, 40)
        DESCRIPCIONLabelControl.Name = "DESCRIPCIONLabelControl"
        DESCRIPCIONLabelControl.Size = New System.Drawing.Size(135, 13)
        DESCRIPCIONLabelControl.TabIndex = 2
        DESCRIPCIONLabelControl.Text = "Descripcion:"
        '
        'IDTIPOCAPACITACIONLabelControl
        '
        IDTIPOCAPACITACIONLabelControl.Location = New System.Drawing.Point(6, 66)
        IDTIPOCAPACITACIONLabelControl.Name = "IDTIPOCAPACITACIONLabelControl"
        IDTIPOCAPACITACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        IDTIPOCAPACITACIONLabelControl.TabIndex = 4
        IDTIPOCAPACITACIONLabelControl.Text = "Idtipocapacitacion:"
        '
        'IDESTADOLabelControl
        '
        IDESTADOLabelControl.Location = New System.Drawing.Point(6, 92)
        IDESTADOLabelControl.Name = "IDESTADOLabelControl"
        IDESTADOLabelControl.Size = New System.Drawing.Size(135, 13)
        IDESTADOLabelControl.TabIndex = 6
        IDESTADOLabelControl.Text = "Idestado:"
        '
        'FECHAINICIOLabelControl
        '
        FECHAINICIOLabelControl.Location = New System.Drawing.Point(6, 118)
        FECHAINICIOLabelControl.Name = "FECHAINICIOLabelControl"
        FECHAINICIOLabelControl.Size = New System.Drawing.Size(135, 13)
        FECHAINICIOLabelControl.TabIndex = 8
        FECHAINICIOLabelControl.Text = "Fechainicio:"
        '
        'FECHAFINLabelControl
        '
        FECHAFINLabelControl.Location = New System.Drawing.Point(6, 144)
        FECHAFINLabelControl.Name = "FECHAFINLabelControl"
        FECHAFINLabelControl.Size = New System.Drawing.Size(135, 13)
        FECHAFINLabelControl.TabIndex = 10
        FECHAFINLabelControl.Text = "Fechafin:"
        '
        'IDMUNICIPIOLabelControl
        '
        IDMUNICIPIOLabelControl.Location = New System.Drawing.Point(6, 170)
        IDMUNICIPIOLabelControl.Name = "IDMUNICIPIOLabelControl"
        IDMUNICIPIOLabelControl.Size = New System.Drawing.Size(135, 13)
        IDMUNICIPIOLabelControl.TabIndex = 12
        IDMUNICIPIOLabelControl.Text = "Idmunicipio:"
        '
        'ID_GENERACIONLabelControl
        '
        ID_GENERACIONLabelControl.Location = New System.Drawing.Point(6, 196)
        ID_GENERACIONLabelControl.Name = "ID_GENERACIONLabelControl"
        ID_GENERACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_GENERACIONLabelControl.TabIndex = 14
        ID_GENERACIONLabelControl.Text = "Id generacion:"
        '
        'ListaSIPU_CAPACITACIONESBindingSource
        '
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_CAPACITACIONES)
        '
        'IDCAPACITACIONTextEdit
        '
        Me.IDCAPACITACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.IDCAPACITACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "IDCAPACITACION", True))
        Me.IDCAPACITACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.IDCAPACITACIONTextEdit.Name = "IDCAPACITACIONTextBox"
        Me.IDCAPACITACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.IDCAPACITACIONTextEdit.TabIndex = 1
        '
        'DESCRIPCIONTextEdit
        '
        Me.DESCRIPCIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.DESCRIPCIONTextEdit.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCIONTextEdit.TabIndex = 3
        Me.DESCRIPCIONTextEdit.Properties.MaxLength = 400
        '
        'IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES
        '
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "IDTIPOCAPACITACION", True))
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.Location = New System.Drawing.Point(144, 60)
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.Name = "IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES"
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.Size = New System.Drawing.Size(200, 20)
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.TabIndex = 5
        '
        'IDESTADOSpinEdit
        '
        Me.IDESTADOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "IDESTADO", True))
        Me.IDESTADOSpinEdit.Location = New System.Drawing.Point(144, 86)
        Me.IDESTADOSpinEdit.Name = "IDESTADOSpinEdit"
        Me.IDESTADOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IDESTADOSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IDESTADOSpinEdit.TabIndex = 7
        '
        'FECHAINICIODateEdit
        '
        Me.FECHAINICIODateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "FECHAINICIO", True))
        Me.FECHAINICIODateEdit.EditValue = Nothing
        Me.FECHAINICIODateEdit.Location = New System.Drawing.Point(144, 112)
        Me.FECHAINICIODateEdit.Name = "FECHAINICIODateEdit"
        Me.FECHAINICIODateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHAINICIODateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FECHAINICIODateEdit.Size = New System.Drawing.Size(200, 20)
        Me.FECHAINICIODateEdit.TabIndex = 9
        '
        'FECHAFINDateEdit
        '
        Me.FECHAFINDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "FECHAFIN", True))
        Me.FECHAFINDateEdit.EditValue = Nothing
        Me.FECHAFINDateEdit.Location = New System.Drawing.Point(144, 138)
        Me.FECHAFINDateEdit.Name = "FECHAFINDateEdit"
        Me.FECHAFINDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHAFINDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FECHAFINDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.FECHAFINDateEdit.TabIndex = 11
        '
        'IDMUNICIPIOcbxSIPU_MUNICIPIO
        '
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "IDMUNICIPIO", True))
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.Location = New System.Drawing.Point(144, 164)
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.Name = "IDMUNICIPIOcbxSIPU_MUNICIPIO"
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.Size = New System.Drawing.Size(200, 20)
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.TabIndex = 13
        '
        'ID_GENERACIONcbxSIPU_GENERACION
        '
        Me.ID_GENERACIONcbxSIPU_GENERACION.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaSIPU_CAPACITACIONESBindingSource, "ID_GENERACION", True))
        Me.ID_GENERACIONcbxSIPU_GENERACION.Location = New System.Drawing.Point(144, 190)
        Me.ID_GENERACIONcbxSIPU_GENERACION.Name = "ID_GENERACIONcbxSIPU_GENERACION"
        Me.ID_GENERACIONcbxSIPU_GENERACION.Size = New System.Drawing.Size(200, 20)
        Me.ID_GENERACIONcbxSIPU_GENERACION.TabIndex = 15
        '
        'ucDetalleSIPU_CAPACITACIONES
        '
        Me.AutoScroll = True
        Me.Controls.Add(IDCAPACITACIONLabelControl)
        Me.Controls.Add(Me.IDCAPACITACIONTextEdit)
        Me.Controls.Add(DESCRIPCIONLabelControl)
        Me.Controls.Add(Me.DESCRIPCIONTextEdit)
        Me.Controls.Add(IDTIPOCAPACITACIONLabelControl)
        Me.Controls.Add(Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES)
        Me.Controls.Add(IDESTADOLabelControl)
        Me.Controls.Add(Me.IDESTADOSpinEdit)
        Me.Controls.Add(FECHAINICIOLabelControl)
        Me.Controls.Add(Me.FECHAINICIODateEdit)
        Me.Controls.Add(FECHAFINLabelControl)
        Me.Controls.Add(Me.FECHAFINDateEdit)
        Me.Controls.Add(IDMUNICIPIOLabelControl)
        Me.Controls.Add(Me.IDMUNICIPIOcbxSIPU_MUNICIPIO)
        Me.Controls.Add(ID_GENERACIONLabelControl)
        Me.Controls.Add(Me.ID_GENERACIONcbxSIPU_GENERACION)
        Me.Name = "ucDetalleSIPU_CAPACITACIONES"
        Me.Size = New System.Drawing.Size(382, 242)
        CType(Me.ListaSIPU_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDCAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDESTADOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHAINICIODateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHAFINDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_CAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDCAPACITACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DESCRIPCIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES As SGAFP.WinUC.cbxSIPU_TIPOCAPACITACIONES
    Friend WithEvents IDESTADOSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHAINICIODateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FECHAFINDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IDMUNICIPIOcbxSIPU_MUNICIPIO As SGAFP.WinUC.cbxSIPU_MUNICIPIO
    Friend WithEvents ID_GENERACIONcbxSIPU_GENERACION As SGAFP.WinUC.cbxSIPU_GENERACION

End Class
