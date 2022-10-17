Imports SGAFP.EL
Public Class ucListaAREA_SUPERVISION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaAREA_SUPERVISIONBindingSource
    End Sub

    Private mComponente As New cAREA_SUPERVISION
    Private _mListaAREA_SUPERVISION As New listaAREA_SUPERVISION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_AREA_SUPERVISION As Decimal) 

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

    Private _VerID_AREA_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_AREA_SUPERVISION() As Boolean
        Get
            Return Me._VerID_AREA_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_AREA_SUPERVISION = value
            Me.DataGridViewTextBoxID_AREA_SUPERVISION.Visible = value
        End Set
    End Property

    Private _VerAREA_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAREA_SUPERVISION() As Boolean
        Get
            Return Me._VerAREA_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerAREA_SUPERVISION = value
            Me.DataGridViewTextBoxAREA_SUPERVISION.Visible = value
        End Set
    End Property

    Private _VerSANCIONATORIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerSANCIONATORIA() As Boolean
        Get
            Return Me._VerSANCIONATORIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerSANCIONATORIA = value
            Me.DataGridViewTextBoxSANCIONATORIA.Visible = value
        End Set
    End Property

    Private _VerMONTO_SANCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_SANCION() As Boolean
        Get
            Return Me._VerMONTO_SANCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_SANCION = value
            Me.DataGridViewTextBoxMONTO_SANCION.Visible = value
        End Set
    End Property

    Private _VerTIEMPO_SANCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIEMPO_SANCION() As Boolean
        Get
            Return Me._VerTIEMPO_SANCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIEMPO_SANCION = value
            Me.DataGridViewTextBoxTIEMPO_SANCION.Visible = value
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

    Public ReadOnly Property Current() As AREA_SUPERVISION
        Get
            Return CType(Me.ListaAREA_SUPERVISIONBindingSource.Current, AREA_SUPERVISION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla AREA_SUPERVISION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaAREA_SUPERVISION = Me.mComponente.ObtenerLista()
        If _mListaAREA_SUPERVISION Is Nothing Then Return -1
        Me.ListaAREA_SUPERVISIONBindingSource.DataSource = _mListaAREA_SUPERVISION
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
        If Not Me.ListaAREA_SUPERVISIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_AREA_SUPERVISION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaAREA_SUPERVISIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarAREA_SUPERVISION( Me.Current.ID_AREA_SUPERVISION) <> 1 Then
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
        If Not Me.ListaAREA_SUPERVISIONBindingSource.Current Is Nothing Then
            Me.ListaAREA_SUPERVISIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarAREA_SUPERVISION(Me.Current)
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

    Private Sub ListaAREA_SUPERVISIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaAREA_SUPERVISIONBindingSource.AddingNew
        Dim lEntidad As New AREA_SUPERVISION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaAREA_SUPERVISIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaAREA_SUPERVISIONBindingSource.PositionChanged
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
        Me.ListaAREA_SUPERVISIONDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaAREA_SUPERVISIONDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaAREA_SUPERVISIONDataGridView.Dock = DockStyle.None
            Me.ListaAREA_SUPERVISIONDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaAREA_SUPERVISIONDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaAREA_SUPERVISIONDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
