Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarTIPO_CONTRATACION
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
        Me.UcListaTIPO_CONTRATACION1 = New SGAFP.ucListaTIPO_CONTRATACION
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaTIPO_CONTRATACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaTIPO_CONTRATACION1
        '
        Me.UcListaTIPO_CONTRATACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaTIPO_CONTRATACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaTIPO_CONTRATACION1.Name = "UcListaTIPO_CONTRATACION1"
        Me.UcListaTIPO_CONTRATACION1.PermitirAgregar = False
        Me.UcListaTIPO_CONTRATACION1.PermitirBuscarEntityType = Nothing
        Me.UcListaTIPO_CONTRATACION1.PermitirEliminar = False
        Me.UcListaTIPO_CONTRATACION1.PermitirFiltrar = True
        Me.UcListaTIPO_CONTRATACION1.PermitirGuardar = False
        Me.UcListaTIPO_CONTRATACION1.PermitirNavegacion = False
        Me.UcListaTIPO_CONTRATACION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaTIPO_CONTRATACION1.sError = Nothing
        Me.UcListaTIPO_CONTRATACION1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaTIPO_CONTRATACION1.TabIndex = 1
        '
        'ucBuscarTIPO_CONTRATACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarTIPO_CONTRATACION"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(TIPO_CONTRATACION)
    End Sub
    Friend WithEvents UcListaTIPO_CONTRATACION1 As SGAFP.ucListaTIPO_CONTRATACION

End Class
