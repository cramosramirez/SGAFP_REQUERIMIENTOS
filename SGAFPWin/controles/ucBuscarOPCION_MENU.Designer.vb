Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarOPCION_MENU
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
        Me.UcListaOPCION_MENU1 = New SGAFP.ucListaOPCION_MENU
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaOPCION_MENU1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaOPCION_MENU1
        '
        Me.UcListaOPCION_MENU1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaOPCION_MENU1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaOPCION_MENU1.Name = "UcListaOPCION_MENU1"
        Me.UcListaOPCION_MENU1.PermitirAgregar = False
        Me.UcListaOPCION_MENU1.PermitirBuscarEntityType = Nothing
        Me.UcListaOPCION_MENU1.PermitirEliminar = False
        Me.UcListaOPCION_MENU1.PermitirFiltrar = True
        Me.UcListaOPCION_MENU1.PermitirGuardar = False
        Me.UcListaOPCION_MENU1.PermitirNavegacion = False
        Me.UcListaOPCION_MENU1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaOPCION_MENU1.sError = Nothing
        Me.UcListaOPCION_MENU1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaOPCION_MENU1.TabIndex = 1
        '
        'ucBuscarOPCION_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarOPCION_MENU"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(OPCION_MENU)
    End Sub
    Friend WithEvents UcListaOPCION_MENU1 As SGAFP.ucListaOPCION_MENU

End Class
