Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEVALUACION_AF
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
        Me.UcBuscarEVALUACION_AF1 = New SGAFP.ucBuscarEVALUACION_AF
        Me.SuspendLayout()
        '
        'UcBuscarEVALUACION_AF1
        '
        Me.UcBuscarEVALUACION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarEVALUACION_AF1.EntityType = GetType(EVALUACION_AF)
        Me.UcBuscarEVALUACION_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarEVALUACION_AF1.Name = "UcBuscarEVALUACION_AF1"
        Me.UcBuscarEVALUACION_AF1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarEVALUACION_AF1.TabIndex = 0
        '
        'frmBuscarEVALUACION_AF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarEVALUACION_AF1)
        Me.Name = "frmBuscarEVALUACION_AF"
        Me.Text = "Buscar EVALUACION_AF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarEVALUACION_AF1 As SGAFP.ucBuscarEVALUACION_AF
End Class
