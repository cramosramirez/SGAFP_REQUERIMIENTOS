Imports SGAFP.EL
Public Class ucListaOPCION_GRUPO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaOPCION_GRUPOBindingSource
    End Sub

    Private mComponente As New cOPCION_GRUPO
    Private _mListaOPCION_GRUPO As New listaOPCION_GRUPO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_OPCION_GRUPO As Decimal) 

    #Region "Propiedades"

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.VerToolBar = Not value
        End Set
    End Property

    Private _VerID_OPCION_GRUPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_OPCION_GRUPO() As Boolean
        Get
            Return Me._VerID_OPCION_GRUPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_OPCION_GRUPO = value
            Me.DataGridViewTextBoxID_OPCION_GRUPO.Visible = value
        End Set
    End Property

    Private _VerID_OPCION_MENU As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_OPCION_MENU() As Boolean
        Get
            Return Me._VerID_OPCION_MENU
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_OPCION_MENU = value
            Me.DataGridViewTextBoxID_OPCION_MENU.Visible = value
        End Set
    End Property

    Private _VerID_GRUPO_USUARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_GRUPO_USUARIO() As Boolean
        Get
            Return Me._VerID_GRUPO_USUARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_GRUPO_USUARIO = value
            Me.DataGridViewTextBoxID_GRUPO_USUARIO.Visible = value
        End Set
    End Property

    Private _VerFECHA_INGRESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me._VerFECHA_INGRESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INGRESO = value
            Me.DataGridViewTextBoxFECHA_INGRESO.Visible = value
        End Set
    End Property

    Private _VerESTADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO() As Boolean
        Get
            Return Me._VerESTADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO = value
            Me.DataGridViewTextBoxESTADO.Visible = value
        End Set
    End Property

    Private _VerUSERID As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSERID() As Boolean
        Get
            Return Me._VerUSERID
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSERID = value
            Me.DataGridViewTextBoxUSERID.Visible = value
        End Set
    End Property

    Private _VerLASTUPDATE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me._VerLASTUPDATE
        End Get
        Set(ByVal value As Boolean)
            Me._VerLASTUPDATE = value
            Me.DataGridViewTextBoxLASTUPDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As OPCION_GRUPO
        Get
            Return CType(Me.ListaOPCION_GRUPOBindingSource.Current, OPCION_GRUPO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_GRUPO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaOPCION_GRUPO = Me.mComponente.ObtenerLista()
        If _mListaOPCION_GRUPO Is Nothing Then Return -1
        Me.ListaOPCION_GRUPOBindingSource.DataSource = _mListaOPCION_GRUPO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_GRUPO
    ''' filtrado por la tabla OPCION_MENU
    ''' </summary>
    ''' <param name="ID_OPCION_MENU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorOPCION_MENU(ByVal ID_OPCION_MENU As Decimal) As Integer
        _mListaOPCION_GRUPO = Me.mComponente.ObtenerListaPorOPCION_MENU(ID_OPCION_MENU)
        If _mListaOPCION_GRUPO Is Nothing Then Return -1
        Me.ListaOPCION_GRUPOBindingSource.DataSource = _mListaOPCION_GRUPO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_GRUPO
    ''' filtrado por la tabla GRUPO_USUARIO
    ''' </summary>
    ''' <param name="ID_GRUPO_USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorGRUPO_USUARIO(ByVal ID_GRUPO_USUARIO As Decimal) As Integer
        _mListaOPCION_GRUPO = Me.mComponente.ObtenerListaPorGRUPO_USUARIO(ID_GRUPO_USUARIO)
        If _mListaOPCION_GRUPO Is Nothing Then Return -1
        Me.ListaOPCION_GRUPOBindingSource.DataSource = _mListaOPCION_GRUPO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de Eliminar. En este método se elimina el
    ''' registro seleccionado del Grid.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaOPCION_GRUPOBindingSource.Current Is Nothing Then
            If Me.Current.ID_OPCION_GRUPO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaOPCION_GRUPOBindingSource.Current Is Nothing Then
            If mComponente.EliminarOPCION_GRUPO( Me.Current.ID_OPCION_GRUPO) <> 1 Then
                Me.sError = "Suceso desconocido."
                Return -1
            End If
        Else
            Me.sError = "No tiene elegido ningun registro a eliminar"
            Return -1
        End If
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de Guardar. En este método se Guarda el
    ''' registro seleccionado del Grid, si es nuevo se Agrega y sino se Actualiza.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaOPCION_GRUPOBindingSource.Current Is Nothing Then
            Me.ListaOPCION_GRUPOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarOPCION_GRUPO(Me.Current)
                Case -1
                    Me.sError = "Suceso desconocido."
                    Return -1
                Case 0
                    Me.sError = "Registro fue modificado por otro usuario antes de guardar. Recupere nuevamente los registros."
                    Return -2
                Case Else
                    Return 1
            End Select
        End If
        Return 0
    End Function

    Private Sub ListaOPCION_GRUPOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaOPCION_GRUPOBindingSource.AddingNew
        Dim lEntidad As New OPCION_GRUPO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaOPCION_GRUPOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaOPCION_GRUPOBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaOPCION_GRUPODataGridView.AllowUserToAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaOPCION_GRUPODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaOPCION_GRUPODataGridView.Dock = DockStyle.None
            Me.ListaOPCION_GRUPODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaOPCION_GRUPODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaOPCION_GRUPODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
