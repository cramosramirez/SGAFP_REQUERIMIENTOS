Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCIUU
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
        Me.UcListaCIUU1 = New SGAFP.ucListaCIUU
        Me.UcDetalleCIUU1 = New SGAFP.ucDetalleCIUU
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCIUU1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCIUU1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaCIUU1
        '
        Me.UcListaCIUU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCIUU1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCIUU1.Name = "UcListaCIUU1"
        Me.UcListaCIUU1.PermitirBuscarEntityType = GetType(CIUU)
        Me.UcListaCIUU1.sError = Nothing
        Me.UcListaCIUU1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCIUU1.TabIndex = 1
        '
        'UcDetalleCIUU1
        '
        Me.UcDetalleCIUU1.AutoScroll = True
        Me.UcDetalleCIUU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCIUU1.EsNuevo = False
        Me.UcDetalleCIUU1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCIUU1.Name = "UcDetalleCIUU1"
        Me.UcDetalleCIUU1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCIUU1.TabIndex = 0
        '
        'ucMantCIUU
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCIUU"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaCIUU1 As SGAFP.ucListaCIUU
    Friend WithEvents UcDetalleCIUU1 As SGAFP.UcDetalleCIUU

End Class
