Imports SGAFP.EL
Public Class ucListaOFERTA_FORMATIVA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaOFERTA_FORMATIVABindingSource
    End Sub

    Private _mComponente As cOFERTA_FORMATIVA
    Public ReadOnly Property mComponente() As cOFERTA_FORMATIVA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cOFERTA_FORMATIVA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaOFERTA_FORMATIVA As New listaOFERTA_FORMATIVA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) 

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

    Private _VerID_OFERTA_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_OFERTA_FORMATIVA() As Boolean
        Get
            Return Me._VerID_OFERTA_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_OFERTA_FORMATIVA = value
            Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerID_EJERCICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me._VerID_EJERCICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_EJERCICIO = value
            Me.DataGridViewTextBoxID_EJERCICIO.Visible = value
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

    Private _VerID_PROVEEDOR_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me._VerID_PROVEEDOR_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROVEEDOR_AF = value
            Me.DataGridViewTextBoxID_PROVEEDOR_AF.Visible = value
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

    Private _VerCOSTO_X_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCOSTO_X_PARTICIPANTE() As Boolean
        Get
            Return Me._VerCOSTO_X_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerCOSTO_X_PARTICIPANTE = value
            Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE.Visible = value
        End Set
    End Property

    Private _VerFECHA_INICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me._VerFECHA_INICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INICIO = value
            Me.DataGridViewTextBoxFECHA_INICIO.Visible = value
        End Set
    End Property

    Private _VerFECHA_FIN As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me._VerFECHA_FIN
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_FIN = value
            Me.DataGridViewTextBoxFECHA_FIN.Visible = value
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

    Private _VerESTADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerESTADO() As Boolean
        Get
            Return Me._VerESTADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerESTADO = value
            Me.DataGridViewTextBoxESTADO.Visible = value
        End Set
    End Property

    Private _VerFECHA_APROBACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_APROBACION() As Boolean
        Get
            Return Me._VerFECHA_APROBACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_APROBACION = value
            Me.DataGridViewTextBoxFECHA_APROBACION.Visible = value
        End Set
    End Property

    Private _VerUSUARIO_APROBACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me._VerUSUARIO_APROBACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSUARIO_APROBACION = value
            Me.DataGridViewTextBoxUSUARIO_APROBACION.Visible = value
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

    Private _VerNOMBRE_PROVEEDOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me._VerNOMBRE_PROVEEDOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_PROVEEDOR = value
            Me.NOMBRE_PROVEEDOR.Visible = value
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
            Me.TEMA_CURSO.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As OFERTA_FORMATIVA
        Get
            Return CType(Me.ListaOFERTA_FORMATIVABindingSource.Current, OFERTA_FORMATIVA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaOFERTA_FORMATIVA = Me.mComponente.ObtenerLista()
        If _mListaOFERTA_FORMATIVA Is Nothing Then Return -1
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = _mListaOFERTA_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla EJERCICIO
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEJERCICIO(ByVal ID_EJERCICIO As String) As Integer
        _mListaOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If _mListaOFERTA_FORMATIVA Is Nothing Then Return -1
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = _mListaOFERTA_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla CURSO_TEMA
    ''' </summary>
    ''' <param name="ID_TEMA_CURSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCURSO_TEMA(ByVal ID_TEMA_CURSO As Decimal) As Integer
        _mListaOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorCURSO_TEMA(ID_TEMA_CURSO)
        If _mListaOFERTA_FORMATIVA Is Nothing Then Return -1
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = _mListaOFERTA_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaOFERTA_FORMATIVA Is Nothing Then Return -1
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = _mListaOFERTA_FORMATIVA
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
        If Not Me.ListaOFERTA_FORMATIVABindingSource.Current Is Nothing Then
            If Me.Current.ID_OFERTA_FORMATIVA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaOFERTA_FORMATIVABindingSource.Current Is Nothing Then
            If mComponente.EliminarOFERTA_FORMATIVA( Me.Current.ID_OFERTA_FORMATIVA) <> 1 Then
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
        If Not Me.ListaOFERTA_FORMATIVABindingSource.Current Is Nothing Then
            Me.ListaOFERTA_FORMATIVABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarOFERTA_FORMATIVA(Me.Current)
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

    Private Sub ListaOFERTA_FORMATIVABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaOFERTA_FORMATIVABindingSource.AddingNew
        Dim lEntidad As New OFERTA_FORMATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaOFERTA_FORMATIVABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaOFERTA_FORMATIVABindingSource.PositionChanged
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
        Me.ListaOFERTA_FORMATIVADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaOFERTA_FORMATIVADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaOFERTA_FORMATIVADataGridView.Dock = DockStyle.None
            Me.ListaOFERTA_FORMATIVADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaOFERTA_FORMATIVADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaOFERTA_FORMATIVADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
