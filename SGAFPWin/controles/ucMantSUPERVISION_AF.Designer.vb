Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSUPERVISION_AF
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
        Me.UcListaSUPERVISION_AF1 = New SGAFP.ucListaSUPERVISION_AF
        Me.UcDetalleSUPERVISION_AF1 = New SGAFP.ucDetalleSUPERVISION_AF
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSUPERVISION_AF1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSUPERVISION_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaSUPERVISION_AF1
        '
        Me.UcListaSUPERVISION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSUPERVISION_AF1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSUPERVISION_AF1.Name = "UcListaSUPERVISION_AF1"
        Me.UcListaSUPERVISION_AF1.PermitirBuscarEntityType = GetType(SUPERVISION_AF)
        Me.UcListaSUPERVISION_AF1.sError = Nothing
        Me.UcListaSUPERVISION_AF1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSUPERVISION_AF1.TabIndex = 1
        '
        'UcDetalleSUPERVISION_AF1
        '
        Me.UcDetalleSUPERVISION_AF1.AutoScroll = True
        Me.UcDetalleSUPERVISION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSUPERVISION_AF1.EsNuevo = False
        Me.UcDetalleSUPERVISION_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSUPERVISION_AF1.Name = "UcDetalleSUPERVISION_AF1"
        Me.UcDetalleSUPERVISION_AF1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSUPERVISION_AF1.TabIndex = 0
        '
        'ucMantSUPERVISION_AF
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSUPERVISION_AF"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaSUPERVISION_AF1 As SGAFP.ucListaSUPERVISION_AF
    Friend WithEvents UcDetalleSUPERVISION_AF1 As SGAFP.UcDetalleSUPERVISION_AF

End Class
