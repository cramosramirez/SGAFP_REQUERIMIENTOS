Imports SGAFP.EL
Public Class ucListaMETODO_EVALUACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaMETODO_EVALUACIONBindingSource
    End Sub

    Private mComponente As New cMETODO_EVALUACION
    Private _mListaMETODO_EVALUACION As New listaMETODO_EVALUACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_METODO_EVALUACION As Decimal) 

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

    Private _VerID_METODO_EVALUACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_METODO_EVALUACION() As Boolean
        Get
            Return Me._VerID_METODO_EVALUACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_METODO_EVALUACION = value
            Me.DataGridViewTextBoxID_METODO_EVALUACION.Visible = value
        End Set
    End Property

    Private _VerMETODO_EVALUACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMETODO_EVALUACION() As Boolean
        Get
            Return Me._VerMETODO_EVALUACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerMETODO_EVALUACION = value
            Me.DataGridViewTextBoxMETODO_EVALUACION.Visible = value
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

    Public ReadOnly Property Current() As METODO_EVALUACION
        Get
            Return CType(Me.ListaMETODO_EVALUACIONBindingSource.Current, METODO_EVALUACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla METODO_EVALUACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaMETODO_EVALUACION = Me.mComponente.ObtenerLista()
        If _mListaMETODO_EVALUACION Is Nothing Then Return -1
        Me.ListaMETODO_EVALUACIONBindingSource.DataSource = _mListaMETODO_EVALUACION
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
        If Not Me.ListaMETODO_EVALUACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_METODO_EVALUACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaMETODO_EVALUACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarMETODO_EVALUACION( Me.Current.ID_METODO_EVALUACION) <> 1 Then
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
        If Not Me.ListaMETODO_EVALUACIONBindingSource.Current Is Nothing Then
            Me.ListaMETODO_EVALUACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarMETODO_EVALUACION(Me.Current)
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

    Private Sub ListaMETODO_EVALUACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaMETODO_EVALUACIONBindingSource.AddingNew
        Dim lEntidad As New METODO_EVALUACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaMETODO_EVALUACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaMETODO_EVALUACIONBindingSource.PositionChanged
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
        Me.ListaMETODO_EVALUACIONDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaMETODO_EVALUACIONDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaMETODO_EVALUACIONDataGridView.Dock = DockStyle.None
            Me.ListaMETODO_EVALUACIONDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaMETODO_EVALUACIONDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaMETODO_EVALUACIONDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
