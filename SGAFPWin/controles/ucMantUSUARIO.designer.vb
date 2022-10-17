Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantUSUARIO
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
        Me.UcListaUSUARIO1 = New SGAFP.ucListaUSUARIO
        Me.UcDetalleUSUARIO1 = New SGAFP.ucDetalleUSUARIO
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaUSUARIO1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleUSUARIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaUSUARIO1
        '
        Me.UcListaUSUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaUSUARIO1.Location = New System.Drawing.Point(0,0)
        Me.UcListaUSUARIO1.Name = "UcListaUSUARIO1"
        Me.UcListaUSUARIO1.PermitirBuscarEntityType = GetType(USUARIO)
        Me.UcListaUSUARIO1.sError = Nothing
        Me.UcListaUSUARIO1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaUSUARIO1.TabIndex = 1
        '
        'UcDetalleUSUARIO1
        '
        Me.UcDetalleUSUARIO1.AutoScroll = True
        Me.UcDetalleUSUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleUSUARIO1.EsNuevo = False
        Me.UcDetalleUSUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleUSUARIO1.Name = "UcDetalleUSUARIO1"
        Me.UcDetalleUSUARIO1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleUSUARIO1.TabIndex = 0
        '
        'ucMantUSUARIO
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantUSUARIO"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaUSUARIO1 As SGAFP.ucListaUSUARIO
    Friend WithEvents UcDetalleUSUARIO1 As SGAFP.UcDetalleUSUARIO

End Class
