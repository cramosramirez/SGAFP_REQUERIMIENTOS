Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSOLIC_CURSOS_RECIBIDOS
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
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1 = New SGAFP.ucListaSOLIC_CURSOS_RECIBIDOS
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1 = New SGAFP.ucDetalleSOLIC_CURSOS_RECIBIDOS
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSOLIC_CURSOS_RECIBIDOS1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaSOLIC_CURSOS_RECIBIDOS1
        '
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Name = "UcListaSOLIC_CURSOS_RECIBIDOS1"
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirBuscarEntityType = GetType(SOLIC_CURSOS_RECIBIDOS)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.sError = Nothing
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.TabIndex = 1
        '
        'UcDetalleSOLIC_CURSOS_RECIBIDOS1
        '
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.AutoScroll = True
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.EsNuevo = False
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.Name = "UcDetalleSOLIC_CURSOS_RECIBIDOS1"
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSOLIC_CURSOS_RECIBIDOS1.TabIndex = 0
        '
        'ucMantSOLIC_CURSOS_RECIBIDOS
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSOLIC_CURSOS_RECIBIDOS"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaSOLIC_CURSOS_RECIBIDOS1 As SGAFP.ucListaSOLIC_CURSOS_RECIBIDOS
    Friend WithEvents UcDetalleSOLIC_CURSOS_RECIBIDOS1 As SGAFP.UcDetalleSOLIC_CURSOS_RECIBIDOS

End Class
