<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSIPU_MUNICIPIO
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
        Me.ListaSIPU_MUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSIPU_MUNICIPIOGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaSIPU_MUNICIPIOGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODMUNICIPIOFIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPTO_INSAFORP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNI_INSAFORP = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaSIPU_MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_MUNICIPIOGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_MUNICIPIOGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSIPU_MUNICIPIOBindingSource
        '
        Me.ListaSIPU_MUNICIPIOBindingSource.DataSource = GetType(SGAFP.EL.SIPU_MUNICIPIO)
        '
        'ListaSIPU_MUNICIPIOGridControl
        '
        Me.ListaSIPU_MUNICIPIOGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSIPU_MUNICIPIOGridControl.DataSource = Me.ListaSIPU_MUNICIPIOBindingSource
        Me.ListaSIPU_MUNICIPIOGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaSIPU_MUNICIPIOGridControl.MainView = Me.ListaSIPU_MUNICIPIOGridView
        Me.ListaSIPU_MUNICIPIOGridControl.Name = "ListaSIPU_MUNICIPIOGridControl"
        Me.ListaSIPU_MUNICIPIOGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaSIPU_MUNICIPIOGridControl.TabIndex = 1
        Me.ListaSIPU_MUNICIPIOGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaSIPU_MUNICIPIOGridView})
        '
        'ListaSIPU_MUNICIPIOGridView
        '
        Me.ListaSIPU_MUNICIPIOGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDMUNICIPIO, Me.colDESCRIPCION, Me.colIDDEPARTAMENTO, Me.colCODMUNICIPIOFIS, Me.colCODIGO_DEPTO_INSAFORP, Me.colCODIGO_MUNI_INSAFORP})
        Me.ListaSIPU_MUNICIPIOGridView.GridControl = Me.ListaSIPU_MUNICIPIOGridControl
        Me.ListaSIPU_MUNICIPIOGridView.Name = "ListaSIPU_MUNICIPIOGridView"
        Me.ListaSIPU_MUNICIPIOGridView.OptionsView.ShowGroupPanel = False
        '
        'colIDMUNICIPIO
        '
        Me.colIDMUNICIPIO.Caption = "Idmunicipio"
        Me.colIDMUNICIPIO.FieldName = "IDMUNICIPIO"
        Me.colIDMUNICIPIO.Name = "colIDMUNICIPIO"
        Me.colIDMUNICIPIO.Visible = True
        Me.colIDMUNICIPIO.VisibleIndex = 0
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        '
        'colIDDEPARTAMENTO
        '
        Me.colIDDEPARTAMENTO.Caption = "Iddepartamento"
        Me.colIDDEPARTAMENTO.FieldName = "IDDEPARTAMENTO"
        Me.colIDDEPARTAMENTO.Name = "colIDDEPARTAMENTO"
        Me.colIDDEPARTAMENTO.Visible = True
        Me.colIDDEPARTAMENTO.VisibleIndex = 2
        '
        'colCODMUNICIPIOFIS
        '
        Me.colCODMUNICIPIOFIS.Caption = "Codmunicipiofis"
        Me.colCODMUNICIPIOFIS.FieldName = "CODMUNICIPIOFIS"
        Me.colCODMUNICIPIOFIS.Name = "colCODMUNICIPIOFIS"
        Me.colCODMUNICIPIOFIS.Visible = True
        Me.colCODMUNICIPIOFIS.VisibleIndex = 3
        '
        'colCODIGO_DEPTO_INSAFORP
        '
        Me.colCODIGO_DEPTO_INSAFORP.Caption = "Codigo depto insaforp"
        Me.colCODIGO_DEPTO_INSAFORP.FieldName = "CODIGO_DEPTO_INSAFORP"
        Me.colCODIGO_DEPTO_INSAFORP.Name = "colCODIGO_DEPTO_INSAFORP"
        Me.colCODIGO_DEPTO_INSAFORP.Visible = True
        Me.colCODIGO_DEPTO_INSAFORP.VisibleIndex = 4
        '
        'colCODIGO_MUNI_INSAFORP
        '
        Me.colCODIGO_MUNI_INSAFORP.Caption = "Codigo muni insaforp"
        Me.colCODIGO_MUNI_INSAFORP.FieldName = "CODIGO_MUNI_INSAFORP"
        Me.colCODIGO_MUNI_INSAFORP.Name = "colCODIGO_MUNI_INSAFORP"
        Me.colCODIGO_MUNI_INSAFORP.Visible = True
        Me.colCODIGO_MUNI_INSAFORP.VisibleIndex = 5
        '
        'ucListaSIPU_MUNICIPIO
        '
        Me.Controls.Add(Me.ListaSIPU_MUNICIPIOGridControl)
        Me.Name = "ucListaSIPU_MUNICIPIO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSIPU_MUNICIPIOGridControl, 0)
        CType(Me.ListaSIPU_MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_MUNICIPIOGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_MUNICIPIOGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_MUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSIPU_MUNICIPIOGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaSIPU_MUNICIPIOGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODMUNICIPIOFIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPTO_INSAFORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNI_INSAFORP As DevExpress.XtraGrid.Columns.GridColumn

End Class
