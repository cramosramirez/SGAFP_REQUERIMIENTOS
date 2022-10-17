Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantPROGRAMA_FORMACION
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
        Me.UcListaPROGRAMA_FORMACION1 = New SGAFP.ucListaPROGRAMA_FORMACION
        Me.UcDetallePROGRAMA_FORMACION1 = New SGAFP.ucDetallePROGRAMA_FORMACION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaPROGRAMA_FORMACION1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetallePROGRAMA_FORMACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaPROGRAMA_FORMACION1
        '
        Me.UcListaPROGRAMA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPROGRAMA_FORMACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaPROGRAMA_FORMACION1.Name = "UcListaPROGRAMA_FORMACION1"
        Me.UcListaPROGRAMA_FORMACION1.PermitirBuscarEntityType = GetType(PROGRAMA_FORMACION)
        Me.UcListaPROGRAMA_FORMACION1.sError = Nothing
        Me.UcListaPROGRAMA_FORMACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaPROGRAMA_FORMACION1.TabIndex = 1
        '
        'UcDetallePROGRAMA_FORMACION1
        '
        Me.UcDetallePROGRAMA_FORMACION1.AutoScroll = True
        Me.UcDetallePROGRAMA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetallePROGRAMA_FORMACION1.EsNuevo = False
        Me.UcDetallePROGRAMA_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetallePROGRAMA_FORMACION1.Name = "UcDetallePROGRAMA_FORMACION1"
        Me.UcDetallePROGRAMA_FORMACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetallePROGRAMA_FORMACION1.TabIndex = 0
        '
        'ucMantPROGRAMA_FORMACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantPROGRAMA_FORMACION"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaPROGRAMA_FORMACION1 As SGAFP.ucListaPROGRAMA_FORMACION
    Friend WithEvents UcDetallePROGRAMA_FORMACION1 As SGAFP.UcDetallePROGRAMA_FORMACION

End Class
