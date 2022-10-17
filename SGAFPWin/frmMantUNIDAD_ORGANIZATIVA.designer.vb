<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantUNIDAD_ORGANIZATIVA
    Inherits SGAFP.frmMantPadre

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcMantUNIDAD_ORGANIZATIVA1 = New SGAFP.ucMantUNIDAD_ORGANIZATIVA
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(570, 23)
        '
        'UcMantUNIDAD_ORGANIZATIVA1
        '
        Me.UcMantUNIDAD_ORGANIZATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMantUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcMantUNIDAD_ORGANIZATIVA1.Name = "UcMantUNIDAD_ORGANIZATIVA1"
        Me.UcMantUNIDAD_ORGANIZATIVA1.sError = Nothing
        Me.UcMantUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(584, 356)
        Me.UcMantUNIDAD_ORGANIZATIVA1.TabIndex = 6
        '
        'frmMantUNIDAD_ORGANIZATIVA
        '
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.UcMantUNIDAD_ORGANIZATIVA1)
        Me.Name = "frmMantUNIDAD_ORGANIZATIVA"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.UcMantUNIDAD_ORGANIZATIVA1, 0)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcMantUNIDAD_ORGANIZATIVA1 As SGAFP.ucMantUNIDAD_ORGANIZATIVA

End Class

