Imports SGAFP.EL
Public Class ucListaESTADO_ACCION_FORMATIVA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaESTADO_ACCION_FORMATIVABindingSource
    End Sub

    Private mComponente As New cESTADO_ACCION_FORMATIVA
    Private _mListaESTADO_ACCION_FORMATIVA As New listaESTADO_ACCION_FORMATIVA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal CODIGO_ESTADO_AF As String) 

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

    Private _VerCODIGO_ESTADO_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_ESTADO_AF() As Boolean
        Get
            Return Me._VerCODIGO_ESTADO_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_ESTADO_AF = value
            Me.DataGridViewTextBoxCODIGO_ESTADO_AF.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_ESTADO_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_ESTADO_AF() As Boolean
        Get
            Return Me._VerNOMBRE_ESTADO_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_ESTADO_AF = value
            Me.DataGridViewTextBoxNOMBRE_ESTADO_AF.Visible = value
        End Set
    End Property

    Private _VerESTADO_INICIAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO_INICIAL() As Boolean
        Get
            Return Me._VerESTADO_INICIAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO_INICIAL = value
            Me.DataGridViewTextBoxESTADO_INICIAL.Visible = value
        End Set
    End Property

    Private _VerPERMITE_INSCRIPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPERMITE_INSCRIPCION() As Boolean
        Get
            Return Me._VerPERMITE_INSCRIPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerPERMITE_INSCRIPCION = value
            Me.DataGridViewTextBoxPERMITE_INSCRIPCION.Visible = value
        End Set
    End Property

    Private _VerESTADO_FINAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO_FINAL() As Boolean
        Get
            Return Me._VerESTADO_FINAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO_FINAL = value
            Me.DataGridViewTextBoxESTADO_FINAL.Visible = value
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

    Public ReadOnly Property Current() As ESTADO_ACCION_FORMATIVA
        Get
            Return CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource.Current, ESTADO_ACCION_FORMATIVA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ESTADO_ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaESTADO_ACCION_FORMATIVA = Me.mComponente.ObtenerLista()
        If _mListaESTADO_ACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaESTADO_ACCION_FORMATIVABindingSource.DataSource = _mListaESTADO_ACCION_FORMATIVA
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
        If Not Me.ListaESTADO_ACCION_FORMATIVABindingSource.Current Is Nothing Then
            If Me.Current.CODIGO_ESTADO_AF = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaESTADO_ACCION_FORMATIVABindingSource.Current Is Nothing Then
            If mComponente.EliminarESTADO_ACCION_FORMATIVA( Me.Current.CODIGO_ESTADO_AF) <> 1 Then
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
        If Not Me.ListaESTADO_ACCION_FORMATIVABindingSource.Current Is Nothing Then
            Me.ListaESTADO_ACCION_FORMATIVABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarESTADO_ACCION_FORMATIVA(Me.Current)
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

    Private Sub ListaESTADO_ACCION_FORMATIVABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaESTADO_ACCION_FORMATIVABindingSource.AddingNew
        Dim lEntidad As New ESTADO_ACCION_FORMATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaESTADO_ACCION_FORMATIVABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaESTADO_ACCION_FORMATIVABindingSource.PositionChanged
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
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaESTADO_ACCION_FORMATIVADataGridView.Dock = DockStyle.None
            Me.ListaESTADO_ACCION_FORMATIVADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaESTADO_ACCION_FORMATIVADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaESTADO_ACCION_FORMATIVADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
