<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleUNIDAD_ORGANIZATIVA
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
        Dim ID_UNIDAD_ORGANIZATIVALabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOMBRE_UNIDADLabelControl As DevExpress.XtraEditors.LabelControl
        Dim CODIGO_UNIDADLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_UNIDAD_PADRELabelControl As DevExpress.XtraEditors.LabelControl
        Dim ESTADOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaUNIDAD_ORGANIZATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_UNIDAD_ORGANIZATIVATextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NOMBRE_UNIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_UNIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
        Me.ESTADOSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_UNIDAD_ORGANIZATIVALabelControl = New DevExpress.XtraEditors.LabelControl
        NOMBRE_UNIDADLabelControl = New DevExpress.XtraEditors.LabelControl
        CODIGO_UNIDADLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_UNIDAD_PADRELabelControl = New DevExpress.XtraEditors.LabelControl
        ESTADOLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_UNIDAD_ORGANIZATIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRE_UNIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_UNIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_UNIDAD_ORGANIZATIVALabelControl
        '
        ID_UNIDAD_ORGANIZATIVALabelControl.Location = New System.Drawing.Point(6, 14)
        ID_UNIDAD_ORGANIZATIVALabelControl.Name = "ID_UNIDAD_ORGANIZATIVALabelControl"
        ID_UNIDAD_ORGANIZATIVALabelControl.Size = New System.Drawing.Size(135, 13)
        ID_UNIDAD_ORGANIZATIVALabelControl.TabIndex = 0
        ID_UNIDAD_ORGANIZATIVALabelControl.Text = "Id unidad organizativa:"
        '
        'NOMBRE_UNIDADLabelControl
        '
        NOMBRE_UNIDADLabelControl.Location = New System.Drawing.Point(6, 40)
        NOMBRE_UNIDADLabelControl.Name = "NOMBRE_UNIDADLabelControl"
        NOMBRE_UNIDADLabelControl.Size = New System.Drawing.Size(135, 13)
        NOMBRE_UNIDADLabelControl.TabIndex = 2
        NOMBRE_UNIDADLabelControl.Text = "Nombre unidad:"
        '
        'CODIGO_UNIDADLabelControl
        '
        CODIGO_UNIDADLabelControl.Location = New System.Drawing.Point(6, 66)
        CODIGO_UNIDADLabelControl.Name = "CODIGO_UNIDADLabelControl"
        CODIGO_UNIDADLabelControl.Size = New System.Drawing.Size(135, 13)
        CODIGO_UNIDADLabelControl.TabIndex = 4
        CODIGO_UNIDADLabelControl.Text = "Codigo unidad:"
        '
        'ID_UNIDAD_PADRELabelControl
        '
        ID_UNIDAD_PADRELabelControl.Location = New System.Drawing.Point(6, 92)
        ID_UNIDAD_PADRELabelControl.Name = "ID_UNIDAD_PADRELabelControl"
        ID_UNIDAD_PADRELabelControl.Size = New System.Drawing.Size(135, 13)
        ID_UNIDAD_PADRELabelControl.TabIndex = 6
        ID_UNIDAD_PADRELabelControl.Text = "Id unidad padre:"
        '
        'ESTADOLabelControl
        '
        ESTADOLabelControl.Location = New System.Drawing.Point(6, 118)
        ESTADOLabelControl.Name = "ESTADOLabelControl"
        ESTADOLabelControl.Size = New System.Drawing.Size(135, 13)
        ESTADOLabelControl.TabIndex = 8
        ESTADOLabelControl.Text = "Estado:"
        '
        'USERIDLabelControl
        '
        USERIDLabelControl.Location = New System.Drawing.Point(6, 144)
        USERIDLabelControl.Name = "USERIDLabelControl"
        USERIDLabelControl.Size = New System.Drawing.Size(135, 13)
        USERIDLabelControl.TabIndex = 10
        USERIDLabelControl.Text = "Userid:"
        '
        'LASTUPDATELabelControl
        '
        LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 170)
        LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        LASTUPDATELabelControl.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabelControl.TabIndex = 12
        LASTUPDATELabelControl.Text = "Lastupdate:"
        '
        'ListaUNIDAD_ORGANIZATIVABindingSource
        '
        Me.ListaUNIDAD_ORGANIZATIVABindingSource.DataSource = GetType(SGAFP.EL.UNIDAD_ORGANIZATIVA)
        '
        'ID_UNIDAD_ORGANIZATIVATextEdit
        '
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "ID_UNIDAD_ORGANIZATIVA", True))
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.Name = "ID_UNIDAD_ORGANIZATIVATextBox"
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_UNIDAD_ORGANIZATIVATextEdit.TabIndex = 1
        '
        'NOMBRE_UNIDADTextEdit
        '
        Me.NOMBRE_UNIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "NOMBRE_UNIDAD", True))
        Me.NOMBRE_UNIDADTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRE_UNIDADTextEdit.Name = "NOMBRE_UNIDADTextBox"
        Me.NOMBRE_UNIDADTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_UNIDADTextEdit.TabIndex = 3
        Me.NOMBRE_UNIDADTextEdit.Properties.MaxLength = 75
        '
        'CODIGO_UNIDADTextEdit
        '
        Me.CODIGO_UNIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "CODIGO_UNIDAD", True))
        Me.CODIGO_UNIDADTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.CODIGO_UNIDADTextEdit.Name = "CODIGO_UNIDADTextBox"
        Me.CODIGO_UNIDADTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.CODIGO_UNIDADTextEdit.TabIndex = 5
        Me.CODIGO_UNIDADTextEdit.Properties.MaxLength = 6
        '
        'ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA
        '
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "ID_UNIDAD_PADRE", True))
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.Location = New System.Drawing.Point(144, 86)
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.Name = "ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA"
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA.TabIndex = 7
        '
        'ESTADOSpinEdit
        '
        Me.ESTADOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "ESTADO", True))
        Me.ESTADOSpinEdit.Location = New System.Drawing.Point(144, 112)
        Me.ESTADOSpinEdit.Name = "ESTADOSpinEdit"
        Me.ESTADOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ESTADOSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ESTADOSpinEdit.TabIndex = 9
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 138)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 11
        Me.USERIDTextEdit.Properties.MaxLength = 256
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUNIDAD_ORGANIZATIVABindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 164)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 13
        '
        'ucDetalleUNIDAD_ORGANIZATIVA
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_UNIDAD_ORGANIZATIVALabelControl)
        Me.Controls.Add(Me.ID_UNIDAD_ORGANIZATIVATextEdit)
        Me.Controls.Add(NOMBRE_UNIDADLabelControl)
        Me.Controls.Add(Me.NOMBRE_UNIDADTextEdit)
        Me.Controls.Add(CODIGO_UNIDADLabelControl)
        Me.Controls.Add(Me.CODIGO_UNIDADTextEdit)
        Me.Controls.Add(ID_UNIDAD_PADRELabelControl)
        Me.Controls.Add(Me.ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA)
        Me.Controls.Add(ESTADOLabelControl)
        Me.Controls.Add(Me.ESTADOSpinEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetalleUNIDAD_ORGANIZATIVA"
        Me.Size = New System.Drawing.Size(382, 216)
        CType(Me.ListaUNIDAD_ORGANIZATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_UNIDAD_ORGANIZATIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRE_UNIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_UNIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaUNIDAD_ORGANIZATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_UNIDAD_ORGANIZATIVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOMBRE_UNIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_UNIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ID_UNIDAD_PADREcbxUNIDAD_ORGANIZATIVA As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
    Friend WithEvents ESTADOSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
