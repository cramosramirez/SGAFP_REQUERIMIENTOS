Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantMODALIDAD_DE_FORMACION
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
        Me.UcListaMODALIDAD_DE_FORMACION1 = New SGAFP.ucListaMODALIDAD_DE_FORMACION
        Me.UcDetalleMODALIDAD_DE_FORMACION1 = New SGAFP.ucDetalleMODALIDAD_DE_FORMACION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaMODALIDAD_DE_FORMACION1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleMODALIDAD_DE_FORMACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaMODALIDAD_DE_FORMACION1
        '
        Me.UcListaMODALIDAD_DE_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaMODALIDAD_DE_FORMACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaMODALIDAD_DE_FORMACION1.Name = "UcListaMODALIDAD_DE_FORMACION1"
        Me.UcListaMODALIDAD_DE_FORMACION1.PermitirBuscarEntityType = GetType(MODALIDAD_DE_FORMACION)
        Me.UcListaMODALIDAD_DE_FORMACION1.sError = Nothing
        Me.UcListaMODALIDAD_DE_FORMACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaMODALIDAD_DE_FORMACION1.TabIndex = 1
        '
        'UcDetalleMODALIDAD_DE_FORMACION1
        '
        Me.UcDetalleMODALIDAD_DE_FORMACION1.AutoScroll = True
        Me.UcDetalleMODALIDAD_DE_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleMODALIDAD_DE_FORMACION1.EsNuevo = False
        Me.UcDetalleMODALIDAD_DE_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleMODALIDAD_DE_FORMACION1.Name = "UcDetalleMODALIDAD_DE_FORMACION1"
        Me.UcDetalleMODALIDAD_DE_FORMACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleMODALIDAD_DE_FORMACION1.TabIndex = 0
        '
        'ucMantMODALIDAD_DE_FORMACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantMODALIDAD_DE_FORMACION"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaMODALIDAD_DE_FORMACION1 As SGAFP.ucListaMODALIDAD_DE_FORMACION
    Friend WithEvents UcDetalleMODALIDAD_DE_FORMACION1 As SGAFP.UcDetalleMODALIDAD_DE_FORMACION

End Class
