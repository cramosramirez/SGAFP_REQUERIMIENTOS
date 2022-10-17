Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantACCION_FORMATIVA
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
        Me.UcListaACCION_FORMATIVA1 = New SGAFP.ucListaACCION_FORMATIVA
        Me.UcDetalleACCION_FORMATIVA1 = New SGAFP.ucDetalleACCION_FORMATIVA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaACCION_FORMATIVA1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleACCION_FORMATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaACCION_FORMATIVA1
        '
        Me.UcListaACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_FORMATIVA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaACCION_FORMATIVA1.Name = "UcListaACCION_FORMATIVA1"
        Me.UcListaACCION_FORMATIVA1.PermitirBuscarEntityType = GetType(ACCION_FORMATIVA)
        Me.UcListaACCION_FORMATIVA1.sError = Nothing
        Me.UcListaACCION_FORMATIVA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaACCION_FORMATIVA1.TabIndex = 1
        '
        'UcDetalleACCION_FORMATIVA1
        '
        Me.UcDetalleACCION_FORMATIVA1.AutoScroll = True
        Me.UcDetalleACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleACCION_FORMATIVA1.EsNuevo = False
        Me.UcDetalleACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleACCION_FORMATIVA1.Name = "UcDetalleACCION_FORMATIVA1"
        Me.UcDetalleACCION_FORMATIVA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleACCION_FORMATIVA1.TabIndex = 0
        '
        'ucMantACCION_FORMATIVA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaACCION_FORMATIVA1 As SGAFP.ucListaACCION_FORMATIVA
    Friend WithEvents UcDetalleACCION_FORMATIVA1 As SGAFP.UcDetalleACCION_FORMATIVA

End Class
