Imports SGAFP.EL
Public Class ucListaFACILITADOR_CAPACITADOR

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaFACILITADOR_CAPACITADORBindingSource
    End Sub

    Private mComponente As New cFACILITADOR_CAPACITADOR
    Private _mListaFACILITADOR_CAPACITADOR As New listaFACILITADOR_CAPACITADOR
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_FACILITADOR As Decimal) 

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

    Private _VerID_FACILITADOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_FACILITADOR() As Boolean
        Get
            Return Me._VerID_FACILITADOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_FACILITADOR = value
            Me.DataGridViewTextBoxID_FACILITADOR.Visible = value
        End Set
    End Property

    Private _VerID_TIPO_PERSONA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_TIPO_PERSONA() As Boolean
        Get
            Return Me._VerID_TIPO_PERSONA
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_TIPO_PERSONA = value
            Me.DataGridViewTextBoxID_TIPO_PERSONA.Visible = value
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

    Private _VerNOMBRE_FACILITADOR As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRE_FACILITADOR() As Boolean
        Get
            Return Me._VerNOMBRE_FACILITADOR
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRE_FACILITADOR = value
            Me.DataGridViewTextBoxNOMBRE_FACILITADOR.Visible = value
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

    Private _VerDUI As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDUI() As Boolean
        Get
            Return Me._VerDUI
        End Get
        Set(ByVal value As Boolean)
            Me._VerDUI = value
            Me.DataGridViewTextBoxDUI.Visible = value
        End Set
    End Property

    Private _VerISSS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerISSS() As Boolean
        Get
            Return Me._VerISSS
        End Get
        Set(ByVal value As Boolean)
            Me._VerISSS = value
            Me.DataGridViewTextBoxISSS.Visible = value
        End Set
    End Property

    Private _VerFECHA_INGRESO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me._VerFECHA_INGRESO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_INGRESO = value
            Me.DataGridViewTextBoxFECHA_INGRESO.Visible = value
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

    Public ReadOnly Property Current() As FACILITADOR_CAPACITADOR
        Get
            Return CType(Me.ListaFACILITADOR_CAPACITADORBindingSource.Current, FACILITADOR_CAPACITADOR)
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaFACILITADOR_CAPACITADOR = Me.mComponente.ObtenerLista()
        If _mListaFACILITADOR_CAPACITADOR Is Nothing Then Return -1
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = _mListaFACILITADOR_CAPACITADOR
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' filtrado por la tabla TIPO_PERSONA
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal) As Integer
        _mListaFACILITADOR_CAPACITADOR = Me.mComponente.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA)
        If _mListaFACILITADOR_CAPACITADOR Is Nothing Then Return -1
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = _mListaFACILITADOR_CAPACITADOR
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
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
        _mListaFACILITADOR_CAPACITADOR = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If _mListaFACILITADOR_CAPACITADOR Is Nothing Then Return -1
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = _mListaFACILITADOR_CAPACITADOR
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
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
        _mListaFACILITADOR_CAPACITADOR = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
        If _mListaFACILITADOR_CAPACITADOR Is Nothing Then Return -1
        Me.ListaFACILITADOR_CAPACITADORBindingSource.DataSource = _mListaFACILITADOR_CAPACITADOR
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
        If Not Me.ListaFACILITADOR_CAPACITADORBindingSource.Current Is Nothing Then
            If Me.Current.ID_FACILITADOR = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaFACILITADOR_CAPACITADORBindingSource.Current Is Nothing Then
            If mComponente.EliminarFACILITADOR_CAPACITADOR( Me.Current.ID_FACILITADOR) <> 1 Then
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
        If Not Me.ListaFACILITADOR_CAPACITADORBindingSource.Current Is Nothing Then
            Me.ListaFACILITADOR_CAPACITADORBindingSource.EndEdit()
            If Not Me.Current.IsDirty Then Return 0
            Select Case mComponente.ActualizarFACILITADOR_CAPACITADOR(Me.Current)
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

    Private Sub ListaFACILITADOR_CAPACITADORBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaFACILITADOR_CAPACITADORBindingSource.AddingNew
        Dim lEntidad As New FACILITADOR_CAPACITADOR
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaFACILITADOR_CAPACITADORBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaFACILITADOR_CAPACITADORBindingSource.PositionChanged
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
        Me.ListaFACILITADOR_CAPACITADORDataGridView.AllowUserToAddRows = Me.PermitirAgregar
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
        Me.ListaFACILITADOR_CAPACITADORDataGridView.AllowUserToDeleteRows = Me.PermitirEliminar
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
            Me.ListaFACILITADOR_CAPACITADORDataGridView.Dock = DockStyle.None
            Me.ListaFACILITADOR_CAPACITADORDataGridView.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaFACILITADOR_CAPACITADORDataGridView.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaFACILITADOR_CAPACITADORDataGridView.Dock = DockStyle.Fill
        End If
    End Sub

End Class
