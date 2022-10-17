Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCONTRATO_PROVEEDOR_AF
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
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1 = New SGAFP.ucBuscarCONTRATO_PROVEEDOR_AF
        Me.SuspendLayout()
        '
        'UcBuscarCONTRATO_PROVEEDOR_AF1
        '
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.EntityType = GetType(CONTRATO_PROVEEDOR_AF)
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.Name = "UcBuscarCONTRATO_PROVEEDOR_AF1"
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarCONTRATO_PROVEEDOR_AF1.TabIndex = 0
        '
        'frmBuscarCONTRATO_PROVEEDOR_AF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarCONTRATO_PROVEEDOR_AF1)
        Me.Name = "frmBuscarCONTRATO_PROVEEDOR_AF"
        Me.Text = "Buscar CONTRATO_PROVEEDOR_AF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarCONTRATO_PROVEEDOR_AF1 As SGAFP.ucBuscarCONTRATO_PROVEEDOR_AF
End Class
