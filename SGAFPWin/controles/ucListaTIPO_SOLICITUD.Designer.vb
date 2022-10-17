<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaTIPO_SOLICITUD
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
        Me.ListaTIPO_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTIPO_SOLICITUDDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_PROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTABLA_RELACIONAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaTIPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTIPO_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaTIPO_SOLICITUDBindingSource
        '
        Me.ListaTIPO_SOLICITUDBindingSource.DataSource = GetType(SGAFP.EL.TIPO_SOLICITUD)
        '
        'ListaTIPO_SOLICITUDDataGridView
        '
        Me.ListaTIPO_SOLICITUDDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaTIPO_SOLICITUDDataGridView.AutoGenerateColumns = False
        Me.ListaTIPO_SOLICITUDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_TIPO_SOLICITUD, Me.DataGridViewTextBoxCODIGO_PROCESO, Me.DataGridViewTextBoxTIPO_SOLICITUD, Me.DataGridViewTextBoxTABLA_RELACIONAL, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaTIPO_SOLICITUDDataGridView.DataSource = Me.ListaTIPO_SOLICITUDBindingSource
        Me.ListaTIPO_SOLICITUDDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaTIPO_SOLICITUDDataGridView.Name = "ListaTIPO_SOLICITUDDataGridView"
        Me.ListaTIPO_SOLICITUDDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaTIPO_SOLICITUDDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_TIPO_SOLICITUD
        '
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.DataPropertyName = "ID_TIPO_SOLICITUD"
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.HeaderText = "Id tipo solicitud"
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.Name = "DataGridViewTextBoxID_TIPO_SOLICITUD"
        '
        'DataGridViewTextBoxCODIGO_PROCESO
        '
        Me.DataGridViewTextBoxCODIGO_PROCESO.DataPropertyName = "CODIGO_PROCESO"
        Me.DataGridViewTextBoxCODIGO_PROCESO.HeaderText = "Codigo proceso"
        Me.DataGridViewTextBoxCODIGO_PROCESO.Name = "DataGridViewTextBoxCODIGO_PROCESO"
        '
        'DataGridViewTextBoxTIPO_SOLICITUD
        '
        Me.DataGridViewTextBoxTIPO_SOLICITUD.DataPropertyName = "TIPO_SOLICITUD"
        Me.DataGridViewTextBoxTIPO_SOLICITUD.HeaderText = "Tipo solicitud"
        Me.DataGridViewTextBoxTIPO_SOLICITUD.Name = "DataGridViewTextBoxTIPO_SOLICITUD"
        '
        'DataGridViewTextBoxTABLA_RELACIONAL
        '
        Me.DataGridViewTextBoxTABLA_RELACIONAL.DataPropertyName = "TABLA_RELACIONAL"
        Me.DataGridViewTextBoxTABLA_RELACIONAL.HeaderText = "Tabla relacional"
        Me.DataGridViewTextBoxTABLA_RELACIONAL.Name = "DataGridViewTextBoxTABLA_RELACIONAL"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxUSERID
        '
        Me.DataGridViewTextBoxUSERID.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxUSERID.HeaderText = "Userid"
        Me.DataGridViewTextBoxUSERID.Name = "DataGridViewTextBoxUSERID"
        '
        'DataGridViewTextBoxLASTUPDATE
        '
        Me.DataGridViewTextBoxLASTUPDATE.DataPropertyName = "LASTUPDATE"
        Me.DataGridViewTextBoxLASTUPDATE.HeaderText = "Lastupdate"
        Me.DataGridViewTextBoxLASTUPDATE.Name = "DataGridViewTextBoxLASTUPDATE"
        '
        'ucListaTIPO_SOLICITUD
        '
        Me.Controls.Add(Me.ListaTIPO_SOLICITUDDataGridView)
        Me.Name = "ucListaTIPO_SOLICITUD"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaTIPO_SOLICITUDDataGridView, 0)
        CType(Me.ListaTIPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTIPO_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_SOLICITUDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTIPO_SOLICITUDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_TIPO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_PROCESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTABLA_RELACIONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
