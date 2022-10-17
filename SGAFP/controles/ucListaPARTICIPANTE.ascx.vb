Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxClasses
Imports System.Collections.Generic
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaPARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPARTICIPANTE
    Inherits ucListaBase
 
    Private mComponente As New cPARTICIPANTE
    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 
    Public Event Editando(ByVal ID_PARTICIPANTE As Decimal)
    Private criterios() As Criteria

#Region "Propiedades"

    Public Property VerMensajeGrid() As Boolean
        Get
            Return Me.lblMensajeGrid.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.lblMensajeGrid.Visible = Value
        End Set
    End Property

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

    Private _VerCursosRecibidos As Boolean = False
    Public Property VerCursosRecibidos() As Boolean
        Get
            Return _VerCursosRecibidos
        End Get
        Set(ByVal Value As Boolean)
            _VerCursosRecibidos = Value
            'If Not Me.ViewState("VerCursosRecibidos") Is Nothing Then Me.ViewState.Remove("VerCursosRecibidos")
            'Me.ViewState.Add("VerCursosRecibidos", Value)
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Seleccion_Edicion").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Seleccion_Edicion").Visible = Value
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
            Return Me.dxgvLista.Columns("Seleccion_Edicion").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Columns("Seleccion_Edicion").Visible = value
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

    Private _odsSeleccionado As String
    Public Property odsSeleccionado() As String
        Get
            Return _odsSeleccionado
        End Get
        Set(ByVal value As String)
            _odsSeleccionado = value
            If Not Me.ViewState("OdsSeleccionado") Is Nothing Then Me.ViewState.Remove("OdsSeleccionado")
            Me.ViewState.Add("OdsSeleccionado", value)
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

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
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

    Public Property VerGENERO() As Boolean
        Get
            Return Me.dxgvLista.Columns("GENERO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("GENERO").Visible = Value
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

    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible = Value
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

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT").Visible = Value
        End Set
    End Property

    Public Property VerISSS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ISSS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ISSS").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DOCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DOCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DOCTO").Visible = Value
        End Set
    End Property

    Public Property VerNUM_DOCTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_DOCTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_DOCTO").Visible = Value
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

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("EMAIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EMAIL").Visible = Value
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

    Public Property VerPROFESION_OFICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROFESION_OFICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROFESION_OFICIO").Visible = Value
        End Set
    End Property

    Public Property VerOCUPACION_ACTUAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUPACION_ACTUAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUPACION_ACTUAL").Visible = Value
        End Set
    End Property

    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Visible = Value
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

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible = Value
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

    Public Property VerID_NIVEL_ACADEMICO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_EDUCACION_FORMAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Visible = Value
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

    Public Property VerDISC_OTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISC_OTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISC_OTRA").Visible = Value
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

    Public Property VerUSERID() As Boolean
        Get
            Return Me.dxgvLista.Columns("USERID").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USERID").Visible = Value
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

    Public Property HeaderGENERO() As String
        Get
            Return Me.dxgvLista.Columns("GENERO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("GENERO").Caption = Value
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

    Public Property HeaderFECHA_NACIMIENTO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption = Value
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

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT() As String
        Get
            Return Me.dxgvLista.Columns("NIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT").Caption = Value
        End Set
    End Property

    Public Property HeaderISSS() As String
        Get
            Return Me.dxgvLista.Columns("ISSS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ISSS").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DOCTO() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DOCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DOCTO").Caption = Value
        End Set
    End Property

    Public Property HeaderNUM_DOCTO() As String
        Get
            Return Me.dxgvLista.Columns("NUM_DOCTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_DOCTO").Caption = Value
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

    Public Property HeaderEMAIL() As String
        Get
            Return Me.dxgvLista.Columns("EMAIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EMAIL").Caption = Value
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

    Public Property HeaderPROFESION_OFICIO() As String
        Get
            Return Me.dxgvLista.Columns("PROFESION_OFICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROFESION_OFICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUPACION_ACTUAL() As String
        Get
            Return Me.dxgvLista.Columns("OCUPACION_ACTUAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUPACION_ACTUAL").Caption = Value
        End Set
    End Property

    Public Property HeaderTITULO_CERTIFICADO_OBTENIDO() As String
        Get
            Return Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Caption = Value
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

    Public Property HeaderID_NIVEL_ACADEMICO() As String
        Get
            Return Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_NIVEL_ACADEMICO").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_EDUCACION_FORMAL() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Caption = Value
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

    Public Property HeaderDISC_OTRA() As String
        Get
            Return Me.dxgvLista.Columns("DISC_OTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISC_OTRA").Caption = Value
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

    Public Property HeaderUSERID() As String
        Get
            Return Me.dxgvLista.Columns("USERID").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USERID").Caption = Value
        End Set
    End Property


    Public Property TamanoPagina() As Decimal
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Decimal)
            Me.dxgvLista.SettingsPager.PageSize = value
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

    Private Property Participante() As PARTICIPANTE
        Get
            Return Me.ViewState("Participante")
        End Get
        Set(ByVal value As PARTICIPANTE)
            Me.ViewState("Participante") = value
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
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorParticipantesSemejantes(ByVal EntidadParticipante As PARTICIPANTE, ByRef duplicadoPorFonetico As Integer) As Integer
        Me.Participante = EntidadParticipante
        Me.DuplicadoPorFonetico = duplicadoPorFonetico
        Me.odsListaParticipantesSemejantes.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaParticipantesSemejantes"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


   
    Public Function CargarDatosPorCriterios(ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As String, ByVal ID_PARTICIPANTE As Int32, ByVal DUI As String, ByVal NIT As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("NOMBRES").DefaultValue = NOMBRES
        Me.odsListaPorCriterios.SelectParameters("APELLIDOS").DefaultValue = APELLIDOS
        Me.odsListaPorCriterios.SelectParameters("FECHA_NACIMIENTO").DefaultValue = FECHA_NACIMIENTO
        Me.odsListaPorCriterios.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE.ToString
        Me.odsListaPorCriterios.SelectParameters("DUI").DefaultValue = DUI
        Me.odsListaPorCriterios.SelectParameters("NIT").DefaultValue = NIT
        Me.odsListaPorCriterios.SelectParameters("asColumnaOrden").DefaultValue = "NOMBRES"
        Me.odsListaPorCriterios.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.DataBind()
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPAIS(ByVal ID_PAIS As Decimal) As Integer
        Me.odsListaPorPAIS.SelectParameters("ID_PAIS").DefaultValue = ID_PAIS.ToString()
        Me.odsListaPorPAIS.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPAIS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPAIS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPAIS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPAIS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPAIS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' por los criterios de NOMBRES y APELLIDOS
    ''' </summary>
    ''' <param name="NOMBRES_APELLIDOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNOMBRES_APELLIDOS(ByVal NOMBRES_APELLIDOS As String) As Integer
        Me.odsListaPorNOMBRES_APELLIDOS.SelectParameters("NOMBRES_APELLIDOS").DefaultValue = NOMBRES_APELLIDOS.ToString()
        Me.odsListaPorNOMBRES_APELLIDOS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorNOMBRES_APELLIDOS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorNOMBRES_APELLIDOS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorNOMBRES_APELLIDOS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' por los criterios de NOMBRES y APELLIDOS
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="NOMBRES_APELLIDOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNOMBRES_APELLIDOS_InscritosPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, ByVal NOMBRES_APELLIDOS As String) As Integer
        Me.odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor.SelectParameters("NOMBRES_APELLIDOS").DefaultValue = NOMBRES_APELLIDOS.ToString()
        Me.odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' por el criterio de DUI
    ''' </summary>
    ''' <param name="DUI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDUI(ByVal DUI As String) As Integer
        Me.odsListaPorDUI.SelectParameters("DUI").DefaultValue = DUI.ToString()
        Me.odsListaPorDUI.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorDUI.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorDUI.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorDUI"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE
    ''' por el criterio de DUI
    ''' </summary>
    ''' <param name="NIT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNIT(ByVal NIT As String) As Integer
        Me.odsListaPorNIT.SelectParameters("NIT").DefaultValue = NIT.ToString()
        Me.odsListaPorNIT.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorNIT.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorNIT.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorNIT"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PARTICIPANTE
    ''' filtrado por los Criterios de Busqueda Recibidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	17/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorBusqueda(ByVal aCriterios() As Criteria) As Integer
        Me.criterios = aCriterios
        Me.odsListaPorBusqueda.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorBusqueda"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal) As Integer
        Me.odsListaPorESTADO_CIVIL.SelectParameters("ID_ESTADO_CIVIL").DefaultValue = ID_ESTADO_CIVIL.ToString()
        Me.odsListaPorESTADO_CIVIL.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorESTADO_CIVIL.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorESTADO_CIVIL.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorESTADO_CIVIL.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorESTADO_CIVIL.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_CIVIL"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        Me.odsListaPorDEPARTAMENTO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorDEPARTAMENTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_MUNICIPIO").DefaultValue = CODIGO_MUNICIPIO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMUNICIPIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal) As Integer
        Me.odsListaPorNIVEL_ACADEMICO.SelectParameters("ID_NIVEL_ACADEMICO").DefaultValue = ID_NIVEL_ACADEMICO.ToString()
        Me.odsListaPorNIVEL_ACADEMICO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorNIVEL_ACADEMICO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorNIVEL_ACADEMICO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorNIVEL_ACADEMICO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorNIVEL_ACADEMICO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorNIVEL_ACADEMICO"
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
                keyValues(i) = grid.GetRowValues(i, "ID_PARTICIPANTE")
                keyNames(i) = grid.GetRowValues(i, "NOMBRES")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
        End If
        If Me.PermitirEditar AndAlso Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Seleccion_Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.VerCursosRecibidos Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).CustomButtons("btnCursosRecibidos").Visibility = DevExpress.Web.ASPxGridView.GridViewCustomButtonVisibility.BrowsableRow
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Seleccionar" Then
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EditForm Then
            'Dim btnGuardar As DevExpress.Web.ASPxEditors.ASPxButton
            'Dim btnCancelar As DevExpress.Web.ASPxEditors.ASPxButton
            'btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            'btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            'btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxEditors.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            'Dim lblEmptyDataRow As DevExpress.Web.ASPxEditors.ASPxLabel
            'lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            'If Not Me.PermitirEditar AndAlso dxgvLista.Columns("Seleccion_Edicion").Visible Then
            '    Dim lbDetalle As LinkButton
            '    lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
            '    lbDetalle.Visible = False
            'End If
            'If Me.PermitirSeleccionar AndAlso dxgvLista.Columns("Seleccion_Edicion").Visible Then
            '    Dim lbSeleccionar As LinkButton
            '    lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
            '    lbSeleccionar.Visible = True
            '    lbSeleccionar.Text = Me.TextoSeleccionar
            '    lbSeleccionar.CommandName = Me.ComandoSeleccionar
            '    If lbSeleccionar.CommandName = "Check" Then
            '        lbSeleccionar.Visible = False
            '    End If
            'End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaPARTICIPANTE
        Dim mLista As New listaPARTICIPANTE
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PARTICIPANTE")
            Dim lEntidad As New PARTICIPANTE
            lEntidad.ID_PARTICIPANTE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PARTICIPANTE = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PARTICIPANTE)

            If Me.mComponente.EliminarPARTICIPANTE(lEntidad.ID_PARTICIPANTE) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='../imagenes/eliminar.png' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub odsListaPorBusqueda_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsListaPorBusqueda.Selecting
        e.InputParameters("aEntidad") = New PARTICIPANTE
        e.InputParameters("aCriterios") = Me.criterios
    End Sub

