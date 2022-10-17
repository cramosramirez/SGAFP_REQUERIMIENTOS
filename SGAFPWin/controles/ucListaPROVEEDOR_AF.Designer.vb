<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPROVEEDOR_AF
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
        Me.ListaPROVEEDOR_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPROVEEDOR_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_TIPO_PERSONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxRAZON_SOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDUI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxISSS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_ACREDITACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxURL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO_CONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL_CONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCARGO_CONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaPROVEEDOR_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROVEEDOR_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPROVEEDOR_AFBindingSource
        '
        Me.ListaPROVEEDOR_AFBindingSource.DataSource = GetType(SGAFP.EL.PROVEEDOR_AF)
        '
        'ListaPROVEEDOR_AFDataGridView
        '
        Me.ListaPROVEEDOR_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPROVEEDOR_AFDataGridView.AutoGenerateColumns = False
        Me.ListaPROVEEDOR_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxCODIGO_MUNICIPIO, Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO, Me.DataGridViewTextBoxID_TIPO_PERSONA, Me.DataGridViewTextBoxNOMBRE_PROVEEDOR, Me.DataGridViewTextBoxRAZON_SOCIAL, Me.DataGridViewTextBoxNIT, Me.DataGridViewTextBoxDUI, Me.DataGridViewTextBoxNRC, Me.DataGridViewTextBoxISSS, Me.DataGridViewTextBoxFECHA_INGRESO, Me.DataGridViewTextBoxFECHA_ACREDITACION, Me.DataGridViewTextBoxDIRECCION, Me.DataGridViewTextBoxEMAIL, Me.DataGridViewTextBoxTELEFONO, Me.DataGridViewTextBoxFAX, Me.DataGridViewTextBoxURL, Me.DataGridViewTextBoxCONTACTO, Me.DataGridViewTextBoxTELEFONO_CONTACTO, Me.DataGridViewTextBoxEMAIL_CONTACTO, Me.DataGridViewTextBoxCARGO_CONTACTO, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaPROVEEDOR_AFDataGridView.DataSource = Me.ListaPROVEEDOR_AFBindingSource
        Me.ListaPROVEEDOR_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaPROVEEDOR_AFDataGridView.Name = "ListaPROVEEDOR_AFDataGridView"
        Me.ListaPROVEEDOR_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaPROVEEDOR_AFDataGridView.TabIndex = 1
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
        'DataGridViewTextBoxID_TIPO_PERSONA
        '
        Me.DataGridViewTextBoxID_TIPO_PERSONA.DataPropertyName = "ID_TIPO_PERSONA"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.HeaderText = "Id tipo persona"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.Name = "DataGridViewTextBoxID_TIPO_PERSONA"
        '
        'DataGridViewTextBoxNOMBRE_PROVEEDOR
        '
        Me.DataGridViewTextBoxNOMBRE_PROVEEDOR.DataPropertyName = "NOMBRE_PROVEEDOR"
        Me.DataGridViewTextBoxNOMBRE_PROVEEDOR.HeaderText = "Nombre proveedor"
        Me.DataGridViewTextBoxNOMBRE_PROVEEDOR.Name = "DataGridViewTextBoxNOMBRE_PROVEEDOR"
        '
        'DataGridViewTextBoxRAZON_SOCIAL
        '
        Me.DataGridViewTextBoxRAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL"
        Me.DataGridViewTextBoxRAZON_SOCIAL.HeaderText = "Razon social"
        Me.DataGridViewTextBoxRAZON_SOCIAL.Name = "DataGridViewTextBoxRAZON_SOCIAL"
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
        'DataGridViewTextBoxNRC
        '
        Me.DataGridViewTextBoxNRC.DataPropertyName = "NRC"
        Me.DataGridViewTextBoxNRC.HeaderText = "Nrc"
        Me.DataGridViewTextBoxNRC.Name = "DataGridViewTextBoxNRC"
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
        'DataGridViewTextBoxFECHA_ACREDITACION
        '
        Me.DataGridViewTextBoxFECHA_ACREDITACION.DataPropertyName = "FECHA_ACREDITACION"
        Me.DataGridViewTextBoxFECHA_ACREDITACION.HeaderText = "Fecha acreditacion"
        Me.DataGridViewTextBoxFECHA_ACREDITACION.Name = "DataGridViewTextBoxFECHA_ACREDITACION"
        '
        'DataGridViewTextBoxDIRECCION
        '
        Me.DataGridViewTextBoxDIRECCION.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxDIRECCION.HeaderText = "Direccion"
        Me.DataGridViewTextBoxDIRECCION.Name = "DataGridViewTextBoxDIRECCION"
        '
        'DataGridViewTextBoxEMAIL
        '
        Me.DataGridViewTextBoxEMAIL.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxEMAIL.HeaderText = "Email"
        Me.DataGridViewTextBoxEMAIL.Name = "DataGridViewTextBoxEMAIL"
        '
        'DataGridViewTextBoxTELEFONO
        '
        Me.DataGridViewTextBoxTELEFONO.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxTELEFONO.HeaderText = "Telefono"
        Me.DataGridViewTextBoxTELEFONO.Name = "DataGridViewTextBoxTELEFONO"
        '
        'DataGridViewTextBoxFAX
        '
        Me.DataGridViewTextBoxFAX.DataPropertyName = "FAX"
        Me.DataGridViewTextBoxFAX.HeaderText = "Fax"
        Me.DataGridViewTextBoxFAX.Name = "DataGridViewTextBoxFAX"
        '
        'DataGridViewTextBoxURL
        '
        Me.DataGridViewTextBoxURL.DataPropertyName = "URL"
        Me.DataGridViewTextBoxURL.HeaderText = "Url"
        Me.DataGridViewTextBoxURL.Name = "DataGridViewTextBoxURL"
        '
        'DataGridViewTextBoxCONTACTO
        '
        Me.DataGridViewTextBoxCONTACTO.DataPropertyName = "CONTACTO"
        Me.DataGridViewTextBoxCONTACTO.HeaderText = "Contacto"
        Me.DataGridViewTextBoxCONTACTO.Name = "DataGridViewTextBoxCONTACTO"
        '
        'DataGridViewTextBoxTELEFONO_CONTACTO
        '
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.DataPropertyName = "TELEFONO_CONTACTO"
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.HeaderText = "Telefono contacto"
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.Name = "DataGridViewTextBoxTELEFONO_CONTACTO"
        '
        'DataGridViewTextBoxEMAIL_CONTACTO
        '
        Me.DataGridViewTextBoxEMAIL_CONTACTO.DataPropertyName = "EMAIL_CONTACTO"
        Me.DataGridViewTextBoxEMAIL_CONTACTO.HeaderText = "Email contacto"
        Me.DataGridViewTextBoxEMAIL_CONTACTO.Name = "DataGridViewTextBoxEMAIL_CONTACTO"
        '
        'DataGridViewTextBoxCARGO_CONTACTO
        '
        Me.DataGridViewTextBoxCARGO_CONTACTO.DataPropertyName = "CARGO_CONTACTO"
        Me.DataGridViewTextBoxCARGO_CONTACTO.HeaderText = "Cargo contacto"
        Me.DataGridViewTextBoxCARGO_CONTACTO.Name = "DataGridViewTextBoxCARGO_CONTACTO"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
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
        'ucListaPROVEEDOR_AF
        '
        Me.Controls.Add(Me.ListaPROVEEDOR_AFDataGridView)
        Me.Name = "ucListaPROVEEDOR_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPROVEEDOR_AFDataGridView, 0)
        CType(Me.ListaPROVEEDOR_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROVEEDOR_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROVEEDOR_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPROVEEDOR_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_TIPO_PERSONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxRAZON_SOCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDUI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxISSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INGRESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_ACREDITACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxURL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO_CONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL_CONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCARGO_CONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
