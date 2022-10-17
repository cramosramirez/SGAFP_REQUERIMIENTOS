Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarTIPO_PERSONA
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
        Me.UcBuscarTIPO_PERSONA1 = New SGAFP.ucBuscarTIPO_PERSONA
        Me.SuspendLayout()
        '
        'UcBuscarTIPO_PERSONA1
        '
        Me.UcBuscarTIPO_PERSONA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarTIPO_PERSONA1.EntityType = GetType(TIPO_PERSONA)
        Me.UcBuscarTIPO_PERSONA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarTIPO_PERSONA1.Name = "UcBuscarTIPO_PERSONA1"
        Me.UcBuscarTIPO_PERSONA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarTIPO_PERSONA1.TabIndex = 0
        '
        'frmBuscarTIPO_PERSONA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarTIPO_PERSONA1)
        Me.Name = "frmBuscarTIPO_PERSONA"
        Me.Text = "Buscar TIPO_PERSONA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarTIPO_PERSONA1 As SGAFP.ucBuscarTIPO_PERSONA
End Class
