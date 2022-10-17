Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantPARTICIPANTE_AF
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
        Me.LabelACCION_FORMATIVA = New System.Windows.Forms.Label
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA = New SGAFP.WinUC.cbxACCION_FORMATIVA
        Me.UcListaPARTICIPANTE_AF1 = New SGAFP.ucListaPARTICIPANTE_AF
        Me.UcDetallePARTICIPANTE_AF1 = New SGAFP.ucDetallePARTICIPANTE_AF
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelACCION_FORMATIVA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaPARTICIPANTE_AF1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetallePARTICIPANTE_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'LabelACCION_FORMATIVA
        '
        Me.LabelACCION_FORMATIVA.AutoSize = True
        Me.LabelACCION_FORMATIVA.Location = New System.Drawing.Point(3, 11)
        Me.LabelACCION_FORMATIVA.Name = "LabelACCION_FORMATIVA"
        Me.LabelACCION_FORMATIVA.Size = New System.Drawing.Size(132, 13)
        Me.LabelACCION_FORMATIVA.TabIndex = 3
        Me.LabelACCION_FORMATIVA.Text = "ACCION_FORMATIVA:"
        '
        'ID_ACCION_FORMATIVACbxACCION_FORMATIVA
        '
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.Location = New System.Drawing.Point(100, 5)
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.Name = "ID_ACCION_FORMATIVACbxACCION_FORMATIVA"
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.Size = New System.Drawing.Size(121, 21)
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.TabIndex = 2
        Me.ID_ACCION_FORMATIVACbxACCION_FORMATIVA.Text = "CbxACCION_FORMATIVA"
        '
        'UcListaPARTICIPANTE_AF1
        '
        Me.UcListaPARTICIPANTE_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPARTICIPANTE_AF1.Location = New System.Drawing.Point(0,0)
        Me.UcListaPARTICIPANTE_AF1.Name = "UcListaPARTICIPANTE_AF1"
        Me.UcListaPARTICIPANTE_AF1.PermitirBuscarEntityType = GetType(PARTICIPANTE_AF)
        Me.UcListaPARTICIPANTE_AF1.sError = Nothing
        Me.UcListaPARTICIPANTE_AF1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaPARTICIPANTE_AF1.TabIndex = 1
        '
        'UcDetallePARTICIPANTE_AF1
        '
        Me.UcDetallePARTICIPANTE_AF1.AutoScroll = True
        Me.UcDetallePARTICIPANTE_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetallePARTICIPANTE_AF1.EsNuevo = False
        Me.UcDetallePARTICIPANTE_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetallePARTICIPANTE_AF1.Name = "UcDetallePARTICIPANTE_AF1"
        Me.UcDetallePARTICIPANTE_AF1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetallePARTICIPANTE_AF1.TabIndex = 0
        '
        'ucMantPARTICIPANTE_AF
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantPARTICIPANTE_AF"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaPARTICIPANTE_AF1 As SGAFP.ucListaPARTICIPANTE_AF
    Friend WithEvents UcDetallePARTICIPANTE_AF1 As SGAFP.UcDetallePARTICIPANTE_AF
    Friend WithEvents LabelACCION_FORMATIVA As System.Windows.Forms.Label
    Friend WithEvents ID_ACCION_FORMATIVACbxACCION_FORMATIVA As SGAFP.WinUC.cbxACCION_FORMATIVA

End Class
