Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantEVALUACIONES_AF_DET
    Inherits SGAFP.ucBaseMant

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UcListaEVALUACIONES_AF_DET1 = New SGAFP.ucListaEVALUACIONES_AF_DET
        Me.UcDetalleEVALUACIONES_AF_DET1 = New SGAFP.ucDetalleEVALUACIONES_AF_DET
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaEVALUACIONES_AF_DET1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleEVALUACIONES_AF_DET1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaEVALUACIONES_AF_DET1
        '
        Me.UcListaEVALUACIONES_AF_DET1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEVALUACIONES_AF_DET1.Location = New System.Drawing.Point(0,0)
        Me.UcListaEVALUACIONES_AF_DET1.Name = "UcListaEVALUACIONES_AF_DET1"
        Me.UcListaEVALUACIONES_AF_DET1.PermitirBuscarEntityType = GetType(EVALUACIONES_AF_DET)
        Me.UcListaEVALUACIONES_AF_DET1.sError = Nothing
        Me.UcListaEVALUACIONES_AF_DET1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaEVALUACIONES_AF_DET1.TabIndex = 1
        '
        'UcDetalleEVALUACIONES_AF_DET1
        '
        Me.UcDetalleEVALUACIONES_AF_DET1.AutoScroll = True
        Me.UcDetalleEVALUACIONES_AF_DET1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleEVALUACIONES_AF_DET1.EsNuevo = False
        Me.UcDetalleEVALUACIONES_AF_DET1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleEVALUACIONES_AF_DET1.Name = "UcDetalleEVALUACIONES_AF_DET1"
        Me.UcDetalleEVALUACIONES_AF_DET1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleEVALUACIONES_AF_DET1.TabIndex = 0
        '
        'ucMantEVALUACIONES_AF_DET
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantEVALUACIONES_AF_DET"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaEVALUACIONES_AF_DET1 As SGAFP.ucListaEVALUACIONES_AF_DET
    Friend WithEvents UcDetalleEVALUACIONES_AF_DET1 As SGAFP.UcDetalleEVALUACIONES_AF_DET

End Class
