<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCONTRATO_COMPRA
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
        Me.components = New System.ComponentModel.Container()
        Me.ListaCONTRATO_COMPRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCONTRATO_COMPRAGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaCONTRATO_COMPRAGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_CONTRATO_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNO_CONTRATO_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNO_CONTRATO_COMPRAOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INGRESOOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO_CREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO_CREAOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_CREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_CREAOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO_ACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO_ACTOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_ACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_ACTOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDirty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_FIN_EJEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INI_EJEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORC_ASISTENCIA_MIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAGO_POR_PARTICIPACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.ListaCONTRATO_COMPRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_COMPRAGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_COMPRAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCONTRATO_COMPRABindingSource
        '
        Me.ListaCONTRATO_COMPRABindingSource.DataSource = GetType(SGAFP.EL.CONTRATO_COMPRA)
        '
        'ListaCONTRATO_COMPRAGridControl
        '
        Me.ListaCONTRATO_COMPRAGridControl.DataSource = Me.ListaCONTRATO_COMPRABindingSource
        Me.ListaCONTRATO_COMPRAGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaCONTRATO_COMPRAGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ListaCONTRATO_COMPRAGridControl.MainView = Me.ListaCONTRATO_COMPRAGridView
        Me.ListaCONTRATO_COMPRAGridControl.Name = "ListaCONTRATO_COMPRAGridControl"
        Me.ListaCONTRATO_COMPRAGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.ListaCONTRATO_COMPRAGridControl.Size = New System.Drawing.Size(720, 445)
        Me.ListaCONTRATO_COMPRAGridControl.TabIndex = 3
        Me.ListaCONTRATO_COMPRAGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaCONTRATO_COMPRAGridView})
        '
        'ListaCONTRATO_COMPRAGridView
        '
        Me.ListaCONTRATO_COMPRAGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_CONTRATO_COMPRA, Me.colNO_CONTRATO_COMPRA, Me.colNO_CONTRATO_COMPRAOld, Me.colFECHA_INGRESO, Me.colFECHA_INGRESOOld, Me.colUSUARIO_CREA, Me.colUSUARIO_CREAOld, Me.colFECHA_CREA, Me.colFECHA_CREAOld, Me.colUSUARIO_ACT, Me.colUSUARIO_ACTOld, Me.colFECHA_ACT, Me.colFECHA_ACTOld, Me.colIsDirty, Me.colFECHA_FIN_EJEC, Me.colFECHA_INI_EJEC, Me.colPORC_ASISTENCIA_MIN, Me.GridColumn1, Me.colPAGO_POR_PARTICIPACION})
        Me.ListaCONTRATO_COMPRAGridView.GridControl = Me.ListaCONTRATO_COMPRAGridControl
        Me.ListaCONTRATO_COMPRAGridView.Name = "ListaCONTRATO_COMPRAGridView"
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.Editable = False
        Me.ListaCONTRATO_COMPRAGridView.OptionsBehavior.ReadOnly = True
        Me.ListaCONTRATO_COMPRAGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_CONTRATO_COMPRA
        '
        Me.colID_CONTRATO_COMPRA.FieldName = "ID_CONTRATO_COMPRA"
        Me.colID_CONTRATO_COMPRA.Name = "colID_CONTRATO_COMPRA"
        '
        'colNO_CONTRATO_COMPRA
        '
        Me.colNO_CONTRATO_COMPRA.Caption = "No. Oferta de Compra"
        Me.colNO_CONTRATO_COMPRA.FieldName = "NO_CONTRATO_COMPRA"
        Me.colNO_CONTRATO_COMPRA.Name = "colNO_CONTRATO_COMPRA"
        Me.colNO_CONTRATO_COMPRA.Visible = True
        Me.colNO_CONTRATO_COMPRA.VisibleIndex = 0
        Me.colNO_CONTRATO_COMPRA.Width = 135
        '
        'colNO_CONTRATO_COMPRAOld
        '
        Me.colNO_CONTRATO_COMPRAOld.FieldName = "NO_CONTRATO_COMPRAOld"
        Me.colNO_CONTRATO_COMPRAOld.Name = "colNO_CONTRATO_COMPRAOld"
        '
        'colFECHA_INGRESO
        '
        Me.colFECHA_INGRESO.Caption = "Fecha de Ingreso"
        Me.colFECHA_INGRESO.FieldName = "FECHA_INGRESO"
        Me.colFECHA_INGRESO.Name = "colFECHA_INGRESO"
        Me.colFECHA_INGRESO.Visible = True
        Me.colFECHA_INGRESO.VisibleIndex = 1
        Me.colFECHA_INGRESO.Width = 98
        '
        'colFECHA_INGRESOOld
        '
        Me.colFECHA_INGRESOOld.FieldName = "FECHA_INGRESOOld"
        Me.colFECHA_INGRESOOld.Name = "colFECHA_INGRESOOld"
        '
        'colUSUARIO_CREA
        '
        Me.colUSUARIO_CREA.FieldName = "USUARIO_CREA"
        Me.colUSUARIO_CREA.Name = "colUSUARIO_CREA"
        '
        'colUSUARIO_CREAOld
        '
        Me.colUSUARIO_CREAOld.FieldName = "USUARIO_CREAOld"
        Me.colUSUARIO_CREAOld.Name = "colUSUARIO_CREAOld"
        '
        'colFECHA_CREA
        '
        Me.colFECHA_CREA.FieldName = "FECHA_CREA"
        Me.colFECHA_CREA.Name = "colFECHA_CREA"
        '
        'colFECHA_CREAOld
        '
        Me.colFECHA_CREAOld.FieldName = "FECHA_CREAOld"
        Me.colFECHA_CREAOld.Name = "colFECHA_CREAOld"
        '
        'colUSUARIO_ACT
        '
        Me.colUSUARIO_ACT.FieldName = "USUARIO_ACT"
        Me.colUSUARIO_ACT.Name = "colUSUARIO_ACT"
        '
        'colUSUARIO_ACTOld
        '
        Me.colUSUARIO_ACTOld.FieldName = "USUARIO_ACTOld"
        Me.colUSUARIO_ACTOld.Name = "colUSUARIO_ACTOld"
        '
        'colFECHA_ACT
        '
        Me.colFECHA_ACT.FieldName = "FECHA_ACT"
        Me.colFECHA_ACT.Name = "colFECHA_ACT"
        '
        'colFECHA_ACTOld
        '
        Me.colFECHA_ACTOld.FieldName = "FECHA_ACTOld"
        Me.colFECHA_ACTOld.Name = "colFECHA_ACTOld"
        '
        'colIsDirty
        '
        Me.colIsDirty.FieldName = "IsDirty"
        Me.colIsDirty.Name = "colIsDirty"
        '
        'colFECHA_FIN_EJEC
        '
        Me.colFECHA_FIN_EJEC.Caption = "Fecha Validez Inicial"
        Me.colFECHA_FIN_EJEC.FieldName = "FECHA_FIN_EJEC"
        Me.colFECHA_FIN_EJEC.Name = "colFECHA_FIN_EJEC"
        Me.colFECHA_FIN_EJEC.Visible = True
        Me.colFECHA_FIN_EJEC.VisibleIndex = 2
        Me.colFECHA_FIN_EJEC.Width = 98
        '
        'colFECHA_INI_EJEC
        '
        Me.colFECHA_INI_EJEC.Caption = "Fecha Validez Final"
        Me.colFECHA_INI_EJEC.FieldName = "FECHA_INI_EJEC"
        Me.colFECHA_INI_EJEC.Name = "colFECHA_INI_EJEC"
        Me.colFECHA_INI_EJEC.Visible = True
        Me.colFECHA_INI_EJEC.VisibleIndex = 3
        Me.colFECHA_INI_EJEC.Width = 110
        '
        'colPORC_ASISTENCIA_MIN
        '
        Me.colPORC_ASISTENCIA_MIN.Caption = "Porc. mínimo asistencia"
        Me.colPORC_ASISTENCIA_MIN.FieldName = "PORC_ASISTENCIA_MIN"
        Me.colPORC_ASISTENCIA_MIN.Name = "colPORC_ASISTENCIA_MIN"
        Me.colPORC_ASISTENCIA_MIN.Visible = True
        Me.colPORC_ASISTENCIA_MIN.VisibleIndex = 4
        Me.colPORC_ASISTENCIA_MIN.Width = 125
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Pago por Participación"
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundExpression = "Iif([PAGO_POR_PARTICIPACION] == 1,True  ,False )"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 136
        '
        'colPAGO_POR_PARTICIPACION
        '
        Me.colPAGO_POR_PARTICIPACION.FieldName = "PAGO_POR_PARTICIPACION"
        Me.colPAGO_POR_PARTICIPACION.Name = "colPAGO_POR_PARTICIPACION"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ucListaCONTRATO_COMPRA
        '
        Me.Controls.Add(Me.ListaCONTRATO_COMPRAGridControl)
        Me.Name = "ucListaCONTRATO_COMPRA"
        Me.Size = New System.Drawing.Size(720, 470)
        Me.Controls.SetChildIndex(Me.ListaCONTRATO_COMPRAGridControl, 0)
        CType(Me.ListaCONTRATO_COMPRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_COMPRAGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_COMPRAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTRATO_COMPRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCONTRATO_COMPRAGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaCONTRATO_COMPRAGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_CONTRATO_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_CONTRATO_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_CONTRATO_COMPRAOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INGRESOOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREAOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREAOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_ACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_ACTOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ACTOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDirty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FIN_EJEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INI_EJEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORC_ASISTENCIA_MIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGO_POR_PARTICIPACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
