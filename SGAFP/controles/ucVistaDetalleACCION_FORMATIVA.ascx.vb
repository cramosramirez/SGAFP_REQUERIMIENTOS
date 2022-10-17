Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Text
Imports SGAFP.DL.DS_DL
Imports System.Collections.Generic

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_FORMATIVA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_ACCION_FORMATIVA As Decimal

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me.txtID_ACCION_FORMATIVA.Text
        End Get
        Set(ByVal Value As Decimal)
            Me.ucProgramacion1.Inicializar()
            Me._ID_ACCION_FORMATIVA = Value
            Me.txtID_ACCION_FORMATIVA.Text = CStr(Value)
            If Me._ID_ACCION_FORMATIVA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(Me._Enabled)
            End If
            Me.trCONTRATO_BOLPROS.Visible = Me.ES_BOLPROS_A_DEMANDA
            Me.trACCION_CONTRATADA.Visible = Me.ES_BOLPROS_A_DEMANDA
            Me.trID_SITIO_CAPACITACION.Visible = Not Me.ES_BOLPROS_A_DEMANDA
            Me.trID_OFERTA_FORMATIVA.Visible = Not Me.ES_BOLPROS_A_DEMANDA
            Me.trAREA_FORMACION.Visible = Not Me.ES_BOLPROS_A_DEMANDA
        End Set
    End Property

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.trHORARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHORARIO.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.lblID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblID_ACCION_FORMATIVA.Visible = value
            Me.txtID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_AREA_FORMACION() As Boolean
        Get
            Return Me.trAREA_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA_FORMACION.Visible = value
        End Set
    End Property

    Public Property VerID_OFERTA_FORMATIVA() As Boolean
        Get
            Return Me.trID_OFERTA_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OFERTA_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me.trID_SITIO_CAPACITACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SITIO_CAPACITACION.Visible = value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.trID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_AF.Visible = value
        End Set
    End Property

    Public Property VerID_TEMA_CURSO() As Boolean
        Get
            Return Me.trID_TEMA_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TEMA_CURSO.Visible = value
        End Set
    End Property

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.ddlEJERCICIO1.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblID_EJERCICIO.Visible = value
            Me.ddlEJERCICIO1.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trNOMBRE_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_GRUPO() As Boolean
        Get
            Return Me.txtCODIGO_GRUPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCODIGO_GRUPO.Visible = value
            Me.txtCODIGO_GRUPO.Visible = value
        End Set
    End Property

    Public Property VerNUMERO_PARTICIPANTES() As Boolean
        Get
            Return Me.txtNUMERO_PARTICIPANTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblNUMERO_PARTICIPANTES.Visible = value
            Me.txtNUMERO_PARTICIPANTES.Visible = value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.trPARTICIPANTES_INSCRITOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPARTICIPANTES_INSCRITOS.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_ESTADO_AF() As Boolean
        Get
            Return Me.ddlESTADO_ACCION_FORMATIVA1.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCODIGO_ESTADO_AF.Visible = value
            Me.ddlESTADO_ACCION_FORMATIVA1.Visible = value
        End Set
    End Property

    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me.txtDURACION_HORAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblDURACION_HORAS.Visible = value
            Me.txtDURACION_HORAS.Visible = value
        End Set
    End Property

    Public Property VerCOSTO_X_PARTICIPANTE() As Boolean
        Get
            Return Me.txtCOSTO_X_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblCOSTO_X_PARTICIPANTE.Visible = value
            Me.txtCOSTO_X_PARTICIPANTE.Visible = value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.lblUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblUSERID.Visible = value
            Me.txtUSERID.Visible = value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.lblLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblLASTUPDATE.Visible = value
            Me.txtLASTUPDATE.Visible = value
        End Set
    End Property

    Public Property PermitirEditarProgramacion() As Boolean
        Get
            Return Me.ucProgramacion1.PermitirEditar
        End Get
        Set(ByVal value As Boolean)
            Me.ucProgramacion1.PermitirEditar = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cACCION_FORMATIVA
    Private mEntidad As ACCION_FORMATIVA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ES_INFORME_FINAL() As Boolean
        Get
            If Me.ViewState("ES_INFORME_FINAL") Is Nothing Then Return False
            Return Me.ViewState("ES_INFORME_FINAL")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("ES_INFORME_FINAL") = value
        End Set
    End Property

    Public Property ES_BOLPROS_A_DEMANDA() As Boolean
        Get
            If Me.ViewState("ES_BOLPROS_A_DEMANDA") Is Nothing Then Return False
            Return Me.ViewState("ES_BOLPROS_A_DEMANDA")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("ES_BOLPROS_A_DEMANDA") = value
        End Set
    End Property

    Public Property ES_CURSO_ONLINE() As Boolean
        Get
            If Me.ViewState("ES_CURSO_ONLINE") Is Nothing Then Return False
            Return Me.ViewState("ES_CURSO_ONLINE")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("ES_CURSO_ONLINE") = value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ACCION_FORMATIVA") Is Nothing Then Me._ID_ACCION_FORMATIVA = Me.ViewState("ID_ACCION_FORMATIVA")
    End Sub


    Private Sub ConfigurarMascaraCodigoCurso(ByVal idProgramaFormacion As Decimal)
        Me.txtCODIGO_GRUPO.Text = ""
        If Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = ModalidadFormacion.CursoConHerramientasTecnologicas Then
            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTEC>->aaaa->000"
            Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
            Exit Sub
        End If
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.ID_ACCION_FORMATIVA)
        If lAccionDetalle IsNot Nothing Then
            Select Case lAccionDetalle.ID_PROGRAMA_FORMACION
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    If ddlSITIO_CAPACITACION1.SelectedValue > 0 AndAlso Not ES_BOLPROS_A_DEMANDA Then
                        Me.txtCODIGO_GRUPO.MaskSettings.Mask = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(Decimal.Parse(ddlSITIO_CAPACITACION1.SelectedValue)).FORMATO_CODIGO_CURSO
                        Me.txtCODIGO_GRUPO.MaskSettings.PromptChar = "#"
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    Else
                        If Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = ModalidadFormacion.CentroFijo Then
                            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPCENTRO>->aaaa->000"
                        Else
                            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPMOVIL>->aaaa->000"
                        End If
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    End If
                Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|PATI>->aaaa->000"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|PROESP>->aaaa->000"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
            End Select

        Else
            Select Case idProgramaFormacion
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|PROESP>->aaaa->000"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    If ddlSITIO_CAPACITACION1.Text <> "" AndAlso Not ES_BOLPROS_A_DEMANDA Then
                        Me.txtCODIGO_GRUPO.MaskSettings.Mask = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(Decimal.Parse(ddlSITIO_CAPACITACION1.SelectedValue)).FORMATO_CODIGO_CURSO
                        Me.txtCODIGO_GRUPO.MaskSettings.PromptChar = "#"
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    Else
                        If Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = ModalidadFormacion.CentroFijo Then
                            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPCENTRO>->aaaa->000"
                        Else
                            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPMOVIL>->aaaa->000"
                        End If
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    End If
                Case Else
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(Decimal.Parse(ddlSITIO_CAPACITACION1.SelectedValue)).FORMATO_CODIGO_CURSO
                    Me.txtCODIGO_GRUPO.MaskSettings.PromptChar = "#"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
            End Select
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Dim idProgramaFormacion As Decimal
        Dim idModalidadFormacion As Decimal

        Dim sError As New String("")
        mEntidad = New ACCION_FORMATIVA
        mEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA

        If mComponente.ObtenerACCION_FORMATIVA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Me.txtID_ACCION_FORMATIVA.Text = mEntidad.ID_ACCION_FORMATIVA.ToString()
        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlEJERCICIO1.SelectedValue = mEntidad.ID_EJERCICIO
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.SelectedValue = mEntidad.ID_PROVEEDOR_AF


        If mEntidad.ID_ACCION_CONTRATADA > 0 Then
            Me.ES_BOLPROS_A_DEMANDA = True
            Me.ES_CURSO_ONLINE = mComponente.EsAccionFormativaOnline(mEntidad.ID_ACCION_FORMATIVA)
        Else
            Me.ES_BOLPROS_A_DEMANDA = False
            Me.ES_CURSO_ONLINE = False
        End If

        idProgramaFormacion = mComponente.ObtenerProgramaFormacionCurso(mEntidad.ID_ACCION_FORMATIVA)
        idModalidadFormacion = mComponente.ObtenerModalidadFormacionCurso(mEntidad.ID_ACCION_FORMATIVA)

        Me.ddlMODALIDAD_DE_FORMACION1.Recuperar()
        If idModalidadFormacion > 0 Then
            Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = idModalidadFormacion
        Else
            Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue = ModalidadFormacion.CentroFijo
        End If

        If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
            Me.ddlSITIO_CAPACITACION1.Recuperar()
            Me.ddlSITIO_CAPACITACION1.SelectedValue = mEntidad.ID_SITIO_CAPACITACION
            Me.ddlAREA_FORMACION1.RecuperarPorOFERTA_FORMATIVA(mEntidad.ID_OFERTA_FORMATIVA)
        Else
            Me.ddlSITIO_CAPACITACION1.Items.Clear()
            Me.ddlSITIO_CAPACITACION1.AgregarVacioNumerico()
            Me.ddlAREA_FORMACION1.Recuperar()
        End If

        Me.txtTEMA_CURSO.Text = mEntidad.ID_TEMA_CURSO

        If mEntidad.ID_ACCION_CONTRATADA <= 0 Then
            Dim mCursoTema As New SGAFP.EL.CURSO_TEMA
            mCursoTema = (New SGAFP.BL.cCURSO_TEMA).ObtenerCURSO_TEMA(mEntidad.ID_TEMA_CURSO)
            Me.ddlAREA_FORMACION1.SelectedValue = mCursoTema.ID_AREA_FORMACION
            If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                Me.ddlOFERTA_FORMATIVA1.RecuperarPorOFERTA_FORMATIVA(mEntidad.ID_OFERTA_FORMATIVA)
                Me.ddlOFERTA_FORMATIVA1.SelectedValue = mEntidad.ID_OFERTA_FORMATIVA
            Else
                Me.ddlOFERTA_FORMATIVA1.Items.Clear()
                Me.ddlOFERTA_FORMATIVA1.AgregarVacioNumerico()
            End If
        Else
            Dim lAccionContra As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(mEntidad.ID_ACCION_CONTRATADA)
            If lAccionContra IsNot Nothing Then
                Dim lContra As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContra.ID_CONTRATO)
                If lContra IsNot Nothing Then

                    If lContra.ID_PROGRAMA_FORMACION = ProgramasFormacion.EMPRESA_CENTRO Then
                        Me.ddlCONTRATO_BOLPROS1.RecuperarPorPROVEEDOR_PROGRAMA_FORMACION(mEntidad.ID_PROVEEDOR_AF, ProgramasFormacion.EMPRESA_CENTRO)
                        Me.ddlCONTRATO_BOLPROS1.SelectedValue = lAccionContra.ID_CONTRATO
                        Me.MostrarAccionContratada()
                        Me.cbxACCION_CONTRATADA.Value = lAccionContra.ID_ACCION_CONTRATADA
                    Else
                        If (lContra.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online OrElse _
                                                  lContra.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante) Then
                            Me.ddlCONTRATO_BOLPROS1.RecuperarPorPROVEEDOR_AF_PAGO_PARTICIPANTE(mEntidad.ID_PROVEEDOR_AF, 1)
                            Me.ddlCONTRATO_BOLPROS1.SelectedValue = lAccionContra.ID_CONTRATO
                            Me.MostrarAccionContratada()
                            Me.cbxACCION_CONTRATADA.Value = lAccionContra.ID_ACCION_CONTRATADA
                        End If
                    End If

                End If
            End If
        End If

        Me.txtNOMBRE_ACCION_FORMATIVA.Text = mEntidad.NOMBRE_ACCION_FORMATIVA
        Me.ConfigurarMascaraCodigoCurso(idProgramaFormacion)
        If mEntidad.HORARIO <> "PENDIENTE DE DEFINIR" Then
            Me.txtCODIGO_GRUPO.Text = mEntidad.CODIGO_GRUPO
        End If
        Me.txtHORARIO.Text = mEntidad.HORARIO
        Me.txtNUMERO_PARTICIPANTES.Text = mEntidad.NUMERO_PARTICIPANTES
        Me.txtPARTICIPANTES_INSCRITOS.Text = mEntidad.PARTICIPANTES_INSCRITOS

        Me.txtCODI_FORMADOR.Text = mEntidad.CODI_FORMADOR
        Me.txtNOMBRE_FORMADOR.Text = mEntidad.NOMBRE_FORMADOR

        Me.ddlESTADO_ACCION_FORMATIVA1.Recuperar()
        Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = mEntidad.CODIGO_ESTADO_AF
        Me.txtDURACION_HORAS.Text = mEntidad.DURACION_HORAS
        Me.txtCOSTO_X_PARTICIPANTE.Text = mEntidad.COSTO_X_PARTICIPANTE.ToString
        Me.txtUSERID.Text = mEntidad.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
        Me.ucProgramacion1.CargarProgramacion(mEntidad.ID_ACCION_FORMATIVA)

        'Cargando datos del lugar de ejecución, departamento y municipio
        Me.txtLUGAR_EJECUCION.Enabled = False
        Me.DdlDEPARTAMENTO1.Enabled = False
        Me.DdlMUNICIPIO1.Enabled = False
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(mEntidad.ID_ACCION_FORMATIVA)
        If lAccionDetalle IsNot Nothing Then
            Me.txtLUGAR_EJECUCION.Text = lAccionDetalle.LUGAR_EJECUCION
            Me.txtLUGAR_EJECUCION.Enabled = True
            Me.DdlDEPARTAMENTO1.Enabled = True
            Me.DdlMUNICIPIO1.Enabled = True
            Me.DdlDEPARTAMENTO1.Recuperar()
            Me.DdlDEPARTAMENTO1.SelectedValue = lAccionDetalle.CODIGO_DEPARTAMENTO
            Me.DdlMUNICIPIO1.SelectedValue = Nothing
            Me.DdlMUNICIPIO1.RecuperarPorDEPARTAMENTO(lAccionDetalle.CODIGO_DEPARTAMENTO)
            If Me.DdlMUNICIPIO1.Items.Count > 0 Then Me.DdlMUNICIPIO1.SelectedValue = lAccionDetalle.CODIGO_MUNICIPIO

            Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(mEntidad.ID_ACCION_FORMATIVA)
            Dim InformeEmitidoDevuelto As Boolean = False
            If lInformes IsNot Nothing AndAlso lInformes.Count > 0 Then
                For Each eInforme As INFORME_FINAL_AF In lInformes
                    If eInforme.ID_ESTADO_INFORME = EstadoInformeFinal.Emitido OrElse eInforme.ID_ESTADO_INFORME = EstadoInformeFinal.InformeDevueltoConObservaciones Then
                        InformeEmitidoDevuelto = True
                    End If
                Next
            End If
            If (lAccionDetalle.ID_MODALIDAD_FORMACION = 2 AndAlso (mEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Ingresada OrElse mEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula)) OrElse _
                (lAccionDetalle.ID_MODALIDAD_FORMACION = 2 AndAlso InformeEmitidoDevuelto AndAlso mEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada) Then
                Me.txtCODI_FORMADOR.ClientEnabled = Not Me.ES_CURSO_ONLINE
                Me.txtNOMBRE_FORMADOR.ClientEnabled = Me.ES_CURSO_ONLINE
                Me.txtLUGAR_EJECUCION.Enabled = True
                Me.DdlDEPARTAMENTO1.Enabled = True
                Me.DdlMUNICIPIO1.Enabled = True
            End If
        End If

        If ID_ACCION_FORMATIVA > 0 Then
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.Enabled = False
            Me.ddlAREA_FORMACION1.Enabled = False
            Me.ddlOFERTA_FORMATIVA1.Enabled = False
            Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = False
            Me.ddlEJERCICIO1.Enabled = False
            Me.txtTEMA_CURSO.Enabled = False
            Me.txtPARTICIPANTES_INSCRITOS.Enabled = False
            Me.txtDURACION_HORAS.Enabled = False
            Me.txtCOSTO_X_PARTICIPANTE.Enabled = False
            Me.ddlMODALIDAD_DE_FORMACION1.Enabled = False
            Me.VerUSERID = True
            Me.VerLASTUPDATE = False
            Me.VerID_TEMA_CURSO = False
            Me.VerUSERID = False
            Me.VerHORARIO = False

            Me.ddlCONTRATO_BOLPROS1.Enabled = False
            Me.cbxACCION_CONTRATADA.Enabled = False

            If idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso lAccionDetalle.ID_MODALIDAD_FORMACION = 2 Then
                Me.DdlDEPARTAMENTO1.Enabled = False
            End If

            If idProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_USAID Or idProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_BM Or mEntidad.ID_SITIO_CAPACITACION = -1 Then
                Me.VerID_SITIO_CAPACITACION = False
                Me.VerID_AREA_FORMACION = False
                Me.VerID_OFERTA_FORMATIVA = False
                Me.VerNOMBRE_ACCION_FORMATIVA = True
                Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = False
                Me.txtNUMERO_PARTICIPANTES.Enabled = False
            Else
                Me.VerID_SITIO_CAPACITACION = True
                Me.VerID_AREA_FORMACION = True
                Me.VerID_OFERTA_FORMATIVA = True
                Me.VerNOMBRE_ACCION_FORMATIVA = False
                Me.txtNUMERO_PARTICIPANTES.Enabled = True
            End If
        End If

        If Me.ES_INFORME_FINAL Then
            'Me.txtCODIGO_GRUPO.Enabled = False
            Me.txtNUMERO_PARTICIPANTES.Enabled = False
            Me.ddlMODALIDAD_DE_FORMACION1.Enabled = True
        End If

        If (Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI)) AndAlso _
            mEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Ingresada Then
            Dim lGrupos As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(mEntidad.ID_ACCION_FORMATIVA)
            If lGrupos IsNot Nothing AndAlso lGrupos.Count > 0 Then
                Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = True
                Me.txtDURACION_HORAS.Enabled = True
                Me.ucProgramacion1.Visible = False
                Me.trCODIGO_GRUPO_NUMERO_PARTICIPANTES.Visible = False
                Me.trLUGAR_EJECUCION.Visible = False
                Me.trDEPARTAMENTO.Visible = False
                Me.trMUNICIPIO.Visible = False
                Me.trCODIGO_ESTADO_AF_ID_EJERCICIO.Visible = False
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlAREA_FORMACION1.Enabled = edicion
        Me.ddlOFERTA_FORMATIVA1.Enabled = edicion
        Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = edicion
        Me.txtCODIGO_GRUPO.Enabled = edicion
        Me.txtHORARIO.Enabled = edicion
        Me.txtNUMERO_PARTICIPANTES.Enabled = edicion
        Me.txtCODI_FORMADOR.Enabled = edicion AndAlso Me.txtCODI_FORMADOR.Text = ""
        Me.txtUSERID.Enabled = edicion
        Me.ddlMODALIDAD_DE_FORMACION1.Enabled = edicion
        Me.txtLUGAR_EJECUCION.Enabled = Not Me._nuevo
        Me.DdlDEPARTAMENTO1.Enabled = Not Me._nuevo
        Me.DdlMUNICIPIO1.Enabled = Not Me._nuevo

        If Me.ES_CURSO_ONLINE Then
            Me.txtCODI_FORMADOR.Enabled = False
            Me.txtNOMBRE_FORMADOR.ClientEnabled = True
        End If
    End Sub

    Private Sub AsignarLugarEjecucionPorCentro(ByVal ID_SITIO_CAPACITACION As Decimal)
        Dim lCentro As SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(ID_SITIO_CAPACITACION)
        If lCentro IsNot Nothing Then
            Me.txtLUGAR_EJECUCION.Text = lCentro.DIRECCION
            Me.DdlDEPARTAMENTO1.Recuperar()
            If lCentro.CODIGO_DEPARTAMENTO <> "" Then
                Me.DdlDEPARTAMENTO1.SelectedValue = lCentro.CODIGO_DEPARTAMENTO
                Me.DdlMUNICIPIO1.RecuperarPorDEPARTAMENTO(lCentro.CODIGO_DEPARTAMENTO)
                Me.DdlMUNICIPIO1.SelectedValue = lCentro.CODIGO_MUNICIPIO
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.ddlMODALIDAD_DE_FORMACION1.Recuperar()
        Me.ddlEJERCICIO1.Recuperar()
        SeleccionarEjercicioActual()

        If Me.EstaEnRol("Administrador") Then
            Me.ddlPROVEEDOR_AF1.RecuperarPorPROVEEDOR_HTP()
            MostrarCentrosFormacion()

        ElseIf Me.EstaEnRol("Proveedor") Then
            Me.ddlPROVEEDOR_AF1.Recuperar()
            Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF.ToString
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.Enabled = True
            Me.ddlEJERCICIO1.Enabled = False
            Me.txtLUGAR_EJECUCION.Enabled = False
            Me.DdlDEPARTAMENTO1.Enabled = False
            Me.DdlMUNICIPIO1.Enabled = False

        ElseIf Me.EstaEnRol("CentroCapacitador") Then
            Me.ddlPROVEEDOR_AF1.Recuperar()
            Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF.ToString
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.SelectedValue = Me.ObtenerIdSitioCapacitacion.ToString
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.Enabled = False
            Me.ddlEJERCICIO1.Enabled = False
            Me.txtLUGAR_EJECUCION.Enabled = False
            Me.DdlDEPARTAMENTO1.Enabled = False
            Me.DdlMUNICIPIO1.Enabled = False
            AsignarLugarEjecucionPorCentro(Me.ObtenerIdSitioCapacitacion)
        End If

        Me.ddlOFERTA_FORMATIVA1.Enabled = True
        Me.ddlAREA_FORMACION1.Enabled = True
        If Not ES_BOLPROS_A_DEMANDA Then
            Me.ddlAREA_FORMACION1.RecuperarPorProveedorEjercicio(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ddlEJERCICIO1.SelectedValue)
            MostrarOfertas()

            Me.ConfigurarMascaraCodigoCurso(Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
        End If
        Me.ddlESTADO_ACCION_FORMATIVA1.Recuperar()
        Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = Enumeradores.EstadoAccionFormativa.Ingresada



        Me.txtCODIGO_GRUPO.Text = ""

        Me.txtPARTICIPANTES_INSCRITOS.Enabled = False
        Me.txtPARTICIPANTES_INSCRITOS.Text = "0"
        Me.txtNUMERO_PARTICIPANTES.Text = "20"
        Me.txtCODI_FORMADOR.Text = ""
        Me.txtNOMBRE_FORMADOR.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")

        Me.txtLUGAR_EJECUCION.Enabled = False
        Me.DdlDEPARTAMENTO1.Enabled = False
        Me.DdlMUNICIPIO1.Enabled = False
        Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = False
        Me.txtTEMA_CURSO.Enabled = False
        Me.txtDURACION_HORAS.Enabled = False
        Me.txtCOSTO_X_PARTICIPANTE.Enabled = False
        Me.VerID_SITIO_CAPACITACION = True
        Me.VerID_AREA_FORMACION = True
        Me.VerID_OFERTA_FORMATIVA = True
        Me.VerNOMBRE_ACCION_FORMATIVA = False
        Me.VerUSERID = True
        Me.VerLASTUPDATE = False
        Me.VerID_TEMA_CURSO = False
        Me.VerUSERID = False
        Me.VerHORARIO = False

        If Me.ES_BOLPROS_A_DEMANDA Then
            Me.ddlPROVEEDOR_AF1.Recuperar()
            If Not Me.EstaEnRol("Administrador") Then
                Me.ddlPROVEEDOR_AF1.Enabled = False
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF.ToString
                Me.ddlCONTRATO_BOLPROS1.RecuperarPorPROVEEDOR_AF_PAGO_PARTICIPANTE(Me.ddlPROVEEDOR_AF1.SelectedValue, 1)
                If Me.ddlCONTRATO_BOLPROS1.Items.Count > 0 Then
                    Me.ddlCONTRATO_BOLPROS1.SelectedValue = Nothing
                    Me.cbxACCION_CONTRATADA.Value = Nothing
                    Me.ddlCONTRATO_BOLPROS1_SelectedIndexChanged(Me, New System.EventArgs)
                End If
                Me.ddlEJERCICIO1.Enabled = False
                Me.MostrarAccionContratada()
                Me.MostrarInfoAccionContratada()
            End If

        End If
        Me.ucProgramacion1.Limpiar()
        Me.ucProgramacion1.Inicializar()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Alerta."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	14/04/2010	Se agrego que los campos NOMBRE_ACCION_FORMATIVA, 
    '''                             CODIGO_GRUPO, HORARIO y NOTAS se convirtiera el texto
    '''                             ingresado por el usuario a Mayusculas.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim lContratoBolpros As CONTRATO_BOLPROS = Nothing
        mEntidad = New ACCION_FORMATIVA

        If Not Me._nuevo AndAlso Me.txtDURACION_HORAS.Enabled AndAlso Me.txtNOMBRE_ACCION_FORMATIVA.Enabled Then
            Dim sComentario As New StringBuilder("CAMBIO DE NOMBRE/DURACION POR: ")
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario)

            mEntidad = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(CInt(Me.txtID_ACCION_FORMATIVA.Text))
            mEntidad.NOMBRE_ACCION_FORMATIVA = Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper
            mEntidad.DURACION_HORAS = CInt(Me.txtDURACION_HORAS.Text)
            mEntidad.USERID = Me.ObtenerUsuario()
            mEntidad.LASTUPDATE = Now

            If lUsuario IsNot Nothing Then sComentario.Append(lUsuario.NOMBRE)
            sComentario.Append(" FECHA:" + Now.ToString("dd/MM/yyyy HH:mm"))

            If mComponente.ActualizarACCION_FORMATIVA_SIN_VALIDACION(mEntidad, sComentario.ToString) <> 1 Then
                Me.AsignarMensaje("Alerta. " & vbCrLf & mComponente.sError, True, True)
                Return "Alerta." & vbCrLf & mComponente.sError
            End If
            Return ""
        End If

        If Not (Me.txtCODIGO_GRUPO.IsValid AndAlso IsNumeric(Right(Me.txtCODIGO_GRUPO.Text, 3)) AndAlso Int32.Parse(Right(Me.txtCODIGO_GRUPO.Text, 3)) > 0) AndAlso Me.ddlSITIO_CAPACITACION1.SelectedItem.Value <> -1 Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "El Codigo de Curso no es valido. El correlativo debe tener 3 digitos, Ej: 001, 002, 003...", True, True)
            Return "Alerta."
        End If
        If Not Me.txtCODIGO_GRUPO.IsValid Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Horario del Curso es requerido", True, True)
            Return "Alerta."
        End If
        If Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue Is Nothing Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Debe seleccionar la modalidad para el Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucProgramacion1.dtASISTENCIA_AF.Rows.Count = 0 Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Debe ingresar una Programación para el Curso", True, True)
            Return "Alerta."
        End If
        If Me.txtNUMERO_PARTICIPANTES.Text = "" Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Debe ingresar un numero de estimado de participantes a capacitar", True, True)
            Return "Alerta."
        End If
        If Me.ucProgramacion1.FECHA_INICIO_REAL Is Nothing Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe una Fecha de Inicio en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucProgramacion1.FECHA_FIN_REAL Is Nothing Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe una Fecha de Finalizacion en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucProgramacion1.HORARIO_REAL.Trim = "" Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe un Horario en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucProgramacion1.MINUTOS_TOTALES <> (Decimal.Parse(Me.txtDURACION_HORAS.Text) * 60) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Las Horas Totales de la Programacion deben ser igual a la Duracion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ES_BOLPROS_A_DEMANDA AndAlso (Me.ddlCONTRATO_BOLPROS1.SelectedValue Is Nothing OrElse Me.cbxACCION_CONTRATADA.Value Is Nothing OrElse Not IsNumeric(Me.cbxACCION_CONTRATADA.Value)) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Seleccione un programa bolpros", True, True)
            Return "Alerta."
        End If

        If ES_BOLPROS_A_DEMANDA Then
            lContratoBolpros = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(Me.ddlCONTRATO_BOLPROS1.SelectedValue)
        End If

        If Me._nuevo Then
            mEntidad.ID_ACCION_FORMATIVA = 0
        Else
            mEntidad = mComponente.ObtenerACCION_FORMATIVA(CInt(Me.txtID_ACCION_FORMATIVA.Text))
        End If

        If Not Me.ES_CURSO_ONLINE Then
            If Me._nuevo Then
                If Me.txtCODI_FORMADOR.Text.Trim = "" Then
                    Me.AsignarMensaje("Alerta. " & vbCrLf & "NIT del formador es requerido", True, True)
                    Return "Alerta."
                End If
            Else
                If mEntidad.CODIGO_ESTADO_AF = EstadoAccionFormativa.Ingresada OrElse mEntidad.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnMatricula Then
                    If Me.txtCODI_FORMADOR.Text.Trim = "" Then
                        Me.AsignarMensaje("Alerta. " & vbCrLf & "NIT del formador es requerido", True, True)
                        Return "Alerta."
                    End If
                End If
            End If
        Else
            If Me.txtNOMBRE_FORMADOR.Text.Trim = "" Then
                Me.AsignarMensaje("Alerta. " & vbCrLf & "Ingrese el nombre del formador", True, True)
                Return "Alerta."
            End If
        End If

        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AF1.SelectedValue
        mEntidad.ID_EJERCICIO = CDate(Me.ucProgramacion1.FECHA_INICIO_REAL).Year.ToString
        mEntidad.NOMBRE_ACCION_FORMATIVA = Me.txtNOMBRE_ACCION_FORMATIVA.Text.ToUpper
        mEntidad.CODIGO_GRUPO = Me.txtCODIGO_GRUPO.Text.ToUpper
        mEntidad.NUMERO_PARTICIPANTES = Val(Me.txtNUMERO_PARTICIPANTES.Text)
        mEntidad.PARTICIPANTES_INSCRITOS = Val(Me.txtPARTICIPANTES_INSCRITOS.Text)
        mEntidad.FECHA_INICIO = CDate(Me.ucProgramacion1.FECHA_INICIO_REAL)
        mEntidad.FECHA_INICIO_REAL = CDate(Me.ucProgramacion1.FECHA_INICIO_REAL)
        mEntidad.FECHA_FIN = CDate(Me.ucProgramacion1.FECHA_FIN_REAL)
        mEntidad.FECHA_FIN_REAL = CDate(Me.ucProgramacion1.FECHA_FIN_REAL)
        mEntidad.HORARIO = Me.ucProgramacion1.HORARIO_REAL
        mEntidad.NOTAS = Me.txtNOMBRE_FORMADOR.Text
        mEntidad.CODI_FORMADOR = Me.txtCODI_FORMADOR.Text
        mEntidad.NOMBRE_FORMADOR = Me.txtNOMBRE_FORMADOR.Text
        mEntidad.CODIGO_ESTADO_AF = Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue
        mEntidad.DURACION_HORAS = Val(Me.txtDURACION_HORAS.Text)
        mEntidad.COSTO_X_PARTICIPANTE = Val(Me.txtCOSTO_X_PARTICIPANTE.Text)
        mEntidad.USERID = Me.ObtenerUsuario()

        If Me.ES_BOLPROS_A_DEMANDA Then
            mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AF1.SelectedValue
            mEntidad.ID_OFERTA_FORMATIVA = -1
            mEntidad.ID_SITIO_CAPACITACION = -1
            mEntidad.ID_TEMA_CURSO = -1
            If Me._nuevo Then
                Dim lAccionContra As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(Me.cbxACCION_CONTRATADA.Value)

                If lAccionContra IsNot Nothing Then
                    Dim listaTemas As listaCURSO_TEMA = (New cCURSO_TEMA).ObtenerListaPorCODIGO_PROGRAMA(lAccionContra.CODIGO_PROGRAMA)
                    If listaTemas IsNot Nothing AndAlso listaTemas.Count > 0 Then
                        mEntidad.ID_TEMA_CURSO = listaTemas(0).ID_TEMA_CURSO
                    End If

                    If mEntidad.ID_TEMA_CURSO = -1 Then
                        Dim lCursoTema As New CURSO_TEMA
                        Dim bCursoTema As New cCURSO_TEMA
                        Dim lPrograma As SIFP.EL.Programas

                        lCursoTema.ID_AREA_FORMACION = -1

                        lPrograma = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccionContra.CODIGO_PROGRAMA.Trim)
                        If lPrograma IsNot Nothing Then
                            Dim lArea As SIFP.EL.Areas
                            Dim bAreaFormacion As New cAREA_FORMACION
                            Dim lstAreaFormacion As listaAREA_FORMACION


                            lArea = (New SIFP.BL.cAreas).ObtenerAreas(lPrograma.codigo_area)
                            If lArea IsNot Nothing Then
                                'Verificar si existe el area formativa
                                lstAreaFormacion = (New cAREA_FORMACION).ObtenerListaPorNOMBRE(lArea.descripcion)
                                If lstAreaFormacion IsNot Nothing AndAlso lstAreaFormacion.Count > 0 Then
                                    lCursoTema.ID_AREA_FORMACION = lstAreaFormacion(0).ID_AREA_FORMACION
                                Else
                                    'Crear Area
                                    Dim lAreaFormacion As New AREA_FORMACION
                                    lAreaFormacion.ID_AREA_FORMACION = 0
                                    lAreaFormacion.AREA_FORMACION = lArea.descripcion.Trim.ToUpper
                                    lAreaFormacion.NOTAS = Nothing
                                    lAreaFormacion.CODIGO_AREA = lArea.codigo_area.Trim
                                    lAreaFormacion.USERID = Me.ObtenerUsuario
                                    lAreaFormacion.LASTUPDATE = Now

                                    bAreaFormacion.ActualizarAREA_FORMACION(lAreaFormacion)
                                    lCursoTema.ID_AREA_FORMACION = lAreaFormacion.ID_AREA_FORMACION
                                End If
                            End If

                        End If
                        'Crear tema curso
                        lCursoTema.ID_TEMA_CURSO = 0
                        lCursoTema.ID_SUBAREA_FORMACION = -1
                        lCursoTema.TEMA_CURSO = Me.txtNOMBRE_ACCION_FORMATIVA.Text.ToUpper
                        lCursoTema.DURACION_HORAS = mEntidad.DURACION_HORAS
                        lCursoTema.FECHA_ACREDITACION = Today
                        lCursoTema.NOTAS = ""
                        lCursoTema.CODIGO_PROGRAMA = lAccionContra.CODIGO_PROGRAMA.Trim
                        lCursoTema.REF_ID_TEMA_CURSO = -1
                        lCursoTema.USERID = Me.ObtenerUsuario
                        lCursoTema.LASTUPDATE = Now

                        bCursoTema.ActualizarCURSO_TEMA(lCursoTema)
                        mEntidad.ID_TEMA_CURSO = lCursoTema.ID_TEMA_CURSO
                    End If
                End If
            End If
            mEntidad.ID_ACCION_CONTRATADA = Me.cbxACCION_CONTRATADA.Value
        Else
            mEntidad.ID_OFERTA_FORMATIVA = Me.ddlOFERTA_FORMATIVA1.SelectedValue
            mEntidad.ID_SITIO_CAPACITACION = Me.ddlSITIO_CAPACITACION1.SelectedValue
            mEntidad.ID_TEMA_CURSO = Me.txtTEMA_CURSO.Text
            mEntidad.ID_ACCION_CONTRATADA = -1
        End If

        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If (Not Me._nuevo AndAlso Me.txtCODI_FORMADOR.Text.Trim <> "") Then
            'Validar que el horario de la programación no esté conflicto con otro horario del formador
            Dim sErrorVal As String = Me.ucProgramacion1.ValidarHorarioParaFormador(Me.ID_ACCION_FORMATIVA, Me.txtCODI_FORMADOR.Text.Trim, mEntidad.ID_PROVEEDOR_AF, mEntidad.ID_EJERCICIO, mEntidad.CODIGO_GRUPO)
            If sErrorVal <> "" Then
                Me.AsignarMensaje("Alerta. " & vbCrLf & sErrorVal, True, True)
                Return "Alerta." & vbCrLf & sErrorVal
            Else
                Me.ucProgramacion1.Actualizar(mEntidad.ID_ACCION_FORMATIVA, Me._nuevo)
            End If
        End If

        If mComponente.ActualizarACCION_FORMATIVA(mEntidad, TipoConcurrencia.Pesimistica, False, False, False) <> 1 Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & mComponente.sError, True, True)
            Return "Alerta." & vbCrLf & mComponente.sError
        End If

        Dim lAccionFormativaDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(mEntidad.ID_ACCION_FORMATIVA)
        Dim bAccionFormativaDetalle As New cACCION_FORMATIVA_DETALLE
        If lAccionFormativaDetalle IsNot Nothing Then
            lAccionFormativaDetalle.ID_MODALIDAD_FORMACION = Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue
            lAccionFormativaDetalle.LUGAR_EJECUCION = Me.txtLUGAR_EJECUCION.Text.Trim.ToUpper
            lAccionFormativaDetalle.CODIGO_DEPARTAMENTO = DdlDEPARTAMENTO1.SelectedValue
            lAccionFormativaDetalle.CODIGO_MUNICIPIO = DdlMUNICIPIO1.SelectedValue
            lAccionFormativaDetalle.LASTUPDATE = Now
            lAccionFormativaDetalle.USERID = Me.ObtenerUsuario

            Dim lCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(lAccionFormativaDetalle.ID_ACCION_FORMATIVA)
            If lCompra IsNot Nothing Then
                lAccionFormativaDetalle.ID_UNIDAD_ORGANIZATIVA = lCompra.ID_UNIDAD_ORGANIZATIVA
            End If
            bAccionFormativaDetalle.ActualizarACCION_FORMATIVA_DETALLE(lAccionFormativaDetalle)
        Else
            If mEntidad.ID_SITIO_CAPACITACION > 0 Then
                'Habil técnico
                lAccionFormativaDetalle = New ACCION_FORMATIVA_DETALLE
                lAccionFormativaDetalle.ID_ACCION_FORMATIVA = mEntidad.ID_ACCION_FORMATIVA
                lAccionFormativaDetalle.ID_PROGRAMA_FORMACION = ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                lAccionFormativaDetalle.ID_MODALIDAD_FORMACION = Me.ddlMODALIDAD_DE_FORMACION1.SelectedValue
                lAccionFormativaDetalle.ID_CONTRATO = -1
                lAccionFormativaDetalle.ID_FUENTE = -1
                lAccionFormativaDetalle.NO_CONVOCATORIA = -1
                lAccionFormativaDetalle.LUGAR_EJECUCION = Me.txtLUGAR_EJECUCION.Text.Trim.ToUpper
                lAccionFormativaDetalle.CODIGO_DEPARTAMENTO = DdlDEPARTAMENTO1.SelectedValue
                lAccionFormativaDetalle.CODIGO_MUNICIPIO = DdlMUNICIPIO1.SelectedValue
                lAccionFormativaDetalle.TELEFONO = ""
                lAccionFormativaDetalle.CONTACTO = ""
                lAccionFormativaDetalle.LASTUPDATE = Now
                lAccionFormativaDetalle.USERID = Me.ObtenerUsuario
                lAccionFormativaDetalle.ID_UNIDAD_ORGANIZATIVA = 9
                bAccionFormativaDetalle.AgregarACCION_FORMATIVA_DETALLE(lAccionFormativaDetalle)
            End If
        End If

        If Not (Not Me._nuevo AndAlso Me.txtCODI_FORMADOR.Text.Trim <> "") Then
            Dim sResult As String = Me.ucProgramacion1.Actualizar(mEntidad.ID_ACCION_FORMATIVA, Me._nuevo)
            If sResult <> "" Then
                Return sResult
            End If
        End If
        'Dim sResult As String = Me.ucProgramacion1.Actualizar(mEntidad.ID_ACCION_FORMATIVA, Me._nuevo)
        'If sResult <> "" Then
        '    Return sResult
        'End If

        Me.ucProgramacion1.Limpiar()
        If Me.ES_INFORME_FINAL Then
            Dim bInforme As New cINFORME_FINAL_AF
            Dim listaInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(mEntidad.ID_ACCION_FORMATIVA)
            If listaInformes IsNot Nothing AndAlso listaInformes.Count = 1 Then
                For i As Integer = 0 To listaInformes.Count - 1
                    If listaInformes(i).ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones Then
                        listaInformes(i).FECHA_INICIAL = mEntidad.FECHA_INICIO_REAL
                        listaInformes(i).FECHA_FINAL = mEntidad.FECHA_FIN_REAL
                        bInforme.ActualizarINFORME_FINAL_AF(listaInformes(i), TipoConcurrencia.Pesimistica, True, False, False)
                    End If
                Next
            End If
        End If
        Me.txtID_ACCION_FORMATIVA.Text = mEntidad.ID_ACCION_FORMATIVA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        If Me.ES_BOLPROS_A_DEMANDA Then
            Me.ddlCONTRATO_BOLPROS1.RecuperarPorPROVEEDOR_AF_PAGO_PARTICIPANTE(Me.ddlPROVEEDOR_AF1.SelectedValue, 1)
            Me.MostrarAccionContratada()
        Else
            MostrarCentrosFormacion()
            MostrarAreas()
            MostrarOfertas()
        End If
    End Sub

    Protected Sub ddlAREA_FORMACION1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlAREA_FORMACION1.SelectedIndexChanged
        MostrarOfertas()
    End Sub

    Protected Sub ddlEJERCICIO1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlEJERCICIO1.SelectedIndexChanged
        MostrarAreas()
        MostrarOfertas()
    End Sub

    Sub MostrarCentrosFormacion()
        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
    End Sub

    Sub MostrarAreas()
        'Me.ddlAREA_FORMACION1.RecuperarPorProveedorSitioEjercicio(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ddlSITIO_CAPACITACION1.SelectedValue, Me.ddlEJERCICIO1.SelectedValue)
        Me.ddlAREA_FORMACION1.RecuperarPorProveedorEjercicio(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ddlEJERCICIO1.SelectedValue)
    End Sub

    Sub MostrarOfertas()
        If ddlAREA_FORMACION1.SelectedValue = "" Then
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO( _
            -1, ddlPROVEEDOR_AF1.SelectedValue, ddlSITIO_CAPACITACION1.SelectedValue, ddlEJERCICIO1.SelectedValue)
        Else
            'Me.ddlOFERTA_FORMATIVA1.RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO( _
            'ddlAREA_FORMACION1.SelectedValue, ddlPROVEEDOR_AF1.SelectedValue, ddlSITIO_CAPACITACION1.SelectedValue, ddlEJERCICIO1.SelectedValue)
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorCRITERIOS( _
                 ddlPROVEEDOR_AF1.SelectedValue, ddlEJERCICIO1.SelectedValue, ddlAREA_FORMACION1.SelectedValue)
        End If

        MostrarInfoOferta()
    End Sub

    Sub MostrarAccionContratada()
        Dim lista As listaACCION_CONTRATADA

        If Me.ddlCONTRATO_BOLPROS1.SelectedValue IsNot Nothing Then
            lista = (New cACCION_CONTRATADA).ObtenerListaPorCONTRATO_BOLPROS(Me.ddlCONTRATO_BOLPROS1.SelectedValue, False, False, "NOMBRE_ACCION_FORMATIVA")
        Else
            lista = New listaACCION_CONTRATADA
        End If
        Me.cbxACCION_CONTRATADA.DataSource = lista
        Me.cbxACCION_CONTRATADA.DataBind()
        Me.cbxACCION_CONTRATADA.Text = ""
    End Sub

    Sub SeleccionarEjercicioActual()
        Dim eEjercicioActual As EJERCICIO = (New cEJERCICIO).ObtenerEJERCICIOActual()

        If eEjercicioActual IsNot Nothing AndAlso Me.ddlEJERCICIO1.Items.FindByValue(eEjercicioActual.ID_EJERCICIO) IsNot Nothing Then
            Me.ddlEJERCICIO1.SelectedValue = eEjercicioActual.ID_EJERCICIO
        End If
    End Sub

    Protected Sub ddlOFERTA_FORMATIVA1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlOFERTA_FORMATIVA1.SelectedIndexChanged
        MostrarInfoOferta()
    End Sub

    Sub MostrarInfoOferta()
        If Not Me.ddlOFERTA_FORMATIVA1.SelectedValue = "" Then
            Dim mOferta As New SGAFP.EL.OFERTA_FORMATIVA
            mOferta = (New SGAFP.BL.cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(Me.ddlOFERTA_FORMATIVA1.SelectedValue)
            'Dim mOfertaSitio As New SGAFP.EL.OFERTA_FORMATIVA_SITIO
            'mOfertaSitio = (New SGAFP.BL.cOFERTA_FORMATIVA_SITIO).ObtenerListaPorOFERTA_FORMATIVA(mOferta.ID_OFERTA_FORMATIVA).Find(Function(e) e.ID_SITIO_CAPACITACION = Me.ddlSITIO_CAPACITACION1.SelectedValue And e.ID_EJERCICIO = Me.ddlEJERCICIO1.SelectedValue)

            Me.txtNOMBRE_ACCION_FORMATIVA.Text = Me.ddlOFERTA_FORMATIVA1.SelectedItem.Text
            Me.txtTEMA_CURSO.Text = mOferta.ID_TEMA_CURSO.ToString
            Me.txtCOSTO_X_PARTICIPANTE.Text = If(mOferta IsNot Nothing, mOferta.COSTO_X_PARTICIPANTE.ToString("#.#######"), "")
            Me.txtDURACION_HORAS.Text = mOferta.DURACION_HORAS.ToString
        Else
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
            Me.txtTEMA_CURSO.Text = ""
            Me.txtCOSTO_X_PARTICIPANTE.Text = ""
            Me.txtDURACION_HORAS.Text = ""
        End If
    End Sub

    Sub MostrarInfoAccionContratada()
        If Me.cbxACCION_CONTRATADA.Value IsNot Nothing Then
            Dim lAccionContratada As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(Me.cbxACCION_CONTRATADA.Value)
            If lAccionContratada IsNot Nothing Then
                Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)

                Me.txtNOMBRE_ACCION_FORMATIVA.Text = If(Me.cbxACCION_CONTRATADA.SelectedItem IsNot Nothing, Me.cbxACCION_CONTRATADA.SelectedItem.Text.Trim.ToUpper, "")
                Me.txtTEMA_CURSO.Text = -1
                Me.txtCOSTO_X_PARTICIPANTE.Text = lAccionContratada.COSTO_PARTICIPANTE.ToString
                Me.txtDURACION_HORAS.Text = lAccionContratada.DURACION.ToString
                Me.DdlDEPARTAMENTO1.Recuperar()
                Me.DdlDEPARTAMENTO1.SelectedValue = lAccionContratada.CODIGO_DEPARTAMENTO
                Me.DdlMUNICIPIO1.RecuperarPorDEPARTAMENTO(lAccionContratada.CODIGO_DEPARTAMENTO)
                Me.DdlMUNICIPIO1.SelectedValue = lAccionContratada.CODIGO_MUNICIPIO
                Me.txtLUGAR_EJECUCION.Text = If(lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online, "INSAFORP ONLINE", "")

                If lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
                    Me.txtLUGAR_EJECUCION.Enabled = True
                    Me.DdlDEPARTAMENTO1.Enabled = True
                    Me.DdlMUNICIPIO1.Enabled = True
                    Me.txtCODI_FORMADOR.Enabled = True
                End If
            End If
        Else
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
            Me.txtLUGAR_EJECUCION.Text = ""
            Me.txtTEMA_CURSO.Text = ""
            Me.txtCOSTO_X_PARTICIPANTE.Text = ""
            Me.txtDURACION_HORAS.Text = ""
        End If
    End Sub

    Protected Sub ddlSITIO_CAPACITACION1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlSITIO_CAPACITACION1.SelectedIndexChanged
        MostrarAreas()
        MostrarOfertas()
        ConfigurarMascaraCodigoCurso(Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
        AsignarLugarEjecucionPorCentro(ddlSITIO_CAPACITACION1.SelectedValue)
    End Sub

    Protected Sub DdlDEPARTAMENTO1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DdlDEPARTAMENTO1.SelectedIndexChanged
        Me.DdlMUNICIPIO1.RecuperarPorDEPARTAMENTO(DdlDEPARTAMENTO1.SelectedValue)
    End Sub


    Protected Sub ddlCONTRATO_BOLPROS1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCONTRATO_BOLPROS1.SelectedIndexChanged
        If ddlCONTRATO_BOLPROS1.SelectedValue IsNot Nothing Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ddlCONTRATO_BOLPROS1.SelectedValue)
            If lContrato IsNot Nothing Then
                If lContrato.ES_PAGO_PARTICIPANTE = 1 Then
                    Me.ES_CURSO_ONLINE = True
                    Me.txtCODI_FORMADOR.Enabled = False
                    Me.txtNOMBRE_FORMADOR.ClientEnabled = True
                Else
                    Me.ES_CURSO_ONLINE = False
                End If
                Me.ConfigurarMascaraCodigoCurso(lContrato.ID_PROGRAMA_FORMACION)
            End If
        End If
        Me.MostrarAccionContratada()
    End Sub

    Protected Sub cbxACCION_CONTRATADA_ValueChanged(sender As Object, e As EventArgs) Handles cbxACCION_CONTRATADA.ValueChanged
        Me.MostrarInfoAccionContratada()
    End Sub

    Protected Sub txtCODI_FORMADOR_ValueChanged(sender As Object, e As EventArgs) Handles txtCODI_FORMADOR.ValueChanged
        Me.txtNOMBRE_FORMADOR.Text = ""

        If Me.txtCODI_FORMADOR.Text.Trim <> "" Then
            Dim lSrvFormadores As New ServicioFORMADOREScliente.ServicioFORMADORESClient
            Dim lEntidad As New ServicioFORMADOREScliente.FORMADOR

            lEntidad = lSrvFormadores.ObtenerFORMADOR_PorNIT(Me.txtCODI_FORMADOR.Text)
            If lEntidad IsNot Nothing Then
                If lEntidad.ID_ESTADO_FORMA <> 1 Then
                    Me.AsignarMensaje("El Formador " + lEntidad.NOMBRES + " " + lEntidad.APELLIDOS + " con numero de NIT: " + Utilerias.FormatearNIT(Me.txtCODI_FORMADOR.Text.Trim) + " no esta acreditado", True, True)
                    Me.txtCODI_FORMADOR.Text = ""
                    Return
                End If
                Me.txtNOMBRE_FORMADOR.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            Else
                Me.AsignarMensaje("No existe Formador con numero de NIT: " + Utilerias.FormatearNIT(Me.txtCODI_FORMADOR.Text.Trim), True, True)
                Me.txtCODI_FORMADOR.Text = ""
            End If
        End If
    End Sub

    Protected Sub ddlMODALIDAD_DE_FORMACION1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlMODALIDAD_DE_FORMACION1.SelectedIndexChanged
        If ddlCONTRATO_BOLPROS1.SelectedValue IsNot Nothing Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ddlCONTRATO_BOLPROS1.SelectedValue)
            If lContrato IsNot Nothing Then
                Me.ConfigurarMascaraCodigoCurso(lContrato.ID_PROGRAMA_FORMACION)
                Exit Sub
            End If
        End If
        ConfigurarMascaraCodigoCurso(Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE)
    End Sub

   
End Class
