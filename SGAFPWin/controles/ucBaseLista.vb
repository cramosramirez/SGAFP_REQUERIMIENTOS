Public Class ucBaseLista

    Private ListaOpciones As List(Of OpcionMenu) = New List(Of OpcionMenu)
    Private frmFiltro As WinUC.frmFind
    Private frmBusqueda As WinUC.frmFind

#Region "Ejecucion Opciones"

    Protected Overridable Sub ProcesarOpcion(ByVal asComando As String)

    End Sub

    Private Sub OnClickOption(ByVal sender As Object, ByVal e As EventArgs)
        Me.ProcesarOpcion(CType(sender, ToolStripItem).ToolTipText)
    End Sub

#End Region

#Region "Propiedades"
    Private _sError As String
    Public Property sError() As String
        Get
            Return _sError
        End Get
        Set(ByVal Value As String)
            _sError = Value
        End Set
    End Property

    Private _PermitirAgregar As Boolean = True
    <Bindable(True), Category("Appearance"), DefaultValue(True)> _
    Public Property PermitirAgregar() As Boolean
        Get
            Return _PermitirAgregar
        End Get
        Set(ByVal value As Boolean)
            _PermitirAgregar = value
            Me.BindingNavigatorAddNewItem.Enabled = Me._PermitirAgregar
            Me.OnPermitirAgregar()
        End Set
    End Property

    Public Overridable Sub OnPermitirAgregar()
    End Sub

    Private _PermitirGuardar As Boolean = True
    <Bindable(True), Category("Appearance"), DefaultValue(True)> _
    Public Property PermitirGuardar() As Boolean
        Get
            Return _PermitirGuardar
        End Get
        Set(ByVal value As Boolean)
            _PermitirGuardar = value
            Me.BindingNavigatorSaveItem.Enabled = Me._PermitirGuardar
            Me.BindingNavigatorSaveItem.Visible = Me._PermitirGuardar
            Me.OnPermitirGuardar()
        End Set
    End Property

    Public Overridable Sub OnPermitirGuardar()
    End Sub

    Private _PermitirEliminar As Boolean = True
    <Bindable(True), Category("Appearance"), DefaultValue(True)> _
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal value As Boolean)
            _PermitirEliminar = value
            Me.BindingNavigatorDeleteItem.Enabled = Me._PermitirEliminar
            Me.OnPermitirEliminar()
        End Set
    End Property

    Public Overridable Sub OnPermitirEliminar()
    End Sub

    Private _PreguntaEliminar As String = "¿Esta seguro de eliminar el registro?"
    Public Property PreguntaEliminar() As String
        Get
            Return _PreguntaEliminar
        End Get
        Set(ByVal value As String)
            _PreguntaEliminar = value
        End Set
    End Property

    Private _PermitirNavegacion As Boolean = True
    <Bindable(True), Category("Appearance"), DefaultValue(True)> _
    Public Property PermitirNavegacion() As Boolean
        Get
            Return _PermitirNavegacion
        End Get
        Set(ByVal value As Boolean)
            _PermitirNavegacion = value
            Me.BindingNavigatorCountItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorMoveFirstItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorMoveLastItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorMoveNextItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorMovePreviousItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorPositionItem.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorSeparator.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorSeparator1.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorSeparator2.Visible = Me._PermitirNavegacion
            Me.BindingNavigatorSeparator3.Visible = Me._PermitirNavegacion
            Me.OnPermitirNavegacion()
        End Set
    End Property

    Public Overridable Sub OnPermitirNavegacion()
    End Sub

    Private _VerToolBar As Boolean = True
    <Bindable(True), Category("Appearance"), DefaultValue(True)> _
    Public Property VerToolBar() As Boolean
        Get
            Return _VerToolBar
        End Get
        Set(ByVal value As Boolean)
            _VerToolBar = value
            If Not value Then
                Me.PermitirAgregar = False
                Me.PermitirEliminar = False
                Me.PermitirNavegacion = False
                Me.PermitirGuardar = False
            End If
            Me.ListaBindingNavigator.Visible = Me._VerToolBar
            Me.OnVerToolbar()
        End Set
    End Property

    Public Overridable Sub OnVerToolbar()
    End Sub

    Private _PermitirBuscar As Boolean = False
    <Description("Permitir Buscar"), Category("Find"), DefaultValue(False)> _
    Public Property PermitirBuscar() As Boolean
        Get
            Return Me._PermitirBuscar
        End Get
        Set(ByVal value As Boolean)
            Me._PermitirBuscar = value
            Me.BindingNavigatorSeparator3.Visible = True
            Me.BindingNavigatorFindItem.Visible = value
        End Set
    End Property

    Private _PermitirFiltrar As Boolean = False
    <Description("Permitir Filtrar."), Category("Find"), DefaultValue(False)> _
    Public Property PermitirFiltrar() As Boolean
        Get
            Return Me._PermitirFiltrar
        End Get
        Set(ByVal value As Boolean)
            Me._PermitirFiltrar = value
            Me.BindingNavigatorSeparator3.Visible = True
            Me.BindingNavigatorFilterItem.Visible = value
            Me.BindingNavigatorRemoveFilterItem.Visible = value
        End Set
    End Property

    Private _PermitirBuscarMensajeError As String = "No se encuentra el registro"
    <Description("Mensaje de Error por si no existe el registro buscado"), Category("Find"), DefaultValue("No se encuentra el registro")> _
    Public Property PermitirBuscarMensajeError() As String
        Get
            Return Me._PermitirBuscarMensajeError
        End Get
        Set(ByVal value As String)
            Me._PermitirBuscarMensajeError = value
        End Set
    End Property

    Private _PermitirBuscarEntityType As Type = Nothing
    <Description("Tipo de la Entidad para la Busqueda"), Category("Find"), DefaultValue("")> _
    Public Property PermitirBuscarEntityType() As Type
        Get
            Return Me._PermitirBuscarEntityType
        End Get
        Set(ByVal value As Type)
            Me._PermitirBuscarEntityType = value
        End Set
    End Property

    Private _PermitirBuscarWidth As Integer = 490
    <Description("Find Window Width"), Category("Find"), DefaultValue(490)> _
    Public Property PermitirBuscarWidth() As Integer
        Get
            Return Me._PermitirBuscarWidth
        End Get
        Set(ByVal value As Integer)
            Me._PermitirBuscarWidth = value
        End Set
    End Property

    Private _PermitirBuscarHeight As Integer = 270
    <Description("Find Window Height"), Category("Find"), DefaultValue(270)> _
    Public Property PermitirBuscarHeight() As Integer
        Get
            Return Me._PermitirBuscarHeight
        End Get
        Set(ByVal value As Integer)
            Me._PermitirBuscarHeight = value
        End Set
    End Property

