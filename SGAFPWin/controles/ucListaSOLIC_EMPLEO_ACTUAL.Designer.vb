<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSOLIC_EMPLEO_ACTUAL
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
        Me.ListaSOLIC_EMPLEO_ACTUALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_EMPLEO_ACTUAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxZONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxISSS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxJEFE_INMEDIATO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPUESTO_CONTRATADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPUESTO_ACTUAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIEMPO_TRABAJO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAREA_TRABAJO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAREA_OTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaSOLIC_EMPLEO_ACTUALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSOLIC_EMPLEO_ACTUALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSOLIC_EMPLEO_ACTUALBindingSource
        '
        Me.ListaSOLIC_EMPLEO_ACTUALBindingSource.DataSource = GetType(SGAFP.EL.SOLIC_EMPLEO_ACTUAL)
        '
        'ListaSOLIC_EMPLEO_ACTUALDataGridView
        '
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.AutoGenerateColumns = False
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_EMPLEO_ACTUAL, Me.DataGridViewTextBoxID_SOLICITUD, Me.DataGridViewTextBoxNOMBRE_EMPRESA, Me.DataGridViewTextBoxDIRECCION, Me.DataGridViewTextBoxZONA, Me.DataGridViewTextBoxTELEFONO, Me.DataGridViewTextBoxFAX, Me.DataGridViewTextBoxEMAIL, Me.DataGridViewTextBoxISSS, Me.DataGridViewTextBoxJEFE_INMEDIATO, Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA, Me.DataGridViewTextBoxPUESTO_CONTRATADO, Me.DataGridViewTextBoxPUESTO_ACTUAL, Me.DataGridViewTextBoxTIEMPO_TRABAJO, Me.DataGridViewTextBoxAREA_TRABAJO, Me.DataGridViewTextBoxAREA_OTRO, Me.DataGridViewTextBoxCODIGO_MUNICIPIO, Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO})
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.DataSource = Me.ListaSOLIC_EMPLEO_ACTUALBindingSource
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.Name = "ListaSOLIC_EMPLEO_ACTUALDataGridView"
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaSOLIC_EMPLEO_ACTUALDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_EMPLEO_ACTUAL
        '
        Me.DataGridViewTextBoxID_EMPLEO_ACTUAL.DataPropertyName = "ID_EMPLEO_ACTUAL"
        Me.DataGridViewTextBoxID_EMPLEO_ACTUAL.HeaderText = "Id empleo actual"
        Me.DataGridViewTextBoxID_EMPLEO_ACTUAL.Name = "DataGridViewTextBoxID_EMPLEO_ACTUAL"
        '
        'DataGridViewTextBoxID_SOLICITUD
        '
        Me.DataGridViewTextBoxID_SOLICITUD.DataPropertyName = "ID_SOLICITUD"
        Me.DataGridViewTextBoxID_SOLICITUD.HeaderText = "Id solicitud"
        Me.DataGridViewTextBoxID_SOLICITUD.Name = "DataGridViewTextBoxID_SOLICITUD"
        '
        'DataGridViewTextBoxNOMBRE_EMPRESA
        '
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.DataPropertyName = "NOMBRE_EMPRESA"
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.HeaderText = "Nombre empresa"
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.Name = "DataGridViewTextBoxNOMBRE_EMPRESA"
        '
        'DataGridViewTextBoxDIRECCION
        '
        Me.DataGridViewTextBoxDIRECCION.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxDIRECCION.HeaderText = "Direccion"
        Me.DataGridViewTextBoxDIRECCION.Name = "DataGridViewTextBoxDIRECCION"
        '
        'DataGridViewTextBoxZONA
        '
        Me.DataGridViewTextBoxZONA.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxZONA.HeaderText = "Zona"
        Me.DataGridViewTextBoxZONA.Name = "DataGridViewTextBoxZONA"
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
        'DataGridViewTextBoxISSS
        '
        Me.DataGridViewTextBoxISSS.DataPropertyName = "ISSS"
        Me.DataGridViewTextBoxISSS.HeaderText = "Isss"
        Me.DataGridViewTextBoxISSS.Name = "DataGridViewTextBoxISSS"
        '
        'DataGridViewTextBoxJEFE_INMEDIATO
        '
        Me.DataGridViewTextBoxJEFE_INMEDIATO.DataPropertyName = "JEFE_INMEDIATO"
        Me.DataGridViewTextBoxJEFE_INMEDIATO.HeaderText = "Jefe inmediato"
        Me.DataGridViewTextBoxJEFE_INMEDIATO.Name = "DataGridViewTextBoxJEFE_INMEDIATO"
        '
        'DataGridViewTextBoxACTIVIDAD_ECONOMICA
        '
        Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA.DataPropertyName = "ACTIVIDAD_ECONOMICA"
        Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA.HeaderText = "Actividad economica"
        Me.DataGridViewTextBoxACTIVIDAD_ECONOMICA.Name = "DataGridViewTextBoxACTIVIDAD_ECONOMICA"
        '
        'DataGridViewTextBoxPUESTO_CONTRATADO
        '
        Me.DataGridViewTextBoxPUESTO_CONTRATADO.DataPropertyName = "PUESTO_CONTRATADO"
        Me.DataGridViewTextBoxPUESTO_CONTRATADO.HeaderText = "Puesto contratado"
        Me.DataGridViewTextBoxPUESTO_CONTRATADO.Name = "DataGridViewTextBoxPUESTO_CONTRATADO"
        '
        'DataGridViewTextBoxPUESTO_ACTUAL
        '
        Me.DataGridViewTextBoxPUESTO_ACTUAL.DataPropertyName = "PUESTO_ACTUAL"
        Me.DataGridViewTextBoxPUESTO_ACTUAL.HeaderText = "Puesto actual"
        Me.DataGridViewTextBoxPUESTO_ACTUAL.Name = "DataGridViewTextBoxPUESTO_ACTUAL"
        '
        'DataGridViewTextBoxTIEMPO_TRABAJO
        '
        Me.DataGridViewTextBoxTIEMPO_TRABAJO.DataPropertyName = "TIEMPO_TRABAJO"
        Me.DataGridViewTextBoxTIEMPO_TRABAJO.HeaderText = "Tiempo trabajo"
        Me.DataGridViewTextBoxTIEMPO_TRABAJO.Name = "DataGridViewTextBoxTIEMPO_TRABAJO"
        '
        'DataGridViewTextBoxAREA_TRABAJO
        '
        Me.DataGridViewTextBoxAREA_TRABAJO.DataPropertyName = "AREA_TRABAJO"
        Me.DataGridViewTextBoxAREA_TRABAJO.HeaderText = "Area trabajo"
        Me.DataGridViewTextBoxAREA_TRABAJO.Name = "DataGridViewTextBoxAREA_TRABAJO"
        '
        'DataGridViewTextBoxAREA_OTRO
        '
        Me.DataGridViewTextBoxAREA_OTRO.DataPropertyName = "AREA_OTRO"
        Me.DataGridViewTextBoxAREA_OTRO.HeaderText = "Area otro"
        Me.DataGridViewTextBoxAREA_OTRO.Name = "DataGridViewTextBoxAREA_OTRO"
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
        'ucListaSOLIC_EMPLEO_ACTUAL
        '
        Me.Controls.Add(Me.ListaSOLIC_EMPLEO_ACTUALDataGridView)
        Me.Name = "ucListaSOLIC_EMPLEO_ACTUAL"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSOLIC_EMPLEO_ACTUALDataGridView, 0)
        CType(Me.ListaSOLIC_EMPLEO_ACTUALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSOLIC_EMPLEO_ACTUALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSOLIC_EMPLEO_ACTUALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSOLIC_EMPLEO_ACTUALDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_EMPLEO_ACTUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxZONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxISSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxJEFE_INMEDIATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxACTIVIDAD_ECONOMICA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPUESTO_CONTRATADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPUESTO_ACTUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIEMPO_TRABAJO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAREA_TRABAJO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAREA_OTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
