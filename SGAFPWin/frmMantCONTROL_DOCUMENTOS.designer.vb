<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantCONTROL_DOCUMENTOS
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
        Me.UcMantCONTROL_DOCUMENTOS1 = New SGAFP.ucMantCONTROL_DOCUMENTOS
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantCONTROL_DOCUMENTOS1
        '
        Me.UcMantCONTROL_DOCUMENTOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantCONTROL_DOCUMENTOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantCONTROL_DOCUMENTOS1.Name = "UcMantCONTROL_DOCUMENTOS1"
        Me.UcMantCONTROL_DOCUMENTOS1.sError = Nothing
        Me.UcMantCONTROL_DOCUMENTOS1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantCONTROL_DOCUMENTOS1.TabIndex = 6
        '
        'frmMantCONTROL_DOCUMENTOS
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantCONTROL_DOCUMENTOS1)
        Me.Name = "frmMantCONTROL_DOCUMENTOS"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantCONTROL_DOCUMENTOS1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantCONTROL_DOCUMENTOS1 As SGAFP.ucMantCONTROL_DOCUMENTOS

End Class

