<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetallePROGRAMA_FORMACION
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
        Dim ID_PROGRAMA_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOMBRE_PROGRAMA_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim USERIDLabelControl As DevExpress.XtraEditors.LabelControl
        Dim LASTUPDATELabelControl As DevExpress.XtraEditors.LabelControl
        Dim PORC_ASISTENCIA_MINIMALabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOTA_MINIMALabelControl As DevExpress.XtraEditors.LabelControl
        Dim ID_TIPO_PAGOLabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaPROGRAMA_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_PROGRAMA_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.USERIDTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LASTUPDATEDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.PORC_ASISTENCIA_MINIMASpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.NOTA_MINIMASpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO = New SGAFP.WinUC.cbxPROGRAMA_FORMACION_TIPOPAGO
        ID_PROGRAMA_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        NOMBRE_PROGRAMA_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        USERIDLabelControl = New DevExpress.XtraEditors.LabelControl
        LASTUPDATELabelControl = New DevExpress.XtraEditors.LabelControl
        PORC_ASISTENCIA_MINIMALabelControl = New DevExpress.XtraEditors.LabelControl
        NOTA_MINIMALabelControl = New DevExpress.XtraEditors.LabelControl
        ID_TIPO_PAGOLabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaPROGRAMA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_PROGRAMA_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PORC_ASISTENCIA_MINIMASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTA_MINIMASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PROGRAMA_FORMACIONLabelControl
        '
        ID_PROGRAMA_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_PROGRAMA_FORMACIONLabelControl.Name = "ID_PROGRAMA_FORMACIONLabelControl"
        ID_PROGRAMA_FORMACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_PROGRAMA_FORMACIONLabelControl.TabIndex = 0
        ID_PROGRAMA_FORMACIONLabelControl.Text = "Id programa formacion:"
        '
        'NOMBRE_PROGRAMA_FORMACIONLabelControl
        '
        NOMBRE_PROGRAMA_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 40)
        NOMBRE_PROGRAMA_FORMACIONLabelControl.Name = "NOMBRE_PROGRAMA_FORMACIONLabelControl"
        NOMBRE_PROGRAMA_FORMACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        NOMBRE_PROGRAMA_FORMACIONLabelControl.TabIndex = 2
        NOMBRE_PROGRAMA_FORMACIONLabelControl.Text = "Nombre programa formacion:"
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
        'PORC_ASISTENCIA_MINIMALabelControl
        '
        PORC_ASISTENCIA_MINIMALabelControl.Location = New System.Drawing.Point(6, 118)
        PORC_ASISTENCIA_MINIMALabelControl.Name = "PORC_ASISTENCIA_MINIMALabelControl"
        PORC_ASISTENCIA_MINIMALabelControl.Size = New System.Drawing.Size(135, 13)
        PORC_ASISTENCIA_MINIMALabelControl.TabIndex = 8
        PORC_ASISTENCIA_MINIMALabelControl.Text = "Porc asistencia minima:"
        '
        'NOTA_MINIMALabelControl
        '
        NOTA_MINIMALabelControl.Location = New System.Drawing.Point(6, 144)
        NOTA_MINIMALabelControl.Name = "NOTA_MINIMALabelControl"
        NOTA_MINIMALabelControl.Size = New System.Drawing.Size(135, 13)
        NOTA_MINIMALabelControl.TabIndex = 10
        NOTA_MINIMALabelControl.Text = "Nota minima:"
        '
        'ID_TIPO_PAGOLabelControl
        '
        ID_TIPO_PAGOLabelControl.Location = New System.Drawing.Point(6, 170)
        ID_TIPO_PAGOLabelControl.Name = "ID_TIPO_PAGOLabelControl"
        ID_TIPO_PAGOLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_TIPO_PAGOLabelControl.TabIndex = 12
        ID_TIPO_PAGOLabelControl.Text = "Id tipo pago:"
        '
        'ListaPROGRAMA_FORMACIONBindingSource
        '
        Me.ListaPROGRAMA_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.PROGRAMA_FORMACION)
        '
        'ID_PROGRAMA_FORMACIONTextEdit
        '
        Me.ID_PROGRAMA_FORMACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_PROGRAMA_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "ID_PROGRAMA_FORMACION", True))
        Me.ID_PROGRAMA_FORMACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_PROGRAMA_FORMACIONTextEdit.Name = "ID_PROGRAMA_FORMACIONTextBox"
        Me.ID_PROGRAMA_FORMACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_PROGRAMA_FORMACIONTextEdit.TabIndex = 1
        '
        'NOMBRE_PROGRAMA_FORMACIONTextEdit
        '
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "NOMBRE_PROGRAMA_FORMACION", True))
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Name = "NOMBRE_PROGRAMA_FORMACIONTextBox"
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.TabIndex = 3
        Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Properties.MaxLength = 100
        '
        'USERIDTextEdit
        '
        Me.USERIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "USERID", True))
        Me.USERIDTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.USERIDTextEdit.Name = "USERIDTextBox"
        Me.USERIDTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.USERIDTextEdit.TabIndex = 5
        Me.USERIDTextEdit.Properties.MaxLength = 256
        '
        'LASTUPDATEDateEdit
        '
        Me.LASTUPDATEDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "LASTUPDATE", True))
        Me.LASTUPDATEDateEdit.EditValue = Nothing
        Me.LASTUPDATEDateEdit.Location = New System.Drawing.Point(144, 86)
        Me.LASTUPDATEDateEdit.Name = "LASTUPDATEDateEdit"
        Me.LASTUPDATEDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LASTUPDATEDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.LASTUPDATEDateEdit.Size = New System.Drawing.Size(200, 20)
        Me.LASTUPDATEDateEdit.TabIndex = 7
        '
        'PORC_ASISTENCIA_MINIMASpinEdit
        '
        Me.PORC_ASISTENCIA_MINIMASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "PORC_ASISTENCIA_MINIMA", True))
        Me.PORC_ASISTENCIA_MINIMASpinEdit.Location = New System.Drawing.Point(144, 112)
        Me.PORC_ASISTENCIA_MINIMASpinEdit.Name = "PORC_ASISTENCIA_MINIMASpinEdit"
        Me.PORC_ASISTENCIA_MINIMASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PORC_ASISTENCIA_MINIMASpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PORC_ASISTENCIA_MINIMASpinEdit.TabIndex = 9
        '
        'NOTA_MINIMASpinEdit
        '
        Me.NOTA_MINIMASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "NOTA_MINIMA", True))
        Me.NOTA_MINIMASpinEdit.Location = New System.Drawing.Point(144, 138)
        Me.NOTA_MINIMASpinEdit.Name = "NOTA_MINIMASpinEdit"
        Me.NOTA_MINIMASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NOTA_MINIMASpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.NOTA_MINIMASpinEdit.TabIndex = 11
        '
        'ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO
        '
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ListaPROGRAMA_FORMACIONBindingSource, "ID_TIPO_PAGO", True))
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.Location = New System.Drawing.Point(144, 164)
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.Name = "ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO"
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.Size = New System.Drawing.Size(200, 20)
        Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO.TabIndex = 13
        '
        'ucDetallePROGRAMA_FORMACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_PROGRAMA_FORMACIONLabelControl)
        Me.Controls.Add(Me.ID_PROGRAMA_FORMACIONTextEdit)
        Me.Controls.Add(NOMBRE_PROGRAMA_FORMACIONLabelControl)
        Me.Controls.Add(Me.NOMBRE_PROGRAMA_FORMACIONTextEdit)
        Me.Controls.Add(USERIDLabelControl)
        Me.Controls.Add(Me.USERIDTextEdit)
        Me.Controls.Add(LASTUPDATELabelControl)
        Me.Controls.Add(Me.LASTUPDATEDateEdit)
        Me.Controls.Add(PORC_ASISTENCIA_MINIMALabelControl)
        Me.Controls.Add(Me.PORC_ASISTENCIA_MINIMASpinEdit)
        Me.Controls.Add(NOTA_MINIMALabelControl)
        Me.Controls.Add(Me.NOTA_MINIMASpinEdit)
        Me.Controls.Add(ID_TIPO_PAGOLabelControl)
        Me.Controls.Add(Me.ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO)
        Me.Name = "ucDetallePROGRAMA_FORMACION"
        Me.Size = New System.Drawing.Size(382, 216)
        CType(Me.ListaPROGRAMA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_PROGRAMA_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRE_PROGRAMA_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASTUPDATEDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PORC_ASISTENCIA_MINIMASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTA_MINIMASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROGRAMA_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_PROGRAMA_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOMBRE_PROGRAMA_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents USERIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LASTUPDATEDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PORC_ASISTENCIA_MINIMASpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NOTA_MINIMASpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ID_TIPO_PAGOcbxPROGRAMA_FORMACION_TIPOPAGO As SGAFP.WinUC.cbxPROGRAMA_FORMACION_TIPOPAGO

End Class
