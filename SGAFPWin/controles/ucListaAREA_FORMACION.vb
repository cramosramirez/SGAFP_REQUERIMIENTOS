Imports SGAFP.EL
Public Class ucListaAREA_FORMACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaAREA_FORMACIONBindingSource
    End Sub

    Private mComponente As New cAREA_FORMACION
    Private _mListaAREA_FORMACION As New listaAREA_FORMACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_AREA_FORMACION As Decimal) 

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

    Private _VerID_AREA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_AREA_FORMACION() As Boolean
        Get
            Return Me._VerID_AREA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_AREA_FORMACION = value
            Me.DataGridViewTextBoxID_AREA_FORMACION.Visible = value
        End Set
    End Property

    Private _VerAREA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAREA_FORMACION() As Boolean
        Get
            Return Me._VerAREA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerAREA_FORMACION = value
            Me.DataGridViewTextBoxAREA_FORMACION.Visible = value
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

    Public ReadOnly Property Current() As AREA_FORMACION
        Get
            Return CType(Me.ListaAREA_FORMACIONBindingSource.Current, AREA_FORMACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla AREA_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaAREA_FORMACION = Me.mComponente.ObtenerLista()
        If _mListaAREA_FORMACION Is Nothing Then Return -1
        Me.ListaAREA_FORMACIONBindingSource.DataSource = _mListaAREA_FORMACION
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
        If Not Me.ListaAREA_FORMACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_AREA_FORMACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaAREA_FORMACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarAREA_FORMACION( Me.Current.ID_AREA_FORMACION) <> 1 Then
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
        If Not Me.ListaAREA_FORMACIONBindingSource.Current Is Nothing Then
            Me.ListaAREA_FORMACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarAREA_FORMACION(Me.Current)
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

    Private Sub ListaAREA_FORMACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaAREA_FORMACIONBindingSource.AddingNew
        Dim lEntidad As New AREA_FORMACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaAREA_FORMACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaAREA_FORMACIONBindingSource.PositionChanged
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
        Me.ListaAREA_FORMACIONDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaAREA_FORMACIONDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaAREA_FORMACIONDataGridView.Dock = DockStyle.None
            Me.ListaAREA_FORMACIONDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaAREA_FORMACIONDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaAREA_FORMACIONDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
