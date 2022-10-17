<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleMODALIDAD_DE_FORMACION
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
        Dim ID_MODALIDAD_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim MODALIDAD_FORMACIONLabelControl As DevExpress.XtraEditors.LabelControl
        Dim NOTASLabelControl As DevExpress.XtraEditors.LabelControl
        Me.ListaMODALIDAD_DE_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_MODALIDAD_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.MODALIDAD_FORMACIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NOTASTextEdit = New DevExpress.XtraEditors.TextEdit
        ID_MODALIDAD_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        MODALIDAD_FORMACIONLabelControl = New DevExpress.XtraEditors.LabelControl
        NOTASLabelControl = New DevExpress.XtraEditors.LabelControl
        CType(Me.ListaMODALIDAD_DE_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_MODALIDAD_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODALIDAD_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTASTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_MODALIDAD_FORMACIONLabelControl
        '
        ID_MODALIDAD_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 14)
        ID_MODALIDAD_FORMACIONLabelControl.Name = "ID_MODALIDAD_FORMACIONLabelControl"
        ID_MODALIDAD_FORMACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        ID_MODALIDAD_FORMACIONLabelControl.TabIndex = 0
        ID_MODALIDAD_FORMACIONLabelControl.Text = "Id modalidad formacion:"
        '
        'MODALIDAD_FORMACIONLabelControl
        '
        MODALIDAD_FORMACIONLabelControl.Location = New System.Drawing.Point(6, 40)
        MODALIDAD_FORMACIONLabelControl.Name = "MODALIDAD_FORMACIONLabelControl"
        MODALIDAD_FORMACIONLabelControl.Size = New System.Drawing.Size(135, 13)
        MODALIDAD_FORMACIONLabelControl.TabIndex = 2
        MODALIDAD_FORMACIONLabelControl.Text = "Modalidad formacion:"
        '
        'NOTASLabelControl
        '
        NOTASLabelControl.Location = New System.Drawing.Point(6, 66)
        NOTASLabelControl.Name = "NOTASLabelControl"
        NOTASLabelControl.Size = New System.Drawing.Size(135, 13)
        NOTASLabelControl.TabIndex = 4
        NOTASLabelControl.Text = "Notas:"
        '
        'ListaMODALIDAD_DE_FORMACIONBindingSource
        '
        Me.ListaMODALIDAD_DE_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.MODALIDAD_DE_FORMACION)
        '
        'ID_MODALIDAD_FORMACIONTextEdit
        '
        Me.ID_MODALIDAD_FORMACIONTextEdit.BackColor = System.Drawing.Color.Linen
        Me.ID_MODALIDAD_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaMODALIDAD_DE_FORMACIONBindingSource, "ID_MODALIDAD_FORMACION", True))
        Me.ID_MODALIDAD_FORMACIONTextEdit.Location = New System.Drawing.Point(144, 8)
        Me.ID_MODALIDAD_FORMACIONTextEdit.Name = "ID_MODALIDAD_FORMACIONTextBox"
        Me.ID_MODALIDAD_FORMACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.ID_MODALIDAD_FORMACIONTextEdit.TabIndex = 1
        '
        'MODALIDAD_FORMACIONTextEdit
        '
        Me.MODALIDAD_FORMACIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaMODALIDAD_DE_FORMACIONBindingSource, "MODALIDAD_FORMACION", True))
        Me.MODALIDAD_FORMACIONTextEdit.Location = New System.Drawing.Point(144, 34)
        Me.MODALIDAD_FORMACIONTextEdit.Name = "MODALIDAD_FORMACIONTextBox"
        Me.MODALIDAD_FORMACIONTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.MODALIDAD_FORMACIONTextEdit.TabIndex = 3
        Me.MODALIDAD_FORMACIONTextEdit.Properties.MaxLength = 100
        '
        'NOTASTextEdit
        '
        Me.NOTASTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaMODALIDAD_DE_FORMACIONBindingSource, "NOTAS", True))
        Me.NOTASTextEdit.Location = New System.Drawing.Point(144, 60)
        Me.NOTASTextEdit.Name = "NOTASTextBox"
        Me.NOTASTextEdit.Size = New System.Drawing.Size(200, 20)
        Me.NOTASTextEdit.TabIndex = 5
        Me.NOTASTextEdit.Properties.MaxLength = 255
        '
        'ucDetalleMODALIDAD_DE_FORMACION
        '
        Me.AutoScroll = True
        Me.Controls.Add(ID_MODALIDAD_FORMACIONLabelControl)
        Me.Controls.Add(Me.ID_MODALIDAD_FORMACIONTextEdit)
        Me.Controls.Add(MODALIDAD_FORMACIONLabelControl)
        Me.Controls.Add(Me.MODALIDAD_FORMACIONTextEdit)
        Me.Controls.Add(NOTASLabelControl)
        Me.Controls.Add(Me.NOTASTextEdit)
        Me.Name = "ucDetalleMODALIDAD_DE_FORMACION"
        Me.Size = New System.Drawing.Size(382, 112)
        CType(Me.ListaMODALIDAD_DE_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_MODALIDAD_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODALIDAD_FORMACIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTASTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaMODALIDAD_DE_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_MODALIDAD_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MODALIDAD_FORMACIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NOTASTextEdit As DevExpress.XtraEditors.TextEdit

End Class
