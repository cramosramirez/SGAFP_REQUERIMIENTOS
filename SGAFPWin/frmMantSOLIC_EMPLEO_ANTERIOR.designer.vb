<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSOLIC_EMPLEO_ANTERIOR
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
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1 = New SGAFP.ucMantSOLIC_EMPLEO_ANTERIOR
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantSOLIC_EMPLEO_ANTERIOR1
        '
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.Name = "UcMantSOLIC_EMPLEO_ANTERIOR1"
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.sError = Nothing
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.TabIndex = 6
        '
        'frmMantSOLIC_EMPLEO_ANTERIOR
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantSOLIC_EMPLEO_ANTERIOR1)
        Me.Name = "frmMantSOLIC_EMPLEO_ANTERIOR"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSOLIC_EMPLEO_ANTERIOR1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSOLIC_EMPLEO_ANTERIOR1 As SGAFP.ucMantSOLIC_EMPLEO_ANTERIOR

End Class

