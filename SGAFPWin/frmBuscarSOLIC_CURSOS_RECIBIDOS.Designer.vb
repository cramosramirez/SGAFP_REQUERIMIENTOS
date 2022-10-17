Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSOLIC_CURSOS_RECIBIDOS
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
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1 = New SGAFP.ucBuscarSOLIC_CURSOS_RECIBIDOS
        Me.SuspendLayout()
        '
        'UcBuscarSOLIC_CURSOS_RECIBIDOS1
        '
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.EntityType = GetType(SOLIC_CURSOS_RECIBIDOS)
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.Name = "UcBuscarSOLIC_CURSOS_RECIBIDOS1"
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1.TabIndex = 0
        '
        'frmBuscarSOLIC_CURSOS_RECIBIDOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSOLIC_CURSOS_RECIBIDOS1)
        Me.Name = "frmBuscarSOLIC_CURSOS_RECIBIDOS"
        Me.Text = "Buscar SOLIC_CURSOS_RECIBIDOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSOLIC_CURSOS_RECIBIDOS1 As SGAFP.ucBuscarSOLIC_CURSOS_RECIBIDOS
End Class
