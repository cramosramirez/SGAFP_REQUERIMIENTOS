Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantREGION
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
        Me.UcListaREGION1 = New SGAFP.ucListaREGION
        Me.UcDetalleREGION1 = New SGAFP.ucDetalleREGION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaREGION1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleREGION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaREGION1
        '
        Me.UcListaREGION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaREGION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaREGION1.Name = "UcListaREGION1"
        Me.UcListaREGION1.PermitirBuscarEntityType = GetType(REGION)
        Me.UcListaREGION1.sError = Nothing
        Me.UcListaREGION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaREGION1.TabIndex = 1
        '
        'UcDetalleREGION1
        '
        Me.UcDetalleREGION1.AutoScroll = True
        Me.UcDetalleREGION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleREGION1.EsNuevo = False
        Me.UcDetalleREGION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleREGION1.Name = "UcDetalleREGION1"
        Me.UcDetalleREGION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleREGION1.TabIndex = 0
        '
        'ucMantREGION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantREGION"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaREGION1 As SGAFP.ucListaREGION
    Friend WithEvents UcDetalleREGION1 As SGAFP.UcDetalleREGION

End Class