#End Region

    Protected Sub ReestablecerModoEdicion()
        Me.BindingNavigatorAddNewItem.Enabled = Me._PermitirAgregar
        If Me.BindingNavigatorSaveItem.Enabled And Not Me._PermitirAgregar Then
            Me.BindingNavigatorSaveItem.Enabled = False
        End If
        Me.BindingNavigatorDeleteItem.Enabled = Me._PermitirEliminar
    End Sub

#Region "Opciones Barra"

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Select Case Me.Eliminar()
            Case -1
                Me.AsignarMensaje(Me.sError, True)
            Case 1
                Me.AsignarMensaje("Registro eliminado satisfactoriamente")
            Case Else
        End Select
    End Sub

    Public Overridable Function Eliminar() As Integer
        If Preguntar(Me._PreguntaEliminar) = DialogResult.No Then
            Return 0
        End If
        Return 1
    End Function

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        'Implementar codigo para Busqueda
        Buscar()
    End Sub

    Protected Overridable Sub Buscar()
        Me.Buscar(Me.ListaBindingNavigator.BindingSource)
    End Sub

    Protected Sub Buscar(ByVal bs As BindingSource)
        'If PermitirBuscarEntityName = "" Then Return
        If Me.PermitirBuscarEntityType Is Nothing Then Return
        frmBusqueda = New WinUC.frmFind
        frmBusqueda.Height = Me.PermitirBuscarHeight
        frmBusqueda.Width = Me.PermitirBuscarWidth
        'frmBusqueda.entity = Me.PermitirBuscarEntityName
        frmBusqueda.entityType = Me.PermitirBuscarEntityType
        frmBusqueda.BindingSourceControl = bs
        'frmBusqueda.listaDatos = bs.DataSource
        frmBusqueda.Inicializar()
        frmBusqueda.ShowDialog()
    End Sub

    Private Sub BindingNavigatorFilterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFilterItem.Click
        'Implementar codigo para Filtro
        Filtrar()
    End Sub

    Private Sub BindingNavigatorRemoveFilterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRemoveFilterItem.Click
        Me.ListaBindingNavigator.BindingSource.RemoveFilter()
    End Sub

    Protected Overridable Sub Filtrar()
        Me.Filtrar(Me.ListaBindingNavigator.BindingSource)
    End Sub

    Protected Sub Filtrar(ByVal bs As BindingSource)
        'If PermitirBuscarEntityName = "" Then Return
        If Me.PermitirBuscarEntityType Is Nothing Then Return
        frmFiltro = New WinUC.frmFind
        frmFiltro.Height = Me.PermitirBuscarHeight
        frmFiltro.Width = Me.PermitirBuscarWidth
        'frmBusqueda.entity = Me.PermitirBuscarEntityName
        frmFiltro.entityType = Me.PermitirBuscarEntityType
        frmFiltro.BindingSourceControl = bs
        'frmFiltro.listaDatos = bs.DataSource
        frmFiltro.Inicializar(WinUC.frmFind.TipoAccion.Filtro)
        frmFiltro.ShowDialog()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Agregar()
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Select Case Me.Guardar()
            Case -1
                Me.AsignarMensaje(Me.sError, True)
            Case -2
                Me.AsignarMensaje(Me.sError)
            Case 1
                Me.AsignarMensaje("Registro guardado satisfactoriamente")
            Case Else
        End Select
    End Sub

    Public Overridable Function Guardar() As Integer
        If Me.Parent.Parent.Parent.GetType().BaseType() Is GetType(ucBaseMant) Then
            Dim ucDetaMant As ucBaseDetalleMant
            Dim ucMant As ucBaseMant
            ucMant = CType(Me.Parent.Parent.Parent, ucBaseMant)
            ucDetaMant = ucMant.Controls.Find("ucDetalle" + ucMant.Name.Remove(0, 6), True)(0)
            ucDetaMant.DataSource.EndEdit()
            Return 1
        End If
        Return 0
    End Function

#End Region

    Public Overridable Function Agregar() As Integer
    End Function

    Public Overridable Sub Editar()
    End Sub

    Public Sub CargarDatosPorLista(ByVal aLista As IBindingListView)
        If aLista Is Nothing Then Return
        Me.ListaBindingNavigator.BindingSource.DataSource = aLista
    End Sub


End Class
