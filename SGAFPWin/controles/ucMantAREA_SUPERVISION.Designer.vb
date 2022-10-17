Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantAREA_SUPERVISION
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
        Me.UcListaAREA_SUPERVISION1 = New SGAFP.ucListaAREA_SUPERVISION
        Me.UcDetalleAREA_SUPERVISION1 = New SGAFP.ucDetalleAREA_SUPERVISION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaAREA_SUPERVISION1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleAREA_SUPERVISION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaAREA_SUPERVISION1
        '
        Me.UcListaAREA_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaAREA_SUPERVISION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaAREA_SUPERVISION1.Name = "UcListaAREA_SUPERVISION1"
        Me.UcListaAREA_SUPERVISION1.PermitirBuscarEntityType = GetType(AREA_SUPERVISION)
        Me.UcListaAREA_SUPERVISION1.sError = Nothing
        Me.UcListaAREA_SUPERVISION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaAREA_SUPERVISION1.TabIndex = 1
        '
        'UcDetalleAREA_SUPERVISION1
        '
        Me.UcDetalleAREA_SUPERVISION1.AutoScroll = True
        Me.UcDetalleAREA_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleAREA_SUPERVISION1.EsNuevo = False
        Me.UcDetalleAREA_SUPERVISION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleAREA_SUPERVISION1.Name = "UcDetalleAREA_SUPERVISION1"
        Me.UcDetalleAREA_SUPERVISION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleAREA_SUPERVISION1.TabIndex = 0
        '
        'ucMantAREA_SUPERVISION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantAREA_SUPERVISION"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaAREA_SUPERVISION1 As SGAFP.ucListaAREA_SUPERVISION
    Friend WithEvents UcDetalleAREA_SUPERVISION1 As SGAFP.UcDetalleAREA_SUPERVISION

End Class
