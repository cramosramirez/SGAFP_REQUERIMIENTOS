<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleGRUPO_ACCION_CONTRATADA
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
        Dim ID_GRUPO_ACCIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_ACCION_CONTRATADALabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_GRUPO_AFLabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_ACCION_FORMATIVALabelControl As DevExpress.XtraEditors.LabelControl
        Dim USUARIO_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHA_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_GRUPO_ACCIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA = New SGAFP.WinUC.cbxACCION_CONTRATADA
        Me.ID_GRUPO_AFSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.USUARIO_CREACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_CREACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_GRUPO_ACCIONLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_ACCION_CONTRATADALabelControl = New DevExpress.XtraEditors.LabelControl
        ID_GRUPO_AFLabelControl = New DevExpress.XtraEditors.LabelControl
        ID_ACCION_FORMATIVALabelControl = New DevExpress.XtraEditors.LabelControl
        USUARIO_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHA_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_GRUPO_ACCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_GRUPO_AFSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_GRUPO_ACCIONLabelControl
        '
        ID_GRUPO_ACCIONLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_GRUPO_ACCIONLabelControl.Name = "ID_GRUPO_ACCIONLabelControl"
        ID_GRUPO_ACCIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_GRUPO_ACCIONLabelControl.TabIndex = 0
        ID_GRUPO_ACCIONLabelControl.Text = "Id grupo accion:"
        '
        'ID_ACCION_CONTRATADALabelControl
        '
        ID_ACCION_CONTRATADALabelControl.Location = New System.Drawing.Point(6, 40)
        ID_ACCION_CONTRATADALabelControl.Name = "ID_ACCION_CONTRATADALabelControl"
        ID_ACCION_CONTRATADALabelControl.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_CONTRATADALabelControl.TabIndex = 2
        ID_ACCION_CONTRATADALabelControl.Text = "Id accion contratada:"
        '
        'ID_GRUPO_AFLabelControl
        '
        ID_GRUPO_AFLabelControl.Location = New System.Drawing.Point(6, 66)
        ID_GRUPO_AFLabelControl.Name = "ID_GRUPO_AFLabelControl"
        ID_GRUPO_AFLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_GRUPO_AFLabelControl.TabIndex = 4
        ID_GRUPO_AFLabelControl.Text = "Id grupo af:"
        '
        'ID_ACCION_FORMATIVALabelControl
        '
        ID_ACCION_FORMATIVALabelControl.Location = New System.Drawing.Point(6, 92)
        ID_ACCION_FORMATIVALabelControl.Name = "ID_ACCION_FORMATIVALabelControl"
        ID_ACCION_FORMATIVALabelControl.Size = New System.Drawing.Size(135, 13)
        ID_ACCION_FORMATIVALabelControl.TabIndex = 6
        ID_ACCION_FORMATIVALabelControl.Text = "Id accion formativa:"
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
        'ListaGRUPO_ACCION_CONTRATADABindingSource
        '
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.DataSource = GetType(SGAFP.EL.GRUPO_ACCION_CONTRATADA)
        '
        'ID_GRUPO_ACCIONTextEdit
        '
        Me.ID_GRUPO_ACCIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_GRUPO_ACCIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "ID_GRUPO_ACCION", True))
        Me.ID_GRUPO_ACCIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_GRUPO_ACCIONTextEdit.Name = "ID_GRUPO_ACCIONTextBox"
        Me.ID_GRUPO_ACCIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_GRUPO_ACCIONTextEdit.TabIndex = 1
        '
        'ID_ACCION_CONTRATADAcbxACCION_CONTRATADA
        '
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "ID_ACCION_CONTRATADA", True))
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.Location = New System.Drawing.Point(144, 34)
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.Name = "ID_ACCION_CONTRATADAcbxACCION_CONTRATADA"
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA.TabIndex = 3
        '
        'ID_GRUPO_AFSpinEdit
        '
        Me.ID_GRUPO_AFSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "ID_GRUPO_AF", True))
        Me.ID_GRUPO_AFSpinEdit.Location = New System.Drawing.Point(144, 60)
        Me.ID_GRUPO_AFSpinEdit.Name = "ID_GRUPO_AFSpinEdit"
        Me.ID_GRUPO_AFSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ID_GRUPO_AFSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ID_GRUPO_AFSpinEdit.TabIndex = 5
        '
        'ID_ACCION_FORMATIVAcbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "ID_ACCION_FORMATIVA", True))
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Location = New System.Drawing.Point(144, 86)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVAcbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Size = New System.Drawing.Size(200, 20)
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.TabIndex = 7
        '
        'USUARIO_CREACIONTextEdit
        '
        Me.USUARIO_CREACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "USUARIO_CREACION", True))
        Me.USUARIO_CREACIONTextEdit.Location = New System.Drawing.Point(144, 112)
        Me.USUARIO_CREACIONTextEdit.Name = "USUARIO_CREACIONTextBox"
        Me.USUARIO_CREACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USUARIO_CREACIONTextEdit.TabIndex = 9
        Me.USUARIO_CREACIONTextEdit.Properties.MaxLength = 255
        '
        'FECHA_CREACIONDateEdit
        '
        Me.FECHA_CREACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "FECHA_CREACION", True))
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
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 164)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 13
        Me.USERIDTextEdit.Properties.MaxLength = 255
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaGRUPO_ACCION_CONTRATADABindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 190)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 15
        '
        'ucDetalleGRUPO_ACCION_CONTRATADA
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_GRUPO_ACCIONLabelControl)
        Me.Controls.Add(Me.ID_GRUPO_ACCIONTextEdit)
        Me.Controls.Add(ID_ACCION_CONTRATADALabelControl)
        Me.Controls.Add(Me.ID_ACCION_CONTRATADAcbxACCION_CONTRATADA)
        Me.Controls.Add(ID_GRUPO_AFLabelControl)
        Me.Controls.Add(Me.ID_GRUPO_AFSpinEdit)
        Me.Controls.Add(ID_ACCION_FORMATIVALabelControl)
        Me.Controls.Add(Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA)
        Me.Controls.Add(USUARIO_CREACIONLabelControl)
        Me.Controls.Add(Me.USUARIO_CREACIONTextEdit)
        Me.Controls.Add(FECHA_CREACIONLabelControl)
        Me.Controls.Add(Me.FECHA_CREACIONDateEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetalleGRUPO_ACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(382, 242)
        CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_GRUPO_ACCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_GRUPO_AFSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaGRUPO_ACCION_CONTRATADABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_GRUPO_ACCIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ID_ACCION_CONTRATADAcbxACCION_CONTRATADA As SGAFP.WinUC.cbxACCION_CONTRATADA
    Friend WithEvents ID_GRUPO_AFSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ID_ACCION_FORMATIVAcbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA
    Friend WithEvents USUARIO_CREACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_CREACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
