Imports SGAFP.EL
Public Class ucListaSIPU_DETALLECAPACITACIONES

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSIPU_DETALLECAPACITACIONESBindingSource
    End Sub

    Private _mComponente As cSIPU_DETALLECAPACITADO
    Public ReadOnly Property mComponente() As cSIPU_DETALLECAPACITADO
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSIPU_DETALLECAPACITADO
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSIPU_DETALLECAPACITACIONES As New ListaSIPU_DETALLECAPACITADO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal IDDETALLECAPACITACION As Decimal) 

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

    Private _VerIDDETALLECAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDDETALLECAPACITACION() As Boolean
        Get
            Return Me._VerIDDETALLECAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDDETALLECAPACITACION = value
            Me.colIDDETALLECAPACITACION.Visible = value
        End Set
    End Property

    Private _VerID_CAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CAPACITACION() As Boolean
        Get
            Return Me._VerID_CAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CAPACITACION = value
            Me.colID_CAPACITACION.Visible = value
        End Set
    End Property

    Private _VerCONVENIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCONVENIO() As Boolean
        Get
            Return Me._VerCONVENIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCONVENIO = value
            Me.colCONVENIO.Visible = value
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
            Me.colESTADO.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SIPU_DETALLECAPACITADO
        Get
            Return CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.Current, SIPU_DETALLECAPACITADO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_DETALLECAPACITACIONES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSIPU_DETALLECAPACITACIONES = Me.mComponente.ObtenerLista()
        If _mListaSIPU_DETALLECAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.DataSource = _mListaSIPU_DETALLECAPACITACIONES
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_DETALLECAPACITACIONES
    ''' filtrado por la tabla SIPU_CAPACITACIONES
    ''' </summary>
    ''' <param name="IDCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal) As Integer
        _mListaSIPU_DETALLECAPACITACIONES = Me.mComponente.ObtenerListaPorSIPU_CAPACITACIONES(IDCAPACITACION)
        If _mListaSIPU_DETALLECAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.DataSource = _mListaSIPU_DETALLECAPACITACIONES
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
        If Not Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.Current Is Nothing Then
            If Me.Current.IDDETALLECAPACITADO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.Current Is Nothing Then
            If mComponente.EliminarSIPU_DETALLECAPACITADO(Me.Current.IDDETALLECAPACITADO) <> 1 Then
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
        If Not Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.Current Is Nothing Then
            Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSIPU_DETALLECAPACITADO(Me.Current)
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

    Private Sub ListaSIPU_DETALLECAPACITACIONESBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSIPU_DETALLECAPACITACIONESBindingSource.AddingNew
        Dim lEntidad As New SIPU_DETALLECAPACITADO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSIPU_DETALLECAPACITACIONESBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_DETALLECAPACITACIONESBindingSource.PositionChanged
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
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaSIPU_DETALLECAPACITACIONESGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Dock = DockStyle.None
            Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSIPU_DETALLECAPACITACIONESGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
