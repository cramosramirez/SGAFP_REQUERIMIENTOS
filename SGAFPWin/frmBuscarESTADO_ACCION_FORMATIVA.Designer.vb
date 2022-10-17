Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarESTADO_ACCION_FORMATIVA
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
        Me.UcBuscarESTADO_ACCION_FORMATIVA1 = New SGAFP.ucBuscarESTADO_ACCION_FORMATIVA
        Me.SuspendLayout()
        '
        'UcBuscarESTADO_ACCION_FORMATIVA1
        '
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.EntityType = GetType(ESTADO_ACCION_FORMATIVA)
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.Name = "UcBuscarESTADO_ACCION_FORMATIVA1"
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarESTADO_ACCION_FORMATIVA1.TabIndex = 0
        '
        'frmBuscarESTADO_ACCION_FORMATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarESTADO_ACCION_FORMATIVA1)
        Me.Name = "frmBuscarESTADO_ACCION_FORMATIVA"
        Me.Text = "Buscar ESTADO_ACCION_FORMATIVA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarESTADO_ACCION_FORMATIVA1 As SGAFP.ucBuscarESTADO_ACCION_FORMATIVA
End Class
