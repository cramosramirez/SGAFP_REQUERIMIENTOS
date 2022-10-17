<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaTERMINO_REFERENCIA_AF
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
        Me.ListaTERMINO_REFERENCIA_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTERMINO_REFERENCIA_AFGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaTERMINO_REFERENCIA_AFGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_ACCION_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_ADJUDICADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCORRELATIVO_GRUPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaTERMINO_REFERENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTERMINO_REFERENCIA_AFGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTERMINO_REFERENCIA_AFGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaTERMINO_REFERENCIA_AFBindingSource
        '
        Me.ListaTERMINO_REFERENCIA_AFBindingSource.DataSource = GetType(SGAFP.EL.TERMINO_REFERENCIA_AF)
        '
        'ListaTERMINO_REFERENCIA_AFGridControl
        '
        Me.ListaTERMINO_REFERENCIA_AFGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaTERMINO_REFERENCIA_AFGridControl.DataSource = Me.ListaTERMINO_REFERENCIA_AFBindingSource
        Me.ListaTERMINO_REFERENCIA_AFGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaTERMINO_REFERENCIA_AFGridControl.MainView = Me.ListaTERMINO_REFERENCIA_AFGridView
        Me.ListaTERMINO_REFERENCIA_AFGridControl.Name = "ListaTERMINO_REFERENCIA_AFGridControl"
        Me.ListaTERMINO_REFERENCIA_AFGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaTERMINO_REFERENCIA_AFGridControl.TabIndex = 1
        Me.ListaTERMINO_REFERENCIA_AFGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaTERMINO_REFERENCIA_AFGridView})
        '
        'ListaTERMINO_REFERENCIA_AFGridView
        '
        Me.ListaTERMINO_REFERENCIA_AFGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_ACCION_FORMATIVA, Me.colRESOLUCION, Me.colTDR, Me.colMONTO_ADJUDICADO, Me.colUSERID, Me.colLASTUPDATE, Me.colCORRELATIVO_GRUPO, Me.colID_SOLICITUD})
        Me.ListaTERMINO_REFERENCIA_AFGridView.GridControl = Me.ListaTERMINO_REFERENCIA_AFGridControl
        Me.ListaTERMINO_REFERENCIA_AFGridView.Name = "ListaTERMINO_REFERENCIA_AFGridView"
        Me.ListaTERMINO_REFERENCIA_AFGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_ACCION_FORMATIVA
        '
        Me.colID_ACCION_FORMATIVA.Caption = "Id accion formativa"
        Me.colID_ACCION_FORMATIVA.FieldName = "ID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Name = "colID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Visible = True
        Me.colID_ACCION_FORMATIVA.VisibleIndex = 0
        '
        'colRESOLUCION
        '
        Me.colRESOLUCION.Caption = "Resolucion"
        Me.colRESOLUCION.FieldName = "RESOLUCION"
        Me.colRESOLUCION.Name = "colRESOLUCION"
        Me.colRESOLUCION.Visible = True
        Me.colRESOLUCION.VisibleIndex = 1
        '
        'colTDR
        '
        Me.colTDR.Caption = "Tdr"
        Me.colTDR.FieldName = "TDR"
        Me.colTDR.Name = "colTDR"
        Me.colTDR.Visible = True
        Me.colTDR.VisibleIndex = 2
        '
        'colMONTO_ADJUDICADO
        '
        Me.colMONTO_ADJUDICADO.Caption = "Monto adjudicado"
        Me.colMONTO_ADJUDICADO.FieldName = "MONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Name = "colMONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Visible = True
        Me.colMONTO_ADJUDICADO.VisibleIndex = 3
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
        'colCORRELATIVO_GRUPO
        '
        Me.colCORRELATIVO_GRUPO.Caption = "Correlativo grupo"
        Me.colCORRELATIVO_GRUPO.FieldName = "CORRELATIVO_GRUPO"
        Me.colCORRELATIVO_GRUPO.Name = "colCORRELATIVO_GRUPO"
        Me.colCORRELATIVO_GRUPO.Visible = True
        Me.colCORRELATIVO_GRUPO.VisibleIndex = 6
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.Caption = "Id solicitud"
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        Me.colID_SOLICITUD.Visible = True
        Me.colID_SOLICITUD.VisibleIndex = 7
        '
        'ucListaTERMINO_REFERENCIA_AF
        '
        Me.Controls.Add(Me.ListaTERMINO_REFERENCIA_AFGridControl)
        Me.Name = "ucListaTERMINO_REFERENCIA_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaTERMINO_REFERENCIA_AFGridControl, 0)
        CType(Me.ListaTERMINO_REFERENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTERMINO_REFERENCIA_AFGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTERMINO_REFERENCIA_AFGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTERMINO_REFERENCIA_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTERMINO_REFERENCIA_AFGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaTERMINO_REFERENCIA_AFGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_ACCION_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_ADJUDICADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCORRELATIVO_GRUPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn

End Class
