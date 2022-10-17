Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarINFORME_FINAL_AF
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
        Me.UcBuscarINFORME_FINAL_AF1 = New SGAFP.ucBuscarINFORME_FINAL_AF
        Me.SuspendLayout()
        '
        'UcBuscarINFORME_FINAL_AF1
        '
        Me.UcBuscarINFORME_FINAL_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarINFORME_FINAL_AF1.EntityType = GetType(INFORME_FINAL_AF)
        Me.UcBuscarINFORME_FINAL_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarINFORME_FINAL_AF1.Name = "UcBuscarINFORME_FINAL_AF1"
        Me.UcBuscarINFORME_FINAL_AF1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarINFORME_FINAL_AF1.TabIndex = 0
        '
        'frmBuscarINFORME_FINAL_AF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarINFORME_FINAL_AF1)
        Me.Name = "frmBuscarINFORME_FINAL_AF"
        Me.Text = "Buscar INFORME_FINAL_AF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarINFORME_FINAL_AF1 As SGAFP.ucBuscarINFORME_FINAL_AF
End Class
