Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCATCURSO_2
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
        Me.UcListaCATCURSO_21 = New SGAFP.ucListaCATCURSO_2
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCATCURSO_21)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCATCURSO_21
        '
        Me.UcListaCATCURSO_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCATCURSO_21.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCATCURSO_21.Name = "UcListaCATCURSO_21"
        Me.UcListaCATCURSO_21.PermitirAgregar = False
        Me.UcListaCATCURSO_21.PermitirBuscarEntityType = Nothing
        Me.UcListaCATCURSO_21.PermitirEliminar = False
        Me.UcListaCATCURSO_21.PermitirFiltrar = True
        Me.UcListaCATCURSO_21.PermitirGuardar = False
        Me.UcListaCATCURSO_21.PermitirNavegacion = False
        Me.UcListaCATCURSO_21.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCATCURSO_21.sError = Nothing
        Me.UcListaCATCURSO_21.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCATCURSO_21.TabIndex = 1
        '
        'ucBuscarCATCURSO_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCATCURSO_2"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CATCURSO_2)
    End Sub
    Friend WithEvents UcListaCATCURSO_21 As SGAFP.ucListaCATCURSO_2

End Class
