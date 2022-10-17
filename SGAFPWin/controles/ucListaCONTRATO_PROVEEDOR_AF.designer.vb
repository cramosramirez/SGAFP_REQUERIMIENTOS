<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCONTRATO_PROVEEDOR_AF
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
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaCONTRATO_PROVEEDOR_AFGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_EJERCICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_ADJUDICADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_LICITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_DEVENGADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTICIP_ADJUDICADA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_FIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_PROYECTO_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaCONTRATO_PROVEEDOR_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_PROVEEDOR_AFGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_PROVEEDOR_AFGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCONTRATO_PROVEEDOR_AFBindingSource
        '
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = GetType(SGAFP.EL.CONTRATO_PROVEEDOR_AF)
        '
        'ListaCONTRATO_PROVEEDOR_AFGridControl
        '
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.DataSource = Me.ListaCONTRATO_PROVEEDOR_AFBindingSource
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.MainView = Me.ListaCONTRATO_PROVEEDOR_AFGridView
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Name = "ListaCONTRATO_PROVEEDOR_AFGridControl"
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.TabIndex = 1
        Me.ListaCONTRATO_PROVEEDOR_AFGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaCONTRATO_PROVEEDOR_AFGridView})
        '
        'ListaCONTRATO_PROVEEDOR_AFGridView
        '
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_CONTRATO, Me.colNUM_CONTRATO, Me.colID_PROVEEDOR_AF, Me.colID_EJERCICIO, Me.colMONTO_ADJUDICADO, Me.colUSERID, Me.colLASTUPDATE, Me.colNUM_LICITACION, Me.colMONTO_DEVENGADO, Me.colID_PROGRAMA_FORMACION, Me.colPARTICIP_ADJUDICADA, Me.colFECHA_INICIO, Me.colFECHA_FIN, Me.colID_PROYECTO_FORMACION})
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.GridControl = Me.ListaCONTRATO_PROVEEDOR_AFGridControl
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.Name = "ListaCONTRATO_PROVEEDOR_AFGridView"
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_CONTRATO
        '
        Me.colID_CONTRATO.Caption = "Id contrato"
        Me.colID_CONTRATO.FieldName = "ID_CONTRATO"
        Me.colID_CONTRATO.Name = "colID_CONTRATO"
        Me.colID_CONTRATO.Visible = True
        Me.colID_CONTRATO.VisibleIndex = 0
        '
        'colNUM_CONTRATO
        '
        Me.colNUM_CONTRATO.Caption = "Num contrato"
        Me.colNUM_CONTRATO.FieldName = "NUM_CONTRATO"
        Me.colNUM_CONTRATO.Name = "colNUM_CONTRATO"
        Me.colNUM_CONTRATO.Visible = True
        Me.colNUM_CONTRATO.VisibleIndex = 1
        '
        'colID_PROVEEDOR_AF
        '
        Me.colID_PROVEEDOR_AF.Caption = "Id proveedor af"
        Me.colID_PROVEEDOR_AF.FieldName = "ID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Name = "colID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Visible = True
        Me.colID_PROVEEDOR_AF.VisibleIndex = 2
        '
        'colID_EJERCICIO
        '
        Me.colID_EJERCICIO.Caption = "Id ejercicio"
        Me.colID_EJERCICIO.FieldName = "ID_EJERCICIO"
        Me.colID_EJERCICIO.Name = "colID_EJERCICIO"
        Me.colID_EJERCICIO.Visible = True
        Me.colID_EJERCICIO.VisibleIndex = 3
        '
        'colMONTO_ADJUDICADO
        '
        Me.colMONTO_ADJUDICADO.Caption = "Monto adjudicado"
        Me.colMONTO_ADJUDICADO.FieldName = "MONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Name = "colMONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Visible = True
        Me.colMONTO_ADJUDICADO.VisibleIndex = 4
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 5
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 6
        '
        'colNUM_LICITACION
        '
        Me.colNUM_LICITACION.Caption = "Num licitacion"
        Me.colNUM_LICITACION.FieldName = "NUM_LICITACION"
        Me.colNUM_LICITACION.Name = "colNUM_LICITACION"
        Me.colNUM_LICITACION.Visible = True
        Me.colNUM_LICITACION.VisibleIndex = 7
        '
        'colMONTO_DEVENGADO
        '
        Me.colMONTO_DEVENGADO.Caption = "Monto devengado"
        Me.colMONTO_DEVENGADO.FieldName = "MONTO_DEVENGADO"
        Me.colMONTO_DEVENGADO.Name = "colMONTO_DEVENGADO"
        Me.colMONTO_DEVENGADO.Visible = True
        Me.colMONTO_DEVENGADO.VisibleIndex = 8
        '
        'colID_PROGRAMA_FORMACION
        '
        Me.colID_PROGRAMA_FORMACION.Caption = "Id programa formacion"
        Me.colID_PROGRAMA_FORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Name = "colID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Visible = True
        Me.colID_PROGRAMA_FORMACION.VisibleIndex = 9
        '
        'colPARTICIP_ADJUDICADA
        '
        Me.colPARTICIP_ADJUDICADA.Caption = "Particip adjudicada"
        Me.colPARTICIP_ADJUDICADA.FieldName = "PARTICIP_ADJUDICADA"
        Me.colPARTICIP_ADJUDICADA.Name = "colPARTICIP_ADJUDICADA"
        Me.colPARTICIP_ADJUDICADA.Visible = True
        Me.colPARTICIP_ADJUDICADA.VisibleIndex = 10
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "Fecha inicio"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 11
        '
        'colFECHA_FIN
        '
        Me.colFECHA_FIN.Caption = "Fecha fin"
        Me.colFECHA_FIN.FieldName = "FECHA_FIN"
        Me.colFECHA_FIN.Name = "colFECHA_FIN"
        Me.colFECHA_FIN.Visible = True
        Me.colFECHA_FIN.VisibleIndex = 12
        '
        'colID_PROYECTO_FORMACION
        '
        Me.colID_PROYECTO_FORMACION.Caption = "Id proyecto formacion"
        Me.colID_PROYECTO_FORMACION.FieldName = "ID_PROYECTO_FORMACION"
        Me.colID_PROYECTO_FORMACION.Name = "colID_PROYECTO_FORMACION"
        Me.colID_PROYECTO_FORMACION.Visible = True
        Me.colID_PROYECTO_FORMACION.VisibleIndex = 13
        '
        'ucListaCONTRATO_PROVEEDOR_AF
        '
        Me.Controls.Add(Me.ListaCONTRATO_PROVEEDOR_AFGridControl)
        Me.Name = "ucListaCONTRATO_PROVEEDOR_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCONTRATO_PROVEEDOR_AFGridControl, 0)
        CType(Me.ListaCONTRATO_PROVEEDOR_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_PROVEEDOR_AFGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_PROVEEDOR_AFGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTRATO_PROVEEDOR_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCONTRATO_PROVEEDOR_AFGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaCONTRATO_PROVEEDOR_AFGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_EJERCICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ADJUDICADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_LICITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_DEVENGADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTICIP_ADJUDICADA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROYECTO_FORMACION As DevExpress.XtraGrid.Columns.GridColumn

End Class
