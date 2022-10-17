Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPROCESO
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
        Me.UcBuscarPROCESO1 = New SGAFP.ucBuscarPROCESO
        Me.SuspendLayout()
        '
        'UcBuscarPROCESO1
        '
        Me.UcBuscarPROCESO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarPROCESO1.EntityType = GetType(PROCESO)
        Me.UcBuscarPROCESO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarPROCESO1.Name = "UcBuscarPROCESO1"
        Me.UcBuscarPROCESO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarPROCESO1.TabIndex = 0
        '
        'frmBuscarPROCESO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarPROCESO1)
        Me.Name = "frmBuscarPROCESO"
        Me.Text = "Buscar PROCESO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarPROCESO1 As SGAFP.ucBuscarPROCESO
End Class
