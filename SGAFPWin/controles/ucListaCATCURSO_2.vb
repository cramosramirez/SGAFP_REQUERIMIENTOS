Imports SGAFP.EL
Public Class ucListaCATCURSO_2

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCATCURSO_2BindingSource
    End Sub

    Private mComponente As New cCATCURSO_2
    Private _mListaCATCURSO_2 As New listaCATCURSO_2
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CURSO As Decimal) 

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

    Private _VerID_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CURSO() As Boolean
        Get
            Return Me._VerID_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CURSO = value
            Me.DataGridViewTextBoxID_CURSO.Visible = value
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

    Private _VerDURACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION() As Boolean
        Get
            Return Me._VerDURACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION = value
            Me.DataGridViewTextBoxDURACION.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As CATCURSO_2
        Get
            Return CType(Me.ListaCATCURSO_2BindingSource.Current, CATCURSO_2)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CATCURSO_2
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCATCURSO_2 = Me.mComponente.ObtenerLista()
        If _mListaCATCURSO_2 Is Nothing Then Return -1
        Me.ListaCATCURSO_2BindingSource.DataSource = _mListaCATCURSO_2
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
        If Not Me.ListaCATCURSO_2BindingSource.Current Is Nothing Then
            If Me.Current.ID_CURSO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCATCURSO_2BindingSource.Current Is Nothing Then
            If mComponente.EliminarCATCURSO_2( Me.Current.ID_CURSO) <> 1 Then
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
        If Not Me.ListaCATCURSO_2BindingSource.Current Is Nothing Then
            Me.ListaCATCURSO_2BindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCATCURSO_2(Me.Current)
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

    Private Sub ListaCATCURSO_2BindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCATCURSO_2BindingSource.AddingNew
        Dim lEntidad As New CATCURSO_2
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCATCURSO_2BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCATCURSO_2BindingSource.PositionChanged
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
        Me.ListaCATCURSO_2DataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaCATCURSO_2DataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaCATCURSO_2DataGridView.Dock = DockStyle.None
            Me.ListaCATCURSO_2DataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCATCURSO_2DataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCATCURSO_2DataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
