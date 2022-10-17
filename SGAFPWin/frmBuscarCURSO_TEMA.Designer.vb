Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCURSO_TEMA
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
        Me.UcBuscarCURSO_TEMA1 = New SGAFP.ucBuscarCURSO_TEMA
        Me.SuspendLayout()
        '
        'UcBuscarCURSO_TEMA1
        '
        Me.UcBuscarCURSO_TEMA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCURSO_TEMA1.EntityType = GetType(CURSO_TEMA)
        Me.UcBuscarCURSO_TEMA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCURSO_TEMA1.Name = "UcBuscarCURSO_TEMA1"
        Me.UcBuscarCURSO_TEMA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCURSO_TEMA1.TabIndex = 0
        '
        'frmBuscarCURSO_TEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCURSO_TEMA1)
        Me.Name = "frmBuscarCURSO_TEMA"
        Me.Text = "Buscar CURSO_TEMA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCURSO_TEMA1 As SGAFP.ucBuscarCURSO_TEMA
End Class
