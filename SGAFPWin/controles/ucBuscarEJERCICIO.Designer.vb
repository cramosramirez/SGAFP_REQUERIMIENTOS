Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarEJERCICIO
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
        Me.UcListaEJERCICIO1 = New SGAFP.ucListaEJERCICIO
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaEJERCICIO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaEJERCICIO1
        '
        Me.UcListaEJERCICIO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEJERCICIO1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaEJERCICIO1.Name = "UcListaEJERCICIO1"
        Me.UcListaEJERCICIO1.PermitirAgregar = False
        Me.UcListaEJERCICIO1.PermitirBuscarEntityType = Nothing
        Me.UcListaEJERCICIO1.PermitirEliminar = False
        Me.UcListaEJERCICIO1.PermitirFiltrar = True
        Me.UcListaEJERCICIO1.PermitirGuardar = False
        Me.UcListaEJERCICIO1.PermitirNavegacion = False
        Me.UcListaEJERCICIO1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaEJERCICIO1.sError = Nothing
        Me.UcListaEJERCICIO1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaEJERCICIO1.TabIndex = 1
        '
        'ucBuscarEJERCICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarEJERCICIO"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(EJERCICIO)
    End Sub
    Friend WithEvents UcListaEJERCICIO1 As SGAFP.ucListaEJERCICIO

End Class
