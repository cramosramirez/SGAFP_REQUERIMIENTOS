<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantUSUARIO
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
        Me.UcMantUSUARIO1 = New SGAFP.ucMantUSUARIO
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantUSUARIO1
        '
        Me.UcMantUSUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantUSUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantUSUARIO1.Name = "UcMantUSUARIO1"
        Me.UcMantUSUARIO1.sError = Nothing
        Me.UcMantUSUARIO1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantUSUARIO1.TabIndex = 6
        '
        'frmMantUSUARIO
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantUSUARIO1)
        Me.Name = "frmMantUSUARIO"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantUSUARIO1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantUSUARIO1 As SGAFP.ucMantUSUARIO

End Class

