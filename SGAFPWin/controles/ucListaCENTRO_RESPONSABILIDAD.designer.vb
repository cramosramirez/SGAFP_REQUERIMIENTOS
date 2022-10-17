<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCENTRO_RESPONSABILIDAD
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
        Me.ListaCENTRO_RESPONSABILIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCENTRO_RESPONSABILIDADGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaCENTRO_RESPONSABILIDADGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_CENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CENTRO_RESPONSABILIDAD_PADR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaCENTRO_RESPONSABILIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCENTRO_RESPONSABILIDADGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCENTRO_RESPONSABILIDADGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCENTRO_RESPONSABILIDADBindingSource
        '
        Me.ListaCENTRO_RESPONSABILIDADBindingSource.DataSource = GetType(SGAFP.EL.CENTRO_RESPONSABILIDAD)
        '
        'ListaCENTRO_RESPONSABILIDADGridControl
        '
        Me.ListaCENTRO_RESPONSABILIDADGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCENTRO_RESPONSABILIDADGridControl.DataSource = Me.ListaCENTRO_RESPONSABILIDADBindingSource
        Me.ListaCENTRO_RESPONSABILIDADGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaCENTRO_RESPONSABILIDADGridControl.MainView = Me.ListaCENTRO_RESPONSABILIDADGridView
        Me.ListaCENTRO_RESPONSABILIDADGridControl.Name = "ListaCENTRO_RESPONSABILIDADGridControl"
        Me.ListaCENTRO_RESPONSABILIDADGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaCENTRO_RESPONSABILIDADGridControl.TabIndex = 1
        Me.ListaCENTRO_RESPONSABILIDADGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaCENTRO_RESPONSABILIDADGridView})
        '
        'ListaCENTRO_RESPONSABILIDADGridView
        '
        Me.ListaCENTRO_RESPONSABILIDADGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_CENTRO_RESPONSABILIDAD, Me.colID_CENTRO_RESPONSABILIDAD_PADR, Me.colCODIGO_CENTRO_RESPONSABILIDAD, Me.colNOMBRE_CENTRO_RESPONSABILIDAD, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaCENTRO_RESPONSABILIDADGridView.GridControl = Me.ListaCENTRO_RESPONSABILIDADGridControl
        Me.ListaCENTRO_RESPONSABILIDADGridView.Name = "ListaCENTRO_RESPONSABILIDADGridView"
        Me.ListaCENTRO_RESPONSABILIDADGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_CENTRO_RESPONSABILIDAD
        '
        Me.colID_CENTRO_RESPONSABILIDAD.Caption = "Id centro responsabilidad"
        Me.colID_CENTRO_RESPONSABILIDAD.FieldName = "ID_CENTRO_RESPONSABILIDAD"
        Me.colID_CENTRO_RESPONSABILIDAD.Name = "colID_CENTRO_RESPONSABILIDAD"
        Me.colID_CENTRO_RESPONSABILIDAD.Visible = True
        Me.colID_CENTRO_RESPONSABILIDAD.VisibleIndex = 0
        '
        'colID_CENTRO_RESPONSABILIDAD_PADR
        '
        Me.colID_CENTRO_RESPONSABILIDAD_PADR.Caption = "Id centro responsabilidad padr"
        Me.colID_CENTRO_RESPONSABILIDAD_PADR.FieldName = "ID_CENTRO_RESPONSABILIDAD_PADR"
        Me.colID_CENTRO_RESPONSABILIDAD_PADR.Name = "colID_CENTRO_RESPONSABILIDAD_PADR"
        Me.colID_CENTRO_RESPONSABILIDAD_PADR.Visible = True
        Me.colID_CENTRO_RESPONSABILIDAD_PADR.VisibleIndex = 1
        '
        'colCODIGO_CENTRO_RESPONSABILIDAD
        '
        Me.colCODIGO_CENTRO_RESPONSABILIDAD.Caption = "Codigo centro responsabilidad"
        Me.colCODIGO_CENTRO_RESPONSABILIDAD.FieldName = "CODIGO_CENTRO_RESPONSABILIDAD"
        Me.colCODIGO_CENTRO_RESPONSABILIDAD.Name = "colCODIGO_CENTRO_RESPONSABILIDAD"
        Me.colCODIGO_CENTRO_RESPONSABILIDAD.Visible = True
        Me.colCODIGO_CENTRO_RESPONSABILIDAD.VisibleIndex = 2
        '
        'colNOMBRE_CENTRO_RESPONSABILIDAD
        '
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD.Caption = "Nombre centro responsabilidad"
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD.FieldName = "NOMBRE_CENTRO_RESPONSABILIDAD"
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD.Name = "colNOMBRE_CENTRO_RESPONSABILIDAD"
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD.Visible = True
        Me.colNOMBRE_CENTRO_RESPONSABILIDAD.VisibleIndex = 3
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.Visible = True
        Me.colUSERID.VisibleIndex = 4
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Visible = True
        Me.colLASTUPDATE.VisibleIndex = 5
        '
        'ucListaCENTRO_RESPONSABILIDAD
        '
        Me.Controls.Add(Me.ListaCENTRO_RESPONSABILIDADGridControl)
        Me.Name = "ucListaCENTRO_RESPONSABILIDAD"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCENTRO_RESPONSABILIDADGridControl, 0)
        CType(Me.ListaCENTRO_RESPONSABILIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCENTRO_RESPONSABILIDADGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCENTRO_RESPONSABILIDADGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCENTRO_RESPONSABILIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCENTRO_RESPONSABILIDADGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaCENTRO_RESPONSABILIDADGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_CENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CENTRO_RESPONSABILIDAD_PADR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CENTRO_RESPONSABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn

End Class
