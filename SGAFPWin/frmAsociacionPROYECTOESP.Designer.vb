<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociacionPROYECTOESP
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
        Me.ListaGRUPOS_PROYECTOSGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaGRUPOS_PROYECTOSGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_GRUPO_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_PROGRAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_AF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDURACION_HORAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_PARTICIPANTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHABILITADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colID_GRUPO_ACCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CencelarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.AceptarSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ListaGRUPOS_PROYECTOSGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPOS_PROYECTOSGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaGRUPOS_PROYECTOSGridControl
        '
        Me.ListaGRUPOS_PROYECTOSGridControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaGRUPOS_PROYECTOSGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ListaGRUPOS_PROYECTOSGridControl.MainView = Me.ListaGRUPOS_PROYECTOSGridView
        Me.ListaGRUPOS_PROYECTOSGridControl.Name = "ListaGRUPOS_PROYECTOSGridControl"
        Me.ListaGRUPOS_PROYECTOSGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.ListaGRUPOS_PROYECTOSGridControl.Size = New System.Drawing.Size(998, 424)
        Me.ListaGRUPOS_PROYECTOSGridControl.TabIndex = 5
        Me.ListaGRUPOS_PROYECTOSGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaGRUPOS_PROYECTOSGridView})
        '
        'ListaGRUPOS_PROYECTOSGridView
        '
        Me.ListaGRUPOS_PROYECTOSGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccion, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colID_SOLICITUD, Me.colID_GRUPO_SOLICITUD, Me.colFECHA_SOLICITUD, Me.colCODIGO_PROGRAMA, Me.colNOMBRE_AF, Me.colDURACION_HORAS, Me.colNUM_PARTICIPANTES, Me.colHABILITADO, Me.colID_GRUPO_ACCION})
        Me.ListaGRUPOS_PROYECTOSGridView.GridControl = Me.ListaGRUPOS_PROYECTOSGridControl
        Me.ListaGRUPOS_PROYECTOSGridView.Name = "ListaGRUPOS_PROYECTOSGridView"
        Me.ListaGRUPOS_PROYECTOSGridView.OptionsView.ShowGroupPanel = False
        Me.ListaGRUPOS_PROYECTOSGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID_SOLICITUD, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMUNICIPIO, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        Me.colSeleccion.Width = 39
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
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 1
        Me.colDEPARTAMENTO.Width = 105
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 2
        Me.colMUNICIPIO.Width = 137
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
        'colID_GRUPO_SOLICITUD
        '
        Me.colID_GRUPO_SOLICITUD.Caption = "Id Grupo"
        Me.colID_GRUPO_SOLICITUD.FieldName = "ID_GRUPO_SOLICITUD"
        Me.colID_GRUPO_SOLICITUD.MaxWidth = 100
        Me.colID_GRUPO_SOLICITUD.Name = "colID_GRUPO_SOLICITUD"
        Me.colID_GRUPO_SOLICITUD.OptionsColumn.AllowEdit = False
        Me.colID_GRUPO_SOLICITUD.Width = 100
        '
        'colFECHA_SOLICITUD
        '
        Me.colFECHA_SOLICITUD.Caption = "Fecha Solicitud"
        Me.colFECHA_SOLICITUD.FieldName = "FECHA_SOLICITUD"
        Me.colFECHA_SOLICITUD.Name = "colFECHA_SOLICITUD"
        Me.colFECHA_SOLICITUD.OptionsColumn.AllowEdit = False
        Me.colFECHA_SOLICITUD.Visible = True
        Me.colFECHA_SOLICITUD.VisibleIndex = 4
        Me.colFECHA_SOLICITUD.Width = 79
        '
        'colCODIGO_PROGRAMA
        '
        Me.colCODIGO_PROGRAMA.Caption = "Codigo Programa"
        Me.colCODIGO_PROGRAMA.FieldName = "CODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Name = "colCODIGO_PROGRAMA"
        '
        'colNOMBRE_AF
        '
        Me.colNOMBRE_AF.Caption = "Curso Solicitado"
        Me.colNOMBRE_AF.FieldName = "colNOMBRE_AF"
        Me.colNOMBRE_AF.Name = "colNOMBRE_AF"
        Me.colNOMBRE_AF.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_AF.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNOMBRE_AF.Visible = True
        Me.colNOMBRE_AF.VisibleIndex = 5
        Me.colNOMBRE_AF.Width = 300
        '
        'colDURACION_HORAS
        '
        Me.colDURACION_HORAS.AppearanceCell.Options.UseTextOptions = True
        Me.colDURACION_HORAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION_HORAS.AppearanceHeader.Options.UseTextOptions = True
        Me.colDURACION_HORAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION_HORAS.Caption = "Duracion (Horas)"
        Me.colDURACION_HORAS.FieldName = "DURACION_HORAS"
        Me.colDURACION_HORAS.Name = "colDURACION_HORAS"
        Me.colDURACION_HORAS.OptionsColumn.AllowEdit = False
        Me.colDURACION_HORAS.Visible = True
        Me.colDURACION_HORAS.VisibleIndex = 6
        Me.colDURACION_HORAS.Width = 113
        '
        'colNUM_PARTICIPANTES
        '
        Me.colNUM_PARTICIPANTES.Caption = "Cant. Participantes"
        Me.colNUM_PARTICIPANTES.FieldName = "NUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.Name = "colNUM_PARTICIPANTES"
        Me.colNUM_PARTICIPANTES.OptionsColumn.AllowEdit = False
        Me.colNUM_PARTICIPANTES.Visible = True
        Me.colNUM_PARTICIPANTES.VisibleIndex = 7
        Me.colNUM_PARTICIPANTES.Width = 107
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
        Me.colHABILITADO.VisibleIndex = 8
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
        'colID_GRUPO_ACCION
        '
        Me.colID_GRUPO_ACCION.Caption = "Id Grupo Accion"
        Me.colID_GRUPO_ACCION.FieldName = "ID_GRUPO_ACCION"
        Me.colID_GRUPO_ACCION.Name = "colID_GRUPO_ACCION"
        '
        'CencelarSimpleButton
        '
        Me.CencelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CencelarSimpleButton.Location = New System.Drawing.Point(105, 434)
        Me.CencelarSimpleButton.Name = "CencelarSimpleButton"
        Me.CencelarSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.CencelarSimpleButton.TabIndex = 8
        Me.CencelarSimpleButton.Text = "Cancelar"
        '
        'AceptarSimpleButton
        '
        Me.AceptarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AceptarSimpleButton.Location = New System.Drawing.Point(12, 434)
        Me.AceptarSimpleButton.Name = "AceptarSimpleButton"
        Me.AceptarSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarSimpleButton.TabIndex = 7
        Me.AceptarSimpleButton.Text = "Asociar"
        '
        'frmAsociacionPROYECTOESP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.CencelarSimpleButton)
        Me.Controls.Add(Me.AceptarSimpleButton)
        Me.Controls.Add(Me.ListaGRUPOS_PROYECTOSGridControl)
        Me.Name = "frmAsociacionPROYECTOESP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asociacion de Grupos en Solicitud de Capacitación"
        Me.Controls.SetChildIndex(Me.ListaGRUPOS_PROYECTOSGridControl, 0)
        Me.Controls.SetChildIndex(Me.AceptarSimpleButton, 0)
        Me.Controls.SetChildIndex(Me.CencelarSimpleButton, 0)
        CType(Me.ListaGRUPOS_PROYECTOSGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPOS_PROYECTOSGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListaGRUPOS_PROYECTOSGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaGRUPOS_PROYECTOSGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_GRUPO_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION_HORAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CencelarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AceptarSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colFECHA_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_PARTICIPANTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PROGRAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHABILITADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colID_GRUPO_ACCION As DevExpress.XtraGrid.Columns.GridColumn
End Class
