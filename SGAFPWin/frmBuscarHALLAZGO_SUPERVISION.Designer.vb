Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarHALLAZGO_SUPERVISION
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
        Me.UcBuscarHALLAZGO_SUPERVISION1 = New SGAFP.ucBuscarHALLAZGO_SUPERVISION
        Me.SuspendLayout()
        '
        'UcBuscarHALLAZGO_SUPERVISION1
        '
        Me.UcBuscarHALLAZGO_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarHALLAZGO_SUPERVISION1.EntityType = GetType(HALLAZGO_SUPERVISION)
        Me.UcBuscarHALLAZGO_SUPERVISION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarHALLAZGO_SUPERVISION1.Name = "UcBuscarHALLAZGO_SUPERVISION1"
        Me.UcBuscarHALLAZGO_SUPERVISION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarHALLAZGO_SUPERVISION1.TabIndex = 0
        '
        'frmBuscarHALLAZGO_SUPERVISION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarHALLAZGO_SUPERVISION1)
        Me.Name = "frmBuscarHALLAZGO_SUPERVISION"
        Me.Text = "Buscar HALLAZGO_SUPERVISION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarHALLAZGO_SUPERVISION1 As SGAFP.ucBuscarHALLAZGO_SUPERVISION
End Class
