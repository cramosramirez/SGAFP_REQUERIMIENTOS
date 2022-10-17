Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantUNIDAD_ORGANIZATIVA
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
        Me.UcListaUNIDAD_ORGANIZATIVA1 = New SGAFP.ucListaUNIDAD_ORGANIZATIVA
        Me.UcDetalleUNIDAD_ORGANIZATIVA1 = New SGAFP.ucDetalleUNIDAD_ORGANIZATIVA
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaUNIDAD_ORGANIZATIVA1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleUNIDAD_ORGANIZATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaUNIDAD_ORGANIZATIVA1
        '
        Me.UcListaUNIDAD_ORGANIZATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(0,0)
        Me.UcListaUNIDAD_ORGANIZATIVA1.Name = "UcListaUNIDAD_ORGANIZATIVA1"
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirBuscarEntityType = GetType(UNIDAD_ORGANIZATIVA)
        Me.UcListaUNIDAD_ORGANIZATIVA1.sError = Nothing
        Me.UcListaUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaUNIDAD_ORGANIZATIVA1.TabIndex = 1
        '
        'UcDetalleUNIDAD_ORGANIZATIVA1
        '
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.AutoScroll = True
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.EsNuevo = False
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.Name = "UcDetalleUNIDAD_ORGANIZATIVA1"
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleUNIDAD_ORGANIZATIVA1.TabIndex = 0
        '
        'ucMantUNIDAD_ORGANIZATIVA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantUNIDAD_ORGANIZATIVA"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaUNIDAD_ORGANIZATIVA1 As SGAFP.ucListaUNIDAD_ORGANIZATIVA
    Friend WithEvents UcDetalleUNIDAD_ORGANIZATIVA1 As SGAFP.UcDetalleUNIDAD_ORGANIZATIVA

End Class
