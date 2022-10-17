<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaFACILITADOR_CAPACITADOR
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
        Me.ListaFACILITADOR_CAPACITADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaFACILITADOR_CAPACITADORDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_FACILITADOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_TIPO_PERSONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_FACILITADOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDUI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxISSS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaFACILITADOR_CAPACITADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaFACILITADOR_CAPACITADORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaFACILITADOR_CAPACITADORBindingSource
        '
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = GetType(SGAFP.EL.FACILITADOR_CAPACITADOR)
        '
        'ListaFACILITADOR_CAPACITADORDataGridView
        '
        Me.ListaFACILITADOR_CAPACITADORDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaFACILITADOR_CAPACITADORDataGridView.AutoGenerateColumns = False
        Me.ListaFACILITADOR_CAPACITADORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_FACILITADOR, Me.DataGridViewTextBoxID_TIPO_PERSONA, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxCODIGO_MUNICIPIO, Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO, Me.DataGridViewTextBoxNOMBRE_FACILITADOR, Me.DataGridViewTextBoxNIT, Me.DataGridViewTextBoxDUI, Me.DataGridViewTextBoxISSS, Me.DataGridViewTextBoxFECHA_INGRESO, Me.DataGridViewTextBoxTELEFONO, Me.DataGridViewTextBoxEMAIL, Me.DataGridViewTextBoxDIRECCION, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaFACILITADOR_CAPACITADORDataGridView.DataSource = Me.ListaFACILITADOR_CAPACITADORBindingSource
        Me.ListaFACILITADOR_CAPACITADORDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaFACILITADOR_CAPACITADORDataGridView.Name = "ListaFACILITADOR_CAPACITADORDataGridView"
        Me.ListaFACILITADOR_CAPACITADORDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaFACILITADOR_CAPACITADORDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_FACILITADOR
        '
        Me.DataGridViewTextBoxID_FACILITADOR.DataPropertyName = "ID_FACILITADOR"
        Me.DataGridViewTextBoxID_FACILITADOR.HeaderText = "Id facilitador"
        Me.DataGridViewTextBoxID_FACILITADOR.Name = "DataGridViewTextBoxID_FACILITADOR"
        '
        'DataGridViewTextBoxID_TIPO_PERSONA
        '
        Me.DataGridViewTextBoxID_TIPO_PERSONA.DataPropertyName = "ID_TIPO_PERSONA"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.HeaderText = "Id tipo persona"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.Name = "DataGridViewTextBoxID_TIPO_PERSONA"
        '
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'DataGridViewTextBoxCODIGO_MUNICIPIO
        '
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.DataPropertyName = "CODIGO_MUNICIPIO"
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.HeaderText = "Codigo municipio"
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.Name = "DataGridViewTextBoxCODIGO_MUNICIPIO"
        '
        'DataGridViewTextBoxCODIGO_REGION
        '
        Me.DataGridViewTextBoxCODIGO_REGION.DataPropertyName = "CODIGO_REGION"
        Me.DataGridViewTextBoxCODIGO_REGION.HeaderText = "Codigo region"
        Me.DataGridViewTextBoxCODIGO_REGION.Name = "DataGridViewTextBoxCODIGO_REGION"
        '
        'DataGridViewTextBoxCODIGO_DEPARTAMENTO
        '
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.DataPropertyName = "CODIGO_DEPARTAMENTO"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.HeaderText = "Codigo departamento"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Name = "DataGridViewTextBoxCODIGO_DEPARTAMENTO"
        '
        'DataGridViewTextBoxNOMBRE_FACILITADOR
        '
        Me.DataGridViewTextBoxNOMBRE_FACILITADOR.DataPropertyName = "NOMBRE_FACILITADOR"
        Me.DataGridViewTextBoxNOMBRE_FACILITADOR.HeaderText = "Nombre facilitador"
        Me.DataGridViewTextBoxNOMBRE_FACILITADOR.Name = "DataGridViewTextBoxNOMBRE_FACILITADOR"
        '
        'DataGridViewTextBoxNIT
        '
        Me.DataGridViewTextBoxNIT.DataPropertyName = "NIT"
        Me.DataGridViewTextBoxNIT.HeaderText = "Nit"
        Me.DataGridViewTextBoxNIT.Name = "DataGridViewTextBoxNIT"
        '
        'DataGridViewTextBoxDUI
        '
        Me.DataGridViewTextBoxDUI.DataPropertyName = "DUI"
        Me.DataGridViewTextBoxDUI.HeaderText = "Dui"
        Me.DataGridViewTextBoxDUI.Name = "DataGridViewTextBoxDUI"
        '
        'DataGridViewTextBoxISSS
        '
        Me.DataGridViewTextBoxISSS.DataPropertyName = "ISSS"
        Me.DataGridViewTextBoxISSS.HeaderText = "Isss"
        Me.DataGridViewTextBoxISSS.Name = "DataGridViewTextBoxISSS"
        '
        'DataGridViewTextBoxFECHA_INGRESO
        '
        Me.DataGridViewTextBoxFECHA_INGRESO.DataPropertyName = "FECHA_INGRESO"
        Me.DataGridViewTextBoxFECHA_INGRESO.HeaderText = "Fecha ingreso"
        Me.DataGridViewTextBoxFECHA_INGRESO.Name = "DataGridViewTextBoxFECHA_INGRESO"
        '
        'DataGridViewTextBoxTELEFONO
        '
        Me.DataGridViewTextBoxTELEFONO.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxTELEFONO.HeaderText = "Telefono"
        Me.DataGridViewTextBoxTELEFONO.Name = "DataGridViewTextBoxTELEFONO"
        '
        'DataGridViewTextBoxEMAIL
        '
        Me.DataGridViewTextBoxEMAIL.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxEMAIL.HeaderText = "Email"
        Me.DataGridViewTextBoxEMAIL.Name = "DataGridViewTextBoxEMAIL"
        '
        'DataGridViewTextBoxDIRECCION
        '
        Me.DataGridViewTextBoxDIRECCION.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxDIRECCION.HeaderText = "Direccion"
        Me.DataGridViewTextBoxDIRECCION.Name = "DataGridViewTextBoxDIRECCION"
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
        'ucListaFACILITADOR_CAPACITADOR
        '
        Me.Controls.Add(Me.ListaFACILITADOR_CAPACITADORDataGridView)
        Me.Name = "ucListaFACILITADOR_CAPACITADOR"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaFACILITADOR_CAPACITADORDataGridView, 0)
        CType(Me.ListaFACILITADOR_CAPACITADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaFACILITADOR_CAPACITADORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaFACILITADOR_CAPACITADORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaFACILITADOR_CAPACITADORDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_FACILITADOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_TIPO_PERSONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_FACILITADOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDUI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxISSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INGRESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
