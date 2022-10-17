<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSITIO_CAPACITACION
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
        Me.ListaSITIO_CAPACITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSITIO_CAPACITACIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_SITIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUMERO_AULAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_REGISTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxENCARGADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO_ENCARGADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL_ENCARGADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCARGO_ENCARGADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaSITIO_CAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSITIO_CAPACITACIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSITIO_CAPACITACIONBindingSource
        '
        Me.ListaSITIO_CAPACITACIONBindingSource.DataSource = GetType(SGAFP.EL.SITIO_CAPACITACION)
        '
        'ListaSITIO_CAPACITACIONDataGridView
        '
        Me.ListaSITIO_CAPACITACIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSITIO_CAPACITACIONDataGridView.AutoGenerateColumns = False
        Me.ListaSITIO_CAPACITACIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_SITIO_CAPACITACION, Me.DataGridViewTextBoxCODIGO_MUNICIPIO, Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxNOMBRE_SITIO, Me.DataGridViewTextBoxDIRECCION, Me.DataGridViewTextBoxTELEFONO, Me.DataGridViewTextBoxFAX, Me.DataGridViewTextBoxEMAIL, Me.DataGridViewTextBoxNUMERO_AULAS, Me.DataGridViewTextBoxFECHA_REGISTRO, Me.DataGridViewTextBoxENCARGADO, Me.DataGridViewTextBoxTELEFONO_ENCARGADO, Me.DataGridViewTextBoxEMAIL_ENCARGADO, Me.DataGridViewTextBoxCARGO_ENCARGADO, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaSITIO_CAPACITACIONDataGridView.DataSource = Me.ListaSITIO_CAPACITACIONBindingSource
        Me.ListaSITIO_CAPACITACIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaSITIO_CAPACITACIONDataGridView.Name = "ListaSITIO_CAPACITACIONDataGridView"
        Me.ListaSITIO_CAPACITACIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaSITIO_CAPACITACIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_SITIO_CAPACITACION
        '
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.DataPropertyName = "ID_SITIO_CAPACITACION"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.HeaderText = "Id sitio capacitacion"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Name = "DataGridViewTextBoxID_SITIO_CAPACITACION"
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
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'DataGridViewTextBoxNOMBRE_SITIO
        '
        Me.DataGridViewTextBoxNOMBRE_SITIO.DataPropertyName = "NOMBRE_SITIO"
        Me.DataGridViewTextBoxNOMBRE_SITIO.HeaderText = "Nombre sitio"
        Me.DataGridViewTextBoxNOMBRE_SITIO.Name = "DataGridViewTextBoxNOMBRE_SITIO"
        '
        'DataGridViewTextBoxDIRECCION
        '
        Me.DataGridViewTextBoxDIRECCION.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxDIRECCION.HeaderText = "Direccion"
        Me.DataGridViewTextBoxDIRECCION.Name = "DataGridViewTextBoxDIRECCION"
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
        'DataGridViewTextBoxEMAIL
        '
        Me.DataGridViewTextBoxEMAIL.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxEMAIL.HeaderText = "Email"
        Me.DataGridViewTextBoxEMAIL.Name = "DataGridViewTextBoxEMAIL"
        '
        'DataGridViewTextBoxNUMERO_AULAS
        '
        Me.DataGridViewTextBoxNUMERO_AULAS.DataPropertyName = "NUMERO_AULAS"
        Me.DataGridViewTextBoxNUMERO_AULAS.HeaderText = "Numero aulas"
        Me.DataGridViewTextBoxNUMERO_AULAS.Name = "DataGridViewTextBoxNUMERO_AULAS"
        '
        'DataGridViewTextBoxFECHA_REGISTRO
        '
        Me.DataGridViewTextBoxFECHA_REGISTRO.DataPropertyName = "FECHA_REGISTRO"
        Me.DataGridViewTextBoxFECHA_REGISTRO.HeaderText = "Fecha registro"
        Me.DataGridViewTextBoxFECHA_REGISTRO.Name = "DataGridViewTextBoxFECHA_REGISTRO"
        '
        'DataGridViewTextBoxENCARGADO
        '
        Me.DataGridViewTextBoxENCARGADO.DataPropertyName = "ENCARGADO"
        Me.DataGridViewTextBoxENCARGADO.HeaderText = "Encargado"
        Me.DataGridViewTextBoxENCARGADO.Name = "DataGridViewTextBoxENCARGADO"
        '
        'DataGridViewTextBoxTELEFONO_ENCARGADO
        '
        Me.DataGridViewTextBoxTELEFONO_ENCARGADO.DataPropertyName = "TELEFONO_ENCARGADO"
        Me.DataGridViewTextBoxTELEFONO_ENCARGADO.HeaderText = "Telefono encargado"
        Me.DataGridViewTextBoxTELEFONO_ENCARGADO.Name = "DataGridViewTextBoxTELEFONO_ENCARGADO"
        '
        'DataGridViewTextBoxEMAIL_ENCARGADO
        '
        Me.DataGridViewTextBoxEMAIL_ENCARGADO.DataPropertyName = "EMAIL_ENCARGADO"
        Me.DataGridViewTextBoxEMAIL_ENCARGADO.HeaderText = "Email encargado"
        Me.DataGridViewTextBoxEMAIL_ENCARGADO.Name = "DataGridViewTextBoxEMAIL_ENCARGADO"
        '
        'DataGridViewTextBoxCARGO_ENCARGADO
        '
        Me.DataGridViewTextBoxCARGO_ENCARGADO.DataPropertyName = "CARGO_ENCARGADO"
        Me.DataGridViewTextBoxCARGO_ENCARGADO.HeaderText = "Cargo encargado"
        Me.DataGridViewTextBoxCARGO_ENCARGADO.Name = "DataGridViewTextBoxCARGO_ENCARGADO"
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
        'ucListaSITIO_CAPACITACION
        '
        Me.Controls.Add(Me.ListaSITIO_CAPACITACIONDataGridView)
        Me.Name = "ucListaSITIO_CAPACITACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSITIO_CAPACITACIONDataGridView, 0)
        CType(Me.ListaSITIO_CAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSITIO_CAPACITACIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSITIO_CAPACITACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSITIO_CAPACITACIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_SITIO_CAPACITACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_SITIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUMERO_AULAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_REGISTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxENCARGADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO_ENCARGADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL_ENCARGADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCARGO_ENCARGADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
