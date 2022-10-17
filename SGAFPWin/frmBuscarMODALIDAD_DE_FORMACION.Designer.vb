Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarMODALIDAD_DE_FORMACION
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
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
        Me.UcBuscarMODALIDAD_DE_FORMACION1 = New SGAFP.ucBuscarMODALIDAD_DE_FORMACION
        Me.SuspendLayout()
        '
        'UcBuscarMODALIDAD_DE_FORMACION1
        '
        Me.UcBuscarMODALIDAD_DE_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarMODALIDAD_DE_FORMACION1.EntityType = GetType(MODALIDAD_DE_FORMACION)
        Me.UcBuscarMODALIDAD_DE_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarMODALIDAD_DE_FORMACION1.Name = "UcBuscarMODALIDAD_DE_FORMACION1"
        Me.UcBuscarMODALIDAD_DE_FORMACION1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarMODALIDAD_DE_FORMACION1.TabIndex = 0
        '
        'frmBuscarMODALIDAD_DE_FORMACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarMODALIDAD_DE_FORMACION1)
        Me.Name = "frmBuscarMODALIDAD_DE_FORMACION"
        Me.Text = "Buscar MODALIDAD_DE_FORMACION"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarMODALIDAD_DE_FORMACION1 As SGAFP.ucBuscarMODALIDAD_DE_FORMACION
End Class
