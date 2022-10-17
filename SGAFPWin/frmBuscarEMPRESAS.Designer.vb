Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEMPRESAS
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
        Me.UcBuscarEMPRESAS1 = New SGAFP.ucBuscarEMPRESAS
        Me.SuspendLayout()
        '
        'UcBuscarEMPRESAS1
        '
        Me.UcBuscarEMPRESAS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarEMPRESAS1.EntityType = GetType(EMPRESAS)
        Me.UcBuscarEMPRESAS1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarEMPRESAS1.Name = "UcBuscarEMPRESAS1"
        Me.UcBuscarEMPRESAS1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarEMPRESAS1.TabIndex = 0
        '
        'frmBuscarEMPRESAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarEMPRESAS1)
        Me.Name = "frmBuscarEMPRESAS"
        Me.Text = "Buscar EMPRESAS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarEMPRESAS1 As SGAFP.ucBuscarEMPRESAS
End Class
