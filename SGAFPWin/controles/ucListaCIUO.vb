Imports SGAFP.EL
Public Class ucListaCIUO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCIUOBindingSource
    End Sub

    Private mComponente As New cCIUO
    Private _mListaCIUO As New listaCIUO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal CIUO As String) 

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

    Private _VerCIUO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCIUO() As Boolean
        Get
            Return Me._VerCIUO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCIUO = value
            Me.DataGridViewTextBoxCIUO.Visible = value
        End Set
    End Property

    Private _VerDESCRIPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me._VerDESCRIPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDESCRIPCION = value
            Me.DataGridViewTextBoxDESCRIPCION.Visible = value
        End Set
    End Property

    Private _VerDESCRIPCION_NACIONAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDESCRIPCION_NACIONAL() As Boolean
        Get
            Return Me._VerDESCRIPCION_NACIONAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerDESCRIPCION_NACIONAL = value
            Me.DataGridViewTextBoxDESCRIPCION_NACIONAL.Visible = value
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

    Public ReadOnly Property Current() As CIUO
        Get
            Return CType(Me.ListaCIUOBindingSource.Current, CIUO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CIUO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCIUO = Me.mComponente.ObtenerLista()
        If _mListaCIUO Is Nothing Then Return -1
        Me.ListaCIUOBindingSource.DataSource = _mListaCIUO
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
        If Not Me.ListaCIUOBindingSource.Current Is Nothing Then
            If Me.Current.CIUO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCIUOBindingSource.Current Is Nothing Then
            If mComponente.EliminarCIUO( Me.Current.CIUO) <> 1 Then
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
        If Not Me.ListaCIUOBindingSource.Current Is Nothing Then
            Me.ListaCIUOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCIUO(Me.Current)
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

    Private Sub ListaCIUOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCIUOBindingSource.AddingNew
        Dim lEntidad As New CIUO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCIUOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCIUOBindingSource.PositionChanged
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
        Me.ListaCIUODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaCIUODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaCIUODataGridView.Dock = DockStyle.None
            Me.ListaCIUODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCIUODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCIUODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
