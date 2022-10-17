Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCURSO_TEMA
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
        Me.UcListaCURSO_TEMA1 = New SGAFP.ucListaCURSO_TEMA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCURSO_TEMA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCURSO_TEMA1
        '
        Me.UcListaCURSO_TEMA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCURSO_TEMA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCURSO_TEMA1.Name = "UcListaCURSO_TEMA1"
        Me.UcListaCURSO_TEMA1.PermitirAgregar = False
        Me.UcListaCURSO_TEMA1.PermitirBuscarEntityType = Nothing
        Me.UcListaCURSO_TEMA1.PermitirEliminar = False
        Me.UcListaCURSO_TEMA1.PermitirFiltrar = True
        Me.UcListaCURSO_TEMA1.PermitirGuardar = False
        Me.UcListaCURSO_TEMA1.PermitirNavegacion = False
        Me.UcListaCURSO_TEMA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCURSO_TEMA1.sError = Nothing
        Me.UcListaCURSO_TEMA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCURSO_TEMA1.TabIndex = 1
        '
        'ucBuscarCURSO_TEMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCURSO_TEMA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CURSO_TEMA)
    End Sub
    Friend WithEvents UcListaCURSO_TEMA1 As SGAFP.ucListaCURSO_TEMA

End Class
