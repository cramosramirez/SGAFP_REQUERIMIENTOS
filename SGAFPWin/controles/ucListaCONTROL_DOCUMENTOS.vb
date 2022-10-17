Imports SGAFP.EL
Public Class ucListaCONTROL_DOCUMENTOS

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaCONTROL_DOCUMENTOSBindingSource
    End Sub

    Private mComponente As New cCONTROL_DOCUMENTOS
    Private _mListaCONTROL_DOCUMENTOS As New listaCONTROL_DOCUMENTOS
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal NUMERO_DOCUMENTO As Decimal) 

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

    Private _VerNUMERO_DOCUMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_DOCUMENTO() As Boolean
        Get
            Return Me._VerNUMERO_DOCUMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_DOCUMENTO = value
            Me.DataGridViewTextBoxNUMERO_DOCUMENTO.Visible = value
        End Set
    End Property

    Private _VerNUMERO_PATRONAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_PATRONAL() As Boolean
        Get
            Return Me._VerNUMERO_PATRONAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_PATRONAL = value
            Me.DataGridViewTextBoxNUMERO_PATRONAL.Visible = value
        End Set
    End Property

    Private _VerNUMERO_FOLIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_FOLIO() As Boolean
        Get
            Return Me._VerNUMERO_FOLIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_FOLIO = value
            Me.DataGridViewTextBoxNUMERO_FOLIO.Visible = value
        End Set
    End Property

    Private _VerID_TIPO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_TIPO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_SOLICITUD = value
            Me.DataGridViewTextBoxID_TIPO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerCODIGO_ETAPA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_ETAPA() As Boolean
        Get
            Return Me._VerCODIGO_ETAPA
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_ETAPA = value
            Me.DataGridViewTextBoxCODIGO_ETAPA.Visible = value
        End Set
    End Property

    Private _VerCODIGO_PROCESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me._VerCODIGO_PROCESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_PROCESO = value
            Me.DataGridViewTextBoxCODIGO_PROCESO.Visible = value
        End Set
    End Property

    Private _VerID_ESTADO_SOLICITUD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me._VerID_ESTADO_SOLICITUD
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ESTADO_SOLICITUD = value
            Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Private _VerNIT As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNIT() As Boolean
        Get
            Return Me._VerNIT
        End Get
        Set(ByVal value As Boolean)
            Me._VerNIT = value
            Me.DataGridViewTextBoxNIT.Visible = value
        End Set
    End Property

    Private _VerPRESENTADO_POR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPRESENTADO_POR() As Boolean
        Get
            Return Me._VerPRESENTADO_POR
        End Get
        Set(ByVal value As Boolean)
            Me._VerPRESENTADO_POR = value
            Me.DataGridViewTextBoxPRESENTADO_POR.Visible = value
        End Set
    End Property

    Private _VerFECHA_RECEPCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_RECEPCION() As Boolean
        Get
            Return Me._VerFECHA_RECEPCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_RECEPCION = value
            Me.DataGridViewTextBoxFECHA_RECEPCION.Visible = value
        End Set
    End Property

    Private _VerRESPONSABLE_ACTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRESPONSABLE_ACTUAL() As Boolean
        Get
            Return Me._VerRESPONSABLE_ACTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerRESPONSABLE_ACTUAL = value
            Me.DataGridViewTextBoxRESPONSABLE_ACTUAL.Visible = value
        End Set
    End Property

    Private _VerRESPONSABLE_ANTERIOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerRESPONSABLE_ANTERIOR() As Boolean
        Get
            Return Me._VerRESPONSABLE_ANTERIOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerRESPONSABLE_ANTERIOR = value
            Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR.Visible = value
        End Set
    End Property

    Private _VerPRIORIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPRIORIDAD() As Boolean
        Get
            Return Me._VerPRIORIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerPRIORIDAD = value
            Me.DataGridViewTextBoxPRIORIDAD.Visible = value
        End Set
    End Property

    Private _VerNO_DOCUMENTO_ORIGEN As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNO_DOCUMENTO_ORIGEN() As Boolean
        Get
            Return Me._VerNO_DOCUMENTO_ORIGEN
        End Get
        Set(ByVal value As Boolean)
            Me._VerNO_DOCUMENTO_ORIGEN = value
            Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN.Visible = value
        End Set
    End Property

    Private _VerNO_DOCUMENTO_PADRE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNO_DOCUMENTO_PADRE() As Boolean
        Get
            Return Me._VerNO_DOCUMENTO_PADRE
        End Get
        Set(ByVal value As Boolean)
            Me._VerNO_DOCUMENTO_PADRE = value
            Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE.Visible = value
        End Set
    End Property

    Private _VerFECHA_REQUERIDA_FIN As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_REQUERIDA_FIN() As Boolean
        Get
            Return Me._VerFECHA_REQUERIDA_FIN
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_REQUERIDA_FIN = value
            Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN.Visible = value
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

    Private _VerUSERID As Boolean = True
    <DefaultValue(True)> _
    Public Property VerUSERID() As Boolean
        Get
            Return Me._VerUSERID
        End Get
        Set(ByVal value As Boolean)
            Me._VerUSERID = value
            Me.DataGridViewTextBoxUSERID.Visible = value
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
            Me.DataGridViewTextBoxLASTUPDATE.Visible = value
        End Set
    End Property

    #End Region

    Public ReadOnly Property Current() As CONTROL_DOCUMENTOS
        Get
            Return CType(Me.ListaCONTROL_DOCUMENTOSBindingSource.Current, CONTROL_DOCUMENTOS)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaCONTROL_DOCUMENTOS = Me.mComponente.ObtenerLista()
        If _mListaCONTROL_DOCUMENTOS Is Nothing Then Return -1
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = _mListaCONTROL_DOCUMENTOS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' filtrado por la tabla TIPO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal) As Integer
        _mListaCONTROL_DOCUMENTOS = Me.mComponente.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD)
        If _mListaCONTROL_DOCUMENTOS Is Nothing Then Return -1
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = _mListaCONTROL_DOCUMENTOS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' filtrado por la tabla ETAPA
    ''' </summary>
    ''' <param name="CODIGO_ETAPA"></param>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorETAPA(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) As Integer
        _mListaCONTROL_DOCUMENTOS = Me.mComponente.ObtenerListaPorETAPA(CODIGO_ETAPA, CODIGO_PROCESO)
        If _mListaCONTROL_DOCUMENTOS Is Nothing Then Return -1
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = _mListaCONTROL_DOCUMENTOS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' filtrado por la tabla PROCESO
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROCESO(ByVal CODIGO_PROCESO As String) As Integer
        _mListaCONTROL_DOCUMENTOS = Me.mComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If _mListaCONTROL_DOCUMENTOS Is Nothing Then Return -1
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = _mListaCONTROL_DOCUMENTOS
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTROL_DOCUMENTOS
    ''' filtrado por la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal) As Integer
        _mListaCONTROL_DOCUMENTOS = Me.mComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If _mListaCONTROL_DOCUMENTOS Is Nothing Then Return -1
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = _mListaCONTROL_DOCUMENTOS
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
        If Not Me.ListaCONTROL_DOCUMENTOSBindingSource.Current Is Nothing Then
            If Me.Current.NUMERO_DOCUMENTO = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaCONTROL_DOCUMENTOSBindingSource.Current Is Nothing Then
            If mComponente.EliminarCONTROL_DOCUMENTOS( Me.Current.NUMERO_DOCUMENTO) <> 1 Then
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
        If Not Me.ListaCONTROL_DOCUMENTOSBindingSource.Current Is Nothing Then
            Me.ListaCONTROL_DOCUMENTOSBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarCONTROL_DOCUMENTOS(Me.Current)
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

    Private Sub ListaCONTROL_DOCUMENTOSBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaCONTROL_DOCUMENTOSBindingSource.AddingNew
        Dim lEntidad As New CONTROL_DOCUMENTOS
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaCONTROL_DOCUMENTOSBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTROL_DOCUMENTOSBindingSource.PositionChanged
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
        Me.ListaCONTROL_DOCUMENTOSDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaCONTROL_DOCUMENTOSDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaCONTROL_DOCUMENTOSDataGridView.Dock = DockStyle.None
            Me.ListaCONTROL_DOCUMENTOSDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaCONTROL_DOCUMENTOSDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaCONTROL_DOCUMENTOSDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
