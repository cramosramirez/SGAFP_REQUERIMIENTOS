Imports SGAFP.EL
Public Class ucListaHALLAZGO_SUPERVISION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaHALLAZGO_SUPERVISIONBindingSource
    End Sub

    Private mComponente As New cHALLAZGO_SUPERVISION
    Private _mListaHALLAZGO_SUPERVISION As New listaHALLAZGO_SUPERVISION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) 

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

    Private _VerID_HALLAZGO_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_HALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me._VerID_HALLAZGO_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_HALLAZGO_SUPERVISION = value
            Me.DataGridViewTextBoxID_HALLAZGO_SUPERVISION.Visible = value
        End Set
    End Property

    Private _VerID_AREA_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_AREA_SUPERVISION() As Boolean
        Get
            Return Me._VerID_AREA_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_AREA_SUPERVISION = value
            Me.DataGridViewTextBoxID_AREA_SUPERVISION.Visible = value
        End Set
    End Property

    Private _VerID_SUPERVISION_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me._VerID_SUPERVISION_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SUPERVISION_AF = value
            Me.DataGridViewTextBoxID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Private _VerHALLAZGO_SUPERVISION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerHALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me._VerHALLAZGO_SUPERVISION
        End Get
        Set(ByVal value As Boolean)
            Me._VerHALLAZGO_SUPERVISION = value
            Me.DataGridViewTextBoxHALLAZGO_SUPERVISION.Visible = value
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
            Me.DataGridViewTextBoxFECHA.Visible = value
        End Set
    End Property

    Private _VerTIPO_SANCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_SANCION() As Boolean
        Get
            Return Me._VerTIPO_SANCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_SANCION = value
            Me.DataGridViewTextBoxTIPO_SANCION.Visible = value
        End Set
    End Property

    Private _VerTIEMPO_SANCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIEMPO_SANCION() As Boolean
        Get
            Return Me._VerTIEMPO_SANCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIEMPO_SANCION = value
            Me.DataGridViewTextBoxTIEMPO_SANCION.Visible = value
        End Set
    End Property

    Private _VerMONTO_SANCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_SANCION() As Boolean
        Get
            Return Me._VerMONTO_SANCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_SANCION = value
            Me.DataGridViewTextBoxMONTO_SANCION.Visible = value
        End Set
    End Property

    Private _VerTIEMPO_SUBSANACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIEMPO_SUBSANACION() As Boolean
        Get
            Return Me._VerTIEMPO_SUBSANACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIEMPO_SUBSANACION = value
            Me.DataGridViewTextBoxTIEMPO_SUBSANACION.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As HALLAZGO_SUPERVISION
        Get
            Return CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource.Current, HALLAZGO_SUPERVISION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaHALLAZGO_SUPERVISION = Me.mComponente.ObtenerLista()
        If _mListaHALLAZGO_SUPERVISION Is Nothing Then Return -1
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.DataSource = _mListaHALLAZGO_SUPERVISION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' filtrado por la tabla AREA_SUPERVISION
    ''' </summary>
    ''' <param name="ID_AREA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAREA_SUPERVISION(ByVal ID_AREA_SUPERVISION As Decimal) As Integer
        _mListaHALLAZGO_SUPERVISION = Me.mComponente.ObtenerListaPorAREA_SUPERVISION(ID_AREA_SUPERVISION)
        If _mListaHALLAZGO_SUPERVISION Is Nothing Then Return -1
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.DataSource = _mListaHALLAZGO_SUPERVISION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' filtrado por la tabla SUPERVISION_AF
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal) As Integer
        _mListaHALLAZGO_SUPERVISION = Me.mComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If _mListaHALLAZGO_SUPERVISION Is Nothing Then Return -1
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.DataSource = _mListaHALLAZGO_SUPERVISION
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
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaHALLAZGO_SUPERVISIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_HALLAZGO_SUPERVISION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaHALLAZGO_SUPERVISIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarHALLAZGO_SUPERVISION( Me.Current.ID_HALLAZGO_SUPERVISION) <> 1 Then
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
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer
        If MyBase.Guardar() = 0 Then
            Return 0
        End If
        If Not Me.ListaHALLAZGO_SUPERVISIONBindingSource.Current Is Nothing Then
            Me.ListaHALLAZGO_SUPERVISIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarHALLAZGO_SUPERVISION(Me.Current)
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

    Private Sub ListaHALLAZGO_SUPERVISIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaHALLAZGO_SUPERVISIONBindingSource.AddingNew
        Dim lEntidad As New HALLAZGO_SUPERVISION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaHALLAZGO_SUPERVISIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaHALLAZGO_SUPERVISIONBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.AllowUserToAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaHALLAZGO_SUPERVISIONDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaHALLAZGO_SUPERVISIONDataGridView.Dock = DockStyle.None
            Me.ListaHALLAZGO_SUPERVISIONDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaHALLAZGO_SUPERVISIONDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaHALLAZGO_SUPERVISIONDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
