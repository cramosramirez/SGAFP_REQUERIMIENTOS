<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantNIVEL_ACADEMICO
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
        Me.UcMantNIVEL_ACADEMICO1 = New SGAFP.ucMantNIVEL_ACADEMICO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantNIVEL_ACADEMICO1
        '
        Me.UcMantNIVEL_ACADEMICO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantNIVEL_ACADEMICO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantNIVEL_ACADEMICO1.Name = "UcMantNIVEL_ACADEMICO1"
        Me.UcMantNIVEL_ACADEMICO1.sError = Nothing
        Me.UcMantNIVEL_ACADEMICO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantNIVEL_ACADEMICO1.TabIndex = 6
        '
        'frmMantNIVEL_ACADEMICO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantNIVEL_ACADEMICO1)
        Me.Name = "frmMantNIVEL_ACADEMICO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantNIVEL_ACADEMICO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantNIVEL_ACADEMICO1 As SGAFP.ucMantNIVEL_ACADEMICO

End Class

