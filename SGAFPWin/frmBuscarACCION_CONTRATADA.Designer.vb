Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarACCION_CONTRATADA
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
        Me.UcBuscarACCION_CONTRATADA1 = New SGAFP.ucBuscarACCION_CONTRATADA
        Me.SuspendLayout()
        '
        'UcBuscarACCION_CONTRATADA1
        '
        Me.UcBuscarACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarACCION_CONTRATADA1.EntityType = GetType(ACCION_CONTRATADA)
        Me.UcBuscarACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarACCION_CONTRATADA1.Name = "UcBuscarACCION_CONTRATADA1"
        Me.UcBuscarACCION_CONTRATADA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarACCION_CONTRATADA1.TabIndex = 0
        '
        'frmBuscarACCION_CONTRATADA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarACCION_CONTRATADA1)
        Me.Name = "frmBuscarACCION_CONTRATADA"
        Me.Text = "Buscar ACCION_CONTRATADA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarACCION_CONTRATADA1 As SGAFP.ucBuscarACCION_CONTRATADA
End Class
