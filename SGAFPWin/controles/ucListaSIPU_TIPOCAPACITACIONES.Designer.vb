<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSIPU_TIPOCAPACITACIONES
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
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaSIPU_TIPOCAPACITACIONESGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDTIPOCAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_TIPOCAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_TIPOCAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSIPU_TIPOCAPACITACIONESBindingSource
        '
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_TIPOCAPACITACIONES)
        '
        'ListaSIPU_TIPOCAPACITACIONESGridControl
        '
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.DataSource = Me.ListaSIPU_TIPOCAPACITACIONESBindingSource
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.MainView = Me.ListaSIPU_TIPOCAPACITACIONESGridView
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Name = "ListaSIPU_TIPOCAPACITACIONESGridControl"
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.TabIndex = 1
        Me.ListaSIPU_TIPOCAPACITACIONESGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaSIPU_TIPOCAPACITACIONESGridView})
        '
        'ListaSIPU_TIPOCAPACITACIONESGridView
        '
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDTIPOCAPACITACION, Me.colDESCRIPCION})
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.GridControl = Me.ListaSIPU_TIPOCAPACITACIONESGridControl
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.Name = "ListaSIPU_TIPOCAPACITACIONESGridView"
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.OptionsView.ShowGroupPanel = False
        '
        'colIDTIPOCAPACITACION
        '
        Me.colIDTIPOCAPACITACION.Caption = "Idtipocapacitacion"
        Me.colIDTIPOCAPACITACION.FieldName = "IDTIPOCAPACITACION"
        Me.colIDTIPOCAPACITACION.Name = "colIDTIPOCAPACITACION"
        Me.colIDTIPOCAPACITACION.Visible = True
        Me.colIDTIPOCAPACITACION.VisibleIndex = 0
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        '
        'ucListaSIPU_TIPOCAPACITACIONES
        '
        Me.Controls.Add(Me.ListaSIPU_TIPOCAPACITACIONESGridControl)
        Me.Name = "ucListaSIPU_TIPOCAPACITACIONES"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSIPU_TIPOCAPACITACIONESGridControl, 0)
        CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_TIPOCAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_TIPOCAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_TIPOCAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSIPU_TIPOCAPACITACIONESGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaSIPU_TIPOCAPACITACIONESGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDTIPOCAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn

End Class
