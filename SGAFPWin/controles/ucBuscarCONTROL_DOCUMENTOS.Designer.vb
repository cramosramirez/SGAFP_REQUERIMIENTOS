Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCONTROL_DOCUMENTOS
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
        Me.UcListaCONTROL_DOCUMENTOS1 = New SGAFP.ucListaCONTROL_DOCUMENTOS
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCONTROL_DOCUMENTOS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCONTROL_DOCUMENTOS1
        '
        Me.UcListaCONTROL_DOCUMENTOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTROL_DOCUMENTOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCONTROL_DOCUMENTOS1.Name = "UcListaCONTROL_DOCUMENTOS1"
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirAgregar = False
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirBuscarEntityType = Nothing
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirEliminar = False
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirFiltrar = True
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirGuardar = False
        Me.UcListaCONTROL_DOCUMENTOS1.PermitirNavegacion = False
        Me.UcListaCONTROL_DOCUMENTOS1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCONTROL_DOCUMENTOS1.sError = Nothing
        Me.UcListaCONTROL_DOCUMENTOS1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCONTROL_DOCUMENTOS1.TabIndex = 1
        '
        'ucBuscarCONTROL_DOCUMENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCONTROL_DOCUMENTOS"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CONTROL_DOCUMENTOS)
    End Sub
    Friend WithEvents UcListaCONTROL_DOCUMENTOS1 As SGAFP.ucListaCONTROL_DOCUMENTOS

End Class
