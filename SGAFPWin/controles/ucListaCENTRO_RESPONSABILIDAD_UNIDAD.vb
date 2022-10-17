Imports SGAFP.EL
Public Class ucListaCENTRO_RESPONSABILIDAD_UNIDAD

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource
    End Sub

    Private _mComponente As cCENTRO_RESPONSABILIDAD_UNIDAD
    Public ReadOnly Property mComponente() As cCENTRO_RESPONSABILIDAD_UNIDAD
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cCENTRO_RESPONSABILIDAD_UNIDAD
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaCENTRO_RESPONSABILIDAD_UNIDAD As New listaCENTRO_RESPONSABILIDAD_UNIDAD
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) 

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

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return Me._ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal value As Decimal)
            Me._ID_UNIDAD_ORGANIZATIVA = value
        End Set
    End Property

    Private _VerID_CENTRO_RESPONSABILIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CENTRO_RESPONSABILIDAD() As Boolean
        Get
            Return Me._VerID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CENTRO_RESPONSABILIDAD = value
            Me.colID_CENTRO_RESPONSABILIDAD.Visible = value
        End Set
    End Property

    Private _VerID_UNIDAD_ORGANIZATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_UNIDAD_ORGANIZATIVA() As Boolean
        Get
            Return Me._VerID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_UNIDAD_ORGANIZATIVA = value
            Me.colID_UNIDAD_ORGANIZATIVA.Visible = value
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
            Me.colUSERID.Visible = value
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
            Me.colLASTUPDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As CENTRO_RESPONSABILIDAD_UNIDAD
        Get
            Return CType(Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.Current, CENTRO_RESPONSABILIDAD_UNIDAD)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCENTRO_RESPONSABILIDAD_UNIDAD = Me.mComponente.ObtenerLista(ID_UNIDAD_ORGANIZATIVA)
        If _mListaCENTRO_RESPONSABILIDAD_UNIDAD Is Nothing Then Return -1
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.DataSource = _mListaCENTRO_RESPONSABILIDAD_UNIDAD
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
    ''' filtrado por la tabla CENTRO_RESPONSABILIDAD
    ''' </summary>
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) As Integer
        _mListaCENTRO_RESPONSABILIDAD_UNIDAD = Me.mComponente.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD)
        If _mListaCENTRO_RESPONSABILIDAD_UNIDAD Is Nothing Then Return -1
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.DataSource = _mListaCENTRO_RESPONSABILIDAD_UNIDAD
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
    ''' filtrado por la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As Integer
        _mListaCENTRO_RESPONSABILIDAD_UNIDAD = Me.mComponente.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA)
        If _mListaCENTRO_RESPONSABILIDAD_UNIDAD Is Nothing Then Return -1
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.DataSource = _mListaCENTRO_RESPONSABILIDAD_UNIDAD
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.Current Is Nothing Then
            If Me.Current.ID_CENTRO_RESPONSABILIDAD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.Current Is Nothing Then
            If mComponente.EliminarCENTRO_RESPONSABILIDAD_UNIDAD(Me.Current.ID_CENTRO_RESPONSABILIDAD, Me.Current.ID_UNIDAD_ORGANIZATIVA) <> 1 Then
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.Current Is Nothing Then
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Dim liRet As Integer
            If Me.Current.ID_CENTRO_RESPONSABILIDAD = 0 Then
                liRet = mComponente.ActualizarCENTRO_RESPONSABILIDAD_UNIDAD(Me.Current)
            Else
                liRet = mComponente.AgregarCENTRO_RESPONSABILIDAD_UNIDAD(Me.Current)
            End If
            Select Case liRet
                Case -1
                    Me.sError = "Suceso desconocido."
                    Return -1
                Case 0
                    Me.sError = "Registro no pudo ser Guardado."
                    Return -2
                Case Else
                    Return 1
            End Select
        End If
        Return 0
    End Function

    Private Sub ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.AddingNew
        Dim lEntidad As New CENTRO_RESPONSABILIDAD_UNIDAD
        lEntidad.ID_UNIDAD_ORGANIZATIVA = Me.ID_UNIDAD_ORGANIZATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCENTRO_RESPONSABILIDAD_UNIDADBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Dock = DockStyle.None
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCENTRO_RESPONSABILIDAD_UNIDADGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
