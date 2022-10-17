Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantFACILITADOR_CAPACITADOR
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
        Me.UcListaFACILITADOR_CAPACITADOR1 = New SGAFP.ucListaFACILITADOR_CAPACITADOR
        Me.UcDetalleFACILITADOR_CAPACITADOR1 = New SGAFP.ucDetalleFACILITADOR_CAPACITADOR
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaFACILITADOR_CAPACITADOR1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleFACILITADOR_CAPACITADOR1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 1
        '
        'UcListaFACILITADOR_CAPACITADOR1
        '
        Me.UcListaFACILITADOR_CAPACITADOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaFACILITADOR_CAPACITADOR1.Location = New System.Drawing.Point(0,0)
        Me.UcListaFACILITADOR_CAPACITADOR1.Name = "UcListaFACILITADOR_CAPACITADOR1"
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirBuscarEntityType = GetType(FACILITADOR_CAPACITADOR)
        Me.UcListaFACILITADOR_CAPACITADOR1.sError = Nothing
        Me.UcListaFACILITADOR_CAPACITADOR1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaFACILITADOR_CAPACITADOR1.TabIndex = 1
        '
        'UcDetalleFACILITADOR_CAPACITADOR1
        '
        Me.UcDetalleFACILITADOR_CAPACITADOR1.AutoScroll = True
        Me.UcDetalleFACILITADOR_CAPACITADOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleFACILITADOR_CAPACITADOR1.EsNuevo = False
        Me.UcDetalleFACILITADOR_CAPACITADOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleFACILITADOR_CAPACITADOR1.Name = "UcDetalleFACILITADOR_CAPACITADOR1"
        Me.UcDetalleFACILITADOR_CAPACITADOR1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleFACILITADOR_CAPACITADOR1.TabIndex = 0
        '
        'ucMantFACILITADOR_CAPACITADOR
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantFACILITADOR_CAPACITADOR"
        Me.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UcListaFACILITADOR_CAPACITADOR1 As SGAFP.ucListaFACILITADOR_CAPACITADOR
    Friend WithEvents UcDetalleFACILITADOR_CAPACITADOR1 As SGAFP.UcDetalleFACILITADOR_CAPACITADOR

End Class
