<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantCURSO_TEMA
    Inherits SGAFP.frmMantPadre

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
        Me.UcMantCURSO_TEMA1 = New SGAFP.ucMantCURSO_TEMA
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantCURSO_TEMA1
        '
        Me.UcMantCURSO_TEMA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantCURSO_TEMA1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantCURSO_TEMA1.Name = "UcMantCURSO_TEMA1"
        Me.UcMantCURSO_TEMA1.sError = Nothing
        Me.UcMantCURSO_TEMA1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantCURSO_TEMA1.TabIndex = 6
        '
        'frmMantCURSO_TEMA
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantCURSO_TEMA1)
        Me.Name = "frmMantCURSO_TEMA"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantCURSO_TEMA1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantCURSO_TEMA1 As SGAFP.ucMantCURSO_TEMA

End Class

