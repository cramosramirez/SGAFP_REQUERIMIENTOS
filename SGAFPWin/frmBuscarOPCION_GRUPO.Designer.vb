Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarOPCION_GRUPO
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
        Me.UcBuscarOPCION_GRUPO1 = New SGAFP.ucBuscarOPCION_GRUPO
        Me.SuspendLayout()
        '
        'UcBuscarOPCION_GRUPO1
        '
        Me.UcBuscarOPCION_GRUPO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarOPCION_GRUPO1.EntityType = GetType(OPCION_GRUPO)
        Me.UcBuscarOPCION_GRUPO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarOPCION_GRUPO1.Name = "UcBuscarOPCION_GRUPO1"
        Me.UcBuscarOPCION_GRUPO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarOPCION_GRUPO1.TabIndex = 0
        '
        'frmBuscarOPCION_GRUPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarOPCION_GRUPO1)
        Me.Name = "frmBuscarOPCION_GRUPO"
        Me.Text = "Buscar OPCION_GRUPO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarOPCION_GRUPO1 As SGAFP.ucBuscarOPCION_GRUPO
End Class
