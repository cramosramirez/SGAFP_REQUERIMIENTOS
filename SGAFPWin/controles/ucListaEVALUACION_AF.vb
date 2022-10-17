Imports SGAFP.EL
Public Class ucListaEVALUACION_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaEVALUACION_AFBindingSource
    End Sub

    Private mComponente As New cEVALUACION_AF
    Private _mListaEVALUACION_AF As New listaEVALUACION_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_EVALUACION_AF As Decimal) 

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

    Private _VerID_ACCION_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me._VerID_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_FORMATIVA = value
            Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerFECHA_EVALUACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_EVALUACION() As Boolean
        Get
            Return Me._VerFECHA_EVALUACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_EVALUACION = value
            Me.DataGridViewTextBoxFECHA_EVALUACION.Visible = value
        End Set
    End Property

    Private _VerTEMA_EVALUACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTEMA_EVALUACION() As Boolean
        Get
            Return Me._VerTEMA_EVALUACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTEMA_EVALUACION = value
            Me.DataGridViewTextBoxTEMA_EVALUACION.Visible = value
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

    Private _VerEVALUADOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEVALUADOR() As Boolean
        Get
            Return Me._VerEVALUADOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerEVALUADOR = value
            Me.DataGridViewTextBoxEVALUADOR.Visible = value
        End Set
    End Property

    Private _VerTIPO_EVALUACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_EVALUACION() As Boolean
        Get
            Return Me._VerTIPO_EVALUACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_EVALUACION = value
            Me.DataGridViewTextBoxTIPO_EVALUACION.Visible = value
        End Set
    End Property

    Private _VerPORC_APROBACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPORC_APROBACION() As Boolean
        Get
            Return Me._VerPORC_APROBACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerPORC_APROBACION = value
            Me.DataGridViewTextBoxPORC_APROBACION.Visible = value
        End Set
    End Property

    Private _VerPORC_REPROBADOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPORC_REPROBADOS() As Boolean
        Get
            Return Me._VerPORC_REPROBADOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerPORC_REPROBADOS = value
            Me.DataGridViewTextBoxPORC_REPROBADOS.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As EVALUACION_AF
        Get
            Return CType(Me.ListaEVALUACION_AFBindingSource.Current, EVALUACION_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaEVALUACION_AF = Me.mComponente.ObtenerLista()
        If _mListaEVALUACION_AF Is Nothing Then Return -1
        Me.ListaEVALUACION_AFBindingSource.DataSource = _mListaEVALUACION_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACION_AF
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaEVALUACION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaEVALUACION_AF Is Nothing Then Return -1
        Me.ListaEVALUACION_AFBindingSource.DataSource = _mListaEVALUACION_AF
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
        If Not Me.ListaEVALUACION_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_EVALUACION_AF = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaEVALUACION_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarEVALUACION_AF( Me.Current.ID_EVALUACION_AF) <> 1 Then
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
        If Not Me.ListaEVALUACION_AFBindingSource.Current Is Nothing Then
            Me.ListaEVALUACION_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarEVALUACION_AF(Me.Current)
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

    Private Sub ListaEVALUACION_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaEVALUACION_AFBindingSource.AddingNew
        Dim lEntidad As New EVALUACION_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaEVALUACION_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEVALUACION_AFBindingSource.PositionChanged
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
        Me.ListaEVALUACION_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaEVALUACION_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaEVALUACION_AFDataGridView.Dock = DockStyle.None
            Me.ListaEVALUACION_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaEVALUACION_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaEVALUACION_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
