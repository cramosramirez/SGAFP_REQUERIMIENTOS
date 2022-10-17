Imports SGAFP.BL
Imports SGAFP.EL
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports System.Collections.Generic

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLICITUD_INSCRIPCION_AF
    Inherits ucListaBase

    Private mComponente As New cSOLICITUD_INSCRIPCION_AF
    Public Event Seleccionado(ByVal ID_SOLICITUD As Decimal)
    Public Event Editando(ByVal ID_SOLICITUD As Decimal)

#Region "Propiedades"

    Public Property TamanoPagina() As Decimal
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Decimal)
            Me.dxgvLista.SettingsPager.PageSize = value
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

    Public Property PermitirRevertirEstado() As Boolean
        Get
            Return Me.dxgvLista.Columns("colRevertir").Visible
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Columns("colRevertir").Visible = value
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

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SOLICITUD").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_PRESENTACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_PRESENTACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_PRESENTACION").Visible = Value
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

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Visible = Value
        End Set
    End Property

    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTADO_SOLICITUD").Visible = Value
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

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
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

    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_SOLICITUD").Visible = Value
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

    Public Property VerEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDAD").Visible = Value
        End Set
    End Property

    Public Property VerMIEMBROS_GRUPO_FAMILIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("MIEMBROS_GRUPO_FAMILIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MIEMBROS_GRUPO_FAMILIAR").Visible = Value
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

    Public Property VerES_JEFE_HOGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ES_JEFE_HOGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ES_JEFE_HOGAR").Visible = Value
        End Set
    End Property

    Public Property VerTIENE_HIJOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIENE_HIJOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIENE_HIJOS").Visible = Value
        End Set
    End Property

    Public Property VerNO_DE_HIJOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_DE_HIJOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_DE_HIJOS").Visible = Value
        End Set
    End Property

    Public Property VerSE_DEDICA_ALGUNA_PROFESION() As Boolean
        Get
            Return Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Visible = Value
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

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
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

    Public Property VerID_LEE_ESCRIBE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_LEE_ESCRIBE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_LEE_ESCRIBE").Visible = Value
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

    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Visible = Value
        End Set
    End Property

    Public Property VerESTUDIA_ACTUALMENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTUDIA_ACTUALMENTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTUDIA_ACTUALMENTE").Visible = Value
        End Set
    End Property

    Public Property VerID_TIEMPO_DEJO_ESTUDIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIEMPO_DEJO_ESTUDIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIEMPO_DEJO_ESTUDIAR").Visible = Value
        End Set
    End Property

    Public Property VerRECIBIO_CURSO_ANTERIOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("RECIBIO_CURSO_ANTERIOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RECIBIO_CURSO_ANTERIOR").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_PROM_EMP_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_PROM_EMP_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_PROM_EMP_ACT").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_OBT_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_OBT_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_OBT_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_OBT_ING_EXTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_OBT_ING_EXTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_OBT_ING_EXTRA").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_CAMB_EMP_X_CURSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_CAMB_EMP_X_CURSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_CAMB_EMP_X_CURSO").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_TRAB_CTA_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_TRAB_CTA_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_TRAB_CTA_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerBENEF_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BENEF_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BENEF_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerRAZON_NO_BENEFICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("RAZON_NO_BENEFICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RAZON_NO_BENEFICIO").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACION").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_TRABAJA() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_TRABAJA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_TRABAJA").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_ESTUDIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_ESTUDIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_ESTUDIA").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_DESOCUPADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_DESOCUPADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_DESOCUPADO").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_OFICIO_HOGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_OFICIO_HOGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_OFICIO_HOGAR").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_BUSCA_TRABAJO() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_BUSCA_TRABAJO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_BUSCA_TRABAJO").Visible = Value
        End Set
    End Property

    Public Property VerOCUACT_OTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("OCUACT_OTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OCUACT_OTRA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerSECTOR_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SECTOR_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SECTOR_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerTRABAJO_ANTERIOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TRABAJO_ANTERIOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TRABAJO_ANTERIOR").Visible = Value
        End Set
    End Property

    Public Property VerRECIBE_INGRESOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("RECIBE_INGRESOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RECIBE_INGRESOS").Visible = Value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_TRABAJO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_TRABAJO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MANERA_OBT_ING_TRABAJO").Visible = Value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_AYUDA_FAM() As Boolean
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_AYUDA_FAM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MANERA_OBT_ING_AYUDA_FAM").Visible = Value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_REMESA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_REMESA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MANERA_OBT_ING_REMESA").Visible = Value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_PENSION() As Boolean
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_PENSION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MANERA_OBT_ING_PENSION").Visible = Value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MANERA_OBT_ING_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_PROMOCION_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_PROMOCION_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_PROMOCION_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_CAMBIAR_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_CAMBIAR_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_CAMBIAR_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_OBTENER_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_OBTENER_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_OBTENER_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_TRABAJAR_CTA_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_TRABAJAR_CTA_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_TRABAJAR_CTA_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_INGRESOS_EXTRAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_INGRESOS_EXTRAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_INGRESOS_EXTRAS").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_NINGUNO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_NINGUNO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_NINGUNO").Visible = Value
        End Set
    End Property

    Public Property VerEXPFOR_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EXPFOR_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EXPFOR_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_REL_TRAB_ACTUAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_REL_TRAB_ACTUAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_REL_TRAB_ACTUAL").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_REL_TRAB_NUEVO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_REL_TRAB_NUEVO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_REL_TRAB_NUEVO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerID_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEPARTAMENTO_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerMUNICIPIO_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MUNICIPIO_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerMOVIL_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MOVIL_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MOVIL_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerEMAIL_REFERENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("EMAIL_REFERENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EMAIL_REFERENCIA").Visible = Value
        End Set
    End Property

    Public Property VerSUGERENCIAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SUGERENCIAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SUGERENCIAS").Visible = Value
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



    Public Property VerNOMBRE_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible = Value
        End Set
    End Property
    Public Property VerCODIGO_GRUPO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_GRUPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_GRUPO").Visible = Value
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
    Public Property VerESTADO_SOLICITUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO_SOLICITUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO_SOLICITUD").Visible = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SOLICITUD").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_PRESENTACION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_PRESENTACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_PRESENTACION").Caption = Value
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

    Public Property HeaderID_ACCION_FORMATIVA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ESTADO_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTADO_SOLICITUD").Caption = Value
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

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
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

    Public Property HeaderID_TIPO_SOLICITUD() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_SOLICITUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_SOLICITUD").Caption = Value
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

    Public Property HeaderEDAD() As String
        Get
            Return Me.dxgvLista.Columns("EDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderMIEMBROS_GRUPO_FAMILIAR() As String
        Get
            Return Me.dxgvLista.Columns("MIEMBROS_GRUPO_FAMILIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MIEMBROS_GRUPO_FAMILIAR").Caption = Value
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

    Public Property HeaderES_JEFE_HOGAR() As String
        Get
            Return Me.dxgvLista.Columns("ES_JEFE_HOGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_JEFE_HOGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTIENE_HIJOS() As String
        Get
            Return Me.dxgvLista.Columns("TIENE_HIJOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIENE_HIJOS").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_DE_HIJOS() As String
        Get
            Return Me.dxgvLista.Columns("NO_DE_HIJOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_DE_HIJOS").Caption = Value
        End Set
    End Property

    Public Property HeaderSE_DEDICA_ALGUNA_PROFESION() As String
        Get
            Return Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Caption = Value
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

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
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

    Public Property HeaderID_LEE_ESCRIBE() As String
        Get
            Return Me.dxgvLista.Columns("ID_LEE_ESCRIBE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_LEE_ESCRIBE").Caption = Value
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

    Public Property HeaderTITULO_CERTIFICADO_OBTENIDO() As String
        Get
            Return Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TITULO_CERTIFICADO_OBTENIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderESTUDIA_ACTUALMENTE() As String
        Get
            Return Me.dxgvLista.Columns("ESTUDIA_ACTUALMENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTUDIA_ACTUALMENTE").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIEMPO_DEJO_ESTUDIAR() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIEMPO_DEJO_ESTUDIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIEMPO_DEJO_ESTUDIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderRECIBIO_CURSO_ANTERIOR() As String
        Get
            Return Me.dxgvLista.Columns("RECIBIO_CURSO_ANTERIOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RECIBIO_CURSO_ANTERIOR").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_PROM_EMP_ACT() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_PROM_EMP_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_PROM_EMP_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_OBT_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_OBT_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_OBT_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_OBT_ING_EXTRA() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_OBT_ING_EXTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_OBT_ING_EXTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_CAMB_EMP_X_CURSO() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_CAMB_EMP_X_CURSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_CAMB_EMP_X_CURSO").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_TRAB_CTA_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_TRAB_CTA_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_TRAB_CTA_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderBENEF_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("BENEF_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BENEF_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderRAZON_NO_BENEFICIO() As String
        Get
            Return Me.dxgvLista.Columns("RAZON_NO_BENEFICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RAZON_NO_BENEFICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_TRABAJA() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_TRABAJA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_TRABAJA").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_ESTUDIA() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_ESTUDIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_ESTUDIA").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_DESOCUPADO() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_DESOCUPADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_DESOCUPADO").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_OFICIO_HOGAR() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_OFICIO_HOGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_OFICIO_HOGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_BUSCA_TRABAJO() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_BUSCA_TRABAJO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_BUSCA_TRABAJO").Caption = Value
        End Set
    End Property

    Public Property HeaderOCUACT_OTRA() As String
        Get
            Return Me.dxgvLista.Columns("OCUACT_OTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OCUACT_OTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderSECTOR_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("SECTOR_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SECTOR_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderTRABAJO_ANTERIOR() As String
        Get
            Return Me.dxgvLista.Columns("TRABAJO_ANTERIOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TRABAJO_ANTERIOR").Caption = Value
        End Set
    End Property

    Public Property HeaderRECIBE_INGRESOS() As String
        Get
            Return Me.dxgvLista.Columns("RECIBE_INGRESOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RECIBE_INGRESOS").Caption = Value
        End Set
    End Property

    Public Property HeaderMANERA_OBT_ING_TRABAJO() As String
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_TRABAJO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MANERA_OBT_ING_TRABAJO").Caption = Value
        End Set
    End Property

    Public Property HeaderMANERA_OBT_ING_AYUDA_FAM() As String
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_AYUDA_FAM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MANERA_OBT_ING_AYUDA_FAM").Caption = Value
        End Set
    End Property

    Public Property HeaderMANERA_OBT_ING_REMESA() As String
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_REMESA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MANERA_OBT_ING_REMESA").Caption = Value
        End Set
    End Property

    Public Property HeaderMANERA_OBT_ING_PENSION() As String
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_PENSION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MANERA_OBT_ING_PENSION").Caption = Value
        End Set
    End Property

    Public Property HeaderMANERA_OBT_ING_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("MANERA_OBT_ING_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MANERA_OBT_ING_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_PROMOCION_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_PROMOCION_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_PROMOCION_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_CAMBIAR_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_CAMBIAR_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_CAMBIAR_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_OBTENER_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_OBTENER_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_OBTENER_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_TRABAJAR_CTA_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_TRABAJAR_CTA_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_TRABAJAR_CTA_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_INGRESOS_EXTRAS() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_INGRESOS_EXTRAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_INGRESOS_EXTRAS").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_NINGUNO() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_NINGUNO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_NINGUNO").Caption = Value
        End Set
    End Property

    Public Property HeaderEXPFOR_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("EXPFOR_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EXPFOR_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_REL_TRAB_ACTUAL() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_REL_TRAB_ACTUAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_REL_TRAB_ACTUAL").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_REL_TRAB_NUEVO() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_REL_TRAB_NUEVO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_REL_TRAB_NUEVO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("ID_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderDEPARTAMENTO_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEPARTAMENTO_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderMUNICIPIO_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MUNICIPIO_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderMOVIL_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("MOVIL_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOVIL_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderEMAIL_REFERENCIA() As String
        Get
            Return Me.dxgvLista.Columns("EMAIL_REFERENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EMAIL_REFERENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderSUGERENCIAS() As String
        Get
            Return Me.dxgvLista.Columns("SUGERENCIAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SUGERENCIAS").Caption = Value
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

#End Region


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal idSolicitud As Decimal, ByVal idProveedor As Decimal, ByVal idSitioCapacitacion As Decimal, ByVal idEjercicio As String, ByVal idEstadoSolicitud As Enumeradores.EstadoSolicitud, ByVal nombreAccionFormativa As String, ByVal codigoGrupo As String, ByVal nombresSolicitante As String, ByVal apellidosSolicitante As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("idSolicitud").DefaultValue = idSolicitud
        Me.odsListaPorCriterios.SelectParameters("idProveedor").DefaultValue = idProveedor
        Me.odsListaPorCriterios.SelectParameters("idSitioCapacitacion").DefaultValue = idSitioCapacitacion
        Me.odsListaPorCriterios.SelectParameters("idEjercicio").DefaultValue = idEjercicio
        Me.odsListaPorCriterios.SelectParameters("idEstadoSolicitud").DefaultValue = idEstadoSolicitud
        Me.odsListaPorCriterios.SelectParameters("nombreAccionFormativa").DefaultValue = nombreAccionFormativa
        Me.odsListaPorCriterios.SelectParameters("codigoGrupo").DefaultValue = codigoGrupo
        Me.odsListaPorCriterios.SelectParameters("nombresSolicitante").DefaultValue = nombresSolicitante
        Me.odsListaPorCriterios.SelectParameters("apellidosSolicitante").DefaultValue = apellidosSolicitante
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Me.odsListaPorPARTICIPANTE.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE.ToString()
        Me.odsListaPorPARTICIPANTE.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorACCION_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorACCION_FORMATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal) As Integer
        Me.odsListaPorESTADO_SOLICITUD.SelectParameters("ID_ESTADO_SOLICITUD").DefaultValue = ID_ESTADO_SOLICITUD.ToString()
        Me.odsListaPorESTADO_SOLICITUD.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorESTADO_SOLICITUD.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorESTADO_SOLICITUD.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorESTADO_SOLICITUD.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorESTADO_SOLICITUD.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_SOLICITUD"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla TIPO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal) As Integer
        Me.odsListaPorTIPO_SOLICITUD.SelectParameters("ID_TIPO_SOLICITUD").DefaultValue = ID_TIPO_SOLICITUD.ToString()
        Me.odsListaPorTIPO_SOLICITUD.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_SOLICITUD.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_SOLICITUD.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_SOLICITUD.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_SOLICITUD.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_SOLICITUD"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla EDUC_LEE_ESCRIBE
    ''' </summary>
    ''' <param name="ID_LEE_ESCRIBE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEDUC_LEE_ESCRIBE(ByVal ID_LEE_ESCRIBE As Decimal) As Integer
        Me.odsListaPorEDUC_LEE_ESCRIBE.SelectParameters("ID_LEE_ESCRIBE").DefaultValue = ID_LEE_ESCRIBE.ToString()
        Me.odsListaPorEDUC_LEE_ESCRIBE.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorEDUC_LEE_ESCRIBE.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorEDUC_LEE_ESCRIBE.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorEDUC_LEE_ESCRIBE.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorEDUC_LEE_ESCRIBE.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorEDUC_LEE_ESCRIBE"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla TIEMPO_DEJO_ESTUDIAR
    ''' </summary>
    ''' <param name="ID_TIEMPO_DEJO_ESTUDIAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal) As Integer
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.SelectParameters("ID_TIEMPO_DEJO_ESTUDIAR").DefaultValue = ID_TIEMPO_DEJO_ESTUDIAR.ToString()
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIEMPO_DEJO_ESTUDIAR.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIEMPO_DEJO_ESTUDIAR"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' filtrado por la tabla REFERENCIA
    ''' </summary>
    ''' <param name="ID_REFERENCIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorREFERENCIA(ByVal ID_REFERENCIA As Decimal) As Integer
        Me.odsListaPorREFERENCIA.SelectParameters("ID_REFERENCIA").DefaultValue = ID_REFERENCIA.ToString()
        Me.odsListaPorREFERENCIA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorREFERENCIA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorREFERENCIA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorREFERENCIA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorREFERENCIA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorREFERENCIA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        CargarDatosViaCallback()
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
                keyValues(i) = grid.GetRowValues(i, "ID_SOLICITUD")
                keyNames(i) = grid.GetRowValues(i, "FECHA_PRESENTACION")
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
        If Not Me.PermitirEditar AndAlso Not Me.PermitirSeleccionar Then
            Me.dxgvLista.Columns("Seleccion_Edicion").Visible = False
        Else
            Me.dxgvLista.Columns("Seleccion_Edicion").Visible = True
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
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
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEditar AndAlso dxgvLista.Columns("Seleccion_Edicion").Visible Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar AndAlso dxgvLista.Columns("Seleccion_Edicion").Visible Then
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

    Public Function DevolverSeleccionados() As listaSOLICITUD_INSCRIPCION_AF
        Dim mLista As New listaSOLICITUD_INSCRIPCION_AF
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_SOLICITUD")
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
            lEntidad.ID_SOLICITUD = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        Dim lEntidad As SOLICITUD_INSCRIPCION_AF = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLICITUD_INSCRIPCION_AF)

        Select Case e.ButtonID
            Case "btnEliminar"
                If Me.mComponente.EliminarSOLICITUD_INSCRIPCION_AF(lEntidad.ID_SOLICITUD) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Eliminar Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "btnAprobar"
                'Verificar si la cuota de capacitación del participante ha sobrepasado para el ejercicio actual
                Dim eAccionFormativa As ACCION_FORMATIVA
                Dim eAccionFormativaDetalle As ACCION_FORMATIVA_DETALLE
                Dim eTermino As TERMINO_REFERENCIA_AF

                eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                eAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lEntidad.ID_ACCION_FORMATIVA)
                eTermino = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(eAccionFormativa.ID_ACCION_FORMATIVA)


                If eAccionFormativa.ID_ACCION_FORMATIVA > 0 AndAlso eAccionFormativaDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                    Dim bProgramaFormacion As New cPROGRAMA_FORMACION
                    Dim bAccionFormativa As New cACCION_FORMATIVA
                    Dim inversionTotal As New Dictionary(Of String, Decimal)
                    Dim montoApoyo As Decimal = bProgramaFormacion.ObtenerMontoApoyoParticipantePorPrograma(eAccionFormativaDetalle.ID_PROGRAMA_FORMACION)

                    inversionTotal = bAccionFormativa.ObtenerMontoCapacitacionHTP(lEntidad.ID_PARTICIPANTE, eAccionFormativa.ID_EJERCICIO)
                    If inversionTotal IsNot Nothing AndAlso (inversionTotal("MONTO") + eAccionFormativa.COSTO_X_PARTICIPANTE) > montoApoyo AndAlso (inversionTotal("MONTO") > 0) Then
                        Me.dxgvLista.JSProperties.Clear()
                        Me.dxgvLista.JSProperties.Add("cpResultCallback", "ParticipanteSobrepasaCuota")
                        Me.dxgvLista.JSProperties.Add("cpIdParticipante", lEntidad.ID_PARTICIPANTE)
                        Me.dxgvLista.JSProperties.Add("cpIdEjercicio", eAccionFormativa.ID_EJERCICIO)
                        Return
                    End If
                End If

                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Aprobar Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "btnEspera"
                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeCupo
                lEntidad.LASTUPDATE = Now
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Colocar en Espera de Cupo el Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If
        End Select
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEditar" OrElse e.ButtonID = "btnAprobar" OrElse e.ButtonID = "btnRechazar" OrElse _
           e.ButtonID = "btnEspera" OrElse e.ButtonID = "btnAnular" OrElse e.ButtonID = "btnCambiarDeGrupo" OrElse e.ButtonID = "btnDesertar" OrElse _
           e.ButtonID = "btnVerReporte" OrElse e.ButtonID = "btnRevertirEstado" Then

            If e.CellType = DevExpress.Web.ASPxGridView.GridViewTableCommandCellType.Data Then
                Dim lEntidad As SOLICITUD_INSCRIPCION_AF = CType(Me.dxgvLista.GetRow(e.VisibleIndex), SOLICITUD_INSCRIPCION_AF)

                If lEntidad IsNot Nothing Then
                    Dim eAccionFormativa As New ACCION_FORMATIVA
                    Dim lExisteDevolucionInforme As Boolean = False
                    Dim lExisteInformeEmitido As Boolean = False
                    Dim lidProgramaFormacion As Decimal
                    Dim lInformesDevueltos As listaINFORME_FINAL_AF
                    Dim lInformesEmitidos As listaINFORME_FINAL_AF

                    eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)

                    lidProgramaFormacion = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(lEntidad.ID_ACCION_FORMATIVA)
                    lInformesDevueltos = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(eAccionFormativa.ID_ACCION_FORMATIVA, Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones)
                    If lInformesDevueltos IsNot Nothing AndAlso lInformesDevueltos.Count > 0 Then lExisteDevolucionInforme = True
                    lInformesEmitidos = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(eAccionFormativa.ID_ACCION_FORMATIVA, Enumeradores.EstadoInformeFinal.Emitido)
                    If lInformesEmitidos IsNot Nothing AndAlso lInformesEmitidos.Count > 0 Then lExisteInformeEmitido = True

                    Select Case e.ButtonID
                        Case "btnEditar"
                            If (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada OrElse _
                                (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada AndAlso _
                                lExisteDevolucionInforme OrElse lExisteInformeEmitido)) AndAlso _
                                (lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion OrElse _
                                 lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse _
                                 lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada) AndAlso _
                                 Not Utilerias.EsProgramaPATI(lidProgramaFormacion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If

                        Case "btnAprobar"
                            If (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada) AndAlso _
                                (lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If

                        Case "btnRechazar", "btnEspera"
                            If eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula AndAlso _
                                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If

                        Case "btnAnular", "btnDesertar"
                            If (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada OrElse _
                                (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada AndAlso _
                                (lExisteDevolucionInforme OrElse lExisteInformeEmitido))) AndAlso _
                                (lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse _
                                 lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada) AndAlso _
                                 Not Utilerias.EsProgramaPATI(lidProgramaFormacion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If
                        Case "btnCambiarDeGrupo"
                            If (eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada OrElse _
                                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada) AndAlso _
                                (lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse _
                                 lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada) AndAlso _
                                 Utilerias.EsProgramaPATI(lidProgramaFormacion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If

                        Case "btnVerReporte"
                            If Not Utilerias.EsProgramaPATI(lidProgramaFormacion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If

                        Case "btnRevertirEstado"
                            If (EstaEnRol(RolUsuario.Administrador) OrElse (EstaEnRol(RolDeUsuario.CoordinadorGFI))) AndAlso _
                                (lEntidad.ID_ESTADO_SOLICITUD = EstadoSolicitud.EnEsperaDeCupo OrElse _
                                lEntidad.ID_ESTADO_SOLICITUD = EstadoSolicitud.CambioDeCurso OrElse _
                                lEntidad.ID_ESTADO_SOLICITUD = EstadoSolicitud.Anulada OrElse _
                                lEntidad.ID_ESTADO_SOLICITUD = EstadoSolicitud.Rechazada OrElse _
                                lEntidad.ID_ESTADO_SOLICITUD = EstadoSolicitud.Desercion) Then
                                e.Visible = DevExpress.Utils.DefaultBoolean.True
                            Else
                                e.Visible = DevExpress.Utils.DefaultBoolean.False
                            End If
                    End Select
                End If
            End If
        Else
            If e.ButtonID = "btnEliminar" Then
                e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Select Case e.Column.FieldName
            Case "NOMBRE_ACCION_FORMATIVA"
                If Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible Then
                    Dim eACCION_FORMATIVA As ACCION_FORMATIVA
                    eACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA").ToString)
                    If eACCION_FORMATIVA IsNot Nothing Then e.Value = eACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA
                End If

            Case "CODIGO_GRUPO"
                If Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible Then
                    Dim eACCION_FORMATIVA As ACCION_FORMATIVA
                    eACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA").ToString)
                    If eACCION_FORMATIVA IsNot Nothing Then e.Value = eACCION_FORMATIVA.CODIGO_GRUPO
                End If

            Case "NOMBRE_SITIO"
                If Me.dxgvLista.Columns("NOMBRE_SITIO").Visible Then
                    Dim eACCION_FORMATIVA As ACCION_FORMATIVA
                    Dim ID_Sitio_Capacitacion As Decimal = 0

                    eACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA").ToString)
                    If eACCION_FORMATIVA IsNot Nothing Then ID_Sitio_Capacitacion = eACCION_FORMATIVA.ID_SITIO_CAPACITACION

                    If ID_Sitio_Capacitacion > 0 Then
                        Dim eSITIO_CAPACITACION As SITIO_CAPACITACION
                        eSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(ID_Sitio_Capacitacion)
                        If eSITIO_CAPACITACION IsNot Nothing Then e.Value = eSITIO_CAPACITACION.NOMBRE_SITIO
                    End If
                End If

            Case "ESTADO_SOLICITUD"
                If Me.dxgvLista.Columns("ESTADO_SOLICITUD").Visible Then
                    Dim eESTADO_SOLICITUD As ESTADO_SOLICITUD
                    eESTADO_SOLICITUD = (New cESTADO_SOLICITUD).ObtenerESTADO_SOLICITUD(e.GetListSourceFieldValue("ID_ESTADO_SOLICITUD").ToString)
                    If eESTADO_SOLICITUD IsNot Nothing Then e.Value = eESTADO_SOLICITUD.ESTADO_SOLICITUD
                End If

            Case "OBSERVACION"
                If Me.dxgvLista.Columns("ESTADO_SOLICITUD").Visible Then
                    Dim ePARTICIPANTE_AF As PARTICIPANTE_AF

                    ePARTICIPANTE_AF = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(e.GetListSourceFieldValue("ID_PARTICIPANTE").ToString, e.GetListSourceFieldValue("ID_ACCION_FORMATIVA").ToString)
                    If ePARTICIPANTE_AF IsNot Nothing Then e.Value = ePARTICIPANTE_AF.NOTAS
                End If

            Case "CORRELATIVO"
                e.Value = e.ListSourceRowIndex + 1
        End Select
    End Sub

    Private Sub CargarDatosViaCallback()
        If hf.Contains("CargarDatos") Then
            Select Case hf("CargarDatos")
                Case "CargarDatos"
                    Me.CargarDatos()

                Case "CargarDatosPorCriterios"
                    Me.CargarDatosPorCriterios(Decimal.Parse(hf("param1")), _
                                       Decimal.Parse(hf("param2")), _
                                       Decimal.Parse(hf("param3")), _
                                       hf("param4"), _
                                       hf("param5"), _
                                       hf("param6"), _
                                       hf("param7"), _
                                       hf("param8"), _
                                       hf("param9"))

                Case "CargarDatosPorAccionFormativa"
                    Me.CargarDatosPorACCION_FORMATIVA(Decimal.Parse(hf("param1")))

                Case "CargarDatosPorParticipante"
                    Me.CargarDatosPorPARTICIPANTE(Decimal.Parse(hf("param1")))
            End Select
        End If
    End Sub

    Protected Sub cbpucListaSOLICITUD_INSCRIPCION_AF_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbpucListaSOLICITUD_INSCRIPCION_AF.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        Dim sResult As String = ""

        Select Case parametros(0)
            Case "CargarDatos"
                If hf.Contains("CargarDatos") Then hf("CargarDatos") = parametros(1) Else hf.Add("CargarDatos", parametros(1))
                For i As Integer = 2 To parametros.Length - 1
                    If hf.Contains("param" + (i - 1).ToString) Then hf.Remove("param" + (i - 1).ToString)
                    hf.Add("param" + (i - 1).ToString, parametros(i))
                Next
                CargarDatosViaCallback()

            Case "Rechazar"
                Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
                lEntidad = CType(Me.dxgvLista.GetRow(Int32.Parse(parametros(1))), SOLICITUD_INSCRIPCION_AF)
                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Rechazada
                lEntidad.LASTUPDATE = Now
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica, parametros(2)) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Rechazar Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "Anular"
                Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
                lEntidad = CType(Me.dxgvLista.GetRow(Int32.Parse(parametros(1))), SOLICITUD_INSCRIPCION_AF)
                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Anulada
                lEntidad.LASTUPDATE = Now
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica, parametros(2)) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Anular Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "Desertar"
                Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
                lEntidad = CType(Me.dxgvLista.GetRow(Int32.Parse(parametros(1))), SOLICITUD_INSCRIPCION_AF)
                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Desercion
                lEntidad.LASTUPDATE = Now
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica, parametros(2)) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Anular Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "CambiarDeGrupo"
                Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
                lEntidad = CType(Me.dxgvLista.GetRow(Int32.Parse(parametros(1))), SOLICITUD_INSCRIPCION_AF)
                lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.CambioDeCurso
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica, parametros(2)) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Cambiar de Grupo el Registro", True, True)
                Else
                    Me.dxgvLista.DataBind()
                End If

            Case "Revertir"
                Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
                Dim bAccionFormativa As New cACCION_FORMATIVA
                Dim lAccionFormativa As ACCION_FORMATIVA
                lEntidad = CType(Me.dxgvLista.GetRow(Int32.Parse(parametros(1))), SOLICITUD_INSCRIPCION_AF)
                If lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.CambioDeCurso OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeCupo OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Rechazada OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Desercion OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Anulada Then
                    Dim lParticipanteAF As PARTICIPANTE_AF = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(lEntidad.ID_PARTICIPANTE, lEntidad.ID_ACCION_FORMATIVA)
                    If lParticipanteAF Is Nothing Then
                        lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
                    Else
                        lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
                    End If
                    lEntidad.LASTUPDATE = Now
                End If
                If Me.mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad, TipoConcurrencia.Pesimistica, parametros(2)) <> 1 Then
                    'Si se cometio un error
                    Me.AsignarMensaje("Error al Revertir Registro", True, True)
                Else
                    lAccionFormativa = bAccionFormativa.ObtenerACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                    lAccionFormativa.PARTICIPANTES_INSCRITOS = bAccionFormativa.ObtenerCantidadParticipantesInscritos(lAccionFormativa.ID_ACCION_FORMATIVA)
                    lAccionFormativa.LASTUPDATE = Now
                    bAccionFormativa.ActualizarACCION_FORMATIVA_SIN_VALIDACION2(lAccionFormativa)
                    Me.dxgvLista.DataBind()
                End If
        End Select
    End Sub
End Class
