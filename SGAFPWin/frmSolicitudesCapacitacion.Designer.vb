<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudesCapacitacion
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.bsPatiEjecucion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.txtTDR = New DevExpress.XtraEditors.TextEdit
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.PatiEjecucionTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.PATIEjecucionTableAdapter
        Me.CbxUNIDAD_ORGANIZATIVA1 = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.CbxREFERENTE1 = New SGAFP.WinUC.cbxREFERENTE
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.dteFechaSolicitud = New DevExpress.XtraEditors.DateEdit
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.CbxPROYECTO_FORMACION1 = New SGAFP.WinUC.cbxPROYECTO_FORMACION
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.ListaSOLICITUD_CAPACITACIONGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaGRUPO_SOLICITUDGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_MODALIDAD_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMODALIDAD_FORMACION1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PROGRAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnombre_programa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcodigo_programa1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDURACION_HORAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_PARTICIPANTES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ListaSOLICITUD_CAPACITACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUNIDAD_ORGANIZATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPROYECTO_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_UNIDAD_ORGANIZATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROYECTO_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOBJETIVO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF_MOVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFAX = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRES_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDOS_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMAIL_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPatiEjecucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTDR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaSolicitud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSOLICITUD_CAPACITACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_SOLICITUDGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSOLICITUD_CAPACITACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1127, 95)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1127, 95)
        Me.LayoutControlGroup2.Text = "Root"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1127, 95)
        Me.LayoutControlGroup3.Text = "Root"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'bsPatiEjecucion
        '
        Me.bsPatiEjecucion.DataMember = "PATIEjecucion"
        Me.bsPatiEjecucion.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup6.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(441, 117)
        Me.LayoutControlGroup6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup6.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup7.GroupBordersVisible = False
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "Root"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(967, 95)
        Me.LayoutControlGroup7.Text = "Root"
        Me.LayoutControlGroup7.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxPROYECTO_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.dteFechaSolicitud)
        Me.LayoutControl1.Controls.Add(Me.CbxREFERENTE1)
        Me.LayoutControl1.Controls.Add(Me.CbxUNIDAD_ORGANIZATIVA1)
        Me.LayoutControl1.Controls.Add(Me.txtTDR)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup7
        Me.LayoutControl1.Size = New System.Drawing.Size(967, 95)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTDR
        '
        Me.txtTDR.Location = New System.Drawing.Point(774, 12)
        Me.txtTDR.Name = "txtTDR"
        Me.txtTDR.Size = New System.Drawing.Size(181, 20)
        Me.txtTDR.StyleController = Me.LayoutControl1
        Me.txtTDR.TabIndex = 7
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtTDR
        Me.LayoutControlItem9.CustomizationFormText = "TDR"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(650, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(297, 24)
        Me.LayoutControlItem9.Text = "Término de Referencia"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(108, 13)
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
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListaSOLICITUD_CAPACITACIONGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(967, 482)
        Me.SplitContainerControl1.SplitterPosition = 95
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'PatiEjecucionTableAdapter1
        '
        Me.PatiEjecucionTableAdapter1.ClearBeforeFill = True
        '
        'CbxUNIDAD_ORGANIZATIVA1
        '
        Me.CbxUNIDAD_ORGANIZATIVA1.AllowFindEntityType = Nothing
        Me.CbxUNIDAD_ORGANIZATIVA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(124, 12)
        Me.CbxUNIDAD_ORGANIZATIVA1.Name = "CbxUNIDAD_ORGANIZATIVA1"
        Me.CbxUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(534, 21)
        Me.CbxUNIDAD_ORGANIZATIVA1.TabIndex = 10
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CbxUNIDAD_ORGANIZATIVA1
        Me.LayoutControlItem6.CustomizationFormText = "Unidad Organizativa"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem6.Text = "Unidad Organizativa"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(108, 13)
        '
        'CbxREFERENTE1
        '
        Me.CbxREFERENTE1.AllowFindEntityType = Nothing
        Me.CbxREFERENTE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxREFERENTE1.Location = New System.Drawing.Point(124, 37)
        Me.CbxREFERENTE1.Name = "CbxREFERENTE1"
        Me.CbxREFERENTE1.Size = New System.Drawing.Size(534, 21)
        Me.CbxREFERENTE1.TabIndex = 11
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CbxREFERENTE1
        Me.LayoutControlItem7.CustomizationFormText = "Referente"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(650, 25)
        Me.LayoutControlItem7.Text = "Referente"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(108, 13)
        '
        'dteFechaSolicitud
        '
        Me.dteFechaSolicitud.EditValue = Nothing
        Me.dteFechaSolicitud.Location = New System.Drawing.Point(774, 36)
        Me.dteFechaSolicitud.Name = "dteFechaSolicitud"
        Me.dteFechaSolicitud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaSolicitud.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteFechaSolicitud.Size = New System.Drawing.Size(181, 20)
        Me.dteFechaSolicitud.StyleController = Me.LayoutControl1
        Me.dteFechaSolicitud.TabIndex = 12
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dteFechaSolicitud
        Me.LayoutControlItem8.CustomizationFormText = "Fecha Solicitud"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(650, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(297, 26)
        Me.LayoutControlItem8.Text = "Fecha Solicitud"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(108, 13)
        '
        'CbxPROYECTO_FORMACION1
        '
        Me.CbxPROYECTO_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROYECTO_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROYECTO_FORMACION1.Location = New System.Drawing.Point(124, 62)
        Me.CbxPROYECTO_FORMACION1.Name = "CbxPROYECTO_FORMACION1"
        Me.CbxPROYECTO_FORMACION1.Size = New System.Drawing.Size(831, 21)
        Me.CbxPROYECTO_FORMACION1.TabIndex = 13
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CbxPROYECTO_FORMACION1
        Me.LayoutControlItem10.CustomizationFormText = "Proyecto"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(947, 25)
        Me.LayoutControlItem10.Text = "Proyecto"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(108, 13)
        '
        'ListaSOLICITUD_CAPACITACIONGridControl
        '
        Me.ListaSOLICITUD_CAPACITACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSOLICITUD_CAPACITACIONGridControl.DataMember = Nothing
        GridLevelNode2.LevelTemplate = Me.ListaGRUPO_SOLICITUDGridView
        GridLevelNode2.RelationName = "GRUPO_SOLICITUD_SOLICITUD_CAPACITACION"
        Me.ListaSOLICITUD_CAPACITACIONGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.ListaSOLICITUD_CAPACITACIONGridControl.Location = New System.Drawing.Point(2, 30)
        Me.ListaSOLICITUD_CAPACITACIONGridControl.MainView = Me.ListaSOLICITUD_CAPACITACIONGridView
        Me.ListaSOLICITUD_CAPACITACIONGridControl.Name = "ListaSOLICITUD_CAPACITACIONGridControl"
        Me.ListaSOLICITUD_CAPACITACIONGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.ListaSOLICITUD_CAPACITACIONGridControl.Size = New System.Drawing.Size(963, 323)
        Me.ListaSOLICITUD_CAPACITACIONGridControl.TabIndex = 2
        Me.ListaSOLICITUD_CAPACITACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaGRUPO_SOLICITUDGridView, Me.ListaSOLICITUD_CAPACITACIONGridView})
        '
        'ListaGRUPO_SOLICITUDGridView
        '
        Me.ListaGRUPO_SOLICITUDGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_MODALIDAD_FORMACION, Me.colCODIGO_PROGRAMA, Me.colDURACION_HORAS, Me.colNUM_PARTICIPANTES, Me.colTDR})
        Me.ListaGRUPO_SOLICITUDGridView.GridControl = Me.ListaSOLICITUD_CAPACITACIONGridControl
        Me.ListaGRUPO_SOLICITUDGridView.Name = "ListaGRUPO_SOLICITUDGridView"
        Me.ListaGRUPO_SOLICITUDGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_MODALIDAD_FORMACION
        '
        Me.colID_MODALIDAD_FORMACION.Caption = "Modalidad Formación"
        Me.colID_MODALIDAD_FORMACION.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colID_MODALIDAD_FORMACION.FieldName = "ID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Name = "colID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Visible = True
        Me.colID_MODALIDAD_FORMACION.VisibleIndex = 0
        Me.colID_MODALIDAD_FORMACION.Width = 80
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "MODALIDAD_FORMACION"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "ID_MODALIDAD_FORMACION"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        Me.RepositoryItemGridLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMODALIDAD_FORMACION1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMODALIDAD_FORMACION1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colMODALIDAD_FORMACION1
        '
        Me.colMODALIDAD_FORMACION1.Caption = "Modalidad de Formación"
        Me.colMODALIDAD_FORMACION1.FieldName = "MODALIDAD_FORMACION"
        Me.colMODALIDAD_FORMACION1.Name = "colMODALIDAD_FORMACION1"
        Me.colMODALIDAD_FORMACION1.OptionsColumn.AllowEdit = False
        Me.colMODALIDAD_FORMACION1.OptionsColumn.ReadOnly = True
        Me.colMODALIDAD_FORMACION1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colMODALIDAD_FORMACION1.Visible = True
        Me.colMODALIDAD_FORMACION1.VisibleIndex = 0
        Me.colMODALIDAD_FORMACION1.Width = 300
        '
        'colCODIGO_PROGRAMA
        '
        Me.colCODIGO_PROGRAMA.Caption = "Programa"
        Me.colCODIGO_PROGRAMA.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colCODIGO_PROGRAMA.FieldName = "CODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Name = "colCODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Visible = True
        Me.colCODIGO_PROGRAMA.VisibleIndex = 1
        Me.colCODIGO_PROGRAMA.Width = 96
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "nombre_programa"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = "[Seleccione programa...l]"
        Me.RepositoryItemGridLookUpEdit2.PopupFormSize = New System.Drawing.Size(680, 0)
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "codigo_programa"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView1
        Me.RepositoryItemGridLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnombre_programa, Me.colcodigo_programa1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colnombre_programa, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colnombre_programa
        '
        Me.colnombre_programa.Caption = "Nombre Programa"
        Me.colnombre_programa.FieldName = "nombre_programa"
        Me.colnombre_programa.Name = "colnombre_programa"
        Me.colnombre_programa.OptionsColumn.AllowEdit = False
        Me.colnombre_programa.OptionsColumn.ReadOnly = True
        Me.colnombre_programa.Visible = True
        Me.colnombre_programa.VisibleIndex = 0
        Me.colnombre_programa.Width = 300
        '
        'colcodigo_programa1
        '
        Me.colcodigo_programa1.Caption = "Codigo"
        Me.colcodigo_programa1.FieldName = "codigo_programa"
        Me.colcodigo_programa1.Name = "colcodigo_programa1"
        Me.colcodigo_programa1.OptionsColumn.AllowEdit = False
        Me.colcodigo_programa1.OptionsColumn.ReadOnly = True
        Me.colcodigo_programa1.Visible = True
        Me.colcodigo_programa1.VisibleIndex = 1
        Me.colcodigo_programa1.Width = 84
        '
        'colDURACION_HORAS
        '
        Me.colDURACION_HORAS.Caption = "Duración (horas)"
        Me.colDURACION_HORAS.FieldName = "DURACION_HORAS"
        Me.colDURACION_HORAS.Name = "colDURACION_HORAS"
        Me.colDURACION_HORAS.Visible = True
        Me.colDURACION_HORAS.VisibleIndex = 2
        Me.colDURACION_HORAS.Width = 92
        '
        'colNUM_PARTICIPANTES
        '
        Me.colNUM_PARTICIPANTES.Caption = "Cantidad Participantes"
        Me.colNUM_PARTICIPANTES.FieldName = "NUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.Name = "colNUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.Visible = True
        Me.colNUM_PARTICIPANTES.VisibleIndex = 3
        Me.colNUM_PARTICIPANTES.Width = 86
        '
        'colTDR
        '
        Me.colTDR.FieldName = "TDR"
        Me.colTDR.Name = "colTDR"
        Me.colTDR.OptionsColumn.AllowEdit = False
        Me.colTDR.Visible = True
        Me.colTDR.VisibleIndex = 4
        '
        'ListaSOLICITUD_CAPACITACIONGridView
        '
        Me.ListaSOLICITUD_CAPACITACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_SOLICITUD, Me.colFECHA_SOLICITUD, Me.colCENTRO_RESPONSABILIDAD, Me.colUNIDAD_ORGANIZATIVA, Me.colPROGRAMA_FORMACION, Me.colPROYECTO_FORMACION, Me.colHORARIO, Me.colID_REFERENTE, Me.colID_CENTRO_RESPONSABILIDAD, Me.colID_UNIDAD_ORGANIZATIVA, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colID_PROGRAMA_FORMACION, Me.colID_PROYECTO_FORMACION, Me.colOBJETIVO_CAPACITACION, Me.colDIRECCION_REFERENTE, Me.colTELEF1, Me.colTELEF2, Me.colTELEF3, Me.colTELEF_MOVIL, Me.colFAX, Me.colNOMBRES_CONTACTO, Me.colAPELLIDOS_CONTACTO, Me.colEMAIL_CONTACTO, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaSOLICITUD_CAPACITACIONGridView.GridControl = Me.ListaSOLICITUD_CAPACITACIONGridControl
        Me.ListaSOLICITUD_CAPACITACIONGridView.Name = "ListaSOLICITUD_CAPACITACIONGridView"
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsBehavior.Editable = False
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsDetail.AllowExpandEmptyDetails = True
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.ListaSOLICITUD_CAPACITACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.Caption = "Id solicitud"
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        Me.colID_SOLICITUD.Visible = True
        Me.colID_SOLICITUD.VisibleIndex = 0
        Me.colID_SOLICITUD.Width = 70
        '
        'colFECHA_SOLICITUD
        '
        Me.colFECHA_SOLICITUD.Caption = "Fecha solicitud"
        Me.colFECHA_SOLICITUD.FieldName = "FECHA_SOLICITUD"
        Me.colFECHA_SOLICITUD.Name = "colFECHA_SOLICITUD"
        Me.colFECHA_SOLICITUD.Visible = True
        Me.colFECHA_SOLICITUD.VisibleIndex = 1
        Me.colFECHA_SOLICITUD.Width = 70
        '
        'colCENTRO_RESPONSABILIDAD
        '
        Me.colCENTRO_RESPONSABILIDAD.Caption = "Centro Respon."
        Me.colCENTRO_RESPONSABILIDAD.FieldName = "colCENTRO_RESPONSABILIDAD"
        Me.colCENTRO_RESPONSABILIDAD.Name = "colCENTRO_RESPONSABILIDAD"
        Me.colCENTRO_RESPONSABILIDAD.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colCENTRO_RESPONSABILIDAD.Visible = True
        Me.colCENTRO_RESPONSABILIDAD.VisibleIndex = 3
        Me.colCENTRO_RESPONSABILIDAD.Width = 170
        '
        'colUNIDAD_ORGANIZATIVA
        '
        Me.colUNIDAD_ORGANIZATIVA.Caption = "Unidad Organizativa"
        Me.colUNIDAD_ORGANIZATIVA.FieldName = "colUNIDAD_ORGANIZATIVA"
        Me.colUNIDAD_ORGANIZATIVA.Name = "colUNIDAD_ORGANIZATIVA"
        Me.colUNIDAD_ORGANIZATIVA.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colUNIDAD_ORGANIZATIVA.Visible = True
        Me.colUNIDAD_ORGANIZATIVA.VisibleIndex = 2
        Me.colUNIDAD_ORGANIZATIVA.Width = 147
        '
        'colPROGRAMA_FORMACION
        '
        Me.colPROGRAMA_FORMACION.Caption = "Programa Formación"
        Me.colPROGRAMA_FORMACION.FieldName = "colPROGRAMA_FORMACION"
        Me.colPROGRAMA_FORMACION.Name = "colPROGRAMA_FORMACION"
        Me.colPROGRAMA_FORMACION.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPROGRAMA_FORMACION.Visible = True
        Me.colPROGRAMA_FORMACION.VisibleIndex = 4
        Me.colPROGRAMA_FORMACION.Width = 137
        '
        'colPROYECTO_FORMACION
        '
        Me.colPROYECTO_FORMACION.Caption = "Proyecto Formación"
        Me.colPROYECTO_FORMACION.FieldName = "colPROYECTO_FORMACION"
        Me.colPROYECTO_FORMACION.Name = "colPROYECTO_FORMACION"
        Me.colPROYECTO_FORMACION.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPROYECTO_FORMACION.Visible = True
        Me.colPROYECTO_FORMACION.VisibleIndex = 5
        Me.colPROYECTO_FORMACION.Width = 137
        '
        'colHORARIO
        '
        Me.colHORARIO.Caption = "Horario"
        Me.colHORARIO.FieldName = "HORARIO"
        Me.colHORARIO.Name = "colHORARIO"
        Me.colHORARIO.Visible = True
        Me.colHORARIO.VisibleIndex = 6
        Me.colHORARIO.Width = 214
        '
        'colID_REFERENTE
        '
        Me.colID_REFERENTE.Caption = "Id referente"
        Me.colID_REFERENTE.FieldName = "ID_REFERENTE"
        Me.colID_REFERENTE.Name = "colID_REFERENTE"
        '
        'colID_CENTRO_RESPONSABILIDAD
        '
        Me.colID_CENTRO_RESPONSABILIDAD.Caption = "Id centro responsabilidad"
        Me.colID_CENTRO_RESPONSABILIDAD.FieldName = "ID_CENTRO_RESPONSABILIDAD"
        Me.colID_CENTRO_RESPONSABILIDAD.Name = "colID_CENTRO_RESPONSABILIDAD"
        '
        'colID_UNIDAD_ORGANIZATIVA
        '
        Me.colID_UNIDAD_ORGANIZATIVA.Caption = "Id unidad organizativa"
        Me.colID_UNIDAD_ORGANIZATIVA.FieldName = "ID_UNIDAD_ORGANIZATIVA"
        Me.colID_UNIDAD_ORGANIZATIVA.Name = "colID_UNIDAD_ORGANIZATIVA"
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.Caption = "Codigo departamento"
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.Caption = "Codigo municipio"
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        '
        'colID_PROGRAMA_FORMACION
        '
        Me.colID_PROGRAMA_FORMACION.Caption = "Id programa formacion"
        Me.colID_PROGRAMA_FORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Name = "colID_PROGRAMA_FORMACION"
        '
        'colID_PROYECTO_FORMACION
        '
        Me.colID_PROYECTO_FORMACION.Caption = "Id proyecto formacion"
        Me.colID_PROYECTO_FORMACION.FieldName = "ID_PROYECTO_FORMACION"
        Me.colID_PROYECTO_FORMACION.Name = "colID_PROYECTO_FORMACION"
        '
        'colOBJETIVO_CAPACITACION
        '
        Me.colOBJETIVO_CAPACITACION.Caption = "Objetivo capacitacion"
        Me.colOBJETIVO_CAPACITACION.FieldName = "OBJETIVO_CAPACITACION"
        Me.colOBJETIVO_CAPACITACION.Name = "colOBJETIVO_CAPACITACION"
        '
        'colDIRECCION_REFERENTE
        '
        Me.colDIRECCION_REFERENTE.Caption = "Direccion referente"
        Me.colDIRECCION_REFERENTE.FieldName = "DIRECCION_REFERENTE"
        Me.colDIRECCION_REFERENTE.Name = "colDIRECCION_REFERENTE"
        '
        'colTELEF1
        '
        Me.colTELEF1.Caption = "Telef1"
        Me.colTELEF1.FieldName = "TELEF1"
        Me.colTELEF1.Name = "colTELEF1"
        '
        'colTELEF2
        '
        Me.colTELEF2.Caption = "Telef2"
        Me.colTELEF2.FieldName = "TELEF2"
        Me.colTELEF2.Name = "colTELEF2"
        '
        'colTELEF3
        '
        Me.colTELEF3.Caption = "Telef3"
        Me.colTELEF3.FieldName = "TELEF3"
        Me.colTELEF3.Name = "colTELEF3"
        '
        'colTELEF_MOVIL
        '
        Me.colTELEF_MOVIL.Caption = "Telef movil"
        Me.colTELEF_MOVIL.FieldName = "TELEF_MOVIL"
        Me.colTELEF_MOVIL.Name = "colTELEF_MOVIL"
        '
        'colFAX
        '
        Me.colFAX.Caption = "Fax"
        Me.colFAX.FieldName = "FAX"
        Me.colFAX.Name = "colFAX"
        '
        'colNOMBRES_CONTACTO
        '
        Me.colNOMBRES_CONTACTO.Caption = "Nombres contacto"
        Me.colNOMBRES_CONTACTO.FieldName = "NOMBRES_CONTACTO"
        Me.colNOMBRES_CONTACTO.Name = "colNOMBRES_CONTACTO"
        '
        'colAPELLIDOS_CONTACTO
        '
        Me.colAPELLIDOS_CONTACTO.Caption = "Apellidos contacto"
        Me.colAPELLIDOS_CONTACTO.FieldName = "APELLIDOS_CONTACTO"
        Me.colAPELLIDOS_CONTACTO.Name = "colAPELLIDOS_CONTACTO"
        '
        'colEMAIL_CONTACTO
        '
        Me.colEMAIL_CONTACTO.Caption = "Email contacto"
        Me.colEMAIL_CONTACTO.FieldName = "EMAIL_CONTACTO"
        Me.colEMAIL_CONTACTO.Name = "colEMAIL_CONTACTO"
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        '
        'frmSolicitudesCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 482)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmSolicitudesCapacitacion"
        Me.Text = "Solicitudes de Capacitacion"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPatiEjecucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTDR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaSolicitud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSOLICITUD_CAPACITACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_SOLICITUDGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSOLICITUD_CAPACITACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents bsPatiEjecucion As System.Windows.Forms.BindingSource
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxUNIDAD_ORGANIZATIVA1 As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
    Friend WithEvents txtTDR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PatiEjecucionTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.PATIEjecucionTableAdapter
    Friend WithEvents CbxREFERENTE1 As SGAFP.WinUC.cbxREFERENTE
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dteFechaSolicitud As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxPROYECTO_FORMACION1 As SGAFP.WinUC.cbxPROYECTO_FORMACION
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ListaSOLICITUD_CAPACITACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaGRUPO_SOLICITUDGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_MODALIDAD_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMODALIDAD_FORMACION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PROGRAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnombre_programa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcodigo_programa1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION_HORAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_PARTICIPANTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListaSOLICITUD_CAPACITACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDAD_ORGANIZATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROYECTO_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_UNIDAD_ORGANIZATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROYECTO_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBJETIVO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF_MOVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDOS_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
End Class
