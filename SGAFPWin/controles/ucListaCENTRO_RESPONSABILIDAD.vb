Imports SGAFP.EL
Public Class ucListaCENTRO_RESPONSABILIDAD

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCENTRO_RESPONSABILIDADBindingSource
    End Sub

    Private _mComponente As cCENTRO_RESPONSABILIDAD
    Public ReadOnly Property mComponente() As cCENTRO_RESPONSABILIDAD
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cCENTRO_RESPONSABILIDAD
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaCENTRO_RESPONSABILIDAD As New listaCENTRO_RESPONSABILIDAD
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) 

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

    Private _VerID_CENTRO_RESPONSABILIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CENTRO_RESPONSABILIDAD() As Boolean
        Get
            Return Me._VerID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CENTRO_RESPONSABILIDAD = value
            Me.colID_CENTRO_RESPONSABILIDAD.Visible = value
        End Set
    End Property

    Private _VerID_CENTRO_RESPONSABILIDAD_PADR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_CENTRO_RESPONSABILIDAD_PADR() As Boolean
        Get
            Return Me._VerID_CENTRO_RESPONSABILIDAD_PADR
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_CENTRO_RESPONSABILIDAD_PADR = value
            Me.colID_CENTRO_RESPONSABILIDAD_PADR.Visible = value
        End Set
    End Property

    Private _VerCODIGO_CENTRO_RESPONSABILIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_CENTRO_RESPONSABILIDAD() As Boolean
        Get
            Return Me._VerCODIGO_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_CENTRO_RESPONSABILIDAD = value
            Me.colCODIGO_CENTRO_RESPONSABILIDAD.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_CENTRO_RESPONSABILIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_CENTRO_RESPONSABILIDAD() As Boolean
        Get
            Return Me._VerNOMBRE_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_CENTRO_RESPONSABILIDAD = value
            Me.colNOMBRE_CENTRO_RESPONSABILIDAD.Visible = value
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

    Public ReadOnly Property Current() As CENTRO_RESPONSABILIDAD
        Get
            Return CType(Me.ListaCENTRO_RESPONSABILIDADBindingSource.Current, CENTRO_RESPONSABILIDAD)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CENTRO_RESPONSABILIDAD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCENTRO_RESPONSABILIDAD = Me.mComponente.ObtenerLista()
        If _mListaCENTRO_RESPONSABILIDAD Is Nothing Then Return -1
        Me.ListaCENTRO_RESPONSABILIDADBindingSource.DataSource = _mListaCENTRO_RESPONSABILIDAD
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
        If Not Me.ListaCENTRO_RESPONSABILIDADBindingSource.Current Is Nothing Then
            If Me.Current.ID_CENTRO_RESPONSABILIDAD = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCENTRO_RESPONSABILIDADBindingSource.Current Is Nothing Then
            If mComponente.EliminarCENTRO_RESPONSABILIDAD(Me.Current.ID_CENTRO_RESPONSABILIDAD) <> 1 Then
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
        If Not Me.ListaCENTRO_RESPONSABILIDADBindingSource.Current Is Nothing Then
            Me.ListaCENTRO_RESPONSABILIDADBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCENTRO_RESPONSABILIDAD(Me.Current)
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

    Private Sub ListaCENTRO_RESPONSABILIDADBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCENTRO_RESPONSABILIDADBindingSource.AddingNew
        Dim lEntidad As New CENTRO_RESPONSABILIDAD
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCENTRO_RESPONSABILIDADBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCENTRO_RESPONSABILIDADBindingSource.PositionChanged
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
        Me.ListaCENTRO_RESPONSABILIDADGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaCENTRO_RESPONSABILIDADGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaCENTRO_RESPONSABILIDADGridControl.Dock = DockStyle.None
            Me.ListaCENTRO_RESPONSABILIDADGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCENTRO_RESPONSABILIDADGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCENTRO_RESPONSABILIDADGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
