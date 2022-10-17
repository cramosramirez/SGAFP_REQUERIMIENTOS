Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDEPARTAMENTO
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
        Me.UcBuscarDEPARTAMENTO1 = New SGAFP.ucBuscarDEPARTAMENTO
        Me.SuspendLayout()
        '
        'UcBuscarDEPARTAMENTO1
        '
        Me.UcBuscarDEPARTAMENTO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarDEPARTAMENTO1.EntityType = GetType(DEPARTAMENTO)
        Me.UcBuscarDEPARTAMENTO1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarDEPARTAMENTO1.Name = "UcBuscarDEPARTAMENTO1"
        Me.UcBuscarDEPARTAMENTO1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarDEPARTAMENTO1.TabIndex = 0
        '
        'frmBuscarDEPARTAMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarDEPARTAMENTO1)
        Me.Name = "frmBuscarDEPARTAMENTO"
        Me.Text = "Buscar DEPARTAMENTO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarDEPARTAMENTO1 As SGAFP.ucBuscarDEPARTAMENTO
End Class
