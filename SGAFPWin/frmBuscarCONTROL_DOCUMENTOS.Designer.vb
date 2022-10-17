Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCONTROL_DOCUMENTOS
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
        Me.UcBuscarCONTROL_DOCUMENTOS1 = New SGAFP.ucBuscarCONTROL_DOCUMENTOS
        Me.SuspendLayout()
        '
        'UcBuscarCONTROL_DOCUMENTOS1
        '
        Me.UcBuscarCONTROL_DOCUMENTOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCONTROL_DOCUMENTOS1.EntityType = GetType(CONTROL_DOCUMENTOS)
        Me.UcBuscarCONTROL_DOCUMENTOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCONTROL_DOCUMENTOS1.Name = "UcBuscarCONTROL_DOCUMENTOS1"
        Me.UcBuscarCONTROL_DOCUMENTOS1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCONTROL_DOCUMENTOS1.TabIndex = 0
        '
        'frmBuscarCONTROL_DOCUMENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCONTROL_DOCUMENTOS1)
        Me.Name = "frmBuscarCONTROL_DOCUMENTOS"
        Me.Text = "Buscar CONTROL_DOCUMENTOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCONTROL_DOCUMENTOS1 As SGAFP.ucBuscarCONTROL_DOCUMENTOS
End Class
