<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantAREA_FORMACION
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
        Me.UcMantAREA_FORMACION1 = New SGAFP.ucMantAREA_FORMACION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantAREA_FORMACION1
        '
        Me.UcMantAREA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantAREA_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantAREA_FORMACION1.Name = "UcMantAREA_FORMACION1"
        Me.UcMantAREA_FORMACION1.sError = Nothing
        Me.UcMantAREA_FORMACION1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantAREA_FORMACION1.TabIndex = 6
        '
        'frmMantAREA_FORMACION
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantAREA_FORMACION1)
        Me.Name = "frmMantAREA_FORMACION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantAREA_FORMACION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantAREA_FORMACION1 As SGAFP.ucMantAREA_FORMACION

End Class

