Imports SGAFP.EL
Public Class ucListaPARTICIPANTE_AF

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPARTICIPANTE_AFBindingSource
    End Sub

    Private mComponente As New cPARTICIPANTE_AF
    Private _mListaPARTICIPANTE_AF As New listaPARTICIPANTE_AF
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) 

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

    Private _ID_ACCION_FORMATIVA As Decimal
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me._ID_ACCION_FORMATIVA
        End Get
        Set(ByVal value As Decimal)
            Me._ID_ACCION_FORMATIVA = value
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

    Private _VerID_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me._VerID_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SOLICITUD = value
            Me.DataGridViewTextBoxID_SOLICITUD.Visible = value
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

    Private _VerFECHA_INSCRIPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INSCRIPCION() As Boolean
        Get
            Return Me._VerFECHA_INSCRIPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INSCRIPCION = value
            Me.DataGridViewTextBoxFECHA_INSCRIPCION.Visible = value
        End Set
    End Property

    Private _VerNOTA_FINAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOTA_FINAL() As Boolean
        Get
            Return Me._VerNOTA_FINAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOTA_FINAL = value
            Me.DataGridViewTextBoxNOTA_FINAL.Visible = value
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

    Private _VerENTREGA_DIPLOMA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerENTREGA_DIPLOMA() As Boolean
        Get
            Return Me._VerENTREGA_DIPLOMA
        End Get
        Set(ByVal value As Boolean)
            Me._VerENTREGA_DIPLOMA = value
            Me.DataGridViewTextBoxENTREGA_DIPLOMA.Visible = value
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

    Public ReadOnly Property Current() As PARTICIPANTE_AF
        Get
            Return CType(Me.ListaPARTICIPANTE_AFBindingSource.Current, PARTICIPANTE_AF)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPARTICIPANTE_AF = Me.mComponente.ObtenerLista(ID_ACCION_FORMATIVA)
        If _mListaPARTICIPANTE_AF Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = _mListaPARTICIPANTE_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_AF
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
        _mListaPARTICIPANTE_AF = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If _mListaPARTICIPANTE_AF Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = _mListaPARTICIPANTE_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_AF
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
        _mListaPARTICIPANTE_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If _mListaPARTICIPANTE_AF Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = _mListaPARTICIPANTE_AF
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_AF
    ''' filtrado por la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        _mListaPARTICIPANTE_AF = Me.mComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If _mListaPARTICIPANTE_AF Is Nothing Then Return -1
        Me.ListaPARTICIPANTE_AFBindingSource.DataSource = _mListaPARTICIPANTE_AF
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
        If Not Me.ListaPARTICIPANTE_AFBindingSource.Current Is Nothing Then
            If Me.Current.ID_PARTICIPANTE = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPARTICIPANTE_AFBindingSource.Current Is Nothing Then
            If mComponente.EliminarPARTICIPANTE_AF(ID_ACCION_FORMATIVA, Me.Current.ID_PARTICIPANTE) <> 1 Then
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
        If Not Me.ListaPARTICIPANTE_AFBindingSource.Current Is Nothing Then
            Me.ListaPARTICIPANTE_AFBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Dim liRet As Integer
            If Me.Current.ID_PARTICIPANTE = 0 Then
                liRet = mComponente.ActualizarPARTICIPANTE_AF(Me.Current)
            Else
                liRet = mComponente.AgregarPARTICIPANTE_AF(Me.Current)
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

    Private Sub ListaPARTICIPANTE_AFBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPARTICIPANTE_AFBindingSource.AddingNew
        Dim lEntidad As New PARTICIPANTE_AF
        lEntidad.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPARTICIPANTE_AFBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTE_AFBindingSource.PositionChanged
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
        Me.ListaPARTICIPANTE_AFDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaPARTICIPANTE_AFDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaPARTICIPANTE_AFDataGridView.Dock = DockStyle.None
            Me.ListaPARTICIPANTE_AFDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPARTICIPANTE_AFDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPARTICIPANTE_AFDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
