Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarESTADO_SOLICITUD
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
        Me.UcBuscarESTADO_SOLICITUD1 = New SGAFP.ucBuscarESTADO_SOLICITUD
        Me.SuspendLayout()
        '
        'UcBuscarESTADO_SOLICITUD1
        '
        Me.UcBuscarESTADO_SOLICITUD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarESTADO_SOLICITUD1.EntityType = GetType(ESTADO_SOLICITUD)
        Me.UcBuscarESTADO_SOLICITUD1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarESTADO_SOLICITUD1.Name = "UcBuscarESTADO_SOLICITUD1"
        Me.UcBuscarESTADO_SOLICITUD1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarESTADO_SOLICITUD1.TabIndex = 0
        '
        'frmBuscarESTADO_SOLICITUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarESTADO_SOLICITUD1)
        Me.Name = "frmBuscarESTADO_SOLICITUD"
        Me.Text = "Buscar ESTADO_SOLICITUD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarESTADO_SOLICITUD1 As SGAFP.ucBuscarESTADO_SOLICITUD
End Class
