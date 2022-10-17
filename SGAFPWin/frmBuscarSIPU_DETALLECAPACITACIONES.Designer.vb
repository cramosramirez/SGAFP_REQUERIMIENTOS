Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSIPU_DETALLECAPACITACIONES
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
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1 = New SGAFP.ucBuscarSIPU_DETALLECAPACITACIONES
        Me.SuspendLayout()
        '
        'UcBuscarSIPU_DETALLECAPACITACIONES1
        '
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.EntityType = GetType(SIPU_DETALLECAPACITADO)
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.Name = "UcBuscarSIPU_DETALLECAPACITACIONES1"
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSIPU_DETALLECAPACITACIONES1.TabIndex = 0
        '
        'frmBuscarSIPU_DETALLECAPACITACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSIPU_DETALLECAPACITACIONES1)
        Me.Name = "frmBuscarSIPU_DETALLECAPACITACIONES"
        Me.Text = "Buscar SIPU_DETALLECAPACITACIONES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSIPU_DETALLECAPACITACIONES1 As SGAFP.ucBuscarSIPU_DETALLECAPACITACIONES
End Class
