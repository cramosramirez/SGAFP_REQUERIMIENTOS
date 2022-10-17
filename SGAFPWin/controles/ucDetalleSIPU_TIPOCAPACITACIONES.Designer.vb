<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleSIPU_TIPOCAPACITACIONES
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
        Dim IDTIPOCAPACITACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim DESCRIPCIONLabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTIPOCAPACITACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.DESCRIPCIONTextEdit = New DevExpress.XtraEditors.TextEdit
        IDTIPOCAPACITACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        DESCRIPCIONLabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTIPOCAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTIPOCAPACITACIONLabelControl
        '
        IDTIPOCAPACITACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        IDTIPOCAPACITACIONLabelControl.Name = "IDTIPOCAPACITACIONLabelControl"
        IDTIPOCAPACITACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        IDTIPOCAPACITACIONLabelControl.TabIndex = 0
        IDTIPOCAPACITACIONLabelControl.Text = "Idtipocapacitacion:"
        '
        'DESCRIPCIONLabelControl
        '
        DESCRIPCIONLabelControl.Location = New System.Drawing.Point(6, 40)
        DESCRIPCIONLabelControl.Name = "DESCRIPCIONLabelControl"
        DESCRIPCIONLabelControl.Size = New System.Drawing.Size(135, 13)
        DESCRIPCIONLabelControl.TabIndex = 2
        DESCRIPCIONLabelControl.Text = "Descripcion:"
        '
        'ListaSIPU_TIPOCAPACITACIONESBindingSource
        '
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_TIPOCAPACITACIONES)
        '
        'IDTIPOCAPACITACIONTextEdit
        '
        Me.IDTIPOCAPACITACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.IDTIPOCAPACITACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, "IDTIPOCAPACITACION", True))
        Me.IDTIPOCAPACITACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.IDTIPOCAPACITACIONTextEdit.Name = "IDTIPOCAPACITACIONTextBox"
        Me.IDTIPOCAPACITACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.IDTIPOCAPACITACIONTextEdit.TabIndex = 1
        '
        'DESCRIPCIONTextEdit
        '
        Me.DESCRIPCIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.DESCRIPCIONTextEdit.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.DESCRIPCIONTextEdit.TabIndex = 3
        Me.DESCRIPCIONTextEdit.Properties.MaxLength = 50
        '
        'ucDetalleSIPU_TIPOCAPACITACIONES
        '
        Me.AutoScroll = True
        Me.Controls.Add(IDTIPOCAPACITACIONLabelControl)
        Me.Controls.Add(Me.IDTIPOCAPACITACIONTextEdit)
        Me.Controls.Add(DESCRIPCIONLabelControl)
        Me.Controls.Add(Me.DESCRIPCIONTextEdit)
        Me.Name = "ucDetalleSIPU_TIPOCAPACITACIONES"
        Me.Size = New System.Drawing.Size(382, 86)
        CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTIPOCAPACITACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_TIPOCAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDTIPOCAPACITACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DESCRIPCIONTextEdit As DevExpress.XtraEditors.TextEdit

End Class
