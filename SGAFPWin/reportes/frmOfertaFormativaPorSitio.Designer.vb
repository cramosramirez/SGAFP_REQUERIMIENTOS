<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfertaFormativaPorSitio
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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl
        Me.CbxMUNICIPIO1 = New SGAFP.WinUC.cbxMUNICIPIO
        Me.CbxDEPARTAMENTO1 = New SGAFP.WinUC.cbxDEPARTAMENTO
        Me.CbxEJERCICIO1 = New SGAFP.WinUC.cbxEJERCICIO
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CbxAREA_FORMACION1 = New SGAFP.WinUC.cbxAREA_FORMACION
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ListaOFERTAFORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_EJERCICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_SITIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTEMA_CURSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDURACION_HORAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOSTO_X_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOTAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOFERTAFORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(772, 340)
        Me.SplitContainerControl1.SplitterPosition = 105
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.CbxMUNICIPIO1)
        Me.LayoutControl2.Controls.Add(Me.CbxDEPARTAMENTO1)
        Me.LayoutControl2.Controls.Add(Me.CbxEJERCICIO1)
        Me.LayoutControl2.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.LayoutControl2.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl2.Controls.Add(Me.CbxAREA_FORMACION1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(772, 105)
        Me.LayoutControl2.TabIndex = 2
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'CbxMUNICIPIO1
        '
        Me.CbxMUNICIPIO1.AllowFindEntityType = Nothing
        Me.CbxMUNICIPIO1.Location = New System.Drawing.Point(495, 62)
        Me.CbxMUNICIPIO1.Name = "CbxMUNICIPIO1"
        Me.CbxMUNICIPIO1.Size = New System.Drawing.Size(265, 21)
        Me.CbxMUNICIPIO1.TabIndex = 9
        Me.CbxMUNICIPIO1.Text = "CbxMUNICIPIO1"
        '
        'CbxDEPARTAMENTO1
        '
        Me.CbxDEPARTAMENTO1.AllowFindEntityType = Nothing
        Me.CbxDEPARTAMENTO1.Location = New System.Drawing.Point(116, 62)
        Me.CbxDEPARTAMENTO1.Name = "CbxDEPARTAMENTO1"
        Me.CbxDEPARTAMENTO1.Size = New System.Drawing.Size(271, 21)
        Me.CbxDEPARTAMENTO1.TabIndex = 8
        Me.CbxDEPARTAMENTO1.Text = "CbxDEPARTAMENTO1"
        '
        'CbxEJERCICIO1
        '
        Me.CbxEJERCICIO1.AllowFindEntityType = Nothing
        Me.CbxEJERCICIO1.Location = New System.Drawing.Point(116, 37)
        Me.CbxEJERCICIO1.Name = "CbxEJERCICIO1"
        Me.CbxEJERCICIO1.Size = New System.Drawing.Size(271, 21)
        Me.CbxEJERCICIO1.TabIndex = 7
        Me.CbxEJERCICIO1.Text = "CbxEJERCICIO1"
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(495, 12)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(265, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 6
        Me.CbxSITIO_CAPACITACION1.Text = "CbxSITIO_CAPACITACION1"
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(116, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(271, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'CbxAREA_FORMACION1
        '
        Me.CbxAREA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxAREA_FORMACION1.Location = New System.Drawing.Point(495, 37)
        Me.CbxAREA_FORMACION1.Name = "CbxAREA_FORMACION1"
        Me.CbxAREA_FORMACION1.Size = New System.Drawing.Size(265, 21)
        Me.CbxAREA_FORMACION1.TabIndex = 4
        Me.CbxAREA_FORMACION1.Text = "CbxAREA_FORMACION1"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(772, 105)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 25)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CbxEJERCICIO1
        Me.LayoutControlItem4.CustomizationFormText = "Ejercicio"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(379, 25)
        Me.LayoutControlItem4.Text = "Ejercicio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxSITIO_CAPACITACION1
        Me.LayoutControlItem3.CustomizationFormText = "Centro de Formacion"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(379, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(373, 25)
        Me.LayoutControlItem3.Text = "Centro de Formacion"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxAREA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Area de Formacion"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(379, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(373, 25)
        Me.LayoutControlItem1.Text = "Area de Formacion"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CbxDEPARTAMENTO1
        Me.LayoutControlItem5.CustomizationFormText = "Departamento"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(379, 35)
        Me.LayoutControlItem5.Text = "Departamento"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CbxMUNICIPIO1
        Me.LayoutControlItem6.CustomizationFormText = "Municipio"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(379, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(373, 35)
        Me.LayoutControlItem6.Text = "Municipio"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(100, 13)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListaOFERTAFORMATIVABindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(772, 229)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'ListaOFERTAFORMATIVABindingSource
        '
        Me.ListaOFERTAFORMATIVABindingSource.DataSource = GetType(SGAFP.EL.listaOFERTA_FORMATIVA)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_EJERCICIO, Me.colNOMBRE_PROVEEDOR, Me.colNOMBRE_SITIO, Me.colTEMA_CURSO, Me.colDURACION_HORAS, Me.colCOSTO_X_PARTICIPANTE, Me.colNOTAS, Me.colNOMBRE_DEPARTAMENTO, Me.colNOMBRE_MUNICIPIO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupPanelText = "Arrastre aqui las columnas para Agrupar"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_PROVEEDOR, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_SITIO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTEMA_CURSO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID_EJERCICIO
        '
        Me.colID_EJERCICIO.Caption = "EJERCICIO"
        Me.colID_EJERCICIO.FieldName = "ID_EJERCICIO"
        Me.colID_EJERCICIO.Name = "colID_EJERCICIO"
        Me.colID_EJERCICIO.Width = 62
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.Caption = "PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Width = 120
        '
        'colNOMBRE_SITIO
        '
        Me.colNOMBRE_SITIO.Caption = "CENTRO DE FORMACION"
        Me.colNOMBRE_SITIO.FieldName = "NOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Name = "colNOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Width = 148
        '
        'colTEMA_CURSO
        '
        Me.colTEMA_CURSO.Caption = "NOMBRE OFERTA"
        Me.colTEMA_CURSO.FieldName = "TEMA_CURSO"
        Me.colTEMA_CURSO.Name = "colTEMA_CURSO"
        Me.colTEMA_CURSO.Visible = True
        Me.colTEMA_CURSO.VisibleIndex = 0
        Me.colTEMA_CURSO.Width = 290
        '
        'colDURACION_HORAS
        '
        Me.colDURACION_HORAS.Caption = "DURACION(Hrs)"
        Me.colDURACION_HORAS.FieldName = "DURACION_HORAS"
        Me.colDURACION_HORAS.Name = "colDURACION_HORAS"
        Me.colDURACION_HORAS.Visible = True
        Me.colDURACION_HORAS.VisibleIndex = 1
        Me.colDURACION_HORAS.Width = 101
        '
        'colCOSTO_X_PARTICIPANTE
        '
        Me.colCOSTO_X_PARTICIPANTE.Caption = "COSTO POR PARTICIPANTE($)"
        Me.colCOSTO_X_PARTICIPANTE.FieldName = "COSTO_X_PARTICIPANTE"
        Me.colCOSTO_X_PARTICIPANTE.Name = "colCOSTO_X_PARTICIPANTE"
        Me.colCOSTO_X_PARTICIPANTE.Visible = True
        Me.colCOSTO_X_PARTICIPANTE.VisibleIndex = 2
        Me.colCOSTO_X_PARTICIPANTE.Width = 174
        '
        'colNOTAS
        '
        Me.colNOTAS.FieldName = "NOTAS"
        Me.colNOTAS.Name = "colNOTAS"
        Me.colNOTAS.Visible = True
        Me.colNOTAS.VisibleIndex = 3
        Me.colNOTAS.Width = 186
        '
        'colNOMBRE_DEPARTAMENTO
        '
        Me.colNOMBRE_DEPARTAMENTO.Caption = "DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Name = "colNOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Visible = True
        Me.colNOMBRE_DEPARTAMENTO.VisibleIndex = 4
        '
        'colNOMBRE_MUNICIPIO
        '
        Me.colNOMBRE_MUNICIPIO.Caption = "MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Name = "colNOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Visible = True
        Me.colNOMBRE_MUNICIPIO.VisibleIndex = 5
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'frmOfertaFormativaPorSitio
        '
        Me.ClientSize = New System.Drawing.Size(772, 340)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmOfertaFormativaPorSitio"
        Me.Text = "Consulta de Oferta Formativa"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOFERTAFORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxEJERCICIO1 As SGAFP.WinUC.cbxEJERCICIO
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CbxAREA_FORMACION1 As SGAFP.WinUC.cbxAREA_FORMACION
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaOFERTAFORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_EJERCICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTEMA_CURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION_HORAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOSTO_X_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colNOMBRE_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CbxMUNICIPIO1 As SGAFP.WinUC.cbxMUNICIPIO
    Friend WithEvents CbxDEPARTAMENTO1 As SGAFP.WinUC.cbxDEPARTAMENTO
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colNOMBRE_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn

End Class
