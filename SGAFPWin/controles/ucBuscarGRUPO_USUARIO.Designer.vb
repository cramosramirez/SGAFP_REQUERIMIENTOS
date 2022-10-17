Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarGRUPO_USUARIO
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
        Me.UcListaGRUPO_USUARIO1 = New SGAFP.ucListaGRUPO_USUARIO
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaGRUPO_USUARIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaGRUPO_USUARIO1
        '
        Me.UcListaGRUPO_USUARIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaGRUPO_USUARIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaGRUPO_USUARIO1.Name = "UcListaGRUPO_USUARIO1"
        Me.UcListaGRUPO_USUARIO1.PermitirAgregar = False
        Me.UcListaGRUPO_USUARIO1.PermitirBuscarEntityType = Nothing
        Me.UcListaGRUPO_USUARIO1.PermitirEliminar = False
        Me.UcListaGRUPO_USUARIO1.PermitirFiltrar = True
        Me.UcListaGRUPO_USUARIO1.PermitirGuardar = False
        Me.UcListaGRUPO_USUARIO1.PermitirNavegacion = False
        Me.UcListaGRUPO_USUARIO1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaGRUPO_USUARIO1.sError = Nothing
        Me.UcListaGRUPO_USUARIO1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaGRUPO_USUARIO1.TabIndex = 1
        '
        'ucBuscarGRUPO_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarGRUPO_USUARIO"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(GRUPO_USUARIO)
    End Sub
    Friend WithEvents UcListaGRUPO_USUARIO1 As SGAFP.ucListaGRUPO_USUARIO

End Class
