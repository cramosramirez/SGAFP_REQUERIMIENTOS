Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSIPU_TIPOCAPACITACIONES
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1 = New SGAFP.ucBuscarSIPU_TIPOCAPACITACIONES
        Me.SuspendLayout()
        '
        'UcBuscarSIPU_TIPOCAPACITACIONES1
        '
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.EntityType = GetType(SIPU_TIPOCAPACITACIONES)
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.Name = "UcBuscarSIPU_TIPOCAPACITACIONES1"
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSIPU_TIPOCAPACITACIONES1.TabIndex = 0
        '
        'frmBuscarSIPU_TIPOCAPACITACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSIPU_TIPOCAPACITACIONES1)
        Me.Name = "frmBuscarSIPU_TIPOCAPACITACIONES"
        Me.Text = "Buscar SIPU_TIPOCAPACITACIONES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSIPU_TIPOCAPACITACIONES1 As SGAFP.ucBuscarSIPU_TIPOCAPACITACIONES
End Class
