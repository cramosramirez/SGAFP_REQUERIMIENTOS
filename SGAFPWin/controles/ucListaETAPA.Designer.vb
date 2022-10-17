<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaETAPA
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
        Me.ListaETAPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaETAPADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCODIGO_ETAPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_PROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_ETAPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxETAPA_ANT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxETAPA_SIG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_ETAPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxORDEN_EJECUCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaETAPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaETAPADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaETAPABindingSource
        '
        Me.ListaETAPABindingSource.DataSource = GetType(SGAFP.EL.ETAPA)
        '
        'ListaETAPADataGridView
        '
        Me.ListaETAPADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaETAPADataGridView.AutoGenerateColumns = False
        Me.ListaETAPADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCODIGO_ETAPA, Me.DataGridViewTextBoxCODIGO_PROCESO, Me.DataGridViewTextBoxID_ESTADO_SOLICITUD, Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO, Me.DataGridViewTextBoxNOMBRE_ETAPA, Me.DataGridViewTextBoxETAPA_ANT, Me.DataGridViewTextBoxETAPA_SIG, Me.DataGridViewTextBoxTIPO_ETAPA, Me.DataGridViewTextBoxDURACION, Me.DataGridViewTextBoxORDEN_EJECUCION, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaETAPADataGridView.DataSource = Me.ListaETAPABindingSource
        Me.ListaETAPADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaETAPADataGridView.Name = "ListaETAPADataGridView"
        Me.ListaETAPADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaETAPADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCODIGO_ETAPA
        '
        Me.DataGridViewTextBoxCODIGO_ETAPA.DataPropertyName = "CODIGO_ETAPA"
        Me.DataGridViewTextBoxCODIGO_ETAPA.HeaderText = "Codigo etapa"
        Me.DataGridViewTextBoxCODIGO_ETAPA.Name = "DataGridViewTextBoxCODIGO_ETAPA"
        '
        'DataGridViewTextBoxCODIGO_PROCESO
        '
        Me.DataGridViewTextBoxCODIGO_PROCESO.DataPropertyName = "CODIGO_PROCESO"
        Me.DataGridViewTextBoxCODIGO_PROCESO.HeaderText = "Codigo proceso"
        Me.DataGridViewTextBoxCODIGO_PROCESO.Name = "DataGridViewTextBoxCODIGO_PROCESO"
        '
        'DataGridViewTextBoxID_ESTADO_SOLICITUD
        '
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.DataPropertyName = "ID_ESTADO_SOLICITUD"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.HeaderText = "Id estado solicitud"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Name = "DataGridViewTextBoxID_ESTADO_SOLICITUD"
        '
        'DataGridViewTextBoxUNIDAD_DE_TIEMPO
        '
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.DataPropertyName = "UNIDAD_DE_TIEMPO"
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.HeaderText = "Unidad de tiempo"
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.Name = "DataGridViewTextBoxUNIDAD_DE_TIEMPO"
        '
        'DataGridViewTextBoxNOMBRE_ETAPA
        '
        Me.DataGridViewTextBoxNOMBRE_ETAPA.DataPropertyName = "NOMBRE_ETAPA"
        Me.DataGridViewTextBoxNOMBRE_ETAPA.HeaderText = "Nombre etapa"
        Me.DataGridViewTextBoxNOMBRE_ETAPA.Name = "DataGridViewTextBoxNOMBRE_ETAPA"
        '
        'DataGridViewTextBoxETAPA_ANT
        '
        Me.DataGridViewTextBoxETAPA_ANT.DataPropertyName = "ETAPA_ANT"
        Me.DataGridViewTextBoxETAPA_ANT.HeaderText = "Etapa ant"
        Me.DataGridViewTextBoxETAPA_ANT.Name = "DataGridViewTextBoxETAPA_ANT"
        '
        'DataGridViewTextBoxETAPA_SIG
        '
        Me.DataGridViewTextBoxETAPA_SIG.DataPropertyName = "ETAPA_SIG"
        Me.DataGridViewTextBoxETAPA_SIG.HeaderText = "Etapa sig"
        Me.DataGridViewTextBoxETAPA_SIG.Name = "DataGridViewTextBoxETAPA_SIG"
        '
        'DataGridViewTextBoxTIPO_ETAPA
        '
        Me.DataGridViewTextBoxTIPO_ETAPA.DataPropertyName = "TIPO_ETAPA"
        Me.DataGridViewTextBoxTIPO_ETAPA.HeaderText = "Tipo etapa"
        Me.DataGridViewTextBoxTIPO_ETAPA.Name = "DataGridViewTextBoxTIPO_ETAPA"
        '
        'DataGridViewTextBoxDURACION
        '
        Me.DataGridViewTextBoxDURACION.DataPropertyName = "DURACION"
        Me.DataGridViewTextBoxDURACION.HeaderText = "Duracion"
        Me.DataGridViewTextBoxDURACION.Name = "DataGridViewTextBoxDURACION"
        '
        'DataGridViewTextBoxORDEN_EJECUCION
        '
        Me.DataGridViewTextBoxORDEN_EJECUCION.DataPropertyName = "ORDEN_EJECUCION"
        Me.DataGridViewTextBoxORDEN_EJECUCION.HeaderText = "Orden ejecucion"
        Me.DataGridViewTextBoxORDEN_EJECUCION.Name = "DataGridViewTextBoxORDEN_EJECUCION"
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
        'ucListaETAPA
        '
        Me.Controls.Add(Me.ListaETAPADataGridView)
        Me.Name = "ucListaETAPA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaETAPADataGridView, 0)
        CType(Me.ListaETAPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaETAPADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaETAPABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaETAPADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCODIGO_ETAPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_PROCESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ESTADO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUNIDAD_DE_TIEMPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_ETAPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxETAPA_ANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxETAPA_SIG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_ETAPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxORDEN_EJECUCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
