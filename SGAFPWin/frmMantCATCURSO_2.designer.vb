<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantCATCURSO_2
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
        Me.UcMantCATCURSO_21 = New SGAFP.ucMantCATCURSO_2
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantCATCURSO_21
        '
        Me.UcMantCATCURSO_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantCATCURSO_21.Location = New System.Drawing.Point(0, 0)
        Me.UcMantCATCURSO_21.Name = "UcMantCATCURSO_21"
        Me.UcMantCATCURSO_21.sError = Nothing
        Me.UcMantCATCURSO_21.Size = New System.Drawing.Size(584, 356)
        Me.UcMantCATCURSO_21.TabIndex = 6
        '
        'frmMantCATCURSO_2
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantCATCURSO_21)
        Me.Name = "frmMantCATCURSO_2"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantCATCURSO_21, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantCATCURSO_21 As SGAFP.ucMantCATCURSO_2

End Class

