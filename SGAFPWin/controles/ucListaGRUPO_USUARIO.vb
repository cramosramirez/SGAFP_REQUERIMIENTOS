Imports SGAFP.EL
Public Class ucListaGRUPO_USUARIO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaGRUPO_USUARIOBindingSource
    End Sub

    Private mComponente As New cGRUPO_USUARIO
    Private _mListaGRUPO_USUARIO As New listaGRUPO_USUARIO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_GRUPO_USUARIO As Decimal) 

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

    Private _VerROL_USUARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerROL_USUARIO() As Boolean
        Get
            Return Me._VerROL_USUARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerROL_USUARIO = value
            Me.DataGridViewTextBoxROL_USUARIO.Visible = value
        End Set
    End Property

    Private _VerNIVEL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIVEL() As Boolean
        Get
            Return Me._VerNIVEL
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIVEL = value
            Me.DataGridViewTextBoxNIVEL.Visible = value
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

    Public ReadOnly Property Current() As GRUPO_USUARIO
        Get
            Return CType(Me.ListaGRUPO_USUARIOBindingSource.Current, GRUPO_USUARIO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaGRUPO_USUARIO = Me.mComponente.ObtenerLista()
        If _mListaGRUPO_USUARIO Is Nothing Then Return -1
        Me.ListaGRUPO_USUARIOBindingSource.DataSource = _mListaGRUPO_USUARIO
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
        If Not Me.ListaGRUPO_USUARIOBindingSource.Current Is Nothing Then
            If Me.Current.ID_GRUPO_USUARIO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaGRUPO_USUARIOBindingSource.Current Is Nothing Then
            If mComponente.EliminarGRUPO_USUARIO( Me.Current.ID_GRUPO_USUARIO) <> 1 Then
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
        If Not Me.ListaGRUPO_USUARIOBindingSource.Current Is Nothing Then
            Me.ListaGRUPO_USUARIOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarGRUPO_USUARIO(Me.Current)
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

    Private Sub ListaGRUPO_USUARIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaGRUPO_USUARIOBindingSource.AddingNew
        Dim lEntidad As New GRUPO_USUARIO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaGRUPO_USUARIOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_USUARIOBindingSource.PositionChanged
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
        Me.ListaGRUPO_USUARIODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaGRUPO_USUARIODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaGRUPO_USUARIODataGridView.Dock = DockStyle.None
            Me.ListaGRUPO_USUARIODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaGRUPO_USUARIODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaGRUPO_USUARIODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
