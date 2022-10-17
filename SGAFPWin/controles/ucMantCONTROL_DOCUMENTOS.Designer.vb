Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCONTROL_DOCUMENTOS
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
        Me.UcListaCONTROL_DOCUMENTOS1 = New SGAFP.ucListaCONTROL_DOCUMENTOS
        Me.UcDetalleCONTROL_DOCUMENTOS1 = New SGAFP.ucDetalleCONTROL_DOCUMENTOS
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCONTROL_DOCUMENTOS1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCONTROL_DOCUMENTOS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaCONTROL_DOCUMENTOS1
        '
        Me.UcListaCONTROL_DOCUMENTOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTROL_DOCUMENTOS1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCONTROL_DOCUMENTOS1.Name = "UcListaCONTROL_DOCUMENTOS1"
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirBuscarEntityType = GetType(CONTROL_DOCUMENTOS)
        Me.UcListaCONTROL_DOCUMENTOS1.sError = Nothing
        Me.UcListaCONTROL_DOCUMENTOS1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCONTROL_DOCUMENTOS1.TabIndex = 1
        '
        'UcDetalleCONTROL_DOCUMENTOS1
        '
        Me.UcDetalleCONTROL_DOCUMENTOS1.AutoScroll = True
        Me.UcDetalleCONTROL_DOCUMENTOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCONTROL_DOCUMENTOS1.EsNuevo = False
        Me.UcDetalleCONTROL_DOCUMENTOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCONTROL_DOCUMENTOS1.Name = "UcDetalleCONTROL_DOCUMENTOS1"
        Me.UcDetalleCONTROL_DOCUMENTOS1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCONTROL_DOCUMENTOS1.TabIndex = 0
        '
        'ucMantCONTROL_DOCUMENTOS
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCONTROL_DOCUMENTOS"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaCONTROL_DOCUMENTOS1 As SGAFP.ucListaCONTROL_DOCUMENTOS
    Friend WithEvents UcDetalleCONTROL_DOCUMENTOS1 As SGAFP.UcDetalleCONTROL_DOCUMENTOS

End Class
