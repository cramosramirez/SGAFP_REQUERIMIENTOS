Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUSUARIO
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
        Me.UcBuscarUSUARIO1 = New SGAFP.ucBuscarUSUARIO
        Me.SuspendLayout()
        '
        'UcBuscarUSUARIO1
        '
        Me.UcBuscarUSUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarUSUARIO1.EntityType = GetType(USUARIO)
        Me.UcBuscarUSUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarUSUARIO1.Name = "UcBuscarUSUARIO1"
        Me.UcBuscarUSUARIO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarUSUARIO1.TabIndex = 0
        '
        'frmBuscarUSUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarUSUARIO1)
        Me.Name = "frmBuscarUSUARIO"
        Me.Text = "Buscar USUARIO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarUSUARIO1 As SGAFP.ucBuscarUSUARIO
End Class
