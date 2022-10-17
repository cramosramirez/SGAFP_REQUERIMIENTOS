<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantHALLAZGO_SUPERVISION
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
        Me.UcMantHALLAZGO_SUPERVISION1 = New SGAFP.ucMantHALLAZGO_SUPERVISION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantHALLAZGO_SUPERVISION1
        '
        Me.UcMantHALLAZGO_SUPERVISION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantHALLAZGO_SUPERVISION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantHALLAZGO_SUPERVISION1.Name = "UcMantHALLAZGO_SUPERVISION1"
        Me.UcMantHALLAZGO_SUPERVISION1.sError = Nothing
        Me.UcMantHALLAZGO_SUPERVISION1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantHALLAZGO_SUPERVISION1.TabIndex = 6
        '
        'frmMantHALLAZGO_SUPERVISION
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantHALLAZGO_SUPERVISION1)
        Me.Name = "frmMantHALLAZGO_SUPERVISION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantHALLAZGO_SUPERVISION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantHALLAZGO_SUPERVISION1 As SGAFP.ucMantHALLAZGO_SUPERVISION

End Class

