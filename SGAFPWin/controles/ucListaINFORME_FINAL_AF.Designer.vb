<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaINFORME_FINAL_AF
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
        Me.ListaINFORME_FINAL_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaINFORME_FINAL_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_INFORME_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INFORME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUMERO_FACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxELABORADO_POR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_FACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_APROBADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_FINALES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTA_PROMEDIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCOMENTARIOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSUARIO_APROBACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaINFORME_FINAL_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaINFORME_FINAL_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaINFORME_FINAL_AFBindingSource
        '
        Me.ListaINFORME_FINAL_AFBindingSource.DataSource = GetType(SGAFP.EL.INFORME_FINAL_AF)
        '
        'ListaINFORME_FINAL_AFDataGridView
        '
        Me.ListaINFORME_FINAL_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaINFORME_FINAL_AFDataGridView.AutoGenerateColumns = False
        Me.ListaINFORME_FINAL_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_INFORME_FINAL, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxFECHA_INFORME, Me.DataGridViewTextBoxNUMERO_FACTURA, Me.DataGridViewTextBoxELABORADO_POR, Me.DataGridViewTextBoxMONTO_FACTURA, Me.DataGridViewTextBoxMONTO_APROBADO, Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS, Me.DataGridViewTextBoxPARTICIPANTES_FINALES, Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA, Me.DataGridViewTextBoxNOTA_PROMEDIO, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxCOMENTARIOS, Me.DataGridViewTextBoxUSUARIO_APROBACION, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUDATE})
        Me.ListaINFORME_FINAL_AFDataGridView.DataSource = Me.ListaINFORME_FINAL_AFBindingSource
        Me.ListaINFORME_FINAL_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaINFORME_FINAL_AFDataGridView.Name = "ListaINFORME_FINAL_AFDataGridView"
        Me.ListaINFORME_FINAL_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaINFORME_FINAL_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_INFORME_FINAL
        '
        Me.DataGridViewTextBoxID_INFORME_FINAL.DataPropertyName = "ID_INFORME_FINAL"
        Me.DataGridViewTextBoxID_INFORME_FINAL.HeaderText = "Id informe final"
        Me.DataGridViewTextBoxID_INFORME_FINAL.Name = "DataGridViewTextBoxID_INFORME_FINAL"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'DataGridViewTextBoxFECHA_INFORME
        '
        Me.DataGridViewTextBoxFECHA_INFORME.DataPropertyName = "FECHA_INFORME"
        Me.DataGridViewTextBoxFECHA_INFORME.HeaderText = "Fecha informe"
        Me.DataGridViewTextBoxFECHA_INFORME.Name = "DataGridViewTextBoxFECHA_INFORME"
        '
        'DataGridViewTextBoxNUMERO_FACTURA
        '
        Me.DataGridViewTextBoxNUMERO_FACTURA.DataPropertyName = "NUMERO_FACTURA"
        Me.DataGridViewTextBoxNUMERO_FACTURA.HeaderText = "Numero factura"
        Me.DataGridViewTextBoxNUMERO_FACTURA.Name = "DataGridViewTextBoxNUMERO_FACTURA"
        '
        'DataGridViewTextBoxELABORADO_POR
        '
        Me.DataGridViewTextBoxELABORADO_POR.DataPropertyName = "ELABORADO_POR"
        Me.DataGridViewTextBoxELABORADO_POR.HeaderText = "Elaborado por"
        Me.DataGridViewTextBoxELABORADO_POR.Name = "DataGridViewTextBoxELABORADO_POR"
        '
        'DataGridViewTextBoxMONTO_FACTURA
        '
        Me.DataGridViewTextBoxMONTO_FACTURA.DataPropertyName = "MONTO_FACTURA"
        Me.DataGridViewTextBoxMONTO_FACTURA.HeaderText = "Monto factura"
        Me.DataGridViewTextBoxMONTO_FACTURA.Name = "DataGridViewTextBoxMONTO_FACTURA"
        '
        'DataGridViewTextBoxMONTO_APROBADO
        '
        Me.DataGridViewTextBoxMONTO_APROBADO.DataPropertyName = "MONTO_APROBADO"
        Me.DataGridViewTextBoxMONTO_APROBADO.HeaderText = "Monto aprobado"
        Me.DataGridViewTextBoxMONTO_APROBADO.Name = "DataGridViewTextBoxMONTO_APROBADO"
        '
        'DataGridViewTextBoxPARTICIPANTES_INSCRITOS
        '
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.DataPropertyName = "PARTICIPANTES_INSCRITOS"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.HeaderText = "Participantes inscritos"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Name = "DataGridViewTextBoxPARTICIPANTES_INSCRITOS"
        '
        'DataGridViewTextBoxPARTICIPANTES_FINALES
        '
        Me.DataGridViewTextBoxPARTICIPANTES_FINALES.DataPropertyName = "PARTICIPANTES_FINALES"
        Me.DataGridViewTextBoxPARTICIPANTES_FINALES.HeaderText = "Participantes finales"
        Me.DataGridViewTextBoxPARTICIPANTES_FINALES.Name = "DataGridViewTextBoxPARTICIPANTES_FINALES"
        '
        'DataGridViewTextBoxPORC_PROM_ASISTENCIA
        '
        Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA.DataPropertyName = "PORC_PROM_ASISTENCIA"
        Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA.HeaderText = "Porc prom asistencia"
        Me.DataGridViewTextBoxPORC_PROM_ASISTENCIA.Name = "DataGridViewTextBoxPORC_PROM_ASISTENCIA"
        '
        'DataGridViewTextBoxNOTA_PROMEDIO
        '
        Me.DataGridViewTextBoxNOTA_PROMEDIO.DataPropertyName = "NOTA_PROMEDIO"
        Me.DataGridViewTextBoxNOTA_PROMEDIO.HeaderText = "Nota promedio"
        Me.DataGridViewTextBoxNOTA_PROMEDIO.Name = "DataGridViewTextBoxNOTA_PROMEDIO"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
        '
        'DataGridViewTextBoxCOMENTARIOS
        '
        Me.DataGridViewTextBoxCOMENTARIOS.DataPropertyName = "COMENTARIOS"
        Me.DataGridViewTextBoxCOMENTARIOS.HeaderText = "Comentarios"
        Me.DataGridViewTextBoxCOMENTARIOS.Name = "DataGridViewTextBoxCOMENTARIOS"
        '
        'DataGridViewTextBoxUSUARIO_APROBACION
        '
        Me.DataGridViewTextBoxUSUARIO_APROBACION.DataPropertyName = "USUARIO_APROBACION"
        Me.DataGridViewTextBoxUSUARIO_APROBACION.HeaderText = "Usuario aprobacion"
        Me.DataGridViewTextBoxUSUARIO_APROBACION.Name = "DataGridViewTextBoxUSUARIO_APROBACION"
        '
        'DataGridViewTextBoxUSERID
        '
        Me.DataGridViewTextBoxUSERID.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxUSERID.HeaderText = "Userid"
        Me.DataGridViewTextBoxUSERID.Name = "DataGridViewTextBoxUSERID"
        '
        'DataGridViewTextBoxLASTUDATE
        '
        Me.DataGridViewTextBoxLASTUDATE.DataPropertyName = "LASTUDATE"
        Me.DataGridViewTextBoxLASTUDATE.HeaderText = "Lastudate"
        Me.DataGridViewTextBoxLASTUDATE.Name = "DataGridViewTextBoxLASTUDATE"
        '
        'ucListaINFORME_FINAL_AF
        '
        Me.Controls.Add(Me.ListaINFORME_FINAL_AFDataGridView)
        Me.Name = "ucListaINFORME_FINAL_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaINFORME_FINAL_AFDataGridView, 0)
        CType(Me.ListaINFORME_FINAL_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaINFORME_FINAL_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaINFORME_FINAL_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaINFORME_FINAL_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_INFORME_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INFORME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUMERO_FACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxELABORADO_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_FACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_APROBADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_INSCRITOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_FINALES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPORC_PROM_ASISTENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTA_PROMEDIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCOMENTARIOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSUARIO_APROBACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
