﻿Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarASISTENCIA_AF_DET
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
        Me.UcListaASISTENCIA_AF_DET1 = New SGAFP.ucListaASISTENCIA_AF_DET
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaASISTENCIA_AF_DET1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaASISTENCIA_AF_DET1
        '
        Me.UcListaASISTENCIA_AF_DET1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaASISTENCIA_AF_DET1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaASISTENCIA_AF_DET1.Name = "UcListaASISTENCIA_AF_DET1"
        Me.UcListaASISTENCIA_AF_DET1.PermitirAgregar = False
        Me.UcListaASISTENCIA_AF_DET1.PermitirBuscarEntityType = Nothing
        Me.UcListaASISTENCIA_AF_DET1.PermitirEliminar = False
        Me.UcListaASISTENCIA_AF_DET1.PermitirFiltrar = True
        Me.UcListaASISTENCIA_AF_DET1.PermitirGuardar = False
        Me.UcListaASISTENCIA_AF_DET1.PermitirNavegacion = False
        Me.UcListaASISTENCIA_AF_DET1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaASISTENCIA_AF_DET1.sError = Nothing
        Me.UcListaASISTENCIA_AF_DET1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaASISTENCIA_AF_DET1.TabIndex = 1
        '
        'ucBuscarASISTENCIA_AF_DET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarASISTENCIA_AF_DET"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ASISTENCIA_AF_DET)
    End Sub
    Friend WithEvents UcListaASISTENCIA_AF_DET1 As SGAFP.ucListaASISTENCIA_AF_DET

End Class
