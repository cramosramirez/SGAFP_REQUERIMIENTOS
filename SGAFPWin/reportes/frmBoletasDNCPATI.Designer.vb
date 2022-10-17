<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletasDNCPATI
    Inherits SGAFP.frmBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoletasDNCPATI))
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim ManhattanBarSeriesView1 As DevExpress.XtraCharts.ManhattanBarSeriesView = New DevExpress.XtraCharts.ManhattanBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbxMunic = New DevExpress.XtraEditors.LookUpEdit()
        Me.MunicFaseMunicipioDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.cbxDepto = New DevExpress.XtraEditors.LookUpEdit()
        Me.DeptoFaseMunicipioDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDetalle = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNUME_FICH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_ENTREVISTADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMB_CASERIO_AUP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_ING_FICHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRIMER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEGUNDO_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTERCER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTERCER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES_SALVADORENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_PAIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDUI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCEDULA_IDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARNET_MINORIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASAPORTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_MUNIC_NAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_DEPTO_NAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES_JEFE_DE_HOGAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO_FAMILIAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENE_HIJOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNO_DE_HIJOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONAS_GRUPO_FAMILIAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSE_DEDICA_ALGUNA_PROFESION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROFESION_SE_DEDICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_MUNIC_RESIDENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_DEPTO_RESIDENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO_FIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO_MOVIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCORREO_ELECTRONICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAPACITADO_PERMANENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_MOVERSE_CAMINAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_USAR_BRAZOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_VER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_OIR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_HABLAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_RETRASO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_BANARSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISCAP_EXPLIQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSABE_LEER_ESCRIBIR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOLO_LEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOLO_ESCRIBE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOLO_FIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEDUCACION_BASICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBACHILLERATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTECNOLOGICA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIVERSITARIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_EDUCACION_FORMAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTITULO_OBTENIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHA_DEJADO_DE_ESTUDIAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIEMPO_DEJO_ESTUDIAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHA_RECIBIDO_CURSOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIMPARTIO_INSAFORP_CURSO_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIMPARTIO_INSAFORP_CURSO_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIMPARTIO_INSAFORP_CURSO_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANO_CURSO_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANO_CURSO_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANO_CURSO_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_LE_DIO_BENEFICIOS_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_LE_DIO_BENEFICIOS_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO_LE_DIO_BENEFICIOS_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_OBTENER_EMPLEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_CAMBIAR_EMPLEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_TRAB_CTA_PROPIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_OTROS_INGRESOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_PROMOCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORQUE_NO_RECIB_BENEFICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREALIZA_ACTIVIDAD_INGRESOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDIO_DE_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACT_INGRESOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_ACTIVIDAD_ESTUDIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_ACTIVIDAD_OFICIOS_HOGAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_ACTIVIDAD_BUSCA_TRABAJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_ACTIVIDAD_OTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_TIEMPO_COMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_NEG_FAMILIAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_MEDIO_TIEMPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_CTA_PROPIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_POR_HORAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_TEMPORAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DE_EMPLEO_OTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHA_TRABAJADO_ANTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIEMPO_QUE_NO_TRABAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_EMPRESA_ANTERIOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEDICACION_EMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_CAMBIO_TRAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_JUBILACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_RENUNCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_DESPIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_CIERRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPUESTO_EMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIEMPO_TRABAJO_EMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECIBE_INGRESOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_TRAB_ACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_AYUDA_FAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_REMESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_PENSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_TRAB_ACT_REM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAN_OBTIENE_ING_OTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINGRESO_PERSONAL_MENSUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINGRESO_PERSONAL_DIARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQUE_GUSTARIA_APRENDER_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQUE_GUSTARIA_APRENDER_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQUE_GUSTARIA_APRENDER_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOGROS_ESPERADOS_EMPLEO_FORMAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOGROS_ESPERADOS_CUENTA_PROPIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOGROS_ESPERADOS_OTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGUSTO_UBICACION_TRABAJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_AYUDAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_INDEPEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_MANT_HIJOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_MANT_PADRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_PAGAR_ESTUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEN_QUE_OCUP_DINERO_OTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRES_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARENTESCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIRECCION_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO_FIJO_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFONO_MOVIL_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMAIL_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOBSERVACIONES_SUGERENCIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOBSERVACIONES_DIGITADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNO_CONVOCATORIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_DEPTO_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_MUNIC_CONOCIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_PROYECTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_PROYECTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRVIO_CAPAC_OTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAnalisis = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldNOCONVOCATORIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESJEFEDEHOGAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.field = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRangoEdad3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMEFICH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREDEPTORESIDENCIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREMUNICRESIDENCIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREDEPTONAC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREMUNICNAC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.tabGrafico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.FichA_PATITableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.FICHA_PATITableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DeptoFaseMunicipioTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.DeptoFaseMunicipioTableAdapter()
        Me.MunicFaseMunicipioTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.MunicFaseMunicipioTableAdapter()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbxMunic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MunicFaseMunicipioDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptoFaseMunicipioDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabDetalle.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalisis.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrafico.SuspendLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1081, 534)
        Me.SplitContainerControl1.SplitterPosition = 85
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbxMunic)
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.SpinEdit1)
        Me.LayoutControl1.Controls.Add(Me.cbxDepto)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1081, 85)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbxMunic
        '
        Me.cbxMunic.Location = New System.Drawing.Point(606, 61)
        Me.cbxMunic.Name = "cbxMunic"
        Me.cbxMunic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxMunic.Properties.DataSource = Me.MunicFaseMunicipioDataTableBindingSource
        Me.cbxMunic.Properties.DisplayMember = "NOMBRE"
        Me.cbxMunic.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.cbxMunic.Size = New System.Drawing.Size(446, 20)
        Me.cbxMunic.StyleController = Me.LayoutControl1
        Me.cbxMunic.TabIndex = 14
        '
        'MunicFaseMunicipioDataTableBindingSource
        '
        Me.MunicFaseMunicipioDataTableBindingSource.DataMember = "MunicFaseMunicipio"
        Me.MunicFaseMunicipioDataTableBindingSource.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(84, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(968, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 12
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(84, 37)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(968, 20)
        Me.SpinEdit1.StyleController = Me.LayoutControl1
        Me.SpinEdit1.TabIndex = 5
        '
        'cbxDepto
        '
        Me.cbxDepto.Location = New System.Drawing.Point(84, 61)
        Me.cbxDepto.Name = "cbxDepto"
        Me.cbxDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxDepto.Properties.DataSource = Me.DeptoFaseMunicipioDataTableBindingSource
        Me.cbxDepto.Properties.DisplayMember = "NOMBRE"
        Me.cbxDepto.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.cbxDepto.Size = New System.Drawing.Size(446, 20)
        Me.cbxDepto.StyleController = Me.LayoutControl1
        Me.cbxDepto.TabIndex = 13
        '
        'DeptoFaseMunicipioDataTableBindingSource
        '
        Me.DeptoFaseMunicipioDataTableBindingSource.DataMember = "DeptoFaseMunicipio"
        Me.DeptoFaseMunicipioDataTableBindingSource.DataSource = Me.DS_DL1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1064, 93)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SpinEdit1
        Me.LayoutControlItem2.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1044, 24)
        Me.LayoutControlItem2.Text = "Convocatoria"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem3.CustomizationFormText = "Programa"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1044, 25)
        Me.LayoutControlItem3.Text = "Programa"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbxDepto
        Me.LayoutControlItem1.CustomizationFormText = "Departamento"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem1.Text = "Departamento"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbxMunic
        Me.LayoutControlItem4.CustomizationFormText = "Municipio"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(522, 49)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem4.Text = "Municipio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabDetalle
        Me.XtraTabControl1.Size = New System.Drawing.Size(1081, 444)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetalle, Me.tabAnalisis, Me.tabGrafico})
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.GridControl1)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(1075, 418)
        Me.tabDetalle.Text = "Detalle"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "FICHA_PATI"
        Me.GridControl1.DataSource = Me.DS_DL1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1075, 418)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUME_FICH, Me.colID_ENTREVISTADOR, Me.colNOMB_CASERIO_AUP, Me.colFECHA_ING_FICHA, Me.colPRIMER_NOMBRE, Me.colSEGUNDO_NOMBRE, Me.colTERCER_NOMBRE, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colTERCER_APELLIDO, Me.colES_SALVADORENO, Me.GridColumn1, Me.colPAIS, Me.colNOMBRE_PAIS, Me.colDUI, Me.colCEDULA_IDENTIDAD, Me.colCARNET_MINORIDAD, Me.colPASAPORTE, Me.colNOMBRE_MUNIC_NAC, Me.colNOMBRE_DEPTO_NAC, Me.colFECHA_NACIMIENTO, Me.colSEXO, Me.GridColumn2, Me.colEDAD, Me.colES_JEFE_DE_HOGAR, Me.GridColumn3, Me.colESTADO_FAMILIAR, Me.GridColumn4, Me.colTIENE_HIJOS, Me.GridColumn5, Me.colNO_DE_HIJOS, Me.colPERSONAS_GRUPO_FAMILIAR, Me.colSE_DEDICA_ALGUNA_PROFESION, Me.GridColumn6, Me.colPROFESION_SE_DEDICA, Me.colDIRECCION, Me.colNOMBRE_MUNIC_RESIDENCIA, Me.colNOMBRE_DEPTO_RESIDENCIA, Me.colTELEFONO_FIJO, Me.colTELEFONO_MOVIL, Me.colCORREO_ELECTRONICO, Me.colDISCAPACITADO_PERMANENTE, Me.GridColumn7, Me.colDISCAP_MOVERSE_CAMINAR, Me.GridColumn8, Me.colDISCAP_USAR_BRAZOS, Me.GridColumn9, Me.colDISCAP_VER, Me.GridColumn10, Me.colDISCAP_OIR, Me.GridColumn11, Me.colDISCAP_HABLAR, Me.GridColumn12, Me.colDISCAP_RETRASO, Me.GridColumn13, Me.colDISCAP_BANARSE, Me.GridColumn14, Me.colDISCAP_EXPLIQUE, Me.colSABE_LEER_ESCRIBIR, Me.GridColumn15, Me.colSOLO_LEE, Me.GridColumn16, Me.colSOLO_ESCRIBE, Me.GridColumn17, Me.colSOLO_FIRMA, Me.GridColumn18, Me.colEDUCACION_BASICA, Me.GridColumn19, Me.colBACHILLERATO, Me.GridColumn20, Me.colTECNOLOGICA, Me.GridColumn21, Me.colUNIVERSITARIA, Me.GridColumn22, Me.colOTRA_EDUCACION_FORMAL, Me.colTITULO_OBTENIDO, Me.colHA_DEJADO_DE_ESTUDIAR, Me.GridColumn23, Me.colTIEMPO_DEJO_ESTUDIAR, Me.GridColumn25, Me.colHA_RECIBIDO_CURSOS, Me.GridColumn24, Me.colCURSO_1, Me.colCURSO_2, Me.colCURSO_3, Me.colIMPARTIO_INSAFORP_CURSO_1, Me.GridColumn26, Me.colIMPARTIO_INSAFORP_CURSO_2, Me.GridColumn27, Me.colIMPARTIO_INSAFORP_CURSO_3, Me.GridColumn28, Me.colANO_CURSO_1, Me.colANO_CURSO_2, Me.colANO_CURSO_3, Me.colCURSO_LE_DIO_BENEFICIOS_1, Me.GridColumn29, Me.colCURSO_LE_DIO_BENEFICIOS_2, Me.GridColumn30, Me.colCURSO_LE_DIO_BENEFICIOS_3, Me.GridColumn31, Me.colSIRVIO_CAPAC_OBTENER_EMPLEO, Me.GridColumn32, Me.colSIRVIO_CAPAC_CAMBIAR_EMPLEO, Me.GridColumn33, Me.colSIRVIO_CAPAC_TRAB_CTA_PROPIA, Me.GridColumn34, Me.colSIRVIO_CAPAC_OTROS_INGRESOS, Me.GridColumn35, Me.colSIRVIO_CAPAC_PROMOCION, Me.GridColumn36, Me.colPORQUE_NO_RECIB_BENEFICIO, Me.colREALIZA_ACTIVIDAD_INGRESOS, Me.GridColumn37, Me.colMEDIO_DE_INGRESO, Me.GridColumn38, Me.colACT_INGRESOS, Me.colOTRA_ACTIVIDAD_ESTUDIA, Me.GridColumn39, Me.colOTRA_ACTIVIDAD_OFICIOS_HOGAR, Me.GridColumn40, Me.colOTRA_ACTIVIDAD_BUSCA_TRABAJO, Me.GridColumn41, Me.colOTRA_ACTIVIDAD_OTRA, Me.colTIPO_DE_EMPLEO_TIEMPO_COMP, Me.GridColumn47, Me.colTIPO_DE_EMPLEO_NEG_FAMILIAR, Me.GridColumn46, Me.colTIPO_DE_EMPLEO_MEDIO_TIEMPO, Me.GridColumn45, Me.colTIPO_DE_EMPLEO_CTA_PROPIA, Me.GridColumn44, Me.colTIPO_DE_EMPLEO_POR_HORAS, Me.GridColumn43, Me.colTIPO_DE_EMPLEO_TEMPORAL, Me.GridColumn42, Me.colTIPO_DE_EMPLEO_OTRO, Me.colHA_TRABAJADO_ANTES, Me.GridColumn48, Me.colTIEMPO_QUE_NO_TRABAJA, Me.GridColumn49, Me.colNOMBRE_EMPRESA_ANTERIOR, Me.colDEDICACION_EMPRESA, Me.colMOTIVO_SALIDA_CAMBIO_TRAB, Me.GridColumn50, Me.colMOTIVO_SALIDA_JUBILACION, Me.GridColumn51, Me.colMOTIVO_SALIDA_RENUNCIA, Me.GridColumn52, Me.colMOTIVO_SALIDA_DESPIDO, Me.GridColumn53, Me.colMOTIVO_SALIDA_CIERRE, Me.GridColumn54, Me.colMOTIVO_SALIDA_EMPRESA_OTRAS, Me.colPUESTO_EMPRESA, Me.colTIEMPO_TRABAJO_EMPRESA, Me.GridColumn55, Me.colRECIBE_INGRESOS, Me.GridColumn56, Me.colMAN_OBTIENE_ING_TRAB_ACT, Me.GridColumn57, Me.colMAN_OBTIENE_ING_AYUDA_FAM, Me.GridColumn58, Me.colMAN_OBTIENE_ING_REMESA, Me.GridColumn59, Me.colMAN_OBTIENE_ING_PENSION, Me.GridColumn60, Me.colMAN_OBTIENE_ING_TRAB_ACT_REM, Me.GridColumn61, Me.colMAN_OBTIENE_ING_OTRA, Me.colINGRESO_PERSONAL_MENSUAL, Me.colINGRESO_PERSONAL_DIARIO, Me.colQUE_GUSTARIA_APRENDER_1, Me.colQUE_GUSTARIA_APRENDER_2, Me.colQUE_GUSTARIA_APRENDER_3, Me.colLOGROS_ESPERADOS_EMPLEO_FORMAL, Me.GridColumn62, Me.colLOGROS_ESPERADOS_CUENTA_PROPIA, Me.GridColumn63, Me.colLOGROS_ESPERADOS_OTRO, Me.colGUSTO_UBICACION_TRABAJO, Me.GridColumn64, Me.colEN_QUE_OCUP_DINERO_AYUDAR, Me.GridColumn65, Me.colEN_QUE_OCUP_DINERO_INDEPEND, Me.GridColumn66, Me.colEN_QUE_OCUP_DINERO_MANT_HIJOS, Me.GridColumn67, Me.colEN_QUE_OCUP_DINERO_MANT_PADRES, Me.GridColumn68, Me.colEN_QUE_OCUP_DINERO_PAGAR_ESTUD, Me.GridColumn69, Me.colEN_QUE_OCUP_DINERO_OTRO, Me.colNOMBRES_CONOCIDO, Me.colPARENTESCO, Me.GridColumn70, Me.colDIRECCION_CONOCIDO, Me.colTELEFONO_FIJO_CONOCIDO, Me.colTELEFONO_MOVIL_CONOCIDO, Me.colEMAIL_CONOCIDO, Me.colOBSERVACIONES_SUGERENCIAS, Me.colUSERID, Me.colLASTUPDATE, Me.colID_PARTICIPANTE, Me.colOBSERVACIONES_DIGITADOR, Me.colNO_CONVOCATORIA, Me.colNOMBRE_DEPTO_CONOCIDO, Me.colNOMBRE_MUNIC_CONOCIDO, Me.colNOMBRE_PROYECTO, Me.colCODIGO_PROYECTO, Me.colSIRVIO_CAPAC_OTRO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 4
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", Nothing, "Participantes ({0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_PROYECTO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNO_CONVOCATORIA, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_DEPTO_RESIDENCIA, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_MUNIC_RESIDENCIA, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEN_QUE_OCUP_DINERO_OTRO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNUME_FICH
        '
        Me.colNUME_FICH.FieldName = "NUME_FICH"
        Me.colNUME_FICH.Name = "colNUME_FICH"
        Me.colNUME_FICH.Visible = True
        Me.colNUME_FICH.VisibleIndex = 0
        Me.colNUME_FICH.Width = 143
        '
        'colID_ENTREVISTADOR
        '
        Me.colID_ENTREVISTADOR.FieldName = "ID_ENTREVISTADOR"
        Me.colID_ENTREVISTADOR.Name = "colID_ENTREVISTADOR"
        Me.colID_ENTREVISTADOR.Visible = True
        Me.colID_ENTREVISTADOR.VisibleIndex = 1
        Me.colID_ENTREVISTADOR.Width = 135
        '
        'colNOMB_CASERIO_AUP
        '
        Me.colNOMB_CASERIO_AUP.FieldName = "NOMB_CASERIO_AUP"
        Me.colNOMB_CASERIO_AUP.Name = "colNOMB_CASERIO_AUP"
        Me.colNOMB_CASERIO_AUP.Visible = True
        Me.colNOMB_CASERIO_AUP.VisibleIndex = 2
        Me.colNOMB_CASERIO_AUP.Width = 287
        '
        'colFECHA_ING_FICHA
        '
        Me.colFECHA_ING_FICHA.Caption = "Fecha Ingreso Ficha"
        Me.colFECHA_ING_FICHA.FieldName = "FECHA_ING_FICHA"
        Me.colFECHA_ING_FICHA.Name = "colFECHA_ING_FICHA"
        Me.colFECHA_ING_FICHA.Visible = True
        Me.colFECHA_ING_FICHA.VisibleIndex = 3
        Me.colFECHA_ING_FICHA.Width = 116
        '
        'colPRIMER_NOMBRE
        '
        Me.colPRIMER_NOMBRE.FieldName = "PRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Name = "colPRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Visible = True
        Me.colPRIMER_NOMBRE.VisibleIndex = 4
        Me.colPRIMER_NOMBRE.Width = 108
        '
        'colSEGUNDO_NOMBRE
        '
        Me.colSEGUNDO_NOMBRE.FieldName = "SEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.Name = "colSEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.Visible = True
        Me.colSEGUNDO_NOMBRE.VisibleIndex = 5
        Me.colSEGUNDO_NOMBRE.Width = 118
        '
        'colTERCER_NOMBRE
        '
        Me.colTERCER_NOMBRE.FieldName = "TERCER_NOMBRE"
        Me.colTERCER_NOMBRE.Name = "colTERCER_NOMBRE"
        Me.colTERCER_NOMBRE.Visible = True
        Me.colTERCER_NOMBRE.VisibleIndex = 6
        Me.colTERCER_NOMBRE.Width = 109
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 7
        Me.colPRIMER_APELLIDO.Width = 114
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 8
        Me.colSEGUNDO_APELLIDO.Width = 124
        '
        'colTERCER_APELLIDO
        '
        Me.colTERCER_APELLIDO.FieldName = "TERCER_APELLIDO"
        Me.colTERCER_APELLIDO.Name = "colTERCER_APELLIDO"
        Me.colTERCER_APELLIDO.Visible = True
        Me.colTERCER_APELLIDO.VisibleIndex = 9
        Me.colTERCER_APELLIDO.Width = 115
        '
        'colES_SALVADORENO
        '
        Me.colES_SALVADORENO.FieldName = "ES_SALVADORENO"
        Me.colES_SALVADORENO.Name = "colES_SALVADORENO"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "NACIONALIDAD"
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundExpression = "Iif([ES_SALVADORENO]=1,'SALVADOREÑA'  ,'EXTRANJERA' )"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        Me.GridColumn1.Width = 96
        '
        'colPAIS
        '
        Me.colPAIS.FieldName = "PAIS"
        Me.colPAIS.Name = "colPAIS"
        Me.colPAIS.Width = 42
        '
        'colNOMBRE_PAIS
        '
        Me.colNOMBRE_PAIS.FieldName = "NOMBRE_PAIS"
        Me.colNOMBRE_PAIS.Name = "colNOMBRE_PAIS"
        Me.colNOMBRE_PAIS.Visible = True
        Me.colNOMBRE_PAIS.VisibleIndex = 11
        Me.colNOMBRE_PAIS.Width = 90
        '
        'colDUI
        '
        Me.colDUI.FieldName = "DUI"
        Me.colDUI.Name = "colDUI"
        Me.colDUI.Visible = True
        Me.colDUI.VisibleIndex = 12
        Me.colDUI.Width = 94
        '
        'colCEDULA_IDENTIDAD
        '
        Me.colCEDULA_IDENTIDAD.FieldName = "CEDULA_IDENTIDAD"
        Me.colCEDULA_IDENTIDAD.Name = "colCEDULA_IDENTIDAD"
        Me.colCEDULA_IDENTIDAD.Visible = True
        Me.colCEDULA_IDENTIDAD.VisibleIndex = 13
        Me.colCEDULA_IDENTIDAD.Width = 122
        '
        'colCARNET_MINORIDAD
        '
        Me.colCARNET_MINORIDAD.FieldName = "CARNET_MINORIDAD"
        Me.colCARNET_MINORIDAD.Name = "colCARNET_MINORIDAD"
        Me.colCARNET_MINORIDAD.Visible = True
        Me.colCARNET_MINORIDAD.VisibleIndex = 14
        Me.colCARNET_MINORIDAD.Width = 127
        '
        'colPASAPORTE
        '
        Me.colPASAPORTE.FieldName = "PASAPORTE"
        Me.colPASAPORTE.Name = "colPASAPORTE"
        Me.colPASAPORTE.Visible = True
        Me.colPASAPORTE.VisibleIndex = 15
        Me.colPASAPORTE.Width = 81
        '
        'colNOMBRE_MUNIC_NAC
        '
        Me.colNOMBRE_MUNIC_NAC.FieldName = "NOMBRE_MUNIC_NAC"
        Me.colNOMBRE_MUNIC_NAC.Name = "colNOMBRE_MUNIC_NAC"
        Me.colNOMBRE_MUNIC_NAC.Visible = True
        Me.colNOMBRE_MUNIC_NAC.VisibleIndex = 16
        Me.colNOMBRE_MUNIC_NAC.Width = 161
        '
        'colNOMBRE_DEPTO_NAC
        '
        Me.colNOMBRE_DEPTO_NAC.FieldName = "NOMBRE_DEPTO_NAC"
        Me.colNOMBRE_DEPTO_NAC.Name = "colNOMBRE_DEPTO_NAC"
        Me.colNOMBRE_DEPTO_NAC.Visible = True
        Me.colNOMBRE_DEPTO_NAC.VisibleIndex = 17
        Me.colNOMBRE_DEPTO_NAC.Width = 150
        '
        'colFECHA_NACIMIENTO
        '
        Me.colFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.Name = "colFECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.Visible = True
        Me.colFECHA_NACIMIENTO.VisibleIndex = 18
        Me.colFECHA_NACIMIENTO.Width = 125
        '
        'colSEXO
        '
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "SEXO"
        Me.GridColumn2.FieldName = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundExpression = "Iif([SEXO]=1,'MASCULINO'  ,'FEMENINO' )"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 19
        '
        'colEDAD
        '
        Me.colEDAD.FieldName = "EDAD"
        Me.colEDAD.Name = "colEDAD"
        Me.colEDAD.Visible = True
        Me.colEDAD.VisibleIndex = 20
        Me.colEDAD.Width = 49
        '
        'colES_JEFE_DE_HOGAR
        '
        Me.colES_JEFE_DE_HOGAR.FieldName = "ES_JEFE_DE_HOGAR"
        Me.colES_JEFE_DE_HOGAR.Name = "colES_JEFE_DE_HOGAR"
        Me.colES_JEFE_DE_HOGAR.Width = 124
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "JEFE DE HOGAR"
        Me.GridColumn3.FieldName = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.UnboundExpression = "Iif( [ES_JEFE_DE_HOGAR] = 1, 'SI', Iif( [ES_JEFE_DE_HOGAR] = 2,'NO' ,'COMPARTIDA'" & _
    " ) )"
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 21
        Me.GridColumn3.Width = 97
        '
        'colESTADO_FAMILIAR
        '
        Me.colESTADO_FAMILIAR.FieldName = "ESTADO_FAMILIAR"
        Me.colESTADO_FAMILIAR.Name = "colESTADO_FAMILIAR"
        Me.colESTADO_FAMILIAR.Width = 116
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Estado Familiar"
        Me.GridColumn4.FieldName = "GridColumn4"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.UnboundExpression = resources.GetString("GridColumn4.UnboundExpression")
        Me.GridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 22
        Me.GridColumn4.Width = 108
        '
        'colTIENE_HIJOS
        '
        Me.colTIENE_HIJOS.FieldName = "TIENE_HIJOS"
        Me.colTIENE_HIJOS.Name = "colTIENE_HIJOS"
        Me.colTIENE_HIJOS.Width = 87
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "TIENE HIJOS"
        Me.GridColumn5.FieldName = "GridColumn5"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.UnboundExpression = "Iif( [TIENE_HIJOS]= 1,'SI'  ,'NO' )"
        Me.GridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 23
        '
        'colNO_DE_HIJOS
        '
        Me.colNO_DE_HIJOS.FieldName = "NO_DE_HIJOS"
        Me.colNO_DE_HIJOS.Name = "colNO_DE_HIJOS"
        Me.colNO_DE_HIJOS.Visible = True
        Me.colNO_DE_HIJOS.VisibleIndex = 24
        Me.colNO_DE_HIJOS.Width = 92
        '
        'colPERSONAS_GRUPO_FAMILIAR
        '
        Me.colPERSONAS_GRUPO_FAMILIAR.FieldName = "PERSONAS_GRUPO_FAMILIAR"
        Me.colPERSONAS_GRUPO_FAMILIAR.Name = "colPERSONAS_GRUPO_FAMILIAR"
        Me.colPERSONAS_GRUPO_FAMILIAR.Visible = True
        Me.colPERSONAS_GRUPO_FAMILIAR.VisibleIndex = 25
        Me.colPERSONAS_GRUPO_FAMILIAR.Width = 170
        '
        'colSE_DEDICA_ALGUNA_PROFESION
        '
        Me.colSE_DEDICA_ALGUNA_PROFESION.FieldName = "SE_DEDICA_ALGUNA_PROFESION"
        Me.colSE_DEDICA_ALGUNA_PROFESION.Name = "colSE_DEDICA_ALGUNA_PROFESION"
        Me.colSE_DEDICA_ALGUNA_PROFESION.Width = 188
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "SE DEDICA ALGUNA PROFESION"
        Me.GridColumn6.FieldName = "GridColumn6"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.UnboundExpression = "Iif( [SE_DEDICA_ALGUNA_PROFESION]= 1,'SI'  ,'NO' )"
        Me.GridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 26
        Me.GridColumn6.Width = 176
        '
        'colPROFESION_SE_DEDICA
        '
        Me.colPROFESION_SE_DEDICA.FieldName = "PROFESION_SE_DEDICA"
        Me.colPROFESION_SE_DEDICA.Name = "colPROFESION_SE_DEDICA"
        Me.colPROFESION_SE_DEDICA.Visible = True
        Me.colPROFESION_SE_DEDICA.VisibleIndex = 27
        Me.colPROFESION_SE_DEDICA.Width = 142
        '
        'colDIRECCION
        '
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 28
        Me.colDIRECCION.Width = 476
        '
        'colNOMBRE_MUNIC_RESIDENCIA
        '
        Me.colNOMBRE_MUNIC_RESIDENCIA.Caption = "Munic. Residencia"
        Me.colNOMBRE_MUNIC_RESIDENCIA.FieldName = "NOMBRE_MUNIC_RESIDENCIA"
        Me.colNOMBRE_MUNIC_RESIDENCIA.Name = "colNOMBRE_MUNIC_RESIDENCIA"
        '
        'colNOMBRE_DEPTO_RESIDENCIA
        '
        Me.colNOMBRE_DEPTO_RESIDENCIA.Caption = "Depto. Residencia"
        Me.colNOMBRE_DEPTO_RESIDENCIA.FieldName = "NOMBRE_DEPTO_RESIDENCIA"
        Me.colNOMBRE_DEPTO_RESIDENCIA.Name = "colNOMBRE_DEPTO_RESIDENCIA"
        '
        'colTELEFONO_FIJO
        '
        Me.colTELEFONO_FIJO.FieldName = "TELEFONO_FIJO"
        Me.colTELEFONO_FIJO.Name = "colTELEFONO_FIJO"
        Me.colTELEFONO_FIJO.Visible = True
        Me.colTELEFONO_FIJO.VisibleIndex = 29
        Me.colTELEFONO_FIJO.Width = 103
        '
        'colTELEFONO_MOVIL
        '
        Me.colTELEFONO_MOVIL.FieldName = "TELEFONO_MOVIL"
        Me.colTELEFONO_MOVIL.Name = "colTELEFONO_MOVIL"
        Me.colTELEFONO_MOVIL.Visible = True
        Me.colTELEFONO_MOVIL.VisibleIndex = 30
        Me.colTELEFONO_MOVIL.Width = 111
        '
        'colCORREO_ELECTRONICO
        '
        Me.colCORREO_ELECTRONICO.FieldName = "CORREO_ELECTRONICO"
        Me.colCORREO_ELECTRONICO.Name = "colCORREO_ELECTRONICO"
        Me.colCORREO_ELECTRONICO.Visible = True
        Me.colCORREO_ELECTRONICO.VisibleIndex = 31
        Me.colCORREO_ELECTRONICO.Width = 142
        '
        'colDISCAPACITADO_PERMANENTE
        '
        Me.colDISCAPACITADO_PERMANENTE.FieldName = "DISCAPACITADO_PERMANENTE"
        Me.colDISCAPACITADO_PERMANENTE.Name = "colDISCAPACITADO_PERMANENTE"
        Me.colDISCAPACITADO_PERMANENTE.Width = 177
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "DISCAPACIDAD PERMANENTE"
        Me.GridColumn7.FieldName = "GridColumn7"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.UnboundExpression = "Iif( [DISCAPACITADO_PERMANENTE]= 1,'SI'  ,'NO' )"
        Me.GridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 32
        Me.GridColumn7.Width = 187
        '
        'colDISCAP_MOVERSE_CAMINAR
        '
        Me.colDISCAP_MOVERSE_CAMINAR.FieldName = "DISCAP_MOVERSE_CAMINAR"
        Me.colDISCAP_MOVERSE_CAMINAR.Name = "colDISCAP_MOVERSE_CAMINAR"
        Me.colDISCAP_MOVERSE_CAMINAR.Width = 165
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "MOVERSE O CAMINAR"
        Me.GridColumn8.FieldName = "GridColumn8"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.UnboundExpression = "Iif( [DISCAP_MOVERSE_CAMINAR]= 1,'SI'  ,'NO' )"
        Me.GridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 33
        Me.GridColumn8.Width = 135
        '
        'colDISCAP_USAR_BRAZOS
        '
        Me.colDISCAP_USAR_BRAZOS.FieldName = "DISCAP_USAR_BRAZOS"
        Me.colDISCAP_USAR_BRAZOS.Name = "colDISCAP_USAR_BRAZOS"
        Me.colDISCAP_USAR_BRAZOS.Width = 138
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "USAR SUS BRAZOS O MANOS"
        Me.GridColumn9.FieldName = "GridColumn9"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.UnboundExpression = "Iif( [DISCAP_USAR_BRAZOS]= 1,'SI'  ,'NO' )"
        Me.GridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 34
        Me.GridColumn9.Width = 161
        '
        'colDISCAP_VER
        '
        Me.colDISCAP_VER.FieldName = "DISCAP_VER"
        Me.colDISCAP_VER.Name = "colDISCAP_VER"
        Me.colDISCAP_VER.Width = 84
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "VER, AUN USANDO LENTES"
        Me.GridColumn10.FieldName = "GridColumn10"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.UnboundExpression = "Iif( [DISCAP_VER]= 1,'SI'  ,'NO' )"
        Me.GridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 35
        Me.GridColumn10.Width = 145
        '
        'colDISCAP_OIR
        '
        Me.colDISCAP_OIR.FieldName = "DISCAP_OIR"
        Me.colDISCAP_OIR.Name = "colDISCAP_OIR"
        Me.colDISCAP_OIR.Width = 84
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "OIR, AUN USANDO APARATOS ESPECIALES"
        Me.GridColumn11.FieldName = "GridColumn11"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.UnboundExpression = "Iif( [DISCAP_OIR]= 1,'SI'  ,'NO' )"
        Me.GridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 36
        Me.GridColumn11.Width = 230
        '
        'colDISCAP_HABLAR
        '
        Me.colDISCAP_HABLAR.FieldName = "DISCAP_HABLAR"
        Me.colDISCAP_HABLAR.Name = "colDISCAP_HABLAR"
        Me.colDISCAP_HABLAR.Width = 104
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "HABLAR"
        Me.GridColumn12.FieldName = "GridColumn12"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.UnboundExpression = "Iif( [DISCAP_HABLAR]= 1,'SI'  ,'NO' )"
        Me.GridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 37
        Me.GridColumn12.Width = 58
        '
        'colDISCAP_RETRASO
        '
        Me.colDISCAP_RETRASO.FieldName = "DISCAP_RETRASO"
        Me.colDISCAP_RETRASO.Name = "colDISCAP_RETRASO"
        Me.colDISCAP_RETRASO.Width = 112
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "TIENE ALGUN RETRASO O DEFICIENCIA MENTAL"
        Me.GridColumn13.FieldName = "GridColumn13"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.UnboundExpression = "Iif( [DISCAP_RETRASO]= 1,'SI'  ,'NO' )"
        Me.GridColumn13.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 38
        Me.GridColumn13.Width = 255
        '
        'colDISCAP_BANARSE
        '
        Me.colDISCAP_BANARSE.FieldName = "DISCAP_BANARSE"
        Me.colDISCAP_BANARSE.Name = "colDISCAP_BANARSE"
        Me.colDISCAP_BANARSE.Width = 111
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "BAÑARSE, VESTIRSE, ALIMENTARSE POR SI MISMO"
        Me.GridColumn14.FieldName = "GridColumn14"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.UnboundExpression = "Iif( [DISCAP_BANARSE]= 1,'SI'  ,'NO' )"
        Me.GridColumn14.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 39
        Me.GridColumn14.Width = 269
        '
        'colDISCAP_EXPLIQUE
        '
        Me.colDISCAP_EXPLIQUE.Caption = "DISCAP_EXPLIQUE"
        Me.colDISCAP_EXPLIQUE.FieldName = "DISCAP_EXPLIQUE"
        Me.colDISCAP_EXPLIQUE.Name = "colDISCAP_EXPLIQUE"
        Me.colDISCAP_EXPLIQUE.Visible = True
        Me.colDISCAP_EXPLIQUE.VisibleIndex = 40
        Me.colDISCAP_EXPLIQUE.Width = 113
        '
        'colSABE_LEER_ESCRIBIR
        '
        Me.colSABE_LEER_ESCRIBIR.FieldName = "SABE_LEER_ESCRIBIR"
        Me.colSABE_LEER_ESCRIBIR.Name = "colSABE_LEER_ESCRIBIR"
        Me.colSABE_LEER_ESCRIBIR.Width = 130
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "SABE LEER Y ESCRIBIR"
        Me.GridColumn15.FieldName = "GridColumn15"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.UnboundExpression = "Iif( [SABE_LEER_ESCRIBIR]= 1,'SI'  ,'NO' )"
        Me.GridColumn15.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 41
        Me.GridColumn15.Width = 130
        '
        'colSOLO_LEE
        '
        Me.colSOLO_LEE.FieldName = "SOLO_LEE"
        Me.colSOLO_LEE.Name = "colSOLO_LEE"
        Me.colSOLO_LEE.Width = 72
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "SOLO LEE"
        Me.GridColumn16.FieldName = "GridColumn16"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.UnboundExpression = "Iif( [SOLO_LEE]= 1,'SI'  , Iif( [SOLO_LEE]= 2,'NO', ''))"
        Me.GridColumn16.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 42
        '
        'colSOLO_ESCRIBE
        '
        Me.colSOLO_ESCRIBE.FieldName = "SOLO_ESCRIBE"
        Me.colSOLO_ESCRIBE.Name = "colSOLO_ESCRIBE"
        Me.colSOLO_ESCRIBE.Width = 97
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "SOLO ESCRIBE"
        Me.GridColumn17.FieldName = "GridColumn17"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.UnboundExpression = "Iif( [SOLO_FIRMA]= 1,'SI'  , Iif( [SOLO_ESCRIBE]= 2,'NO', ''))"
        Me.GridColumn17.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 43
        Me.GridColumn17.Width = 91
        '
        'colSOLO_FIRMA
        '
        Me.colSOLO_FIRMA.FieldName = "SOLO_FIRMA"
        Me.colSOLO_FIRMA.Name = "colSOLO_FIRMA"
        Me.colSOLO_FIRMA.Width = 87
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "SOLO FIRMA"
        Me.GridColumn18.FieldName = "GridColumn18"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.UnboundExpression = "Iif( [SOLO_FIRMA]= 1,'SI'  , Iif( [SOLO_FIRMA]= 2,'NO', ''))"
        Me.GridColumn18.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 44
        Me.GridColumn18.Width = 81
        '
        'colEDUCACION_BASICA
        '
        Me.colEDUCACION_BASICA.FieldName = "EDUCACION_BASICA"
        Me.colEDUCACION_BASICA.Name = "colEDUCACION_BASICA"
        Me.colEDUCACION_BASICA.Width = 125
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "EDUCACION BASICA"
        Me.GridColumn19.FieldName = "GridColumn19"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.UnboundExpression = resources.GetString("GridColumn19.UnboundExpression")
        Me.GridColumn19.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 45
        Me.GridColumn19.Width = 120
        '
        'colBACHILLERATO
        '
        Me.colBACHILLERATO.FieldName = "BACHILLERATO"
        Me.colBACHILLERATO.Name = "colBACHILLERATO"
        Me.colBACHILLERATO.Width = 97
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "BACHILLERATO"
        Me.GridColumn20.FieldName = "GridColumn20"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.UnboundExpression = "Iif( [BACHILLERATO]= 1,'INCOMPLETO'  ,'COMPLETO' )"
        Me.GridColumn20.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 46
        Me.GridColumn20.Width = 94
        '
        'colTECNOLOGICA
        '
        Me.colTECNOLOGICA.FieldName = "TECNOLOGICA"
        Me.colTECNOLOGICA.Name = "colTECNOLOGICA"
        Me.colTECNOLOGICA.Width = 94
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "TECNOLOGICA"
        Me.GridColumn21.FieldName = "GridColumn21"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.UnboundExpression = "Iif( [TECNOLOGICA]= 1,'INCOMPLETO'  ,'COMPLETO' )"
        Me.GridColumn21.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 47
        Me.GridColumn21.Width = 91
        '
        'colUNIVERSITARIA
        '
        Me.colUNIVERSITARIA.FieldName = "UNIVERSITARIA"
        Me.colUNIVERSITARIA.Name = "colUNIVERSITARIA"
        Me.colUNIVERSITARIA.Width = 100
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "UNIVERSITARIA"
        Me.GridColumn22.FieldName = "GridColumn22"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.UnboundExpression = "Iif( [UNIVERSITARIA]= 1,'INCOMPLETO'  ,'COMPLETO' )"
        Me.GridColumn22.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 48
        Me.GridColumn22.Width = 97
        '
        'colOTRA_EDUCACION_FORMAL
        '
        Me.colOTRA_EDUCACION_FORMAL.FieldName = "OTRA_EDUCACION_FORMAL"
        Me.colOTRA_EDUCACION_FORMAL.Name = "colOTRA_EDUCACION_FORMAL"
        Me.colOTRA_EDUCACION_FORMAL.Visible = True
        Me.colOTRA_EDUCACION_FORMAL.VisibleIndex = 49
        Me.colOTRA_EDUCACION_FORMAL.Width = 156
        '
        'colTITULO_OBTENIDO
        '
        Me.colTITULO_OBTENIDO.FieldName = "TITULO_OBTENIDO"
        Me.colTITULO_OBTENIDO.Name = "colTITULO_OBTENIDO"
        Me.colTITULO_OBTENIDO.Visible = True
        Me.colTITULO_OBTENIDO.VisibleIndex = 50
        Me.colTITULO_OBTENIDO.Width = 116
        '
        'colHA_DEJADO_DE_ESTUDIAR
        '
        Me.colHA_DEJADO_DE_ESTUDIAR.FieldName = "HA_DEJADO_DE_ESTUDIAR"
        Me.colHA_DEJADO_DE_ESTUDIAR.Name = "colHA_DEJADO_DE_ESTUDIAR"
        Me.colHA_DEJADO_DE_ESTUDIAR.Width = 157
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "HA DEJADO DE ESTUDIAR"
        Me.GridColumn23.FieldName = "GridColumn23"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.UnboundExpression = "Iif( [HA_DEJADO_DE_ESTUDIAR]= 1,'SI'  ,Iif( [HA_DEJADO_DE_ESTUDIAR]= 2,'NO','' ))" & _
    ""
        Me.GridColumn23.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 51
        Me.GridColumn23.Width = 151
        '
        'colTIEMPO_DEJO_ESTUDIAR
        '
        Me.colTIEMPO_DEJO_ESTUDIAR.FieldName = "TIEMPO_DEJO_ESTUDIAR"
        Me.colTIEMPO_DEJO_ESTUDIAR.Name = "colTIEMPO_DEJO_ESTUDIAR"
        Me.colTIEMPO_DEJO_ESTUDIAR.Width = 148
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "HACE CUANTO TIEMPO"
        Me.GridColumn25.FieldName = "GridColumn25"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.UnboundExpression = "Iif( [TIEMPO_DEJO_ESTUDIAR]= 1, '1 AÑO', Iif( [TIEMPO_DEJO_ESTUDIAR]= 2,'2-3 AÑOS" & _
    "' ,Iif( [TIEMPO_DEJO_ESTUDIAR]= 3,'MAS DE 3 AÑOS' , 'NR')))"
        Me.GridColumn25.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 52
        Me.GridColumn25.Width = 136
        '
        'colHA_RECIBIDO_CURSOS
        '
        Me.colHA_RECIBIDO_CURSOS.FieldName = "HA_RECIBIDO_CURSOS"
        Me.colHA_RECIBIDO_CURSOS.Name = "colHA_RECIBIDO_CURSOS"
        Me.colHA_RECIBIDO_CURSOS.Width = 138
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "HA RECIBIDO CURSOS"
        Me.GridColumn24.FieldName = "GridColumn24"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.UnboundExpression = "Iif( [HA_RECIBIDO_CURSOS]= 1,'SI', Iif( [HA_RECIBIDO_CURSOS]= 2,'NO','' ))"
        Me.GridColumn24.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 53
        Me.GridColumn24.Width = 149
        '
        'colCURSO_1
        '
        Me.colCURSO_1.FieldName = "CURSO_1"
        Me.colCURSO_1.Name = "colCURSO_1"
        Me.colCURSO_1.Visible = True
        Me.colCURSO_1.VisibleIndex = 54
        Me.colCURSO_1.Width = 69
        '
        'colCURSO_2
        '
        Me.colCURSO_2.FieldName = "CURSO_2"
        Me.colCURSO_2.Name = "colCURSO_2"
        Me.colCURSO_2.Visible = True
        Me.colCURSO_2.VisibleIndex = 58
        Me.colCURSO_2.Width = 69
        '
        'colCURSO_3
        '
        Me.colCURSO_3.FieldName = "CURSO_3"
        Me.colCURSO_3.Name = "colCURSO_3"
        Me.colCURSO_3.Visible = True
        Me.colCURSO_3.VisibleIndex = 62
        Me.colCURSO_3.Width = 69
        '
        'colIMPARTIO_INSAFORP_CURSO_1
        '
        Me.colIMPARTIO_INSAFORP_CURSO_1.FieldName = "IMPARTIO_INSAFORP_CURSO_1"
        Me.colIMPARTIO_INSAFORP_CURSO_1.Name = "colIMPARTIO_INSAFORP_CURSO_1"
        Me.colIMPARTIO_INSAFORP_CURSO_1.Width = 182
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "IMPARTIO_INSAFORP_CURSO_1"
        Me.GridColumn26.FieldName = "GridColumn26"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.UnboundExpression = "Iif( [IMPARTIO_INSAFORP_CURSO_1]= 1,'SI', Iif( [IMPARTIO_INSAFORP_CURSO_1]= 2,'NO" & _
    "','NO SABE' ))"
        Me.GridColumn26.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 55
        Me.GridColumn26.Width = 180
        '
        'colIMPARTIO_INSAFORP_CURSO_2
        '
        Me.colIMPARTIO_INSAFORP_CURSO_2.FieldName = "IMPARTIO_INSAFORP_CURSO_2"
        Me.colIMPARTIO_INSAFORP_CURSO_2.Name = "colIMPARTIO_INSAFORP_CURSO_2"
        Me.colIMPARTIO_INSAFORP_CURSO_2.Width = 182
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "IMPARTIO_INSAFORP_CURSO_2"
        Me.GridColumn27.FieldName = "GridColumn27"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.UnboundExpression = "Iif( [IMPARTIO_INSAFORP_CURSO_2]= 1,'SI', Iif( [IMPARTIO_INSAFORP_CURSO_2]= 2,'NO" & _
    "','NO SABE' ))"
        Me.GridColumn27.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 59
        Me.GridColumn27.Width = 179
        '
        'colIMPARTIO_INSAFORP_CURSO_3
        '
        Me.colIMPARTIO_INSAFORP_CURSO_3.FieldName = "IMPARTIO_INSAFORP_CURSO_3"
        Me.colIMPARTIO_INSAFORP_CURSO_3.Name = "colIMPARTIO_INSAFORP_CURSO_3"
        Me.colIMPARTIO_INSAFORP_CURSO_3.Width = 182
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "IMPARTIO_INSAFORP_CURSO_3"
        Me.GridColumn28.FieldName = "GridColumn28"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.UnboundExpression = "Iif( [IMPARTIO_INSAFORP_CURSO_3]= 1,'SI', Iif( [IMPARTIO_INSAFORP_CURSO_3]= 2,'NO" & _
    "','NO SABE' ))"
        Me.GridColumn28.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 63
        Me.GridColumn28.Width = 179
        '
        'colANO_CURSO_1
        '
        Me.colANO_CURSO_1.FieldName = "ANO_CURSO_1"
        Me.colANO_CURSO_1.Name = "colANO_CURSO_1"
        Me.colANO_CURSO_1.Visible = True
        Me.colANO_CURSO_1.VisibleIndex = 56
        Me.colANO_CURSO_1.Width = 97
        '
        'colANO_CURSO_2
        '
        Me.colANO_CURSO_2.FieldName = "ANO_CURSO_2"
        Me.colANO_CURSO_2.Name = "colANO_CURSO_2"
        Me.colANO_CURSO_2.Visible = True
        Me.colANO_CURSO_2.VisibleIndex = 60
        Me.colANO_CURSO_2.Width = 97
        '
        'colANO_CURSO_3
        '
        Me.colANO_CURSO_3.FieldName = "ANO_CURSO_3"
        Me.colANO_CURSO_3.Name = "colANO_CURSO_3"
        Me.colANO_CURSO_3.Visible = True
        Me.colANO_CURSO_3.VisibleIndex = 64
        Me.colANO_CURSO_3.Width = 97
        '
        'colCURSO_LE_DIO_BENEFICIOS_1
        '
        Me.colCURSO_LE_DIO_BENEFICIOS_1.FieldName = "CURSO_LE_DIO_BENEFICIOS_1"
        Me.colCURSO_LE_DIO_BENEFICIOS_1.Name = "colCURSO_LE_DIO_BENEFICIOS_1"
        Me.colCURSO_LE_DIO_BENEFICIOS_1.Width = 177
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "CURSO_LE_DIO_BENEFICIOS_1"
        Me.GridColumn29.FieldName = "GridColumn29"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.UnboundExpression = "Iif( [CURSO_LE_DIO_BENEFICIOS_1]= 1,'SI', Iif( [CURSO_LE_DIO_BENEFICIOS_1]= 2,'NR" & _
    "','' ))"
        Me.GridColumn29.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 57
        Me.GridColumn29.Width = 163
        '
        'colCURSO_LE_DIO_BENEFICIOS_2
        '
        Me.colCURSO_LE_DIO_BENEFICIOS_2.FieldName = "CURSO_LE_DIO_BENEFICIOS_2"
        Me.colCURSO_LE_DIO_BENEFICIOS_2.Name = "colCURSO_LE_DIO_BENEFICIOS_2"
        Me.colCURSO_LE_DIO_BENEFICIOS_2.Width = 177
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "CURSO_LE_DIO_BENEFICIOS_2"
        Me.GridColumn30.FieldName = "GridColumn30"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.UnboundExpression = "Iif( [CURSO_LE_DIO_BENEFICIOS_2]= 1,'SI', Iif( [CURSO_LE_DIO_BENEFICIOS_2]= 2,'NR" & _
    "','' ))"
        Me.GridColumn30.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 61
        Me.GridColumn30.Width = 174
        '
        'colCURSO_LE_DIO_BENEFICIOS_3
        '
        Me.colCURSO_LE_DIO_BENEFICIOS_3.FieldName = "CURSO_LE_DIO_BENEFICIOS_3"
        Me.colCURSO_LE_DIO_BENEFICIOS_3.Name = "colCURSO_LE_DIO_BENEFICIOS_3"
        Me.colCURSO_LE_DIO_BENEFICIOS_3.Width = 177
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "CURSO_LE_DIO_BENEFICIOS_3"
        Me.GridColumn31.FieldName = "GridColumn31"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.UnboundExpression = "Iif( [CURSO_LE_DIO_BENEFICIOS_3]= 1,'SI', Iif( [CURSO_LE_DIO_BENEFICIOS_3]= 2,'NR" & _
    "','' ))"
        Me.GridColumn31.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 65
        Me.GridColumn31.Width = 174
        '
        'colSIRVIO_CAPAC_OBTENER_EMPLEO
        '
        Me.colSIRVIO_CAPAC_OBTENER_EMPLEO.FieldName = "SIRVIO_CAPAC_OBTENER_EMPLEO"
        Me.colSIRVIO_CAPAC_OBTENER_EMPLEO.Name = "colSIRVIO_CAPAC_OBTENER_EMPLEO"
        Me.colSIRVIO_CAPAC_OBTENER_EMPLEO.Width = 194
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "SIRVIO_CAPAC_OBTENER_EMPLEO"
        Me.GridColumn32.FieldName = "GridColumn32"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.UnboundExpression = "Iif( [SIRVIO_CAPAC_OBTENER_EMPLEO]= 1,'SI', 'NO')"
        Me.GridColumn32.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 66
        Me.GridColumn32.Width = 191
        '
        'colSIRVIO_CAPAC_CAMBIAR_EMPLEO
        '
        Me.colSIRVIO_CAPAC_CAMBIAR_EMPLEO.FieldName = "SIRVIO_CAPAC_CAMBIAR_EMPLEO"
        Me.colSIRVIO_CAPAC_CAMBIAR_EMPLEO.Name = "colSIRVIO_CAPAC_CAMBIAR_EMPLEO"
        Me.colSIRVIO_CAPAC_CAMBIAR_EMPLEO.Width = 194
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "SIRVIO_CAPAC_CAMBIAR_EMPLEO"
        Me.GridColumn33.FieldName = "GridColumn33"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.UnboundExpression = "Iif( [SIRVIO_CAPAC_CAMBIAR_EMPLEO]= 1,'SI', 'NO')"
        Me.GridColumn33.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 67
        Me.GridColumn33.Width = 191
        '
        'colSIRVIO_CAPAC_TRAB_CTA_PROPIA
        '
        Me.colSIRVIO_CAPAC_TRAB_CTA_PROPIA.FieldName = "SIRVIO_CAPAC_TRAB_CTA_PROPIA"
        Me.colSIRVIO_CAPAC_TRAB_CTA_PROPIA.Name = "colSIRVIO_CAPAC_TRAB_CTA_PROPIA"
        Me.colSIRVIO_CAPAC_TRAB_CTA_PROPIA.Width = 199
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "SIRVIO_CAPAC_TRAB_CTA_PROPIA"
        Me.GridColumn34.FieldName = "GridColumn34"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.UnboundExpression = "Iif( [SIRVIO_CAPAC_TRAB_CTA_PROPIA]= 1,'SI', 'NO')"
        Me.GridColumn34.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 68
        Me.GridColumn34.Width = 196
        '
        'colSIRVIO_CAPAC_OTROS_INGRESOS
        '
        Me.colSIRVIO_CAPAC_OTROS_INGRESOS.FieldName = "SIRVIO_CAPAC_OTROS_INGRESOS"
        Me.colSIRVIO_CAPAC_OTROS_INGRESOS.Name = "colSIRVIO_CAPAC_OTROS_INGRESOS"
        Me.colSIRVIO_CAPAC_OTROS_INGRESOS.Width = 195
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "SIRVIO_CAPAC_OTROS_INGRESOS"
        Me.GridColumn35.FieldName = "GridColumn35"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.UnboundExpression = "Iif( [SIRVIO_CAPAC_OTROS_INGRESOS]= 1,'SI', 'NO')"
        Me.GridColumn35.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 69
        Me.GridColumn35.Width = 200
        '
        'colSIRVIO_CAPAC_PROMOCION
        '
        Me.colSIRVIO_CAPAC_PROMOCION.FieldName = "SIRVIO_CAPAC_PROMOCION"
        Me.colSIRVIO_CAPAC_PROMOCION.Name = "colSIRVIO_CAPAC_PROMOCION"
        Me.colSIRVIO_CAPAC_PROMOCION.Width = 166
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "SIRVIO_CAPAC_PROMOCION"
        Me.GridColumn36.FieldName = "GridColumn36"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.UnboundExpression = "Iif( [SIRVIO_CAPAC_PROMOCION]= 1,'SI', 'NO')"
        Me.GridColumn36.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 70
        Me.GridColumn36.Width = 205
        '
        'colPORQUE_NO_RECIB_BENEFICIO
        '
        Me.colPORQUE_NO_RECIB_BENEFICIO.FieldName = "PORQUE_NO_RECIB_BENEFICIO"
        Me.colPORQUE_NO_RECIB_BENEFICIO.Name = "colPORQUE_NO_RECIB_BENEFICIO"
        Me.colPORQUE_NO_RECIB_BENEFICIO.Visible = True
        Me.colPORQUE_NO_RECIB_BENEFICIO.VisibleIndex = 72
        Me.colPORQUE_NO_RECIB_BENEFICIO.Width = 181
        '
        'colREALIZA_ACTIVIDAD_INGRESOS
        '
        Me.colREALIZA_ACTIVIDAD_INGRESOS.FieldName = "REALIZA_ACTIVIDAD_INGRESOS"
        Me.colREALIZA_ACTIVIDAD_INGRESOS.Name = "colREALIZA_ACTIVIDAD_INGRESOS"
        Me.colREALIZA_ACTIVIDAD_INGRESOS.Width = 182
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "REALIZA_ACTIVIDAD_INGRESOS"
        Me.GridColumn37.FieldName = "GridColumn37"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.UnboundExpression = "Iif( [REALIZA_ACTIVIDAD_INGRESOS]= 1,'SI', 'NO')"
        Me.GridColumn37.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 73
        Me.GridColumn37.Width = 179
        '
        'colMEDIO_DE_INGRESO
        '
        Me.colMEDIO_DE_INGRESO.FieldName = "MEDIO_DE_INGRESO"
        Me.colMEDIO_DE_INGRESO.Name = "colMEDIO_DE_INGRESO"
        Me.colMEDIO_DE_INGRESO.Width = 125
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "MEDIO_DE_INGRESO"
        Me.GridColumn38.FieldName = "GridColumn38"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.UnboundExpression = "Iif( [MEDIO_DE_INGRESO]= 1,'EMPLEO FORMAL', Iif( [MEDIO_DE_INGRESO]= 2,'OTRA ACTI" & _
    "VIDAD','NR' ))"
        Me.GridColumn38.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 74
        Me.GridColumn38.Width = 122
        '
        'colACT_INGRESOS
        '
        Me.colACT_INGRESOS.FieldName = "ACT_INGRESOS"
        Me.colACT_INGRESOS.Name = "colACT_INGRESOS"
        Me.colACT_INGRESOS.Visible = True
        Me.colACT_INGRESOS.VisibleIndex = 75
        Me.colACT_INGRESOS.Width = 99
        '
        'colOTRA_ACTIVIDAD_ESTUDIA
        '
        Me.colOTRA_ACTIVIDAD_ESTUDIA.FieldName = "OTRA_ACTIVIDAD_ESTUDIA"
        Me.colOTRA_ACTIVIDAD_ESTUDIA.Name = "colOTRA_ACTIVIDAD_ESTUDIA"
        Me.colOTRA_ACTIVIDAD_ESTUDIA.Width = 160
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "OTRA_ACTIVIDAD_ESTUDIA"
        Me.GridColumn39.FieldName = "GridColumn39"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.UnboundExpression = "Iif( [OTRA_ACTIVIDAD_ESTUDIA]= 1,'SI', 'NO')"
        Me.GridColumn39.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 76
        Me.GridColumn39.Width = 157
        '
        'colOTRA_ACTIVIDAD_OFICIOS_HOGAR
        '
        Me.colOTRA_ACTIVIDAD_OFICIOS_HOGAR.FieldName = "OTRA_ACTIVIDAD_OFICIOS_HOGAR"
        Me.colOTRA_ACTIVIDAD_OFICIOS_HOGAR.Name = "colOTRA_ACTIVIDAD_OFICIOS_HOGAR"
        Me.colOTRA_ACTIVIDAD_OFICIOS_HOGAR.Width = 202
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "OTRA_ACTIVIDAD_OFICIOS_HOGAR"
        Me.GridColumn40.FieldName = "GridColumn40"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.UnboundExpression = "Iif( [OTRA_ACTIVIDAD_OFICIOS_HOGAR]= 1,'SI', 'NO')"
        Me.GridColumn40.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 77
        Me.GridColumn40.Width = 199
        '
        'colOTRA_ACTIVIDAD_BUSCA_TRABAJO
        '
        Me.colOTRA_ACTIVIDAD_BUSCA_TRABAJO.FieldName = "OTRA_ACTIVIDAD_BUSCA_TRABAJO"
        Me.colOTRA_ACTIVIDAD_BUSCA_TRABAJO.Name = "colOTRA_ACTIVIDAD_BUSCA_TRABAJO"
        Me.colOTRA_ACTIVIDAD_BUSCA_TRABAJO.Width = 202
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "OTRA_ACTIVIDAD_BUSCA_TRABAJO"
        Me.GridColumn41.FieldName = "GridColumn41"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.UnboundExpression = "Iif( [OTRA_ACTIVIDAD_BUSCA_TRABAJO]= 1,'SI', 'NO')"
        Me.GridColumn41.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 78
        Me.GridColumn41.Width = 199
        '
        'colOTRA_ACTIVIDAD_OTRA
        '
        Me.colOTRA_ACTIVIDAD_OTRA.FieldName = "OTRA_ACTIVIDAD_OTRA"
        Me.colOTRA_ACTIVIDAD_OTRA.Name = "colOTRA_ACTIVIDAD_OTRA"
        Me.colOTRA_ACTIVIDAD_OTRA.Visible = True
        Me.colOTRA_ACTIVIDAD_OTRA.VisibleIndex = 79
        Me.colOTRA_ACTIVIDAD_OTRA.Width = 145
        '
        'colTIPO_DE_EMPLEO_TIEMPO_COMP
        '
        Me.colTIPO_DE_EMPLEO_TIEMPO_COMP.FieldName = "TIPO_DE_EMPLEO_TIEMPO_COMP"
        Me.colTIPO_DE_EMPLEO_TIEMPO_COMP.Name = "colTIPO_DE_EMPLEO_TIEMPO_COMP"
        Me.colTIPO_DE_EMPLEO_TIEMPO_COMP.Width = 189
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "TIPO_DE_EMPLEO_TIEMPO_COMP"
        Me.GridColumn47.FieldName = "GridColumn47"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_TIEMPO_COMP]= 1,'SI', 'NO')"
        Me.GridColumn47.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 80
        Me.GridColumn47.Width = 186
        '
        'colTIPO_DE_EMPLEO_NEG_FAMILIAR
        '
        Me.colTIPO_DE_EMPLEO_NEG_FAMILIAR.FieldName = "TIPO_DE_EMPLEO_NEG_FAMILIAR"
        Me.colTIPO_DE_EMPLEO_NEG_FAMILIAR.Name = "colTIPO_DE_EMPLEO_NEG_FAMILIAR"
        Me.colTIPO_DE_EMPLEO_NEG_FAMILIAR.Width = 190
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "TIPO_DE_EMPLEO_NEG_FAMILIAR"
        Me.GridColumn46.FieldName = "GridColumn46"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_NEG_FAMILIAR]= 1,'SI', 'NO')"
        Me.GridColumn46.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 81
        Me.GridColumn46.Width = 187
        '
        'colTIPO_DE_EMPLEO_MEDIO_TIEMPO
        '
        Me.colTIPO_DE_EMPLEO_MEDIO_TIEMPO.FieldName = "TIPO_DE_EMPLEO_MEDIO_TIEMPO"
        Me.colTIPO_DE_EMPLEO_MEDIO_TIEMPO.Name = "colTIPO_DE_EMPLEO_MEDIO_TIEMPO"
        Me.colTIPO_DE_EMPLEO_MEDIO_TIEMPO.Width = 193
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "TIPO_DE_EMPLEO_MEDIO_TIEMPO"
        Me.GridColumn45.FieldName = "GridColumn45"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_MEDIO_TIEMPO]= 1,'SI', 'NO')"
        Me.GridColumn45.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 82
        Me.GridColumn45.Width = 190
        '
        'colTIPO_DE_EMPLEO_CTA_PROPIA
        '
        Me.colTIPO_DE_EMPLEO_CTA_PROPIA.FieldName = "TIPO_DE_EMPLEO_CTA_PROPIA"
        Me.colTIPO_DE_EMPLEO_CTA_PROPIA.Name = "colTIPO_DE_EMPLEO_CTA_PROPIA"
        Me.colTIPO_DE_EMPLEO_CTA_PROPIA.Width = 180
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "TIPO_DE_EMPLEO_CTA_PROPIA"
        Me.GridColumn44.FieldName = "GridColumn44"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_CTA_PROPIA]= 1,'SI', 'NO')"
        Me.GridColumn44.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 83
        Me.GridColumn44.Width = 177
        '
        'colTIPO_DE_EMPLEO_POR_HORAS
        '
        Me.colTIPO_DE_EMPLEO_POR_HORAS.FieldName = "TIPO_DE_EMPLEO_POR_HORAS"
        Me.colTIPO_DE_EMPLEO_POR_HORAS.Name = "colTIPO_DE_EMPLEO_POR_HORAS"
        Me.colTIPO_DE_EMPLEO_POR_HORAS.Width = 178
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "TIPO_DE_EMPLEO_POR_HORAS"
        Me.GridColumn43.FieldName = "GridColumn43"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_POR_HORAS]= 1,'SI', 'NO')"
        Me.GridColumn43.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 84
        Me.GridColumn43.Width = 175
        '
        'colTIPO_DE_EMPLEO_TEMPORAL
        '
        Me.colTIPO_DE_EMPLEO_TEMPORAL.FieldName = "TIPO_DE_EMPLEO_TEMPORAL"
        Me.colTIPO_DE_EMPLEO_TEMPORAL.Name = "colTIPO_DE_EMPLEO_TEMPORAL"
        Me.colTIPO_DE_EMPLEO_TEMPORAL.Width = 169
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "TIPO_DE_EMPLEO_TEMPORAL"
        Me.GridColumn42.FieldName = "GridColumn42"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.UnboundExpression = "Iif( [TIPO_DE_EMPLEO_TEMPORAL]= 1,'SI', 'NO')"
        Me.GridColumn42.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 85
        Me.GridColumn42.Width = 166
        '
        'colTIPO_DE_EMPLEO_OTRO
        '
        Me.colTIPO_DE_EMPLEO_OTRO.FieldName = "TIPO_DE_EMPLEO_OTRO"
        Me.colTIPO_DE_EMPLEO_OTRO.Name = "colTIPO_DE_EMPLEO_OTRO"
        Me.colTIPO_DE_EMPLEO_OTRO.Visible = True
        Me.colTIPO_DE_EMPLEO_OTRO.VisibleIndex = 86
        Me.colTIPO_DE_EMPLEO_OTRO.Width = 145
        '
        'colHA_TRABAJADO_ANTES
        '
        Me.colHA_TRABAJADO_ANTES.FieldName = "HA_TRABAJADO_ANTES"
        Me.colHA_TRABAJADO_ANTES.Name = "colHA_TRABAJADO_ANTES"
        Me.colHA_TRABAJADO_ANTES.Width = 140
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "HA_TRABAJADO_ANTES"
        Me.GridColumn48.FieldName = "GridColumn48"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.UnboundExpression = "Iif( [HA_TRABAJADO_ANTES]= 1,'SI', 'NO')"
        Me.GridColumn48.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 87
        Me.GridColumn48.Width = 137
        '
        'colTIEMPO_QUE_NO_TRABAJA
        '
        Me.colTIEMPO_QUE_NO_TRABAJA.FieldName = "TIEMPO_QUE_NO_TRABAJA"
        Me.colTIEMPO_QUE_NO_TRABAJA.Name = "colTIEMPO_QUE_NO_TRABAJA"
        Me.colTIEMPO_QUE_NO_TRABAJA.Width = 159
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "TIEMPO_QUE_NO_TRABAJA"
        Me.GridColumn49.FieldName = "GridColumn49"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.UnboundExpression = resources.GetString("GridColumn49.UnboundExpression")
        Me.GridColumn49.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 88
        Me.GridColumn49.Width = 181
        '
        'colNOMBRE_EMPRESA_ANTERIOR
        '
        Me.colNOMBRE_EMPRESA_ANTERIOR.FieldName = "NOMBRE_EMPRESA_ANTERIOR"
        Me.colNOMBRE_EMPRESA_ANTERIOR.Name = "colNOMBRE_EMPRESA_ANTERIOR"
        Me.colNOMBRE_EMPRESA_ANTERIOR.Visible = True
        Me.colNOMBRE_EMPRESA_ANTERIOR.VisibleIndex = 89
        Me.colNOMBRE_EMPRESA_ANTERIOR.Width = 174
        '
        'colDEDICACION_EMPRESA
        '
        Me.colDEDICACION_EMPRESA.FieldName = "DEDICACION_EMPRESA"
        Me.colDEDICACION_EMPRESA.Name = "colDEDICACION_EMPRESA"
        Me.colDEDICACION_EMPRESA.Visible = True
        Me.colDEDICACION_EMPRESA.VisibleIndex = 90
        Me.colDEDICACION_EMPRESA.Width = 138
        '
        'colMOTIVO_SALIDA_CAMBIO_TRAB
        '
        Me.colMOTIVO_SALIDA_CAMBIO_TRAB.FieldName = "MOTIVO_SALIDA_CAMBIO_TRAB"
        Me.colMOTIVO_SALIDA_CAMBIO_TRAB.Name = "colMOTIVO_SALIDA_CAMBIO_TRAB"
        Me.colMOTIVO_SALIDA_CAMBIO_TRAB.Width = 182
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "MOTIVO_SALIDA_CAMBIO_TRAB"
        Me.GridColumn50.FieldName = "GridColumn50"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.UnboundExpression = "Iif( [MOTIVO_SALIDA_CAMBIO_TRAB]= 1,'SI', 'NO')"
        Me.GridColumn50.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 91
        Me.GridColumn50.Width = 179
        '
        'colMOTIVO_SALIDA_JUBILACION
        '
        Me.colMOTIVO_SALIDA_JUBILACION.FieldName = "MOTIVO_SALIDA_JUBILACION"
        Me.colMOTIVO_SALIDA_JUBILACION.Name = "colMOTIVO_SALIDA_JUBILACION"
        Me.colMOTIVO_SALIDA_JUBILACION.Width = 170
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "MOTIVO_SALIDA_JUBILACION"
        Me.GridColumn51.FieldName = "GridColumn51"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.UnboundExpression = "Iif( [MOTIVO_SALIDA_JUBILACION]= 1,'SI', 'NO')"
        Me.GridColumn51.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 92
        Me.GridColumn51.Width = 167
        '
        'colMOTIVO_SALIDA_RENUNCIA
        '
        Me.colMOTIVO_SALIDA_RENUNCIA.FieldName = "MOTIVO_SALIDA_RENUNCIA"
        Me.colMOTIVO_SALIDA_RENUNCIA.Name = "colMOTIVO_SALIDA_RENUNCIA"
        Me.colMOTIVO_SALIDA_RENUNCIA.Width = 162
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "MOTIVO_SALIDA_RENUNCIA"
        Me.GridColumn52.FieldName = "GridColumn52"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.UnboundExpression = "Iif( [MOTIVO_SALIDA_RENUNCIA]= 1,'SI', 'NO')"
        Me.GridColumn52.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 93
        Me.GridColumn52.Width = 159
        '
        'colMOTIVO_SALIDA_DESPIDO
        '
        Me.colMOTIVO_SALIDA_DESPIDO.FieldName = "MOTIVO_SALIDA_DESPIDO"
        Me.colMOTIVO_SALIDA_DESPIDO.Name = "colMOTIVO_SALIDA_DESPIDO"
        Me.colMOTIVO_SALIDA_DESPIDO.Width = 154
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "MOTIVO_SALIDA_DESPIDO"
        Me.GridColumn53.FieldName = "GridColumn53"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.UnboundExpression = "Iif( [MOTIVO_SALIDA_DESPIDO]= 1,'SI', 'NO')"
        Me.GridColumn53.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 94
        Me.GridColumn53.Width = 151
        '
        'colMOTIVO_SALIDA_CIERRE
        '
        Me.colMOTIVO_SALIDA_CIERRE.FieldName = "MOTIVO_SALIDA_CIERRE"
        Me.colMOTIVO_SALIDA_CIERRE.Name = "colMOTIVO_SALIDA_CIERRE"
        Me.colMOTIVO_SALIDA_CIERRE.Width = 147
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "MOTIVO_SALIDA_CIERRE"
        Me.GridColumn54.FieldName = "GridColumn54"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.UnboundExpression = "Iif( [MOTIVO_SALIDA_CIERRE]= 1,'SI', 'NO')"
        Me.GridColumn54.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 95
        Me.GridColumn54.Width = 144
        '
        'colMOTIVO_SALIDA_EMPRESA_OTRAS
        '
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS.FieldName = "MOTIVO_SALIDA_EMPRESA_OTRAS"
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS.Name = "colMOTIVO_SALIDA_EMPRESA_OTRAS"
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS.Visible = True
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS.VisibleIndex = 96
        Me.colMOTIVO_SALIDA_EMPRESA_OTRAS.Width = 196
        '
        'colPUESTO_EMPRESA
        '
        Me.colPUESTO_EMPRESA.FieldName = "PUESTO_EMPRESA"
        Me.colPUESTO_EMPRESA.Name = "colPUESTO_EMPRESA"
        Me.colPUESTO_EMPRESA.Visible = True
        Me.colPUESTO_EMPRESA.VisibleIndex = 97
        Me.colPUESTO_EMPRESA.Width = 316
        '
        'colTIEMPO_TRABAJO_EMPRESA
        '
        Me.colTIEMPO_TRABAJO_EMPRESA.FieldName = "TIEMPO_TRABAJO_EMPRESA"
        Me.colTIEMPO_TRABAJO_EMPRESA.Name = "colTIEMPO_TRABAJO_EMPRESA"
        Me.colTIEMPO_TRABAJO_EMPRESA.Width = 164
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "TIEMPO_TRABAJO_EMPRESA"
        Me.GridColumn55.FieldName = "GridColumn55"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.UnboundExpression = resources.GetString("GridColumn55.UnboundExpression")
        Me.GridColumn55.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 98
        Me.GridColumn55.Width = 161
        '
        'colRECIBE_INGRESOS
        '
        Me.colRECIBE_INGRESOS.FieldName = "RECIBE_INGRESOS"
        Me.colRECIBE_INGRESOS.Name = "colRECIBE_INGRESOS"
        Me.colRECIBE_INGRESOS.Width = 115
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "RECIBE_INGRESOS"
        Me.GridColumn56.FieldName = "GridColumn56"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.UnboundExpression = "Iif( [RECIBE_INGRESOS]= 1, 'SI', 'NO')"
        Me.GridColumn56.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 99
        Me.GridColumn56.Width = 112
        '
        'colMAN_OBTIENE_ING_TRAB_ACT
        '
        Me.colMAN_OBTIENE_ING_TRAB_ACT.FieldName = "MAN_OBTIENE_ING_TRAB_ACT"
        Me.colMAN_OBTIENE_ING_TRAB_ACT.Name = "colMAN_OBTIENE_ING_TRAB_ACT"
        Me.colMAN_OBTIENE_ING_TRAB_ACT.Width = 175
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "MAN_OBTIENE_ING_TRAB_ACT"
        Me.GridColumn57.FieldName = "GridColumn57"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.UnboundExpression = "Iif( [MAN_OBTIENE_ING_TRAB_ACT]= 1, 'SI', 'NO')"
        Me.GridColumn57.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 100
        Me.GridColumn57.Width = 172
        '
        'colMAN_OBTIENE_ING_AYUDA_FAM
        '
        Me.colMAN_OBTIENE_ING_AYUDA_FAM.FieldName = "MAN_OBTIENE_ING_AYUDA_FAM"
        Me.colMAN_OBTIENE_ING_AYUDA_FAM.Name = "colMAN_OBTIENE_ING_AYUDA_FAM"
        Me.colMAN_OBTIENE_ING_AYUDA_FAM.Width = 184
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "MAN_OBTIENE_ING_AYUDA_FAM"
        Me.GridColumn58.FieldName = "GridColumn58"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.UnboundExpression = "Iif( [MAN_OBTIENE_ING_AYUDA_FAM]= 1, 'SI', 'NO')"
        Me.GridColumn58.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 101
        Me.GridColumn58.Width = 181
        '
        'colMAN_OBTIENE_ING_REMESA
        '
        Me.colMAN_OBTIENE_ING_REMESA.FieldName = "MAN_OBTIENE_ING_REMESA"
        Me.colMAN_OBTIENE_ING_REMESA.Name = "colMAN_OBTIENE_ING_REMESA"
        Me.colMAN_OBTIENE_ING_REMESA.Width = 163
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "MAN_OBTIENE_ING_REMESA"
        Me.GridColumn59.FieldName = "GridColumn59"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.UnboundExpression = "Iif( [MAN_OBTIENE_ING_REMESA]= 1, 'SI', 'NO')"
        Me.GridColumn59.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 102
        Me.GridColumn59.Width = 160
        '
        'colMAN_OBTIENE_ING_PENSION
        '
        Me.colMAN_OBTIENE_ING_PENSION.FieldName = "MAN_OBTIENE_ING_PENSION"
        Me.colMAN_OBTIENE_ING_PENSION.Name = "colMAN_OBTIENE_ING_PENSION"
        Me.colMAN_OBTIENE_ING_PENSION.Width = 167
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "MAN_OBTIENE_ING_PENSION"
        Me.GridColumn60.FieldName = "GridColumn60"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.UnboundExpression = "Iif( [MAN_OBTIENE_ING_PENSION]= 1, 'SI', 'NO')"
        Me.GridColumn60.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 103
        Me.GridColumn60.Width = 164
        '
        'colMAN_OBTIENE_ING_TRAB_ACT_REM
        '
        Me.colMAN_OBTIENE_ING_TRAB_ACT_REM.FieldName = "MAN_OBTIENE_ING_TRAB_ACT_REM"
        Me.colMAN_OBTIENE_ING_TRAB_ACT_REM.Name = "colMAN_OBTIENE_ING_TRAB_ACT_REM"
        Me.colMAN_OBTIENE_ING_TRAB_ACT_REM.Width = 202
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "MAN_OBTIENE_ING_TRAB_ACT_REM"
        Me.GridColumn61.FieldName = "GridColumn61"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.UnboundExpression = "Iif( [MAN_OBTIENE_ING_TRAB_ACT_REM]= 1, 'SI', 'NO')"
        Me.GridColumn61.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 104
        Me.GridColumn61.Width = 199
        '
        'colMAN_OBTIENE_ING_OTRA
        '
        Me.colMAN_OBTIENE_ING_OTRA.FieldName = "MAN_OBTIENE_ING_OTRA"
        Me.colMAN_OBTIENE_ING_OTRA.Name = "colMAN_OBTIENE_ING_OTRA"
        Me.colMAN_OBTIENE_ING_OTRA.Visible = True
        Me.colMAN_OBTIENE_ING_OTRA.VisibleIndex = 105
        Me.colMAN_OBTIENE_ING_OTRA.Width = 151
        '
        'colINGRESO_PERSONAL_MENSUAL
        '
        Me.colINGRESO_PERSONAL_MENSUAL.FieldName = "INGRESO_PERSONAL_MENSUAL"
        Me.colINGRESO_PERSONAL_MENSUAL.Name = "colINGRESO_PERSONAL_MENSUAL"
        Me.colINGRESO_PERSONAL_MENSUAL.Visible = True
        Me.colINGRESO_PERSONAL_MENSUAL.VisibleIndex = 106
        Me.colINGRESO_PERSONAL_MENSUAL.Width = 177
        '
        'colINGRESO_PERSONAL_DIARIO
        '
        Me.colINGRESO_PERSONAL_DIARIO.FieldName = "INGRESO_PERSONAL_DIARIO"
        Me.colINGRESO_PERSONAL_DIARIO.Name = "colINGRESO_PERSONAL_DIARIO"
        Me.colINGRESO_PERSONAL_DIARIO.Visible = True
        Me.colINGRESO_PERSONAL_DIARIO.VisibleIndex = 107
        Me.colINGRESO_PERSONAL_DIARIO.Width = 168
        '
        'colQUE_GUSTARIA_APRENDER_1
        '
        Me.colQUE_GUSTARIA_APRENDER_1.FieldName = "QUE_GUSTARIA_APRENDER_1"
        Me.colQUE_GUSTARIA_APRENDER_1.Name = "colQUE_GUSTARIA_APRENDER_1"
        Me.colQUE_GUSTARIA_APRENDER_1.Visible = True
        Me.colQUE_GUSTARIA_APRENDER_1.VisibleIndex = 108
        Me.colQUE_GUSTARIA_APRENDER_1.Width = 171
        '
        'colQUE_GUSTARIA_APRENDER_2
        '
        Me.colQUE_GUSTARIA_APRENDER_2.FieldName = "QUE_GUSTARIA_APRENDER_2"
        Me.colQUE_GUSTARIA_APRENDER_2.Name = "colQUE_GUSTARIA_APRENDER_2"
        Me.colQUE_GUSTARIA_APRENDER_2.Visible = True
        Me.colQUE_GUSTARIA_APRENDER_2.VisibleIndex = 109
        Me.colQUE_GUSTARIA_APRENDER_2.Width = 171
        '
        'colQUE_GUSTARIA_APRENDER_3
        '
        Me.colQUE_GUSTARIA_APRENDER_3.FieldName = "QUE_GUSTARIA_APRENDER_3"
        Me.colQUE_GUSTARIA_APRENDER_3.Name = "colQUE_GUSTARIA_APRENDER_3"
        Me.colQUE_GUSTARIA_APRENDER_3.Visible = True
        Me.colQUE_GUSTARIA_APRENDER_3.VisibleIndex = 110
        Me.colQUE_GUSTARIA_APRENDER_3.Width = 171
        '
        'colLOGROS_ESPERADOS_EMPLEO_FORMAL
        '
        Me.colLOGROS_ESPERADOS_EMPLEO_FORMAL.FieldName = "LOGROS_ESPERADOS_EMPLEO_FORMAL"
        Me.colLOGROS_ESPERADOS_EMPLEO_FORMAL.Name = "colLOGROS_ESPERADOS_EMPLEO_FORMAL"
        Me.colLOGROS_ESPERADOS_EMPLEO_FORMAL.Width = 220
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "LOGROS_ESPERADOS_EMPLEO_FORMAL"
        Me.GridColumn62.FieldName = "GridColumn62"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.UnboundExpression = "Iif( [LOGROS_ESPERADOS_EMPLEO_FORMAL]= 1, 'SI', 'NO')"
        Me.GridColumn62.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 111
        Me.GridColumn62.Width = 217
        '
        'colLOGROS_ESPERADOS_CUENTA_PROPIA
        '
        Me.colLOGROS_ESPERADOS_CUENTA_PROPIA.FieldName = "LOGROS_ESPERADOS_CUENTA_PROPIA"
        Me.colLOGROS_ESPERADOS_CUENTA_PROPIA.Name = "colLOGROS_ESPERADOS_CUENTA_PROPIA"
        Me.colLOGROS_ESPERADOS_CUENTA_PROPIA.Width = 218
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "LOGROS_ESPERADOS_CUENTA_PROPIA"
        Me.GridColumn63.FieldName = "GridColumn63"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.UnboundExpression = "Iif( [LOGROS_ESPERADOS_CUENTA_PROPIA]= 1, 'SI', 'NO')"
        Me.GridColumn63.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 112
        Me.GridColumn63.Width = 215
        '
        'colLOGROS_ESPERADOS_OTRO
        '
        Me.colLOGROS_ESPERADOS_OTRO.FieldName = "LOGROS_ESPERADOS_OTRO"
        Me.colLOGROS_ESPERADOS_OTRO.Name = "colLOGROS_ESPERADOS_OTRO"
        Me.colLOGROS_ESPERADOS_OTRO.Visible = True
        Me.colLOGROS_ESPERADOS_OTRO.VisibleIndex = 113
        Me.colLOGROS_ESPERADOS_OTRO.Width = 163
        '
        'colGUSTO_UBICACION_TRABAJO
        '
        Me.colGUSTO_UBICACION_TRABAJO.FieldName = "GUSTO_UBICACION_TRABAJO"
        Me.colGUSTO_UBICACION_TRABAJO.Name = "colGUSTO_UBICACION_TRABAJO"
        Me.colGUSTO_UBICACION_TRABAJO.Width = 171
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "GUSTO_UBICACION_TRABAJO"
        Me.GridColumn64.FieldName = "GridColumn64"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.UnboundExpression = "Iif( [GUSTO_UBICACION_TRABAJO]= 1, 'EN EL MISMO MUNICIPIO', Iif( [GUSTO_UBICACION" & _
    "_TRABAJO]= 2,'EN OTRO MUNICIPIO' , Iif( [GUSTO_UBICACION_TRABAJO]= 3,'LE ES INDI" & _
    "FERENTE' , '') ) )"
        Me.GridColumn64.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 114
        Me.GridColumn64.Width = 168
        '
        'colEN_QUE_OCUP_DINERO_AYUDAR
        '
        Me.colEN_QUE_OCUP_DINERO_AYUDAR.FieldName = "EN_QUE_OCUP_DINERO_AYUDAR"
        Me.colEN_QUE_OCUP_DINERO_AYUDAR.Name = "colEN_QUE_OCUP_DINERO_AYUDAR"
        Me.colEN_QUE_OCUP_DINERO_AYUDAR.Width = 188
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "EN_QUE_OCUP_DINERO_AYUDAR"
        Me.GridColumn65.FieldName = "GridColumn65"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.UnboundExpression = "Iif( [EN_QUE_OCUP_DINERO_AYUDAR]= 1, 'SI', 'NO')"
        Me.GridColumn65.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 115
        Me.GridColumn65.Width = 185
        '
        'colEN_QUE_OCUP_DINERO_INDEPEND
        '
        Me.colEN_QUE_OCUP_DINERO_INDEPEND.FieldName = "EN_QUE_OCUP_DINERO_INDEPEND"
        Me.colEN_QUE_OCUP_DINERO_INDEPEND.Name = "colEN_QUE_OCUP_DINERO_INDEPEND"
        Me.colEN_QUE_OCUP_DINERO_INDEPEND.Width = 197
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "EN_QUE_OCUP_DINERO_INDEPEND"
        Me.GridColumn66.FieldName = "GridColumn66"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.UnboundExpression = "Iif( [EN_QUE_OCUP_DINERO_INDEPEND]= 1, 'SI', 'NO')"
        Me.GridColumn66.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 116
        Me.GridColumn66.Width = 194
        '
        'colEN_QUE_OCUP_DINERO_MANT_HIJOS
        '
        Me.colEN_QUE_OCUP_DINERO_MANT_HIJOS.FieldName = "EN_QUE_OCUP_DINERO_MANT_HIJOS"
        Me.colEN_QUE_OCUP_DINERO_MANT_HIJOS.Name = "colEN_QUE_OCUP_DINERO_MANT_HIJOS"
        Me.colEN_QUE_OCUP_DINERO_MANT_HIJOS.Width = 211
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "EN_QUE_OCUP_DINERO_MANT_HIJOS"
        Me.GridColumn67.FieldName = "GridColumn67"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.UnboundExpression = "Iif( [EN_QUE_OCUP_DINERO_MANT_HIJOS]= 1, 'SI', 'NO')"
        Me.GridColumn67.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 117
        Me.GridColumn67.Width = 221
        '
        'colEN_QUE_OCUP_DINERO_MANT_PADRES
        '
        Me.colEN_QUE_OCUP_DINERO_MANT_PADRES.FieldName = "EN_QUE_OCUP_DINERO_MANT_PADRES"
        Me.colEN_QUE_OCUP_DINERO_MANT_PADRES.Name = "colEN_QUE_OCUP_DINERO_MANT_PADRES"
        Me.colEN_QUE_OCUP_DINERO_MANT_PADRES.Width = 220
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "EN_QUE_OCUP_DINERO_MANT_PADRES"
        Me.GridColumn68.FieldName = "GridColumn68"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.UnboundExpression = "Iif( [EN_QUE_OCUP_DINERO_MANT_PADRES]= 1, 'SI', 'NO')"
        Me.GridColumn68.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 118
        Me.GridColumn68.Width = 217
        '
        'colEN_QUE_OCUP_DINERO_PAGAR_ESTUD
        '
        Me.colEN_QUE_OCUP_DINERO_PAGAR_ESTUD.FieldName = "EN_QUE_OCUP_DINERO_PAGAR_ESTUD"
        Me.colEN_QUE_OCUP_DINERO_PAGAR_ESTUD.Name = "colEN_QUE_OCUP_DINERO_PAGAR_ESTUD"
        Me.colEN_QUE_OCUP_DINERO_PAGAR_ESTUD.Width = 219
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "EN_QUE_OCUP_DINERO_PAGAR_ESTUD"
        Me.GridColumn69.FieldName = "GridColumn69"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.UnboundExpression = "Iif( [EN_QUE_OCUP_DINERO_PAGAR_ESTUD]= 1, 'SI', 'NO')"
        Me.GridColumn69.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 119
        Me.GridColumn69.Width = 216
        '
        'colEN_QUE_OCUP_DINERO_OTRO
        '
        Me.colEN_QUE_OCUP_DINERO_OTRO.FieldName = "EN_QUE_OCUP_DINERO_OTRO"
        Me.colEN_QUE_OCUP_DINERO_OTRO.Name = "colEN_QUE_OCUP_DINERO_OTRO"
        Me.colEN_QUE_OCUP_DINERO_OTRO.Visible = True
        Me.colEN_QUE_OCUP_DINERO_OTRO.VisibleIndex = 120
        Me.colEN_QUE_OCUP_DINERO_OTRO.Width = 176
        '
        'colNOMBRES_CONOCIDO
        '
        Me.colNOMBRES_CONOCIDO.FieldName = "NOMBRES_CONOCIDO"
        Me.colNOMBRES_CONOCIDO.Name = "colNOMBRES_CONOCIDO"
        Me.colNOMBRES_CONOCIDO.Visible = True
        Me.colNOMBRES_CONOCIDO.VisibleIndex = 121
        Me.colNOMBRES_CONOCIDO.Width = 132
        '
        'colPARENTESCO
        '
        Me.colPARENTESCO.FieldName = "PARENTESCO"
        Me.colPARENTESCO.Name = "colPARENTESCO"
        Me.colPARENTESCO.Width = 88
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "PARENTESCO"
        Me.GridColumn70.FieldName = "GridColumn70"
        Me.GridColumn70.Name = "GridColumn70"
        Me.GridColumn70.UnboundExpression = "Iif( [PARENTESCO]= 1, 'FAMILIAR', 'AMIGO')"
        Me.GridColumn70.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn70.Visible = True
        Me.GridColumn70.VisibleIndex = 122
        Me.GridColumn70.Width = 85
        '
        'colDIRECCION_CONOCIDO
        '
        Me.colDIRECCION_CONOCIDO.FieldName = "DIRECCION_CONOCIDO"
        Me.colDIRECCION_CONOCIDO.Name = "colDIRECCION_CONOCIDO"
        Me.colDIRECCION_CONOCIDO.Visible = True
        Me.colDIRECCION_CONOCIDO.VisibleIndex = 123
        Me.colDIRECCION_CONOCIDO.Width = 521
        '
        'colTELEFONO_FIJO_CONOCIDO
        '
        Me.colTELEFONO_FIJO_CONOCIDO.FieldName = "TELEFONO_FIJO_CONOCIDO"
        Me.colTELEFONO_FIJO_CONOCIDO.Name = "colTELEFONO_FIJO_CONOCIDO"
        Me.colTELEFONO_FIJO_CONOCIDO.Visible = True
        Me.colTELEFONO_FIJO_CONOCIDO.VisibleIndex = 126
        Me.colTELEFONO_FIJO_CONOCIDO.Width = 165
        '
        'colTELEFONO_MOVIL_CONOCIDO
        '
        Me.colTELEFONO_MOVIL_CONOCIDO.FieldName = "TELEFONO_MOVIL_CONOCIDO"
        Me.colTELEFONO_MOVIL_CONOCIDO.Name = "colTELEFONO_MOVIL_CONOCIDO"
        Me.colTELEFONO_MOVIL_CONOCIDO.Visible = True
        Me.colTELEFONO_MOVIL_CONOCIDO.VisibleIndex = 127
        Me.colTELEFONO_MOVIL_CONOCIDO.Width = 173
        '
        'colEMAIL_CONOCIDO
        '
        Me.colEMAIL_CONOCIDO.FieldName = "EMAIL_CONOCIDO"
        Me.colEMAIL_CONOCIDO.Name = "colEMAIL_CONOCIDO"
        Me.colEMAIL_CONOCIDO.Visible = True
        Me.colEMAIL_CONOCIDO.VisibleIndex = 128
        Me.colEMAIL_CONOCIDO.Width = 114
        '
        'colOBSERVACIONES_SUGERENCIAS
        '
        Me.colOBSERVACIONES_SUGERENCIAS.FieldName = "OBSERVACIONES_SUGERENCIAS"
        Me.colOBSERVACIONES_SUGERENCIAS.Name = "colOBSERVACIONES_SUGERENCIAS"
        Me.colOBSERVACIONES_SUGERENCIAS.Visible = True
        Me.colOBSERVACIONES_SUGERENCIAS.VisibleIndex = 130
        Me.colOBSERVACIONES_SUGERENCIAS.Width = 182
        '
        'colUSERID
        '
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 133
        Me.colUSERID.Width = 192
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 132
        Me.colLASTUPDATE.Width = 82
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Visible = True
        Me.colID_PARTICIPANTE.VisibleIndex = 131
        Me.colID_PARTICIPANTE.Width = 112
        '
        'colOBSERVACIONES_DIGITADOR
        '
        Me.colOBSERVACIONES_DIGITADOR.FieldName = "OBSERVACIONES_DIGITADOR"
        Me.colOBSERVACIONES_DIGITADOR.Name = "colOBSERVACIONES_DIGITADOR"
        Me.colOBSERVACIONES_DIGITADOR.Visible = True
        Me.colOBSERVACIONES_DIGITADOR.VisibleIndex = 129
        Me.colOBSERVACIONES_DIGITADOR.Width = 169
        '
        'colNO_CONVOCATORIA
        '
        Me.colNO_CONVOCATORIA.Caption = "No. Convocatoria"
        Me.colNO_CONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Name = "colNO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Width = 138
        '
        'colNOMBRE_DEPTO_CONOCIDO
        '
        Me.colNOMBRE_DEPTO_CONOCIDO.FieldName = "NOMBRE_DEPTO_CONOCIDO"
        Me.colNOMBRE_DEPTO_CONOCIDO.Name = "colNOMBRE_DEPTO_CONOCIDO"
        Me.colNOMBRE_DEPTO_CONOCIDO.Visible = True
        Me.colNOMBRE_DEPTO_CONOCIDO.VisibleIndex = 125
        Me.colNOMBRE_DEPTO_CONOCIDO.Width = 162
        '
        'colNOMBRE_MUNIC_CONOCIDO
        '
        Me.colNOMBRE_MUNIC_CONOCIDO.FieldName = "NOMBRE_MUNIC_CONOCIDO"
        Me.colNOMBRE_MUNIC_CONOCIDO.Name = "colNOMBRE_MUNIC_CONOCIDO"
        Me.colNOMBRE_MUNIC_CONOCIDO.Visible = True
        Me.colNOMBRE_MUNIC_CONOCIDO.VisibleIndex = 124
        Me.colNOMBRE_MUNIC_CONOCIDO.Width = 162
        '
        'colNOMBRE_PROYECTO
        '
        Me.colNOMBRE_PROYECTO.Caption = "Proyecto"
        Me.colNOMBRE_PROYECTO.FieldName = "NOMBRE_PROYECTO"
        Me.colNOMBRE_PROYECTO.Name = "colNOMBRE_PROYECTO"
        '
        'colCODIGO_PROYECTO
        '
        Me.colCODIGO_PROYECTO.FieldName = "CODIGO_PROYECTO"
        Me.colCODIGO_PROYECTO.Name = "colCODIGO_PROYECTO"
        Me.colCODIGO_PROYECTO.Visible = True
        Me.colCODIGO_PROYECTO.VisibleIndex = 134
        Me.colCODIGO_PROYECTO.Width = 120
        '
        'colSIRVIO_CAPAC_OTRO
        '
        Me.colSIRVIO_CAPAC_OTRO.FieldName = "SIRVIO_CAPAC_OTRO"
        Me.colSIRVIO_CAPAC_OTRO.Name = "colSIRVIO_CAPAC_OTRO"
        Me.colSIRVIO_CAPAC_OTRO.Visible = True
        Me.colSIRVIO_CAPAC_OTRO.VisibleIndex = 71
        Me.colSIRVIO_CAPAC_OTRO.Width = 371
        '
        'tabAnalisis
        '
        Me.tabAnalisis.Controls.Add(Me.PivotGridControl1)
        Me.tabAnalisis.Name = "tabAnalisis"
        Me.tabAnalisis.Size = New System.Drawing.Size(1075, 418)
        Me.tabAnalisis.Text = "Analisis"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "FICHA_PATI"
        Me.PivotGridControl1.DataSource = Me.DS_DL1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOCONVOCATORIA, Me.fieldESJEFEDEHOGAR, Me.field, Me.fieldSEXO, Me.fieldSEXO1, Me.fieldRangoEdad3, Me.fieldNUMEFICH, Me.fieldNOMBREDEPTORESIDENCIA, Me.fieldNOMBREMUNICRESIDENCIA, Me.fieldNOMBREDEPTONAC, Me.fieldNOMBREMUNICNAC})
        PivotGridGroup1.Caption = "DISCAPACIDAD"
        PivotGridGroup1.Hierarchy = Nothing
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.Size = New System.Drawing.Size(1075, 418)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldNOCONVOCATORIA
        '
        Me.fieldNOCONVOCATORIA.AreaIndex = 0
        Me.fieldNOCONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.fieldNOCONVOCATORIA.Name = "fieldNOCONVOCATORIA"
        '
        'fieldESJEFEDEHOGAR
        '
        Me.fieldESJEFEDEHOGAR.AreaIndex = 1
        Me.fieldESJEFEDEHOGAR.FieldName = "ES_JEFE_DE_HOGAR"
        Me.fieldESJEFEDEHOGAR.Name = "fieldESJEFEDEHOGAR"
        Me.fieldESJEFEDEHOGAR.Visible = False
        '
        'field
        '
        Me.field.AreaIndex = 5
        Me.field.Caption = "Es Jefe de Hogar"
        Me.field.Name = "field"
        Me.field.UnboundExpression = "Iif( [ES_JEFE_DE_HOGAR] = 1, 'SI', Iif( [ES_JEFE_DE_HOGAR] = 2,'NO' ,'COMPARTIDA'" & _
    " ) )"
        Me.field.UnboundFieldName = "fieldESJEFEDEHOGAR1"
        Me.field.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldSEXO
        '
        Me.fieldSEXO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSEXO.AreaIndex = 0
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        Me.fieldSEXO.Visible = False
        '
        'fieldSEXO1
        '
        Me.fieldSEXO1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSEXO1.AreaIndex = 0
        Me.fieldSEXO1.Caption = "Genero"
        Me.fieldSEXO1.FieldName = "SEXO"
        Me.fieldSEXO1.Name = "fieldSEXO1"
        Me.fieldSEXO1.UnboundExpression = "Iif([SEXO]=1, 'HOMBRE' ,'MUJER' )"
        Me.fieldSEXO1.UnboundFieldName = "fieldSEXO1"
        Me.fieldSEXO1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldRangoEdad3
        '
        Me.fieldRangoEdad3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRangoEdad3.AreaIndex = 0
        Me.fieldRangoEdad3.Caption = "Rango Edad"
        Me.fieldRangoEdad3.Name = "fieldRangoEdad3"
        Me.fieldRangoEdad3.UnboundFieldName = "fieldRangoEdad3"
        Me.fieldRangoEdad3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldNUMEFICH
        '
        Me.fieldNUMEFICH.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNUMEFICH.AreaIndex = 0
        Me.fieldNUMEFICH.Caption = "Participacion"
        Me.fieldNUMEFICH.FieldName = "NUME_FICH"
        Me.fieldNUMEFICH.Name = "fieldNUMEFICH"
        Me.fieldNUMEFICH.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldNOMBREDEPTORESIDENCIA
        '
        Me.fieldNOMBREDEPTORESIDENCIA.AreaIndex = 1
        Me.fieldNOMBREDEPTORESIDENCIA.FieldName = "NOMBRE_DEPTO_RESIDENCIA"
        Me.fieldNOMBREDEPTORESIDENCIA.Name = "fieldNOMBREDEPTORESIDENCIA"
        '
        'fieldNOMBREMUNICRESIDENCIA
        '
        Me.fieldNOMBREMUNICRESIDENCIA.AreaIndex = 2
        Me.fieldNOMBREMUNICRESIDENCIA.FieldName = "NOMBRE_MUNIC_RESIDENCIA"
        Me.fieldNOMBREMUNICRESIDENCIA.Name = "fieldNOMBREMUNICRESIDENCIA"
        '
        'fieldNOMBREDEPTONAC
        '
        Me.fieldNOMBREDEPTONAC.AreaIndex = 3
        Me.fieldNOMBREDEPTONAC.FieldName = "NOMBRE_DEPTO_NAC"
        Me.fieldNOMBREDEPTONAC.Name = "fieldNOMBREDEPTONAC"
        '
        'fieldNOMBREMUNICNAC
        '
        Me.fieldNOMBREMUNICNAC.AreaIndex = 4
        Me.fieldNOMBREMUNICNAC.FieldName = "NOMBRE_MUNIC_NAC"
        Me.fieldNOMBREMUNICNAC.Name = "fieldNOMBREMUNICNAC"
        '
        'tabGrafico
        '
        Me.tabGrafico.Controls.Add(Me.txtTituloGrafico)
        Me.tabGrafico.Controls.Add(Me.LabelControl2)
        Me.tabGrafico.Controls.Add(Me.CheckEdit1)
        Me.tabGrafico.Controls.Add(Me.LabelControl1)
        Me.tabGrafico.Controls.Add(Me.ComboBoxEdit1)
        Me.tabGrafico.Controls.Add(Me.ChartControl1)
        Me.tabGrafico.Name = "tabGrafico"
        Me.tabGrafico.Size = New System.Drawing.Size(1075, 418)
        Me.tabGrafico.Text = "Grafico"
        '
        'txtTituloGrafico
        '
        Me.txtTituloGrafico.EditValue = "Analisis Ejecucion PATI"
        Me.txtTituloGrafico.Location = New System.Drawing.Point(536, 3)
        Me.txtTituloGrafico.Name = "txtTituloGrafico"
        Me.txtTituloGrafico.Size = New System.Drawing.Size(256, 20)
        Me.txtTituloGrafico.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(461, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Texto Grafico:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(313, 4)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Invertir Grafico"
        Me.CheckEdit1.Size = New System.Drawing.Size(123, 19)
        Me.CheckEdit1.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Tipo de Grafico:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "Barras tipo Manhatan"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(87, 3)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Barras tipo Manhatan", "Barras 3D", "Barras en Pila 3D", "Barras 2D", "Barras en Pila 2D", "Pastel 3D", "Pastel 2D"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(133, 20)
        Me.ComboBoxEdit1.TabIndex = 9
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.DataAdapter = Me.FichA_PATITableAdapter1
        Me.ChartControl1.DataSource = Me.PivotGridControl1
        XyDiagram3D1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3D1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & _
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & _
    "1"
        XyDiagram3D1.RuntimeRotation = True
        XyDiagram3D1.RuntimeZooming = True
        Me.ChartControl1.Diagram = XyDiagram3D1
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Location = New System.Drawing.Point(4, 29)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Mixed"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Bar3DSeriesLabel1.LineVisible = True
        Bar3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Bar3DSeriesLabel1.Visible = True
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.SeriesTemplate.View = ManhattanBarSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(1067, 382)
        Me.ChartControl1.TabIndex = 8
        ChartTitle1.Text = "Participantes PATI"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'FichA_PATITableAdapter1
        '
        Me.FichA_PATITableAdapter1.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DeptoFaseMunicipioTableAdapter1
        '
        Me.DeptoFaseMunicipioTableAdapter1.ClearBeforeFill = True
        '
        'MunicFaseMunicipioTableAdapter1
        '
        Me.MunicFaseMunicipioTableAdapter1.ClearBeforeFill = True
        '
        'frmBoletasDNCPATI
        '
        Me.ClientSize = New System.Drawing.Size(1081, 534)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmBoletasDNCPATI"
        Me.Text = "Analisis Ejecución PATI"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbxMunic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MunicFaseMunicipioDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptoFaseMunicipioDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabDetalle.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalisis.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrafico.ResumeLayout(False)
        Me.tabGrafico.PerformLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDetalle As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabAnalisis As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents tabGrafico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTituloGrafico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents fieldNOCONVOCATORIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESJEFEDEHOGAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRangoEdad3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FichA_PATITableAdapter1 As SGAFP.DL.DS_DLTableAdapters.FICHA_PATITableAdapter
    Friend WithEvents colNUME_FICH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ENTREVISTADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMB_CASERIO_AUP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ING_FICHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERCER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDUI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCEDULA_IDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARNET_MINORIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASAPORTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES_JEFE_DE_HOGAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO_FAMILIAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIENE_HIJOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_DE_HIJOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONAS_GRUPO_FAMILIAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSE_DEDICA_ALGUNA_PROFESION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROFESION_SE_DEDICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO_FIJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO_MOVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCORREO_ELECTRONICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAPACITADO_PERMANENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_MOVERSE_CAMINAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_USAR_BRAZOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_VER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_OIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_HABLAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_RETRASO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_BANARSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISCAP_EXPLIQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSABE_LEER_ESCRIBIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOLO_LEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOLO_ESCRIBE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOLO_FIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEDUCACION_BASICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBACHILLERATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTECNOLOGICA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIVERSITARIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_EDUCACION_FORMAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTITULO_OBTENIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHA_DEJADO_DE_ESTUDIAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIEMPO_DEJO_ESTUDIAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHA_RECIBIDO_CURSOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMPARTIO_INSAFORP_CURSO_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMPARTIO_INSAFORP_CURSO_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMPARTIO_INSAFORP_CURSO_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANO_CURSO_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANO_CURSO_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANO_CURSO_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_LE_DIO_BENEFICIOS_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_LE_DIO_BENEFICIOS_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO_LE_DIO_BENEFICIOS_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_OBTENER_EMPLEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_CAMBIAR_EMPLEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_TRAB_CTA_PROPIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_OTROS_INGRESOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_PROMOCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORQUE_NO_RECIB_BENEFICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREALIZA_ACTIVIDAD_INGRESOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDIO_DE_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACT_INGRESOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_ACTIVIDAD_ESTUDIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_ACTIVIDAD_OFICIOS_HOGAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_ACTIVIDAD_BUSCA_TRABAJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_ACTIVIDAD_OTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_TIEMPO_COMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_NEG_FAMILIAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_MEDIO_TIEMPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_CTA_PROPIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_POR_HORAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_TEMPORAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DE_EMPLEO_OTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHA_TRABAJADO_ANTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIEMPO_QUE_NO_TRABAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_EMPRESA_ANTERIOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEDICACION_EMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_CAMBIO_TRAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_JUBILACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_RENUNCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_DESPIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_CIERRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOTIVO_SALIDA_EMPRESA_OTRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPUESTO_EMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIEMPO_TRABAJO_EMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBE_INGRESOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_TRAB_ACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_AYUDA_FAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_REMESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_PENSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_TRAB_ACT_REM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAN_OBTIENE_ING_OTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINGRESO_PERSONAL_MENSUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINGRESO_PERSONAL_DIARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQUE_GUSTARIA_APRENDER_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQUE_GUSTARIA_APRENDER_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQUE_GUSTARIA_APRENDER_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOGROS_ESPERADOS_EMPLEO_FORMAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOGROS_ESPERADOS_CUENTA_PROPIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOGROS_ESPERADOS_OTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGUSTO_UBICACION_TRABAJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_AYUDAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_INDEPEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_MANT_HIJOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_MANT_PADRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_PAGAR_ESTUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEN_QUE_OCUP_DINERO_OTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARENTESCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO_FIJO_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO_MOVIL_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACIONES_SUGERENCIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACIONES_DIGITADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_CONVOCATORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbxMunic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DeptoFaseMunicipioTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.DeptoFaseMunicipioTableAdapter
    Friend WithEvents MunicFaseMunicipioTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.MunicFaseMunicipioTableAdapter
    Friend WithEvents cbxDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DeptoFaseMunicipioDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicFaseMunicipioDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNOMBRE_DEPTO_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_DEPTO_NAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_DEPTO_RESIDENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MUNIC_CONOCIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MUNIC_NAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MUNIC_RESIDENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROYECTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PROYECTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES_SALVADORENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRVIO_CAPAC_OTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNUMEFICH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREDEPTORESIDENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREMUNICRESIDENCIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREDEPTONAC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREMUNICNAC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents field As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO1 As DevExpress.XtraPivotGrid.PivotGridField

End Class
