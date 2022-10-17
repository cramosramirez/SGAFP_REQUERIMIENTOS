<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePROGRAMA_FORMACION_TIPOPAGO
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
        Dim ID_TIPO_PAGOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOMBRE_TIPO_PAGOLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_TIPO_PAGOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NOMBRE_TIPO_PAGOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        ID_TIPO_PAGOLabelControl = New DevExpress.XtraEditors.LabelControl
        NOMBRE_TIPO_PAGOLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_TIPO_PAGOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRE_TIPO_PAGOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_TIPO_PAGOLabelControl
        '
        ID_TIPO_PAGOLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_TIPO_PAGOLabelControl.Name = "ID_TIPO_PAGOLabelControl"
        ID_TIPO_PAGOLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_PAGOLabelControl.TabIndex = 0
        ID_TIPO_PAGOLabelControl.Text = "Id tipo pago:"
        '
        'NOMBRE_TIPO_PAGOLabelControl
        '
        NOMBRE_TIPO_PAGOLabelControl.Location = New System.Drawing.Point(6, 40)
        NOMBRE_TIPO_PAGOLabelControl.Name = "NOMBRE_TIPO_PAGOLabelControl"
        NOMBRE_TIPO_PAGOLabelControl.Size = New System.Drawing.Size(135, 13)
        NOMBRE_TIPO_PAGOLabelControl.TabIndex = 2
        NOMBRE_TIPO_PAGOLabelControl.Text = "Nombre tipo pago:"
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
        'ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource
        '
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.DataSource = GetType(SGAFP.EL.PROGRAMA_FORMACION_TIPOPAGO)
        '
        'ID_TIPO_PAGOTextEdit
        '
        Me.ID_TIPO_PAGOTextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_TIPO_PAGOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, "ID_TIPO_PAGO", True))
        Me.ID_TIPO_PAGOTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_TIPO_PAGOTextEdit.Name = "ID_TIPO_PAGOTextBox"
        Me.ID_TIPO_PAGOTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_PAGOTextEdit.TabIndex = 1
        '
        'NOMBRE_TIPO_PAGOTextEdit
        '
        Me.NOMBRE_TIPO_PAGOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, "NOMBRE_TIPO_PAGO", True))
        Me.NOMBRE_TIPO_PAGOTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRE_TIPO_PAGOTextEdit.Name = "NOMBRE_TIPO_PAGOTextBox"
        Me.NOMBRE_TIPO_PAGOTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_TIPO_PAGOTextEdit.TabIndex = 3
        Me.NOMBRE_TIPO_PAGOTextEdit.Properties.MaxLength = 100
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 5
        Me.USERIDTextEdit.Properties.MaxLength = 256
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 7
        '
        'ucDetallePROGRAMA_FORMACION_TIPOPAGO
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_TIPO_PAGOLabelControl)
        Me.Controls.Add(Me.ID_TIPO_PAGOTextEdit)
        Me.Controls.Add(NOMBRE_TIPO_PAGOLabelControl)
        Me.Controls.Add(Me.NOMBRE_TIPO_PAGOTextEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Name = "ucDetallePROGRAMA_FORMACION_TIPOPAGO"
        Me.Size = New System.Drawing.Size(382, 138)
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_TIPO_PAGOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRE_TIPO_PAGOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_TIPO_PAGOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOMBRE_TIPO_PAGOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit

End Class
