<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPARTICIPANTE_AF
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
        Me.UcMantPARTICIPANTE_AF1 = New SGAFP.ucMantPARTICIPANTE_AF
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantPARTICIPANTE_AF1
        '
        Me.UcMantPARTICIPANTE_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantPARTICIPANTE_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantPARTICIPANTE_AF1.Name = "UcMantPARTICIPANTE_AF1"
        Me.UcMantPARTICIPANTE_AF1.sError = Nothing
        Me.UcMantPARTICIPANTE_AF1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantPARTICIPANTE_AF1.TabIndex = 6
        '
        'frmMantPARTICIPANTE_AF
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantPARTICIPANTE_AF1)
        Me.Name = "frmMantPARTICIPANTE_AF"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantPARTICIPANTE_AF1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantPARTICIPANTE_AF1 As SGAFP.ucMantPARTICIPANTE_AF

End Class

