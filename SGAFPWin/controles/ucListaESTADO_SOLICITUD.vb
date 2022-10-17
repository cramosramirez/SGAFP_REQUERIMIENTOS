Imports SGAFP.EL
Public Class ucListaESTADO_SOLICITUD

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaESTADO_SOLICITUDBindingSource
    End Sub

    Private mComponente As New cESTADO_SOLICITUD
    Private _mListaESTADO_SOLICITUD As New listaESTADO_SOLICITUD
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_ESTADO_SOLICITUD As Decimal) 

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

    Private _VerESTADO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO_SOLICITUD() As Boolean
        Get
            Return Me._VerESTADO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO_SOLICITUD = value
            Me.DataGridViewTextBoxESTADO_SOLICITUD.Visible = value
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

    #End Region

    Public ReadOnly Property Current() As ESTADO_SOLICITUD
        Get
            Return CType(Me.ListaESTADO_SOLICITUDBindingSource.Current, ESTADO_SOLICITUD)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaESTADO_SOLICITUD = Me.mComponente.ObtenerLista()
        If _mListaESTADO_SOLICITUD Is Nothing Then Return -1
        Me.ListaESTADO_SOLICITUDBindingSource.DataSource = _mListaESTADO_SOLICITUD
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
        If Not Me.ListaESTADO_SOLICITUDBindingSource.Current Is Nothing Then
            If Me.Current.ID_ESTADO_SOLICITUD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaESTADO_SOLICITUDBindingSource.Current Is Nothing Then
            If mComponente.EliminarESTADO_SOLICITUD( Me.Current.ID_ESTADO_SOLICITUD) <> 1 Then
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
        If Not Me.ListaESTADO_SOLICITUDBindingSource.Current Is Nothing Then
            Me.ListaESTADO_SOLICITUDBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarESTADO_SOLICITUD(Me.Current)
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

    Private Sub ListaESTADO_SOLICITUDBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaESTADO_SOLICITUDBindingSource.AddingNew
        Dim lEntidad As New ESTADO_SOLICITUD
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaESTADO_SOLICITUDBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaESTADO_SOLICITUDBindingSource.PositionChanged
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
        Me.ListaESTADO_SOLICITUDDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaESTADO_SOLICITUDDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaESTADO_SOLICITUDDataGridView.Dock = DockStyle.None
            Me.ListaESTADO_SOLICITUDDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaESTADO_SOLICITUDDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaESTADO_SOLICITUDDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
