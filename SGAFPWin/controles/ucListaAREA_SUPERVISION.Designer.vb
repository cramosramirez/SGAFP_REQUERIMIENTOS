<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaAREA_SUPERVISION
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
        Me.ListaAREA_SUPERVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaAREA_SUPERVISIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_AREA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAREA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxSANCIONATORIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_SANCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIEMPO_SANCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaAREA_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaAREA_SUPERVISIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaAREA_SUPERVISIONBindingSource
        '
        Me.ListaAREA_SUPERVISIONBindingSource.DataSource = GetType(SGAFP.EL.AREA_SUPERVISION)
        '
        'ListaAREA_SUPERVISIONDataGridView
        '
        Me.ListaAREA_SUPERVISIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaAREA_SUPERVISIONDataGridView.AutoGenerateColumns = False
        Me.ListaAREA_SUPERVISIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_AREA_SUPERVISION, Me.DataGridViewTextBoxAREA_SUPERVISION, Me.DataGridViewTextBoxSANCIONATORIA, Me.DataGridViewTextBoxMONTO_SANCION, Me.DataGridViewTextBoxTIEMPO_SANCION, Me.DataGridViewTextBoxNOTAS})
        Me.ListaAREA_SUPERVISIONDataGridView.DataSource = Me.ListaAREA_SUPERVISIONBindingSource
        Me.ListaAREA_SUPERVISIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaAREA_SUPERVISIONDataGridView.Name = "ListaAREA_SUPERVISIONDataGridView"
        Me.ListaAREA_SUPERVISIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaAREA_SUPERVISIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_AREA_SUPERVISION
        '
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.DataPropertyName = "ID_AREA_SUPERVISION"
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.HeaderText = "Id area supervision"
        Me.DataGridViewTextBoxID_AREA_SUPERVISION.Name = "DataGridViewTextBoxID_AREA_SUPERVISION"
        '
        'DataGridViewTextBoxAREA_SUPERVISION
        '
        Me.DataGridViewTextBoxAREA_SUPERVISION.DataPropertyName = "AREA_SUPERVISION"
        Me.DataGridViewTextBoxAREA_SUPERVISION.HeaderText = "Area supervision"
        Me.DataGridViewTextBoxAREA_SUPERVISION.Name = "DataGridViewTextBoxAREA_SUPERVISION"
        '
        'DataGridViewTextBoxSANCIONATORIA
        '
        Me.DataGridViewTextBoxSANCIONATORIA.DataPropertyName = "SANCIONATORIA"
        Me.DataGridViewTextBoxSANCIONATORIA.HeaderText = "Sancionatoria"
        Me.DataGridViewTextBoxSANCIONATORIA.Name = "DataGridViewTextBoxSANCIONATORIA"
        '
        'DataGridViewTextBoxMONTO_SANCION
        '
        Me.DataGridViewTextBoxMONTO_SANCION.DataPropertyName = "MONTO_SANCION"
        Me.DataGridViewTextBoxMONTO_SANCION.HeaderText = "Monto sancion"
        Me.DataGridViewTextBoxMONTO_SANCION.Name = "DataGridViewTextBoxMONTO_SANCION"
        '
        'DataGridViewTextBoxTIEMPO_SANCION
        '
        Me.DataGridViewTextBoxTIEMPO_SANCION.DataPropertyName = "TIEMPO_SANCION"
        Me.DataGridViewTextBoxTIEMPO_SANCION.HeaderText = "Tiempo sancion"
        Me.DataGridViewTextBoxTIEMPO_SANCION.Name = "DataGridViewTextBoxTIEMPO_SANCION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaAREA_SUPERVISION
        '
        Me.Controls.Add(Me.ListaAREA_SUPERVISIONDataGridView)
        Me.Name = "ucListaAREA_SUPERVISION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaAREA_SUPERVISIONDataGridView, 0)
        CType(Me.ListaAREA_SUPERVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaAREA_SUPERVISIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaAREA_SUPERVISIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaAREA_SUPERVISIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_AREA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAREA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxSANCIONATORIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_SANCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIEMPO_SANCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
