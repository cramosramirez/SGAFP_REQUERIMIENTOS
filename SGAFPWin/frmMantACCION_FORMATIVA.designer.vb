<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantACCION_FORMATIVA
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
        Me.UcMantACCION_FORMATIVA1 = New SGAFP.ucMantACCION_FORMATIVA
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantACCION_FORMATIVA1
        '
        Me.UcMantACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantACCION_FORMATIVA1.Name = "UcMantACCION_FORMATIVA1"
        Me.UcMantACCION_FORMATIVA1.sError = Nothing
        Me.UcMantACCION_FORMATIVA1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantACCION_FORMATIVA1.TabIndex = 6
        '
        'frmMantACCION_FORMATIVA
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantACCION_FORMATIVA1)
        Me.Name = "frmMantACCION_FORMATIVA"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantACCION_FORMATIVA1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantACCION_FORMATIVA1 As SGAFP.ucMantACCION_FORMATIVA

End Class

