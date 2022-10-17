Imports SGAFP.EL
Public Class ucListaSOLIC_CURSOS_RECIBIDOS

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource
    End Sub

    Private mComponente As New cSOLIC_CURSOS_RECIBIDOS
    Private _mListaSOLIC_CURSOS_RECIBIDOS As New listaSOLIC_CURSOS_RECIBIDOS
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) 

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

    Private _VerID_CURSO_RECIBIDO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CURSO_RECIBIDO() As Boolean
        Get
            Return Me._VerID_CURSO_RECIBIDO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CURSO_RECIBIDO = value
            Me.DataGridViewTextBoxID_CURSO_RECIBIDO.Visible = value
        End Set
    End Property

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.DataGridViewTextBoxID_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_CURSO() As Boolean
        Get
            Return Me._VerNOMBRE_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_CURSO = value
            Me.DataGridViewTextBoxNOMBRE_CURSO.Visible = value
        End Set
    End Property

    Private _VerINSTITUCION_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerINSTITUCION_CURSO() As Boolean
        Get
            Return Me._VerINSTITUCION_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerINSTITUCION_CURSO = value
            Me.DataGridViewTextBoxINSTITUCION_CURSO.Visible = value
        End Set
    End Property

    Private _VerAPOYO_INSAFORP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAPOYO_INSAFORP() As Boolean
        Get
            Return Me._VerAPOYO_INSAFORP
        End Get
        Set(ByVal value As Boolean)
            Me._VerAPOYO_INSAFORP = value
            Me.DataGridViewTextBoxAPOYO_INSAFORP.Visible = value
        End Set
    End Property

    Private _VerANIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerANIO() As Boolean
        Get
            Return Me._VerANIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerANIO = value
            Me.DataGridViewTextBoxANIO.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SOLIC_CURSOS_RECIBIDOS
        Get
            Return CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.Current, SOLIC_CURSOS_RECIBIDOS)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSOLIC_CURSOS_RECIBIDOS = Me.mComponente.ObtenerLista()
        If _mListaSOLIC_CURSOS_RECIBIDOS Is Nothing Then Return -1
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.DataSource = _mListaSOLIC_CURSOS_RECIBIDOS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
    ''' filtrado por la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        _mListaSOLIC_CURSOS_RECIBIDOS = Me.mComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If _mListaSOLIC_CURSOS_RECIBIDOS Is Nothing Then Return -1
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.DataSource = _mListaSOLIC_CURSOS_RECIBIDOS
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
        If Not Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.Current Is Nothing Then
            If Me.Current.ID_CURSO_RECIBIDO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.Current Is Nothing Then
            If mComponente.EliminarSOLIC_CURSOS_RECIBIDOS( Me.Current.ID_CURSO_RECIBIDO) <> 1 Then
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
        If Not Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.Current Is Nothing Then
            Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSOLIC_CURSOS_RECIBIDOS(Me.Current)
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

    Private Sub ListaSOLIC_CURSOS_RECIBIDOSBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSOLIC_CURSOS_RECIBIDOSBindingSource.AddingNew
        Dim lEntidad As New SOLIC_CURSOS_RECIBIDOS
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSOLIC_CURSOS_RECIBIDOSBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLIC_CURSOS_RECIBIDOSBindingSource.PositionChanged
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
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Dock = DockStyle.None
            Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSOLIC_CURSOS_RECIBIDOSDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
