<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarioCursos
    Inherits frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.UcCalendarioDeCursos1 = New SGAFP.ucCalendarioDeCursos
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcCalendarioDeCursos1
        '
        Me.UcCalendarioDeCursos1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCalendarioDeCursos1.Location = New System.Drawing.Point(0, 0)
        Me.UcCalendarioDeCursos1.Name = "UcCalendarioDeCursos1"
        Me.UcCalendarioDeCursos1.Size = New System.Drawing.Size(441, 299)
        Me.UcCalendarioDeCursos1.TabIndex = 4
        '
        'frmCalendarioCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 299)
        Me.Controls.Add(Me.UcCalendarioDeCursos1)
        Me.Name = "frmCalendarioCursos"
        Me.Text = "Calendario de Cursos"
        Me.Controls.SetChildIndex(Me.UcCalendarioDeCursos1, 0)
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents UcCalendarioDeCursos1 As SGAFP.ucCalendarioDeCursos
End Class
