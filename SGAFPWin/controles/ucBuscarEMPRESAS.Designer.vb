Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarEMPRESAS
    Inherits ucBaseBusqueda

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.UcListaEMPRESAS1 = New SGAFP.ucListaEMPRESAS
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaEMPRESAS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaEMPRESAS1
        '
        Me.UcListaEMPRESAS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEMPRESAS1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaEMPRESAS1.Name = "UcListaEMPRESAS1"
        Me.UcListaEMPRESAS1.PermitirAgregar = False
        Me.UcListaEMPRESAS1.PermitirBuscarEntityType = Nothing
        Me.UcListaEMPRESAS1.PermitirEliminar = False
        Me.UcListaEMPRESAS1.PermitirFiltrar = True
        Me.UcListaEMPRESAS1.PermitirGuardar = False
        Me.UcListaEMPRESAS1.PermitirNavegacion = False
        Me.UcListaEMPRESAS1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaEMPRESAS1.sError = Nothing
        Me.UcListaEMPRESAS1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaEMPRESAS1.TabIndex = 1
        '
        'ucBuscarEMPRESAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarEMPRESAS"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(EMPRESAS)
    End Sub
    Friend WithEvents UcListaEMPRESAS1 As SGAFP.ucListaEMPRESAS

End Class
