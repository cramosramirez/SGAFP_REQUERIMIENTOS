Imports SGAFP.EL
Public Class ucListaEJERCICIO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaEJERCICIOBindingSource
    End Sub

    Private mComponente As New cEJERCICIO
    Private _mListaEJERCICIO As New listaEJERCICIO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_EJERCICIO As String) 

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

    Private _VerID_EJERCICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me._VerID_EJERCICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_EJERCICIO = value
            Me.DataGridViewTextBoxID_EJERCICIO.Visible = value
        End Set
    End Property

    Private _VerETIQUETA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerETIQUETA() As Boolean
        Get
            Return Me._VerETIQUETA
        End Get
        Set(ByVal value As Boolean)
            Me._VerETIQUETA = value
            Me.DataGridViewTextBoxETIQUETA.Visible = value
        End Set
    End Property

    Private _VerFECHA_INICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me._VerFECHA_INICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INICIO = value
            Me.DataGridViewTextBoxFECHA_INICIO.Visible = value
        End Set
    End Property

    Private _VerFECHA_FIN As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me._VerFECHA_FIN
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_FIN = value
            Me.DataGridViewTextBoxFECHA_FIN.Visible = value
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

    Public ReadOnly Property Current() As EJERCICIO
        Get
            Return CType(Me.ListaEJERCICIOBindingSource.Current, EJERCICIO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EJERCICIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaEJERCICIO = Me.mComponente.ObtenerLista()
        If _mListaEJERCICIO Is Nothing Then Return -1
        Me.ListaEJERCICIOBindingSource.DataSource = _mListaEJERCICIO
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
        If Not Me.ListaEJERCICIOBindingSource.Current Is Nothing Then
            If Me.Current.ID_EJERCICIO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaEJERCICIOBindingSource.Current Is Nothing Then
            If mComponente.EliminarEJERCICIO( Me.Current.ID_EJERCICIO) <> 1 Then
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
        If Not Me.ListaEJERCICIOBindingSource.Current Is Nothing Then
            Me.ListaEJERCICIOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarEJERCICIO(Me.Current)
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

    Private Sub ListaEJERCICIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaEJERCICIOBindingSource.AddingNew
        Dim lEntidad As New EJERCICIO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaEJERCICIOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEJERCICIOBindingSource.PositionChanged
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
        Me.ListaEJERCICIODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaEJERCICIODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaEJERCICIODataGridView.Dock = DockStyle.None
            Me.ListaEJERCICIODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaEJERCICIODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaEJERCICIODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
