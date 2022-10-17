<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPROGRAMA_FORMACION
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
        Me.UcMantPROGRAMA_FORMACION1 = New SGAFP.ucMantPROGRAMA_FORMACION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantPROGRAMA_FORMACION1
        '
        Me.UcMantPROGRAMA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantPROGRAMA_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantPROGRAMA_FORMACION1.Name = "UcMantPROGRAMA_FORMACION1"
        Me.UcMantPROGRAMA_FORMACION1.sError = Nothing
        Me.UcMantPROGRAMA_FORMACION1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantPROGRAMA_FORMACION1.TabIndex = 6
        '
        'frmMantPROGRAMA_FORMACION
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantPROGRAMA_FORMACION1)
        Me.Name = "frmMantPROGRAMA_FORMACION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantPROGRAMA_FORMACION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantPROGRAMA_FORMACION1 As SGAFP.ucMantPROGRAMA_FORMACION

End Class

