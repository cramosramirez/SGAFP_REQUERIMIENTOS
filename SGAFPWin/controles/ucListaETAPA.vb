Imports SGAFP.EL
Public Class ucListaETAPA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaETAPABindingSource
    End Sub

    Private mComponente As New cETAPA
    Private _mListaETAPA As New listaETAPA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) 

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

    Private _CODIGO_PROCESO As String
    Public Property CODIGO_PROCESO() As String
        Get
            Return Me._CODIGO_PROCESO
        End Get
        Set(ByVal value As String)
            Me._CODIGO_PROCESO = value
        End Set
    End Property

    Private _VerCODIGO_ETAPA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_ETAPA() As Boolean
        Get
            Return Me._VerCODIGO_ETAPA
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_ETAPA = value
            Me.DataGridViewTextBoxCODIGO_ETAPA.Visible = value
        End Set
    End Property

    Private _VerCODIGO_PROCESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me._VerCODIGO_PROCESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_PROCESO = value
            Me.DataGridViewTextBoxCODIGO_PROCESO.Visible = value
        End Set
    End Property

    Private _VerID_ESTADO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_ESTADO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ESTADO_SOLICITUD = value
            Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerUNIDAD_DE_TIEMPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUNIDAD_DE_TIEMPO() As Boolean
        Get
            Return Me._VerUNIDAD_DE_TIEMPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerUNIDAD_DE_TIEMPO = value
            Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_ETAPA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_ETAPA() As Boolean
        Get
            Return Me._VerNOMBRE_ETAPA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_ETAPA = value
            Me.DataGridViewTextBoxNOMBRE_ETAPA.Visible = value
        End Set
    End Property

    Private _VerETAPA_ANT As Boolean = True
    <DefaultValue(True)> _
    Public Property VerETAPA_ANT() As Boolean
        Get
            Return Me._VerETAPA_ANT
        End Get
        Set(ByVal value As Boolean)
            Me._VerETAPA_ANT = value
            Me.DataGridViewTextBoxETAPA_ANT.Visible = value
        End Set
    End Property

    Private _VerETAPA_SIG As Boolean = True
    <DefaultValue(True)> _
    Public Property VerETAPA_SIG() As Boolean
        Get
            Return Me._VerETAPA_SIG
        End Get
        Set(ByVal value As Boolean)
            Me._VerETAPA_SIG = value
            Me.DataGridViewTextBoxETAPA_SIG.Visible = value
        End Set
    End Property

    Private _VerTIPO_ETAPA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_ETAPA() As Boolean
        Get
            Return Me._VerTIPO_ETAPA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_ETAPA = value
            Me.DataGridViewTextBoxTIPO_ETAPA.Visible = value
        End Set
    End Property

    Private _VerDURACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION() As Boolean
        Get
            Return Me._VerDURACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION = value
            Me.DataGridViewTextBoxDURACION.Visible = value
        End Set
    End Property

    Private _VerORDEN_EJECUCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerORDEN_EJECUCION() As Boolean
        Get
            Return Me._VerORDEN_EJECUCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerORDEN_EJECUCION = value
            Me.DataGridViewTextBoxORDEN_EJECUCION.Visible = value
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

    Public ReadOnly Property Current() As ETAPA
        Get
            Return CType(Me.ListaETAPABindingSource.Current, ETAPA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaETAPA = Me.mComponente.ObtenerLista(CODIGO_PROCESO)
        If _mListaETAPA Is Nothing Then Return -1
        Me.ListaETAPABindingSource.DataSource = _mListaETAPA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' filtrado por la tabla PROCESO
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROCESO(ByVal CODIGO_PROCESO As String) As Integer
        _mListaETAPA = Me.mComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If _mListaETAPA Is Nothing Then Return -1
        Me.ListaETAPABindingSource.DataSource = _mListaETAPA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' filtrado por la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal) As Integer
        _mListaETAPA = Me.mComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If _mListaETAPA Is Nothing Then Return -1
        Me.ListaETAPABindingSource.DataSource = _mListaETAPA
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
        If Not Me.ListaETAPABindingSource.Current Is Nothing Then
            If Me.Current.CODIGO_ETAPA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaETAPABindingSource.Current Is Nothing Then
            If mComponente.EliminarETAPA(CODIGO_PROCESO, Me.Current.CODIGO_ETAPA) <> 1 Then
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
        If Not Me.ListaETAPABindingSource.Current Is Nothing Then
            Me.ListaETAPABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarETAPA(Me.Current)
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

    Private Sub ListaETAPABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaETAPABindingSource.AddingNew
        Dim lEntidad As New ETAPA
        lEntidad.CODIGO_PROCESO = Me.CODIGO_PROCESO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaETAPABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaETAPABindingSource.PositionChanged
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
        Me.ListaETAPADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaETAPADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaETAPADataGridView.Dock = DockStyle.None
            Me.ListaETAPADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaETAPADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaETAPADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
