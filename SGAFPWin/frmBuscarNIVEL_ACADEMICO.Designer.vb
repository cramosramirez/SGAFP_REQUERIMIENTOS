Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarNIVEL_ACADEMICO
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
        Me.UcBuscarNIVEL_ACADEMICO1 = New SGAFP.ucBuscarNIVEL_ACADEMICO
        Me.SuspendLayout()
        '
        'UcBuscarNIVEL_ACADEMICO1
        '
        Me.UcBuscarNIVEL_ACADEMICO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarNIVEL_ACADEMICO1.EntityType = GetType(NIVEL_ACADEMICO)
        Me.UcBuscarNIVEL_ACADEMICO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarNIVEL_ACADEMICO1.Name = "UcBuscarNIVEL_ACADEMICO1"
        Me.UcBuscarNIVEL_ACADEMICO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarNIVEL_ACADEMICO1.TabIndex = 0
        '
        'frmBuscarNIVEL_ACADEMICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarNIVEL_ACADEMICO1)
        Me.Name = "frmBuscarNIVEL_ACADEMICO"
        Me.Text = "Buscar NIVEL_ACADEMICO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarNIVEL_ACADEMICO1 As SGAFP.ucBuscarNIVEL_ACADEMICO
End Class
