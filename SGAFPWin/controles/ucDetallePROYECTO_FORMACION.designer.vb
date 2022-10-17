<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePROYECTO_FORMACION
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
        Me.ID_PROYECTO_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        Me.USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        Me.LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        Me.ID_PROYECTO_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ListaPROYECTO_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.ID_PROYECTO_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROYECTO_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PROYECTO_FORMACIONLabelControl
        '
        Me.ID_PROYECTO_FORMACIONLabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ID_PROYECTO_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 37)
        Me.ID_PROYECTO_FORMACIONLabelControl.Name = "ID_PROYECTO_FORMACIONLabelControl"
        Me.ID_PROYECTO_FORMACIONLabelControl.Size = New System.Drawing.Size(115, 13)
        Me.ID_PROYECTO_FORMACIONLabelControl.TabIndex = 0
        Me.ID_PROYECTO_FORMACIONLabelControl.Text = "Id proyecto formacion *"
        '
        'NOMBRE_PROYECTO_FORMACIONLabelControl
        '
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 63)
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.Name = "NOMBRE_PROYECTO_FORMACIONLabelControl"
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.Size = New System.Drawing.Size(142, 13)
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.TabIndex = 2
        Me.NOMBRE_PROYECTO_FORMACIONLabelControl.Text = "Nombre proyecto formacion *"
        '
        'USERIDLabelControl
        '
        Me.USERIDLabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.USERIDLabelControl.Location = New System.Drawing.Point(6, 89)
        Me.USERIDLabelControl.Name = "USERIDLabelControl"
        Me.USERIDLabelControl.Size = New System.Drawing.Size(39, 13)
        Me.USERIDLabelControl.TabIndex = 4
        Me.USERIDLabelControl.Text = "Userid *"
        '
        'LASTUPDATELabelControl
        '
        Me.LASTUPDATELabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LASTUPDATELabelControl.Location = New System.Drawing.Point(6, 115)
        Me.LASTUPDATELabelControl.Name = "LASTUPDATELabelControl"
        Me.LASTUPDATELabelControl.Size = New System.Drawing.Size(63, 13)
        Me.LASTUPDATELabelControl.TabIndex = 6
        Me.LASTUPDATELabelControl.Text = "Lastupdate *"
        '
        'ID_PROYECTO_FORMACIONTextEdit
        '
        Me.ID_PROYECTO_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROYECTO_FORMACIONBindingSource, "ID_PROYECTO_FORMACION", True))
        Me.ID_PROYECTO_FORMACIONTextEdit.Location = New System.Drawing.Point(154, 31)
        Me.ID_PROYECTO_FORMACIONTextEdit.Name = "ID_PROYECTO_FORMACIONTextEdit"
        Me.ID_PROYECTO_FORMACIONTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Linen
        Me.ID_PROYECTO_FORMACIONTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ID_PROYECTO_FORMACIONTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.ID_PROYECTO_FORMACIONTextEdit.TabIndex = 1
        '
        'ListaPROYECTO_FORMACIONBindingSource
        '
        Me.ListaPROYECTO_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.PROYECTO_FORMACION)
        '
        'NOMBRE_PROYECTO_FORMACIONTextEdit
        '
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROYECTO_FORMACIONBindingSource, "NOMBRE_PROYECTO_FORMACION", True))
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Location = New System.Drawing.Point(154, 57)
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Name = "NOMBRE_PROYECTO_FORMACIONTextEdit"
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Properties.MaxLength = 255
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Size = New System.Drawing.Size(595, 20)
        Me.NOMBRE_PROYECTO_FORMACIONTextEdit.TabIndex = 3
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROYECTO_FORMACIONBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(154, 83)
        Me.USERIDTextEdit.Name = "USERIDTextEdit"
        Me.USERIDTextEdit.Properties.MaxLength = 256
        Me.USERIDTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.USERIDTextEdit.TabIndex = 5
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROYECTO_FORMACIONBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(154, 109)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(190, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "(*) Campos obligatorios."
        '
        'ucDetallePROYECTO_FORMACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ID_PROYECTO_FORMACIONLabelControl)
        Me.Controls.Add(Me.ID_PROYECTO_FORMACIONTextEdit)
        Me.Controls.Add(Me.NOMBRE_PROYECTO_FORMACIONLabelControl)
        Me.Controls.Add(Me.NOMBRE_PROYECTO_FORMACIONTextEdit)
        Me.Controls.Add(Me.USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(Me.LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetallePROYECTO_FORMACION"
        Me.Size = New System.Drawing.Size(769, 200)
        CType(Me.ID_PROYECTO_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROYECTO_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRE_PROYECTO_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROYECTO_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_PROYECTO_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOMBRE_PROYECTO_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ID_PROYECTO_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NOMBRE_PROYECTO_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents USERIDLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
