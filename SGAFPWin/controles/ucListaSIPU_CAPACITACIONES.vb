Imports SGAFP.EL
Public Class ucListaSIPU_CAPACITACIONES

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSIPU_CAPACITACIONESBindingSource
    End Sub

    Private _mComponente As cSIPU_CAPACITACIONES
    Public ReadOnly Property mComponente() As cSIPU_CAPACITACIONES
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSIPU_CAPACITACIONES
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSIPU_CAPACITACIONES As New listaSIPU_CAPACITACIONES
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal IDCAPACITACION As Decimal) 

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

    Private _VerIDCAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDCAPACITACION() As Boolean
        Get
            Return Me._VerIDCAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDCAPACITACION = value
            Me.colIDCAPACITACION.Visible = value
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
            Me.colDESCRIPCION.Visible = value
        End Set
    End Property

    Private _VerIDTIPOCAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDTIPOCAPACITACION() As Boolean
        Get
            Return Me._VerIDTIPOCAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDTIPOCAPACITACION = value
            Me.colIDTIPOCAPACITACION.Visible = value
        End Set
    End Property

    Private _VerIDESTADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDESTADO() As Boolean
        Get
            Return Me._VerIDESTADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDESTADO = value
            Me.colIDESTADO.Visible = value
        End Set
    End Property

    Private _VerFECHAINICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHAINICIO() As Boolean
        Get
            Return Me._VerFECHAINICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHAINICIO = value
            Me.colFECHAINICIO.Visible = value
        End Set
    End Property

    Private _VerFECHAFIN As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHAFIN() As Boolean
        Get
            Return Me._VerFECHAFIN
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHAFIN = value
            Me.colFECHAFIN.Visible = value
        End Set
    End Property

    Private _VerIDMUNICIPIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDMUNICIPIO() As Boolean
        Get
            Return Me._VerIDMUNICIPIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDMUNICIPIO = value
            Me.colIDMUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerID_GENERACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_GENERACION() As Boolean
        Get
            Return Me._VerID_GENERACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_GENERACION = value
            Me.colID_GENERACION.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SIPU_CAPACITACIONES
        Get
            Return CType(Me.ListaSIPU_CAPACITACIONESBindingSource.Current, SIPU_CAPACITACIONES)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_CAPACITACIONES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSIPU_CAPACITACIONES = Me.mComponente.ObtenerLista()
        If _mListaSIPU_CAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = _mListaSIPU_CAPACITACIONES
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_CAPACITACIONES
    ''' filtrado por la tabla SIPU_TIPOCAPACITACIONES
    ''' </summary>
    ''' <param name="IDTIPOCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSIPU_TIPOCAPACITACIONES(ByVal IDTIPOCAPACITACION As Decimal) As Integer
        _mListaSIPU_CAPACITACIONES = Me.mComponente.ObtenerListaPorSIPU_TIPOCAPACITACIONES(IDTIPOCAPACITACION)
        If _mListaSIPU_CAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = _mListaSIPU_CAPACITACIONES
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_CAPACITACIONES
    ''' filtrado por la tabla SIPU_MUNICIPIO
    ''' </summary>
    ''' <param name="IDMUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSIPU_MUNICIPIO(ByVal IDMUNICIPIO As Decimal) As Integer
        _mListaSIPU_CAPACITACIONES = Me.mComponente.ObtenerListaPorSIPU_MUNICIPIO(IDMUNICIPIO)
        If _mListaSIPU_CAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = _mListaSIPU_CAPACITACIONES
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_CAPACITACIONES
    ''' filtrado por la tabla SIPU_GENERACION
    ''' </summary>
    ''' <param name="ID_GENERACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSIPU_GENERACION(ByVal ID_GENERACION As Decimal) As Integer
        _mListaSIPU_CAPACITACIONES = Me.mComponente.ObtenerListaPorSIPU_GENERACION(ID_GENERACION)
        If _mListaSIPU_CAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_CAPACITACIONESBindingSource.DataSource = _mListaSIPU_CAPACITACIONES
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaSIPU_CAPACITACIONESBindingSource.Current Is Nothing Then
            If Me.Current.IDCAPACITACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSIPU_CAPACITACIONESBindingSource.Current Is Nothing Then
            If mComponente.EliminarSIPU_CAPACITACIONES(Me.Current.IDCAPACITACION) <> 1 Then
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaSIPU_CAPACITACIONESBindingSource.Current Is Nothing Then
            Me.ListaSIPU_CAPACITACIONESBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSIPU_CAPACITACIONES(Me.Current)
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

    Private Sub ListaSIPU_CAPACITACIONESBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSIPU_CAPACITACIONESBindingSource.AddingNew
        Dim lEntidad As New SIPU_CAPACITACIONES
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSIPU_CAPACITACIONESBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_CAPACITACIONESBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaSIPU_CAPACITACIONESGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaSIPU_CAPACITACIONESGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaSIPU_CAPACITACIONESGridControl.Dock = DockStyle.None
            Me.ListaSIPU_CAPACITACIONESGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSIPU_CAPACITACIONESGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSIPU_CAPACITACIONESGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
