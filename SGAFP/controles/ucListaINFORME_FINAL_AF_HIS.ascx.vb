Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaINFORME_FINAL_AF_HIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla INFORME_FINAL_AF_HIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaINFORME_FINAL_AF_HIS
    Inherits ucListaBase
 
    Private mComponente As New cINFORME_FINAL_AF_HIS
    Public Event Seleccionado(ByVal ID_INFORME_FINAL_HIS As Decimal) 
    Public Event Editando(ByVal ID_INFORME_FINAL_HIS As Decimal) 

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

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL_HIS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL_HIS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFORME_FINAL_HIS").Visible = Value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible = Value
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

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INFORME() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INFORME").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INFORME").Visible = Value
        End Set
    End Property

    Public Property VerNUMERO_FACTURA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUMERO_FACTURA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUMERO_FACTURA").Visible = Value
        End Set
    End Property

    Public Property VerELABORADO_POR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ELABORADO_POR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ELABORADO_POR").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_FACTURA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_FACTURA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_FACTURA").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_APROBADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_APROBADO").Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_ESTADO_INFORME() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ESTADO_INFORME").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_ESTADO_INFORME").Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_FINALES() As Boolean
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Visible = Value
        End Set
    End Property

    Public Property VerPORC_PROM_ASISTENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_PROM_ASISTENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_PROM_ASISTENCIA").Visible = Value
        End Set
    End Property

    Public Property VerNOTA_PROMEDIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOTA_PROMEDIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOTA_PROMEDIO").Visible = Value
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

    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("COMENTARIOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COMENTARIOS").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_APROBACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_APROBACION").Visible = Value
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

    Public Property VerID_ESTADO_INFORME() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_INFORME").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTADO_INFORME").Visible = Value
        End Set
    End Property

    Public Property VerHORAS_DESARROLLADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORAS_DESARROLLADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORAS_DESARROLLADAS").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INICIAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INICIAL").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FINAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FINAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FINAL").Visible = Value
        End Set
    End Property

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORARIO").Visible = Value
        End Set
    End Property

    Public Property HeaderID_INFORME_FINAL_HIS() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL_HIS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFORME_FINAL_HIS").Caption = Value
        End Set
    End Property

    Public Property HeaderID_INFORME_FINAL() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption = Value
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

    Public Property HeaderID_PROVEEDOR_AF() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INFORME() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INFORME").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INFORME").Caption = Value
        End Set
    End Property

    Public Property HeaderNUMERO_FACTURA() As String
        Get
            Return Me.dxgvLista.Columns("NUMERO_FACTURA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUMERO_FACTURA").Caption = Value
        End Set
    End Property

    Public Property HeaderELABORADO_POR() As String
        Get
            Return Me.dxgvLista.Columns("ELABORADO_POR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ELABORADO_POR").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_FACTURA() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_FACTURA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_FACTURA").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_APROBADO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_APROBADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_APROBADO").Caption = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_INSCRITOS() As String
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Caption = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_FINALES() As String
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_PROM_ASISTENCIA() As String
        Get
            Return Me.dxgvLista.Columns("PORC_PROM_ASISTENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_PROM_ASISTENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderNOTA_PROMEDIO() As String
        Get
            Return Me.dxgvLista.Columns("NOTA_PROMEDIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOTA_PROMEDIO").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO").Caption = Value
        End Set
    End Property

    Public Property HeaderCOMENTARIOS() As String
        Get
            Return Me.dxgvLista.Columns("COMENTARIOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COMENTARIOS").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_APROBACION() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_APROBACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_APROBACION").Caption = Value
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

    Public Property HeaderID_ESTADO_INFORME() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_INFORME").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTADO_INFORME").Caption = Value
        End Set
    End Property

    Public Property HeaderHORAS_DESARROLLADAS() As String
        Get
            Return Me.dxgvLista.Columns("HORAS_DESARROLLADAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HORAS_DESARROLLADAS").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INICIAL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INICIAL").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FINAL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FINAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FINAL").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF_HIS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF_HIS
    ''' filtrado por la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal) As Integer
        Me.odsListaPorINFORME_FINAL_AF.SelectParameters("ID_INFORME_FINAL").DefaultValue = ID_INFORME_FINAL.ToString()
        Me.odsListaPorINFORME_FINAL_AF.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorINFORME_FINAL_AF.SelectParameters("asColumnaOrden").DefaultValue = "ID_INFORME_FINAL_HIS"
        Me.odsListaPorINFORME_FINAL_AF.SelectParameters("asTipoOrden").DefaultValue = "DESC"
        Me.odsListaPorINFORME_FINAL_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorINFORME_FINAL_AF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF_HIS
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
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
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF_HIS
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_AF_HIS
    ''' filtrado por la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_INFORME_AF(ByVal ID_ESTADO_INFORME As Decimal) As Integer
        Me.odsListaPorESTADO_INFORME_AF.SelectParameters("ID_ESTADO_INFORME").DefaultValue = ID_ESTADO_INFORME.ToString()
        Me.odsListaPorESTADO_INFORME_AF.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorESTADO_INFORME_AF.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorESTADO_INFORME_AF.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorESTADO_INFORME_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_INFORME_AF"
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
                keyValues(i) = grid.GetRowValues(i, "ID_INFORME_FINAL_HIS")
                keyNames(i) = grid.GetRowValues(i, "ID_INFORME_FINAL")
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
            If Not Me.PermitirEditar Then
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

    Public Function DevolverSeleccionados() As listaINFORME_FINAL_AF_HIS
        Dim mLista As New listaINFORME_FINAL_AF_HIS
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_INFORME_FINAL_HIS")
            Dim lEntidad As New INFORME_FINAL_AF_HIS
            lEntidad.ID_INFORME_FINAL_HIS = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As INFORME_FINAL_AF_HIS = CType(Me.dxgvLista.GetRow(e.VisibleIndex), INFORME_FINAL_AF_HIS)

            If Me.mComponente.EliminarINFORME_FINAL_AF_HIS(lEntidad.ID_INFORME_FINAL_HIS) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NOMBRE_ESTADO_INFORME" Then
            If e.GetListSourceFieldValue("ID_ESTADO_INFORME") IsNot Nothing Then
                Dim lEntidad As ESTADO_INFORME_AF = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(e.GetListSourceFieldValue("ID_ESTADO_INFORME"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRE_ESTADO_INFORME + " - " + lEntidad.DESCRIPCION_ESTADO
                End If
            End If
        ElseIf e.Column.FieldName = "USUARIO" Then
            If e.GetListSourceFieldValue("USERID") IsNot Nothing Then
                Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USERID"))
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRE
                End If
            End If
        End If
    End Sub
End Class
