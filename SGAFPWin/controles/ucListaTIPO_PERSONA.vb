Imports SGAFP.EL
Public Class ucListaTIPO_PERSONA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaTIPO_PERSONABindingSource
    End Sub

    Private mComponente As New cTIPO_PERSONA
    Private _mListaTIPO_PERSONA As New listaTIPO_PERSONA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_TIPO_PERSONA As Decimal) 

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

    Private _VerID_TIPO_PERSONA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_PERSONA() As Boolean
        Get
            Return Me._VerID_TIPO_PERSONA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_PERSONA = value
            Me.DataGridViewTextBoxID_TIPO_PERSONA.Visible = value
        End Set
    End Property

    Private _VerTIPO_PERSONA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_PERSONA() As Boolean
        Get
            Return Me._VerTIPO_PERSONA
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_PERSONA = value
            Me.DataGridViewTextBoxTIPO_PERSONA.Visible = value
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

    Public ReadOnly Property Current() As TIPO_PERSONA
        Get
            Return CType(Me.ListaTIPO_PERSONABindingSource.Current, TIPO_PERSONA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TIPO_PERSONA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaTIPO_PERSONA = Me.mComponente.ObtenerLista()
        If _mListaTIPO_PERSONA Is Nothing Then Return -1
        Me.ListaTIPO_PERSONABindingSource.DataSource = _mListaTIPO_PERSONA
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
        If Not Me.ListaTIPO_PERSONABindingSource.Current Is Nothing Then
            If Me.Current.ID_TIPO_PERSONA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaTIPO_PERSONABindingSource.Current Is Nothing Then
            If mComponente.EliminarTIPO_PERSONA( Me.Current.ID_TIPO_PERSONA) <> 1 Then
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
        If Not Me.ListaTIPO_PERSONABindingSource.Current Is Nothing Then
            Me.ListaTIPO_PERSONABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarTIPO_PERSONA(Me.Current)
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

    Private Sub ListaTIPO_PERSONABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaTIPO_PERSONABindingSource.AddingNew
        Dim lEntidad As New TIPO_PERSONA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaTIPO_PERSONABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTIPO_PERSONABindingSource.PositionChanged
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
        Me.ListaTIPO_PERSONADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaTIPO_PERSONADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaTIPO_PERSONADataGridView.Dock = DockStyle.None
            Me.ListaTIPO_PERSONADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaTIPO_PERSONADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaTIPO_PERSONADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
