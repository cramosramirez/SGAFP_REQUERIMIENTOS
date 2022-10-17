<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSITIO_CAPACITACION
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
        Me.UcMantSITIO_CAPACITACION1 = New SGAFP.ucMantSITIO_CAPACITACION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantSITIO_CAPACITACION1
        '
        Me.UcMantSITIO_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSITIO_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSITIO_CAPACITACION1.Name = "UcMantSITIO_CAPACITACION1"
        Me.UcMantSITIO_CAPACITACION1.sError = Nothing
        Me.UcMantSITIO_CAPACITACION1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantSITIO_CAPACITACION1.TabIndex = 6
        '
        'frmMantSITIO_CAPACITACION
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantSITIO_CAPACITACION1)
        Me.Name = "frmMantSITIO_CAPACITACION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSITIO_CAPACITACION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSITIO_CAPACITACION1 As SGAFP.ucMantSITIO_CAPACITACION

End Class

