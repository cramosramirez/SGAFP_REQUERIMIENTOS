Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantHALLAZGO_SUPERVISION
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
        Me.UcListaHALLAZGO_SUPERVISION1 = New SGAFP.ucListaHALLAZGO_SUPERVISION
        Me.UcDetalleHALLAZGO_SUPERVISION1 = New SGAFP.ucDetalleHALLAZGO_SUPERVISION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaHALLAZGO_SUPERVISION1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleHALLAZGO_SUPERVISION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaHALLAZGO_SUPERVISION1
        '
        Me.UcListaHALLAZGO_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaHALLAZGO_SUPERVISION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaHALLAZGO_SUPERVISION1.Name = "UcListaHALLAZGO_SUPERVISION1"
        Me.UcListaHALLAZGO_SUPERVISION1.PermitirBuscarEntityType = GetType(HALLAZGO_SUPERVISION)
        Me.UcListaHALLAZGO_SUPERVISION1.sError = Nothing
        Me.UcListaHALLAZGO_SUPERVISION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaHALLAZGO_SUPERVISION1.TabIndex = 1
        '
        'UcDetalleHALLAZGO_SUPERVISION1
        '
        Me.UcDetalleHALLAZGO_SUPERVISION1.AutoScroll = True
        Me.UcDetalleHALLAZGO_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleHALLAZGO_SUPERVISION1.EsNuevo = False
        Me.UcDetalleHALLAZGO_SUPERVISION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleHALLAZGO_SUPERVISION1.Name = "UcDetalleHALLAZGO_SUPERVISION1"
        Me.UcDetalleHALLAZGO_SUPERVISION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleHALLAZGO_SUPERVISION1.TabIndex = 0
        '
        'ucMantHALLAZGO_SUPERVISION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantHALLAZGO_SUPERVISION"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaHALLAZGO_SUPERVISION1 As SGAFP.ucListaHALLAZGO_SUPERVISION
    Friend WithEvents UcDetalleHALLAZGO_SUPERVISION1 As SGAFP.UcDetalleHALLAZGO_SUPERVISION

End Class
