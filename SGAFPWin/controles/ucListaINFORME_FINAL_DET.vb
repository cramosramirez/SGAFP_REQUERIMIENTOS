Imports SGAFP.EL
Public Class ucListaINFORME_FINAL_DET

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaINFORME_FINAL_DETBindingSource
    End Sub

    Private mComponente As New cINFORME_FINAL_DET
    Private _mListaINFORME_FINAL_DET As New listaINFORME_FINAL_DET
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) 

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

    Private _VerID_INFORME_FINAL_DET As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_INFORME_FINAL_DET() As Boolean
        Get
            Return Me._VerID_INFORME_FINAL_DET
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_INFORME_FINAL_DET = value
            Me.DataGridViewTextBoxID_INFORME_FINAL_DET.Visible = value
        End Set
    End Property

    Private _VerID_INFORME_FINAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me._VerID_INFORME_FINAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_INFORME_FINAL = value
            Me.DataGridViewTextBoxID_INFORME_FINAL.Visible = value
        End Set
    End Property

    Private _VerID_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me._VerID_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PARTICIPANTE = value
            Me.DataGridViewTextBoxID_PARTICIPANTE.Visible = value
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
            Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Private _VerNOTA_OBTENIDA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me._VerNOTA_OBTENIDA
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTA_OBTENIDA = value
            Me.DataGridViewTextBoxNOTA_OBTENIDA.Visible = value
        End Set
    End Property

    Private _VerPORC_ASISTENCIA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPORC_ASISTENCIA() As Boolean
        Get
            Return Me._VerPORC_ASISTENCIA
        End Get
        Set(ByVal value As Boolean)
            Me._VerPORC_ASISTENCIA = value
            Me.DataGridViewTextBoxPORC_ASISTENCIA.Visible = value
        End Set
    End Property

    Private _VerMONTO_SOLICITADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_SOLICITADO() As Boolean
        Get
            Return Me._VerMONTO_SOLICITADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_SOLICITADO = value
            Me.DataGridViewTextBoxMONTO_SOLICITADO.Visible = value
        End Set
    End Property

    Private _VerMONTO_APROBADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me._VerMONTO_APROBADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerMONTO_APROBADO = value
            Me.DataGridViewTextBoxMONTO_APROBADO.Visible = value
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
            Me.DataGridViewTextBoxESTADO.Visible = value
        End Set
    End Property

    Private _VerNOTAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTAS() As Boolean
        Get
            Return Me._VerNOTAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTAS = value
            Me.DataGridViewTextBoxNOTAS.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As INFORME_FINAL_DET
        Get
            Return CType(Me.ListaINFORME_FINAL_DETBindingSource.Current, INFORME_FINAL_DET)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaINFORME_FINAL_DET = Me.mComponente.ObtenerLista()
        If _mListaINFORME_FINAL_DET Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_DETBindingSource.DataSource = _mListaINFORME_FINAL_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal) As Integer
        _mListaINFORME_FINAL_DET = Me.mComponente.ObtenerListaPorINFORME_FINAL_AF(ID_INFORME_FINAL)
        If _mListaINFORME_FINAL_DET Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_DETBindingSource.DataSource = _mListaINFORME_FINAL_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        _mListaINFORME_FINAL_DET = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaINFORME_FINAL_DET Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_DETBindingSource.DataSource = _mListaINFORME_FINAL_DET
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        _mListaINFORME_FINAL_DET = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaINFORME_FINAL_DET Is Nothing Then Return -1
        Me.ListaINFORME_FINAL_DETBindingSource.DataSource = _mListaINFORME_FINAL_DET
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
        If Not Me.ListaINFORME_FINAL_DETBindingSource.Current Is Nothing Then
            If Me.Current.ID_INFORME_FINAL_DET = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaINFORME_FINAL_DETBindingSource.Current Is Nothing Then
            If mComponente.EliminarINFORME_FINAL_DET( Me.Current.ID_INFORME_FINAL_DET) <> 1 Then
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
        If Not Me.ListaINFORME_FINAL_DETBindingSource.Current Is Nothing Then
            Me.ListaINFORME_FINAL_DETBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarINFORME_FINAL_DET(Me.Current)
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

    Private Sub ListaINFORME_FINAL_DETBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaINFORME_FINAL_DETBindingSource.AddingNew
        Dim lEntidad As New INFORME_FINAL_DET
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaINFORME_FINAL_DETBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaINFORME_FINAL_DETBindingSource.PositionChanged
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
        Me.ListaINFORME_FINAL_DETDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaINFORME_FINAL_DETDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaINFORME_FINAL_DETDataGridView.Dock = DockStyle.None
            Me.ListaINFORME_FINAL_DETDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaINFORME_FINAL_DETDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaINFORME_FINAL_DETDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
