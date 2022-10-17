<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSOLICITUD_CAPACITACION
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
        Me.UcMantSOLICITUD_CAPACITACION1 = New SGAFP.ucMantSOLICITUD_CAPACITACION
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(901, 23)
        '
        'UcMantSOLICITUD_CAPACITACION1
        '
        Me.UcMantSOLICITUD_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantSOLICITUD_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantSOLICITUD_CAPACITACION1.Name = "UcMantSOLICITUD_CAPACITACION1"
        Me.UcMantSOLICITUD_CAPACITACION1.sError = Nothing
        Me.UcMantSOLICITUD_CAPACITACION1.Size = New System.Drawing.Size(915, 585)
        Me.UcMantSOLICITUD_CAPACITACION1.TabIndex = 6
        '
        'frmMantSOLICITUD_CAPACITACION
        '
        Me.ClientSize = New System.Drawing.Size(915, 585)
        Me.Controls.Add(Me.UcMantSOLICITUD_CAPACITACION1)
        Me.Name = "frmMantSOLICITUD_CAPACITACION"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantSOLICITUD_CAPACITACION1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantSOLICITUD_CAPACITACION1 As SGAFP.ucMantSOLICITUD_CAPACITACION

End Class

