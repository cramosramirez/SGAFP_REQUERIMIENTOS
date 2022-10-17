<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnRepetidosPorDUI = New System.Windows.Forms.Button
        Me.btnRepetidosPorNIT = New System.Windows.Forms.Button
        Me.btnRepetidosPorNombres = New System.Windows.Forms.Button
        Me.ListaPARTICIPANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPARTICIPANTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ListaPARTICIPANTEDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnProcesarCambios = New System.Windows.Forms.Button
        Me.btnProcesarSeleccionados = New System.Windows.Forms.Button
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaPARTICIPANTEBindingNavigator.SuspendLayout()
        CType(Me.ListaPARTICIPANTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRepetidosPorDUI
        '
        Me.btnRepetidosPorDUI.Location = New System.Drawing.Point(12, 28)
        Me.btnRepetidosPorDUI.Name = "btnRepetidosPorDUI"
        Me.btnRepetidosPorDUI.Size = New System.Drawing.Size(185, 23)
        Me.btnRepetidosPorDUI.TabIndex = 0
        Me.btnRepetidosPorDUI.Text = "Recuperar Repetidos por DUI"
        Me.btnRepetidosPorDUI.UseVisualStyleBackColor = True
        '
        'btnRepetidosPorNIT
        '
        Me.btnRepetidosPorNIT.Location = New System.Drawing.Point(203, 28)
        Me.btnRepetidosPorNIT.Name = "btnRepetidosPorNIT"
        Me.btnRepetidosPorNIT.Size = New System.Drawing.Size(185, 23)
        Me.btnRepetidosPorNIT.TabIndex = 1
        Me.btnRepetidosPorNIT.Text = "Recuperar Repetidos por NIT"
        Me.btnRepetidosPorNIT.UseVisualStyleBackColor = True
        '
        'btnRepetidosPorNombres
        '
        Me.btnRepetidosPorNombres.Location = New System.Drawing.Point(394, 28)
        Me.btnRepetidosPorNombres.Name = "btnRepetidosPorNombres"
        Me.btnRepetidosPorNombres.Size = New System.Drawing.Size(185, 23)
        Me.btnRepetidosPorNombres.TabIndex = 2
        Me.btnRepetidosPorNombres.Text = "Recuperar Repetidos por Nombres"
        Me.btnRepetidosPorNombres.UseVisualStyleBackColor = True
        '
        'ListaPARTICIPANTEBindingSource
        '
        Me.ListaPARTICIPANTEBindingSource.DataSource = GetType(SGAFP.EL.PARTICIPANTE)
        '
        'ListaPARTICIPANTEBindingNavigator
        '
        Me.ListaPARTICIPANTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListaPARTICIPANTEBindingNavigator.BindingSource = Me.ListaPARTICIPANTEBindingSource
        Me.ListaPARTICIPANTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaPARTICIPANTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListaPARTICIPANTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaPARTICIPANTEBindingNavigatorSaveItem})
        Me.ListaPARTICIPANTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListaPARTICIPANTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaPARTICIPANTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaPARTICIPANTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaPARTICIPANTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaPARTICIPANTEBindingNavigator.Name = "ListaPARTICIPANTEBindingNavigator"
        Me.ListaPARTICIPANTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaPARTICIPANTEBindingNavigator.Size = New System.Drawing.Size(856, 25)
        Me.ListaPARTICIPANTEBindingNavigator.TabIndex = 3
        Me.ListaPARTICIPANTEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'ListaPARTICIPANTEBindingNavigatorSaveItem
        '
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.Enabled = False
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaPARTICIPANTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.Name = "ListaPARTICIPANTEBindingNavigatorSaveItem"
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListaPARTICIPANTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ListaPARTICIPANTEDataGridView
        '
        Me.ListaPARTICIPANTEDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPARTICIPANTEDataGridView.AutoGenerateColumns = False
        Me.ListaPARTICIPANTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPARTICIPANTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn69})
        Me.ListaPARTICIPANTEDataGridView.DataSource = Me.ListaPARTICIPANTEBindingSource
        Me.ListaPARTICIPANTEDataGridView.Location = New System.Drawing.Point(12, 57)
        Me.ListaPARTICIPANTEDataGridView.Name = "ListaPARTICIPANTEDataGridView"
        Me.ListaPARTICIPANTEDataGridView.Size = New System.Drawing.Size(832, 310)
        Me.ListaPARTICIPANTEDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRES"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRES"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DUI"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DUI"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NIT"
        Me.DataGridViewTextBoxColumn22.HeaderText = "NIT"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LUGAR_NACIMIENTO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "LUGAR_NACIMIENTO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "GENERO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "GENERO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FECHA_NACIMIENTO"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FECHA_NACIMIENTO"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxColumn18.HeaderText = "DIRECCION"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "ISSS"
        Me.DataGridViewTextBoxColumn24.HeaderText = "ISSS"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CIUO"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CIUO"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn28.HeaderText = "ZONA"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxColumn30.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "MOVIL"
        Me.DataGridViewTextBoxColumn32.HeaderText = "MOVIL"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn34.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "FAX"
        Me.DataGridViewTextBoxColumn36.HeaderText = "FAX"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ESTADO_CIVIL"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ESTADO_CIVIL"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "NIT_EMPRESA"
        Me.DataGridViewTextBoxColumn40.HeaderText = "NIT_EMPRESA"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "NOMBRE_EMPRESA"
        Me.DataGridViewTextBoxColumn42.HeaderText = "NOMBRE_EMPRESA"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "CARGO"
        Me.DataGridViewTextBoxColumn44.HeaderText = "CARGO"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "ESTADO_FAMILIAR"
        Me.DataGridViewTextBoxColumn46.HeaderText = "ESTADO_FAMILIAR"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "PROFESION_OFICIO"
        Me.DataGridViewTextBoxColumn48.HeaderText = "PROFESION_OFICIO"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "OCUPACION_ACTUAL"
        Me.DataGridViewTextBoxColumn50.HeaderText = "OCUPACION_ACTUAL"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "TITULO_CERTIFICADO_OBTENIDO"
        Me.DataGridViewTextBoxColumn52.HeaderText = "TITULO_CERTIFICADO_OBTENIDO"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "DEPARTAMENTO_NAC"
        Me.DataGridViewTextBoxColumn54.HeaderText = "DEPARTAMENTO_NAC"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "MUNICIPIO_NAC"
        Me.DataGridViewTextBoxColumn56.HeaderText = "MUNICIPIO_NAC"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "CODIGO_MUNICIPIO"
        Me.DataGridViewTextBoxColumn58.HeaderText = "CODIGO_MUNICIPIO"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "CODIGO_REGION"
        Me.DataGridViewTextBoxColumn61.HeaderText = "CODIGO_REGION"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "CODIGO_DEPARTAMENTO"
        Me.DataGridViewTextBoxColumn64.HeaderText = "CODIGO_DEPARTAMENTO"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "LASTUPDATE"
        Me.DataGridViewTextBoxColumn67.HeaderText = "LASTUPDATE"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxColumn69.HeaderText = "USERID"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'btnProcesarCambios
        '
        Me.btnProcesarCambios.Location = New System.Drawing.Point(585, 28)
        Me.btnProcesarCambios.Name = "btnProcesarCambios"
        Me.btnProcesarCambios.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesarCambios.TabIndex = 5
        Me.btnProcesarCambios.Text = "Procesar"
        Me.btnProcesarCambios.UseVisualStyleBackColor = True
        '
        'btnProcesarSeleccionados
        '
        Me.btnProcesarSeleccionados.Location = New System.Drawing.Point(666, 28)
        Me.btnProcesarSeleccionados.Name = "btnProcesarSeleccionados"
        Me.btnProcesarSeleccionados.Size = New System.Drawing.Size(139, 23)
        Me.btnProcesarSeleccionados.TabIndex = 6
        Me.btnProcesarSeleccionados.Text = "Procesar Seleccionados"
        Me.btnProcesarSeleccionados.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 379)
        Me.Controls.Add(Me.btnProcesarSeleccionados)
        Me.Controls.Add(Me.btnProcesarCambios)
        Me.Controls.Add(Me.ListaPARTICIPANTEDataGridView)
        Me.Controls.Add(Me.ListaPARTICIPANTEBindingNavigator)
        Me.Controls.Add(Me.btnRepetidosPorNombres)
        Me.Controls.Add(Me.btnRepetidosPorNIT)
        Me.Controls.Add(Me.btnRepetidosPorDUI)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaPARTICIPANTEBindingNavigator.ResumeLayout(False)
        Me.ListaPARTICIPANTEBindingNavigator.PerformLayout()
        CType(Me.ListaPARTICIPANTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRepetidosPorDUI As System.Windows.Forms.Button
    Friend WithEvents btnRepetidosPorNIT As System.Windows.Forms.Button
    Friend WithEvents btnRepetidosPorNombres As System.Windows.Forms.Button
    Friend WithEvents ListaPARTICIPANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPARTICIPANTEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListaPARTICIPANTEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListaPARTICIPANTEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnProcesarCambios As System.Windows.Forms.Button
    Friend WithEvents btnProcesarSeleccionados As System.Windows.Forms.Button

End Class
