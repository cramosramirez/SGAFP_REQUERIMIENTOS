Imports SGAFP.EL
Public Class ucListaUSUARIO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaUSUARIOBindingSource
    End Sub

    Public ReadOnly Property mComponente() As cUSUARIO
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cUSUARIO
            End If
            Return _mComponente
        End Get
    End Property

    Private _mComponente As cUSUARIO
    Private _mListaUSUARIO As New listaUSUARIO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal USUARIO As String) 

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

    Private _VerUSUARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSUARIO() As Boolean
        Get
            Return Me._VerUSUARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSUARIO = value
            Me.DataGridViewTextBoxUSUARIO.Visible = value
        End Set
    End Property

    Private _VerID_PROVEEDOR_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me._VerID_PROVEEDOR_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROVEEDOR_AF = value
            Me.DataGridViewTextBoxID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Private _VerID_SITIO_CAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me._VerID_SITIO_CAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SITIO_CAPACITACION = value
            Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Visible = value
        End Set
    End Property

    Private _VerID_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me._VerID_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PARTICIPANTE = value
            Me.DataGridViewTextBoxID_PARTICIPANTE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As USUARIO
        Get
            Return CType(Me.ListaUSUARIOBindingSource.Current, USUARIO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaUSUARIO = Me.mComponente.ObtenerLista()
        If _mListaUSUARIO Is Nothing Then Return -1
        Me.ListaUSUARIOBindingSource.DataSource = _mListaUSUARIO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaUSUARIO = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaUSUARIO Is Nothing Then Return -1
        Me.ListaUSUARIOBindingSource.DataSource = _mListaUSUARIO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        _mListaUSUARIO = Me.mComponente.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION)
        If _mListaUSUARIO Is Nothing Then Return -1
        Me.ListaUSUARIOBindingSource.DataSource = _mListaUSUARIO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla USUARIO
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        _mListaUSUARIO = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaUSUARIO Is Nothing Then Return -1
        Me.ListaUSUARIOBindingSource.DataSource = _mListaUSUARIO
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
        If Not Me.ListaUSUARIOBindingSource.Current Is Nothing Then
            If Me.Current.USUARIO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaUSUARIOBindingSource.Current Is Nothing Then
            If mComponente.EliminarUSUARIO( Me.Current.USUARIO) <> 1 Then
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
        If Not Me.ListaUSUARIOBindingSource.Current Is Nothing Then
            Me.ListaUSUARIOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarUSUARIO(Me.Current)
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

    Private Sub ListaUSUARIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaUSUARIOBindingSource.AddingNew
        Dim lEntidad As New USUARIO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaUSUARIOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaUSUARIOBindingSource.PositionChanged
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
        Me.ListaUSUARIODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaUSUARIODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaUSUARIODataGridView.Dock = DockStyle.None
            Me.ListaUSUARIODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaUSUARIODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaUSUARIODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
