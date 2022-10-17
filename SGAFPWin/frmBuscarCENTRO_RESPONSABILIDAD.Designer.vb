Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCENTRO_RESPONSABILIDAD
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
        Me.UcBuscarCENTRO_RESPONSABILIDAD1 = New SGAFP.ucBuscarCENTRO_RESPONSABILIDAD
        Me.SuspendLayout()
        '
        'UcBuscarCENTRO_RESPONSABILIDAD1
        '
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.EntityType = GetType(CENTRO_RESPONSABILIDAD)
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.Name = "UcBuscarCENTRO_RESPONSABILIDAD1"
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCENTRO_RESPONSABILIDAD1.TabIndex = 0
        '
        'frmBuscarCENTRO_RESPONSABILIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCENTRO_RESPONSABILIDAD1)
        Me.Name = "frmBuscarCENTRO_RESPONSABILIDAD"
        Me.Text = "Buscar CENTRO_RESPONSABILIDAD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCENTRO_RESPONSABILIDAD1 As SGAFP.ucBuscarCENTRO_RESPONSABILIDAD
End Class
