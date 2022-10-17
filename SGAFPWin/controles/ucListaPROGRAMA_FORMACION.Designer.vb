<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPROGRAMA_FORMACION
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
        Me.ListaPROGRAMA_FORMACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPROGRAMA_FORMACIONGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaPROGRAMA_FORMACIONGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPORC_ASISTENCIA_MINIMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOTA_MINIMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_TIPO_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaPROGRAMA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROGRAMA_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROGRAMA_FORMACIONGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPROGRAMA_FORMACIONBindingSource
        '
        Me.ListaPROGRAMA_FORMACIONBindingSource.DataSource = GetType(SGAFP.EL.PROGRAMA_FORMACION)
        '
        'ListaPROGRAMA_FORMACIONGridControl
        '
        Me.ListaPROGRAMA_FORMACIONGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPROGRAMA_FORMACIONGridControl.DataSource = Me.ListaPROGRAMA_FORMACIONBindingSource
        Me.ListaPROGRAMA_FORMACIONGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaPROGRAMA_FORMACIONGridControl.MainView = Me.ListaPROGRAMA_FORMACIONGridView
        Me.ListaPROGRAMA_FORMACIONGridControl.Name = "ListaPROGRAMA_FORMACIONGridControl"
        Me.ListaPROGRAMA_FORMACIONGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaPROGRAMA_FORMACIONGridControl.TabIndex = 1
        Me.ListaPROGRAMA_FORMACIONGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaPROGRAMA_FORMACIONGridView})
        '
        'ListaPROGRAMA_FORMACIONGridView
        '
        Me.ListaPROGRAMA_FORMACIONGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PROGRAMA_FORMACION, Me.colNOMBRE_PROGRAMA_FORMACION, Me.colUSERID, Me.colLASTUPDATE, Me.colPORC_ASISTENCIA_MINIMA, Me.colNOTA_MINIMA, Me.colID_TIPO_PAGO})
        Me.ListaPROGRAMA_FORMACIONGridView.GridControl = Me.ListaPROGRAMA_FORMACIONGridControl
        Me.ListaPROGRAMA_FORMACIONGridView.Name = "ListaPROGRAMA_FORMACIONGridView"
        Me.ListaPROGRAMA_FORMACIONGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_PROGRAMA_FORMACION
        '
        Me.colID_PROGRAMA_FORMACION.Caption = "Id programa formacion"
        Me.colID_PROGRAMA_FORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Name = "colID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Visible = True
        Me.colID_PROGRAMA_FORMACION.VisibleIndex = 0
        '
        'colNOMBRE_PROGRAMA_FORMACION
        '
        Me.colNOMBRE_PROGRAMA_FORMACION.Caption = "Nombre programa formacion"
        Me.colNOMBRE_PROGRAMA_FORMACION.FieldName = "NOMBRE_PROGRAMA_FORMACION"
        Me.colNOMBRE_PROGRAMA_FORMACION.Name = "colNOMBRE_PROGRAMA_FORMACION"
        Me.colNOMBRE_PROGRAMA_FORMACION.Visible = True
        Me.colNOMBRE_PROGRAMA_FORMACION.VisibleIndex = 1
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 2
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 3
        '
        'colPORC_ASISTENCIA_MINIMA
        '
        Me.colPORC_ASISTENCIA_MINIMA.Caption = "Porc asistencia minima"
        Me.colPORC_ASISTENCIA_MINIMA.FieldName = "PORC_ASISTENCIA_MINIMA"
        Me.colPORC_ASISTENCIA_MINIMA.Name = "colPORC_ASISTENCIA_MINIMA"
        Me.colPORC_ASISTENCIA_MINIMA.Visible = True
        Me.colPORC_ASISTENCIA_MINIMA.VisibleIndex = 4
        '
        'colNOTA_MINIMA
        '
        Me.colNOTA_MINIMA.Caption = "Nota minima"
        Me.colNOTA_MINIMA.FieldName = "NOTA_MINIMA"
        Me.colNOTA_MINIMA.Name = "colNOTA_MINIMA"
        Me.colNOTA_MINIMA.Visible = True
        Me.colNOTA_MINIMA.VisibleIndex = 5
        '
        'colID_TIPO_PAGO
        '
        Me.colID_TIPO_PAGO.Caption = "Id tipo pago"
        Me.colID_TIPO_PAGO.FieldName = "ID_TIPO_PAGO"
        Me.colID_TIPO_PAGO.Name = "colID_TIPO_PAGO"
        Me.colID_TIPO_PAGO.Visible = True
        Me.colID_TIPO_PAGO.VisibleIndex = 6
        '
        'ucListaPROGRAMA_FORMACION
        '
        Me.Controls.Add(Me.ListaPROGRAMA_FORMACIONGridControl)
        Me.Name = "ucListaPROGRAMA_FORMACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPROGRAMA_FORMACIONGridControl, 0)
        CType(Me.ListaPROGRAMA_FORMACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROGRAMA_FORMACIONGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROGRAMA_FORMACIONGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROGRAMA_FORMACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPROGRAMA_FORMACIONGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaPROGRAMA_FORMACIONGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORC_ASISTENCIA_MINIMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTA_MINIMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_TIPO_PAGO As DevExpress.XtraGrid.Columns.GridColumn

End Class
