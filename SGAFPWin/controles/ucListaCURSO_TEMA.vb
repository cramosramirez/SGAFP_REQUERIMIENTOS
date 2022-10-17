Imports SGAFP.EL
Public Class ucListaCURSO_TEMA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCURSO_TEMABindingSource
    End Sub

    Private mComponente As New cCURSO_TEMA
    Private _mListaCURSO_TEMA As New listaCURSO_TEMA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_TEMA_CURSO As Decimal) 

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

    Private _VerID_TEMA_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TEMA_CURSO() As Boolean
        Get
            Return Me._VerID_TEMA_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TEMA_CURSO = value
            Me.DataGridViewTextBoxID_TEMA_CURSO.Visible = value
        End Set
    End Property

    Private _VerID_AREA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_AREA_FORMACION() As Boolean
        Get
            Return Me._VerID_AREA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_AREA_FORMACION = value
            Me.DataGridViewTextBoxID_AREA_FORMACION.Visible = value
        End Set
    End Property

    Private _VerTEMA_CURSO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTEMA_CURSO() As Boolean
        Get
            Return Me._VerTEMA_CURSO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTEMA_CURSO = value
            Me.DataGridViewTextBoxTEMA_CURSO.Visible = value
        End Set
    End Property

    Private _VerDURACION_HORAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me._VerDURACION_HORAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerDURACION_HORAS = value
            Me.DataGridViewTextBoxDURACION_HORAS.Visible = value
        End Set
    End Property

    Private _VerFECHA_ACREDITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_ACREDITACION() As Boolean
        Get
            Return Me._VerFECHA_ACREDITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_ACREDITACION = value
            Me.DataGridViewTextBoxFECHA_ACREDITACION.Visible = value
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

    Public ReadOnly Property Current() As CURSO_TEMA
        Get
            Return CType(Me.ListaCURSO_TEMABindingSource.Current, CURSO_TEMA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CURSO_TEMA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCURSO_TEMA = Me.mComponente.ObtenerLista()
        If _mListaCURSO_TEMA Is Nothing Then Return -1
        Me.ListaCURSO_TEMABindingSource.DataSource = _mListaCURSO_TEMA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CURSO_TEMA
    ''' filtrado por la tabla AREA_FORMACION
    ''' </summary>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAREA_FORMACION(ByVal ID_AREA_FORMACION As Decimal) As Integer
        _mListaCURSO_TEMA = Me.mComponente.ObtenerListaPorAREA_FORMACION(ID_AREA_FORMACION)
        If _mListaCURSO_TEMA Is Nothing Then Return -1
        Me.ListaCURSO_TEMABindingSource.DataSource = _mListaCURSO_TEMA
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
        If Not Me.ListaCURSO_TEMABindingSource.Current Is Nothing Then
            If Me.Current.ID_TEMA_CURSO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCURSO_TEMABindingSource.Current Is Nothing Then
            If mComponente.EliminarCURSO_TEMA( Me.Current.ID_TEMA_CURSO) <> 1 Then
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
        If Not Me.ListaCURSO_TEMABindingSource.Current Is Nothing Then
            Me.ListaCURSO_TEMABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCURSO_TEMA(Me.Current)
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

    Private Sub ListaCURSO_TEMABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCURSO_TEMABindingSource.AddingNew
        Dim lEntidad As New CURSO_TEMA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCURSO_TEMABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCURSO_TEMABindingSource.PositionChanged
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
        Me.ListaCURSO_TEMADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaCURSO_TEMADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaCURSO_TEMADataGridView.Dock = DockStyle.None
            Me.ListaCURSO_TEMADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCURSO_TEMADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCURSO_TEMADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
