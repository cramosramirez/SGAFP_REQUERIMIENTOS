Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantREFERENTE
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
        Me.UcListaREFERENTE1 = New SGAFP.ucListaREFERENTE
        Me.UcDetalleREFERENTE1 = New SGAFP.ucDetalleREFERENTE
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaREFERENTE1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleREFERENTE1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaREFERENTE1
        '
        Me.UcListaREFERENTE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaREFERENTE1.Location = New System.Drawing.Point(0,0)
        Me.UcListaREFERENTE1.Name = "UcListaREFERENTE1"
        Me.UcListaREFERENTE1.PermitirBuscarEntityType = GetType(REFERENTE)
        Me.UcListaREFERENTE1.sError = Nothing
        Me.UcListaREFERENTE1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaREFERENTE1.TabIndex = 1
        '
        'UcDetalleREFERENTE1
        '
        Me.UcDetalleREFERENTE1.AutoScroll = True
        Me.UcDetalleREFERENTE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleREFERENTE1.EsNuevo = False
        Me.UcDetalleREFERENTE1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleREFERENTE1.Name = "UcDetalleREFERENTE1"
        Me.UcDetalleREFERENTE1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleREFERENTE1.TabIndex = 0
        '
        'ucMantREFERENTE
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantREFERENTE"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaREFERENTE1 As SGAFP.ucListaREFERENTE
    Friend WithEvents UcDetalleREFERENTE1 As SGAFP.UcDetalleREFERENTE

End Class
