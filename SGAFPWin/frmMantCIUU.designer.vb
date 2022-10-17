<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantCIUU
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
        Me.UcMantCIUU1 = New SGAFP.ucMantCIUU
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantCIUU1
        '
        Me.UcMantCIUU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantCIUU1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantCIUU1.Name = "UcMantCIUU1"
        Me.UcMantCIUU1.sError = Nothing
        Me.UcMantCIUU1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantCIUU1.TabIndex = 6
        '
        'frmMantCIUU
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantCIUU1)
        Me.Name = "frmMantCIUU"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantCIUU1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantCIUU1 As SGAFP.ucMantCIUU

End Class

