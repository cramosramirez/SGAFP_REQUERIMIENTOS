Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantETAPA
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
        Me.LabelPROCESO = New System.Windows.Forms.Label
        Me.CODIGO_PROCESOCbxPROCESO = New SGAFP.WinUC.cbxPROCESO
        Me.UcListaETAPA1 = New SGAFP.ucListaETAPA
        Me.UcDetalleETAPA1 = New SGAFP.ucDetalleETAPA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelPROCESO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CODIGO_PROCESOCbxPROCESO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaETAPA1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleETAPA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'LabelPROCESO
        '
        Me.LabelPROCESO.AutoSize = True
        Me.LabelPROCESO.Location = New System.Drawing.Point(3, 11)
        Me.LabelPROCESO.Name = "LabelPROCESO"
        Me.LabelPROCESO.Size = New System.Drawing.Size(132, 13)
        Me.LabelPROCESO.TabIndex = 3
        Me.LabelPROCESO.Text = "PROCESO:"
        '
        'CODIGO_PROCESOCbxPROCESO
        '
        Me.CODIGO_PROCESOCbxPROCESO.Location = New System.Drawing.Point(100, 5)
        Me.CODIGO_PROCESOCbxPROCESO.Name = "CODIGO_PROCESOCbxPROCESO"
        Me.CODIGO_PROCESOCbxPROCESO.Size = New System.Drawing.Size(121, 21)
        Me.CODIGO_PROCESOCbxPROCESO.TabIndex = 2
        Me.CODIGO_PROCESOCbxPROCESO.Text = "CbxPROCESO"
        '
        'UcListaETAPA1
        '
        Me.UcListaETAPA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaETAPA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaETAPA1.Name = "UcListaETAPA1"
        Me.UcListaETAPA1.PermitirBuscarEntityType = GetType(ETAPA)
        Me.UcListaETAPA1.sError = Nothing
        Me.UcListaETAPA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaETAPA1.TabIndex = 1
        '
        'UcDetalleETAPA1
        '
        Me.UcDetalleETAPA1.AutoScroll = True
        Me.UcDetalleETAPA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleETAPA1.EsNuevo = False
        Me.UcDetalleETAPA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleETAPA1.Name = "UcDetalleETAPA1"
        Me.UcDetalleETAPA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleETAPA1.TabIndex = 0
        '
        'ucMantETAPA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantETAPA"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaETAPA1 As SGAFP.ucListaETAPA
    Friend WithEvents UcDetalleETAPA1 As SGAFP.UcDetalleETAPA
    Friend WithEvents LabelPROCESO As System.Windows.Forms.Label
    Friend WithEvents CODIGO_PROCESOCbxPROCESO As SGAFP.WinUC.cbxPROCESO

End Class
