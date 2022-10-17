<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCENTRO_RESPONSABILIDAD_UNIDAD
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
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_CENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_UNIDAD_ORGANIZATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource
        '
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.DataSource = GetType(SGAFP.EL.CENTRO_RESPONSABILIDAD_UNIDAD)
        '
        'ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl
        '
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.DataSource = Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.MainView = Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Name = "ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl"
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.TabIndex = 1
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView})
        '
        'ListaCENTRO_RESPONSABILIDAD_UNIDADGridView
        '
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_CENTRO_RESPONSABILIDAD, Me.colID_UNIDAD_ORGANIZATIVA, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.GridControl = Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.Name = "ListaCENTRO_RESPONSABILIDAD_UNIDADGridView"
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_CENTRO_RESPONSABILIDAD
        '
        Me.colID_CENTRO_RESPONSABILIDAD.Caption = "Id centro responsabilidad"
        Me.colID_CENTRO_RESPONSABILIDAD.FieldName = "ID_CENTRO_RESPONSABILIDAD"
        Me.colID_CENTRO_RESPONSABILIDAD.Name = "colID_CENTRO_RESPONSABILIDAD"
        Me.colID_CENTRO_RESPONSABILIDAD.Visible = True
        Me.colID_CENTRO_RESPONSABILIDAD.VisibleIndex = 0
        '
        'colID_UNIDAD_ORGANIZATIVA
        '
        Me.colID_UNIDAD_ORGANIZATIVA.Caption = "Id unidad organizativa"
        Me.colID_UNIDAD_ORGANIZATIVA.FieldName = "ID_UNIDAD_ORGANIZATIVA"
        Me.colID_UNIDAD_ORGANIZATIVA.Name = "colID_UNIDAD_ORGANIZATIVA"
        Me.colID_UNIDAD_ORGANIZATIVA.Visible = True
        Me.colID_UNIDAD_ORGANIZATIVA.VisibleIndex = 1
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
        'ucListaCENTRO_RESPONSABILIDAD_UNIDAD
        '
        Me.Controls.Add(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl)
        Me.Name = "ucListaCENTRO_RESPONSABILIDAD_UNIDAD"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl, 0)
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaCENTRO_RESPONSABILIDAD_UNIDADGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_CENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_UNIDAD_ORGANIZATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
