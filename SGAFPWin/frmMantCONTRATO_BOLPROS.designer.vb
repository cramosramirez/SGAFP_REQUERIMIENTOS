<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantCONTRATO_BOLPROS
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
        Me.UcMantCONTRATO_BOLPROS1 = New SGAFP.ucMantCONTRATO_BOLPROS
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(756, 23)
        '
        'ucMantCONTRATO_BOLPROS1
        '
        Me.UcMantCONTRATO_BOLPROS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantCONTRATO_BOLPROS1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantCONTRATO_BOLPROS1.Name = "UcMantCONTRATO_BOLPROS1"
        Me.UcMantCONTRATO_BOLPROS1.sError = Nothing
        Me.UcMantCONTRATO_BOLPROS1.Size = New System.Drawing.Size(770, 492)
        Me.UcMantCONTRATO_BOLPROS1.TabIndex = 6
        '
        'frmMantCONTRATO_BOLPROS
        '
        Me.ClientSize = New System.Drawing.Size(770, 492)
        Me.Controls.Add(Me.UcMantCONTRATO_BOLPROS1)
        Me.Name = "frmMantCONTRATO_BOLPROS"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantCONTRATO_BOLPROS1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantCONTRATO_BOLPROS1 As SGAFP.ucMantCONTRATO_BOLPROS

End Class

