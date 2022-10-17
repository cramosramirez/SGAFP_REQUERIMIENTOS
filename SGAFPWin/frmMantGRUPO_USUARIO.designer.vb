<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantGRUPO_USUARIO
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
        Me.UcMantGRUPO_USUARIO1 = New SGAFP.ucMantGRUPO_USUARIO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantGRUPO_USUARIO1
        '
        Me.UcMantGRUPO_USUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantGRUPO_USUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantGRUPO_USUARIO1.Name = "UcMantGRUPO_USUARIO1"
        Me.UcMantGRUPO_USUARIO1.sError = Nothing
        Me.UcMantGRUPO_USUARIO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantGRUPO_USUARIO1.TabIndex = 6
        '
        'frmMantGRUPO_USUARIO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantGRUPO_USUARIO1)
        Me.Name = "frmMantGRUPO_USUARIO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantGRUPO_USUARIO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantGRUPO_USUARIO1 As SGAFP.ucMantGRUPO_USUARIO

End Class

