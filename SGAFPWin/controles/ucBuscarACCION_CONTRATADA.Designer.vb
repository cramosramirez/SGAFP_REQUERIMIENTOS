Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarACCION_CONTRATADA
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
        Me.UcListaACCION_CONTRATADA1 = New SGAFP.ucListaACCION_CONTRATADA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaACCION_CONTRATADA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaACCION_CONTRATADA1
        '
        Me.UcListaACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaACCION_CONTRATADA1.Name = "UcListaACCION_CONTRATADA1"
        Me.UcListaACCION_CONTRATADA1.PermitirAgregar = False
        Me.UcListaACCION_CONTRATADA1.PermitirBuscarEntityType = Nothing
        Me.UcListaACCION_CONTRATADA1.PermitirEliminar = False
        Me.UcListaACCION_CONTRATADA1.PermitirFiltrar = True
        Me.UcListaACCION_CONTRATADA1.PermitirGuardar = False
        Me.UcListaACCION_CONTRATADA1.PermitirNavegacion = False
        Me.UcListaACCION_CONTRATADA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaACCION_CONTRATADA1.sError = Nothing
        Me.UcListaACCION_CONTRATADA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaACCION_CONTRATADA1.TabIndex = 1
        '
        'ucBuscarACCION_CONTRATADA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ACCION_CONTRATADA)
    End Sub
    Friend WithEvents UcListaACCION_CONTRATADA1 As SGAFP.ucListaACCION_CONTRATADA

End Class
