<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaREFERENTE
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
        Me.ListaREFERENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaREFERENTEGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaREFERENTEGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEF_MOVIL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFAX = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDOS_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMAIL_CONTACTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaREFERENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaREFERENTEGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaREFERENTEGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaREFERENTEBindingSource
        '
        Me.ListaREFERENTEBindingSource.DataSource = GetType(SGAFP.EL.REFERENTE)
        '
        'ListaREFERENTEGridControl
        '
        Me.ListaREFERENTEGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaREFERENTEGridControl.DataSource = Me.ListaREFERENTEBindingSource
        Me.ListaREFERENTEGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaREFERENTEGridControl.MainView = Me.ListaREFERENTEGridView
        Me.ListaREFERENTEGridControl.Name = "ListaREFERENTEGridControl"
        Me.ListaREFERENTEGridControl.Size = New System.Drawing.Size(870, 323)
        Me.ListaREFERENTEGridControl.TabIndex = 1
        Me.ListaREFERENTEGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaREFERENTEGridView})
        '
        'ListaREFERENTEGridView
        '
        Me.ListaREFERENTEGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_REFERENTE, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colNOMBRE_REFERENTE, Me.colDIRECCION_REFERENTE, Me.colTELEF1, Me.colTELEF2, Me.colTELEF3, Me.colTELEF_MOVIL, Me.colFAX, Me.colNOMBRE_CONTACTO, Me.colAPELLIDOS_CONTACTO, Me.colEMAIL_CONTACTO, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaREFERENTEGridView.GridControl = Me.ListaREFERENTEGridControl
        Me.ListaREFERENTEGridView.Name = "ListaREFERENTEGridView"
        Me.ListaREFERENTEGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_REFERENTE
        '
        Me.colID_REFERENTE.Caption = "Id referente"
        Me.colID_REFERENTE.FieldName = "ID_REFERENTE"
        Me.colID_REFERENTE.Name = "colID_REFERENTE"
        Me.colID_REFERENTE.Visible = True
        Me.colID_REFERENTE.VisibleIndex = 0
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.Caption = "Codigo departamento"
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.Caption = "Codigo municipio"
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        '
        'colNOMBRE_REFERENTE
        '
        Me.colNOMBRE_REFERENTE.Caption = "Nombre referente"
        Me.colNOMBRE_REFERENTE.FieldName = "NOMBRE_REFERENTE"
        Me.colNOMBRE_REFERENTE.Name = "colNOMBRE_REFERENTE"
        Me.colNOMBRE_REFERENTE.Visible = True
        Me.colNOMBRE_REFERENTE.VisibleIndex = 3
        '
        'colDIRECCION_REFERENTE
        '
        Me.colDIRECCION_REFERENTE.Caption = "Direccion referente"
        Me.colDIRECCION_REFERENTE.FieldName = "DIRECCION_REFERENTE"
        Me.colDIRECCION_REFERENTE.Name = "colDIRECCION_REFERENTE"
        Me.colDIRECCION_REFERENTE.Visible = True
        Me.colDIRECCION_REFERENTE.VisibleIndex = 4
        '
        'colTELEF1
        '
        Me.colTELEF1.Caption = "Telef1"
        Me.colTELEF1.FieldName = "TELEF1"
        Me.colTELEF1.Name = "colTELEF1"
        Me.colTELEF1.Visible = True
        Me.colTELEF1.VisibleIndex = 5
        '
        'colTELEF2
        '
        Me.colTELEF2.Caption = "Telef2"
        Me.colTELEF2.FieldName = "TELEF2"
        Me.colTELEF2.Name = "colTELEF2"
        Me.colTELEF2.Visible = True
        Me.colTELEF2.VisibleIndex = 6
        '
        'colTELEF3
        '
        Me.colTELEF3.Caption = "Telef3"
        Me.colTELEF3.FieldName = "TELEF3"
        Me.colTELEF3.Name = "colTELEF3"
        Me.colTELEF3.Visible = True
        Me.colTELEF3.VisibleIndex = 7
        '
        'colTELEF_MOVIL
        '
        Me.colTELEF_MOVIL.Caption = "Telef movil"
        Me.colTELEF_MOVIL.FieldName = "TELEF_MOVIL"
        Me.colTELEF_MOVIL.Name = "colTELEF_MOVIL"
        Me.colTELEF_MOVIL.Visible = True
        Me.colTELEF_MOVIL.VisibleIndex = 8
        '
        'colFAX
        '
        Me.colFAX.Caption = "Fax"
        Me.colFAX.FieldName = "FAX"
        Me.colFAX.Name = "colFAX"
        Me.colFAX.Visible = True
        Me.colFAX.VisibleIndex = 9
        '
        'colNOMBRE_CONTACTO
        '
        Me.colNOMBRE_CONTACTO.Caption = "Nombre contacto"
        Me.colNOMBRE_CONTACTO.FieldName = "NOMBRE_CONTACTO"
        Me.colNOMBRE_CONTACTO.Name = "colNOMBRE_CONTACTO"
        Me.colNOMBRE_CONTACTO.Visible = True
        Me.colNOMBRE_CONTACTO.VisibleIndex = 10
        '
        'colAPELLIDOS_CONTACTO
        '
        Me.colAPELLIDOS_CONTACTO.Caption = "Apellidos contacto"
        Me.colAPELLIDOS_CONTACTO.FieldName = "APELLIDOS_CONTACTO"
        Me.colAPELLIDOS_CONTACTO.Name = "colAPELLIDOS_CONTACTO"
        Me.colAPELLIDOS_CONTACTO.Visible = True
        Me.colAPELLIDOS_CONTACTO.VisibleIndex = 11
        '
        'colEMAIL_CONTACTO
        '
        Me.colEMAIL_CONTACTO.Caption = "Email contacto"
        Me.colEMAIL_CONTACTO.FieldName = "EMAIL_CONTACTO"
        Me.colEMAIL_CONTACTO.Name = "colEMAIL_CONTACTO"
        Me.colEMAIL_CONTACTO.Visible = True
        Me.colEMAIL_CONTACTO.VisibleIndex = 12
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Lastupdate"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 1
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "colMUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 2
        '
        'ucListaREFERENTE
        '
        Me.Controls.Add(Me.ListaREFERENTEGridControl)
        Me.Name = "ucListaREFERENTE"
        Me.Size = New System.Drawing.Size(876, 354)
        Me.Controls.SetChildIndex(Me.ListaREFERENTEGridControl, 0)
        CType(Me.ListaREFERENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaREFERENTEGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaREFERENTEGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaREFERENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaREFERENTEGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaREFERENTEGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEF_MOVIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDOS_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL_CONTACTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn

End Class
