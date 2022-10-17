<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSIPU_GENERACION
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
        Dim ID_GENERACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHALabelControl As DevExpress.XtraEditors.LabelControl
        Dim FUENTELabelControl As DevExpress.XtraEditors.LabelControl
        Dim NUMERO_CONVOCATORIALabelControl As DevExpress.XtraEditors.LabelControl
        Dim USUARIO_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHA_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaSIPU_GENERACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_GENERACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHADateEdit = New DevExpress.XtraEditors.DateEdit
        Me.FUENTESpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.NUMERO_CONVOCATORIASpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.USUARIO_CREACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_CREACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_GENERACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHALabelControl = New DevExpress.XtraEditors.LabelControl
        FUENTELabelControl = New DevExpress.XtraEditors.LabelControl
        NUMERO_CONVOCATORIALabelControl = New DevExpress.XtraEditors.LabelControl
        USUARIO_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHA_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaSIPU_GENERACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_GENERACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHADateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUENTESpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUMERO_CONVOCATORIASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_GENERACIONLabelControl
        '
        ID_GENERACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_GENERACIONLabelControl.Name = "ID_GENERACIONLabelControl"
        ID_GENERACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_GENERACIONLabelControl.TabIndex = 0
        ID_GENERACIONLabelControl.Text = "Id generacion:"
        '
        'FECHALabelControl
        '
        FECHALabelControl.Location = New System.Drawing.Point(6, 40)
        FECHALabelControl.Name = "FECHALabelControl"
        FECHALabelControl.Size = New System.Drawing.Size(135, 13)
        FECHALabelControl.TabIndex = 2
        FECHALabelControl.Text = "Fecha:"
        '
        'FUENTELabelControl
        '
        FUENTELabelControl.Location = New System.Drawing.Point(6, 66)
        FUENTELabelControl.Name = "FUENTELabelControl"
        FUENTELabelControl.Size = New System.Drawing.Size(135, 13)
        FUENTELabelControl.TabIndex = 4
        FUENTELabelControl.Text = "Fuente:"
        '
        'NUMERO_CONVOCATORIALabelControl
        '
        NUMERO_CONVOCATORIALabelControl.Location = New System.Drawing.Point(6, 92)
        NUMERO_CONVOCATORIALabelControl.Name = "NUMERO_CONVOCATORIALabelControl"
        NUMERO_CONVOCATORIALabelControl.Size = New System.Drawing.Size(135, 13)
        NUMERO_CONVOCATORIALabelControl.TabIndex = 6
        NUMERO_CONVOCATORIALabelControl.Text = "Numero convocatoria:"
        '
        'USUARIO_CREACIONLabelControl
        '
        USUARIO_CREACIONLabelControl.Location = New System.Drawing.Point(6, 118)
        USUARIO_CREACIONLabelControl.Name = "USUARIO_CREACIONLabelControl"
        USUARIO_CREACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        USUARIO_CREACIONLabelControl.TabIndex = 8
        USUARIO_CREACIONLabelControl.Text = "Usuario creacion:"
        '
        'FECHA_CREACIONLabelControl
        '
        FECHA_CREACIONLabelControl.Location = New System.Drawing.Point(6, 144)
        FECHA_CREACIONLabelControl.Name = "FECHA_CREACIONLabelControl"
        FECHA_CREACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        FECHA_CREACIONLabelControl.TabIndex = 10
        FECHA_CREACIONLabelControl.Text = "Fecha creacion:"
        '
        'USERIDLabelControl
        '
        USERIDLabelControl.Location = New System.Drawing.Point(6, 170)
        USERIDLabelControl.Name = "USERIDLabelControl"
        USERIDLabelControl.Size = New System.Drawing.Size(135, 13)
        USERIDLabelControl.TabIndex = 12
        USERIDLabelControl.Text = "Userid:"
        '
        'LASTUPDATELabelControl
        '
        LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 196)
        LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        LASTUPDATELabelControl.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabelControl.TabIndex = 14
        LASTUPDATELabelControl.Text = "Lastupdate:"
        '
        'ListaSIPU_GENERACIONBindingSource
        '
        Me.ListaSIPU_GENERACIONBindingSource.DataSource = GetType(SGAFP.EL.SIPU_GENERACION)
        '
        'ID_GENERACIONTextEdit
        '
        Me.ID_GENERACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_GENERACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "ID_GENERACION", True))
        Me.ID_GENERACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_GENERACIONTextEdit.Name = "ID_GENERACIONTextBox"
        Me.ID_GENERACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_GENERACIONTextEdit.TabIndex = 1
        '
        'FECHADateEdit
        '
        Me.FECHADateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "FECHA", True))
        Me.FECHADateEdit.EditValue = Nothing
        Me.FECHADateEdit.Location = New System.Drawing.Point(144, 34)
        Me.FECHADateEdit.Name = "FECHADateEdit"
        Me.FECHADateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHADateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FECHADateEdit.Size = New System.Drawing.Size(200, 20)
        Me.FECHADateEdit.TabIndex = 3
        '
        'FUENTESpinEdit
        '
        Me.FUENTESpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "FUENTE", True))
        Me.FUENTESpinEdit.Location = New System.Drawing.Point(144, 60)
        Me.FUENTESpinEdit.Name = "FUENTESpinEdit"
        Me.FUENTESpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FUENTESpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.FUENTESpinEdit.TabIndex = 5
        '
        'NUMERO_CONVOCATORIASpinEdit
        '
        Me.NUMERO_CONVOCATORIASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "NUMERO_CONVOCATORIA", True))
        Me.NUMERO_CONVOCATORIASpinEdit.Location = New System.Drawing.Point(144, 86)
        Me.NUMERO_CONVOCATORIASpinEdit.Name = "NUMERO_CONVOCATORIASpinEdit"
        Me.NUMERO_CONVOCATORIASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NUMERO_CONVOCATORIASpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.NUMERO_CONVOCATORIASpinEdit.TabIndex = 7
        '
        'USUARIO_CREACIONTextEdit
        '
        Me.USUARIO_CREACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "USUARIO_CREACION", True))
        Me.USUARIO_CREACIONTextEdit.Location = New System.Drawing.Point(144, 112)
        Me.USUARIO_CREACIONTextEdit.Name = "USUARIO_CREACIONTextBox"
        Me.USUARIO_CREACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USUARIO_CREACIONTextEdit.TabIndex = 9
        Me.USUARIO_CREACIONTextEdit.Properties.MaxLength = 250
        '
        'FECHA_CREACIONDateEdit
        '
        Me.FECHA_CREACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "FECHA_CREACION", True))
        Me.FECHA_CREACIONDateEdit.EditValue = Nothing
        Me.FECHA_CREACIONDateEdit.Location = New System.Drawing.Point(144, 138)
        Me.FECHA_CREACIONDateEdit.Name = "FECHA_CREACIONDateEdit"
        Me.FECHA_CREACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_CREACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FECHA_CREACIONDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_CREACIONDateEdit.TabIndex = 11
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 164)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 13
        Me.USERIDTextEdit.Properties.MaxLength = 250
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_GENERACIONBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 190)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 15
        '
        'ucDetalleSIPU_GENERACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_GENERACIONLabelControl)
        Me.Controls.Add(Me.ID_GENERACIONTextEdit)
        Me.Controls.Add(FECHALabelControl)
        Me.Controls.Add(Me.FECHADateEdit)
        Me.Controls.Add(FUENTELabelControl)
        Me.Controls.Add(Me.FUENTESpinEdit)
        Me.Controls.Add(NUMERO_CONVOCATORIALabelControl)
        Me.Controls.Add(Me.NUMERO_CONVOCATORIASpinEdit)
        Me.Controls.Add(USUARIO_CREACIONLabelControl)
        Me.Controls.Add(Me.USUARIO_CREACIONTextEdit)
        Me.Controls.Add(FECHA_CREACIONLabelControl)
        Me.Controls.Add(Me.FECHA_CREACIONDateEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetalleSIPU_GENERACION"
        Me.Size = New System.Drawing.Size(382, 242)
        CType(Me.ListaSIPU_GENERACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_GENERACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHADateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUENTESpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUMERO_CONVOCATORIASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_GENERACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_GENERACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHADateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FUENTESpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NUMERO_CONVOCATORIASpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents USUARIO_CREACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_CREACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
