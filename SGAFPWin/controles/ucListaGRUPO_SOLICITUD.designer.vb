<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaGRUPO_SOLICITUD
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
        Me.ListaGRUPO_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaGRUPO_SOLICITUDGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaGRUPO_SOLICITUDGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_GRUPO_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_MODALIDAD_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PROGRAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDURACION_HORAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_PARTICIPANTES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaGRUPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_SOLICITUDGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_SOLICITUDGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaGRUPO_SOLICITUDBindingSource
        '
        Me.ListaGRUPO_SOLICITUDBindingSource.DataSource = GetType(SGAFP.EL.GRUPO_SOLICITUD)
        '
        'ListaGRUPO_SOLICITUDGridControl
        '
        Me.ListaGRUPO_SOLICITUDGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaGRUPO_SOLICITUDGridControl.DataSource = Me.ListaGRUPO_SOLICITUDBindingSource
        Me.ListaGRUPO_SOLICITUDGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaGRUPO_SOLICITUDGridControl.MainView = Me.ListaGRUPO_SOLICITUDGridView
        Me.ListaGRUPO_SOLICITUDGridControl.Name = "ListaGRUPO_SOLICITUDGridControl"
        Me.ListaGRUPO_SOLICITUDGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaGRUPO_SOLICITUDGridControl.TabIndex = 1
        Me.ListaGRUPO_SOLICITUDGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaGRUPO_SOLICITUDGridView})
        '
        'ListaGRUPO_SOLICITUDGridView
        '
        Me.ListaGRUPO_SOLICITUDGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_GRUPO_SOLICITUD, Me.colID_SOLICITUD, Me.colID_MODALIDAD_FORMACION, Me.colCODIGO_PROGRAMA, Me.colDURACION_HORAS, Me.colNUM_PARTICIPANTES, Me.colTDR, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaGRUPO_SOLICITUDGridView.GridControl = Me.ListaGRUPO_SOLICITUDGridControl
        Me.ListaGRUPO_SOLICITUDGridView.Name = "ListaGRUPO_SOLICITUDGridView"
        Me.ListaGRUPO_SOLICITUDGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_GRUPO_SOLICITUD
        '
        Me.colID_GRUPO_SOLICITUD.Caption = "Id grupo solicitud"
        Me.colID_GRUPO_SOLICITUD.FieldName = "ID_GRUPO_SOLICITUD"
        Me.colID_GRUPO_SOLICITUD.Name = "colID_GRUPO_SOLICITUD"
        Me.colID_GRUPO_SOLICITUD.Visible = True
        Me.colID_GRUPO_SOLICITUD.VisibleIndex = 0
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.Caption = "Id solicitud"
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        Me.colID_SOLICITUD.Visible = True
        Me.colID_SOLICITUD.VisibleIndex = 1
        '
        'colID_MODALIDAD_FORMACION
        '
        Me.colID_MODALIDAD_FORMACION.Caption = "Id modalidad formacion"
        Me.colID_MODALIDAD_FORMACION.FieldName = "ID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Name = "colID_MODALIDAD_FORMACION"
        Me.colID_MODALIDAD_FORMACION.Visible = True
        Me.colID_MODALIDAD_FORMACION.VisibleIndex = 2
        '
        'colCODIGO_PROGRAMA
        '
        Me.colCODIGO_PROGRAMA.Caption = "Codigo programa"
        Me.colCODIGO_PROGRAMA.FieldName = "CODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Name = "colCODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Visible = True
        Me.colCODIGO_PROGRAMA.VisibleIndex = 3
        '
        'colDURACION_HORAS
        '
        Me.colDURACION_HORAS.Caption = "Duracion horas"
        Me.colDURACION_HORAS.FieldName = "DURACION_HORAS"
        Me.colDURACION_HORAS.Name = "colDURACION_HORAS"
        Me.colDURACION_HORAS.Visible = True
        Me.colDURACION_HORAS.VisibleIndex = 4
        '
        'colNUM_PARTICIPANTES
        '
        Me.colNUM_PARTICIPANTES.Caption = "Num participantes"
        Me.colNUM_PARTICIPANTES.FieldName = "NUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.Name = "colNUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.Visible = True
        Me.colNUM_PARTICIPANTES.VisibleIndex = 5
        '
        'colTDR
        '
        Me.colTDR.Caption = "Tdr"
        Me.colTDR.FieldName = "TDR"
        Me.colTDR.Name = "colTDR"
        Me.colTDR.Visible = True
        Me.colTDR.VisibleIndex = 6
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 7
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 8
        '
        'ucListaGRUPO_SOLICITUD
        '
        Me.Controls.Add(Me.ListaGRUPO_SOLICITUDGridControl)
        Me.Name = "ucListaGRUPO_SOLICITUD"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaGRUPO_SOLICITUDGridControl, 0)
        CType(Me.ListaGRUPO_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_SOLICITUDGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_SOLICITUDGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaGRUPO_SOLICITUDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaGRUPO_SOLICITUDGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaGRUPO_SOLICITUDGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_GRUPO_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_MODALIDAD_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PROGRAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION_HORAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_PARTICIPANTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
