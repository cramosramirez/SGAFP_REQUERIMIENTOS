Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantTERMINO_REFERENCIA_AF
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
        Me.SplitContainer1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaTERMINO_REFERENCIA_AF1 = New SGAFP.ucListaTERMINO_REFERENCIA_AF
        Me.UcDetalleTERMINO_REFERENCIA_AF1 = New SGAFP.ucDetalleTERMINO_REFERENCIA_AF
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FireScrollEventOnMouseWheel = True
        Me.SplitContainer1.Horizontal = False
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaTERMINO_REFERENCIA_AF1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleTERMINO_REFERENCIA_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaTERMINO_REFERENCIA_AF1
        '
        Me.UcListaTERMINO_REFERENCIA_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaTERMINO_REFERENCIA_AF1.Location = New System.Drawing.Point(0,0)
        Me.UcListaTERMINO_REFERENCIA_AF1.Name = "UcListaTERMINO_REFERENCIA_AF1"
        Me.UcListaTERMINO_REFERENCIA_AF1.PermitirBuscarEntityType = GetType(TERMINO_REFERENCIA_AF)
        Me.UcListaTERMINO_REFERENCIA_AF1.sError = Nothing
        Me.UcListaTERMINO_REFERENCIA_AF1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaTERMINO_REFERENCIA_AF1.TabIndex = 1
        '
        'UcDetalleTERMINO_REFERENCIA_AF1
        '
        Me.UcDetalleTERMINO_REFERENCIA_AF1.AutoScroll = True
        Me.UcDetalleTERMINO_REFERENCIA_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleTERMINO_REFERENCIA_AF1.EsNuevo = False
        Me.UcDetalleTERMINO_REFERENCIA_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleTERMINO_REFERENCIA_AF1.Name = "UcDetalleTERMINO_REFERENCIA_AF1"
        Me.UcDetalleTERMINO_REFERENCIA_AF1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleTERMINO_REFERENCIA_AF1.TabIndex = 0
        '
        'ucMantTERMINO_REFERENCIA_AF
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantTERMINO_REFERENCIA_AF"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaTERMINO_REFERENCIA_AF1 As SGAFP.ucListaTERMINO_REFERENCIA_AF
    Friend WithEvents UcDetalleTERMINO_REFERENCIA_AF1 As SGAFP.UcDetalleTERMINO_REFERENCIA_AF

End Class
