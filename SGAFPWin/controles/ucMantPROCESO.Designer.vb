Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantPROCESO
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
        Me.UcListaPROCESO1 = New SGAFP.ucListaPROCESO
        Me.UcDetallePROCESO1 = New SGAFP.ucDetallePROCESO
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaPROCESO1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetallePROCESO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaPROCESO1
        '
        Me.UcListaPROCESO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPROCESO1.Location = New System.Drawing.Point(0,0)
        Me.UcListaPROCESO1.Name = "UcListaPROCESO1"
        Me.UcListaPROCESO1.PermitirBuscarEntityType = GetType(PROCESO)
        Me.UcListaPROCESO1.sError = Nothing
        Me.UcListaPROCESO1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaPROCESO1.TabIndex = 1
        '
        'UcDetallePROCESO1
        '
        Me.UcDetallePROCESO1.AutoScroll = True
        Me.UcDetallePROCESO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetallePROCESO1.EsNuevo = False
        Me.UcDetallePROCESO1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetallePROCESO1.Name = "UcDetallePROCESO1"
        Me.UcDetallePROCESO1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetallePROCESO1.TabIndex = 0
        '
        'ucMantPROCESO
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantPROCESO"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaPROCESO1 As SGAFP.ucListaPROCESO
    Friend WithEvents UcDetallePROCESO1 As SGAFP.UcDetallePROCESO

End Class
