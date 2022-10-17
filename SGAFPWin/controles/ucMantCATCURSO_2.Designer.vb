Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCATCURSO_2
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
        Me.UcListaCATCURSO_21 = New SGAFP.ucListaCATCURSO_2
        Me.UcDetalleCATCURSO_21 = New SGAFP.ucDetalleCATCURSO_2
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCATCURSO_21)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCATCURSO_21)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaCATCURSO_21
        '
        Me.UcListaCATCURSO_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCATCURSO_21.Location = New System.Drawing.Point(0,0)
        Me.UcListaCATCURSO_21.Name = "UcListaCATCURSO_21"
        Me.UcListaCATCURSO_21.PermitirBuscarEntityType = GetType(CATCURSO_2)
        Me.UcListaCATCURSO_21.sError = Nothing
        Me.UcListaCATCURSO_21.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCATCURSO_21.TabIndex = 1
        '
        'UcDetalleCATCURSO_21
        '
        Me.UcDetalleCATCURSO_21.AutoScroll = True
        Me.UcDetalleCATCURSO_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCATCURSO_21.EsNuevo = False
        Me.UcDetalleCATCURSO_21.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCATCURSO_21.Name = "UcDetalleCATCURSO_21"
        Me.UcDetalleCATCURSO_21.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCATCURSO_21.TabIndex = 0
        '
        'ucMantCATCURSO_2
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCATCURSO_2"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaCATCURSO_21 As SGAFP.ucListaCATCURSO_2
    Friend WithEvents UcDetalleCATCURSO_21 As SGAFP.UcDetalleCATCURSO_2

End Class
