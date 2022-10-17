<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaHALLAZGO_SUPERVISION
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
        Me.ListaHALLAZGO_SUPERVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaHALLAZGO_SUPERVISIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_AREA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SUPERVISION_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxHALLAZGO_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_SANCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIEMPO_SANCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_SANCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIEMPO_SUBSANACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaHALLAZGO_SUPERVISIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaHALLAZGO_SUPERVISIONBindingSource
        '
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.DataSource = GetType(SGAFP.EL.HALLAZGO_SUPERVISION)
        '
        'ListaHALLAZGO_SUPERVISIONDataGridView
        '
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.AutoGenerateColumns = False
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION, Me.DataGridViewTextBoxID_AREA_SUPERVISION, Me.DataGridViewTextBoxID_SUPERVISION_AF, Me.DataGridViewTextBoxHALLAZGO_SUPERVISION, Me.DataGridViewTextBoxFECHA, Me.DataGridViewTextBoxTIPO_SANCION, Me.DataGridViewTextBoxTIEMPO_SANCION, Me.DataGridViewTextBoxMONTO_SANCION, Me.DataGridViewTextBoxTIEMPO_SUBSANACION})
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.DataSource = Me.ListaHALLAZGO_SUPERVISIONBindingSource
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.Name = "ListaHALLAZGO_SUPERVISIONDataGridView"
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_HALLAZGO_SUPERVISION
        '
        Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION.DataPropertyName = "ID_HALLAZGO_SUPERVISION"
        Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION.HeaderText = "Id hallazgo supervision"
        Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION.Name = "DataGridViewTextBoxID_HALLAZGO_SUPERVISION"
        '
        'DataGridViewTextBoxID_AREA_SUPERVISION
        '
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.DataPropertyName = "ID_AREA_SUPERVISION"
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.HeaderText = "Id area supervision"
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.Name = "DataGridViewTextBoxID_AREA_SUPERVISION"
        '
        'DataGridViewTextBoxID_SUPERVISION_AF
        '
        Me.DataGridViewTextBoxID_SUPERVISION_AF.DataPropertyName = "ID_SUPERVISION_AF"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.HeaderText = "Id supervision af"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.Name = "DataGridViewTextBoxID_SUPERVISION_AF"
        '
        'DataGridViewTextBoxHALLAZGO_SUPERVISION
        '
        Me.DataGridViewTextBoxHALLAZGO_SUPERVISION.DataPropertyName = "HALLAZGO_SUPERVISION"
        Me.DataGridViewTextBoxHALLAZGO_SUPERVISION.HeaderText = "Hallazgo supervision"
        Me.DataGridViewTextBoxHALLAZGO_SUPERVISION.Name = "DataGridViewTextBoxHALLAZGO_SUPERVISION"
        '
        'DataGridViewTextBoxFECHA
        '
        Me.DataGridViewTextBoxFECHA.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxFECHA.HeaderText = "Fecha"
        Me.DataGridViewTextBoxFECHA.Name = "DataGridViewTextBoxFECHA"
        '
        'DataGridViewTextBoxTIPO_SANCION
        '
        Me.DataGridViewTextBoxTIPO_SANCION.DataPropertyName = "TIPO_SANCION"
        Me.DataGridViewTextBoxTIPO_SANCION.HeaderText = "Tipo sancion"
        Me.DataGridViewTextBoxTIPO_SANCION.Name = "DataGridViewTextBoxTIPO_SANCION"
        '
        'DataGridViewTextBoxTIEMPO_SANCION
        '
        Me.DataGridViewTextBoxTIEMPO_SANCION.DataPropertyName = "TIEMPO_SANCION"
        Me.DataGridViewTextBoxTIEMPO_SANCION.HeaderText = "Tiempo sancion"
        Me.DataGridViewTextBoxTIEMPO_SANCION.Name = "DataGridViewTextBoxTIEMPO_SANCION"
        '
        'DataGridViewTextBoxMONTO_SANCION
        '
        Me.DataGridViewTextBoxMONTO_SANCION.DataPropertyName = "MONTO_SANCION"
        Me.DataGridViewTextBoxMONTO_SANCION.HeaderText = "Monto sancion"
        Me.DataGridViewTextBoxMONTO_SANCION.Name = "DataGridViewTextBoxMONTO_SANCION"
        '
        'DataGridViewTextBoxTIEMPO_SUBSANACION
        '
        Me.DataGridViewTextBoxTIEMPO_SUBSANACION.DataPropertyName = "TIEMPO_SUBSANACION"
        Me.DataGridViewTextBoxTIEMPO_SUBSANACION.HeaderText = "Tiempo subsanacion"
        Me.DataGridViewTextBoxTIEMPO_SUBSANACION.Name = "DataGridViewTextBoxTIEMPO_SUBSANACION"
        '
        'ucListaHALLAZGO_SUPERVISION
        '
        Me.Controls.Add(Me.ListaHALLAZGO_SUPERVISIONDataGridView)
        Me.Name = "ucListaHALLAZGO_SUPERVISION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaHALLAZGO_SUPERVISIONDataGridView, 0)
        CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaHALLAZGO_SUPERVISIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaHALLAZGO_SUPERVISIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaHALLAZGO_SUPERVISIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_HALLAZGO_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_AREA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SUPERVISION_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxHALLAZGO_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_SANCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIEMPO_SANCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_SANCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIEMPO_SUBSANACION As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
