<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantDEPARTAMENTO
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
        Me.UcMantDEPARTAMENTO1 = New SGAFP.ucMantDEPARTAMENTO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantDEPARTAMENTO1
        '
        Me.UcMantDEPARTAMENTO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantDEPARTAMENTO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantDEPARTAMENTO1.Name = "UcMantDEPARTAMENTO1"
        Me.UcMantDEPARTAMENTO1.sError = Nothing
        Me.UcMantDEPARTAMENTO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantDEPARTAMENTO1.TabIndex = 6
        '
        'frmMantDEPARTAMENTO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantDEPARTAMENTO1)
        Me.Name = "frmMantDEPARTAMENTO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantDEPARTAMENTO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantDEPARTAMENTO1 As SGAFP.ucMantDEPARTAMENTO

End Class

