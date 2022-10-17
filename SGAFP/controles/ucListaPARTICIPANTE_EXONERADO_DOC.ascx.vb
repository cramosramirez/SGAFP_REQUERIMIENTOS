Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaPARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PARTICIPANTE_EXONERADO_DOC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPARTICIPANTE_EXONERADO_DOC
    Inherits ucListaBase
 
    Private mComponente As New cPARTICIPANTE_EXONERADO_DOC
    Public Event Seleccionado(ByVal ID_PARTICIPANTE_EXONERADO As Decimal)
    Public Event Editando(ByVal ID_PARTICIPANTE_EXONERADO As Decimal)

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreFuente() As String
        Get
            Return Me.dxgvLista.Font.Name
        End Get
        Set(ByVal value As String)
            Me.dxgvLista.Font.Name = value
        End Set
    End Property

    Public Property TamanoFuente() As System.Web.UI.WebControls.FontUnit
        Get
            Return Me.dxgvLista.Font.Size
        End Get
        Set(ByVal value As System.Web.UI.WebControls.FontUnit)
            Me.dxgvLista.Font.Size = value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE_EXONERADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE_EXONERADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PARTICIPANTE_EXONERADO").Visible = Value
        End Set
    End Property


    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.dxgvLista.Columns("USERID").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USERID").Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LASTUPDATE").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible = Value
        End Set
    End Property

    Public Property MensajeGrid() As String
        Get
            Return Me.lblMensajeGrid.Text
        End Get
        Set(ByVal Value As String)
            Me.lblMensajeGrid.Text = Value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_SITIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_SITIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_SITIO").Visible = Value
        End Set
    End Property


    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDOS").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible = Value
        End Set
    End Property

    Public Property VerGENERO() As Boolean
        Get
            Return Me.dxgvLista.Columns("GENERO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("GENERO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible = Value
        End Set
    End Property

    Public Property VerMensajeGrid() As Boolean
        Get
            Return Me.lblMensajeGrid.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.lblMensajeGrid.Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible = Value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_NAC() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_NAC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEPARTAMENTO_NAC").Visible = Value
        End Set
    End Property

    Public Property VerMUNICIPIO_NAC() As Boolean
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_NAC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MUNICIPIO_NAC").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO").Visible = Value
        End Set
    End Property

    Public Property VerMOVIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("MOVIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MOVIL").Visible = Value
        End Set
    End Property

    Public Property VerCON_DISCAPACIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("CON_DISCAPACIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CON_DISCAPACIDAD").Visible = Value
        End Set
    End Property

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("EMAIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EMAIL").Visible = Value
        End Set
    End Property

    Public Property VerID_NIVEL_ACADEMICO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Visible = Value
        End Set
    End Property

    Public Property VerID_PAIS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PAIS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PAIS").Visible = Value
        End Set
    End Property

    Public Property VerID_ESTADO_CIVIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_CIVIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTADO_CIVIL").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INGRESO").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_EVALUA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_EVALUA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_EVALUA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_EVALUA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_EVALUA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_EVALUA").Visible = Value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO").Visible = Value
        End Set
    End Property

    Public Property HeaderID_PARTICIPANTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.dxgvLista.Columns("USERID").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USERID").Caption = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LASTUPDATE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_AF() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SITIO_CAPACITACION() As String
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES").Caption = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APELLIDOS").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_NACIMIENTO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderGENERO() As String
        Get
            Return Me.dxgvLista.Columns("GENERO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("GENERO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_DEPARTAMENTO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_MUNICIPIO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption = Value
        End Set
    End Property

    Public Property HeaderDEPARTAMENTO_NAC() As String
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_NAC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEPARTAMENTO_NAC").Caption = Value
        End Set
    End Property

    Public Property HeaderMUNICIPIO_NAC() As String
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_NAC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MUNICIPIO_NAC").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO").Caption = Value
        End Set
    End Property

    Public Property HeaderMOVIL() As String
        Get
            Return Me.dxgvLista.Columns("MOVIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOVIL").Caption = Value
        End Set
    End Property

    Public Property HeaderCON_DISCAPACIDAD() As String
        Get
            Return Me.dxgvLista.Columns("CON_DISCAPACIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CON_DISCAPACIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderEMAIL() As String
        Get
            Return Me.dxgvLista.Columns("EMAIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EMAIL").Caption = Value
        End Set
    End Property

    Public Property HeaderID_NIVEL_ACADEMICO() As String
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PAIS() As String
        Get
            Return Me.dxgvLista.Columns("ID_PAIS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PAIS").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ESTADO_CIVIL() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_CIVIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTADO_CIVIL").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INGRESO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INGRESO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_EVALUA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_EVALUA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_EVALUA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_EVALUA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_EVALUA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_EVALUA").Caption = Value
        End Set
    End Property

    Public Property HeaderES_APROBADO() As String
        Get
            Return Me.dxgvLista.Columns("ES_APROBADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_APROBADO").Caption = Value
        End Set
    End Property

    Private Property ParticipanteExoneradoDoc() As PARTICIPANTE_EXONERADO_DOC
        Get
            Return Me.ViewState("ParticipanteExoneradoDoc")
        End Get
        Set(ByVal value As PARTICIPANTE_EXONERADO_DOC)
            Me.ViewState("ParticipanteExoneradoDoc") = value
        End Set
    End Property

    Private Property DuplicadoPorFonetico() As Integer
        Get
            Return Me.ViewState("DuplicadoPorFonetico")
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("DuplicadoPorFonetico") = value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorParticipantesSemejantes(ByVal EntidadPartiExonerado As PARTICIPANTE_EXONERADO_DOC, ByRef duplicadoPorFonetico As Integer) As Integer
        Me.ParticipanteExoneradoDoc = EntidadPartiExonerado
        Me.DuplicadoPorFonetico = duplicadoPorFonetico
        Me.odsListaParticipantesSemejantes.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaParticipantesSemejantes"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ESTADO As Decimal, ByVal FECHA_NACIMIENTO As Object, ByVal NOMBRES As String, ByVal APELLIDOS As String) As Integer
        Me.odsListaCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.odsListaCriterios.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION
        Me.odsListaCriterios.SelectParameters("ESTADO").DefaultValue = ESTADO
        Me.odsListaCriterios.SelectParameters("FECHA_NACIMIENTO").DefaultValue = FECHA_NACIMIENTO
        Me.odsListaCriterios.SelectParameters("NOMBRES").DefaultValue = NOMBRES
        Me.odsListaCriterios.SelectParameters("APELLIDOS").DefaultValue = APELLIDOS
        Me.odsListaCriterios.SelectParameters("asColumnaOrden").DefaultValue = "NOMBRES"
        Me.odsListaCriterios.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Me.odsListaPorPARTICIPANTE.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE.ToString()
        Me.odsListaPorPARTICIPANTE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPARTICIPANTE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPARTICIPANTE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPARTICIPANTE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPARTICIPANTE"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_AF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorSITIO_CAPACITACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSITIO_CAPACITACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_PARTICIPANTE_EXONERADO")
                keyNames(i) = grid.GetRowValues(i, "USERID")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EditForm Then
            Dim btnGuardar As DevExpress.Web.ASPxEditors.ASPxButton
            Dim btnCancelar As DevExpress.Web.ASPxEditors.ASPxButton
            btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EmptyDataRow Then
            Dim btnAgregar As DevExpress.Web.ASPxEditors.ASPxButton
            btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnAgregar.Visible = Me.PermitirAgregarInline
            Dim lblEmptyDataRow As DevExpress.Web.ASPxEditors.ASPxLabel
            lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEditar OrElse e.GetValue("ESTADO") > 0 Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPARTICIPANTE_EXONERADO_DOC
        Dim mLista As New listaPARTICIPANTE_EXONERADO_DOC
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PARTICIPANTE_EXONERADO")
            Dim lEntidad As New PARTICIPANTE_EXONERADO_DOC
            lEntidad.ID_PARTICIPANTE_EXONERADO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PARTICIPANTE_EXONERADO_DOC = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PARTICIPANTE_EXONERADO_DOC)
            If lEntidad.ESTADO > 0 Then
                Me.AsignarMensaje("No se puede eliminar el participante porque está Evaluado", True, True)
                Return
            End If
            If Me.mComponente.EliminarPARTICIPANTE_EXONERADO_DOC(lEntidad.ID_PARTICIPANTE_EXONERADO) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='../imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
            If (EstaEnRol(RolDeUsuario.Proveedor) OrElse EstaEnRol(RolDeUsuario.CentroCapacitador)) AndAlso dxgvLista.GetRowValues(e.VisibleIndex, "ESTADO") <= 0 Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim idProveedor As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "ID_PROVEEDOR_AF")
            If idProveedor IsNot Nothing Then
                e.Value = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(CDec(idProveedor)).NOMBRE_PROVEEDOR
            End If
        ElseIf e.Column.FieldName = "NOMBRE_SITIO" Then
            Dim idSitioCapacitacion As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "ID_SITIO_CAPACITACION")
            If idSitioCapacitacion IsNot Nothing Then
                e.Value = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(CDec(idSitioCapacitacion)).NOMBRE_SITIO
            End If
        ElseIf e.Column.FieldName = "DEPARTAMENTO_RESIDENCIA" Then
            Dim idCodigoDepto As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "CODIGO_DEPARTAMENTO")
            If idCodigoDepto IsNot Nothing Then
                e.Value = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(idCodigoDepto.ToString).NOMBRE
            End If
        ElseIf e.Column.FieldName = "MUNICIPIO_RESIDENCIA" Then
            Dim idCodigoDepto As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "CODIGO_DEPARTAMENTO")
            Dim idCodigoMuni As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "CODIGO_MUNICIPIO")
            If idCodigoDepto IsNot Nothing AndAlso idCodigoMuni IsNot Nothing Then
                e.Value = (New cMUNICIPIO).ObtenerMUNICIPIO(idCodigoDepto.ToString, idCodigoMuni.ToString).NOMBRE
            End If
        ElseIf e.Column.FieldName = "ESTADO_DESCRIP" Then
            Dim idEstado As Object = dxgvLista.GetRowValues(e.ListSourceRowIndex, "ESTADO")
            If idEstado IsNot Nothing Then
                Select Case CDec(idEstado)
                    Case 0
                        e.Value = "PENDIENTE DE EVALUAR"
                    Case 1
                        e.Value = "APROBADO"
                    Case 2
                        e.Value = "RECHAZADO"
                End Select
            End If
        End If
    End Sub

    Protected Sub odsListaParticipantesSemejantes_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsListaParticipantesSemejantes.Selecting
        e.InputParameters("mPARTICIPANTE_EXONERADO_DOC") = Me.ParticipanteExoneradoDoc
        e.InputParameters("duplicadoPorFonetico") = Me.DuplicadoPorFonetico
    End Sub
End Class
