Imports SGAFP.EL
Public Class ucListaNIVEL_ACADEMICO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaNIVEL_ACADEMICOBindingSource
    End Sub

    Private mComponente As New cNIVEL_ACADEMICO
    Private _mListaNIVEL_ACADEMICO As New listaNIVEL_ACADEMICO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal NIVEL_ACADEMICO As String) 

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

    Private _VerNIVEL_ACADEMICO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIVEL_ACADEMICO() As Boolean
        Get
            Return Me._VerNIVEL_ACADEMICO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIVEL_ACADEMICO = value
            Me.DataGridViewTextBoxNIVEL_ACADEMICO.Visible = value
        End Set
    End Property

    Private _VerDESCRIPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me._VerDESCRIPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDESCRIPCION = value
            Me.DataGridViewTextBoxDESCRIPCION.Visible = value
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

    Public ReadOnly Property Current() As NIVEL_ACADEMICO
        Get
            Return CType(Me.ListaNIVEL_ACADEMICOBindingSource.Current, NIVEL_ACADEMICO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla NIVEL_ACADEMICO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaNIVEL_ACADEMICO = Me.mComponente.ObtenerLista()
        If _mListaNIVEL_ACADEMICO Is Nothing Then Return -1
        Me.ListaNIVEL_ACADEMICOBindingSource.DataSource = _mListaNIVEL_ACADEMICO
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
        If Not Me.ListaNIVEL_ACADEMICOBindingSource.Current Is Nothing Then
            If Me.Current.ID_NIVEL_ACADEMICO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaNIVEL_ACADEMICOBindingSource.Current Is Nothing Then
            If mComponente.EliminarNIVEL_ACADEMICO(Me.Current.ID_NIVEL_ACADEMICO) <> 1 Then
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
        If Not Me.ListaNIVEL_ACADEMICOBindingSource.Current Is Nothing Then
            Me.ListaNIVEL_ACADEMICOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarNIVEL_ACADEMICO(Me.Current)
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

    Private Sub ListaNIVEL_ACADEMICOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaNIVEL_ACADEMICOBindingSource.AddingNew
        Dim lEntidad As New NIVEL_ACADEMICO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaNIVEL_ACADEMICOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaNIVEL_ACADEMICOBindingSource.PositionChanged
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
        Me.ListaNIVEL_ACADEMICODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaNIVEL_ACADEMICODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaNIVEL_ACADEMICODataGridView.Dock = DockStyle.None
            Me.ListaNIVEL_ACADEMICODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaNIVEL_ACADEMICODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaNIVEL_ACADEMICODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
