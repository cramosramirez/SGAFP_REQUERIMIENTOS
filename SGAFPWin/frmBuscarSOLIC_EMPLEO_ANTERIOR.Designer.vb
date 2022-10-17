Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSOLIC_EMPLEO_ANTERIOR
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
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1 = New SGAFP.ucBuscarSOLIC_EMPLEO_ANTERIOR
        Me.SuspendLayout()
        '
        'UcBuscarSOLIC_EMPLEO_ANTERIOR1
        '
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.EntityType = GetType(SOLIC_EMPLEO_ANTERIOR)
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.Name = "UcBuscarSOLIC_EMPLEO_ANTERIOR1"
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1.TabIndex = 0
        '
        'frmBuscarSOLIC_EMPLEO_ANTERIOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSOLIC_EMPLEO_ANTERIOR1)
        Me.Name = "frmBuscarSOLIC_EMPLEO_ANTERIOR"
        Me.Text = "Buscar SOLIC_EMPLEO_ANTERIOR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSOLIC_EMPLEO_ANTERIOR1 As SGAFP.ucBuscarSOLIC_EMPLEO_ANTERIOR
End Class
