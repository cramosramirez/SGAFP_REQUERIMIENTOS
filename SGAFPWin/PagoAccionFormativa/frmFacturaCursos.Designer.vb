<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaCursos
    Inherits frmBase

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridViewInformeFinal = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCurso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_INICIAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_FINAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDuracion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_DESARROLLADAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTICIPANTES_FINALES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_FACTURA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ListaFACTURA_AF = New DevExpress.XtraGrid.GridControl
        Me.ListaFACTURA_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridViewFactura = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_FACTURA_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreProveedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_QUEDAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_CHEQUE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTIPO_DOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_QUEDAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.dteFECHA_EMISION = New DevExpress.XtraEditors.DateEdit
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.txtNUMERO_DOCUMENTO = New DevExpress.XtraEditors.TextEdit
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.ListaFACTURA_AFACCION_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridViewInformeFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaFACTURA_AF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaFACTURA_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dteFECHA_EMISION.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFECHA_EMISION.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNUMERO_DOCUMENTO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaFACTURA_AFACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridViewInformeFinal
        '
        Me.GridViewInformeFinal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCurso, Me.colCodigoGrupo, Me.colFECHA_INICIAL, Me.colFECHA_FINAL, Me.colDuracion, Me.colHORAS_DESARROLLADAS, Me.colPARTICIPANTES_FINALES, Me.colMONTO_FACTURA})
        Me.GridViewInformeFinal.GridControl = Me.ListaFACTURA_AF
        Me.GridViewInformeFinal.Name = "GridViewInformeFinal"
        Me.GridViewInformeFinal.OptionsBehavior.Editable = False
        Me.GridViewInformeFinal.OptionsBehavior.ReadOnly = True
        Me.GridViewInformeFinal.OptionsDetail.ShowDetailTabs = False
        Me.GridViewInformeFinal.OptionsView.ShowGroupPanel = False
        '
        'colCurso
        '
        Me.colCurso.Caption = " Curso"
        Me.colCurso.FieldName = "colCurso"
        Me.colCurso.Name = "colCurso"
        Me.colCurso.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colCurso.Visible = True
        Me.colCurso.VisibleIndex = 0
        Me.colCurso.Width = 349
        '
        'colCodigoGrupo
        '
        Me.colCodigoGrupo.Caption = "Código Grupo"
        Me.colCodigoGrupo.FieldName = "colCodigoGrupo"
        Me.colCodigoGrupo.Name = "colCodigoGrupo"
        Me.colCodigoGrupo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colCodigoGrupo.Visible = True
        Me.colCodigoGrupo.VisibleIndex = 1
        Me.colCodigoGrupo.Width = 102
        '
        'colFECHA_INICIAL
        '
        Me.colFECHA_INICIAL.AppearanceCell.Options.UseTextOptions = True
        Me.colFECHA_INICIAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA_INICIAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colFECHA_INICIAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA_INICIAL.Caption = "Inicio"
        Me.colFECHA_INICIAL.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFECHA_INICIAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_INICIAL.FieldName = "FECHA_INICIAL"
        Me.colFECHA_INICIAL.Name = "colFECHA_INICIAL"
        Me.colFECHA_INICIAL.Visible = True
        Me.colFECHA_INICIAL.VisibleIndex = 2
        Me.colFECHA_INICIAL.Width = 72
        '
        'colFECHA_FINAL
        '
        Me.colFECHA_FINAL.AppearanceCell.Options.UseTextOptions = True
        Me.colFECHA_FINAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA_FINAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colFECHA_FINAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA_FINAL.Caption = "Finalización"
        Me.colFECHA_FINAL.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFECHA_FINAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_FINAL.FieldName = "FECHA_FINAL"
        Me.colFECHA_FINAL.Name = "colFECHA_FINAL"
        Me.colFECHA_FINAL.Visible = True
        Me.colFECHA_FINAL.VisibleIndex = 3
        Me.colFECHA_FINAL.Width = 83
        '
        'colDuracion
        '
        Me.colDuracion.AppearanceCell.Options.UseTextOptions = True
        Me.colDuracion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDuracion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDuracion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDuracion.Caption = " Duración"
        Me.colDuracion.FieldName = "colDuracion"
        Me.colDuracion.Name = "colDuracion"
        Me.colDuracion.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colDuracion.Visible = True
        Me.colDuracion.VisibleIndex = 4
        Me.colDuracion.Width = 73
        '
        'colHORAS_DESARROLLADAS
        '
        Me.colHORAS_DESARROLLADAS.AppearanceCell.Options.UseTextOptions = True
        Me.colHORAS_DESARROLLADAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHORAS_DESARROLLADAS.AppearanceHeader.Options.UseTextOptions = True
        Me.colHORAS_DESARROLLADAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHORAS_DESARROLLADAS.Caption = "Horas Desarrolladas"
        Me.colHORAS_DESARROLLADAS.FieldName = "HORAS_DESARROLLADAS"
        Me.colHORAS_DESARROLLADAS.Name = "colHORAS_DESARROLLADAS"
        Me.colHORAS_DESARROLLADAS.Visible = True
        Me.colHORAS_DESARROLLADAS.VisibleIndex = 5
        Me.colHORAS_DESARROLLADAS.Width = 105
        '
        'colPARTICIPANTES_FINALES
        '
        Me.colPARTICIPANTES_FINALES.AppearanceCell.Options.UseTextOptions = True
        Me.colPARTICIPANTES_FINALES.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPARTICIPANTES_FINALES.AppearanceHeader.Options.UseTextOptions = True
        Me.colPARTICIPANTES_FINALES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPARTICIPANTES_FINALES.Caption = "Activos"
        Me.colPARTICIPANTES_FINALES.FieldName = "PARTICIPANTES_FINALES"
        Me.colPARTICIPANTES_FINALES.Name = "colPARTICIPANTES_FINALES"
        Me.colPARTICIPANTES_FINALES.Visible = True
        Me.colPARTICIPANTES_FINALES.VisibleIndex = 6
        Me.colPARTICIPANTES_FINALES.Width = 63
        '
        'colMONTO_FACTURA
        '
        Me.colMONTO_FACTURA.AppearanceCell.Options.UseTextOptions = True
        Me.colMONTO_FACTURA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMONTO_FACTURA.AppearanceHeader.Options.UseTextOptions = True
        Me.colMONTO_FACTURA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMONTO_FACTURA.Caption = "Total Pago"
        Me.colMONTO_FACTURA.DisplayFormat.FormatString = "#,##0.00"
        Me.colMONTO_FACTURA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMONTO_FACTURA.FieldName = "MONTO_FACTURA"
        Me.colMONTO_FACTURA.Name = "colMONTO_FACTURA"
        Me.colMONTO_FACTURA.Visible = True
        Me.colMONTO_FACTURA.VisibleIndex = 7
        Me.colMONTO_FACTURA.Width = 171
        '
        'ListaFACTURA_AF
        '
        Me.ListaFACTURA_AF.DataSource = Me.ListaFACTURA_AFBindingSource
        Me.ListaFACTURA_AF.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridViewInformeFinal
        GridLevelNode1.RelationName = "FACTURA_AF_INFORME_FINAL_AF"
        Me.ListaFACTURA_AF.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.ListaFACTURA_AF.Location = New System.Drawing.Point(0, 0)
        Me.ListaFACTURA_AF.MainView = Me.GridViewFactura
        Me.ListaFACTURA_AF.Name = "ListaFACTURA_AF"
        Me.ListaFACTURA_AF.Size = New System.Drawing.Size(1036, 457)
        Me.ListaFACTURA_AF.TabIndex = 0
        Me.ListaFACTURA_AF.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFactura, Me.GridViewInformeFinal})
        '
        'ListaFACTURA_AFBindingSource
        '
        Me.ListaFACTURA_AFBindingSource.DataSource = GetType(SGAFP.EL.listaFACTURA_AF)
        '
        'GridViewFactura
        '
        Me.GridViewFactura.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_FACTURA_AF, Me.colID_PROVEEDOR_AF, Me.colReferencia, Me.colNombreProveedor, Me.colNUMERO_DOCUMENTO, Me.colNombreTipoDocumento, Me.colFECHA_DOCUMENTO, Me.colNombreEstado, Me.colMonto, Me.colNUMERO_QUEDAN, Me.colNUMERO_CHEQUE, Me.colTIPO_DOCUMENTO, Me.colFECHA_QUEDAN, Me.colESTADO, Me.colOBSERVACION})
        Me.GridViewFactura.GridControl = Me.ListaFACTURA_AF
        Me.GridViewFactura.Name = "GridViewFactura"
        Me.GridViewFactura.OptionsView.ShowGroupPanel = False
        '
        'colID_FACTURA_AF
        '
        Me.colID_FACTURA_AF.FieldName = "ID_FACTURA_AF"
        Me.colID_FACTURA_AF.Name = "colID_FACTURA_AF"
        '
        'colID_PROVEEDOR_AF
        '
        Me.colID_PROVEEDOR_AF.FieldName = "ID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Name = "colID_PROVEEDOR_AF"
        '
        'colReferencia
        '
        Me.colReferencia.Caption = "N° Contrato / OC"
        Me.colReferencia.FieldName = "colReferencia"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.OptionsColumn.AllowEdit = False
        Me.colReferencia.OptionsFilter.AllowAutoFilter = False
        Me.colReferencia.OptionsFilter.AllowFilter = False
        Me.colReferencia.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colReferencia.Visible = True
        Me.colReferencia.VisibleIndex = 0
        Me.colReferencia.Width = 101
        '
        'colNombreProveedor
        '
        Me.colNombreProveedor.Caption = " Proveedor"
        Me.colNombreProveedor.FieldName = "colNombreProveedor"
        Me.colNombreProveedor.Name = "colNombreProveedor"
        Me.colNombreProveedor.OptionsColumn.AllowEdit = False
        Me.colNombreProveedor.OptionsFilter.AllowAutoFilter = False
        Me.colNombreProveedor.OptionsFilter.AllowFilter = False
        Me.colNombreProveedor.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNombreProveedor.Visible = True
        Me.colNombreProveedor.VisibleIndex = 1
        Me.colNombreProveedor.Width = 200
        '
        'colNUMERO_DOCUMENTO
        '
        Me.colNUMERO_DOCUMENTO.Caption = "N° Documento"
        Me.colNUMERO_DOCUMENTO.FieldName = "NUMERO_DOCUMENTO"
        Me.colNUMERO_DOCUMENTO.Name = "colNUMERO_DOCUMENTO"
        Me.colNUMERO_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.colNUMERO_DOCUMENTO.OptionsFilter.AllowAutoFilter = False
        Me.colNUMERO_DOCUMENTO.OptionsFilter.AllowFilter = False
        Me.colNUMERO_DOCUMENTO.Visible = True
        Me.colNUMERO_DOCUMENTO.VisibleIndex = 2
        Me.colNUMERO_DOCUMENTO.Width = 88
        '
        'colNombreTipoDocumento
        '
        Me.colNombreTipoDocumento.AppearanceCell.Options.UseTextOptions = True
        Me.colNombreTipoDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreTipoDocumento.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreTipoDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreTipoDocumento.Caption = "Tipo"
        Me.colNombreTipoDocumento.FieldName = "colNombreTipoDocumento"
        Me.colNombreTipoDocumento.Name = "colNombreTipoDocumento"
        Me.colNombreTipoDocumento.OptionsColumn.AllowEdit = False
        Me.colNombreTipoDocumento.OptionsFilter.AllowAutoFilter = False
        Me.colNombreTipoDocumento.OptionsFilter.AllowFilter = False
        Me.colNombreTipoDocumento.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNombreTipoDocumento.Visible = True
        Me.colNombreTipoDocumento.VisibleIndex = 3
        Me.colNombreTipoDocumento.Width = 61
        '
        'colFECHA_DOCUMENTO
        '
        Me.colFECHA_DOCUMENTO.Caption = "Fecha Emisión"
        Me.colFECHA_DOCUMENTO.FieldName = "FECHA_DOCUMENTO"
        Me.colFECHA_DOCUMENTO.Name = "colFECHA_DOCUMENTO"
        Me.colFECHA_DOCUMENTO.OptionsColumn.AllowEdit = False
        Me.colFECHA_DOCUMENTO.OptionsFilter.AllowAutoFilter = False
        Me.colFECHA_DOCUMENTO.OptionsFilter.AllowFilter = False
        Me.colFECHA_DOCUMENTO.Visible = True
        Me.colFECHA_DOCUMENTO.VisibleIndex = 4
        Me.colFECHA_DOCUMENTO.Width = 73
        '
        'colNombreEstado
        '
        Me.colNombreEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colNombreEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreEstado.Caption = " Estado"
        Me.colNombreEstado.FieldName = "colNombreEstado"
        Me.colNombreEstado.Name = "colNombreEstado"
        Me.colNombreEstado.OptionsColumn.AllowEdit = False
        Me.colNombreEstado.OptionsFilter.AllowAutoFilter = False
        Me.colNombreEstado.OptionsFilter.AllowFilter = False
        Me.colNombreEstado.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNombreEstado.Visible = True
        Me.colNombreEstado.VisibleIndex = 5
        Me.colNombreEstado.Width = 65
        '
        'colMonto
        '
        Me.colMonto.AppearanceCell.Options.UseTextOptions = True
        Me.colMonto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMonto.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMonto.Caption = " Monto"
        Me.colMonto.DisplayFormat.FormatString = "#,##0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMonto.FieldName = "colMonto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.OptionsFilter.AllowAutoFilter = False
        Me.colMonto.OptionsFilter.AllowFilter = False
        Me.colMonto.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 6
        Me.colMonto.Width = 101
        '
        'colNUMERO_QUEDAN
        '
        Me.colNUMERO_QUEDAN.AppearanceCell.Options.UseTextOptions = True
        Me.colNUMERO_QUEDAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNUMERO_QUEDAN.Caption = "Quedan"
        Me.colNUMERO_QUEDAN.FieldName = "colNUMERO_QUEDAN"
        Me.colNUMERO_QUEDAN.Name = "colNUMERO_QUEDAN"
        Me.colNUMERO_QUEDAN.OptionsColumn.AllowEdit = False
        Me.colNUMERO_QUEDAN.OptionsFilter.AllowAutoFilter = False
        Me.colNUMERO_QUEDAN.OptionsFilter.AllowFilter = False
        Me.colNUMERO_QUEDAN.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNUMERO_QUEDAN.Visible = True
        Me.colNUMERO_QUEDAN.VisibleIndex = 7
        Me.colNUMERO_QUEDAN.Width = 65
        '
        'colNUMERO_CHEQUE
        '
        Me.colNUMERO_CHEQUE.Caption = "Cheque"
        Me.colNUMERO_CHEQUE.FieldName = "NUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.Name = "colNUMERO_CHEQUE"
        Me.colNUMERO_CHEQUE.OptionsColumn.AllowEdit = False
        Me.colNUMERO_CHEQUE.OptionsFilter.AllowAutoFilter = False
        Me.colNUMERO_CHEQUE.OptionsFilter.AllowFilter = False
        Me.colNUMERO_CHEQUE.Visible = True
        Me.colNUMERO_CHEQUE.VisibleIndex = 8
        '
        'colTIPO_DOCUMENTO
        '
        Me.colTIPO_DOCUMENTO.FieldName = "TIPO_DOCUMENTO"
        Me.colTIPO_DOCUMENTO.Name = "colTIPO_DOCUMENTO"
        '
        'colFECHA_QUEDAN
        '
        Me.colFECHA_QUEDAN.FieldName = "FECHA_QUEDAN"
        Me.colFECHA_QUEDAN.Name = "colFECHA_QUEDAN"
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.Caption = "Observación"
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.AllowEdit = False
        Me.colOBSERVACION.OptionsFilter.AllowAutoFilter = False
        Me.colOBSERVACION.OptionsFilter.AllowFilter = False
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 9
        Me.colOBSERVACION.Width = 186
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem2"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(498, 25)
        Me.LayoutControlItem4.Text = "Proveedor"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1008, 97)
        Me.LayoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1008, 120)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.CustomizationFormText = "Estado"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem5.Text = "Estado Curso"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem2"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem3.Text = "Proveedor"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem2"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem1.Text = "Proveedor"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(441, 117)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dteFECHA_EMISION)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.txtNUMERO_DOCUMENTO)
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1036, 79)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dteFECHA_EMISION
        '
        Me.dteFECHA_EMISION.EditValue = Nothing
        Me.dteFECHA_EMISION.Location = New System.Drawing.Point(864, 37)
        Me.dteFECHA_EMISION.Name = "dteFECHA_EMISION"
        Me.dteFECHA_EMISION.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFECHA_EMISION.Properties.DisplayFormat.FormatString = "dd/MM/yyy"
        Me.dteFECHA_EMISION.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteFECHA_EMISION.Properties.EditFormat.FormatString = "dd/MM/yyy"
        Me.dteFECHA_EMISION.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dteFECHA_EMISION.Properties.Mask.EditMask = "dd/MM/yyy"
        Me.dteFECHA_EMISION.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteFECHA_EMISION.Size = New System.Drawing.Size(160, 20)
        Me.dteFECHA_EMISION.StyleController = Me.LayoutControl1
        Me.dteFECHA_EMISION.TabIndex = 11
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(110, 37)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(391, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 6
        '
        'txtNUMERO_DOCUMENTO
        '
        Me.txtNUMERO_DOCUMENTO.Location = New System.Drawing.Point(603, 37)
        Me.txtNUMERO_DOCUMENTO.Name = "txtNUMERO_DOCUMENTO"
        Me.txtNUMERO_DOCUMENTO.Size = New System.Drawing.Size(159, 20)
        Me.txtNUMERO_DOCUMENTO.StyleController = Me.LayoutControl1
        Me.txtNUMERO_DOCUMENTO.TabIndex = 5
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(110, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(914, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1036, 79)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem8.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(493, 34)
        Me.LayoutControlItem8.Text = "Proveedor"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem10.CustomizationFormText = "Programa"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1016, 25)
        Me.LayoutControlItem10.Text = "Programa"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.dteFECHA_EMISION
        Me.LayoutControlItem9.CustomizationFormText = "Fecha"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(754, 25)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(262, 34)
        Me.LayoutControlItem9.Text = "Fecha"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNUMERO_DOCUMENTO
        Me.LayoutControlItem7.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(493, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(261, 34)
        Me.LayoutControlItem7.Text = "N° Factura / Recibo"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(94, 13)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListaFACTURA_AF)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1036, 541)
        Me.SplitContainerControl1.SplitterPosition = 79
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.CustomizationFormText = "Ejercicio"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem2"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(434, 25)
        Me.LayoutControlItem6.Text = "Ejercicio"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'ListaFACTURA_AFACCION_FORMATIVABindingSource
        '
        Me.ListaFACTURA_AFACCION_FORMATIVABindingSource.DataMember = "FACTURA_AF_INFORME_FINAL_AF"
        Me.ListaFACTURA_AFACCION_FORMATIVABindingSource.DataSource = Me.ListaFACTURA_AFBindingSource
        '
        'frmFacturaCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 541)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmFacturaCursos"
        Me.Text = "Factura Cursos"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.GridViewInformeFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaFACTURA_AF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaFACTURA_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dteFECHA_EMISION.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFECHA_EMISION.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNUMERO_DOCUMENTO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaFACTURA_AFACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents txtNUMERO_DOCUMENTO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ListaFACTURA_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ListaFACTURA_AFACCION_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dteFECHA_EMISION As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ListaFACTURA_AF As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewFactura As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_FACTURA_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_QUEDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_QUEDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewInformeFinal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCurso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FINAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORAS_DESARROLLADAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTICIPANTES_FINALES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_FACTURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuracion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
End Class
