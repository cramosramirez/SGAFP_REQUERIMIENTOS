Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGRUPO_ACCION_CONTRATADA
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
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1 = New SGAFP.ucBuscarGRUPO_ACCION_CONTRATADA
        Me.SuspendLayout()
        '
        'UcBuscarGRUPO_ACCION_CONTRATADA1
        '
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.EntityType = GetType(GRUPO_ACCION_CONTRATADA)
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.Name = "UcBuscarGRUPO_ACCION_CONTRATADA1"
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarGRUPO_ACCION_CONTRATADA1.TabIndex = 0
        '
        'frmBuscarGRUPO_ACCION_CONTRATADA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarGRUPO_ACCION_CONTRATADA1)
        Me.Name = "frmBuscarGRUPO_ACCION_CONTRATADA"
        Me.Text = "Buscar GRUPO_ACCION_CONTRATADA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarGRUPO_ACCION_CONTRATADA1 As SGAFP.ucBuscarGRUPO_ACCION_CONTRATADA
End Class
