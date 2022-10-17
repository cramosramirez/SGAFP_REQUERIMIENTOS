Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantPARTICIPANTE_EXONERADO_DOC
    Inherits SGAFP.ucBaseMant

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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaPARTICIPANTE1 = New SGAFP.ucListaPARTICIPANTE
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FireScrollEventOnMouseWheel = True
        Me.SplitContainer1.Horizontal = False
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaPARTICIPANTE1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 418
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaPARTICIPANTE1
        '
        Me.UcListaPARTICIPANTE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPARTICIPANTE1.EsParticipantesExoneradosDocumentos = False
        Me.UcListaPARTICIPANTE1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaPARTICIPANTE1.Name = "UcListaPARTICIPANTE1"
        Me.UcListaPARTICIPANTE1.PermitirBuscarEntityType = Nothing
        Me.UcListaPARTICIPANTE1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaPARTICIPANTE1.sError = Nothing
        Me.UcListaPARTICIPANTE1.Size = New System.Drawing.Size(650, 418)
        Me.UcListaPARTICIPANTE1.TabIndex = 0
        '
        'ucMantPARTICIPANTE_EXONERADO_DOC
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantPARTICIPANTE_EXONERADO_DOC"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaPARTICIPANTE1 As SGAFP.ucListaPARTICIPANTE

End Class
