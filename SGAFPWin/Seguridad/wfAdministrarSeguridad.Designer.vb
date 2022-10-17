<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfAdministrarSeguridad
    Inherits SGAFP.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim ID_SITIO_CAPACITACIONLabel As System.Windows.Forms.Label
        Dim ID_PROVEEDOR_AFLabel As System.Windows.Forms.Label
        Dim ID_PARTICIPANTELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label

        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfAdministrarSeguridad))
        Me.ListaUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.tsbRecuperar = New System.Windows.Forms.ToolStripButton
        Me.ListaUSUARIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tstxtUsuario = New System.Windows.Forms.ToolStripTextBox
        Me.tsbBuscarUsuario = New System.Windows.Forms.ToolStripButton
        Me.USUARIOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.gleParticipante = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ListaPARTICIPANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombresApellidos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleProveedor = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ListaPROVEEDORAFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleSitioCapacitacion = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ListaSITIOCAPACITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_SITIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_SITIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tbRoles = New DevExpress.XtraTab.XtraTabPage
        Me.chklbRoles = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.tpOpciones = New DevExpress.XtraTab.XtraTabPage
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.txtClave = New DevExpress.XtraEditors.TextEdit
        Me.txtPreguntaSeguridad = New DevExpress.XtraEditors.TextEdit
        Me.txtRespuestaSeguridad = New DevExpress.XtraEditors.TextEdit
        Me.chkBloqueado = New DevExpress.XtraEditors.CheckEdit
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit
        USUARIOLabel = New System.Windows.Forms.Label
        ID_SITIO_CAPACITACIONLabel = New System.Windows.Forms.Label
        ID_PROVEEDOR_AFLabel = New System.Windows.Forms.Label
        ID_PARTICIPANTELabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        lblClave = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        lblRespuestaSeguridad = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaUSUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaUSUARIOBindingNavigator.SuspendLayout()
        CType(Me.USUARIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleParticipante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROVEEDORAFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleSitioCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tbRoles.SuspendLayout()
        CType(Me.chklbRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreguntaSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRespuestaSeguridad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBloqueado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Location = New System.Drawing.Point(12, 41)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(57, 13)
        USUARIOLabel.TabIndex = 11
        USUARIOLabel.Text = "USUARIO:"
        '
        'ID_SITIO_CAPACITACIONLabel
        '
        ID_SITIO_CAPACITACIONLabel.AutoSize = True
        ID_SITIO_CAPACITACIONLabel.Location = New System.Drawing.Point(11, 119)
        ID_SITIO_CAPACITACIONLabel.Name = "ID_SITIO_CAPACITACIONLabel"
        ID_SITIO_CAPACITACIONLabel.Size = New System.Drawing.Size(119, 13)
        ID_SITIO_CAPACITACIONLabel.TabIndex = 9
        ID_SITIO_CAPACITACIONLabel.Text = "SITIO CAPACITACION:"
        '
        'ID_PROVEEDOR_AFLabel
        '
        ID_PROVEEDOR_AFLabel.AutoSize = True
        ID_PROVEEDOR_AFLabel.Location = New System.Drawing.Point(12, 97)
        ID_PROVEEDOR_AFLabel.Name = "ID_PROVEEDOR_AFLabel"
        ID_PROVEEDOR_AFLabel.Size = New System.Drawing.Size(72, 13)
        ID_PROVEEDOR_AFLabel.TabIndex = 7
        ID_PROVEEDOR_AFLabel.Text = "PROVEEDOR:"
        '
        'ID_PARTICIPANTELabel
        '
        ID_PARTICIPANTELabel.AutoSize = True
        ID_PARTICIPANTELabel.Location = New System.Drawing.Point(12, 71)
        ID_PARTICIPANTELabel.Name = "ID_PARTICIPANTELabel"
        ID_PARTICIPANTELabel.Size = New System.Drawing.Size(84, 13)
        ID_PARTICIPANTELabel.TabIndex = 5
        ID_PARTICIPANTELabel.Text = "PARTICIPANTE:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(434, 67)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 13)
        Label1.TabIndex = 17
        Label1.Text = "EMAIL:"
        '
        'lblClave
        '
        lblClave.AutoSize = True
        lblClave.Location = New System.Drawing.Point(434, 41)
        lblClave.Name = "lblClave"
        lblClave.Size = New System.Drawing.Size(42, 13)
        lblClave.TabIndex = 19
        lblClave.Text = "CLAVE:"
        lblClave.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(434, 97)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(125, 13)
        Label3.TabIndex = 21
        Label3.Text = "PREGUNTA SEGURIDAD:"
        '
        'lblRespuestaSeguridad
        '
        lblRespuestaSeguridad.AutoSize = True
        lblRespuestaSeguridad.Location = New System.Drawing.Point(434, 123)
        lblRespuestaSeguridad.Name = "lblRespuestaSeguridad"
        lblRespuestaSeguridad.Size = New System.Drawing.Size(129, 13)
        lblRespuestaSeguridad.TabIndex = 23
        lblRespuestaSeguridad.Text = "RESPUESTA SEGURIDAD:"
        lblRespuestaSeguridad.Visible = False
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(434, 148)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(73, 13)
        Label5.TabIndex = 26
        Label5.Text = "BLOQUEADO:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(739, 148)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(49, 13)
        Label6.TabIndex = 27
        Label6.Text = "ACTIVO:"
        '
        'ListaUSUARIOBindingSource
        '
        Me.ListaUSUARIOBindingSource.DataSource = GetType(SGAFP.EL.listaUSUARIO)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'tsbRecuperar
        '
        Me.tsbRecuperar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRecuperar.Image = Global.SGAFP.My.Resources.Resources.DB
        Me.tsbRecuperar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRecuperar.Name = "tsbRecuperar"
        Me.tsbRecuperar.Size = New System.Drawing.Size(23, 22)
        Me.tsbRecuperar.Text = "Recuperar"
        '
        'ListaUSUARIOBindingNavigator
        '
        Me.ListaUSUARIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListaUSUARIOBindingNavigator.BindingSource = Me.ListaUSUARIOBindingSource
        Me.ListaUSUARIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaUSUARIOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListaUSUARIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.tsbRecuperar, Me.ToolStripLabel1, Me.tstxtUsuario, Me.tsbBuscarUsuario})
        Me.ListaUSUARIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListaUSUARIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaUSUARIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaUSUARIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaUSUARIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaUSUARIOBindingNavigator.Name = "ListaUSUARIOBindingNavigator"
        Me.ListaUSUARIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaUSUARIOBindingNavigator.Size = New System.Drawing.Size(861, 25)
        Me.ListaUSUARIOBindingNavigator.TabIndex = 4
        Me.ListaUSUARIOBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel1.Text = "Buscar Usuario:"
        '
        'tstxtUsuario
        '
        Me.tstxtUsuario.Enabled = False
        Me.tstxtUsuario.Name = "tstxtUsuario"
        Me.tstxtUsuario.Size = New System.Drawing.Size(150, 25)
        Me.tstxtUsuario.ToolTipText = "Ingrese nombre de Usuario a Buscar"
        '
        'tsbBuscarUsuario
        '
        Me.tsbBuscarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscarUsuario.Enabled = False
        Me.tsbBuscarUsuario.Image = Global.SGAFP.My.Resources.Resources.view
        Me.tsbBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarUsuario.Name = "tsbBuscarUsuario"
        Me.tsbBuscarUsuario.Size = New System.Drawing.Size(23, 22)
        Me.tsbBuscarUsuario.Text = "Buscar Usuario"
        '
        'USUARIOTextEdit
        '
        Me.USUARIOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "USUARIO", True))
        Me.USUARIOTextEdit.Location = New System.Drawing.Point(136, 38)
        Me.USUARIOTextEdit.Name = "USUARIOTextEdit"
        Me.USUARIOTextEdit.Size = New System.Drawing.Size(282, 20)
        Me.USUARIOTextEdit.TabIndex = 12
        '
        'gleParticipante
        '
        Me.gleParticipante.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_PARTICIPANTE", True))
        Me.gleParticipante.Location = New System.Drawing.Point(136, 64)
        Me.gleParticipante.Name = "gleParticipante"
        Me.gleParticipante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleParticipante.Properties.DataSource = Me.ListaPARTICIPANTEBindingSource
        Me.gleParticipante.Properties.DisplayMember = "NombresApellidos"
        Me.gleParticipante.Properties.ValueMember = "ID_PARTICIPANTE"
        Me.gleParticipante.Properties.View = Me.GridLookUpEdit1View
        Me.gleParticipante.Size = New System.Drawing.Size(282, 20)
        Me.gleParticipante.TabIndex = 13
        '
        'ListaPARTICIPANTEBindingSource
        '
        Me.ListaPARTICIPANTEBindingSource.DataSource = GetType(SGAFP.EL.listaPARTICIPANTE)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PARTICIPANTE, Me.colNombresApellidos})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Visible = True
        Me.colID_PARTICIPANTE.VisibleIndex = 1
        '
        'colNombresApellidos
        '
        Me.colNombresApellidos.FieldName = "NombresApellidos"
        Me.colNombresApellidos.Name = "colNombresApellidos"
        Me.colNombresApellidos.OptionsColumn.ReadOnly = True
        Me.colNombresApellidos.Visible = True
        Me.colNombresApellidos.VisibleIndex = 0
        '
        'gleProveedor
        '
        Me.gleProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_PROVEEDOR_AF", True))
        Me.gleProveedor.Location = New System.Drawing.Point(136, 90)
        Me.gleProveedor.Name = "gleProveedor"
        Me.gleProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleProveedor.Properties.DataSource = Me.ListaPROVEEDORAFBindingSource
        Me.gleProveedor.Properties.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.gleProveedor.Properties.ValueMember = "ID_PROVEEDOR_AF"
        Me.gleProveedor.Properties.View = Me.GridLookUpEdit2View
        Me.gleProveedor.Size = New System.Drawing.Size(282, 20)
        Me.gleProveedor.TabIndex = 14
        '
        'ListaPROVEEDORAFBindingSource
        '
        Me.ListaPROVEEDORAFBindingSource.DataSource = GetType(SGAFP.EL.listaPROVEEDOR_AF)
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PROVEEDOR_AF, Me.colNOMBRE_PROVEEDOR})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colID_PROVEEDOR_AF
        '
        Me.colID_PROVEEDOR_AF.FieldName = "ID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Name = "colID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Visible = True
        Me.colID_PROVEEDOR_AF.VisibleIndex = 0
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Visible = True
        Me.colNOMBRE_PROVEEDOR.VisibleIndex = 1
        '
        'gleSitioCapacitacion
        '
        Me.gleSitioCapacitacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_SITIO_CAPACITACION", True))
        Me.gleSitioCapacitacion.Location = New System.Drawing.Point(136, 116)
        Me.gleSitioCapacitacion.Name = "gleSitioCapacitacion"
        Me.gleSitioCapacitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleSitioCapacitacion.Properties.DataSource = Me.ListaSITIOCAPACITACIONBindingSource
        Me.gleSitioCapacitacion.Properties.DisplayMember = "NOMBRE_SITIO"
        Me.gleSitioCapacitacion.Properties.ValueMember = "ID_SITIO_CAPACITACION"
        Me.gleSitioCapacitacion.Properties.View = Me.GridLookUpEdit3View
        Me.gleSitioCapacitacion.Size = New System.Drawing.Size(282, 20)
        Me.gleSitioCapacitacion.TabIndex = 15
        '
        'ListaSITIOCAPACITACIONBindingSource
        '
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = GetType(SGAFP.EL.listaSITIO_CAPACITACION)
        '
        'GridLookUpEdit3View
        '
        Me.GridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_SITIO_CAPACITACION, Me.colNOMBRE_SITIO})
        Me.GridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit3View.Name = "GridLookUpEdit3View"
        Me.GridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colID_SITIO_CAPACITACION
        '
        Me.colID_SITIO_CAPACITACION.FieldName = "ID_SITIO_CAPACITACION"
        Me.colID_SITIO_CAPACITACION.Name = "colID_SITIO_CAPACITACION"
        Me.colID_SITIO_CAPACITACION.Visible = True
        Me.colID_SITIO_CAPACITACION.VisibleIndex = 0
        '
        'colNOMBRE_SITIO
        '
        Me.colNOMBRE_SITIO.FieldName = "NOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Name = "colNOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Visible = True
        Me.colNOMBRE_SITIO.VisibleIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 174)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tbRoles
        Me.XtraTabControl1.Size = New System.Drawing.Size(837, 191)
        Me.XtraTabControl1.TabIndex = 16
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tbRoles, Me.tpOpciones})
        '
        'tbRoles
        '
        Me.tbRoles.Controls.Add(Me.chklbRoles)
        Me.tbRoles.Name = "tbRoles"
        Me.tbRoles.Size = New System.Drawing.Size(830, 162)
        Me.tbRoles.Text = "Roles"
        '
        'chklbRoles
        '
        Me.chklbRoles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklbRoles.Location = New System.Drawing.Point(3, 3)
        Me.chklbRoles.Name = "chklbRoles"
        Me.chklbRoles.Size = New System.Drawing.Size(824, 156)
        Me.chklbRoles.TabIndex = 0
        '
        'tpOpciones
        '
        Me.tpOpciones.Name = "tpOpciones"
        Me.tpOpciones.Size = New System.Drawing.Size(830, 162)
        Me.tpOpciones.Text = "Opciones"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(565, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(282, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(565, 38)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(282, 20)
        Me.txtClave.TabIndex = 20
        Me.txtClave.Visible = False
        '
        'txtPreguntaSeguridad
        '
        Me.txtPreguntaSeguridad.Location = New System.Drawing.Point(565, 94)
        Me.txtPreguntaSeguridad.Name = "txtPreguntaSeguridad"
        Me.txtPreguntaSeguridad.Size = New System.Drawing.Size(282, 20)
        Me.txtPreguntaSeguridad.TabIndex = 22
        '
        'txtRespuestaSeguridad
        '
        Me.txtRespuestaSeguridad.Location = New System.Drawing.Point(565, 120)
        Me.txtRespuestaSeguridad.Name = "txtRespuestaSeguridad"
        Me.txtRespuestaSeguridad.Size = New System.Drawing.Size(282, 20)
        Me.txtRespuestaSeguridad.TabIndex = 24
        Me.txtRespuestaSeguridad.Visible = False
        '
        'chkBloqueado
        '
        Me.chkBloqueado.Location = New System.Drawing.Point(563, 146)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Properties.Caption = ""
        Me.chkBloqueado.Size = New System.Drawing.Size(22, 19)
        Me.chkBloqueado.TabIndex = 25
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(825, 146)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Caption = ""
        Me.chkActivo.Size = New System.Drawing.Size(22, 19)
        Me.chkActivo.TabIndex = 28
        '
        'wfAdministrarSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 377)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.chkBloqueado)
        Me.Controls.Add(lblRespuestaSeguridad)
        Me.Controls.Add(Me.txtRespuestaSeguridad)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtPreguntaSeguridad)
        Me.Controls.Add(lblClave)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.gleSitioCapacitacion)
        Me.Controls.Add(Me.gleProveedor)
        Me.Controls.Add(Me.gleParticipante)
        Me.Controls.Add(ID_PARTICIPANTELabel)
        Me.Controls.Add(ID_PROVEEDOR_AFLabel)
        Me.Controls.Add(ID_SITIO_CAPACITACIONLabel)
        Me.Controls.Add(USUARIOLabel)
        Me.Controls.Add(Me.USUARIOTextEdit)
        Me.Controls.Add(Me.ListaUSUARIOBindingNavigator)
        Me.Name = "wfAdministrarSeguridad"
        Me.Text = "Administrar Seguridad"
        Me.Controls.SetChildIndex(Me.ListaUSUARIOBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.USUARIOTextEdit, 0)
        Me.Controls.SetChildIndex(USUARIOLabel, 0)
        Me.Controls.SetChildIndex(ID_SITIO_CAPACITACIONLabel, 0)
        Me.Controls.SetChildIndex(ID_PROVEEDOR_AFLabel, 0)
        Me.Controls.SetChildIndex(ID_PARTICIPANTELabel, 0)
        Me.Controls.SetChildIndex(Me.gleParticipante, 0)
        Me.Controls.SetChildIndex(Me.gleProveedor, 0)
        Me.Controls.SetChildIndex(Me.gleSitioCapacitacion, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(lblClave, 0)
        Me.Controls.SetChildIndex(Me.txtPreguntaSeguridad, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.txtRespuestaSeguridad, 0)
        Me.Controls.SetChildIndex(lblRespuestaSeguridad, 0)
        Me.Controls.SetChildIndex(Me.chkBloqueado, 0)
        Me.Controls.SetChildIndex(Label5, 0)
        Me.Controls.SetChildIndex(Label6, 0)
        Me.Controls.SetChildIndex(Me.chkActivo, 0)
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaUSUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaUSUARIOBindingNavigator.ResumeLayout(False)
        Me.ListaUSUARIOBindingNavigator.PerformLayout()
        CType(Me.USUARIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleParticipante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROVEEDORAFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleSitioCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tbRoles.ResumeLayout(False)
        CType(Me.chklbRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreguntaSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRespuestaSeguridad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBloqueado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRecuperar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListaUSUARIOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents USUARIOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gleParticipante As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ListaPARTICIPANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombresApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleProveedor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ListaPROVEEDORAFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleSitioCapacitacion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ListaSITIOCAPACITACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_SITIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtUsuario As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbBuscarUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tbRoles As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpOpciones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chklbRoles As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPreguntaSeguridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRespuestaSeguridad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkBloqueado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents lblRespuestaSeguridad As System.Windows.Forms.Label

End Class
