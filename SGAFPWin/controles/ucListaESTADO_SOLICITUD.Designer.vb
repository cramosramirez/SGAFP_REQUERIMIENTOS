<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaESTADO_SOLICITUD
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
        Me.ListaESTADO_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaESTADO_SOLICITUDDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaESTADO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaESTADO_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaESTADO_SOLICITUDBindingSource
        '
        Me.ListaESTADO_SOLICITUDBindingSource.DataSource = GetType(SGAFP.EL.ESTADO_SOLICITUD)
        '
        'ListaESTADO_SOLICITUDDataGridView
        '
        Me.ListaESTADO_SOLICITUDDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaESTADO_SOLICITUDDataGridView.AutoGenerateColumns = False
        Me.ListaESTADO_SOLICITUDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_ESTADO_SOLICITUD, Me.DataGridViewTextBoxESTADO_SOLICITUD, Me.DataGridViewTextBoxNOTAS})
        Me.ListaESTADO_SOLICITUDDataGridView.DataSource = Me.ListaESTADO_SOLICITUDBindingSource
        Me.ListaESTADO_SOLICITUDDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaESTADO_SOLICITUDDataGridView.Name = "ListaESTADO_SOLICITUDDataGridView"
        Me.ListaESTADO_SOLICITUDDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaESTADO_SOLICITUDDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_ESTADO_SOLICITUD
        '
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.DataPropertyName = "ID_ESTADO_SOLICITUD"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.HeaderText = "Id estado solicitud"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Name = "DataGridViewTextBoxID_ESTADO_SOLICITUD"
        '
        'DataGridViewTextBoxESTADO_SOLICITUD
        '
        Me.DataGridViewTextBoxESTADO_SOLICITUD.DataPropertyName = "ESTADO_SOLICITUD"
        Me.DataGridViewTextBoxESTADO_SOLICITUD.HeaderText = "Estado solicitud"
        Me.DataGridViewTextBoxESTADO_SOLICITUD.Name = "DataGridViewTextBoxESTADO_SOLICITUD"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaESTADO_SOLICITUD
        '
        Me.Controls.Add(Me.ListaESTADO_SOLICITUDDataGridView)
        Me.Name = "ucListaESTADO_SOLICITUD"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaESTADO_SOLICITUDDataGridView, 0)
        CType(Me.ListaESTADO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaESTADO_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaESTADO_SOLICITUDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaESTADO_SOLICITUDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_ESTADO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
