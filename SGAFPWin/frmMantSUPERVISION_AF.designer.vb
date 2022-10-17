<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSUPERVISION_AF
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
        Me.UcMantSUPERVISION_AF1 = New SGAFP.ucMantSUPERVISION_AF
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantSUPERVISION_AF1
        '
        Me.UcMantSUPERVISION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSUPERVISION_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSUPERVISION_AF1.Name = "UcMantSUPERVISION_AF1"
        Me.UcMantSUPERVISION_AF1.sError = Nothing
        Me.UcMantSUPERVISION_AF1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantSUPERVISION_AF1.TabIndex = 6
        '
        'frmMantSUPERVISION_AF
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantSUPERVISION_AF1)
        Me.Name = "frmMantSUPERVISION_AF"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSUPERVISION_AF1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSUPERVISION_AF1 As SGAFP.ucMantSUPERVISION_AF

End Class

