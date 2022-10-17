Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPROGRAMA_FORMACION_TIPOPAGO
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
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1 = New SGAFP.ucBuscarPROGRAMA_FORMACION_TIPOPAGO
        Me.SuspendLayout()
        '
        'UcBuscarPROGRAMA_FORMACION_TIPOPAGO1
        '
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.EntityType = GetType(PROGRAMA_FORMACION_TIPOPAGO)
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.Name = "UcBuscarPROGRAMA_FORMACION_TIPOPAGO1"
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.TabIndex = 0
        '
        'frmBuscarPROGRAMA_FORMACION_TIPOPAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarPROGRAMA_FORMACION_TIPOPAGO1)
        Me.Name = "frmBuscarPROGRAMA_FORMACION_TIPOPAGO"
        Me.Text = "Buscar PROGRAMA_FORMACION_TIPOPAGO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarPROGRAMA_FORMACION_TIPOPAGO1 As SGAFP.ucBuscarPROGRAMA_FORMACION_TIPOPAGO
End Class
