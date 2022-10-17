Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCIUU
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
        Me.UcBuscarCIUU1 = New SGAFP.ucBuscarCIUU
        Me.SuspendLayout()
        '
        'UcBuscarCIUU1
        '
        Me.UcBuscarCIUU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCIUU1.EntityType = GetType(CIUU)
        Me.UcBuscarCIUU1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCIUU1.Name = "UcBuscarCIUU1"
        Me.UcBuscarCIUU1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCIUU1.TabIndex = 0
        '
        'frmBuscarCIUU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCIUU1)
        Me.Name = "frmBuscarCIUU"
        Me.Text = "Buscar CIUU"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCIUU1 As SGAFP.ucBuscarCIUU
End Class
