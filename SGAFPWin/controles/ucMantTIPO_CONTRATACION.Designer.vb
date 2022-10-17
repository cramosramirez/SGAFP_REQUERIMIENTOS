Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantTIPO_CONTRATACION
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
        Me.UcListaTIPO_CONTRATACION1 = New SGAFP.ucListaTIPO_CONTRATACION
        Me.UcDetalleTIPO_CONTRATACION1 = New SGAFP.ucDetalleTIPO_CONTRATACION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaTIPO_CONTRATACION1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleTIPO_CONTRATACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaTIPO_CONTRATACION1
        '
        Me.UcListaTIPO_CONTRATACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaTIPO_CONTRATACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaTIPO_CONTRATACION1.Name = "UcListaTIPO_CONTRATACION1"
        Me.UcListaTIPO_CONTRATACION1.PermitirBuscarEntityType = GetType(TIPO_CONTRATACION)
        Me.UcListaTIPO_CONTRATACION1.sError = Nothing
        Me.UcListaTIPO_CONTRATACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaTIPO_CONTRATACION1.TabIndex = 1
        '
        'UcDetalleTIPO_CONTRATACION1
        '
        Me.UcDetalleTIPO_CONTRATACION1.AutoScroll = True
        Me.UcDetalleTIPO_CONTRATACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleTIPO_CONTRATACION1.EsNuevo = False
        Me.UcDetalleTIPO_CONTRATACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleTIPO_CONTRATACION1.Name = "UcDetalleTIPO_CONTRATACION1"
        Me.UcDetalleTIPO_CONTRATACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleTIPO_CONTRATACION1.TabIndex = 0
        '
        'ucMantTIPO_CONTRATACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantTIPO_CONTRATACION"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaTIPO_CONTRATACION1 As SGAFP.ucListaTIPO_CONTRATACION
    Friend WithEvents UcDetalleTIPO_CONTRATACION1 As SGAFP.UcDetalleTIPO_CONTRATACION

End Class
