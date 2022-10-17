Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEJERCICIO
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
        Me.UcBuscarEJERCICIO1 = New SGAFP.ucBuscarEJERCICIO
        Me.SuspendLayout()
        '
        'UcBuscarEJERCICIO1
        '
        Me.UcBuscarEJERCICIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarEJERCICIO1.EntityType = GetType(EJERCICIO)
        Me.UcBuscarEJERCICIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarEJERCICIO1.Name = "UcBuscarEJERCICIO1"
        Me.UcBuscarEJERCICIO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarEJERCICIO1.TabIndex = 0
        '
        'frmBuscarEJERCICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarEJERCICIO1)
        Me.Name = "frmBuscarEJERCICIO"
        Me.Text = "Buscar EJERCICIO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarEJERCICIO1 As SGAFP.ucBuscarEJERCICIO
End Class
