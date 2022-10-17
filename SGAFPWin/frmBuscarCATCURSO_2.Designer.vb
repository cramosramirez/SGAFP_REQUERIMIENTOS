Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCATCURSO_2
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
        Me.UcBuscarCATCURSO_21 = New SGAFP.ucBuscarCATCURSO_2
        Me.SuspendLayout()
        '
        'UcBuscarCATCURSO_21
        '
        Me.UcBuscarCATCURSO_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCATCURSO_21.EntityType = GetType(CATCURSO_2)
        Me.UcBuscarCATCURSO_21.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCATCURSO_21.Name = "UcBuscarCATCURSO_21"
        Me.UcBuscarCATCURSO_21.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCATCURSO_21.TabIndex = 0
        '
        'frmBuscarCATCURSO_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCATCURSO_21)
        Me.Name = "frmBuscarCATCURSO_2"
        Me.Text = "Buscar CATCURSO_2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCATCURSO_21 As SGAFP.ucBuscarCATCURSO_2
End Class
