Imports SGAFP.EL
Public Class ucListaACCION_FORMATIVA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaACCION_FORMATIVABindingSource
        If Not Me.DesignMode Then
            'mComponente = New cACCION_FORMATIVA
        End If

    End Sub

    Public ReadOnly Property mComponente() As cACCION_FORMATIVA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cACCION_FORMATIVA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mComponente As cACCION_FORMATIVA
    Private _mListaACCION_FORMATIVA As New listaACCION_FORMATIVA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

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

    Private _VerID_ACCION_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me._VerID_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_FORMATIVA = value
            Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Visible = value
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

    Private _VerID_SITIO_CAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me._VerID_SITIO_CAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SITIO_CAPACITACION = value
            Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Visible = value
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

    Private _VerNOMBRE_ACCION_FORMATIVA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_ACCION_FORMATIVA() As Boolean
        Get
            Return Me._VerNOMBRE_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_ACCION_FORMATIVA = value
            Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerCODIGO_GRUPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_GRUPO() As Boolean
        Get
            Return Me._VerCODIGO_GRUPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_GRUPO = value
            Me.DataGridViewTextBoxCODIGO_GRUPO.Visible = value
        End Set
    End Property

    Private _VerNUMERO_PARTICIPANTES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_PARTICIPANTES() As Boolean
        Get
            Return Me._VerNUMERO_PARTICIPANTES
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_PARTICIPANTES = value
            Me.DataGridViewTextBoxNUMERO_PARTICIPANTES.Visible = value
        End Set
    End Property

    Private _VerPARTICIPANTES_INSCRITOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me._VerPARTICIPANTES_INSCRITOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIPANTES_INSCRITOS = value
            Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Visible = value
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

    Private _VerHORARIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerHORARIO() As Boolean
        Get
            Return Me._VerHORARIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerHORARIO = value
            Me.DataGridViewTextBoxHORARIO.Visible = value
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

    Public ReadOnly Property Current() As ACCION_FORMATIVA
        Get
            Return CType(Me.ListaACCION_FORMATIVABindingSource.Current, ACCION_FORMATIVA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerLista()
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal) As Integer
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
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
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
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
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorCURSO_TEMA(ID_TEMA_CURSO)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
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
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla ESTADO_ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_ACCION_FORMATIVA(ByVal CODIGO_ESTADO_AF As String) As Integer
        _mListaACCION_FORMATIVA = Me.mComponente.ObtenerListaPorESTADO_ACCION_FORMATIVA(CODIGO_ESTADO_AF)
        If _mListaACCION_FORMATIVA Is Nothing Then Return -1
        Me.ListaACCION_FORMATIVABindingSource.DataSource = _mListaACCION_FORMATIVA
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
        If Not Me.ListaACCION_FORMATIVABindingSource.Current Is Nothing Then
            If Me.Current.ID_ACCION_FORMATIVA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaACCION_FORMATIVABindingSource.Current Is Nothing Then
            If mComponente.EliminarACCION_FORMATIVA( Me.Current.ID_ACCION_FORMATIVA) <> 1 Then
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
        If Not Me.ListaACCION_FORMATIVABindingSource.Current Is Nothing Then
            Me.ListaACCION_FORMATIVABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarACCION_FORMATIVA(Me.Current)
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

    Private Sub ListaACCION_FORMATIVABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaACCION_FORMATIVABindingSource.AddingNew
        Dim lEntidad As New ACCION_FORMATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaACCION_FORMATIVABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaACCION_FORMATIVABindingSource.PositionChanged
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
        Me.ListaACCION_FORMATIVADataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaACCION_FORMATIVADataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaACCION_FORMATIVADataGridView.Dock = DockStyle.None
            Me.ListaACCION_FORMATIVADataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaACCION_FORMATIVADataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaACCION_FORMATIVADataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
