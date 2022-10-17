<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantETAPA
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
        Me.UcMantETAPA1 = New SGAFP.ucMantETAPA
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantETAPA1
        '
        Me.UcMantETAPA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantETAPA1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantETAPA1.Name = "UcMantETAPA1"
        Me.UcMantETAPA1.sError = Nothing
        Me.UcMantETAPA1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantETAPA1.TabIndex = 6
        '
        'frmMantETAPA
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantETAPA1)
        Me.Name = "frmMantETAPA"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantETAPA1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantETAPA1 As SGAFP.ucMantETAPA

End Class

