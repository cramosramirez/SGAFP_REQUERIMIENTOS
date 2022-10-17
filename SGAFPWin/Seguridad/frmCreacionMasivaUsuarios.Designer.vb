<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreacionMasivaUsuarios
    Inherits SGAFP.frmBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Archivo:"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(70, 66)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEdit1.Size = New System.Drawing.Size(181, 20)
        Me.ButtonEdit1.TabIndex = 6
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(10, 101)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.Step = 1
        Me.ProgressBarControl1.Size = New System.Drawing.Size(567, 18)
        Me.ProgressBarControl1.TabIndex = 7
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(434, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Procesar"
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindByCode = True
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(96, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(301, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 9
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindByCode = True
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(96, 39)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(301, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 10
        Me.CbxSITIO_CAPACITACION1.Text = "CbxSITIO_CAPACITACION1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Proveedor:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Centro:"
        '
        'frmCreacionMasivaUsuarios
        '
        Me.ClientSize = New System.Drawing.Size(591, 146)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.ButtonEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmCreacionMasivaUsuarios"
        Me.Text = "Carga Masiva de Usuarios"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.ButtonEdit1, 0)
        Me.Controls.SetChildIndex(Me.ProgressBarControl1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.CbxPROVEEDOR_AF1, 0)
        Me.Controls.SetChildIndex(Me.CbxSITIO_CAPACITACION1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
