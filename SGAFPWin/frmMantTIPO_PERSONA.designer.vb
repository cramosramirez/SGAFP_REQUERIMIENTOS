<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantTIPO_PERSONA
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
        Me.UcMantTIPO_PERSONA1 = New SGAFP.ucMantTIPO_PERSONA
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantTIPO_PERSONA1
        '
        Me.UcMantTIPO_PERSONA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantTIPO_PERSONA1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantTIPO_PERSONA1.Name = "UcMantTIPO_PERSONA1"
        Me.UcMantTIPO_PERSONA1.sError = Nothing
        Me.UcMantTIPO_PERSONA1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantTIPO_PERSONA1.TabIndex = 6
        '
        'frmMantTIPO_PERSONA
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantTIPO_PERSONA1)
        Me.Name = "frmMantTIPO_PERSONA"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantTIPO_PERSONA1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantTIPO_PERSONA1 As SGAFP.ucMantTIPO_PERSONA

End Class

