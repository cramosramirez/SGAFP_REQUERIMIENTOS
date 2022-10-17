Imports SGAFP.EL
Public Class ucListaTERMINO_REFERENCIA_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaTERMINO_REFERENCIA_AFBindingSource
    End Sub

    Private _mComponente As cTERMINO_REFERENCIA_AF
    Public ReadOnly Property mComponente() As cTERMINO_REFERENCIA_AF
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cTERMINO_REFERENCIA_AF
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaTERMINO_REFERENCIA_AF As New listaTERMINO_REFERENCIA_AF
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
            Me.colID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerRESOLUCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRESOLUCION() As Boolean
        Get
            Return Me._VerRESOLUCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerRESOLUCION = value
            Me.colRESOLUCION.Visible = value
        End Set
    End Property

    Private _VerTDR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTDR() As Boolean
        Get
            Return Me._VerTDR
        End Get
        Set(ByVal value As Boolean)
            Me._VerTDR = value
            Me.colTDR.Visible = value
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

    Private _VerCORRELATIVO_GRUPO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCORRELATIVO_GRUPO() As Boolean
        Get
            Return Me._VerCORRELATIVO_GRUPO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCORRELATIVO_GRUPO = value
            Me.colCORRELATIVO_GRUPO.Visible = value
        End Set
    End Property

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.colID_SOLICITUD.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As TERMINO_REFERENCIA_AF
        Get
            Return CType(Me.ListaTERMINO_REFERENCIA_AFBindingSource.Current, TERMINO_REFERENCIA_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TERMINO_REFERENCIA_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaTERMINO_REFERENCIA_AF = Me.mComponente.ObtenerLista()
        If _mListaTERMINO_REFERENCIA_AF Is Nothing Then Return -1
        Me.ListaTERMINO_REFERENCIA_AFBindingSource.DataSource = _mListaTERMINO_REFERENCIA_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TERMINO_REFERENCIA_AF
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaTERMINO_REFERENCIA_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaTERMINO_REFERENCIA_AF Is Nothing Then Return -1
        Me.ListaTERMINO_REFERENCIA_AFBindingSource.DataSource = _mListaTERMINO_REFERENCIA_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla TERMINO_REFERENCIA_AF
    ''' filtrado por la tabla SOLICITUD_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal) As Integer
        _mListaTERMINO_REFERENCIA_AF = Me.mComponente.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD)
        If _mListaTERMINO_REFERENCIA_AF Is Nothing Then Return -1
        Me.ListaTERMINO_REFERENCIA_AFBindingSource.DataSource = _mListaTERMINO_REFERENCIA_AF
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
        If Not Me.ListaTERMINO_REFERENCIA_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_ACCION_FORMATIVA = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaTERMINO_REFERENCIA_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarTERMINO_REFERENCIA_AF(Me.Current.ID_ACCION_FORMATIVA) <> 1 Then
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
        If Not Me.ListaTERMINO_REFERENCIA_AFBindingSource.Current Is Nothing Then
            Me.ListaTERMINO_REFERENCIA_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Dim liRet As Integer
            If Me.Current.ID_ACCION_FORMATIVA = 0 Then
                liRet = mComponente.ActualizarTERMINO_REFERENCIA_AF(Me.Current)
            Else
                liRet = mComponente.AgregarTERMINO_REFERENCIA_AF(Me.Current)
            End If
            Select Case liRet
                Case -1
                    Me.sError = "Suceso desconocido."
                    Return -1
                Case 0
                    Me.sError = "Registro no pudo ser Guardado."
                    Return -2
                Case Else
                    Return 1
            End Select
        End If
        Return 0
    End Function

    Private Sub ListaTERMINO_REFERENCIA_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaTERMINO_REFERENCIA_AFBindingSource.AddingNew
        Dim lEntidad As New TERMINO_REFERENCIA_AF
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaTERMINO_REFERENCIA_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTERMINO_REFERENCIA_AFBindingSource.PositionChanged
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
        Me.ListaTERMINO_REFERENCIA_AFGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaTERMINO_REFERENCIA_AFGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaTERMINO_REFERENCIA_AFGridControl.Dock = DockStyle.None
            Me.ListaTERMINO_REFERENCIA_AFGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaTERMINO_REFERENCIA_AFGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaTERMINO_REFERENCIA_AFGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
