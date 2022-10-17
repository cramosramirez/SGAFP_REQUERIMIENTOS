Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarUNIDAD_ORGANIZATIVA
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
        Me.UcListaUNIDAD_ORGANIZATIVA1 = New SGAFP.ucListaUNIDAD_ORGANIZATIVA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaUNIDAD_ORGANIZATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaUNIDAD_ORGANIZATIVA1
        '
        Me.UcListaUNIDAD_ORGANIZATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaUNIDAD_ORGANIZATIVA1.Name = "UcListaUNIDAD_ORGANIZATIVA1"
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirAgregar = False
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirBuscarEntityType = Nothing
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirEliminar = False
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirFiltrar = True
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirGuardar = False
        Me.UcListaUNIDAD_ORGANIZATIVA1.PermitirNavegacion = False
        Me.UcListaUNIDAD_ORGANIZATIVA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaUNIDAD_ORGANIZATIVA1.sError = Nothing
        Me.UcListaUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaUNIDAD_ORGANIZATIVA1.TabIndex = 1
        '
        'ucBuscarUNIDAD_ORGANIZATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarUNIDAD_ORGANIZATIVA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(UNIDAD_ORGANIZATIVA)
    End Sub
    Friend WithEvents UcListaUNIDAD_ORGANIZATIVA1 As SGAFP.ucListaUNIDAD_ORGANIZATIVA

End Class
