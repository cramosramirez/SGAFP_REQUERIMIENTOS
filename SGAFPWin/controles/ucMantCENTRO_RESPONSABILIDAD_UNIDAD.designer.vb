Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCENTRO_RESPONSABILIDAD_UNIDAD
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
        Me.LabelUNIDAD_ORGANIZATIVA = New System.Windows.Forms.Label
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1 = New SGAFP.ucListaCENTRO_RESPONSABILIDAD_UNIDAD
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1 = New SGAFP.ucDetalleCENTRO_RESPONSABILIDAD_UNIDAD
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelUNIDAD_ORGANIZATIVA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'LabelUNIDAD_ORGANIZATIVA
        '
        Me.LabelUNIDAD_ORGANIZATIVA.AutoSize = True
        Me.LabelUNIDAD_ORGANIZATIVA.Location = New System.Drawing.Point(3, 11)
        Me.LabelUNIDAD_ORGANIZATIVA.Name = "LabelUNIDAD_ORGANIZATIVA"
        Me.LabelUNIDAD_ORGANIZATIVA.Size = New System.Drawing.Size(132, 13)
        Me.LabelUNIDAD_ORGANIZATIVA.TabIndex = 3
        Me.LabelUNIDAD_ORGANIZATIVA.Text = "UNIDAD_ORGANIZATIVA:"
        '
        'ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA
        '
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA.Location = New System.Drawing.Point(100, 5)
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA.Name = "ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA"
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA.Size = New System.Drawing.Size(121, 21)
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA.TabIndex = 2
        Me.ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA.Text = "CbxUNIDAD_ORGANIZATIVA"
        '
        'UcListaCENTRO_RESPONSABILIDAD_UNIDAD1
        '
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.Name = "UcListaCENTRO_RESPONSABILIDAD_UNIDAD1"
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.PermitirBuscarEntityType = GetType(CENTRO_RESPONSABILIDAD_UNIDAD)
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.sError = Nothing
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCENTRO_RESPONSABILIDAD_UNIDAD1.TabIndex = 1
        '
        'UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1
        '
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.AutoScroll = True
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.EsNuevo = False
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.Name = "UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1"
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1.TabIndex = 0
        '
        'ucMantCENTRO_RESPONSABILIDAD_UNIDAD
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCENTRO_RESPONSABILIDAD_UNIDAD"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaCENTRO_RESPONSABILIDAD_UNIDAD1 As SGAFP.ucListaCENTRO_RESPONSABILIDAD_UNIDAD
    Friend WithEvents UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD1 As SGAFP.UcDetalleCENTRO_RESPONSABILIDAD_UNIDAD
    Friend WithEvents LabelUNIDAD_ORGANIZATIVA As System.Windows.Forms.Label
    Friend WithEvents ID_UNIDAD_ORGANIZATIVACbxUNIDAD_ORGANIZATIVA As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA

End Class
