Imports SGAFP.EL
Public Class ucListaEVALUACIONES_AF_DET

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaEVALUACIONES_AF_DETBindingSource
    End Sub

    Private mComponente As New cEVALUACIONES_AF_DET
    Private _mListaEVALUACIONES_AF_DET As New listaEVALUACIONES_AF_DET
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_EVALUACION_DET As Decimal) 

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

    Private _VerID_EVALUACION_DET As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_EVALUACION_DET() As Boolean
        Get
            Return Me._VerID_EVALUACION_DET
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_EVALUACION_DET = value
            Me.DataGridViewTextBoxID_EVALUACION_DET.Visible = value
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

    Private _VerID_EVALUACION_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_EVALUACION_AF() As Boolean
        Get
            Return Me._VerID_EVALUACION_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_EVALUACION_AF = value
            Me.DataGridViewTextBoxID_EVALUACION_AF.Visible = value
        End Set
    End Property

    Private _VerNOTA_OBTENIDA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me._VerNOTA_OBTENIDA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTA_OBTENIDA = value
            Me.DataGridViewTextBoxNOTA_OBTENIDA.Visible = value
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

    Public ReadOnly Property Current() As EVALUACIONES_AF_DET
        Get
            Return CType(Me.ListaEVALUACIONES_AF_DETBindingSource.Current, EVALUACIONES_AF_DET)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaEVALUACIONES_AF_DET = Me.mComponente.ObtenerLista()
        If _mListaEVALUACIONES_AF_DET Is Nothing Then Return -1
        Me.ListaEVALUACIONES_AF_DETBindingSource.DataSource = _mListaEVALUACIONES_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
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
        _mListaEVALUACIONES_AF_DET = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaEVALUACIONES_AF_DET Is Nothing Then Return -1
        Me.ListaEVALUACIONES_AF_DETBindingSource.DataSource = _mListaEVALUACIONES_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
    ''' filtrado por la tabla EVALUACION_AF
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal) As Integer
        _mListaEVALUACIONES_AF_DET = Me.mComponente.ObtenerListaPorEVALUACION_AF(ID_EVALUACION_AF)
        If _mListaEVALUACIONES_AF_DET Is Nothing Then Return -1
        Me.ListaEVALUACIONES_AF_DETBindingSource.DataSource = _mListaEVALUACIONES_AF_DET
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
        If Not Me.ListaEVALUACIONES_AF_DETBindingSource.Current Is Nothing Then
            If Me.Current.ID_EVALUACION_DET = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaEVALUACIONES_AF_DETBindingSource.Current Is Nothing Then
            If mComponente.EliminarEVALUACIONES_AF_DET( Me.Current.ID_EVALUACION_DET) <> 1 Then
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
        If Not Me.ListaEVALUACIONES_AF_DETBindingSource.Current Is Nothing Then
            Me.ListaEVALUACIONES_AF_DETBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarEVALUACIONES_AF_DET(Me.Current)
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

    Private Sub ListaEVALUACIONES_AF_DETBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaEVALUACIONES_AF_DETBindingSource.AddingNew
        Dim lEntidad As New EVALUACIONES_AF_DET
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaEVALUACIONES_AF_DETBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEVALUACIONES_AF_DETBindingSource.PositionChanged
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
        Me.ListaEVALUACIONES_AF_DETDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaEVALUACIONES_AF_DETDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaEVALUACIONES_AF_DETDataGridView.Dock = DockStyle.None
            Me.ListaEVALUACIONES_AF_DETDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaEVALUACIONES_AF_DETDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaEVALUACIONES_AF_DETDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
