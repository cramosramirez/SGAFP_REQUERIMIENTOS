<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPARTICIPANTE
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
        Me.ListaPARTICIPANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPARTICIPANTEGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaPARTICIPANTEGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGENERO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryGENERO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaGENEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colColumnName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PAIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryPAIS = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaPAISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE_PAIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDUI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISSS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTIPO_DOCTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_DOCTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMOVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMAIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_ESTADO_CIVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryESTADO_CIVIL = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaESTADO_CIVILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE_ESTADO_CIVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPROFESION_OFICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOCUPACION_ACTUAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTITULO_CERTIFICADO_OBTENIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO_NAC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryDEPARTAMENTO_NAC = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaDEPARTAMENTO_NACBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO_NAC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryMUNICIPIO_NAC = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaMUNICIPIO_NACBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryDEPARTAMENTO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaDEPARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryMUNICIPIO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaMUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_NIVEL_ACADEMICO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryNIVEL_ACADEMICO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaNIVEL_ACADEMICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE_NIVEL_ACADEMICO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOTRA_EDUCACION_FORMAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCON_DISCAPACIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryDISCAPACIDAD = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ListaDISCAPACIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colColumnName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDISC_OTRA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryGENERO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGENEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryPAIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPAISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryESTADO_CIVIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaESTADO_CIVILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDEPARTAMENTO_NAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDEPARTAMENTO_NACBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryMUNICIPIO_NAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaMUNICIPIO_NACBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDEPARTAMENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryMUNICIPIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaMUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryNIVEL_ACADEMICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryDISCAPACIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDISCAPACIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPARTICIPANTEBindingSource
        '
        Me.ListaPARTICIPANTEBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE)
        '
        'ListaPARTICIPANTEGridControl
        '
        Me.ListaPARTICIPANTEGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPARTICIPANTEGridControl.DataSource = Me.ListaPARTICIPANTEBindingSource
        Me.ListaPARTICIPANTEGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaPARTICIPANTEGridControl.MainView = Me.ListaPARTICIPANTEGridView
        Me.ListaPARTICIPANTEGridControl.Name = "ListaPARTICIPANTEGridControl"
        Me.ListaPARTICIPANTEGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryPAIS, Me.RepositoryNIVEL_ACADEMICO, Me.RepositoryESTADO_CIVIL, Me.RepositoryDEPARTAMENTO, Me.RepositoryMUNICIPIO, Me.RepositoryDEPARTAMENTO_NAC, Me.RepositoryMUNICIPIO_NAC, Me.RepositoryGENERO, Me.RepositoryDISCAPACIDAD})
        Me.ListaPARTICIPANTEGridControl.Size = New System.Drawing.Size(933, 323)
        Me.ListaPARTICIPANTEGridControl.TabIndex = 1
        Me.ListaPARTICIPANTEGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaPARTICIPANTEGridView})
        '
        'ListaPARTICIPANTEGridView
        '
        Me.ListaPARTICIPANTEGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PARTICIPANTE, Me.colNOMBRES, Me.colAPELLIDOS, Me.colGENERO, Me.colID_PAIS, Me.colFECHA_NACIMIENTO, Me.colDIRECCION, Me.colDUI, Me.colNIT, Me.colISSS, Me.colTIPO_DOCTO, Me.colNUM_DOCTO, Me.colTELEFONO, Me.colMOVIL, Me.colEMAIL, Me.colID_ESTADO_CIVIL, Me.colPROFESION_OFICIO, Me.colOCUPACION_ACTUAL, Me.colTITULO_CERTIFICADO_OBTENIDO, Me.colDEPARTAMENTO_NAC, Me.colMUNICIPIO_NAC, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colID_NIVEL_ACADEMICO, Me.colOTRA_EDUCACION_FORMAL, Me.colCON_DISCAPACIDAD, Me.colDISC_OTRA, Me.colLASTUPDATE, Me.colUSERID})
        Me.ListaPARTICIPANTEGridView.GridControl = Me.ListaPARTICIPANTEGridControl
        Me.ListaPARTICIPANTEGridView.Name = "ListaPARTICIPANTEGridView"
        Me.ListaPARTICIPANTEGridView.OptionsDetail.EnableMasterViewMode = False
        Me.ListaPARTICIPANTEGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.Caption = "Id participante"
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Visible = True
        Me.colID_PARTICIPANTE.VisibleIndex = 0
        Me.colID_PARTICIPANTE.Width = 33
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Caption = "Nombres"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Visible = True
        Me.colNOMBRES.VisibleIndex = 1
        Me.colNOMBRES.Width = 30
        '
        'colAPELLIDOS
        '
        Me.colAPELLIDOS.Caption = "Apellidos"
        Me.colAPELLIDOS.FieldName = "APELLIDOS"
        Me.colAPELLIDOS.Name = "colAPELLIDOS"
        Me.colAPELLIDOS.Visible = True
        Me.colAPELLIDOS.VisibleIndex = 2
        Me.colAPELLIDOS.Width = 30
        '
        'colGENERO
        '
        Me.colGENERO.Caption = "Genero"
        Me.colGENERO.ColumnEdit = Me.RepositoryGENERO
        Me.colGENERO.FieldName = "GENERO"
        Me.colGENERO.Name = "colGENERO"
        Me.colGENERO.Visible = True
        Me.colGENERO.VisibleIndex = 3
        Me.colGENERO.Width = 24
        '
        'RepositoryGENERO
        '
        Me.RepositoryGENERO.AutoHeight = False
        Me.RepositoryGENERO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryGENERO.DataSource = Me.ListaGENEROBindingSource
        Me.RepositoryGENERO.DisplayMember = "ColumnName"
        Me.RepositoryGENERO.Name = "RepositoryGENERO"
        Me.RepositoryGENERO.ValueMember = "DataValue"
        Me.RepositoryGENERO.View = Me.GridView9
        Me.RepositoryGENERO.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaGENEROBindingSource
        '
        Me.ListaGENEROBindingSource.DataSource = GetType(SGAFP.EL.Criteria)
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumnName})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colColumnName
        '
        Me.colColumnName.Caption = "Género"
        Me.colColumnName.FieldName = "ColumnName"
        Me.colColumnName.Name = "colColumnName"
        Me.colColumnName.Visible = True
        Me.colColumnName.VisibleIndex = 0
        Me.colColumnName.Width = 120
        '
        'colID_PAIS
        '
        Me.colID_PAIS.Caption = "Id pais"
        Me.colID_PAIS.ColumnEdit = Me.RepositoryPAIS
        Me.colID_PAIS.FieldName = "ID_PAIS"
        Me.colID_PAIS.Name = "colID_PAIS"
        Me.colID_PAIS.Visible = True
        Me.colID_PAIS.VisibleIndex = 4
        Me.colID_PAIS.Width = 24
        '
        'RepositoryPAIS
        '
        Me.RepositoryPAIS.AutoHeight = False
        Me.RepositoryPAIS.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryPAIS.DataSource = Me.ListaPAISBindingSource
        Me.RepositoryPAIS.DisplayMember = "NOMBRE_PAIS"
        Me.RepositoryPAIS.Name = "RepositoryPAIS"
        Me.RepositoryPAIS.ValueMember = "ID_PAIS"
        Me.RepositoryPAIS.View = Me.GridView1
        Me.RepositoryPAIS.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaPAISBindingSource
        '
        Me.ListaPAISBindingSource.DataSource = GetType(SGAFP.EL.PAIS)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_PAIS})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_PAIS, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNOMBRE_PAIS
        '
        Me.colNOMBRE_PAIS.Caption = "País"
        Me.colNOMBRE_PAIS.FieldName = "NOMBRE_PAIS"
        Me.colNOMBRE_PAIS.Name = "colNOMBRE_PAIS"
        Me.colNOMBRE_PAIS.Visible = True
        Me.colNOMBRE_PAIS.VisibleIndex = 0
        Me.colNOMBRE_PAIS.Width = 120
        '
        'colFECHA_NACIMIENTO
        '
        Me.colFECHA_NACIMIENTO.Caption = "Fecha nacimiento"
        Me.colFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.Name = "colFECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.Visible = True
        Me.colFECHA_NACIMIENTO.VisibleIndex = 5
        Me.colFECHA_NACIMIENTO.Width = 24
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "Direccion"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 6
        Me.colDIRECCION.Width = 24
        '
        'colDUI
        '
        Me.colDUI.Caption = "Dui"
        Me.colDUI.FieldName = "DUI"
        Me.colDUI.Name = "colDUI"
        Me.colDUI.Visible = True
        Me.colDUI.VisibleIndex = 7
        Me.colDUI.Width = 24
        '
        'colNIT
        '
        Me.colNIT.Caption = "Nit"
        Me.colNIT.FieldName = "NIT"
        Me.colNIT.Name = "colNIT"
        Me.colNIT.Visible = True
        Me.colNIT.VisibleIndex = 8
        Me.colNIT.Width = 24
        '
        'colISSS
        '
        Me.colISSS.Caption = "Isss"
        Me.colISSS.FieldName = "ISSS"
        Me.colISSS.Name = "colISSS"
        Me.colISSS.Visible = True
        Me.colISSS.VisibleIndex = 9
        Me.colISSS.Width = 24
        '
        'colTIPO_DOCTO
        '
        Me.colTIPO_DOCTO.Caption = "Tipo docto"
        Me.colTIPO_DOCTO.FieldName = "TIPO_DOCTO"
        Me.colTIPO_DOCTO.Name = "colTIPO_DOCTO"
        Me.colTIPO_DOCTO.Visible = True
        Me.colTIPO_DOCTO.VisibleIndex = 10
        Me.colTIPO_DOCTO.Width = 24
        '
        'colNUM_DOCTO
        '
        Me.colNUM_DOCTO.Caption = "Num docto"
        Me.colNUM_DOCTO.FieldName = "NUM_DOCTO"
        Me.colNUM_DOCTO.Name = "colNUM_DOCTO"
        Me.colNUM_DOCTO.Visible = True
        Me.colNUM_DOCTO.VisibleIndex = 11
        Me.colNUM_DOCTO.Width = 24
        '
        'colTELEFONO
        '
        Me.colTELEFONO.Caption = "Telefono"
        Me.colTELEFONO.FieldName = "TELEFONO"
        Me.colTELEFONO.Name = "colTELEFONO"
        Me.colTELEFONO.Visible = True
        Me.colTELEFONO.VisibleIndex = 12
        Me.colTELEFONO.Width = 24
        '
        'colMOVIL
        '
        Me.colMOVIL.Caption = "Movil"
        Me.colMOVIL.FieldName = "MOVIL"
        Me.colMOVIL.Name = "colMOVIL"
        Me.colMOVIL.Visible = True
        Me.colMOVIL.VisibleIndex = 13
        Me.colMOVIL.Width = 24
        '
        'colEMAIL
        '
        Me.colEMAIL.Caption = "Email"
        Me.colEMAIL.FieldName = "EMAIL"
        Me.colEMAIL.Name = "colEMAIL"
        Me.colEMAIL.Visible = True
        Me.colEMAIL.VisibleIndex = 14
        Me.colEMAIL.Width = 24
        '
        'colID_ESTADO_CIVIL
        '
        Me.colID_ESTADO_CIVIL.Caption = "Id estado civil"
        Me.colID_ESTADO_CIVIL.ColumnEdit = Me.RepositoryESTADO_CIVIL
        Me.colID_ESTADO_CIVIL.FieldName = "ID_ESTADO_CIVIL"
        Me.colID_ESTADO_CIVIL.Name = "colID_ESTADO_CIVIL"
        Me.colID_ESTADO_CIVIL.Visible = True
        Me.colID_ESTADO_CIVIL.VisibleIndex = 15
        Me.colID_ESTADO_CIVIL.Width = 24
        '
        'RepositoryESTADO_CIVIL
        '
        Me.RepositoryESTADO_CIVIL.AutoHeight = False
        Me.RepositoryESTADO_CIVIL.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryESTADO_CIVIL.DataSource = Me.ListaESTADO_CIVILBindingSource
        Me.RepositoryESTADO_CIVIL.DisplayMember = "NOMBRE_ESTADO_CIVIL"
        Me.RepositoryESTADO_CIVIL.Name = "RepositoryESTADO_CIVIL"
        Me.RepositoryESTADO_CIVIL.ValueMember = "ID_ESTADO_CIVIL"
        Me.RepositoryESTADO_CIVIL.View = Me.GridView3
        Me.RepositoryESTADO_CIVIL.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaESTADO_CIVILBindingSource
        '
        Me.ListaESTADO_CIVILBindingSource.DataSource = GetType(SGAFP.EL.ESTADO_CIVIL)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_ESTADO_CIVIL})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE_ESTADO_CIVIL
        '
        Me.colNOMBRE_ESTADO_CIVIL.Caption = "Estado Civil"
        Me.colNOMBRE_ESTADO_CIVIL.FieldName = "NOMBRE_ESTADO_CIVIL"
        Me.colNOMBRE_ESTADO_CIVIL.Name = "colNOMBRE_ESTADO_CIVIL"
        Me.colNOMBRE_ESTADO_CIVIL.Visible = True
        Me.colNOMBRE_ESTADO_CIVIL.VisibleIndex = 0
        Me.colNOMBRE_ESTADO_CIVIL.Width = 120
        '
        'colPROFESION_OFICIO
        '
        Me.colPROFESION_OFICIO.Caption = "Profesion oficio"
        Me.colPROFESION_OFICIO.FieldName = "PROFESION_OFICIO"
        Me.colPROFESION_OFICIO.Name = "colPROFESION_OFICIO"
        Me.colPROFESION_OFICIO.Visible = True
        Me.colPROFESION_OFICIO.VisibleIndex = 16
        Me.colPROFESION_OFICIO.Width = 24
        '
        'colOCUPACION_ACTUAL
        '
        Me.colOCUPACION_ACTUAL.Caption = "Ocupacion actual"
        Me.colOCUPACION_ACTUAL.FieldName = "OCUPACION_ACTUAL"
        Me.colOCUPACION_ACTUAL.Name = "colOCUPACION_ACTUAL"
        Me.colOCUPACION_ACTUAL.Visible = True
        Me.colOCUPACION_ACTUAL.VisibleIndex = 17
        Me.colOCUPACION_ACTUAL.Width = 24
        '
        'colTITULO_CERTIFICADO_OBTENIDO
        '
        Me.colTITULO_CERTIFICADO_OBTENIDO.Caption = "Titulo certificado obtenido"
        Me.colTITULO_CERTIFICADO_OBTENIDO.FieldName = "TITULO_CERTIFICADO_OBTENIDO"
        Me.colTITULO_CERTIFICADO_OBTENIDO.Name = "colTITULO_CERTIFICADO_OBTENIDO"
        Me.colTITULO_CERTIFICADO_OBTENIDO.Visible = True
        Me.colTITULO_CERTIFICADO_OBTENIDO.VisibleIndex = 18
        Me.colTITULO_CERTIFICADO_OBTENIDO.Width = 24
        '
        'colDEPARTAMENTO_NAC
        '
        Me.colDEPARTAMENTO_NAC.Caption = "Departamento Nacimiento"
        Me.colDEPARTAMENTO_NAC.ColumnEdit = Me.RepositoryDEPARTAMENTO_NAC
        Me.colDEPARTAMENTO_NAC.FieldName = "DEPARTAMENTO_NAC"
        Me.colDEPARTAMENTO_NAC.Name = "colDEPARTAMENTO_NAC"
        Me.colDEPARTAMENTO_NAC.Visible = True
        Me.colDEPARTAMENTO_NAC.VisibleIndex = 19
        Me.colDEPARTAMENTO_NAC.Width = 24
        '
        'RepositoryDEPARTAMENTO_NAC
        '
        Me.RepositoryDEPARTAMENTO_NAC.AutoHeight = False
        Me.RepositoryDEPARTAMENTO_NAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDEPARTAMENTO_NAC.DataSource = Me.ListaDEPARTAMENTO_NACBindingSource
        Me.RepositoryDEPARTAMENTO_NAC.DisplayMember = "NOMBRE"
        Me.RepositoryDEPARTAMENTO_NAC.Name = "RepositoryDEPARTAMENTO_NAC"
        Me.RepositoryDEPARTAMENTO_NAC.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.RepositoryDEPARTAMENTO_NAC.View = Me.GridView5
        Me.RepositoryDEPARTAMENTO_NAC.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaDEPARTAMENTO_NACBindingSource
        '
        Me.ListaDEPARTAMENTO_NACBindingSource.DataSource = GetType(SGAFP.EL.DEPARTAMENTO)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE2})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE2
        '
        Me.colNOMBRE2.Caption = "Departamento Nacimiento"
        Me.colNOMBRE2.FieldName = "NOMBRE"
        Me.colNOMBRE2.Name = "colNOMBRE2"
        Me.colNOMBRE2.Visible = True
        Me.colNOMBRE2.VisibleIndex = 0
        Me.colNOMBRE2.Width = 120
        '
        'colMUNICIPIO_NAC
        '
        Me.colMUNICIPIO_NAC.Caption = "Municipio Nacimiento"
        Me.colMUNICIPIO_NAC.ColumnEdit = Me.RepositoryMUNICIPIO_NAC
        Me.colMUNICIPIO_NAC.FieldName = "MUNICIPIO_NAC"
        Me.colMUNICIPIO_NAC.Name = "colMUNICIPIO_NAC"
        Me.colMUNICIPIO_NAC.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colMUNICIPIO_NAC.Visible = True
        Me.colMUNICIPIO_NAC.VisibleIndex = 20
        Me.colMUNICIPIO_NAC.Width = 24
        '
        'RepositoryMUNICIPIO_NAC
        '
        Me.RepositoryMUNICIPIO_NAC.AutoHeight = False
        Me.RepositoryMUNICIPIO_NAC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryMUNICIPIO_NAC.DataSource = Me.ListaMUNICIPIO_NACBindingSource
        Me.RepositoryMUNICIPIO_NAC.DisplayMember = "NOMBRE"
        Me.RepositoryMUNICIPIO_NAC.Name = "RepositoryMUNICIPIO_NAC"
        Me.RepositoryMUNICIPIO_NAC.ValueMember = "CODIGO_MUNICIPIO"
        Me.RepositoryMUNICIPIO_NAC.View = Me.GridView6
        Me.RepositoryMUNICIPIO_NAC.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaMUNICIPIO_NACBindingSource
        '
        Me.ListaMUNICIPIO_NACBindingSource.DataSource = GetType(SGAFP.EL.MUNICIPIO)
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE1})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE1
        '
        Me.colNOMBRE1.Caption = "Municipio Nacimiento"
        Me.colNOMBRE1.FieldName = "NOMBRE"
        Me.colNOMBRE1.Name = "colNOMBRE1"
        Me.colNOMBRE1.Visible = True
        Me.colNOMBRE1.VisibleIndex = 0
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.Caption = "Departamento Residencia"
        Me.colCODIGO_DEPARTAMENTO.ColumnEdit = Me.RepositoryDEPARTAMENTO
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Visible = True
        Me.colCODIGO_DEPARTAMENTO.VisibleIndex = 21
        Me.colCODIGO_DEPARTAMENTO.Width = 24
        '
        'RepositoryDEPARTAMENTO
        '
        Me.RepositoryDEPARTAMENTO.AutoHeight = False
        Me.RepositoryDEPARTAMENTO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDEPARTAMENTO.DataSource = Me.ListaDEPARTAMENTOBindingSource
        Me.RepositoryDEPARTAMENTO.DisplayMember = "NOMBRE"
        Me.RepositoryDEPARTAMENTO.Name = "RepositoryDEPARTAMENTO"
        Me.RepositoryDEPARTAMENTO.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.RepositoryDEPARTAMENTO.View = Me.GridView4
        Me.RepositoryDEPARTAMENTO.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaDEPARTAMENTOBindingSource
        '
        Me.ListaDEPARTAMENTOBindingSource.DataSource = GetType(SGAFP.EL.DEPARTAMENTO)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Departamento Residencia"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 0
        Me.colNOMBRE.Width = 120
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.Caption = "Municipio Residencia"
        Me.colCODIGO_MUNICIPIO.ColumnEdit = Me.RepositoryMUNICIPIO
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colCODIGO_MUNICIPIO.Visible = True
        Me.colCODIGO_MUNICIPIO.VisibleIndex = 22
        Me.colCODIGO_MUNICIPIO.Width = 24
        '
        'RepositoryMUNICIPIO
        '
        Me.RepositoryMUNICIPIO.AutoHeight = False
        Me.RepositoryMUNICIPIO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryMUNICIPIO.DataSource = Me.ListaMUNICIPIOBindingSource
        Me.RepositoryMUNICIPIO.DisplayMember = "NOMBRE"
        Me.RepositoryMUNICIPIO.Name = "RepositoryMUNICIPIO"
        Me.RepositoryMUNICIPIO.ValueMember = "CODIGO_MUNICIPIO"
        Me.RepositoryMUNICIPIO.View = Me.GridView7
        Me.RepositoryMUNICIPIO.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaMUNICIPIOBindingSource
        '
        Me.ListaMUNICIPIOBindingSource.DataSource = GetType(SGAFP.EL.MUNICIPIO)
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE3})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE3
        '
        Me.colNOMBRE3.Caption = "Municipio Residencia"
        Me.colNOMBRE3.FieldName = "NOMBRE"
        Me.colNOMBRE3.Name = "colNOMBRE3"
        Me.colNOMBRE3.Visible = True
        Me.colNOMBRE3.VisibleIndex = 0
        '
        'colID_NIVEL_ACADEMICO
        '
        Me.colID_NIVEL_ACADEMICO.Caption = "Id nivel academico"
        Me.colID_NIVEL_ACADEMICO.ColumnEdit = Me.RepositoryNIVEL_ACADEMICO
        Me.colID_NIVEL_ACADEMICO.FieldName = "ID_NIVEL_ACADEMICO"
        Me.colID_NIVEL_ACADEMICO.Name = "colID_NIVEL_ACADEMICO"
        Me.colID_NIVEL_ACADEMICO.Visible = True
        Me.colID_NIVEL_ACADEMICO.VisibleIndex = 23
        Me.colID_NIVEL_ACADEMICO.Width = 24
        '
        'RepositoryNIVEL_ACADEMICO
        '
        Me.RepositoryNIVEL_ACADEMICO.AutoHeight = False
        Me.RepositoryNIVEL_ACADEMICO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryNIVEL_ACADEMICO.DataSource = Me.ListaNIVEL_ACADEMICOBindingSource
        Me.RepositoryNIVEL_ACADEMICO.DisplayMember = "NOMBRE_NIVEL_ACADEMICO"
        Me.RepositoryNIVEL_ACADEMICO.Name = "RepositoryNIVEL_ACADEMICO"
        Me.RepositoryNIVEL_ACADEMICO.ValueMember = "ID_NIVEL_ACADEMICO"
        Me.RepositoryNIVEL_ACADEMICO.View = Me.GridView2
        Me.RepositoryNIVEL_ACADEMICO.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaNIVEL_ACADEMICOBindingSource
        '
        Me.ListaNIVEL_ACADEMICOBindingSource.DataSource = GetType(SGAFP.EL.NIVEL_ACADEMICO)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_NIVEL_ACADEMICO})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE_NIVEL_ACADEMICO
        '
        Me.colNOMBRE_NIVEL_ACADEMICO.Caption = "Nivel Académico"
        Me.colNOMBRE_NIVEL_ACADEMICO.FieldName = "NOMBRE_NIVEL_ACADEMICO"
        Me.colNOMBRE_NIVEL_ACADEMICO.Name = "colNOMBRE_NIVEL_ACADEMICO"
        Me.colNOMBRE_NIVEL_ACADEMICO.Visible = True
        Me.colNOMBRE_NIVEL_ACADEMICO.VisibleIndex = 0
        Me.colNOMBRE_NIVEL_ACADEMICO.Width = 120
        '
        'colOTRA_EDUCACION_FORMAL
        '
        Me.colOTRA_EDUCACION_FORMAL.Caption = "Otra educacion formal"
        Me.colOTRA_EDUCACION_FORMAL.FieldName = "OTRA_EDUCACION_FORMAL"
        Me.colOTRA_EDUCACION_FORMAL.Name = "colOTRA_EDUCACION_FORMAL"
        Me.colOTRA_EDUCACION_FORMAL.Visible = True
        Me.colOTRA_EDUCACION_FORMAL.VisibleIndex = 24
        Me.colOTRA_EDUCACION_FORMAL.Width = 24
        '
        'colCON_DISCAPACIDAD
        '
        Me.colCON_DISCAPACIDAD.Caption = "Con discapacidad"
        Me.colCON_DISCAPACIDAD.ColumnEdit = Me.RepositoryDISCAPACIDAD
        Me.colCON_DISCAPACIDAD.FieldName = "CON_DISCAPACIDAD"
        Me.colCON_DISCAPACIDAD.Name = "colCON_DISCAPACIDAD"
        Me.colCON_DISCAPACIDAD.Visible = True
        Me.colCON_DISCAPACIDAD.VisibleIndex = 25
        Me.colCON_DISCAPACIDAD.Width = 24
        '
        'RepositoryDISCAPACIDAD
        '
        Me.RepositoryDISCAPACIDAD.AutoHeight = False
        Me.RepositoryDISCAPACIDAD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryDISCAPACIDAD.DataSource = Me.ListaDISCAPACIDADBindingSource
        Me.RepositoryDISCAPACIDAD.DisplayMember = "ColumnName"
        Me.RepositoryDISCAPACIDAD.Name = "RepositoryDISCAPACIDAD"
        Me.RepositoryDISCAPACIDAD.ValueMember = "DataValue"
        Me.RepositoryDISCAPACIDAD.View = Me.GridView8
        Me.RepositoryDISCAPACIDAD.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ListaDISCAPACIDADBindingSource
        '
        Me.ListaDISCAPACIDADBindingSource.DataSource = GetType(SGAFP.EL.Criteria)
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumnName1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colColumnName1
        '
        Me.colColumnName1.Caption = "Discapacidad"
        Me.colColumnName1.FieldName = "ColumnName"
        Me.colColumnName1.Name = "colColumnName1"
        Me.colColumnName1.Visible = True
        Me.colColumnName1.VisibleIndex = 0
        '
        'colDISC_OTRA
        '
        Me.colDISC_OTRA.Caption = "Disc otra"
        Me.colDISC_OTRA.FieldName = "DISC_OTRA"
        Me.colDISC_OTRA.Name = "colDISC_OTRA"
        Me.colDISC_OTRA.Visible = True
        Me.colDISC_OTRA.VisibleIndex = 26
        Me.colDISC_OTRA.Width = 24
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 27
        Me.colLASTUPDATE.Width = 24
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 28
        Me.colUSERID.Width = 222
        '
        'ucListaPARTICIPANTE
        '
        Me.Controls.Add(Me.ListaPARTICIPANTEGridControl)
        Me.Name = "ucListaPARTICIPANTE"
        Me.Size = New System.Drawing.Size(939, 354)
        Me.Controls.SetChildIndex(Me.ListaPARTICIPANTEGridControl, 0)
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryGENERO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGENEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryPAIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPAISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryESTADO_CIVIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaESTADO_CIVILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDEPARTAMENTO_NAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDEPARTAMENTO_NACBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryMUNICIPIO_NAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaMUNICIPIO_NACBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDEPARTAMENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryMUNICIPIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaMUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryNIVEL_ACADEMICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryDISCAPACIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDISCAPACIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPARTICIPANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPARTICIPANTEGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaPARTICIPANTEGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGENERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDUI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ESTADO_CIVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROFESION_OFICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCUPACION_ACTUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTITULO_CERTIFICADO_OBTENIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO_NAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO_NAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_NIVEL_ACADEMICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_EDUCACION_FORMAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCON_DISCAPACIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISC_OTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListaPAISBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaESTADO_CIVILBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaNIVEL_ACADEMICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaDEPARTAMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryPAIS As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE_PAIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryNIVEL_ACADEMICO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE_NIVEL_ACADEMICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryESTADO_CIVIL As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE_ESTADO_CIVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDEPARTAMENTO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryMUNICIPIO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ListaMUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaDEPARTAMENTO_NACBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryDEPARTAMENTO_NAC As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNOMBRE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryMUNICIPIO_NAC As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ListaMUNICIPIO_NACBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ListaGENEROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaDISCAPACIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryGENERO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColumnName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryDISCAPACIDAD As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColumnName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE3 As DevExpress.XtraGrid.Columns.GridColumn

End Class
