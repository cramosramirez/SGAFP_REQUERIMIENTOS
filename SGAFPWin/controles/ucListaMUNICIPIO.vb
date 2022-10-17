Imports SGAFP.EL
Public Class ucListaMUNICIPIO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaMUNICIPIOBindingSource
    End Sub

    Private mComponente As New cMUNICIPIO
    Private _mListaMUNICIPIO As New listaMUNICIPIO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) 

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

    Private _CODIGO_REGION As String
    Public Property CODIGO_REGION() As String
        Get
            Return Me._CODIGO_REGION
        End Get
        Set(ByVal value As String)
            Me._CODIGO_REGION = value
        End Set
    End Property

    Private _CODIGO_DEPARTAMENTO As String
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me._CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal value As String)
            Me._CODIGO_DEPARTAMENTO = value
        End Set
    End Property

    Private _VerCODIGO_MUNICIPIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me._VerCODIGO_MUNICIPIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_MUNICIPIO = value
            Me.DataGridViewTextBoxCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_REGION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me._VerCODIGO_REGION
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_REGION = value
            Me.DataGridViewTextBoxCODIGO_REGION.Visible = value
        End Set
    End Property

    Private _VerCODIGO_DEPARTAMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me._VerCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_DEPARTAMENTO = value
            Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Private _VerNOMBRE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE() As Boolean
        Get
            Return Me._VerNOMBRE
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE = value
            Me.DataGridViewTextBoxNOMBRE.Visible = value
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

    Public ReadOnly Property Current() As MUNICIPIO
        Get
            Return CType(Me.ListaMUNICIPIOBindingSource.Current, MUNICIPIO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaMUNICIPIO = Me.mComponente.ObtenerLista(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If _mListaMUNICIPIO Is Nothing Then Return -1
        Me.ListaMUNICIPIOBindingSource.DataSource = _mListaMUNICIPIO
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaMUNICIPIO = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If _mListaMUNICIPIO Is Nothing Then Return -1
        Me.ListaMUNICIPIOBindingSource.DataSource = _mListaMUNICIPIO
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
        If Not Me.ListaMUNICIPIOBindingSource.Current Is Nothing Then
            If Me.Current.CODIGO_MUNICIPIO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaMUNICIPIOBindingSource.Current Is Nothing Then
            If mComponente.EliminarMUNICIPIO(CODIGO_DEPARTAMENTO, Me.Current.CODIGO_MUNICIPIO) <> 1 Then
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
        If Not Me.ListaMUNICIPIOBindingSource.Current Is Nothing Then
            Me.ListaMUNICIPIOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarMUNICIPIO(Me.Current)
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

    Private Sub ListaMUNICIPIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaMUNICIPIOBindingSource.AddingNew
        Dim lEntidad As New MUNICIPIO
        lEntidad.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaMUNICIPIOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaMUNICIPIOBindingSource.PositionChanged
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
        Me.ListaMUNICIPIODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaMUNICIPIODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaMUNICIPIODataGridView.Dock = DockStyle.None
            Me.ListaMUNICIPIODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaMUNICIPIODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaMUNICIPIODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
