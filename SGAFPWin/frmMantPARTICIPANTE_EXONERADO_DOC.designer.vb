<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPARTICIPANTE_EXONERADO_DOC
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
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1 = New SGAFP.ucMantPARTICIPANTE_EXONERADO_DOC
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(8, 2)
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantPARTICIPANTE_EXONERADO_DOC1
        '
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.Name = "UcMantPARTICIPANTE_EXONERADO_DOC1"
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.sError = Nothing
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.TabIndex = 6
        '
        'frmMantPARTICIPANTE_EXONERADO_DOC
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantPARTICIPANTE_EXONERADO_DOC1)
        Me.Name = "frmMantPARTICIPANTE_EXONERADO_DOC"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantPARTICIPANTE_EXONERADO_DOC1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantPARTICIPANTE_EXONERADO_DOC1 As SGAFP.ucMantPARTICIPANTE_EXONERADO_DOC

End Class

