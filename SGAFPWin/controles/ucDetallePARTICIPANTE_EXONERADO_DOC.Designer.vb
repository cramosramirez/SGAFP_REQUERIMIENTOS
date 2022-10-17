<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePARTICIPANTE_EXONERADO_DOC
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
        Dim ID_PARTICIPANTELabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE = New SGAFP.WinUC.cbxPARTICIPANTE
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_PARTICIPANTELabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PARTICIPANTELabelControl
        '
        ID_PARTICIPANTELabelControl.Location = New System.Drawing.Point(6, 14)
        ID_PARTICIPANTELabelControl.Name = "ID_PARTICIPANTELabelControl"
        ID_PARTICIPANTELabelControl.Size = New System.Drawing.Size(135, 13)
        ID_PARTICIPANTELabelControl.TabIndex = 0
        ID_PARTICIPANTELabelControl.Text = "Id participante:"
        '
        'USERIDLabelControl
        '
        USERIDLabelControl.Location = New System.Drawing.Point(6, 40)
        USERIDLabelControl.Name = "USERIDLabelControl"
        USERIDLabelControl.Size = New System.Drawing.Size(135, 13)
        USERIDLabelControl.TabIndex = 2
        USERIDLabelControl.Text = "Userid:"
        '
        'LASTUPDATELabelControl
        '
        LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 66)
        LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        LASTUPDATELabelControl.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabelControl.TabIndex = 4
        LASTUPDATELabelControl.Text = "Lastupdate:"
        '
        'ListaPARTICIPANTE_EXONERADO_DOCBindingSource
        '
        Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE_EXONERADO_DOC)
        '
        'ID_PARTICIPANTEcbxPARTICIPANTE
        '
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, "ID_PARTICIPANTE", True))
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Location = New System.Drawing.Point(144, 8)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Name = "ID_PARTICIPANTEcbxPARTICIPANTE"
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Size = New System.Drawing.Size(200, 20)
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.TabIndex = 1
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.BackColor = System.Drawing.Color.Linen
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Enabled = False
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 3
        Me.USERIDTextEdit.Properties.MaxLength = 256
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 60)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 5
        '
        'ucDetallePARTICIPANTE_EXONERADO_DOC
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_PARTICIPANTELabelControl)
        Me.Controls.Add(Me.ID_PARTICIPANTEcbxPARTICIPANTE)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetallePARTICIPANTE_EXONERADO_DOC"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaPARTICIPANTE_EXONERADO_DOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPARTICIPANTE_EXONERADO_DOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_PARTICIPANTEcbxPARTICIPANTE As SGAFP.WinUC.cbxPARTICIPANTE
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
