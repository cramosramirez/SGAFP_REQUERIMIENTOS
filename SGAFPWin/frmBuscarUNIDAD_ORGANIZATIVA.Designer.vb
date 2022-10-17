Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUNIDAD_ORGANIZATIVA
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
        Me.UcBuscarUNIDAD_ORGANIZATIVA1 = New SGAFP.ucBuscarUNIDAD_ORGANIZATIVA
        Me.SuspendLayout()
        '
        'UcBuscarUNIDAD_ORGANIZATIVA1
        '
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.EntityType = GetType(UNIDAD_ORGANIZATIVA)
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.Name = "UcBuscarUNIDAD_ORGANIZATIVA1"
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(582, 379)
        Me.UcBuscarUNIDAD_ORGANIZATIVA1.TabIndex = 0
        '
        'frmBuscarUNIDAD_ORGANIZATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.UcBuscarUNIDAD_ORGANIZATIVA1)
        Me.Name = "frmBuscarUNIDAD_ORGANIZATIVA"
        Me.Text = "Buscar UNIDAD_ORGANIZATIVA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBuscarUNIDAD_ORGANIZATIVA1 As SGAFP.ucBuscarUNIDAD_ORGANIZATIVA
End Class
