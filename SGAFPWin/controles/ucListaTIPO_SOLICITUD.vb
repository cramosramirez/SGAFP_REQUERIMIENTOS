Imports SGAFP.EL
Public Class ucListaTIPO_SOLICITUD

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaTIPO_SOLICITUDBindingSource
    End Sub

    Private mComponente As New cTIPO_SOLICITUD
    Private _mListaTIPO_SOLICITUD As New listaTIPO_SOLICITUD
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_TIPO_SOLICITUD As Decimal) 

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

    Private _VerID_TIPO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_TIPO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_SOLICITUD = value
            Me.DataGridViewTextBoxID_TIPO_SOLICITUD.Visible = value
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

    Private _VerTIPO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_SOLICITUD() As Boolean
        Get
            Return Me._VerTIPO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_SOLICITUD = value
            Me.DataGridViewTextBoxTIPO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerTABLA_RELACIONAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTABLA_RELACIONAL() As Boolean
        Get
            Return Me._VerTABLA_RELACIONAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerTABLA_RELACIONAL = value
            Me.DataGridViewTextBoxTABLA_RELACIONAL.Visible = value
        End Set
    End Property

    Private _VerNOTAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTAS() As Boolean
        Get
            Return Me._VerNOTAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTAS = value
            Me.DataGridViewTextBoxNOTAS.Visible = value
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

    Public ReadOnly Property Current() As TIPO_SOLICITUD
        Get
            Return CType(Me.ListaTIPO_SOLICITUDBindingSource.Current, TIPO_SOLICITUD)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaTIPO_SOLICITUD = Me.mComponente.ObtenerLista()
        If _mListaTIPO_SOLICITUD Is Nothing Then Return -1
        Me.ListaTIPO_SOLICITUDBindingSource.DataSource = _mListaTIPO_SOLICITUD
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_SOLICITUD
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
        _mListaTIPO_SOLICITUD = Me.mComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If _mListaTIPO_SOLICITUD Is Nothing Then Return -1
        Me.ListaTIPO_SOLICITUDBindingSource.DataSource = _mListaTIPO_SOLICITUD
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
        If Not Me.ListaTIPO_SOLICITUDBindingSource.Current Is Nothing Then
            If Me.Current.ID_TIPO_SOLICITUD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaTIPO_SOLICITUDBindingSource.Current Is Nothing Then
            If mComponente.EliminarTIPO_SOLICITUD( Me.Current.ID_TIPO_SOLICITUD) <> 1 Then
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
        If Not Me.ListaTIPO_SOLICITUDBindingSource.Current Is Nothing Then
            Me.ListaTIPO_SOLICITUDBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarTIPO_SOLICITUD(Me.Current)
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

    Private Sub ListaTIPO_SOLICITUDBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaTIPO_SOLICITUDBindingSource.AddingNew
        Dim lEntidad As New TIPO_SOLICITUD
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaTIPO_SOLICITUDBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTIPO_SOLICITUDBindingSource.PositionChanged
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
        Me.ListaTIPO_SOLICITUDDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaTIPO_SOLICITUDDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaTIPO_SOLICITUDDataGridView.Dock = DockStyle.None
            Me.ListaTIPO_SOLICITUDDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaTIPO_SOLICITUDDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaTIPO_SOLICITUDDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
