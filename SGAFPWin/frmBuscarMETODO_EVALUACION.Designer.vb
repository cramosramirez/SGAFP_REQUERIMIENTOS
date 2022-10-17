Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarMETODO_EVALUACION
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
        Me.UcBuscarMETODO_EVALUACION1 = New SGAFP.ucBuscarMETODO_EVALUACION
        Me.SuspendLayout()
        '
        'UcBuscarMETODO_EVALUACION1
        '
        Me.UcBuscarMETODO_EVALUACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarMETODO_EVALUACION1.EntityType = GetType(METODO_EVALUACION)
        Me.UcBuscarMETODO_EVALUACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarMETODO_EVALUACION1.Name = "UcBuscarMETODO_EVALUACION1"
        Me.UcBuscarMETODO_EVALUACION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarMETODO_EVALUACION1.TabIndex = 0
        '
        'frmBuscarMETODO_EVALUACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarMETODO_EVALUACION1)
        Me.Name = "frmBuscarMETODO_EVALUACION"
        Me.Text = "Buscar METODO_EVALUACION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarMETODO_EVALUACION1 As SGAFP.ucBuscarMETODO_EVALUACION
End Class
