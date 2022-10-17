<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaGRUPO_ACCION_CONTRATADA
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
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaGRUPO_ACCION_CONTRATADAGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_GRUPO_ACCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_ACCION_CONTRATADA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_GRUPO_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_ACCION_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_ACCION_CONTRATADAGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_ACCION_CONTRATADAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaGRUPO_ACCION_CONTRATADABindingSource
        '
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.DataSource = GetType(SGAFP.EL.GRUPO_ACCION_CONTRATADA)
        '
        'ListaGRUPO_ACCION_CONTRATADAGridControl
        '
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.DataSource = Me.ListaGRUPO_ACCION_CONTRATADABindingSource
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.MainView = Me.ListaGRUPO_ACCION_CONTRATADAGridView
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Name = "ListaGRUPO_ACCION_CONTRATADAGridControl"
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.TabIndex = 1
        Me.ListaGRUPO_ACCION_CONTRATADAGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaGRUPO_ACCION_CONTRATADAGridView})
        '
        'ListaGRUPO_ACCION_CONTRATADAGridView
        '
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_GRUPO_ACCION, Me.colID_ACCION_CONTRATADA, Me.colID_GRUPO_AF, Me.colID_ACCION_FORMATIVA, Me.colUSUARIO_CREACION, Me.colFECHA_CREACION, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.GridControl = Me.ListaGRUPO_ACCION_CONTRATADAGridControl
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.Name = "ListaGRUPO_ACCION_CONTRATADAGridView"
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_GRUPO_ACCION
        '
        Me.colID_GRUPO_ACCION.Caption = "Id grupo accion"
        Me.colID_GRUPO_ACCION.FieldName = "ID_GRUPO_ACCION"
        Me.colID_GRUPO_ACCION.Name = "colID_GRUPO_ACCION"
        Me.colID_GRUPO_ACCION.Visible = True
        Me.colID_GRUPO_ACCION.VisibleIndex = 0
        '
        'colID_ACCION_CONTRATADA
        '
        Me.colID_ACCION_CONTRATADA.Caption = "Id accion contratada"
        Me.colID_ACCION_CONTRATADA.FieldName = "ID_ACCION_CONTRATADA"
        Me.colID_ACCION_CONTRATADA.Name = "colID_ACCION_CONTRATADA"
        Me.colID_ACCION_CONTRATADA.Visible = True
        Me.colID_ACCION_CONTRATADA.VisibleIndex = 1
        '
        'colID_GRUPO_AF
        '
        Me.colID_GRUPO_AF.Caption = "Id grupo af"
        Me.colID_GRUPO_AF.FieldName = "ID_GRUPO_AF"
        Me.colID_GRUPO_AF.Name = "colID_GRUPO_AF"
        Me.colID_GRUPO_AF.Visible = True
        Me.colID_GRUPO_AF.VisibleIndex = 2
        '
        'colID_ACCION_FORMATIVA
        '
        Me.colID_ACCION_FORMATIVA.Caption = "Id accion formativa"
        Me.colID_ACCION_FORMATIVA.FieldName = "ID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Name = "colID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Visible = True
        Me.colID_ACCION_FORMATIVA.VisibleIndex = 3
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
        'ucListaGRUPO_ACCION_CONTRATADA
        '
        Me.Controls.Add(Me.ListaGRUPO_ACCION_CONTRATADAGridControl)
        Me.Name = "ucListaGRUPO_ACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaGRUPO_ACCION_CONTRATADAGridControl, 0)
        CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_ACCION_CONTRATADAGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_ACCION_CONTRATADAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaGRUPO_ACCION_CONTRATADABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaGRUPO_ACCION_CONTRATADAGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaGRUPO_ACCION_CONTRATADAGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_GRUPO_ACCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ACCION_CONTRATADA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_GRUPO_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ACCION_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
