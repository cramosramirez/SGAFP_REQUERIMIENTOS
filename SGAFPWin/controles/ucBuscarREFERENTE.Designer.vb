Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarREFERENTE
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
        Me.UcListaREFERENTE1 = New SGAFP.ucListaREFERENTE
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaREFERENTE1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaREFERENTE1
        '
        Me.UcListaREFERENTE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaREFERENTE1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaREFERENTE1.Name = "UcListaREFERENTE1"
        Me.UcListaREFERENTE1.PermitirAgregar = False
        Me.UcListaREFERENTE1.PermitirBuscarEntityType = Nothing
        Me.UcListaREFERENTE1.PermitirEliminar = False
        Me.UcListaREFERENTE1.PermitirFiltrar = True
        Me.UcListaREFERENTE1.PermitirGuardar = False
        Me.UcListaREFERENTE1.PermitirNavegacion = False
        Me.UcListaREFERENTE1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaREFERENTE1.sError = Nothing
        Me.UcListaREFERENTE1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaREFERENTE1.TabIndex = 1
        '
        'ucBuscarREFERENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarREFERENTE"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(REFERENTE)
    End Sub
    Friend WithEvents UcListaREFERENTE1 As SGAFP.ucListaREFERENTE

End Class
