<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSIPU_DETALLECAPACITACIONES
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
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaSIPU_DETALLECAPACITACIONESGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDDETALLECAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCONVENIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_DETALLECAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSIPU_DETALLECAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSIPU_DETALLECAPACITACIONESBindingSource
        '
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.DataSource = GetType(SGAFP.EL.SIPU_DETALLECAPACITADO)
        '
        'ListaSIPU_DETALLECAPACITACIONESGridControl
        '
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.DataSource = Me.ListaSIPU_DETALLECAPACITACIONESBindingSource
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Location = New System.Drawing.Point(3, 28)
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.MainView = Me.ListaSIPU_DETALLECAPACITACIONESGridView
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Name = "ListaSIPU_DETALLECAPACITACIONESGridControl"
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Size = New System.Drawing.Size(523, 323)
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.TabIndex = 1
        Me.ListaSIPU_DETALLECAPACITACIONESGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaSIPU_DETALLECAPACITACIONESGridView})
        '
        'ListaSIPU_DETALLECAPACITACIONESGridView
        '
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDETALLECAPACITACION, Me.colID_CAPACITACION, Me.colCONVENIO, Me.colESTADO})
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.GridControl = Me.ListaSIPU_DETALLECAPACITACIONESGridControl
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.Name = "ListaSIPU_DETALLECAPACITACIONESGridView"
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.OptionsView.ShowGroupPanel = False
        '
        'colIDDETALLECAPACITACION
        '
        Me.colIDDETALLECAPACITACION.Caption = "Iddetallecapacitacion"
        Me.colIDDETALLECAPACITACION.FieldName = "IDDETALLECAPACITACION"
        Me.colIDDETALLECAPACITACION.Name = "colIDDETALLECAPACITACION"
        Me.colIDDETALLECAPACITACION.Visible = True
        Me.colIDDETALLECAPACITACION.VisibleIndex = 0
        '
        'colID_CAPACITACION
        '
        Me.colID_CAPACITACION.Caption = "Id capacitacion"
        Me.colID_CAPACITACION.FieldName = "ID_CAPACITACION"
        Me.colID_CAPACITACION.Name = "colID_CAPACITACION"
        Me.colID_CAPACITACION.Visible = True
        Me.colID_CAPACITACION.VisibleIndex = 1
        '
        'colCONVENIO
        '
        Me.colCONVENIO.Caption = "Convenio"
        Me.colCONVENIO.FieldName = "CONVENIO"
        Me.colCONVENIO.Name = "colCONVENIO"
        Me.colCONVENIO.Visible = True
        Me.colCONVENIO.VisibleIndex = 2
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Estado"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 3
        '
        'ucListaSIPU_DETALLECAPACITACIONES
        '
        Me.Controls.Add(Me.ListaSIPU_DETALLECAPACITACIONESGridControl)
        Me.Name = "ucListaSIPU_DETALLECAPACITACIONES"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSIPU_DETALLECAPACITACIONESGridControl, 0)
        CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_DETALLECAPACITACIONESGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSIPU_DETALLECAPACITACIONESGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSIPU_DETALLECAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSIPU_DETALLECAPACITACIONESGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaSIPU_DETALLECAPACITACIONESGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDDETALLECAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONVENIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn

End Class
