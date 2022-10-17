Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarREGION
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
        Me.UcListaREGION1 = New SGAFP.ucListaREGION
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaREGION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaREGION1
        '
        Me.UcListaREGION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaREGION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaREGION1.Name = "UcListaREGION1"
        Me.UcListaREGION1.PermitirAgregar = False
        Me.UcListaREGION1.PermitirBuscarEntityType = Nothing
        Me.UcListaREGION1.PermitirEliminar = False
        Me.UcListaREGION1.PermitirFiltrar = True
        Me.UcListaREGION1.PermitirGuardar = False
        Me.UcListaREGION1.PermitirNavegacion = False
        Me.UcListaREGION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaREGION1.sError = Nothing
        Me.UcListaREGION1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaREGION1.TabIndex = 1
        '
        'ucBuscarREGION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarREGION"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(REGION)
    End Sub
    Friend WithEvents UcListaREGION1 As SGAFP.ucListaREGION

End Class
