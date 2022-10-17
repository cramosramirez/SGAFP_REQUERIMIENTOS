Imports SGAFP.EL
Public Class ucListaCONTRATO_PROVEEDOR_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCONTRATO_PROVEEDOR_AFBindingSource
    End Sub

    Private _mComponente As cCONTRATO_PROVEEDOR_AF
    Public ReadOnly Property mComponente() As cCONTRATO_PROVEEDOR_AF
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cCONTRATO_PROVEEDOR_AF
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaCONTRATO_PROVEEDOR_AF As New listaCONTRATO_PROVEEDOR_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

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

    Private _VerID_CONTRATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CONTRATO() As Boolean
        Get
            Return Me._VerID_CONTRATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CONTRATO = value
            Me.colID_CONTRATO.Visible = value
        End Set
    End Property

    Private _VerNUM_CONTRATO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_CONTRATO() As Boolean
        Get
            Return Me._VerNUM_CONTRATO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_CONTRATO = value
            Me.colNUM_CONTRATO.Visible = value
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
            Me.colID_PROVEEDOR_AF.Visible = value
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
            Me.colID_EJERCICIO.Visible = value
        End Set
    End Property

    Private _VerMONTO_ADJUDICADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_ADJUDICADO() As Boolean
        Get
            Return Me._VerMONTO_ADJUDICADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_ADJUDICADO = value
            Me.colMONTO_ADJUDICADO.Visible = value
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

    Private _VerNUM_LICITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_LICITACION() As Boolean
        Get
            Return Me._VerNUM_LICITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_LICITACION = value
            Me.colNUM_LICITACION.Visible = value
        End Set
    End Property

    Private _VerMONTO_DEVENGADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_DEVENGADO() As Boolean
        Get
            Return Me._VerMONTO_DEVENGADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_DEVENGADO = value
            Me.colMONTO_DEVENGADO.Visible = value
        End Set
    End Property

    Private _VerID_PROGRAMA_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me._VerID_PROGRAMA_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROGRAMA_FORMACION = value
            Me.colID_PROGRAMA_FORMACION.Visible = value
        End Set
    End Property

    Private _VerPARTICIP_ADJUDICADA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPARTICIP_ADJUDICADA() As Boolean
        Get
            Return Me._VerPARTICIP_ADJUDICADA
        End Get
        Set(ByVal value As Boolean)
            Me._VerPARTICIP_ADJUDICADA = value
            Me.colPARTICIP_ADJUDICADA.Visible = value
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
            Me.colFECHA_INICIO.Visible = value
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
            Me.colFECHA_FIN.Visible = value
        End Set
    End Property

    Private _VerID_PROYECTO_FORMACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROYECTO_FORMACION() As Boolean
        Get
            Return Me._VerID_PROYECTO_FORMACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROYECTO_FORMACION = value
            Me.colID_PROYECTO_FORMACION.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As CONTRATO_PROVEEDOR_AF
        Get
            Return CType(Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.Current, CONTRATO_PROVEEDOR_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_PROVEEDOR_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCONTRATO_PROVEEDOR_AF = Me.mComponente.ObtenerLista()
        If _mListaCONTRATO_PROVEEDOR_AF Is Nothing Then Return -1
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = _mListaCONTRATO_PROVEEDOR_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_PROVEEDOR_AF
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaCONTRATO_PROVEEDOR_AF = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaCONTRATO_PROVEEDOR_AF Is Nothing Then Return -1
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = _mListaCONTRATO_PROVEEDOR_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_PROVEEDOR_AF
    ''' filtrado por la tabla EJERCICIO
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEJERCICIO(ByVal ID_EJERCICIO As String) As Integer
        _mListaCONTRATO_PROVEEDOR_AF = Me.mComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If _mListaCONTRATO_PROVEEDOR_AF Is Nothing Then Return -1
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = _mListaCONTRATO_PROVEEDOR_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_PROVEEDOR_AF
    ''' filtrado por la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As Integer
        _mListaCONTRATO_PROVEEDOR_AF = Me.mComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If _mListaCONTRATO_PROVEEDOR_AF Is Nothing Then Return -1
        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = _mListaCONTRATO_PROVEEDOR_AF
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_CONTRATO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarCONTRATO_PROVEEDOR_AF(Me.Current.ID_CONTRATO) <> 1 Then
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.Current Is Nothing Then
            Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCONTRATO_PROVEEDOR_AF(Me.Current)
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

    Private Sub ListaCONTRATO_PROVEEDOR_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCONTRATO_PROVEEDOR_AFBindingSource.AddingNew
        Dim lEntidad As New CONTRATO_PROVEEDOR_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCONTRATO_PROVEEDOR_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTRATO_PROVEEDOR_AFBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaCONTRATO_PROVEEDOR_AFGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Dock = DockStyle.None
            Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCONTRATO_PROVEEDOR_AFGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
