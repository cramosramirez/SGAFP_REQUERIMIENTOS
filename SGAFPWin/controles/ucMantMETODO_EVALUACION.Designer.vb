Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantMETODO_EVALUACION
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
        Me.UcListaMETODO_EVALUACION1 = New SGAFP.ucListaMETODO_EVALUACION
        Me.UcDetalleMETODO_EVALUACION1 = New SGAFP.ucDetalleMETODO_EVALUACION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaMETODO_EVALUACION1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleMETODO_EVALUACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaMETODO_EVALUACION1
        '
        Me.UcListaMETODO_EVALUACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaMETODO_EVALUACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaMETODO_EVALUACION1.Name = "UcListaMETODO_EVALUACION1"
        Me.UcListaMETODO_EVALUACION1.PermitirBuscarEntityType = GetType(METODO_EVALUACION)
        Me.UcListaMETODO_EVALUACION1.sError = Nothing
        Me.UcListaMETODO_EVALUACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaMETODO_EVALUACION1.TabIndex = 1
        '
        'UcDetalleMETODO_EVALUACION1
        '
        Me.UcDetalleMETODO_EVALUACION1.AutoScroll = True
        Me.UcDetalleMETODO_EVALUACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleMETODO_EVALUACION1.EsNuevo = False
        Me.UcDetalleMETODO_EVALUACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleMETODO_EVALUACION1.Name = "UcDetalleMETODO_EVALUACION1"
        Me.UcDetalleMETODO_EVALUACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleMETODO_EVALUACION1.TabIndex = 0
        '
        'ucMantMETODO_EVALUACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantMETODO_EVALUACION"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaMETODO_EVALUACION1 As SGAFP.ucListaMETODO_EVALUACION
    Friend WithEvents UcDetalleMETODO_EVALUACION1 As SGAFP.UcDetalleMETODO_EVALUACION

End Class
