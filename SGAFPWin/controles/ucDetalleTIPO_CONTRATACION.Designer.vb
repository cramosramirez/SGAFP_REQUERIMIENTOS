<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleTIPO_CONTRATACION
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
        Dim ID_TIPO_CONTRALabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOM_TIPO_CONTRALabelControl As DevExpress.XtraEditors.LabelControl
        Dim USUARIO_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim FECHA_CREACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaTIPO_CONTRATACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_TIPO_CONTRATextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NOM_TIPO_CONTRATextEdit = New DevExpress.XtraEditors.TextEdit
        Me.USUARIO_CREACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_CREACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_TIPO_CONTRALabelControl = New DevExpress.XtraEditors.LabelControl
        NOM_TIPO_CONTRALabelControl = New DevExpress.XtraEditors.LabelControl
        USUARIO_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        FECHA_CREACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaTIPO_CONTRATACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_TIPO_CONTRATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOM_TIPO_CONTRATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_TIPO_CONTRALabelControl
        '
        ID_TIPO_CONTRALabelControl.Location = New System.Drawing.Point(6, 14)
        ID_TIPO_CONTRALabelControl.Name = "ID_TIPO_CONTRALabelControl"
        ID_TIPO_CONTRALabelControl.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_CONTRALabelControl.TabIndex = 0
        ID_TIPO_CONTRALabelControl.Text = "Id tipo contra:"
        '
        'NOM_TIPO_CONTRALabelControl
        '
        NOM_TIPO_CONTRALabelControl.Location = New System.Drawing.Point(6, 40)
        NOM_TIPO_CONTRALabelControl.Name = "NOM_TIPO_CONTRALabelControl"
        NOM_TIPO_CONTRALabelControl.Size = New System.Drawing.Size(135, 13)
        NOM_TIPO_CONTRALabelControl.TabIndex = 2
        NOM_TIPO_CONTRALabelControl.Text = "Nom tipo contra:"
        '
        'USUARIO_CREACIONLabelControl
        '
        USUARIO_CREACIONLabelControl.Location = New System.Drawing.Point(6, 66)
        USUARIO_CREACIONLabelControl.Name = "USUARIO_CREACIONLabelControl"
        USUARIO_CREACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        USUARIO_CREACIONLabelControl.TabIndex = 4
        USUARIO_CREACIONLabelControl.Text = "Usuario creacion:"
        '
        'FECHA_CREACIONLabelControl
        '
        FECHA_CREACIONLabelControl.Location = New System.Drawing.Point(6, 92)
        FECHA_CREACIONLabelControl.Name = "FECHA_CREACIONLabelControl"
        FECHA_CREACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        FECHA_CREACIONLabelControl.TabIndex = 6
        FECHA_CREACIONLabelControl.Text = "Fecha creacion:"
        '
        'USERIDLabelControl
        '
        USERIDLabelControl.Location = New System.Drawing.Point(6, 118)
        USERIDLabelControl.Name = "USERIDLabelControl"
        USERIDLabelControl.Size = New System.Drawing.Size(135, 13)
        USERIDLabelControl.TabIndex = 8
        USERIDLabelControl.Text = "Userid:"
        '
        'LASTUPDATELabelControl
        '
        LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 144)
        LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        LASTUPDATELabelControl.Size = New System.Drawing.Size(135, 13)
        LASTUPDATELabelControl.TabIndex = 10
        LASTUPDATELabelControl.Text = "Lastupdate:"
        '
        'ListaTIPO_CONTRATACIONBindingSource
        '
        Me.ListaTIPO_CONTRATACIONBindingSource.DataSource = GetType(SGAFP.EL.TIPO_CONTRATACION)
        '
        'ID_TIPO_CONTRATextEdit
        '
        Me.ID_TIPO_CONTRATextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_TIPO_CONTRATextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "ID_TIPO_CONTRA", True))
        Me.ID_TIPO_CONTRATextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_TIPO_CONTRATextEdit.Name = "ID_TIPO_CONTRATextBox"
        Me.ID_TIPO_CONTRATextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_CONTRATextEdit.TabIndex = 1
        '
        'NOM_TIPO_CONTRATextEdit
        '
        Me.NOM_TIPO_CONTRATextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "NOM_TIPO_CONTRA", True))
        Me.NOM_TIPO_CONTRATextEdit.Location = New System.Drawing.Point(144, 34)
        Me.NOM_TIPO_CONTRATextEdit.Name = "NOM_TIPO_CONTRATextBox"
        Me.NOM_TIPO_CONTRATextEdit.Size = New System.Drawing.Size(200, 20)
        Me.NOM_TIPO_CONTRATextEdit.TabIndex = 3
        Me.NOM_TIPO_CONTRATextEdit.Properties.MaxLength = 30
        '
        'USUARIO_CREACIONTextEdit
        '
        Me.USUARIO_CREACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "USUARIO_CREACION", True))
        Me.USUARIO_CREACIONTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.USUARIO_CREACIONTextEdit.Name = "USUARIO_CREACIONTextBox"
        Me.USUARIO_CREACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USUARIO_CREACIONTextEdit.TabIndex = 5
        Me.USUARIO_CREACIONTextEdit.Properties.MaxLength = 255
        '
        'FECHA_CREACIONDateEdit
        '
        Me.FECHA_CREACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "FECHA_CREACION", True))
        Me.FECHA_CREACIONDateEdit.EditValue = Nothing
        Me.FECHA_CREACIONDateEdit.Location = New System.Drawing.Point(144, 86)
        Me.FECHA_CREACIONDateEdit.Name = "FECHA_CREACIONDateEdit"
        Me.FECHA_CREACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_CREACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FECHA_CREACIONDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.FECHA_CREACIONDateEdit.TabIndex = 7
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 112)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 9
        Me.USERIDTextEdit.Properties.MaxLength = 255
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaTIPO_CONTRATACIONBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 138)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 11
        '
        'ucDetalleTIPO_CONTRATACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_TIPO_CONTRALabelControl)
        Me.Controls.Add(Me.ID_TIPO_CONTRATextEdit)
        Me.Controls.Add(NOM_TIPO_CONTRALabelControl)
        Me.Controls.Add(Me.NOM_TIPO_CONTRATextEdit)
        Me.Controls.Add(USUARIO_CREACIONLabelControl)
        Me.Controls.Add(Me.USUARIO_CREACIONTextEdit)
        Me.Controls.Add(FECHA_CREACIONLabelControl)
        Me.Controls.Add(Me.FECHA_CREACIONDateEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetalleTIPO_CONTRATACION"
        Me.Size = New System.Drawing.Size(382, 190)
        CType(Me.ListaTIPO_CONTRATACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_TIPO_CONTRATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOM_TIPO_CONTRATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIO_CREACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_CREACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_CONTRATACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_TIPO_CONTRATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOM_TIPO_CONTRATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents USUARIO_CREACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_CREACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
