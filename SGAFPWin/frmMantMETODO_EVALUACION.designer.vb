<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantMETODO_EVALUACION
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
        Me.UcMantMETODO_EVALUACION1 = New SGAFP.ucMantMETODO_EVALUACION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantMETODO_EVALUACION1
        '
        Me.UcMantMETODO_EVALUACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantMETODO_EVALUACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantMETODO_EVALUACION1.Name = "UcMantMETODO_EVALUACION1"
        Me.UcMantMETODO_EVALUACION1.sError = Nothing
        Me.UcMantMETODO_EVALUACION1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantMETODO_EVALUACION1.TabIndex = 6
        '
        'frmMantMETODO_EVALUACION
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantMETODO_EVALUACION1)
        Me.Name = "frmMantMETODO_EVALUACION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantMETODO_EVALUACION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantMETODO_EVALUACION1 As SGAFP.ucMantMETODO_EVALUACION

End Class

