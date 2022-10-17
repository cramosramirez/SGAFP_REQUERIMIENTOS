<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotivoCambio
    Inherits frmBase

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
        Me.MemoEditMotivo = New DevExpress.XtraEditors.MemoEdit
        Me.LabelMensaje = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButtonAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButtonCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.MemoEditMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemoEditMotivo
        '
        Me.MemoEditMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEditMotivo.Location = New System.Drawing.Point(12, 32)
        Me.MemoEditMotivo.Name = "MemoEditMotivo"
        Me.MemoEditMotivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MemoEditMotivo.Size = New System.Drawing.Size(302, 98)
        Me.MemoEditMotivo.TabIndex = 0
        '
        'LabelMensaje
        '
        Me.LabelMensaje.Location = New System.Drawing.Point(12, 12)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(0, 13)
        Me.LabelMensaje.TabIndex = 2
        '
        'SimpleButtonAceptar
        '
        Me.SimpleButtonAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButtonAceptar.Location = New System.Drawing.Point(64, 140)
        Me.SimpleButtonAceptar.Name = "SimpleButtonAceptar"
        Me.SimpleButtonAceptar.Size = New System.Drawing.Size(86, 22)
        Me.SimpleButtonAceptar.TabIndex = 3
        Me.SimpleButtonAceptar.Text = "Aceptar"
        '
        'SimpleButtonCancelar
        '
        Me.SimpleButtonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButtonCancelar.Location = New System.Drawing.Point(174, 140)
        Me.SimpleButtonCancelar.Name = "SimpleButtonCancelar"
        Me.SimpleButtonCancelar.Size = New System.Drawing.Size(86, 22)
        Me.SimpleButtonCancelar.TabIndex = 4
        Me.SimpleButtonCancelar.Text = "Cancelar"
        '
        'frmMotivoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButtonCancelar
        Me.ClientSize = New System.Drawing.Size(326, 173)
        Me.Controls.Add(Me.SimpleButtonCancelar)
        Me.Controls.Add(Me.SimpleButtonAceptar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.MemoEditMotivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMotivoCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Anulación de Factura"
        Me.Controls.SetChildIndex(Me.MemoEditMotivo, 0)
        Me.Controls.SetChildIndex(Me.LabelMensaje, 0)
        Me.Controls.SetChildIndex(Me.SimpleButtonAceptar, 0)
        Me.Controls.SetChildIndex(Me.SimpleButtonCancelar, 0)
        CType(Me.MemoEditMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MemoEditMotivo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelMensaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonCancelar As DevExpress.XtraEditors.SimpleButton
End Class
