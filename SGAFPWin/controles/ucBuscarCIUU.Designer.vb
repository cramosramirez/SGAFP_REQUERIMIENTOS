Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCIUU
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
        Me.UcListaCIUU1 = New SGAFP.ucListaCIUU
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCIUU1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCIUU1
        '
        Me.UcListaCIUU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCIUU1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCIUU1.Name = "UcListaCIUU1"
        Me.UcListaCIUU1.PermitirAgregar = False
        Me.UcListaCIUU1.PermitirBuscarEntityType = Nothing
        Me.UcListaCIUU1.PermitirEliminar = False
        Me.UcListaCIUU1.PermitirFiltrar = True
        Me.UcListaCIUU1.PermitirGuardar = False
        Me.UcListaCIUU1.PermitirNavegacion = False
        Me.UcListaCIUU1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCIUU1.sError = Nothing
        Me.UcListaCIUU1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCIUU1.TabIndex = 1
        '
        'ucBuscarCIUU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCIUU"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CIUU)
    End Sub
    Friend WithEvents UcListaCIUU1 As SGAFP.ucListaCIUU

End Class
