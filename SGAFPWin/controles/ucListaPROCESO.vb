Imports SGAFP.EL
Public Class ucListaPROCESO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPROCESOBindingSource
    End Sub

    Private mComponente As New cPROCESO
    Private _mListaPROCESO As New listaPROCESO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal CODIGO_PROCESO As String) 

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

    Private _VerCODIGO_PROCESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me._VerCODIGO_PROCESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_PROCESO = value
            Me.DataGridViewTextBoxCODIGO_PROCESO.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_PROCESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_PROCESO() As Boolean
        Get
            Return Me._VerNOMBRE_PROCESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_PROCESO = value
            Me.DataGridViewTextBoxNOMBRE_PROCESO.Visible = value
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

    Private _VerUNIDAD_DE_TIEMPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUNIDAD_DE_TIEMPO() As Boolean
        Get
            Return Me._VerUNIDAD_DE_TIEMPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerUNIDAD_DE_TIEMPO = value
            Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.Visible = value
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

    Public ReadOnly Property Current() As PROCESO
        Get
            Return CType(Me.ListaPROCESOBindingSource.Current, PROCESO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROCESO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPROCESO = Me.mComponente.ObtenerLista()
        If _mListaPROCESO Is Nothing Then Return -1
        Me.ListaPROCESOBindingSource.DataSource = _mListaPROCESO
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
        If Not Me.ListaPROCESOBindingSource.Current Is Nothing Then
            If Me.Current.CODIGO_PROCESO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPROCESOBindingSource.Current Is Nothing Then
            If mComponente.EliminarPROCESO( Me.Current.CODIGO_PROCESO) <> 1 Then
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
        If Not Me.ListaPROCESOBindingSource.Current Is Nothing Then
            Me.ListaPROCESOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarPROCESO(Me.Current)
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

    Private Sub ListaPROCESOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPROCESOBindingSource.AddingNew
        Dim lEntidad As New PROCESO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPROCESOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROCESOBindingSource.PositionChanged
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
        Me.ListaPROCESODataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaPROCESODataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaPROCESODataGridView.Dock = DockStyle.None
            Me.ListaPROCESODataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPROCESODataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPROCESODataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
