Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantOPCION_MENU
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
        Me.UcListaOPCION_MENU1 = New SGAFP.ucListaOPCION_MENU
        Me.UcDetalleOPCION_MENU1 = New SGAFP.ucDetalleOPCION_MENU
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaOPCION_MENU1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleOPCION_MENU1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaOPCION_MENU1
        '
        Me.UcListaOPCION_MENU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaOPCION_MENU1.Location = New System.Drawing.Point(0,0)
        Me.UcListaOPCION_MENU1.Name = "UcListaOPCION_MENU1"
        Me.UcListaOPCION_MENU1.PermitirBuscarEntityType = GetType(OPCION_MENU)
        Me.UcListaOPCION_MENU1.sError = Nothing
        Me.UcListaOPCION_MENU1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaOPCION_MENU1.TabIndex = 1
        '
        'UcDetalleOPCION_MENU1
        '
        Me.UcDetalleOPCION_MENU1.AutoScroll = True
        Me.UcDetalleOPCION_MENU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleOPCION_MENU1.EsNuevo = False
        Me.UcDetalleOPCION_MENU1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleOPCION_MENU1.Name = "UcDetalleOPCION_MENU1"
        Me.UcDetalleOPCION_MENU1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleOPCION_MENU1.TabIndex = 0
        '
        'ucMantOPCION_MENU
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantOPCION_MENU"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaOPCION_MENU1 As SGAFP.ucListaOPCION_MENU
    Friend WithEvents UcDetalleOPCION_MENU1 As SGAFP.UcDetalleOPCION_MENU

End Class
