<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociacionGruposPATI
    Inherits frmBase

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
        Me.ListaGRUPOS_PATIGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaGRUPOS_PATIGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSeleccion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_GRUPO_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDURACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AceptarSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.CencelarSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.colHABILITADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.ListaGRUPOS_PATIGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPOS_PATIGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaGRUPOS_PATIGridControl
        '
        Me.ListaGRUPOS_PATIGridControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaGRUPOS_PATIGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ListaGRUPOS_PATIGridControl.MainView = Me.ListaGRUPOS_PATIGridView
        Me.ListaGRUPOS_PATIGridControl.Name = "ListaGRUPOS_PATIGridControl"
        Me.ListaGRUPOS_PATIGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.ListaGRUPOS_PATIGridControl.Size = New System.Drawing.Size(842, 424)
        Me.ListaGRUPOS_PATIGridControl.TabIndex = 4
        Me.ListaGRUPOS_PATIGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaGRUPOS_PATIGridView})
        '
        'ListaGRUPOS_PATIGridView
        '
        Me.ListaGRUPOS_PATIGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccion, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colID_SOLICITUD, Me.colID_GRUPO_AF, Me.colNOMBRE_AF, Me.colDURACION, Me.colHABILITADO})
        Me.ListaGRUPOS_PATIGridView.GridControl = Me.ListaGRUPOS_PATIGridControl
        Me.ListaGRUPOS_PATIGridView.Name = "ListaGRUPOS_PATIGridView"
        Me.ListaGRUPOS_PATIGridView.OptionsView.ShowGroupPanel = False
        Me.ListaGRUPOS_PATIGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID_SOLICITUD, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMUNICIPIO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSeleccion
        '
        Me.colSeleccion.Caption = " "
        Me.colSeleccion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSeleccion.FieldName = "VALOR"
        Me.colSeleccion.MaxWidth = 40
        Me.colSeleccion.Name = "colSeleccion"
        Me.colSeleccion.Visible = True
        Me.colSeleccion.VisibleIndex = 0
        Me.colSeleccion.Width = 32
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "1"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "0"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemCheckEdit1.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 1
        Me.colDEPARTAMENTO.Width = 100
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 2
        Me.colMUNICIPIO.Width = 120
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.Caption = "Id Solicitud"
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.MaxWidth = 100
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        Me.colID_SOLICITUD.OptionsColumn.AllowEdit = False
        Me.colID_SOLICITUD.Visible = True
        Me.colID_SOLICITUD.VisibleIndex = 3
        Me.colID_SOLICITUD.Width = 100
        '
        'colID_GRUPO_AF
        '
        Me.colID_GRUPO_AF.Caption = "Id_Grupo_Af"
        Me.colID_GRUPO_AF.FieldName = "ID_GRUPO_AF"
        Me.colID_GRUPO_AF.MaxWidth = 100
        Me.colID_GRUPO_AF.Name = "colID_GRUPO_AF"
        Me.colID_GRUPO_AF.OptionsColumn.AllowEdit = False
        Me.colID_GRUPO_AF.Visible = True
        Me.colID_GRUPO_AF.VisibleIndex = 4
        Me.colID_GRUPO_AF.Width = 100
        '
        'colNOMBRE_AF
        '
        Me.colNOMBRE_AF.Caption = "Curso Solicitado"
        Me.colNOMBRE_AF.FieldName = "NOMBRE_AF"
        Me.colNOMBRE_AF.Name = "colNOMBRE_AF"
        Me.colNOMBRE_AF.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_AF.Visible = True
        Me.colNOMBRE_AF.VisibleIndex = 5
        Me.colNOMBRE_AF.Width = 320
        '
        'colDURACION
        '
        Me.colDURACION.AppearanceCell.Options.UseTextOptions = True
        Me.colDURACION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION.AppearanceHeader.Options.UseTextOptions = True
        Me.colDURACION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION.Caption = "Duracion"
        Me.colDURACION.FieldName = "DURACION_HORAS"
        Me.colDURACION.Name = "colDURACION"
        Me.colDURACION.OptionsColumn.AllowEdit = False
        Me.colDURACION.Visible = True
        Me.colDURACION.VisibleIndex = 6
        Me.colDURACION.Width = 88
        '
        'AceptarSimpleButton
        '
        Me.AceptarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AceptarSimpleButton.Location = New System.Drawing.Point(12, 433)
        Me.AceptarSimpleButton.Name = "AceptarSimpleButton"
        Me.AceptarSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarSimpleButton.TabIndex = 5
        Me.AceptarSimpleButton.Text = "Asociar"
        '
        'CencelarSimpleButton
        '
        Me.CencelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CencelarSimpleButton.Location = New System.Drawing.Point(105, 433)
        Me.CencelarSimpleButton.Name = "CencelarSimpleButton"
        Me.CencelarSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.CencelarSimpleButton.TabIndex = 6
        Me.CencelarSimpleButton.Text = "Cancelar"
        '
        'colHABILITADO
        '
        Me.colHABILITADO.AppearanceHeader.Options.UseTextOptions = True
        Me.colHABILITADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHABILITADO.Caption = "Habilitado"
        Me.colHABILITADO.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colHABILITADO.FieldName = "HABILITADO"
        Me.colHABILITADO.Name = "colHABILITADO"
        Me.colHABILITADO.OptionsColumn.AllowEdit = False
        Me.colHABILITADO.Visible = True
        Me.colHABILITADO.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.DisplayValueChecked = "1"
        Me.RepositoryItemCheckEdit2.DisplayValueUnchecked = "0"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit2.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemCheckEdit2.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmAsociacionGruposPATI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.CencelarSimpleButton)
        Me.Controls.Add(Me.AceptarSimpleButton)
        Me.Controls.Add(Me.ListaGRUPOS_PATIGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAsociacionGruposPATI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asociacion de Grupos PATI"
        Me.Controls.SetChildIndex(Me.ListaGRUPOS_PATIGridControl, 0)
        Me.Controls.SetChildIndex(Me.AceptarSimpleButton, 0)
        Me.Controls.SetChildIndex(Me.CencelarSimpleButton, 0)
        CType(Me.ListaGRUPOS_PATIGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPOS_PATIGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListaGRUPOS_PATIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaGRUPOS_PATIGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_GRUPO_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AceptarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CencelarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSeleccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHABILITADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
