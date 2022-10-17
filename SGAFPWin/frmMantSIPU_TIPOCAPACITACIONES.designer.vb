<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSIPU_TIPOCAPACITACIONES
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
        Me.UcMantSIPU_TIPOCAPACITACIONES1 = New SGAFP.ucMantSIPU_TIPOCAPACITACIONES
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantSIPU_TIPOCAPACITACIONES1
        '
        Me.UcMantSIPU_TIPOCAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSIPU_TIPOCAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSIPU_TIPOCAPACITACIONES1.Name = "UcMantSIPU_TIPOCAPACITACIONES1"
        Me.UcMantSIPU_TIPOCAPACITACIONES1.sError = Nothing
        Me.UcMantSIPU_TIPOCAPACITACIONES1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantSIPU_TIPOCAPACITACIONES1.TabIndex = 6
        '
        'frmMantSIPU_TIPOCAPACITACIONES
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantSIPU_TIPOCAPACITACIONES1)
        Me.Name = "frmMantSIPU_TIPOCAPACITACIONES"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSIPU_TIPOCAPACITACIONES1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSIPU_TIPOCAPACITACIONES1 As SGAFP.ucMantSIPU_TIPOCAPACITACIONES

End Class

