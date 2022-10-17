<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaACCION_FORMATIVA_DETALLE
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
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaACCION_FORMATIVA_DETALLEGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaACCION_FORMATIVA_DETALLEGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_ACCION_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_MODALIDAD_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_FUENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_CONVOCATORIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLUGAR_EJECUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEFONO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaACCION_FORMATIVA_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaACCION_FORMATIVA_DETALLEGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaACCION_FORMATIVA_DETALLEGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaACCION_FORMATIVA_DETALLEBindingSource
        '
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = GetType(SGAFP.EL.ACCION_FORMATIVA_DETALLE)
        '
        'ListaACCION_FORMATIVA_DETALLEGridControl
        '
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.DataSource = Me.ListaACCION_FORMATIVA_DETALLEBindingSource
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.MainView = Me.ListaACCION_FORMATIVA_DETALLEGridView
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.Name = "ListaACCION_FORMATIVA_DETALLEGridControl"
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.TabIndex = 1
        Me.ListaACCION_FORMATIVA_DETALLEGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaACCION_FORMATIVA_DETALLEGridView})
        '
        'ListaACCION_FORMATIVA_DETALLEGridView
        '
        Me.ListaACCION_FORMATIVA_DETALLEGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_ACCION_FORMATIVA, Me.colID_PROGRAMA_FORMACION, Me.colID_MODALIDAD_FORMACION, Me.colID_CONTRATO, Me.colID_FUENTE, Me.colNO_CONVOCATORIA, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colLUGAR_EJECUCION, Me.colTELEFONO, Me.colCONTACTO, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaACCION_FORMATIVA_DETALLEGridView.GridControl = Me.ListaACCION_FORMATIVA_DETALLEGridControl
        Me.ListaACCION_FORMATIVA_DETALLEGridView.Name = "ListaACCION_FORMATIVA_DETALLEGridView"
        Me.ListaACCION_FORMATIVA_DETALLEGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_ACCION_FORMATIVA
        '
        Me.colID_ACCION_FORMATIVA.Caption = "Id accion formativa"
        Me.colID_ACCION_FORMATIVA.FieldName = "ID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Name = "colID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Visible = True
        Me.colID_ACCION_FORMATIVA.VisibleIndex = 0
        '
        'colID_PROGRAMA_FORMACION
        '
        Me.colID_PROGRAMA_FORMACION.Caption = "Id programa formacion"
        Me.colID_PROGRAMA_FORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Name = "colID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Visible = True
        Me.colID_PROGRAMA_FORMACION.VisibleIndex = 1
        '
        'colID_MODALIDAD_FORMACION
        '
        Me.colID_MODALIDAD_FORMACION.Caption = "Id modalidad formacion"
        Me.colID_MODALIDAD_FORMACION.FieldName = "ID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Name = "colID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Visible = True
        Me.colID_MODALIDAD_FORMACION.VisibleIndex = 2
        '
        'colID_CONTRATO
        '
        Me.colID_CONTRATO.Caption = "Id contrato"
        Me.colID_CONTRATO.FieldName = "ID_CONTRATO"
        Me.colID_CONTRATO.Name = "colID_CONTRATO"
        Me.colID_CONTRATO.Visible = True
        Me.colID_CONTRATO.VisibleIndex = 3
        '
        'colID_FUENTE
        '
        Me.colID_FUENTE.Caption = "Id fuente"
        Me.colID_FUENTE.FieldName = "ID_FUENTE"
        Me.colID_FUENTE.Name = "colID_FUENTE"
        Me.colID_FUENTE.Visible = True
        Me.colID_FUENTE.VisibleIndex = 4
        '
        'colNO_CONVOCATORIA
        '
        Me.colNO_CONVOCATORIA.Caption = "No convocatoria"
        Me.colNO_CONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Name = "colNO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Visible = True
        Me.colNO_CONVOCATORIA.VisibleIndex = 5
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.Caption = "Codigo departamento"
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Visible = True
        Me.colCODIGO_DEPARTAMENTO.VisibleIndex = 6
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.Caption = "Codigo municipio"
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Visible = True
        Me.colCODIGO_MUNICIPIO.VisibleIndex = 7
        '
        'colLUGAR_EJECUCION
        '
        Me.colLUGAR_EJECUCION.Caption = "Lugar ejecucion"
        Me.colLUGAR_EJECUCION.FieldName = "LUGAR_EJECUCION"
        Me.colLUGAR_EJECUCION.Name = "colLUGAR_EJECUCION"
        Me.colLUGAR_EJECUCION.Visible = True
        Me.colLUGAR_EJECUCION.VisibleIndex = 8
        '
        'colTELEFONO
        '
        Me.colTELEFONO.Caption = "Telefono"
        Me.colTELEFONO.FieldName = "TELEFONO"
        Me.colTELEFONO.Name = "colTELEFONO"
        Me.colTELEFONO.Visible = True
        Me.colTELEFONO.VisibleIndex = 9
        '
        'colCONTACTO
        '
        Me.colCONTACTO.Caption = "Contacto"
        Me.colCONTACTO.FieldName = "CONTACTO"
        Me.colCONTACTO.Name = "colCONTACTO"
        Me.colCONTACTO.Visible = True
        Me.colCONTACTO.VisibleIndex = 10
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 11
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 12
        '
        'ucListaACCION_FORMATIVA_DETALLE
        '
        Me.Controls.Add(Me.ListaACCION_FORMATIVA_DETALLEGridControl)
        Me.Name = "ucListaACCION_FORMATIVA_DETALLE"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaACCION_FORMATIVA_DETALLEGridControl, 0)
        CType(Me.ListaACCION_FORMATIVA_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaACCION_FORMATIVA_DETALLEGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaACCION_FORMATIVA_DETALLEGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaACCION_FORMATIVA_DETALLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaACCION_FORMATIVA_DETALLEGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaACCION_FORMATIVA_DETALLEGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_ACCION_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_MODALIDAD_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_FUENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_CONVOCATORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLUGAR_EJECUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
