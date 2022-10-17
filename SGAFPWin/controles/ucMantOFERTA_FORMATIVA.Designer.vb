Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantOFERTA_FORMATIVA
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
        Me.UcListaOFERTA_FORMATIVA1 = New SGAFP.ucListaOFERTA_FORMATIVA
        Me.UcDetalleOFERTA_FORMATIVA1 = New SGAFP.ucDetalleOFERTA_FORMATIVA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaOFERTA_FORMATIVA1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleOFERTA_FORMATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaOFERTA_FORMATIVA1
        '
        Me.UcListaOFERTA_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaOFERTA_FORMATIVA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaOFERTA_FORMATIVA1.Name = "UcListaOFERTA_FORMATIVA1"
        Me.UcListaOFERTA_FORMATIVA1.PermitirBuscarEntityType = GetType(OFERTA_FORMATIVA)
        Me.UcListaOFERTA_FORMATIVA1.sError = Nothing
        Me.UcListaOFERTA_FORMATIVA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaOFERTA_FORMATIVA1.TabIndex = 1
        '
        'UcDetalleOFERTA_FORMATIVA1
        '
        Me.UcDetalleOFERTA_FORMATIVA1.AutoScroll = True
        Me.UcDetalleOFERTA_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleOFERTA_FORMATIVA1.EsNuevo = False
        Me.UcDetalleOFERTA_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleOFERTA_FORMATIVA1.Name = "UcDetalleOFERTA_FORMATIVA1"
        Me.UcDetalleOFERTA_FORMATIVA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleOFERTA_FORMATIVA1.TabIndex = 0
        '
        'ucMantOFERTA_FORMATIVA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantOFERTA_FORMATIVA"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaOFERTA_FORMATIVA1 As SGAFP.ucListaOFERTA_FORMATIVA
    Friend WithEvents UcDetalleOFERTA_FORMATIVA1 As SGAFP.UcDetalleOFERTA_FORMATIVA

End Class
