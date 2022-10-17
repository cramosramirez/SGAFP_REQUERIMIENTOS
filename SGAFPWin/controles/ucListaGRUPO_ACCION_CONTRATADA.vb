Imports SGAFP.EL
Public Class ucListaGRUPO_ACCION_CONTRATADA

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaGRUPO_ACCION_CONTRATADABindingSource
    End Sub

    Private _mComponente As cGRUPO_ACCION_CONTRATADA
    Public ReadOnly Property mComponente() As cGRUPO_ACCION_CONTRATADA
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cGRUPO_ACCION_CONTRATADA
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaGRUPO_ACCION_CONTRATADA As New listaGRUPO_ACCION_CONTRATADA
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_GRUPO_ACCION As Decimal) 

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

    Private _VerID_GRUPO_ACCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_GRUPO_ACCION() As Boolean
        Get
            Return Me._VerID_GRUPO_ACCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_GRUPO_ACCION = value
            Me.colID_GRUPO_ACCION.Visible = value
        End Set
    End Property

    Private _VerID_ACCION_CONTRATADA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ACCION_CONTRATADA() As Boolean
        Get
            Return Me._VerID_ACCION_CONTRATADA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ACCION_CONTRATADA = value
            Me.colID_ACCION_CONTRATADA.Visible = value
        End Set
    End Property

    Private _VerID_GRUPO_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_GRUPO_AF() As Boolean
        Get
            Return Me._VerID_GRUPO_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_GRUPO_AF = value
            Me.colID_GRUPO_AF.Visible = value
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
            Me.colID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerUSUARIO_CREACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me._VerUSUARIO_CREACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSUARIO_CREACION = value
            Me.colUSUARIO_CREACION.Visible = value
        End Set
    End Property

    Private _VerFECHA_CREACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me._VerFECHA_CREACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_CREACION = value
            Me.colFECHA_CREACION.Visible = value
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
            Me.colUSERID.Visible = value
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
            Me.colLASTUPDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As GRUPO_ACCION_CONTRATADA
        Get
            Return CType(Me.ListaGRUPO_ACCION_CONTRATADABindingSource.Current, GRUPO_ACCION_CONTRATADA)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaGRUPO_ACCION_CONTRATADA = Me.mComponente.ObtenerLista()
        If _mListaGRUPO_ACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.DataSource = _mListaGRUPO_ACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_ACCION_CONTRATADA
    ''' filtrado por la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <param name="ID_ACCION_CONTRATADA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal) As Integer
        _mListaGRUPO_ACCION_CONTRATADA = Me.mComponente.ObtenerListaPorACCION_CONTRATADA(ID_ACCION_CONTRATADA)
        If _mListaGRUPO_ACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.DataSource = _mListaGRUPO_ACCION_CONTRATADA
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla GRUPO_ACCION_CONTRATADA
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaGRUPO_ACCION_CONTRATADA = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaGRUPO_ACCION_CONTRATADA Is Nothing Then Return -1
        Me.ListaGRUPO_ACCION_CONTRATADABindingSource.DataSource = _mListaGRUPO_ACCION_CONTRATADA
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaGRUPO_ACCION_CONTRATADABindingSource.Current Is Nothing Then
            If Me.Current.ID_GRUPO_ACCION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaGRUPO_ACCION_CONTRATADABindingSource.Current Is Nothing Then
            If mComponente.EliminarGRUPO_ACCION_CONTRATADA(Me.Current.ID_GRUPO_ACCION) <> 1 Then
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaGRUPO_ACCION_CONTRATADABindingSource.Current Is Nothing Then
            Me.ListaGRUPO_ACCION_CONTRATADABindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarGRUPO_ACCION_CONTRATADA(Me.Current)
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

    Private Sub ListaGRUPO_ACCION_CONTRATADABindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaGRUPO_ACCION_CONTRATADABindingSource.AddingNew
        Dim lEntidad As New GRUPO_ACCION_CONTRATADA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaGRUPO_ACCION_CONTRATADABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaGRUPO_ACCION_CONTRATADABindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaGRUPO_ACCION_CONTRATADAGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Dock = DockStyle.None
            Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaGRUPO_ACCION_CONTRATADAGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
