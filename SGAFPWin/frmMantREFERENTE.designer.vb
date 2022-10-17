<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantREFERENTE
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
        Me.UcMantREFERENTE1 = New SGAFP.ucMantREFERENTE
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantREFERENTE1
        '
        Me.UcMantREFERENTE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantREFERENTE1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantREFERENTE1.Name = "UcMantREFERENTE1"
        Me.UcMantREFERENTE1.sError = Nothing
        Me.UcMantREFERENTE1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantREFERENTE1.TabIndex = 6
        '
        'frmMantREFERENTE
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantREFERENTE1)
        Me.Name = "frmMantREFERENTE"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantREFERENTE1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantREFERENTE1 As SGAFP.ucMantREFERENTE

End Class

