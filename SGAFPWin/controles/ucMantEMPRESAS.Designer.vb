Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantEMPRESAS
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
        Me.UcListaEMPRESAS1 = New SGAFP.ucListaEMPRESAS
        Me.UcDetalleEMPRESAS1 = New SGAFP.ucDetalleEMPRESAS
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaEMPRESAS1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleEMPRESAS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaEMPRESAS1
        '
        Me.UcListaEMPRESAS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEMPRESAS1.Location = New System.Drawing.Point(0,0)
        Me.UcListaEMPRESAS1.Name = "UcListaEMPRESAS1"
        Me.UcListaEMPRESAS1.PermitirBuscarEntityType = GetType(EMPRESAS)
        Me.UcListaEMPRESAS1.sError = Nothing
        Me.UcListaEMPRESAS1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaEMPRESAS1.TabIndex = 1
        '
        'UcDetalleEMPRESAS1
        '
        Me.UcDetalleEMPRESAS1.AutoScroll = True
        Me.UcDetalleEMPRESAS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleEMPRESAS1.EsNuevo = False
        Me.UcDetalleEMPRESAS1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleEMPRESAS1.Name = "UcDetalleEMPRESAS1"
        Me.UcDetalleEMPRESAS1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleEMPRESAS1.TabIndex = 0
        '
        'ucMantEMPRESAS
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantEMPRESAS"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaEMPRESAS1 As SGAFP.ucListaEMPRESAS
    Friend WithEvents UcDetalleEMPRESAS1 As SGAFP.UcDetalleEMPRESAS

End Class
