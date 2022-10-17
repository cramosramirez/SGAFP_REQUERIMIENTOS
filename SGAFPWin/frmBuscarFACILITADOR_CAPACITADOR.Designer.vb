Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFACILITADOR_CAPACITADOR
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
        Me.UcBuscarFACILITADOR_CAPACITADOR1 = New SGAFP.ucBuscarFACILITADOR_CAPACITADOR
        Me.SuspendLayout()
        '
        'UcBuscarFACILITADOR_CAPACITADOR1
        '
        Me.UcBuscarFACILITADOR_CAPACITADOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarFACILITADOR_CAPACITADOR1.EntityType = GetType(FACILITADOR_CAPACITADOR)
        Me.UcBuscarFACILITADOR_CAPACITADOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarFACILITADOR_CAPACITADOR1.Name = "UcBuscarFACILITADOR_CAPACITADOR1"
        Me.UcBuscarFACILITADOR_CAPACITADOR1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarFACILITADOR_CAPACITADOR1.TabIndex = 0
        '
        'frmBuscarFACILITADOR_CAPACITADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarFACILITADOR_CAPACITADOR1)
        Me.Name = "frmBuscarFACILITADOR_CAPACITADOR"
        Me.Text = "Buscar FACILITADOR_CAPACITADOR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarFACILITADOR_CAPACITADOR1 As SGAFP.ucBuscarFACILITADOR_CAPACITADOR
End Class
