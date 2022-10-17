Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSITIO_CAPACITACION
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcBuscarSITIO_CAPACITACION1 = New SGAFP.ucBuscarSITIO_CAPACITACION
        Me.SuspendLayout()
        '
        'UcBuscarSITIO_CAPACITACION1
        '
        Me.UcBuscarSITIO_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarSITIO_CAPACITACION1.EntityType = GetType(SITIO_CAPACITACION)
        Me.UcBuscarSITIO_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarSITIO_CAPACITACION1.Name = "UcBuscarSITIO_CAPACITACION1"
        Me.UcBuscarSITIO_CAPACITACION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarSITIO_CAPACITACION1.TabIndex = 0
        '
        'frmBuscarSITIO_CAPACITACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarSITIO_CAPACITACION1)
        Me.Name = "frmBuscarSITIO_CAPACITACION"
        Me.Text = "Buscar SITIO_CAPACITACION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarSITIO_CAPACITACION1 As SGAFP.ucBuscarSITIO_CAPACITACION
End Class
