Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPROGRAMA_FORMACION
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
        Me.UcBuscarPROGRAMA_FORMACION1 = New SGAFP.ucBuscarPROGRAMA_FORMACION
        Me.SuspendLayout()
        '
        'UcBuscarPROGRAMA_FORMACION1
        '
        Me.UcBuscarPROGRAMA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarPROGRAMA_FORMACION1.EntityType = GetType(PROGRAMA_FORMACION)
        Me.UcBuscarPROGRAMA_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarPROGRAMA_FORMACION1.Name = "UcBuscarPROGRAMA_FORMACION1"
        Me.UcBuscarPROGRAMA_FORMACION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarPROGRAMA_FORMACION1.TabIndex = 0
        '
        'frmBuscarPROGRAMA_FORMACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarPROGRAMA_FORMACION1)
        Me.Name = "frmBuscarPROGRAMA_FORMACION"
        Me.Text = "Buscar PROGRAMA_FORMACION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarPROGRAMA_FORMACION1 As SGAFP.ucBuscarPROGRAMA_FORMACION
End Class
