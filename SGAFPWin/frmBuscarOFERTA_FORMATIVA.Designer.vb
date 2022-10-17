Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarOFERTA_FORMATIVA
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
        Me.UcBuscarOFERTA_FORMATIVA1 = New SGAFP.ucBuscarOFERTA_FORMATIVA
        Me.SuspendLayout()
        '
        'UcBuscarOFERTA_FORMATIVA1
        '
        Me.UcBuscarOFERTA_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarOFERTA_FORMATIVA1.EntityType = GetType(OFERTA_FORMATIVA)
        Me.UcBuscarOFERTA_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarOFERTA_FORMATIVA1.Name = "UcBuscarOFERTA_FORMATIVA1"
        Me.UcBuscarOFERTA_FORMATIVA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarOFERTA_FORMATIVA1.TabIndex = 0
        '
        'frmBuscarOFERTA_FORMATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarOFERTA_FORMATIVA1)
        Me.Name = "frmBuscarOFERTA_FORMATIVA"
        Me.Text = "Buscar OFERTA_FORMATIVA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarOFERTA_FORMATIVA1 As SGAFP.ucBuscarOFERTA_FORMATIVA
End Class
