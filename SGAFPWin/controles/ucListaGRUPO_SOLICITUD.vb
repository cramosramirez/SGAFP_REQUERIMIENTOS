Imports SGAFP.EL
Public Class ucListaGRUPO_SOLICITUD

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaGRUPO_SOLICITUDBindingSource
    End Sub

    Private _mComponente As cGRUPO_SOLICITUD
    Public ReadOnly Property mComponente() As cGRUPO_SOLICITUD
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cGRUPO_SOLICITUD
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaGRUPO_SOLICITUD As New listaGRUPO_SOLICITUD
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_GRUPO_SOLICITUD As Decimal) 

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

    Private _VerID_GRUPO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_GRUPO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_GRUPO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_GRUPO_SOLICITUD = value
            Me.colID_GRUPO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.colID_SOLICITUD.Visible = value
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

    Private _VerCODIGO_PROGRAMA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_PROGRAMA() As Boolean
        Get
            Return Me._VerCODIGO_PROGRAMA
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_PROGRAMA = value
            Me.colCODIGO_PROGRAMA.Visible = value
        End Set
    End Property

    Private _VerDURACION_HORAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me._VerDURACION_HORAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION_HORAS = value
            Me.colDURACION_HORAS.Visible = value
        End Set
    End Property

    Private _VerNUM_PARTICIPANTES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_PARTICIPANTES() As Boolean
        Get
            Return Me._VerNUM_PARTICIPANTES
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_PARTICIPANTES = value
            Me.colNUM_PARTICIPANTES.Visible = value
        End Set
    End Property

    Private _VerTDR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTDR() As Boolean
        Get
            Return Me._VerTDR
        End Get
        Set(ByVal value As Boolean)
            Me._VerTDR = value
            Me.colTDR.Visible = value
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

    Public ReadOnly Property Current() As GRUPO_SOLICITUD
        Get
            Return CType(Me.ListaGRUPO_SOLICITUDBindingSource.Current, GRUPO_SOLICITUD)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaGRUPO_SOLICITUD = Me.mComponente.ObtenerLista()
        If _mListaGRUPO_SOLICITUD Is Nothing Then Return -1
        Me.ListaGRUPO_SOLICITUDBindingSource.DataSource = _mListaGRUPO_SOLICITUD
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_SOLICITUD
    ''' filtrado por la tabla SOLICITUD_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal) As Integer
        _mListaGRUPO_SOLICITUD = Me.mComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If _mListaGRUPO_SOLICITUD Is Nothing Then Return -1
        Me.ListaGRUPO_SOLICITUDBindingSource.DataSource = _mListaGRUPO_SOLICITUD
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_SOLICITUD
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
        _mListaGRUPO_SOLICITUD = Me.mComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If _mListaGRUPO_SOLICITUD Is Nothing Then Return -1
        Me.ListaGRUPO_SOLICITUDBindingSource.DataSource = _mListaGRUPO_SOLICITUD
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
        If Not Me.ListaGRUPO_SOLICITUDBindingSource.Current Is Nothing Then
            If Me.Current.ID_GRUPO_SOLICITUD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaGRUPO_SOLICITUDBindingSource.Current Is Nothing Then
            If mComponente.EliminarGRUPO_SOLICITUD(Me.Current.ID_GRUPO_SOLICITUD) <> 1 Then
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
        If Not Me.ListaGRUPO_SOLICITUDBindingSource.Current Is Nothing Then
            Me.ListaGRUPO_SOLICITUDBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarGRUPO_SOLICITUD(Me.Current)
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

    Private Sub ListaGRUPO_SOLICITUDBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaGRUPO_SOLICITUDBindingSource.AddingNew
        Dim lEntidad As New GRUPO_SOLICITUD
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaGRUPO_SOLICITUDBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_SOLICITUDBindingSource.PositionChanged
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
        Me.ListaGRUPO_SOLICITUDGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaGRUPO_SOLICITUDGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaGRUPO_SOLICITUDGridControl.Dock = DockStyle.None
            Me.ListaGRUPO_SOLICITUDGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaGRUPO_SOLICITUDGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaGRUPO_SOLICITUDGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
