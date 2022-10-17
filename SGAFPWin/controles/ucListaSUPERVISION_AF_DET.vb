Imports SGAFP.EL
Public Class ucListaSUPERVISION_AF_DET

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSUPERVISION_AF_DETBindingSource
    End Sub

    Private mComponente As New cSUPERVISION_AF_DET
    Private _mListaSUPERVISION_AF_DET As New listaSUPERVISION_AF_DET
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) 

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

    Private _VerID_SUPERVISION_DET As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SUPERVISION_DET() As Boolean
        Get
            Return Me._VerID_SUPERVISION_DET
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SUPERVISION_DET = value
            Me.DataGridViewTextBoxID_SUPERVISION_DET.Visible = value
        End Set
    End Property

    Private _VerID_LISTA_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_LISTA_SUPERVISION() As Boolean
        Get
            Return Me._VerID_LISTA_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_LISTA_SUPERVISION = value
            Me.DataGridViewTextBoxID_LISTA_SUPERVISION.Visible = value
        End Set
    End Property

    Private _VerID_SUPERVISION_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me._VerID_SUPERVISION_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SUPERVISION_AF = value
            Me.DataGridViewTextBoxID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Private _VerCOMENTARIOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me._VerCOMENTARIOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerCOMENTARIOS = value
            Me.DataGridViewTextBoxCOMENTARIOS.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SUPERVISION_AF_DET
        Get
            Return CType(Me.ListaSUPERVISION_AF_DETBindingSource.Current, SUPERVISION_AF_DET)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSUPERVISION_AF_DET = Me.mComponente.ObtenerLista()
        If _mListaSUPERVISION_AF_DET Is Nothing Then Return -1
        Me.ListaSUPERVISION_AF_DETBindingSource.DataSource = _mListaSUPERVISION_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' filtrado por la tabla LISTA_SUPERVISION_AF
    ''' </summary>
    ''' <param name="ID_LISTA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLISTA_SUPERVISION_AF(ByVal ID_LISTA_SUPERVISION As Decimal) As Integer
        _mListaSUPERVISION_AF_DET = Me.mComponente.ObtenerListaPorLISTA_SUPERVISION_AF(ID_LISTA_SUPERVISION)
        If _mListaSUPERVISION_AF_DET Is Nothing Then Return -1
        Me.ListaSUPERVISION_AF_DETBindingSource.DataSource = _mListaSUPERVISION_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' filtrado por la tabla SUPERVISION_AF
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal) As Integer
        _mListaSUPERVISION_AF_DET = Me.mComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If _mListaSUPERVISION_AF_DET Is Nothing Then Return -1
        Me.ListaSUPERVISION_AF_DETBindingSource.DataSource = _mListaSUPERVISION_AF_DET
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
        If Not Me.ListaSUPERVISION_AF_DETBindingSource.Current Is Nothing Then
            If Me.Current.ID_SUPERVISION_DET = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSUPERVISION_AF_DETBindingSource.Current Is Nothing Then
            If mComponente.EliminarSUPERVISION_AF_DET( Me.Current.ID_SUPERVISION_DET) <> 1 Then
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
        If Not Me.ListaSUPERVISION_AF_DETBindingSource.Current Is Nothing Then
            Me.ListaSUPERVISION_AF_DETBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSUPERVISION_AF_DET(Me.Current)
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

    Private Sub ListaSUPERVISION_AF_DETBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSUPERVISION_AF_DETBindingSource.AddingNew
        Dim lEntidad As New SUPERVISION_AF_DET
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSUPERVISION_AF_DETBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSUPERVISION_AF_DETBindingSource.PositionChanged
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
        Me.ListaSUPERVISION_AF_DETDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaSUPERVISION_AF_DETDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaSUPERVISION_AF_DETDataGridView.Dock = DockStyle.None
            Me.ListaSUPERVISION_AF_DETDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSUPERVISION_AF_DETDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSUPERVISION_AF_DETDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
