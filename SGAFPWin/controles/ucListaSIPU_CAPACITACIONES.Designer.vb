<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSIPU_CAPACITACIONES
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
        Me.ListaSIPU_CAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSIPU_CAPACITACIONESGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaSIPU_CAPACITACIONESGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDCAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDTIPOCAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHAINICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHAFIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_GENERACION = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaSIPU_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_CAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_CAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSIPU_CAPACITACIONESBindingSource
        '
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_CAPACITACIONES)
        '
        'ListaSIPU_CAPACITACIONESGridControl
        '
        Me.ListaSIPU_CAPACITACIONESGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSIPU_CAPACITACIONESGridControl.DataSource = Me.ListaSIPU_CAPACITACIONESBindingSource
        Me.ListaSIPU_CAPACITACIONESGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaSIPU_CAPACITACIONESGridControl.MainView = Me.ListaSIPU_CAPACITACIONESGridView
        Me.ListaSIPU_CAPACITACIONESGridControl.Name = "ListaSIPU_CAPACITACIONESGridControl"
        Me.ListaSIPU_CAPACITACIONESGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaSIPU_CAPACITACIONESGridControl.TabIndex = 1
        Me.ListaSIPU_CAPACITACIONESGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaSIPU_CAPACITACIONESGridView})
        '
        'ListaSIPU_CAPACITACIONESGridView
        '
        Me.ListaSIPU_CAPACITACIONESGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDCAPACITACION, Me.colDESCRIPCION, Me.colIDTIPOCAPACITACION, Me.colIDESTADO, Me.colFECHAINICIO, Me.colFECHAFIN, Me.colIDMUNICIPIO, Me.colID_GENERACION})
        Me.ListaSIPU_CAPACITACIONESGridView.GridControl = Me.ListaSIPU_CAPACITACIONESGridControl
        Me.ListaSIPU_CAPACITACIONESGridView.Name = "ListaSIPU_CAPACITACIONESGridView"
        Me.ListaSIPU_CAPACITACIONESGridView.OptionsView.ShowGroupPanel = False
        '
        'colIDCAPACITACION
        '
        Me.colIDCAPACITACION.Caption = "Idcapacitacion"
        Me.colIDCAPACITACION.FieldName = "IDCAPACITACION"
        Me.colIDCAPACITACION.Name = "colIDCAPACITACION"
        Me.colIDCAPACITACION.Visible = True
        Me.colIDCAPACITACION.VisibleIndex = 0
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        '
        'colIDTIPOCAPACITACION
        '
        Me.colIDTIPOCAPACITACION.Caption = "Idtipocapacitacion"
        Me.colIDTIPOCAPACITACION.FieldName = "IDTIPOCAPACITACION"
        Me.colIDTIPOCAPACITACION.Name = "colIDTIPOCAPACITACION"
        Me.colIDTIPOCAPACITACION.Visible = True
        Me.colIDTIPOCAPACITACION.VisibleIndex = 2
        '
        'colIDESTADO
        '
        Me.colIDESTADO.Caption = "Idestado"
        Me.colIDESTADO.FieldName = "IDESTADO"
        Me.colIDESTADO.Name = "colIDESTADO"
        Me.colIDESTADO.Visible = True
        Me.colIDESTADO.VisibleIndex = 3
        '
        'colFECHAINICIO
        '
        Me.colFECHAINICIO.Caption = "Fechainicio"
        Me.colFECHAINICIO.FieldName = "FECHAINICIO"
        Me.colFECHAINICIO.Name = "colFECHAINICIO"
        Me.colFECHAINICIO.Visible = True
        Me.colFECHAINICIO.VisibleIndex = 4
        '
        'colFECHAFIN
        '
        Me.colFECHAFIN.Caption = "Fechafin"
        Me.colFECHAFIN.FieldName = "FECHAFIN"
        Me.colFECHAFIN.Name = "colFECHAFIN"
        Me.colFECHAFIN.Visible = True
        Me.colFECHAFIN.VisibleIndex = 5
        '
        'colIDMUNICIPIO
        '
        Me.colIDMUNICIPIO.Caption = "Idmunicipio"
        Me.colIDMUNICIPIO.FieldName = "IDMUNICIPIO"
        Me.colIDMUNICIPIO.Name = "colIDMUNICIPIO"
        Me.colIDMUNICIPIO.Visible = True
        Me.colIDMUNICIPIO.VisibleIndex = 6
        '
        'colID_GENERACION
        '
        Me.colID_GENERACION.Caption = "Id generacion"
        Me.colID_GENERACION.FieldName = "ID_GENERACION"
        Me.colID_GENERACION.Name = "colID_GENERACION"
        Me.colID_GENERACION.Visible = True
        Me.colID_GENERACION.VisibleIndex = 7
        '
        'ucListaSIPU_CAPACITACIONES
        '
        Me.Controls.Add(Me.ListaSIPU_CAPACITACIONESGridControl)
        Me.Name = "ucListaSIPU_CAPACITACIONES"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSIPU_CAPACITACIONESGridControl, 0)
        CType(Me.ListaSIPU_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_CAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_CAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_CAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSIPU_CAPACITACIONESGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaSIPU_CAPACITACIONESGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDCAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTIPOCAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHAINICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHAFIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_GENERACION As DevExpress.XtraGrid.Columns.GridColumn

End Class
