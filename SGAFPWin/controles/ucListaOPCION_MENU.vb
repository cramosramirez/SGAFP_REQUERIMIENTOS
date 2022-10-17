Imports SGAFP.EL
Public Class ucListaOPCION_MENU

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaOPCION_MENUBindingSource
    End Sub

    Private mComponente As New cOPCION_MENU
    Private _mListaOPCION_MENU As New listaOPCION_MENU
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_OPCION_MENU As Decimal) 

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

    Private _VerOPCION_MENU As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOPCION_MENU() As Boolean
        Get
            Return Me._VerOPCION_MENU
        End Get
        Set(ByVal value As Boolean)
            Me._VerOPCION_MENU = value
            Me.DataGridViewTextBoxOPCION_MENU.Visible = value
        End Set
    End Property

    Private _VerOPCION_SISTEMA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOPCION_SISTEMA() As Boolean
        Get
            Return Me._VerOPCION_SISTEMA
        End Get
        Set(ByVal value As Boolean)
            Me._VerOPCION_SISTEMA = value
            Me.DataGridViewTextBoxOPCION_SISTEMA.Visible = value
        End Set
    End Property

    Private _VerURL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerURL() As Boolean
        Get
            Return Me._VerURL
        End Get
        Set(ByVal value As Boolean)
            Me._VerURL = value
            Me.DataGridViewTextBoxURL.Visible = value
        End Set
    End Property

    Private _VerPAGINA_HTML As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPAGINA_HTML() As Boolean
        Get
            Return Me._VerPAGINA_HTML
        End Get
        Set(ByVal value As Boolean)
            Me._VerPAGINA_HTML = value
            Me.DataGridViewTextBoxPAGINA_HTML.Visible = value
        End Set
    End Property

    Private _VerOBJETO_USUARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOBJETO_USUARIO() As Boolean
        Get
            Return Me._VerOBJETO_USUARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerOBJETO_USUARIO = value
            Me.DataGridViewTextBoxOBJETO_USUARIO.Visible = value
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

    Public ReadOnly Property Current() As OPCION_MENU
        Get
            Return CType(Me.ListaOPCION_MENUBindingSource.Current, OPCION_MENU)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OPCION_MENU
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaOPCION_MENU = Me.mComponente.ObtenerLista()
        If _mListaOPCION_MENU Is Nothing Then Return -1
        Me.ListaOPCION_MENUBindingSource.DataSource = _mListaOPCION_MENU
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
        If Not Me.ListaOPCION_MENUBindingSource.Current Is Nothing Then
            If Me.Current.ID_OPCION_MENU = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaOPCION_MENUBindingSource.Current Is Nothing Then
            If mComponente.EliminarOPCION_MENU( Me.Current.ID_OPCION_MENU) <> 1 Then
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
        If Not Me.ListaOPCION_MENUBindingSource.Current Is Nothing Then
            Me.ListaOPCION_MENUBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarOPCION_MENU(Me.Current)
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

    Private Sub ListaOPCION_MENUBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaOPCION_MENUBindingSource.AddingNew
        Dim lEntidad As New OPCION_MENU
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaOPCION_MENUBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaOPCION_MENUBindingSource.PositionChanged
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
        Me.ListaOPCION_MENUDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaOPCION_MENUDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaOPCION_MENUDataGridView.Dock = DockStyle.None
            Me.ListaOPCION_MENUDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaOPCION_MENUDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaOPCION_MENUDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
