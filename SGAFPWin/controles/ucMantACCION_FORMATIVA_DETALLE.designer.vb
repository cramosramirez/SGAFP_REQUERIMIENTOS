Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantACCION_FORMATIVA_DETALLE
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
        Me.UcListaACCION_FORMATIVA_DETALLE1 = New SGAFP.ucListaACCION_FORMATIVA_DETALLE
        Me.UcDetalleACCION_FORMATIVA_DETALLE1 = New SGAFP.ucDetalleACCION_FORMATIVA_DETALLE
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaACCION_FORMATIVA_DETALLE1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleACCION_FORMATIVA_DETALLE1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaACCION_FORMATIVA_DETALLE1
        '
        Me.UcListaACCION_FORMATIVA_DETALLE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_FORMATIVA_DETALLE1.Location = New System.Drawing.Point(0,0)
        Me.UcListaACCION_FORMATIVA_DETALLE1.Name = "UcListaACCION_FORMATIVA_DETALLE1"
        Me.UcListaACCION_FORMATIVA_DETALLE1.PermitirBuscarEntityType = GetType(ACCION_FORMATIVA_DETALLE)
        Me.UcListaACCION_FORMATIVA_DETALLE1.sError = Nothing
        Me.UcListaACCION_FORMATIVA_DETALLE1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaACCION_FORMATIVA_DETALLE1.TabIndex = 1
        '
        'UcDetalleACCION_FORMATIVA_DETALLE1
        '
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.AutoScroll = True
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.EsNuevo = False
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.Name = "UcDetalleACCION_FORMATIVA_DETALLE1"
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleACCION_FORMATIVA_DETALLE1.TabIndex = 0
        '
        'ucMantACCION_FORMATIVA_DETALLE
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantACCION_FORMATIVA_DETALLE"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaACCION_FORMATIVA_DETALLE1 As SGAFP.ucListaACCION_FORMATIVA_DETALLE
    Friend WithEvents UcDetalleACCION_FORMATIVA_DETALLE1 As SGAFP.UcDetalleACCION_FORMATIVA_DETALLE

End Class
