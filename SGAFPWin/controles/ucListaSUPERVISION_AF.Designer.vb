<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSUPERVISION_AF
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
        Me.ListaSUPERVISION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSUPERVISION_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_SUPERVISION_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_MODALIDAD_FORMACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCENTRO_FORMACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxGRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxHORARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCOORDINADOR_CFP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECTOR_CFP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOBJETIVO_VISITA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION_VISITA = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaSUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSUPERVISION_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSUPERVISION_AFBindingSource
        '
        Me.ListaSUPERVISION_AFBindingSource.DataSource = GetType(SGAFP.EL.SUPERVISION_AF)
        '
        'ListaSUPERVISION_AFDataGridView
        '
        Me.ListaSUPERVISION_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSUPERVISION_AFDataGridView.AutoGenerateColumns = False
        Me.ListaSUPERVISION_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_SUPERVISION_AF, Me.DataGridViewTextBoxID_MODALIDAD_FORMACION, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxFECHA, Me.DataGridViewTextBoxNOMBRE_AF, Me.DataGridViewTextBoxCENTRO_FORMACION, Me.DataGridViewTextBoxOPCION, Me.DataGridViewTextBoxGRUPO, Me.DataGridViewTextBoxHORARIO, Me.DataGridViewTextBoxCODIGO, Me.DataGridViewTextBoxCOORDINADOR_CFP, Me.DataGridViewTextBoxDIRECTOR_CFP, Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES, Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES, Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS, Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS, Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES, Me.DataGridViewTextBoxOBJETIVO_VISITA, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxDURACION_VISITA})
        Me.ListaSUPERVISION_AFDataGridView.DataSource = Me.ListaSUPERVISION_AFBindingSource
        Me.ListaSUPERVISION_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaSUPERVISION_AFDataGridView.Name = "ListaSUPERVISION_AFDataGridView"
        Me.ListaSUPERVISION_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaSUPERVISION_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_SUPERVISION_AF
        '
        Me.DataGridViewTextBoxID_SUPERVISION_AF.DataPropertyName = "ID_SUPERVISION_AF"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.HeaderText = "Id supervision af"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.Name = "DataGridViewTextBoxID_SUPERVISION_AF"
        '
        'DataGridViewTextBoxID_MODALIDAD_FORMACION
        '
        Me.DataGridViewTextBoxID_MODALIDAD_FORMACION.DataPropertyName = "ID_MODALIDAD_FORMACION"
        Me.DataGridViewTextBoxID_MODALIDAD_FORMACION.HeaderText = "Id modalidad formacion"
        Me.DataGridViewTextBoxID_MODALIDAD_FORMACION.Name = "DataGridViewTextBoxID_MODALIDAD_FORMACION"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxFECHA
        '
        Me.DataGridViewTextBoxFECHA.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxFECHA.HeaderText = "Fecha"
        Me.DataGridViewTextBoxFECHA.Name = "DataGridViewTextBoxFECHA"
        '
        'DataGridViewTextBoxNOMBRE_AF
        '
        Me.DataGridViewTextBoxNOMBRE_AF.DataPropertyName = "NOMBRE_AF"
        Me.DataGridViewTextBoxNOMBRE_AF.HeaderText = "Nombre af"
        Me.DataGridViewTextBoxNOMBRE_AF.Name = "DataGridViewTextBoxNOMBRE_AF"
        '
        'DataGridViewTextBoxCENTRO_FORMACION
        '
        Me.DataGridViewTextBoxCENTRO_FORMACION.DataPropertyName = "CENTRO_FORMACION"
        Me.DataGridViewTextBoxCENTRO_FORMACION.HeaderText = "Centro formacion"
        Me.DataGridViewTextBoxCENTRO_FORMACION.Name = "DataGridViewTextBoxCENTRO_FORMACION"
        '
        'DataGridViewTextBoxOPCION
        '
        Me.DataGridViewTextBoxOPCION.DataPropertyName = "OPCION"
        Me.DataGridViewTextBoxOPCION.HeaderText = "Opcion"
        Me.DataGridViewTextBoxOPCION.Name = "DataGridViewTextBoxOPCION"
        '
        'DataGridViewTextBoxGRUPO
        '
        Me.DataGridViewTextBoxGRUPO.DataPropertyName = "GRUPO"
        Me.DataGridViewTextBoxGRUPO.HeaderText = "Grupo"
        Me.DataGridViewTextBoxGRUPO.Name = "DataGridViewTextBoxGRUPO"
        '
        'DataGridViewTextBoxHORARIO
        '
        Me.DataGridViewTextBoxHORARIO.DataPropertyName = "HORARIO"
        Me.DataGridViewTextBoxHORARIO.HeaderText = "Horario"
        Me.DataGridViewTextBoxHORARIO.Name = "DataGridViewTextBoxHORARIO"
        '
        'DataGridViewTextBoxCODIGO
        '
        Me.DataGridViewTextBoxCODIGO.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxCODIGO.HeaderText = "Codigo"
        Me.DataGridViewTextBoxCODIGO.Name = "DataGridViewTextBoxCODIGO"
        '
        'DataGridViewTextBoxCOORDINADOR_CFP
        '
        Me.DataGridViewTextBoxCOORDINADOR_CFP.DataPropertyName = "COORDINADOR_CFP"
        Me.DataGridViewTextBoxCOORDINADOR_CFP.HeaderText = "Coordinador cfp"
        Me.DataGridViewTextBoxCOORDINADOR_CFP.Name = "DataGridViewTextBoxCOORDINADOR_CFP"
        '
        'DataGridViewTextBoxDIRECTOR_CFP
        '
        Me.DataGridViewTextBoxDIRECTOR_CFP.DataPropertyName = "DIRECTOR_CFP"
        Me.DataGridViewTextBoxDIRECTOR_CFP.HeaderText = "Director cfp"
        Me.DataGridViewTextBoxDIRECTOR_CFP.Name = "DataGridViewTextBoxDIRECTOR_CFP"
        '
        'DataGridViewTextBoxPARTICIPANTES_PRESENTES
        '
        Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES.DataPropertyName = "PARTICIPANTES_PRESENTES"
        Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES.HeaderText = "Participantes presentes"
        Me.DataGridViewTextBoxPARTICIPANTES_PRESENTES.Name = "DataGridViewTextBoxPARTICIPANTES_PRESENTES"
        '
        'DataGridViewTextBoxPARTICIPANTES_AUSENTES
        '
        Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES.DataPropertyName = "PARTICIPANTES_AUSENTES"
        Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES.HeaderText = "Participantes ausentes"
        Me.DataGridViewTextBoxPARTICIPANTES_AUSENTES.Name = "DataGridViewTextBoxPARTICIPANTES_AUSENTES"
        '
        'DataGridViewTextBoxPARTICIPANTES_INSCRITOS
        '
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.DataPropertyName = "PARTICIPANTES_INSCRITOS"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.HeaderText = "Participantes inscritos"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Name = "DataGridViewTextBoxPARTICIPANTES_INSCRITOS"
        '
        'DataGridViewTextBoxPARTICIPANTES_DESERTADOS
        '
        Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS.DataPropertyName = "PARTICIPANTES_DESERTADOS"
        Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS.HeaderText = "Participantes desertados"
        Me.DataGridViewTextBoxPARTICIPANTES_DESERTADOS.Name = "DataGridViewTextBoxPARTICIPANTES_DESERTADOS"
        '
        'DataGridViewTextBoxPARTICIPANTES_SUPLENTES
        '
        Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES.DataPropertyName = "PARTICIPANTES_SUPLENTES"
        Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES.HeaderText = "Participantes suplentes"
        Me.DataGridViewTextBoxPARTICIPANTES_SUPLENTES.Name = "DataGridViewTextBoxPARTICIPANTES_SUPLENTES"
        '
        'DataGridViewTextBoxOBJETIVO_VISITA
        '
        Me.DataGridViewTextBoxOBJETIVO_VISITA.DataPropertyName = "OBJETIVO_VISITA"
        Me.DataGridViewTextBoxOBJETIVO_VISITA.HeaderText = "Objetivo visita"
        Me.DataGridViewTextBoxOBJETIVO_VISITA.Name = "DataGridViewTextBoxOBJETIVO_VISITA"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxDURACION_VISITA
        '
        Me.DataGridViewTextBoxDURACION_VISITA.DataPropertyName = "DURACION_VISITA"
        Me.DataGridViewTextBoxDURACION_VISITA.HeaderText = "Duracion visita"
        Me.DataGridViewTextBoxDURACION_VISITA.Name = "DataGridViewTextBoxDURACION_VISITA"
        '
        'ucListaSUPERVISION_AF
        '
        Me.Controls.Add(Me.ListaSUPERVISION_AFDataGridView)
        Me.Name = "ucListaSUPERVISION_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSUPERVISION_AFDataGridView, 0)
        CType(Me.ListaSUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSUPERVISION_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSUPERVISION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSUPERVISION_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_SUPERVISION_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_MODALIDAD_FORMACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCENTRO_FORMACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxGRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxHORARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCOORDINADOR_CFP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECTOR_CFP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_PRESENTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_AUSENTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_INSCRITOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_DESERTADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_SUPLENTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOBJETIVO_VISITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION_VISITA As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
