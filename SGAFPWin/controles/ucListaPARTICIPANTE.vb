Imports SGAFP.EL
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class ucListaPARTICIPANTE

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ListaBindingNavigator.BindingSource = Me.ListaPARTICIPANTEBindingSource
    End Sub

    Private _mComponente As cPARTICIPANTE
    Public ReadOnly Property mComponente() As cPARTICIPANTE
        Get
            If _mComponente Is Nothing Then
                _mComponente = New cPARTICIPANTE
            End If
            Return _mComponente
        End Get
    End Property

    Private _mListaPARTICIPANTE As New listaPARTICIPANTE
    Public Event CambioRegistro()
    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 

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

    Private _VerID_PARTICIPANTE As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me._VerID_PARTICIPANTE
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PARTICIPANTE = value
            Me.colID_PARTICIPANTE.Visible = value
        End Set
    End Property

    Private _VerNOMBRES As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNOMBRES() As Boolean
        Get
            Return Me._VerNOMBRES
        End Get
        Set(ByVal value As Boolean)
            Me._VerNOMBRES = value
            Me.colNOMBRES.Visible = value
        End Set
    End Property

    Private _VerAPELLIDOS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me._VerAPELLIDOS
        End Get
        Set(ByVal value As Boolean)
            Me._VerAPELLIDOS = value
            Me.colAPELLIDOS.Visible = value
        End Set
    End Property

    Private _VerGENERO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerGENERO() As Boolean
        Get
            Return Me._VerGENERO
        End Get
        Set(ByVal value As Boolean)
            Me._VerGENERO = value
            Me.colGENERO.Visible = value
        End Set
    End Property

    Private _VerID_PAIS As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_PAIS() As Boolean
        Get
            Return Me._VerID_PAIS
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_PAIS = value
            Me.colID_PAIS.Visible = value
        End Set
    End Property

    Private _VerFECHA_NACIMIENTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me._VerFECHA_NACIMIENTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerFECHA_NACIMIENTO = value
            Me.colFECHA_NACIMIENTO.Visible = value
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
            Me.colDIRECCION.Visible = value
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
            Me.colDUI.Visible = value
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
            Me.colNIT.Visible = value
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
            Me.colISSS.Visible = value
        End Set
    End Property

    Private _VerTIPO_DOCTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTIPO_DOCTO() As Boolean
        Get
            Return Me._VerTIPO_DOCTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTIPO_DOCTO = value
            Me.colTIPO_DOCTO.Visible = value
        End Set
    End Property

    Private _VerNUM_DOCTO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerNUM_DOCTO() As Boolean
        Get
            Return Me._VerNUM_DOCTO
        End Get
        Set(ByVal value As Boolean)
            Me._VerNUM_DOCTO = value
            Me.colNUM_DOCTO.Visible = value
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
            Me.colTELEFONO.Visible = value
        End Set
    End Property

    Private _VerMOVIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMOVIL() As Boolean
        Get
            Return Me._VerMOVIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerMOVIL = value
            Me.colMOVIL.Visible = value
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
            Me.colEMAIL.Visible = value
        End Set
    End Property

    Private _VerID_ESTADO_CIVIL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_ESTADO_CIVIL() As Boolean
        Get
            Return Me._VerID_ESTADO_CIVIL
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_ESTADO_CIVIL = value
            Me.colID_ESTADO_CIVIL.Visible = value
        End Set
    End Property

    Private _VerPROFESION_OFICIO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerPROFESION_OFICIO() As Boolean
        Get
            Return Me._VerPROFESION_OFICIO
        End Get
        Set(ByVal value As Boolean)
            Me._VerPROFESION_OFICIO = value
            Me.colPROFESION_OFICIO.Visible = value
        End Set
    End Property

    Private _VerOCUPACION_ACTUAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOCUPACION_ACTUAL() As Boolean
        Get
            Return Me._VerOCUPACION_ACTUAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerOCUPACION_ACTUAL = value
            Me.colOCUPACION_ACTUAL.Visible = value
        End Set
    End Property

    Private _VerTITULO_CERTIFICADO_OBTENIDO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me._VerTITULO_CERTIFICADO_OBTENIDO
        End Get
        Set(ByVal value As Boolean)
            Me._VerTITULO_CERTIFICADO_OBTENIDO = value
            Me.colTITULO_CERTIFICADO_OBTENIDO.Visible = value
        End Set
    End Property

    Private _VerDEPARTAMENTO_NAC As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDEPARTAMENTO_NAC() As Boolean
        Get
            Return Me._VerDEPARTAMENTO_NAC
        End Get
        Set(ByVal value As Boolean)
            Me._VerDEPARTAMENTO_NAC = value
            Me.colDEPARTAMENTO_NAC.Visible = value
        End Set
    End Property

    Private _VerMUNICIPIO_NAC As Boolean = True
    <DefaultValue(True)> _
    Public Property VerMUNICIPIO_NAC() As Boolean
        Get
            Return Me._VerMUNICIPIO_NAC
        End Get
        Set(ByVal value As Boolean)
            Me._VerMUNICIPIO_NAC = value
            Me.colMUNICIPIO_NAC.Visible = value
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
            Me.colCODIGO_DEPARTAMENTO.Visible = value
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
            Me.colCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Private _VerID_NIVEL_ACADEMICO As Boolean = True
    <DefaultValue(True)> _
    Public Property VerID_NIVEL_ACADEMICO() As Boolean
        Get
            Return Me._VerID_NIVEL_ACADEMICO
        End Get
        Set(ByVal value As Boolean)
            Me._VerID_NIVEL_ACADEMICO = value
            Me.colID_NIVEL_ACADEMICO.Visible = value
        End Set
    End Property

    Private _VerOTRA_EDUCACION_FORMAL As Boolean = True
    <DefaultValue(True)> _
    Public Property VerOTRA_EDUCACION_FORMAL() As Boolean
        Get
            Return Me._VerOTRA_EDUCACION_FORMAL
        End Get
        Set(ByVal value As Boolean)
            Me._VerOTRA_EDUCACION_FORMAL = value
            Me.colOTRA_EDUCACION_FORMAL.Visible = value
        End Set
    End Property

    Private _VerCON_DISCAPACIDAD As Boolean = True
    <DefaultValue(True)> _
    Public Property VerCON_DISCAPACIDAD() As Boolean
        Get
            Return Me._VerCON_DISCAPACIDAD
        End Get
        Set(ByVal value As Boolean)
            Me._VerCON_DISCAPACIDAD = value
            Me.colCON_DISCAPACIDAD.Visible = value
        End Set
    End Property

    Private _VerDISC_OTRA As Boolean = True
    <DefaultValue(True)> _
    Public Property VerDISC_OTRA() As Boolean
        Get
            Return Me._VerDISC_OTRA
        End Get
        Set(ByVal value As Boolean)
            Me._VerDISC_OTRA = value
            Me.colDISC_OTRA.Visible = value
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

    #End Region

    Public ReadOnly Property Current() As PARTICIPANTE
        Get
            Return CType(Me.ListaPARTICIPANTEBindingSource.Current, PARTICIPANTE)
        End Get
    End Property

    Private _mEsParticipantesExoneradosDocumentos As Boolean
    Public Property EsParticipantesExoneradosDocumentos() As Boolean
        Get
            Return _mEsParticipantesExoneradosDocumentos
        End Get
        Set(ByVal value As Boolean)
            Me.colID_PARTICIPANTE.Visible = Not value
            Me.colDUI.Visible = Not value
            Me.colNIT.Visible = Not value
            Me.colISSS.Visible = Not value
            Me.colTIPO_DOCTO.Visible = Not value
            Me.colNUM_DOCTO.Visible = Not value
            Me.colEMAIL.Visible = Not value
            Me.colPROFESION_OFICIO.Visible = Not value
            Me.colOCUPACION_ACTUAL.Visible = Not value
            Me.colTITULO_CERTIFICADO_OBTENIDO.Visible = Not value
            Me.colOTRA_EDUCACION_FORMAL.Visible = Not value
            Me.colDISC_OTRA.Visible = Not value
            Me.colLASTUPDATE.Visible = Not value
            Me.colUSERID.Visible = Not value

            _mEsParticipantesExoneradosDocumentos = value
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerLista()
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' filtrado por la tabla PAIS
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPAIS(ByVal ID_PAIS As Decimal) As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorPAIS(ID_PAIS)
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' filtrado por la tabla ESTADO_CIVIL
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal) As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL)
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los Participantes Exonerados de Documentos de Identificación de la tabla PARTICIPANTE
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorExoneradoDocumentos() As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorExoneradoDocumentos()
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        'For Each lEntidad As PARTICIPANTE In _mListaPARTICIPANTE
        '    lEntidad.CODIGO_MUNICIPIO = lEntidad.CODIGO_DEPARTAMENTO + "." + lEntidad.CODIGO_MUNICIPIO
        '    lEntidad.MUNICIPIO_NAC = lEntidad.DEPARTAMENTO_NAC + "." + lEntidad.MUNICIPIO_NAC
        'Next
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' filtrado por la tabla NIVEL_ACADEMICO
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal) As Integer
        _mListaPARTICIPANTE = Me.mComponente.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO)
        If _mListaPARTICIPANTE Is Nothing Then Return -1
        Me.ListaPARTICIPANTEBindingSource.DataSource = _mListaPARTICIPANTE
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
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar() As Integer
        If Not Me.ListaPARTICIPANTEBindingSource.Current Is Nothing Then
            If Me.Current.ID_PARTICIPANTE = 0 Then Return 0
        End If
        If MyBase.Eliminar() = 0 Then Return 0
        If Not Me.ListaPARTICIPANTEBindingSource.Current Is Nothing Then
            If mComponente.EliminarPARTICIPANTE(Me.Current.ID_PARTICIPANTE) <> 1 Then
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
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Guardar() As Integer

        If Me.ListaPARTICIPANTEGridView.HasColumnErrors Then
            Me.sError = "Existen registros no válidos"
            Return -1
        End If

        If Not Me.ListaPARTICIPANTEBindingSource.Current Is Nothing Then
            Me.ListaPARTICIPANTEBindingSource.EndEdit()

            For Each lEntidad As PARTICIPANTE In CType(ListaPARTICIPANTEBindingSource.DataSource, listaPARTICIPANTE).FindAll(Function(g) g.IsDirty = True)
                lEntidad.LASTUPDATE = Now
                lEntidad.TIPO_DOCTO = 3
                lEntidad.USERID = Me.usuarioActualizacion
                Select Case mComponente.ActualizarPARTICIPANTE(lEntidad)
                    Case 0
                        Me.sError = "Registro fue modificado por otro usuario antes de guardar. Recupere nuevamente los registros."
                        Return -1
                    Case 1
                        Dim lParticipanteExonerado As PARTICIPANTE_EXONERADO_DOC
                        Dim bParticipanteExonerado As New cPARTICIPANTE_EXONERADO_DOC
                        lParticipanteExonerado = bParticipanteExonerado.ObtenerPARTICIPANTE_EXONERADO_DOC(lEntidad.ID_PARTICIPANTE)
                        If lParticipanteExonerado Is Nothing Then
                            'bParticipanteExonerado.AgregarPARTICIPANTE_EXONERADO_DOC(lEntidad.ID_PARTICIPANTE, Me.usuarioActualizacion, Now)
                        Else
                            'bParticipanteExonerado.ActualizarPARTICIPANTE_EXONERADO_DOC(lEntidad.ID_PARTICIPANTE, Me.usuarioActualizacion, Now)
                        End If
                        lEntidad.IsDirty = False
                    Case Else
                        Me.sError = mComponente.sError
                        Return -1
                End Select
            Next
        End If
        Return 0
    End Function

    Private Sub ListaPARTICIPANTEBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ListaPARTICIPANTEBindingSource.AddingNew
        Dim lEntidad As New PARTICIPANTE
        e.NewObject = lEntidad
    End Sub

    Private Sub ListaPARTICIPANTEBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTEBindingSource.PositionChanged
        RaiseEvent CambioRegistro()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirAgregar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirAgregar()
        Me.ListaPARTICIPANTEGridView.OptionsBehavior.AllowAddRows = Me.PermitirAgregar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de PermitirEliminar y configura el Grid
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnPermitirEliminar()
        Me.ListaPARTICIPANTEGridView.OptionsBehavior.AllowDeleteRows = Me.PermitirEliminar
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Sobreecribe el ancestro de VerToolBar y reubica el Grid dependiendo
    ''' de si se oculta o pone visible la barra.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Sub OnVerToolbar()
        If Me.VerToolBar Then
            Me.ListaPARTICIPANTEGridControl.Dock = DockStyle.None
            Me.ListaPARTICIPANTEGridControl.Size = New Size(Me.Size.Width, Me.Size.Height - Me.ListaBindingNavigator.Size.Height)
            Me.ListaPARTICIPANTEGridControl.Location = New Point(1, Me.ListaBindingNavigator.Size.Height + 1)
        Else
            Me.ListaPARTICIPANTEGridControl.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ucListaPARTICIPANTE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Dim lista_Departamento As listaDEPARTAMENTO
        Dim lista_DepartamentoNac As listaDEPARTAMENTO
        Dim listaCriteria As List(Of Criteria)

        Me.ListaESTADO_CIVILBindingSource.DataSource = (New cESTADO_CIVIL).ObtenerLista
        Me.ListaPAISBindingSource.DataSource = (New cPAIS).ObtenerLista
        Me.ListaNIVEL_ACADEMICOBindingSource.DataSource = (New cNIVEL_ACADEMICO).ObtenerLista

        lista_Departamento = (New cDEPARTAMENTO).ObtenerLista(False, False, "NOMBRE")
        lista_DepartamentoNac = (New cDEPARTAMENTO).ObtenerLista(False, False, "NOMBRE")

        Me.ListaDEPARTAMENTOBindingSource.DataSource = lista_Departamento
        Me.ListaDEPARTAMENTO_NACBindingSource.DataSource = lista_DepartamentoNac

        listaCriteria = New List(Of Criteria)
        listaCriteria.Add(New Criteria("Hombre", "", "M", ""))
        listaCriteria.Add(New Criteria("Mujer", "", "F", ""))
        Me.ListaGENEROBindingSource.DataSource = listaCriteria

        listaCriteria = New List(Of Criteria)
        listaCriteria.Add(New Criteria("Hombre", "", "M", ""))
        listaCriteria.Add(New Criteria("Mujer", "", "F", ""))
        Me.ListaGENEROBindingSource.DataSource = listaCriteria

        listaCriteria = New List(Of Criteria)
        listaCriteria.Add(New Criteria("Si", "", "1", ""))
        listaCriteria.Add(New Criteria("No", "", "2", ""))
        Me.ListaDISCAPACIDADBindingSource.DataSource = listaCriteria
    End Sub

    Private Sub RepositoryDEPARTAMENTO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryDEPARTAMENTO.EditValueChanged
        Dim view As New DevExpress.XtraGrid.Views.Grid.GridView
        view.SetRowCellValue(view.FocusedRowHandle, "CODIGO_MUNICIPIO", Nothing)
    End Sub

    Private clone As DataView = Nothing

    Private Sub ListaPARTICIPANTEGridView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles ListaPARTICIPANTEGridView.CustomColumnDisplayText
        If e.Column.FieldName = "CODIGO_MUNICIPIO" OrElse e.Column.FieldName = "MUNICIPIO_NAC" Then
            Dim grid As DevExpress.XtraGrid.Views.Grid.GridView
            Dim lEntidad As PARTICIPANTE
            grid = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            lEntidad = CType(grid.GetRow(e.RowHandle), PARTICIPANTE)
            If e.Column.FieldName = "CODIGO_MUNICIPIO" Then
                e.DisplayText = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO).NOMBRE
            Else
                e.DisplayText = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.DEPARTAMENTO_NAC, lEntidad.MUNICIPIO_NAC).NOMBRE
            End If
        End If
    End Sub

    Private Sub ListaPARTICIPANTEGridView_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTEGridView.HiddenEditor
        If clone IsNot Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub ListaPARTICIPANTEGridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles ListaPARTICIPANTEGridView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub ListaPARTICIPANTEGridView_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles ListaPARTICIPANTEGridView.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub ListaPARTICIPANTEGridView_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPARTICIPANTEGridView.ShownEditor
        Dim grid As DevExpress.XtraGrid.Views.Grid.GridView
        grid = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If grid.FocusedColumn.FieldName = "CODIGO_MUNICIPIO" AndAlso TypeOf grid.ActiveEditor Is DevExpress.XtraEditors.GridLookUpEdit Then
            Dim edit As DevExpress.XtraEditors.GridLookUpEdit
            Dim bs As New BindingSource
            Dim fila As PARTICIPANTE

            edit = CType(grid.ActiveEditor, DevExpress.XtraEditors.GridLookUpEdit)
            fila = CType(grid.GetRow(grid.FocusedRowHandle), PARTICIPANTE)
            If fila IsNot Nothing Then
                If fila.CODIGO_DEPARTAMENTO IsNot Nothing Then
                    bs.DataSource = (New cMUNICIPIO).ObtenerLista(fila.CODIGO_DEPARTAMENTO, False, False, "NOMBRE")
                Else
                    bs.DataSource = New listaMUNICIPIO
                End If
                edit.Properties.DataSource = bs
            End If
        ElseIf grid.FocusedColumn.FieldName = "MUNICIPIO_NAC" AndAlso TypeOf grid.ActiveEditor Is DevExpress.XtraEditors.GridLookUpEdit Then
            Dim edit As DevExpress.XtraEditors.GridLookUpEdit
            Dim bs As New BindingSource
            Dim fila As PARTICIPANTE

            edit = CType(grid.ActiveEditor, DevExpress.XtraEditors.GridLookUpEdit)
            fila = CType(grid.GetRow(grid.FocusedRowHandle), PARTICIPANTE)
            If fila IsNot Nothing Then
                If fila.DEPARTAMENTO_NAC IsNot Nothing Then
                    bs.DataSource = (New cMUNICIPIO).ObtenerLista(fila.DEPARTAMENTO_NAC, False, False, "NOMBRE")
                Else
                    bs.DataSource = New listaMUNICIPIO
                End If
                edit.Properties.DataSource = bs
            End If
        End If
    End Sub

    Private Sub RepositoryDEPARTAMENTO_NAC_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryDEPARTAMENTO_NAC.EditValueChanged
        Dim view As New DevExpress.XtraGrid.Views.Grid.GridView
        view.SetRowCellValue(view.FocusedRowHandle, "MUNICIPIO_NAC", Nothing)
    End Sub

    Private Sub ListaPARTICIPANTEGridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles ListaPARTICIPANTEGridView.ValidateRow
        Dim view As GridView = CType(sender, GridView)
        Dim cNombres As GridColumn = view.Columns("NOMBRES")
        Dim cApellidos As GridColumn = view.Columns("APELLIDOS")
        Dim cGenero As GridColumn = view.Columns("GENERO")
        Dim cPais As GridColumn = view.Columns("ID_PAIS")
        Dim cFechaNacimiento As GridColumn = view.Columns("FECHA_NACIMIENTO")
        Dim cDireccion As GridColumn = view.Columns("DIRECCION")
        Dim cTelefono As GridColumn = view.Columns("TELEFONO")
        Dim cMovil As GridColumn = view.Columns("MOVIL")
        Dim cEstadoCivil As GridColumn = view.Columns("ID_ESTADO_CIVIL")
        Dim cDeptoNac As GridColumn = view.Columns("DEPARTAMENTO_NAC")
        Dim cMuniNac As GridColumn = view.Columns("MUNICIPIO_NAC")
        Dim cDeptoResidencia As GridColumn = view.Columns("CODIGO_DEPARTAMENTO")
        Dim cMuniResidencia As GridColumn = view.Columns("CODIGO_MUNICIPIO")
        Dim cNivelAcademico As GridColumn = view.Columns("ID_NIVEL_ACADEMICO")
        Dim cDiscapacidad As GridColumn = view.Columns("CON_DISCAPACIDAD")

        Dim lNombres As String = CType(view.GetRowCellValue(e.RowHandle, colNOMBRES), String)
        Dim lApellidos As String = CType(view.GetRowCellValue(e.RowHandle, colAPELLIDOS), String)
        Dim lGenero As String = CType(view.GetRowCellValue(e.RowHandle, colGENERO), String)
        Dim lPais As String = CType(view.GetRowCellValue(e.RowHandle, colID_PAIS), Integer)
        Dim lFechaNacimiento As String = CType(view.GetRowCellValue(e.RowHandle, colFECHA_NACIMIENTO), Date)
        Dim lDireccion As String = CType(view.GetRowCellValue(e.RowHandle, colDIRECCION), String)
        Dim lTelefono As String = CType(view.GetRowCellValue(e.RowHandle, colTELEFONO), String)
        Dim lMovil As String = CType(view.GetRowCellValue(e.RowHandle, colMOVIL), String)
        Dim lEstadoCivil As String = CType(view.GetRowCellValue(e.RowHandle, colID_ESTADO_CIVIL), Integer)
        Dim lDeptoNac As String = CType(view.GetRowCellValue(e.RowHandle, colDEPARTAMENTO_NAC), String)
        Dim lMuniNac As String = CType(view.GetRowCellValue(e.RowHandle, colMUNICIPIO_NAC), String)
        Dim lDeptoResidencia As String = CType(view.GetRowCellValue(e.RowHandle, colCODIGO_DEPARTAMENTO), String)
        Dim lMuniResidencia As String = CType(view.GetRowCellValue(e.RowHandle, colCODIGO_MUNICIPIO), String)
        Dim lNivelAcademico As String = CType(view.GetRowCellValue(e.RowHandle, colID_NIVEL_ACADEMICO), Integer)
        Dim lDiscapacidad As String = CType(view.GetRowCellValue(e.RowHandle, colCON_DISCAPACIDAD), Integer)

        If lNombres = String.Empty OrElse IsDBNull(lNombres) Then
            e.Valid = False
            view.SetColumnError(cNombres, "Ingrese los Nombres")
        End If
        If lApellidos = String.Empty OrElse IsDBNull(lApellidos) Then
            e.Valid = False
            view.SetColumnError(cApellidos, "Ingrese los Apellidos")
        End If
        If lGenero = String.Empty OrElse IsDBNull(lGenero) Then
            e.Valid = False
            view.SetColumnError(cGenero, "Ingrese el Género")
        End If
        If IsDBNull(lPais) Then
            e.Valid = False
            view.SetColumnError(cPais, "Ingrese el País de origen")
        End If
        If Not IsDate(lFechaNacimiento) OrElse IsDBNull(lPais) Then
            e.Valid = False
            view.SetColumnError(cFechaNacimiento, "Fecha de Nacimiento no válida")
        End If
        If lDireccion = String.Empty OrElse IsDBNull(lDireccion) Then
            e.Valid = False
            view.SetColumnError(cDireccion, "Ingrese la Dirección")
        End If
        If (lTelefono = String.Empty OrElse IsDBNull(lTelefono)) AndAlso (lMovil = String.Empty OrElse IsDBNull(lMovil)) Then
            e.Valid = False
            view.SetColumnError(cTelefono, "Ingrese al menos un número de teléfono o celular")
        End If
        If IsDBNull(lEstadoCivil) Then
            e.Valid = False
            view.SetColumnError(cEstadoCivil, "Ingrese el estado civil")
        End If
        If lDeptoNac = String.Empty OrElse IsDBNull(lDeptoNac) Then
            e.Valid = False
            view.SetColumnError(cDeptoNac, "Ingrese el Departamento de Nacimiento")
        End If
        If lMuniNac = String.Empty OrElse IsDBNull(lMuniNac) Then
            e.Valid = False
            view.SetColumnError(cMuniNac, "Ingrese el Municipio de Nacimiento")
        End If
        If lDeptoResidencia = String.Empty OrElse IsDBNull(lDeptoResidencia) Then
            e.Valid = False
            view.SetColumnError(cDeptoResidencia, "Ingrese el Departamento de Residencia")
        End If
        If lMuniResidencia = String.Empty OrElse IsDBNull(lMuniResidencia) Then
            e.Valid = False
            view.SetColumnError(cMuniResidencia, "Ingrese el Municipio de Residencia")
        End If
        If IsDBNull(lNivelAcademico) Then
            e.Valid = False
            view.SetColumnError(cNivelAcademico, "Ingrese el Nivel Académico")
        End If
        If IsDBNull(lDiscapacidad) Then
            e.Valid = False
            view.SetColumnError(cDiscapacidad, "Ingrese si posee discapacidad")
        End If
    End Sub

    Private Sub ListaPARTICIPANTEGridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles ListaPARTICIPANTEGridView.ValidatingEditor
        Dim grid As GridView = CType(sender, GridView)
        If grid.FocusedColumn.Name = "colNOMBRES" OrElse _
            grid.FocusedColumn.Name = "colAPELLIDOS" OrElse _
            grid.FocusedColumn.Name = "colDIRECCION" Then
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then
                e.Value = e.Value.ToString.Trim.ToUpper
            End If
        End If
        If grid.FocusedColumn.Name = "colTELEFONO" Then
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) AndAlso e.Value <> String.Empty Then
                If e.Value.ToString.Length <> 8 Then
                    e.Valid = False
                    grid.SetColumnError(grid.Columns("TELEFONO"), "Teléfono no válido")
                End If
            End If
        End If
        If grid.FocusedColumn.Name = "colMOVIL" Then
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) AndAlso e.Value <> String.Empty Then
                If e.Value.ToString.Length <> 8 Then
                    e.Valid = False
                    grid.SetColumnError(grid.Columns("MOVIL"), "Móvil no válido")
                End If
            End If
        End If
    End Sub
End Class
