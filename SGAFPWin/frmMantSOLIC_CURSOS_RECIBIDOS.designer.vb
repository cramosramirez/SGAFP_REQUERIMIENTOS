<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSOLIC_CURSOS_RECIBIDOS
    Inherits SGAFP.frmMantPadre

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
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1 = New SGAFP.ucMantSOLIC_CURSOS_RECIBIDOS
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantSOLIC_CURSOS_RECIBIDOS1
        '
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.Name = "UcMantSOLIC_CURSOS_RECIBIDOS1"
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.sError = Nothing
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.TabIndex = 6
        '
        'frmMantSOLIC_CURSOS_RECIBIDOS
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantSOLIC_CURSOS_RECIBIDOS1)
        Me.Name = "frmMantSOLIC_CURSOS_RECIBIDOS"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSOLIC_CURSOS_RECIBIDOS1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSOLIC_CURSOS_RECIBIDOS1 As SGAFP.ucMantSOLIC_CURSOS_RECIBIDOS

End Class

