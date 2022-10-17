Imports SGAFP.EL
Public Class ucListaLISTA_SUPERVISION_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaLISTA_SUPERVISION_AFBindingSource
    End Sub

    Private mComponente As New cLISTA_SUPERVISION_AF
    Private _mListaLISTA_SUPERVISION_AF As New listaLISTA_SUPERVISION_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_LISTA_SUPERVISION As Decimal) 

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

    Private _VerLISTA_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerLISTA_SUPERVISION() As Boolean
        Get
            Return Me._VerLISTA_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerLISTA_SUPERVISION = value
            Me.DataGridViewTextBoxLISTA_SUPERVISION.Visible = value
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

    Public ReadOnly Property Current() As LISTA_SUPERVISION_AF
        Get
            Return CType(Me.ListaLISTA_SUPERVISION_AFBindingSource.Current, LISTA_SUPERVISION_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla LISTA_SUPERVISION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaLISTA_SUPERVISION_AF = Me.mComponente.ObtenerLista()
        If _mListaLISTA_SUPERVISION_AF Is Nothing Then Return -1
        Me.ListaLISTA_SUPERVISION_AFBindingSource.DataSource = _mListaLISTA_SUPERVISION_AF
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
        If Not Me.ListaLISTA_SUPERVISION_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_LISTA_SUPERVISION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaLISTA_SUPERVISION_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarLISTA_SUPERVISION_AF( Me.Current.ID_LISTA_SUPERVISION) <> 1 Then
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
        If Not Me.ListaLISTA_SUPERVISION_AFBindingSource.Current Is Nothing Then
            Me.ListaLISTA_SUPERVISION_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarLISTA_SUPERVISION_AF(Me.Current)
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

    Private Sub ListaLISTA_SUPERVISION_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaLISTA_SUPERVISION_AFBindingSource.AddingNew
        Dim lEntidad As New LISTA_SUPERVISION_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaLISTA_SUPERVISION_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaLISTA_SUPERVISION_AFBindingSource.PositionChanged
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
        Me.ListaLISTA_SUPERVISION_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaLISTA_SUPERVISION_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaLISTA_SUPERVISION_AFDataGridView.Dock = DockStyle.None
            Me.ListaLISTA_SUPERVISION_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaLISTA_SUPERVISION_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaLISTA_SUPERVISION_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
