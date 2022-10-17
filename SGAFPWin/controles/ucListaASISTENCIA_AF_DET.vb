Imports SGAFP.EL
Public Class ucListaASISTENCIA_AF_DET

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaASISTENCIA_AF_DETBindingSource
    End Sub

    Private mComponente As New cASISTENCIA_AF_DET
    Private _mListaASISTENCIA_AF_DET As New listaASISTENCIA_AF_DET
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) 

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

    Private _VerID_ASISTENCIA_DET As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ASISTENCIA_DET() As Boolean
        Get
            Return Me._VerID_ASISTENCIA_DET
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ASISTENCIA_DET = value
            Me.DataGridViewTextBoxID_ASISTENCIA_DET.Visible = value
        End Set
    End Property

    Private _VerID_ASISTENCIA_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ASISTENCIA_AF() As Boolean
        Get
            Return Me._VerID_ASISTENCIA_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ASISTENCIA_AF = value
            Me.DataGridViewTextBoxID_ASISTENCIA_AF.Visible = value
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

    Private _VerASISTIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerASISTIO() As Boolean
        Get
            Return Me._VerASISTIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerASISTIO = value
            Me.DataGridViewTextBoxASISTIO.Visible = value
        End Set
    End Property

    Private _VerPRESENTA_JUSTIFICACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPRESENTA_JUSTIFICACION() As Boolean
        Get
            Return Me._VerPRESENTA_JUSTIFICACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerPRESENTA_JUSTIFICACION = value
            Me.DataGridViewTextBoxPRESENTA_JUSTIFICACION.Visible = value
        End Set
    End Property

    Private _VerJUSTIFICACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerJUSTIFICACION() As Boolean
        Get
            Return Me._VerJUSTIFICACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerJUSTIFICACION = value
            Me.DataGridViewTextBoxJUSTIFICACION.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As ASISTENCIA_AF_DET
        Get
            Return CType(Me.ListaASISTENCIA_AF_DETBindingSource.Current, ASISTENCIA_AF_DET)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaASISTENCIA_AF_DET = Me.mComponente.ObtenerLista()
        If _mListaASISTENCIA_AF_DET Is Nothing Then Return -1
        Me.ListaASISTENCIA_AF_DETBindingSource.DataSource = _mListaASISTENCIA_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' filtrado por la tabla ASISTENCIA_AF
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        _mListaASISTENCIA_AF_DET = Me.mComponente.ObtenerListaPorASISTENCIA_AF(ID_ASISTENCIA_AF)
        If _mListaASISTENCIA_AF_DET Is Nothing Then Return -1
        Me.ListaASISTENCIA_AF_DETBindingSource.DataSource = _mListaASISTENCIA_AF_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
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
        _mListaASISTENCIA_AF_DET = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaASISTENCIA_AF_DET Is Nothing Then Return -1
        Me.ListaASISTENCIA_AF_DETBindingSource.DataSource = _mListaASISTENCIA_AF_DET
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
        If Not Me.ListaASISTENCIA_AF_DETBindingSource.Current Is Nothing Then
            If Me.Current.ID_ASISTENCIA_DET = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaASISTENCIA_AF_DETBindingSource.Current Is Nothing Then
            If mComponente.EliminarASISTENCIA_AF_DET( Me.Current.ID_ASISTENCIA_DET) <> 1 Then
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
        If Not Me.ListaASISTENCIA_AF_DETBindingSource.Current Is Nothing Then
            Me.ListaASISTENCIA_AF_DETBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarASISTENCIA_AF_DET(Me.Current)
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

    Private Sub ListaASISTENCIA_AF_DETBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaASISTENCIA_AF_DETBindingSource.AddingNew
        Dim lEntidad As New ASISTENCIA_AF_DET
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaASISTENCIA_AF_DETBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaASISTENCIA_AF_DETBindingSource.PositionChanged
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
        Me.ListaASISTENCIA_AF_DETDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaASISTENCIA_AF_DETDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaASISTENCIA_AF_DETDataGridView.Dock = DockStyle.None
            Me.ListaASISTENCIA_AF_DETDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaASISTENCIA_AF_DETDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaASISTENCIA_AF_DETDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
