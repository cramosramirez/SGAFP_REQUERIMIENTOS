<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPARTICIPANTE_AF
    Inherits SGAFP.ucBaseLista

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
        Me.ListaPARTICIPANTE_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPARTICIPANTE_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INSCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTA_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPORC_ASISTENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxENTREGA_DIPLOMA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaPARTICIPANTE_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTE_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPARTICIPANTE_AFBindingSource
        '
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE_AF)
        '
        'ListaPARTICIPANTE_AFDataGridView
        '
        Me.ListaPARTICIPANTE_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPARTICIPANTE_AFDataGridView.AutoGenerateColumns = False
        Me.ListaPARTICIPANTE_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_PARTICIPANTE, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxID_SOLICITUD, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxFECHA_INSCRIPCION, Me.DataGridViewTextBoxNOTA_FINAL, Me.DataGridViewTextBoxPORC_ASISTENCIA, Me.DataGridViewTextBoxENTREGA_DIPLOMA, Me.DataGridViewTextBoxNOTAS})
        Me.ListaPARTICIPANTE_AFDataGridView.DataSource = Me.ListaPARTICIPANTE_AFBindingSource
        Me.ListaPARTICIPANTE_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaPARTICIPANTE_AFDataGridView.Name = "ListaPARTICIPANTE_AFDataGridView"
        Me.ListaPARTICIPANTE_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaPARTICIPANTE_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_PARTICIPANTE
        '
        Me.DataGridViewTextBoxID_PARTICIPANTE.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxID_PARTICIPANTE.HeaderText = "Id participante"
        Me.DataGridViewTextBoxID_PARTICIPANTE.Name = "DataGridViewTextBoxID_PARTICIPANTE"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxID_SOLICITUD
        '
        Me.DataGridViewTextBoxID_SOLICITUD.DataPropertyName = "ID_SOLICITUD"
        Me.DataGridViewTextBoxID_SOLICITUD.HeaderText = "Id solicitud"
        Me.DataGridViewTextBoxID_SOLICITUD.Name = "DataGridViewTextBoxID_SOLICITUD"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
        '
        'DataGridViewTextBoxFECHA_INSCRIPCION
        '
        Me.DataGridViewTextBoxFECHA_INSCRIPCION.DataPropertyName = "FECHA_INSCRIPCION"
        Me.DataGridViewTextBoxFECHA_INSCRIPCION.HeaderText = "Fecha inscripcion"
        Me.DataGridViewTextBoxFECHA_INSCRIPCION.Name = "DataGridViewTextBoxFECHA_INSCRIPCION"
        '
        'DataGridViewTextBoxNOTA_FINAL
        '
        Me.DataGridViewTextBoxNOTA_FINAL.DataPropertyName = "NOTA_FINAL"
        Me.DataGridViewTextBoxNOTA_FINAL.HeaderText = "Nota final"
        Me.DataGridViewTextBoxNOTA_FINAL.Name = "DataGridViewTextBoxNOTA_FINAL"
        '
        'DataGridViewTextBoxPORC_ASISTENCIA
        '
        Me.DataGridViewTextBoxPORC_ASISTENCIA.DataPropertyName = "PORC_ASISTENCIA"
        Me.DataGridViewTextBoxPORC_ASISTENCIA.HeaderText = "Porc asistencia"
        Me.DataGridViewTextBoxPORC_ASISTENCIA.Name = "DataGridViewTextBoxPORC_ASISTENCIA"
        '
        'DataGridViewTextBoxENTREGA_DIPLOMA
        '
        Me.DataGridViewTextBoxENTREGA_DIPLOMA.DataPropertyName = "ENTREGA_DIPLOMA"
        Me.DataGridViewTextBoxENTREGA_DIPLOMA.HeaderText = "Entrega diploma"
        Me.DataGridViewTextBoxENTREGA_DIPLOMA.Name = "DataGridViewTextBoxENTREGA_DIPLOMA"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaPARTICIPANTE_AF
        '
        Me.Controls.Add(Me.ListaPARTICIPANTE_AFDataGridView)
        Me.Name = "ucListaPARTICIPANTE_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPARTICIPANTE_AFDataGridView, 0)
        CType(Me.ListaPARTICIPANTE_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTE_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPARTICIPANTE_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPARTICIPANTE_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INSCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTA_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPORC_ASISTENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxENTREGA_DIPLOMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
