Imports SGAFP.EL
Public Class ucListaSITIO_CAPACITACION

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaSITIO_CAPACITACIONBindingSource
    End Sub

    Private mComponente As New cSITIO_CAPACITACION
    Private _mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_SITIO_CAPACITACION As Decimal) 

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

    Private _VerID_SITIO_CAPACITACION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me._VerID_SITIO_CAPACITACION
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_SITIO_CAPACITACION = value
            Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Visible = value
        End Set
    End Property

    Private _VerCODIGO_MUNICIPIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me._VerCODIGO_MUNICIPIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_MUNICIPIO = value
            Me.DataGridViewTextBoxCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerCODIGO_REGION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me._VerCODIGO_REGION
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_REGION = value
            Me.DataGridViewTextBoxCODIGO_REGION.Visible = value
        End Set
    End Property

    Private _VerCODIGO_DEPARTAMENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me._VerCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCODIGO_DEPARTAMENTO = value
            Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Private _VerID_PROVEEDOR_AF As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me._VerID_PROVEEDOR_AF
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PROVEEDOR_AF = value
            Me.DataGridViewTextBoxID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Private _VerNOMBRE_SITIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_SITIO() As Boolean
        Get
            Return Me._VerNOMBRE_SITIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_SITIO = value
            Me.DataGridViewTextBoxNOMBRE_SITIO.Visible = value
        End Set
    End Property

    Private _VerDIRECCION As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDIRECCION() As Boolean
        Get
            Return Me._VerDIRECCION
        End Get
        Set(ByVal value As Boolean)
            Me._VerDIRECCION = value
            Me.DataGridViewTextBoxDIRECCION.Visible = value
        End Set
    End Property

    Private _VerTELEFONO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO() As Boolean
        Get
            Return Me._VerTELEFONO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO = value
            Me.DataGridViewTextBoxTELEFONO.Visible = value
        End Set
    End Property

    Private _VerFAX As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFAX() As Boolean
        Get
            Return Me._VerFAX
        End Get
        Set(ByVal value As Boolean)
            Me._VerFAX = value
            Me.DataGridViewTextBoxFAX.Visible = value
        End Set
    End Property

    Private _VerEMAIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL() As Boolean
        Get
            Return Me._VerEMAIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL = value
            Me.DataGridViewTextBoxEMAIL.Visible = value
        End Set
    End Property

    Private _VerNUMERO_AULAS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUMERO_AULAS() As Boolean
        Get
            Return Me._VerNUMERO_AULAS
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUMERO_AULAS = value
            Me.DataGridViewTextBoxNUMERO_AULAS.Visible = value
        End Set
    End Property

    Private _VerFECHA_REGISTRO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_REGISTRO() As Boolean
        Get
            Return Me._VerFECHA_REGISTRO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_REGISTRO = value
            Me.DataGridViewTextBoxFECHA_REGISTRO.Visible = value
        End Set
    End Property

    Private _VerENCARGADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerENCARGADO() As Boolean
        Get
            Return Me._VerENCARGADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerENCARGADO = value
            Me.DataGridViewTextBoxENCARGADO.Visible = value
        End Set
    End Property

    Private _VerTELEFONO_ENCARGADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTELEFONO_ENCARGADO() As Boolean
        Get
            Return Me._VerTELEFONO_ENCARGADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTELEFONO_ENCARGADO = value
            Me.DataGridViewTextBoxTELEFONO_ENCARGADO.Visible = value
        End Set
    End Property

    Private _VerEMAIL_ENCARGADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerEMAIL_ENCARGADO() As Boolean
        Get
            Return Me._VerEMAIL_ENCARGADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerEMAIL_ENCARGADO = value
            Me.DataGridViewTextBoxEMAIL_ENCARGADO.Visible = value
        End Set
    End Property

    Private _VerCARGO_ENCARGADO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCARGO_ENCARGADO() As Boolean
        Get
            Return Me._VerCARGO_ENCARGADO
        End Get
        Set(ByVal value As Boolean)
            Me._VerCARGO_ENCARGADO = value
            Me.DataGridViewTextBoxCARGO_ENCARGADO.Visible = value
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

    Public ReadOnly Property Current() As SITIO_CAPACITACION
        Get
            Return CType(Me.ListaSITIO_CAPACITACIONBindingSource.Current, SITIO_CAPACITACION)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaSITIO_CAPACITACION = Me.mComponente.ObtenerLista()
        If _mListaSITIO_CAPACITACION Is Nothing Then Return -1
        Me.ListaSITIO_CAPACITACIONBindingSource.DataSource = _mListaSITIO_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaSITIO_CAPACITACION = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If _mListaSITIO_CAPACITACION Is Nothing Then Return -1
        Me.ListaSITIO_CAPACITACIONBindingSource.DataSource = _mListaSITIO_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaSITIO_CAPACITACION = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If _mListaSITIO_CAPACITACION Is Nothing Then Return -1
        Me.ListaSITIO_CAPACITACIONBindingSource.DataSource = _mListaSITIO_CAPACITACION
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        _mListaSITIO_CAPACITACION = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaSITIO_CAPACITACION Is Nothing Then Return -1
        Me.ListaSITIO_CAPACITACIONBindingSource.DataSource = _mListaSITIO_CAPACITACION
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
        If Not Me.ListaSITIO_CAPACITACIONBindingSource.Current Is Nothing Then
            If Me.Current.ID_SITIO_CAPACITACION = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaSITIO_CAPACITACIONBindingSource.Current Is Nothing Then
            If mComponente.EliminarSITIO_CAPACITACION( Me.Current.ID_SITIO_CAPACITACION) <> 1 Then
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
        If Not Me.ListaSITIO_CAPACITACIONBindingSource.Current Is Nothing Then
            Me.ListaSITIO_CAPACITACIONBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarSITIO_CAPACITACION(Me.Current)
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

    Private Sub ListaSITIO_CAPACITACIONBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaSITIO_CAPACITACIONBindingSource.AddingNew
        Dim lEntidad As New SITIO_CAPACITACION
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaSITIO_CAPACITACIONBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSITIO_CAPACITACIONBindingSource.PositionChanged
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
        Me.ListaSITIO_CAPACITACIONDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaSITIO_CAPACITACIONDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaSITIO_CAPACITACIONDataGridView.Dock = DockStyle.None
            Me.ListaSITIO_CAPACITACIONDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaSITIO_CAPACITACIONDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaSITIO_CAPACITACIONDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
