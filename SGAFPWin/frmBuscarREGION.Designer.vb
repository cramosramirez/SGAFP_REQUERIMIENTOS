Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarREGION
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
        Me.UcBuscarREGION1 = New SGAFP.ucBuscarREGION
        Me.SuspendLayout()
        '
        'UcBuscarREGION1
        '
        Me.UcBuscarREGION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarREGION1.EntityType = GetType(REGION)
        Me.UcBuscarREGION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarREGION1.Name = "UcBuscarREGION1"
        Me.UcBuscarREGION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarREGION1.TabIndex = 0
        '
        'frmBuscarREGION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarREGION1)
        Me.Name = "frmBuscarREGION"
        Me.Text = "Buscar REGION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarREGION1 As SGAFP.ucBuscarREGION
End Class
