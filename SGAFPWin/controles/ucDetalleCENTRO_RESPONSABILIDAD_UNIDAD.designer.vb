<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD
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
        Dim ID_CENTRO_RESPONSABILIDADLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_UNIDAD_ORGANIZATIVALabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD = New SGAFP.WinUC.cbxCENTRO_RESPONSABILIDAD
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_CENTRO_RESPONSABILIDADLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_UNIDAD_ORGANIZATIVALabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CENTRO_RESPONSABILIDADLabelControl
        '
        ID_CENTRO_RESPONSABILIDADLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_CENTRO_RESPONSABILIDADLabelControl.Name = "ID_CENTRO_RESPONSABILIDADLabelControl"
        ID_CENTRO_RESPONSABILIDADLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_CENTRO_RESPONSABILIDADLabelControl.TabIndex = 0
        ID_CENTRO_RESPONSABILIDADLabelControl.Text = "Id centro responsabilidad:"
        '
        'ID_UNIDAD_ORGANIZATIVALabelControl
        '
        ID_UNIDAD_ORGANIZATIVALabelControl.Location = New System.Drawing.Point(6, 40)
        ID_UNIDAD_ORGANIZATIVALabelControl.Name = "ID_UNIDAD_ORGANIZATIVALabelControl"
        ID_UNIDAD_ORGANIZATIVALabelControl.Size = New System.Drawing.Size(135, 13)
        ID_UNIDAD_ORGANIZATIVALabelControl.TabIndex = 2
        ID_UNIDAD_ORGANIZATIVALabelControl.Text = "Id unidad organizativa:"
        '
        'USERIDLabelControl
        '
        USERIDLabelControl.Location = New System.Drawing.Point(6, 66)
        USERIDLabelControl.Name = "USERIDLabelControl"
        USERIDLabelControl.Size = New System.Drawing.Size(135, 13)
        USERIDLabelControl.TabIndex = 4
        USERIDLabelControl.Text = "Userid:"
        '
        'LASTUPDATELabelControl
        '
        LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 92)
        LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        LASTUPDATELabelControl.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabelControl.TabIndex = 6
        LASTUPDATELabelControl.Text = "Lastupdate:"
        '
        'ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource
        '
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.DataSource = GetType(SGAFP.EL.CENTRO_RESPONSABILIDAD_UNIDAD)
        '
        'ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD
        '
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, "ID_CENTRO_RESPONSABILIDAD", True))
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Location = New System.Drawing.Point(144, 8)
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Name = "ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD"
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Size = New System.Drawing.Size(200, 20)
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.TabIndex = 1
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.BackColor = System.Drawing.Color.Linen
        Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD.Enabled = False
        '
        'ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA
        '
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, "ID_UNIDAD_ORGANIZATIVA", True))
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Location = New System.Drawing.Point(144, 34)
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Name = "ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA"
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.TabIndex = 3
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.BackColor = System.Drawing.Color.Linen
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Enabled = False
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 5
        Me.USERIDTextEdit.Properties.MaxLength = 256
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 7
        '
        'ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_CENTRO_RESPONSABILIDADLabelControl)
        Me.Controls.Add(Me.ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD)
        Me.Controls.Add(ID_UNIDAD_ORGANIZATIVALabelControl)
        Me.Controls.Add(Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_CENTRO_RESPONSABILIDADcbxCENTRO_RESPONSABILIDAD As SGAFP.WinUC.cbxCENTRO_RESPONSABILIDAD
    Friend WithEvents ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
