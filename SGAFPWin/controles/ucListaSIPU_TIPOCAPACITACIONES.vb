Imports SGAFP.EL
Public Class ucListaSIPU_TIPOCAPACITACIONES

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSIPU_TIPOCAPACITACIONESBindingSource
    End Sub

    Private _mComponente As cSIPU_TIPOCAPACITACIONES
    Public ReadOnly Property mComponente() As cSIPU_TIPOCAPACITACIONES
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSIPU_TIPOCAPACITACIONES
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSIPU_TIPOCAPACITACIONES As New listaSIPU_TIPOCAPACITACIONES
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal IDTIPOCAPACITACION As Decimal) 

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

    #End Region

    Public ReadOnly Property Current() As SIPU_TIPOCAPACITACIONES
        Get
            Return CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.Current, SIPU_TIPOCAPACITACIONES)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_TIPOCAPACITACIONES
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSIPU_TIPOCAPACITACIONES = Me.mComponente.ObtenerLista()
        If _mListaSIPU_TIPOCAPACITACIONES Is Nothing Then Return -1
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.DataSource = _mListaSIPU_TIPOCAPACITACIONES
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
        If Not Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.Current Is Nothing Then
            If Me.Current.IDTIPOCAPACITACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.Current Is Nothing Then
            If mComponente.EliminarSIPU_TIPOCAPACITACIONES(Me.Current.IDTIPOCAPACITACION) <> 1 Then
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
        If Not Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.Current Is Nothing Then
            Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSIPU_TIPOCAPACITACIONES(Me.Current)
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

    Private Sub ListaSIPU_TIPOCAPACITACIONESBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSIPU_TIPOCAPACITACIONESBindingSource.AddingNew
        Dim lEntidad As New SIPU_TIPOCAPACITACIONES
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSIPU_TIPOCAPACITACIONESBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_TIPOCAPACITACIONESBindingSource.PositionChanged
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
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaSIPU_TIPOCAPACITACIONESGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Dock = DockStyle.None
            Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSIPU_TIPOCAPACITACIONESGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
