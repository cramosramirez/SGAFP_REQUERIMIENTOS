<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPROCESO
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
        Me.UcMantPROCESO1 = New SGAFP.ucMantPROCESO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantPROCESO1
        '
        Me.UcMantPROCESO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantPROCESO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantPROCESO1.Name = "UcMantPROCESO1"
        Me.UcMantPROCESO1.sError = Nothing
        Me.UcMantPROCESO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantPROCESO1.TabIndex = 6
        '
        'frmMantPROCESO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantPROCESO1)
        Me.Name = "frmMantPROCESO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantPROCESO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantPROCESO1 As SGAFP.ucMantPROCESO

End Class

