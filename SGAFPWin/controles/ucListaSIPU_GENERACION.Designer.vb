<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSIPU_GENERACION
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
        Me.ListaSIPU_GENERACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSIPU_GENERACIONGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaSIPU_GENERACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_GENERACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFUENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUMERO_CONVOCATORIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaSIPU_GENERACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_GENERACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_GENERACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSIPU_GENERACIONBindingSource
        '
        Me.ListaSIPU_GENERACIONBindingSource.DataSource = GetType(SGAFP.EL.SIPU_GENERACION)
        '
        'ListaSIPU_GENERACIONGridControl
        '
        Me.ListaSIPU_GENERACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSIPU_GENERACIONGridControl.DataSource = Me.ListaSIPU_GENERACIONBindingSource
        Me.ListaSIPU_GENERACIONGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaSIPU_GENERACIONGridControl.MainView = Me.ListaSIPU_GENERACIONGridView
        Me.ListaSIPU_GENERACIONGridControl.Name = "ListaSIPU_GENERACIONGridControl"
        Me.ListaSIPU_GENERACIONGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaSIPU_GENERACIONGridControl.TabIndex = 1
        Me.ListaSIPU_GENERACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaSIPU_GENERACIONGridView})
        '
        'ListaSIPU_GENERACIONGridView
        '
        Me.ListaSIPU_GENERACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_GENERACION, Me.colFECHA, Me.colFUENTE, Me.colNUMERO_CONVOCATORIA, Me.colUSUARIO_CREACION, Me.colFECHA_CREACION, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaSIPU_GENERACIONGridView.GridControl = Me.ListaSIPU_GENERACIONGridControl
        Me.ListaSIPU_GENERACIONGridView.Name = "ListaSIPU_GENERACIONGridView"
        Me.ListaSIPU_GENERACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_GENERACION
        '
        Me.colID_GENERACION.Caption = "Id generacion"
        Me.colID_GENERACION.FieldName = "ID_GENERACION"
        Me.colID_GENERACION.Name = "colID_GENERACION"
        Me.colID_GENERACION.Visible = True
        Me.colID_GENERACION.VisibleIndex = 0
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "Fecha"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 1
        '
        'colFUENTE
        '
        Me.colFUENTE.Caption = "Fuente"
        Me.colFUENTE.FieldName = "FUENTE"
        Me.colFUENTE.Name = "colFUENTE"
        Me.colFUENTE.Visible = True
        Me.colFUENTE.VisibleIndex = 2
        '
        'colNUMERO_CONVOCATORIA
        '
        Me.colNUMERO_CONVOCATORIA.Caption = "Numero convocatoria"
        Me.colNUMERO_CONVOCATORIA.FieldName = "NUMERO_CONVOCATORIA"
        Me.colNUMERO_CONVOCATORIA.Name = "colNUMERO_CONVOCATORIA"
        Me.colNUMERO_CONVOCATORIA.Visible = True
        Me.colNUMERO_CONVOCATORIA.VisibleIndex = 3
        '
        'colUSUARIO_CREACION
        '
        Me.colUSUARIO_CREACION.Caption = "Usuario creacion"
        Me.colUSUARIO_CREACION.FieldName = "USUARIO_CREACION"
        Me.colUSUARIO_CREACION.Name = "colUSUARIO_CREACION"
        Me.colUSUARIO_CREACION.Visible = True
        Me.colUSUARIO_CREACION.VisibleIndex = 4
        '
        'colFECHA_CREACION
        '
        Me.colFECHA_CREACION.Caption = "Fecha creacion"
        Me.colFECHA_CREACION.FieldName = "FECHA_CREACION"
        Me.colFECHA_CREACION.Name = "colFECHA_CREACION"
        Me.colFECHA_CREACION.Visible = True
        Me.colFECHA_CREACION.VisibleIndex = 5
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 6
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 7
        '
        'ucListaSIPU_GENERACION
        '
        Me.Controls.Add(Me.ListaSIPU_GENERACIONGridControl)
        Me.Name = "ucListaSIPU_GENERACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSIPU_GENERACIONGridControl, 0)
        CType(Me.ListaSIPU_GENERACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_GENERACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_GENERACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_GENERACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSIPU_GENERACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaSIPU_GENERACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_GENERACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFUENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMERO_CONVOCATORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
