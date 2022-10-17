Imports SGAFP.EL
Public Class ucListaSIPU_MUNICIPIO

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSIPU_MUNICIPIOBindingSource
    End Sub

    Private _mComponente As cSIPU_MUNICIPIO
    Public ReadOnly Property mComponente() As cSIPU_MUNICIPIO
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cSIPU_MUNICIPIO
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaSIPU_MUNICIPIO As New listaSIPU_MUNICIPIO
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal IDMUNICIPIO As Decimal) 

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

    Private _VerIDDEPARTAMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerIDDEPARTAMENTO() As Boolean
        Get
            Return Me._VerIDDEPARTAMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerIDDEPARTAMENTO = value
            Me.colIDDEPARTAMENTO.Visible = value
        End Set
    End Property

    Private _VerCODMUNICIPIOFIS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODMUNICIPIOFIS() As Boolean
        Get
            Return Me._VerCODMUNICIPIOFIS
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODMUNICIPIOFIS = value
            Me.colCODMUNICIPIOFIS.Visible = value
        End Set
    End Property

    Private _VerCODIGO_DEPTO_INSAFORP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_DEPTO_INSAFORP() As Boolean
        Get
            Return Me._VerCODIGO_DEPTO_INSAFORP
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_DEPTO_INSAFORP = value
            Me.colCODIGO_DEPTO_INSAFORP.Visible = value
        End Set
    End Property

    Private _VerCODIGO_MUNI_INSAFORP As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_MUNI_INSAFORP() As Boolean
        Get
            Return Me._VerCODIGO_MUNI_INSAFORP
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_MUNI_INSAFORP = value
            Me.colCODIGO_MUNI_INSAFORP.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As SIPU_MUNICIPIO
        Get
            Return CType(Me.ListaSIPU_MUNICIPIOBindingSource.Current, SIPU_MUNICIPIO)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SIPU_MUNICIPIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSIPU_MUNICIPIO = Me.mComponente.ObtenerLista()
        If _mListaSIPU_MUNICIPIO Is Nothing Then Return -1
        Me.ListaSIPU_MUNICIPIOBindingSource.DataSource = _mListaSIPU_MUNICIPIO
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
        If Not Me.ListaSIPU_MUNICIPIOBindingSource.Current Is Nothing Then
            If Me.Current.IDMUNICIPIO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSIPU_MUNICIPIOBindingSource.Current Is Nothing Then
            If mComponente.EliminarSIPU_MUNICIPIO(Me.Current.IDMUNICIPIO) <> 1 Then
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
        If Not Me.ListaSIPU_MUNICIPIOBindingSource.Current Is Nothing Then
            Me.ListaSIPU_MUNICIPIOBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSIPU_MUNICIPIO(Me.Current)
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

    Private Sub ListaSIPU_MUNICIPIOBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSIPU_MUNICIPIOBindingSource.AddingNew
        Dim lEntidad As New SIPU_MUNICIPIO
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSIPU_MUNICIPIOBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_MUNICIPIOBindingSource.PositionChanged
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
        Me.ListaSIPU_MUNICIPIOGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
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
        Me.ListaSIPU_MUNICIPIOGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
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
            Me.ListaSIPU_MUNICIPIOGridControl.Dock = DockStyle.None
            Me.ListaSIPU_MUNICIPIOGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSIPU_MUNICIPIOGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSIPU_MUNICIPIOGridControl.Dock = DockStyle.Fill
        End If
    End Sub

End Class
