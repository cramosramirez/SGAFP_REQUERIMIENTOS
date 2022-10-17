Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantGRUPO_USUARIO
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
        Me.UcListaGRUPO_USUARIO1 = New SGAFP.ucListaGRUPO_USUARIO
        Me.UcDetalleGRUPO_USUARIO1 = New SGAFP.ucDetalleGRUPO_USUARIO
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaGRUPO_USUARIO1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleGRUPO_USUARIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaGRUPO_USUARIO1
        '
        Me.UcListaGRUPO_USUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaGRUPO_USUARIO1.Location = New System.Drawing.Point(0,0)
        Me.UcListaGRUPO_USUARIO1.Name = "UcListaGRUPO_USUARIO1"
        Me.UcListaGRUPO_USUARIO1.PermitirBuscarEntityType = GetType(GRUPO_USUARIO)
        Me.UcListaGRUPO_USUARIO1.sError = Nothing
        Me.UcListaGRUPO_USUARIO1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaGRUPO_USUARIO1.TabIndex = 1
        '
        'UcDetalleGRUPO_USUARIO1
        '
        Me.UcDetalleGRUPO_USUARIO1.AutoScroll = True
        Me.UcDetalleGRUPO_USUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleGRUPO_USUARIO1.EsNuevo = False
        Me.UcDetalleGRUPO_USUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleGRUPO_USUARIO1.Name = "UcDetalleGRUPO_USUARIO1"
        Me.UcDetalleGRUPO_USUARIO1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleGRUPO_USUARIO1.TabIndex = 0
        '
        'ucMantGRUPO_USUARIO
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantGRUPO_USUARIO"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaGRUPO_USUARIO1 As SGAFP.ucListaGRUPO_USUARIO
    Friend WithEvents UcDetalleGRUPO_USUARIO1 As SGAFP.UcDetalleGRUPO_USUARIO

End Class
