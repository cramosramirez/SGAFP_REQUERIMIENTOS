<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPROGRAMA_FORMACION_TIPOPAGO
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
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_TIPO_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_TIPO_PAGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource
        '
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.DataSource = GetType(SGAFP.EL.PROGRAMA_FORMACION_TIPOPAGO)
        '
        'ListaPROGRAMA_FORMACION_TIPOPAGOGridControl
        '
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.DataSource = Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.MainView = Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Name = "ListaPROGRAMA_FORMACION_TIPOPAGOGridControl"
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.TabIndex = 1
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView})
        '
        'ListaPROGRAMA_FORMACION_TIPOPAGOGridView
        '
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_TIPO_PAGO, Me.colNOMBRE_TIPO_PAGO, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.GridControl = Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.Name = "ListaPROGRAMA_FORMACION_TIPOPAGOGridView"
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_TIPO_PAGO
        '
        Me.colID_TIPO_PAGO.Caption = "Id tipo pago"
        Me.colID_TIPO_PAGO.FieldName = "ID_TIPO_PAGO"
        Me.colID_TIPO_PAGO.Name = "colID_TIPO_PAGO"
        Me.colID_TIPO_PAGO.Visible = True
        Me.colID_TIPO_PAGO.VisibleIndex = 0
        '
        'colNOMBRE_TIPO_PAGO
        '
        Me.colNOMBRE_TIPO_PAGO.Caption = "Nombre tipo pago"
        Me.colNOMBRE_TIPO_PAGO.FieldName = "NOMBRE_TIPO_PAGO"
        Me.colNOMBRE_TIPO_PAGO.Name = "colNOMBRE_TIPO_PAGO"
        Me.colNOMBRE_TIPO_PAGO.Visible = True
        Me.colNOMBRE_TIPO_PAGO.VisibleIndex = 1
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
        'ucListaPROGRAMA_FORMACION_TIPOPAGO
        '
        Me.Controls.Add(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl)
        Me.Name = "ucListaPROGRAMA_FORMACION_TIPOPAGO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl, 0)
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPROGRAMA_FORMACION_TIPOPAGOGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaPROGRAMA_FORMACION_TIPOPAGOGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_TIPO_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_TIPO_PAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
