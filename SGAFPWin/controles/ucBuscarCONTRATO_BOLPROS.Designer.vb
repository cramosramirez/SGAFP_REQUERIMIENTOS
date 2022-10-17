Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCONTRATO_BOLPROS
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
        Me.UcListaCONTRATO_BOLPROS1 = New SGAFP.ucListaCONTRATO_BOLPROS
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCONTRATO_BOLPROS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCONTRATO_BOLPROS1
        '
        Me.UcListaCONTRATO_BOLPROS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTRATO_BOLPROS1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCONTRATO_BOLPROS1.Name = "UcListaCONTRATO_BOLPROS1"
        Me.UcListaCONTRATO_BOLPROS1.PermitirAgregar = False
        Me.UcListaCONTRATO_BOLPROS1.PermitirBuscarEntityType = Nothing
        Me.UcListaCONTRATO_BOLPROS1.PermitirEliminar = False
        Me.UcListaCONTRATO_BOLPROS1.PermitirFiltrar = True
        Me.UcListaCONTRATO_BOLPROS1.PermitirGuardar = False
        Me.UcListaCONTRATO_BOLPROS1.PermitirNavegacion = False
        Me.UcListaCONTRATO_BOLPROS1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCONTRATO_BOLPROS1.sError = Nothing
        Me.UcListaCONTRATO_BOLPROS1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCONTRATO_BOLPROS1.TabIndex = 1
        '
        'ucBuscarCONTRATO_BOLPROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCONTRATO_BOLPROS"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CONTRATO_BOLPROS)
    End Sub
    Friend WithEvents UcListaCONTRATO_BOLPROS1 As SGAFP.ucListaCONTRATO_BOLPROS

End Class
