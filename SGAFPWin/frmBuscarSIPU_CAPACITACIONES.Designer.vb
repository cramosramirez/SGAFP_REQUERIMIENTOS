Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSIPU_CAPACITACIONES
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
        Me.UcBuscarSIPU_CAPACITACIONES1 = New SGAFP.ucBuscarSIPU_CAPACITACIONES
        Me.SuspendLayout()
        '
        'UcBuscarSIPU_CAPACITACIONES1
        '
        Me.UcBuscarSIPU_CAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSIPU_CAPACITACIONES1.EntityType = GetType(SIPU_CAPACITACIONES)
        Me.UcBuscarSIPU_CAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSIPU_CAPACITACIONES1.Name = "UcBuscarSIPU_CAPACITACIONES1"
        Me.UcBuscarSIPU_CAPACITACIONES1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSIPU_CAPACITACIONES1.TabIndex = 0
        '
        'frmBuscarSIPU_CAPACITACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSIPU_CAPACITACIONES1)
        Me.Name = "frmBuscarSIPU_CAPACITACIONES"
        Me.Text = "Buscar SIPU_CAPACITACIONES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSIPU_CAPACITACIONES1 As SGAFP.ucBuscarSIPU_CAPACITACIONES
End Class
