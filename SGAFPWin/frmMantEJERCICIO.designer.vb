<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantEJERCICIO
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
        Me.UcMantEJERCICIO1 = New SGAFP.ucMantEJERCICIO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantEJERCICIO1
        '
        Me.UcMantEJERCICIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantEJERCICIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantEJERCICIO1.Name = "UcMantEJERCICIO1"
        Me.UcMantEJERCICIO1.sError = Nothing
        Me.UcMantEJERCICIO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantEJERCICIO1.TabIndex = 6
        '
        'frmMantEJERCICIO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantEJERCICIO1)
        Me.Name = "frmMantEJERCICIO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantEJERCICIO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantEJERCICIO1 As SGAFP.ucMantEJERCICIO

End Class

