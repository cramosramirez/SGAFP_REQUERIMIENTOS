Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarFACILITADOR_CAPACITADOR
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
        Me.UcListaFACILITADOR_CAPACITADOR1 = New SGAFP.ucListaFACILITADOR_CAPACITADOR
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaFACILITADOR_CAPACITADOR1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaFACILITADOR_CAPACITADOR1
        '
        Me.UcListaFACILITADOR_CAPACITADOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaFACILITADOR_CAPACITADOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaFACILITADOR_CAPACITADOR1.Name = "UcListaFACILITADOR_CAPACITADOR1"
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirAgregar = False
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirBuscarEntityType = Nothing
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirEliminar = False
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirFiltrar = True
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirGuardar = False
        Me.UcListaFACILITADOR_CAPACITADOR1.PermitirNavegacion = False
        Me.UcListaFACILITADOR_CAPACITADOR1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaFACILITADOR_CAPACITADOR1.sError = Nothing
        Me.UcListaFACILITADOR_CAPACITADOR1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaFACILITADOR_CAPACITADOR1.TabIndex = 1
        '
        'ucBuscarFACILITADOR_CAPACITADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarFACILITADOR_CAPACITADOR"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(FACILITADOR_CAPACITADOR)
    End Sub
    Friend WithEvents UcListaFACILITADOR_CAPACITADOR1 As SGAFP.ucListaFACILITADOR_CAPACITADOR

End Class
