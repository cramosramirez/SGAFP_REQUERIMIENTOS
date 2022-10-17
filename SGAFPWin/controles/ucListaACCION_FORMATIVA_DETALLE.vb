Imports SGAFP.EL
Public Class ucListaACCION_FORMATIVA_DETALLE

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaACCION_FORMATIVA_DETALLEBindingSource
    End Sub

    Private _mComponente As cACCION_FORMATIVA_DETALLE
    Public ReadOnly Property mComponente() As cACCION_FORMATIVA_DETALLE
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cACCION_FORMATIVA_DETALLE
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaACCION_FORMATIVA_DETALLE As New listaACCION_FORMATIVA_DETALLE
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

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

    Private _VerID_ACCION_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me._VerID_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_FORMATIVA = value
            Me.colID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerID_PROGRAMA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me._VerID_PROGRAMA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROGRAMA_FORMACION = value
            Me.colID_PROGRAMA_FORMACION.Visible = value
        End Set
    End Property

    Private _VerID_MODALIDAD_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me._VerID_MODALIDAD_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_MODALIDAD_FORMACION = value
            Me.colID_MODALIDAD_FORMACION.Visible = value
        End Set
    End Property

    Private _VerID_CONTRATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CONTRATO() As Boolean
        Get
            Return Me._VerID_CONTRATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CONTRATO = value
            Me.colID_CONTRATO.Visible = value
        End Set
    End Property

    Private _VerID_FUENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_FUENTE() As Boolean
        Get
            Return Me._VerID_FUENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_FUENTE = value
            Me.colID_FUENTE.Visible = value
        End Set
    End Property

    Private _VerNO_CONVOCATORIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNO_CONVOCATORIA() As Boolean
        Get
            Return Me._VerNO_CONVOCATORIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNO_CONVOCATORIA = value
            Me.colNO_CONVOCATORIA.Visible = value
        End Set
    End Property

    Private _VerCODIGO_DEPARTAMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me._VerCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_DEPARTAMENTO = value
            Me.colCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_MUNICIPIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me._VerCODIGO_MUNICIPIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_MUNICIPIO = value
            Me.colCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerLUGAR_EJECUCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLUGAR_EJECUCION() As Boolean
        Get
            Return Me._VerLUGAR_EJECUCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerLUGAR_EJECUCION = value
            Me.colLUGAR_EJECUCION.Visible = value
        End Set
    End Property

    Private _VerTELEFONO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO() As Boolean
        Get
            Return Me._VerTELEFONO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO = value
            Me.colTELEFONO.Visible = value
        End Set
    End Property

    Private _VerCONTACTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCONTACTO() As Boolean
        Get
            Return Me._VerCONTACTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCONTACTO = value
            Me.colCONTACTO.Visible = value
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

    Public ReadOnly Property Current() As ACCION_FORMATIVA_DETALLE
        Get
            Return CType(Me.ListaACCION_FORMATIVA_DETALLEBindingSource.Current, ACCION_FORMATIVA_DETALLE)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerLista()
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla CONTRATO_PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO_PROVEEDOR_AF(ByVal ID_CONTRATO As Decimal) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorCONTRATO_PROVEEDOR_AF(ID_CONTRATO)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla FUENTE_FINANCIAMIENTO
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_DETALLE
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        _mListaACCION_FORMATIVA_DETALLE = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If _mListaACCION_FORMATIVA_DETALLE Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVA_DETALLEBindingSource.DataSource = _mListaACCION_FORMATIVA_DETALLE
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
        If Not Me.ListaACCION_FORMATIVA_DETALLEBindingSource.Current Is Nothing Then
            If Me.Current.ID_ACCION_FORMATIVA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaACCION_FORMATIVA_DETALLEBindingSource.Current Is Nothing Then
            If mComponente.EliminarACCION_FORMATIVA_DETALLE(Me.Current.ID_ACCION_FORMATIVA) <> 1 Then
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
        If Not Me.ListaACCION_FORMATIVA_DETALLEBindingSource.Current Is Nothing Then
            Me.ListaACCION_FORMATIVA_DETALLEBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Dim liRet As Integer
            If Me.Current.ID_ACCION_FORMATIVA = 0 Then
                liRet = mComponente.ActualizarACCION_FORMATIVA_DETALLE(Me.Current)
            Else
                liRet = mComponente.AgregarACCION_FORMATIVA_DETALLE(Me.Current)
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

    Private Sub ListaACCION_FORMATIVA_DETALLEBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaACCION_FORMATIVA_DETALLEBindingSource.AddingNew
        Dim lEntidad As New ACCION_FORMATIVA_DETALLE
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaACCION_FORMATIVA_DETALLEBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_FORMATIVA_DETALLEBindingSource.PositionChanged
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
        Me.ListaACCION_FORMATIVA_DETALLEGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaACCION_FORMATIVA_DETALLEGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaACCION_FORMATIVA_DETALLEGridControl.Dock = DockStyle.None
            Me.ListaACCION_FORMATIVA_DETALLEGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaACCION_FORMATIVA_DETALLEGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaACCION_FORMATIVA_DETALLEGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