#Region "Implementación por Callback"
    Protected Sub cbpucListaPARTICIPANTE_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbpucListaPARTICIPANTE.Callback
        Dim parametros() As String = e.Parameter.Split(";")

    End Sub

    Public Sub CargarDatosPorCallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "BuscarDatos" Then
            If hf.Contains("BuscarDatos") Then hf("BuscarDatos") = parametros(0) Else hf.Add("BuscarDatos", parametros(0))
            For i As Integer = 1 To parametros.Length - 1
                If hf.Contains("param" + (i).ToString) Then hf.Remove("param" + (i).ToString)
            Next
            For i As Integer = 1 To parametros.Length - 1
                hf.Add("param" + (i).ToString, parametros(i))
            Next
            ActualizarCargarDatosCallback()
        End If
    End Sub

    Private Sub ActualizarCargarDatosCallback(Optional ByVal arg1 As String = "", Optional ByVal arg2 As String = "", Optional ByVal arg3 As String = "")
        If hf.Contains("BuscarDatos") Then
            Select Case hf("BuscarDatos")
                Case "NOMBRES_APELLIDOS"
                    Me.CargarDatosPorNOMBRES_APELLIDOS(hf("param1"))

                Case "DUI"
                    Me.CargarDatosPorDUI(hf("param1"))

                Case "NIT"
                    Me.CargarDatosPorNIT(hf("param1"))

                Case "NOMBRES_APELLIDOS_InscritosPorProveedor"
                    Me.CargarDatosPorNOMBRES_APELLIDOS_InscritosPorProveedor(CDec(hf("param1")), hf("param2"))

                Case "CRITERIOS"
                    Dim criterios As New List(Of Criteria)

                    If hf("param4") <> "-1" Then
                        criterios.Add(New Criteria("ID_PARTICIPANTE", "=", hf("param4"), "AND"))
                    End If

                    If hf("param1") <> "" Then
                        criterios.Add(New Criteria("NOMBRES", "%*%", hf("param1").ToUpper(), "AND"))
                    End If

                    If hf("param2") <> "" Then
                        criterios.Add(New Criteria("APELLIDOS", "%*%", hf("param2").ToUpper(), "AND"))
                    End If

                    If hf("param3") <> "" Then
                        criterios.Add(New Criteria("FECHA_NACIMIENTO", "=", hf("param3"), "AND"))
                    End If

                    If hf("param5") <> "" Then
                        criterios.Add(New Criteria("DUI", "=", hf("param5"), "AND"))
                    End If

                    If hf("param6") <> "" Then
                        criterios.Add(New Criteria("NIT", "=", hf("param6"), "AND"))
                    End If
                    Me.CargarDatosPorBusqueda(criterios.ToArray())
            End Select
        End If
    End Sub
#End Region
 

    Protected Sub odsListaParticipantesSemejantes_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsListaParticipantesSemejantes.Selecting
        e.InputParameters("mPARTICIPANTE") = Me.Participante
        e.InputParameters("duplicadoPorFonetico") = Me.DuplicadoPorFonetico
    End Sub
End Class
