Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCURSO_TEMA
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
        Me.UcListaCURSO_TEMA1 = New SGAFP.ucListaCURSO_TEMA
        Me.UcDetalleCURSO_TEMA1 = New SGAFP.ucDetalleCURSO_TEMA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCURSO_TEMA1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCURSO_TEMA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaCURSO_TEMA1
        '
        Me.UcListaCURSO_TEMA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCURSO_TEMA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCURSO_TEMA1.Name = "UcListaCURSO_TEMA1"
        Me.UcListaCURSO_TEMA1.PermitirBuscarEntityType = GetType(CURSO_TEMA)
        Me.UcListaCURSO_TEMA1.sError = Nothing
        Me.UcListaCURSO_TEMA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCURSO_TEMA1.TabIndex = 1
        '
        'UcDetalleCURSO_TEMA1
        '
        Me.UcDetalleCURSO_TEMA1.AutoScroll = True
        Me.UcDetalleCURSO_TEMA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCURSO_TEMA1.EsNuevo = False
        Me.UcDetalleCURSO_TEMA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCURSO_TEMA1.Name = "UcDetalleCURSO_TEMA1"
        Me.UcDetalleCURSO_TEMA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCURSO_TEMA1.TabIndex = 0
        '
        'ucMantCURSO_TEMA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCURSO_TEMA"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaCURSO_TEMA1 As SGAFP.ucListaCURSO_TEMA
    Friend WithEvents UcDetalleCURSO_TEMA1 As SGAFP.UcDetalleCURSO_TEMA

End Class
