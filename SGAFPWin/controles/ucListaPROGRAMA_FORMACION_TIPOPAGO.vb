Imports SGAFP.EL
Public Class ucListaPROGRAMA_FORMACION_TIPOPAGO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource
    End Sub

    Private _mComponente As cPROGRAMA_FORMACION_TIPOPAGO
    Public ReadOnly Property mComponente() As cPROGRAMA_FORMACION_TIPOPAGO
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cPROGRAMA_FORMACION_TIPOPAGO
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaPROGRAMA_FORMACION_TIPOPAGO As New listaPROGRAMA_FORMACION_TIPOPAGO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_TIPO_PAGO As Decimal) 

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

    Private _VerID_TIPO_PAGO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_PAGO() As Boolean
        Get
            Return Me._VerID_TIPO_PAGO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_PAGO = value
            Me.colID_TIPO_PAGO.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_TIPO_PAGO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_TIPO_PAGO() As Boolean
        Get
            Return Me._VerNOMBRE_TIPO_PAGO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_TIPO_PAGO = value
            Me.colNOMBRE_TIPO_PAGO.Visible = value
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

    Public ReadOnly Property Current() As PROGRAMA_FORMACION_TIPOPAGO
        Get
            Return CType(Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.Current, PROGRAMA_FORMACION_TIPOPAGO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PROGRAMA_FORMACION_TIPOPAGO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPROGRAMA_FORMACION_TIPOPAGO = Me.mComponente.ObtenerLista()
        If _mListaPROGRAMA_FORMACION_TIPOPAGO Is Nothing Then Return -1
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.DataSource = _mListaPROGRAMA_FORMACION_TIPOPAGO
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
        If Not Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.Current Is Nothing Then
            If Me.Current.ID_TIPO_PAGO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.Current Is Nothing Then
            If mComponente.EliminarPROGRAMA_FORMACION_TIPOPAGO(Me.Current.ID_TIPO_PAGO) <> 1 Then
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
        If Not Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.Current Is Nothing Then
            Me.ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarPROGRAMA_FORMACION_TIPOPAGO(Me.Current)
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

    Private Sub ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.AddingNew
        Dim lEntidad As New PROGRAMA_FORMACION_TIPOPAGO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROGRAMA_FORMACION_TIPOPAGOBindingSource.PositionChanged
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
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Dock = DockStyle.None
            Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPROGRAMA_FORMACION_TIPOPAGOGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
