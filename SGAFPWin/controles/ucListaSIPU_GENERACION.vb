Imports SGAFP.EL
Public Class ucListaSIPU_GENERACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSIPU_GENERACIONBindingSource
    End Sub

    Private _mComponente As cSIPU_GENERACION
    Public ReadOnly Property mComponente() As cSIPU_GENERACION
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSIPU_GENERACION
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSIPU_GENERACION As New listaSIPU_GENERACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_GENERACION As Decimal) 

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

    Private _VerFECHA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA() As Boolean
        Get
            Return Me._VerFECHA
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA = value
            Me.colFECHA.Visible = value
        End Set
    End Property

    Private _VerFUENTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFUENTE() As Boolean
        Get
            Return Me._VerFUENTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerFUENTE = value
            Me.colFUENTE.Visible = value
        End Set
    End Property

    Private _VerNUMERO_CONVOCATORIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_CONVOCATORIA() As Boolean
        Get
            Return Me._VerNUMERO_CONVOCATORIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_CONVOCATORIA = value
            Me.colNUMERO_CONVOCATORIA.Visible = value
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

    Public ReadOnly Property Current() As SIPU_GENERACION
        Get
            Return CType(Me.ListaSIPU_GENERACIONBindingSource.Current, SIPU_GENERACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_GENERACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSIPU_GENERACION = Me.mComponente.ObtenerLista()
        If _mListaSIPU_GENERACION Is Nothing Then Return -1
        Me.ListaSIPU_GENERACIONBindingSource.DataSource = _mListaSIPU_GENERACION
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
        If Not Me.ListaSIPU_GENERACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_GENERACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSIPU_GENERACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarSIPU_GENERACION(Me.Current.ID_GENERACION) <> 1 Then
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
        If Not Me.ListaSIPU_GENERACIONBindingSource.Current Is Nothing Then
            Me.ListaSIPU_GENERACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSIPU_GENERACION(Me.Current)
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

    Private Sub ListaSIPU_GENERACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSIPU_GENERACIONBindingSource.AddingNew
        Dim lEntidad As New SIPU_GENERACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSIPU_GENERACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_GENERACIONBindingSource.PositionChanged
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
        Me.ListaSIPU_GENERACIONGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaSIPU_GENERACIONGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaSIPU_GENERACIONGridControl.Dock = DockStyle.None
            Me.ListaSIPU_GENERACIONGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSIPU_GENERACIONGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSIPU_GENERACIONGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
