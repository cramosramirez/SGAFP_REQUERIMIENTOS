Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantGRUPO_ACCION_CONTRATADA
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
        Me.UcListaGRUPO_ACCION_CONTRATADA1 = New SGAFP.ucListaGRUPO_ACCION_CONTRATADA
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1 = New SGAFP.ucDetalleGRUPO_ACCION_CONTRATADA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaGRUPO_ACCION_CONTRATADA1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleGRUPO_ACCION_CONTRATADA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaGRUPO_ACCION_CONTRATADA1
        '
        Me.UcListaGRUPO_ACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaGRUPO_ACCION_CONTRATADA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaGRUPO_ACCION_CONTRATADA1.Name = "UcListaGRUPO_ACCION_CONTRATADA1"
        Me.UcListaGRUPO_ACCION_CONTRATADA1.PermitirBuscarEntityType = GetType(GRUPO_ACCION_CONTRATADA)
        Me.UcListaGRUPO_ACCION_CONTRATADA1.sError = Nothing
        Me.UcListaGRUPO_ACCION_CONTRATADA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaGRUPO_ACCION_CONTRATADA1.TabIndex = 1
        '
        'UcDetalleGRUPO_ACCION_CONTRATADA1
        '
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.AutoScroll = True
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.EsNuevo = False
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.Name = "UcDetalleGRUPO_ACCION_CONTRATADA1"
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleGRUPO_ACCION_CONTRATADA1.TabIndex = 0
        '
        'ucMantGRUPO_ACCION_CONTRATADA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantGRUPO_ACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaGRUPO_ACCION_CONTRATADA1 As SGAFP.ucListaGRUPO_ACCION_CONTRATADA
    Friend WithEvents UcDetalleGRUPO_ACCION_CONTRATADA1 As SGAFP.UcDetalleGRUPO_ACCION_CONTRATADA

End Class
