<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantFACILITADOR_CAPACITADOR
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
        Me.UcMantFACILITADOR_CAPACITADOR1 = New SGAFP.ucMantFACILITADOR_CAPACITADOR
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantFACILITADOR_CAPACITADOR1
        '
        Me.UcMantFACILITADOR_CAPACITADOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantFACILITADOR_CAPACITADOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantFACILITADOR_CAPACITADOR1.Name = "UcMantFACILITADOR_CAPACITADOR1"
        Me.UcMantFACILITADOR_CAPACITADOR1.sError = Nothing
        Me.UcMantFACILITADOR_CAPACITADOR1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantFACILITADOR_CAPACITADOR1.TabIndex = 6
        '
        'frmMantFACILITADOR_CAPACITADOR
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantFACILITADOR_CAPACITADOR1)
        Me.Name = "frmMantFACILITADOR_CAPACITADOR"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantFACILITADOR_CAPACITADOR1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantFACILITADOR_CAPACITADOR1 As SGAFP.ucMantFACILITADOR_CAPACITADOR

End Class

