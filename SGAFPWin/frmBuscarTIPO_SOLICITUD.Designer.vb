Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarTIPO_SOLICITUD
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
        Me.UcBuscarTIPO_SOLICITUD1 = New SGAFP.ucBuscarTIPO_SOLICITUD
        Me.SuspendLayout()
        '
        'UcBuscarTIPO_SOLICITUD1
        '
        Me.UcBuscarTIPO_SOLICITUD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarTIPO_SOLICITUD1.EntityType = GetType(TIPO_SOLICITUD)
        Me.UcBuscarTIPO_SOLICITUD1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarTIPO_SOLICITUD1.Name = "UcBuscarTIPO_SOLICITUD1"
        Me.UcBuscarTIPO_SOLICITUD1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarTIPO_SOLICITUD1.TabIndex = 0
        '
        'frmBuscarTIPO_SOLICITUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarTIPO_SOLICITUD1)
        Me.Name = "frmBuscarTIPO_SOLICITUD"
        Me.Text = "Buscar TIPO_SOLICITUD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarTIPO_SOLICITUD1 As SGAFP.ucBuscarTIPO_SOLICITUD
End Class
