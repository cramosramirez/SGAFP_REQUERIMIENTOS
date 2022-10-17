Imports SGAFP.BL
Imports SGAFP.EL
Imports SQLMembershipProvider.BL
Imports System.Collections.Generic
Imports SGAFP.DL.DS_DL

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_FORMATIVA_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_FORMATIVA_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_FORMATIVA_REPROG
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ACCION_FORMATIVA_REPROG As Decimal
    Public Property ID_ACCION_FORMATIVA_REPROG() As Decimal
        Get
            Return Me.txtID_ACCION_FORMATIVA_REPROG.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_FORMATIVA_REPROG = Value
            Me.txtID_ACCION_FORMATIVA_REPROG.Text = CStr(Value)
            If Me._ID_ACCION_FORMATIVA_REPROG > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _ID_ACCION_FORMATIVA As Decimal
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me.txtID_ACCION_FORMATIVA.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_FORMATIVA = Value
            Me.txtID_ACCION_FORMATIVA.Text = CStr(Value)
            If Me._ID_ACCION_FORMATIVA > 0 Then
                Me.CargarDatosAccionFormativa()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
        End Set
    End Property

    Private _CODIGO_ESTADO_AF As String
    Public ReadOnly Property CODIGO_ESTADO_AF() As String
        Get
            Return Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue
        End Get
    End Property

    Public Property VerID_ACCION_FORMATIVA_REPROG() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA_REPROG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA_REPROG.Visible = value
        End Set
    End Property

    Public Property VerID_ESTADO_REPROG() As Boolean
        Get
            Return Me.trID_ESTADO_REPROG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_REPROG.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerAREA_FORMACION() As Boolean
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

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.trHORARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHORARIO.Visible = value
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

    Public Property VerID_AREA_FORMACION() As Boolean
        Get
            Return Me.trAREA_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA_FORMACION.Visible = value
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

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.trLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLASTUPDATE.Visible = value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSERID.Visible = value
        End Set
    End Property
    

    Public Property VerMOTIVOREPROG() As Boolean
        Get
            Return Me.trMOTIVOREPROG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOTIVOREPROG.Visible = value
        End Set
    End Property

    Public Property VerMOTIVORECHAZO() As Boolean
        Get
            Return Me.trMOTIVORECHAZO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOTIVORECHAZO.Visible = value
        End Set
    End Property

    Public Property PermitirEditarReProgramacion() As Boolean
        Get
            Return Me.ucReProgramacion1.PermitirEditar
        End Get
        Set(ByVal value As Boolean)
            Me.ucReProgramacion1.PermitirEditar = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cACCION_FORMATIVA_REPROG
    Private mComponenteAF As New cACCION_FORMATIVA
    Private mEntidad As ACCION_FORMATIVA_REPROG
    Private mEntidadAF As ACCION_FORMATIVA
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

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ACCION_FORMATIVA_REPROG") Is Nothing Then Me._ID_ACCION_FORMATIVA_REPROG = Me.ViewState("ID_ACCION_FORMATIVA_REPROG")
    End Sub

    Private Sub ConfigurarMascaraCodigoCurso(ByVal lidProgramaFormacion As Decimal)
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.ID_ACCION_FORMATIVA)
        If lAccionDetalle IsNot Nothing Then
            Select Case lAccionDetalle.ID_PROGRAMA_FORMACION
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    If ddlSITIO_CAPACITACION1.SelectedValue Is Nothing OrElse ddlSITIO_CAPACITACION1.SelectedValue = "" Then
                        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(Me.ID_ACCION_FORMATIVA)
                        If lTermino IsNot Nothing Then
                            Dim lCriteria As New List(Of Criteria)
                            Dim lGrupo As New GRUPO_SOLICITUD
                            lCriteria.Add(New Criteria("TDR", "=", lTermino.TDR, "AND"))
                            lCriteria.Add(New Criteria("CORRELATIVO_GRUPO", "=", lTermino.CORRELATIVO_GRUPO.ToString, ""))
                            lGrupo.TDR = lTermino.TDR
                            lGrupo.CORRELATIVO_GRUPO = lTermino.CORRELATIVO_GRUPO
                            Dim listaGrupos As listaGRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerListaPorBusqueda(lGrupo, lCriteria.ToArray)

                            If listaGrupos IsNot Nothing AndAlso listaGrupos.Count > 0 Then
                                If listaGrupos(0).ID_MODALIDAD_FORMACION = 1 Then
                                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPCENTRO>->aaaa->000"
                                Else
                                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPMOVIL>->aaaa->000"
                                End If
                            Else
                                Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPCENTRO>->aaaa->000"
                            End If
                        Else
                            Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|HTPCENTRO>->aaaa->000"
                        End If
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    Else
                        Me.txtCODIGO_GRUPO.MaskSettings.Mask = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(Decimal.Parse(ddlSITIO_CAPACITACION1.SelectedValue)).FORMATO_CODIGO_CURSO
                        Me.txtCODIGO_GRUPO.MaskSettings.PromptChar = "#"
                        Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                    End If
                Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|PATI>->aaaa->000"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    Me.txtCODIGO_GRUPO.MaskSettings.Mask = "<|PROESP>->aaaa->000"
                    Me.txtCODIGO_GRUPO.MaskSettings.IncludeLiterals = DevExpress.Web.ASPxEditors.MaskIncludeLiteralsMode.All
            End Select
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ACCION_FORMATIVA_REPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim afEntidad As New ACCION_FORMATIVA
        Dim sError As New String("")
        Dim cambioEstilo As New Style()
        cambioEstilo.BackColor = Drawing.Color.Yellow

        mEntidad = New ACCION_FORMATIVA_REPROG
        mEntidad.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
        If mComponente.ObtenerACCION_FORMATIVA_REPROG(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        afEntidad = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(mEntidad.ID_ACCION_FORMATIVA)

        Dim lidProgramaFormacion As Integer
        lidProgramaFormacion = mComponenteAF.ObtenerProgramaFormacionCurso(mEntidad.ID_ACCION_FORMATIVA)
        Me.txtID_ACCION_FORMATIVA.Text = mEntidad.ID_ACCION_FORMATIVA.ToString
        Me.txtID_ACCION_FORMATIVA_REPROG.Text = mEntidad.ID_ACCION_FORMATIVA_REPROG.ToString()
        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlEJERCICIO1.SelectedValue = mEntidad.ID_EJERCICIO
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.SelectedValue = mEntidad.ID_PROVEEDOR_AF
        If lidProgramaFormacion <> Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
            Me.ddlAREA_FORMACION1.Recuperar()
        Else
            If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                Me.ddlSITIO_CAPACITACION1.Recuperar()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = mEntidad.ID_SITIO_CAPACITACION
                Me.ddlAREA_FORMACION1.RecuperarPorOFERTA_FORMATIVA(mEntidad.ID_OFERTA_FORMATIVA)
            End If
        End If
        Me.txtTEMA_CURSO.Text = mEntidad.ID_TEMA_CURSO
        Dim mCursoTema As New SGAFP.EL.CURSO_TEMA
        mCursoTema = (New SGAFP.BL.cCURSO_TEMA).ObtenerCURSO_TEMA(mEntidad.ID_TEMA_CURSO)
        If mCursoTema IsNot Nothing Then
            Me.ddlAREA_FORMACION1.SelectedValue = mCursoTema.ID_AREA_FORMACION
        End If
        If lidProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso mEntidad.ID_OFERTA_FORMATIVA <> -1 Then
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorOFERTA_FORMATIVA(mEntidad.ID_OFERTA_FORMATIVA)
            Me.ddlOFERTA_FORMATIVA1.SelectedValue = mEntidad.ID_OFERTA_FORMATIVA
        End If

        Me.txtNOMBRE_ACCION_FORMATIVA.Text = mEntidad.NOMBRE_ACCION_FORMATIVA
        Me.ConfigurarMascaraCodigoCurso(lidProgramaFormacion)
        Me.txtCODIGO_GRUPO.Text = mEntidad.CODIGO_GRUPO
        Me.txtNUMERO_PARTICIPANTES.Text = mEntidad.NUMERO_PARTICIPANTES
        Me.txtPARTICIPANTES_INSCRITOS.Text = mEntidad.PARTICIPANTES_INSCRITOS
        Me.txtHORARIO.Text = mEntidad.HORARIO
        Me.txtCODI_FORMADOR.Text = mEntidad.CODI_FORMADOR
        Me.txtNOMBRE_FORMADOR.Text = mEntidad.NOMBRE_FORMADOR
        Me.ddlESTADO_ACCION_FORMATIVA1.Recuperar()
        Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = mEntidad.CODIGO_ESTADO_AF
        Me.txtDURACION_HORAS.Text = mEntidad.DURACION_HORAS
        Me.txtCOSTO_X_PARTICIPANTE.Text = mEntidad.COSTO_X_PARTICIPANTE
        Me.txtUSERID.Text = mEntidad.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
        Me.txtMOTIVOREPROG.Text = mEntidad.MOTIVOREPROG
        Me.txtMOTIVORECHAZO.Text = mEntidad.MOTIVORECHAZO
        Me.ucReProgramacion1.CargarReProgramacion(mEntidad.ID_ACCION_FORMATIVA_REPROG)

        'Evaluar cambios en los campos
        If afEntidad.ID_PROVEEDOR_AF <> mEntidad.ID_PROVEEDOR_AF Then Me.ddlPROVEEDOR_AF1.ApplyStyle(cambioEstilo)
        If afEntidad.ID_SITIO_CAPACITACION <> mEntidad.ID_SITIO_CAPACITACION Then Me.ddlSITIO_CAPACITACION1.ApplyStyle(cambioEstilo)
        If afEntidad.ID_TEMA_CURSO <> mEntidad.ID_TEMA_CURSO Then Me.txtTEMA_CURSO.ApplyStyle(cambioEstilo)
        If afEntidad.ID_OFERTA_FORMATIVA <> mEntidad.ID_OFERTA_FORMATIVA Then Me.ddlOFERTA_FORMATIVA1.ApplyStyle(cambioEstilo)
        If afEntidad.NOMBRE_ACCION_FORMATIVA <> mEntidad.NOMBRE_ACCION_FORMATIVA Then Me.txtNOMBRE_ACCION_FORMATIVA.BackColor = Drawing.Color.Yellow Else Me.txtNOMBRE_ACCION_FORMATIVA.BackColor = Drawing.Color.White
        If afEntidad.CODIGO_GRUPO <> mEntidad.CODIGO_GRUPO Then Me.txtCODIGO_GRUPO.BackColor = Drawing.Color.Yellow Else Me.txtCODIGO_GRUPO.BackColor = Drawing.Color.White
        If afEntidad.NUMERO_PARTICIPANTES <> mEntidad.NUMERO_PARTICIPANTES Then Me.txtNUMERO_PARTICIPANTES.BackColor = Drawing.Color.Yellow Else Me.txtNUMERO_PARTICIPANTES.BackColor = Drawing.Color.White
        If afEntidad.FECHA_INICIO_REAL <> mEntidad.FECHA_INICIO_REAL Then Me.ucReProgramacion1.Resaltar_FechaInicioReal(True) Else Me.ucReProgramacion1.Resaltar_FechaInicioReal(False)
        If afEntidad.FECHA_FIN_REAL <> mEntidad.FECHA_FIN_REAL Then Me.ucReProgramacion1.Resaltar_FechaFinReal(True) Else Me.ucReProgramacion1.Resaltar_FechaFinReal(False)
        If afEntidad.HORARIO <> mEntidad.HORARIO Then Me.txtHORARIO.BackColor = Drawing.Color.Yellow Else Me.txtHORARIO.BackColor = Drawing.Color.White
        If afEntidad.CODI_FORMADOR <> mEntidad.CODI_FORMADOR Then
            Me.txtCODI_FORMADOR.BackColor = Drawing.Color.Yellow
            Me.txtNOMBRE_FORMADOR.BackColor = Drawing.Color.Yellow
        Else
            Me.txtCODI_FORMADOR.BackColor = Drawing.Color.White
            Me.txtNOMBRE_FORMADOR.BackColor = Drawing.Color.White
        End If
        If afEntidad.DURACION_HORAS <> mEntidad.DURACION_HORAS Then Me.txtDURACION_HORAS.BackColor = Drawing.Color.Yellow Else Me.txtDURACION_HORAS.BackColor = Drawing.Color.White
        If afEntidad.COSTO_X_PARTICIPANTE <> mEntidad.COSTO_X_PARTICIPANTE Then Me.txtCOSTO_X_PARTICIPANTE.BackColor = Drawing.Color.Yellow Else Me.txtCOSTO_X_PARTICIPANTE.BackColor = Drawing.Color.White
        If afEntidad.ID_EJERCICIO <> mEntidad.ID_EJERCICIO Then Me.ddlEJERCICIO1.ApplyStyle(cambioEstilo)


        If _ID_ACCION_FORMATIVA_REPROG > 0 Then
            Me.txtID_ACCION_FORMATIVA_REPROG.Enabled = False
            Me.txtID_ACCION_FORMATIVA.Enabled = False
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.Enabled = False
            Me.ddlAREA_FORMACION1.Enabled = False
            Me.ddlOFERTA_FORMATIVA1.Enabled = False
            Me.txtTEMA_CURSO.Enabled = False
            Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = False
            Me.txtCODIGO_GRUPO.Enabled = False
            Me.txtNUMERO_PARTICIPANTES.Enabled = False
            Me.txtHORARIO.Enabled = False
            Me.txtCODI_FORMADOR.Enabled = False
            Me.txtNOMBRE_FORMADOR.Enabled = False
            Me.txtPARTICIPANTES_INSCRITOS.Enabled = False
            Me.txtDURACION_HORAS.Enabled = False
            Me.txtCOSTO_X_PARTICIPANTE.Enabled = False
            Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = False
            Me.ddlEJERCICIO1.Enabled = False
            Me.txtMOTIVOREPROG.Enabled = False
            Me.txtMOTIVORECHAZO.Enabled = False

            If mEntidad.ID_SITIO_CAPACITACION = -1 Then
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

            Me.VerID_ACCION_FORMATIVA_REPROG = False
            Me.VerLASTUPDATE = False
            Me.VerID_TEMA_CURSO = False
            Me.VerUSERID = False
            Me.VerCODIGO_ESTADO_AF = False
            Me.VerID_ESTADO_REPROG = False
            Me.VerMOTIVOREPROG = True
            Me.VerMOTIVORECHAZO = False
            Me.VerHORARIO = False
        End If
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ACCION_FORMATIVA_REPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatosAccionFormativa()

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidadAF = New ACCION_FORMATIVA
        mEntidadAF.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA

        If mComponenteAF.ObtenerACCION_FORMATIVA(mEntidadAF) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ACCION_FORMATIVA.Text = mEntidadAF.ID_ACCION_FORMATIVA.ToString()
        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlEJERCICIO1.SelectedValue = mEntidadAF.ID_EJERCICIO
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.SelectedValue = mEntidadAF.ID_PROVEEDOR_AF
        Dim lidProgramaFormacion As Decimal
        lidProgramaFormacion = mComponenteAF.ObtenerProgramaFormacionCurso(mEntidadAF.ID_ACCION_FORMATIVA)

        If mEntidadAF.ID_SITIO_CAPACITACION = -1 Then
            Me.ddlAREA_FORMACION1.Recuperar()
        Else
            Me.ddlSITIO_CAPACITACION1.Recuperar()
            Me.ddlSITIO_CAPACITACION1.SelectedValue = mEntidadAF.ID_SITIO_CAPACITACION
            Me.ddlAREA_FORMACION1.RecuperarPorOFERTA_FORMATIVA(mEntidadAF.ID_OFERTA_FORMATIVA)
        End If

        Me.txtTEMA_CURSO.Text = mEntidadAF.ID_TEMA_CURSO

        Dim mCursoTema As New SGAFP.EL.CURSO_TEMA
        mCursoTema = (New SGAFP.BL.cCURSO_TEMA).ObtenerCURSO_TEMA(mEntidadAF.ID_TEMA_CURSO)
        If mCursoTema IsNot Nothing Then
            Me.ddlAREA_FORMACION1.SelectedValue = mCursoTema.ID_AREA_FORMACION
        End If
        If mEntidadAF.ID_SITIO_CAPACITACION <> -1 Then
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorOFERTA_FORMATIVA(mEntidadAF.ID_OFERTA_FORMATIVA)
            Me.ddlOFERTA_FORMATIVA1.SelectedValue = mEntidadAF.ID_OFERTA_FORMATIVA
        End If

        Me.txtNOMBRE_ACCION_FORMATIVA.Text = mEntidadAF.NOMBRE_ACCION_FORMATIVA
        Me.ConfigurarMascaraCodigoCurso(lidProgramaFormacion)
        Me.txtCODIGO_GRUPO.Text = mEntidadAF.CODIGO_GRUPO
        Me.txtNUMERO_PARTICIPANTES.Text = mEntidadAF.NUMERO_PARTICIPANTES
        Me.txtPARTICIPANTES_INSCRITOS.Text = mEntidadAF.PARTICIPANTES_INSCRITOS
        Me.txtHORARIO.Text = mEntidadAF.HORARIO
        Me.txtCODI_FORMADOR.Text = mEntidadAF.CODI_FORMADOR
        Me.txtNOMBRE_FORMADOR.Text = mEntidadAF.NOMBRE_FORMADOR
        Me.ddlESTADO_ACCION_FORMATIVA1.Recuperar()
        Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = mEntidadAF.CODIGO_ESTADO_AF
        Me.ddlESTADO_REPROG1.Recuperar()
        Me.txtDURACION_HORAS.Text = mEntidadAF.DURACION_HORAS
        Me.txtCOSTO_X_PARTICIPANTE.Text = mEntidadAF.COSTO_X_PARTICIPANTE
        Me.txtUSERID.Text = mEntidadAF.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidadAF.LASTUPDATE = Nothing, Format(mEntidadAF.LASTUPDATE, "dd/MM/yyyy"), "")
        Me.ucReProgramacion1.CargarProgramacion(mEntidadAF.ID_ACCION_FORMATIVA)

        Me.txtMOTIVOREPROG.Text = ""
        Me.txtMOTIVORECHAZO.Text = ""

        If _ID_ACCION_FORMATIVA > 0 Then
            Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = False
            Me.txtNUMERO_PARTICIPANTES.Enabled = False
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.Enabled = False
            Me.ddlAREA_FORMACION1.Enabled = False
            Me.ddlOFERTA_FORMATIVA1.Enabled = False
            Me.txtDURACION_HORAS.Enabled = False
            Me.txtCOSTO_X_PARTICIPANTE.Enabled = False
            Me.txtCODIGO_GRUPO.Enabled = False
            Me.txtCODI_FORMADOR.Enabled = True
            Me.txtNOMBRE_FORMADOR.Enabled = False
            Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = False
            Me.ddlEJERCICIO1.Enabled = False

            Me.VerID_ACCION_FORMATIVA_REPROG = False
            Me.VerID_TEMA_CURSO = False
            Me.VerUSERID = False
            Me.VerLASTUPDATE = False
            Me.VerID_ESTADO_REPROG = False
            Me.VerMOTIVOREPROG = True
            Me.VerMOTIVORECHAZO = False
            Me.VerID_ESTADO_REPROG = False
            Me.VerHORARIO = False

            If mEntidadAF.ID_SITIO_CAPACITACION = -1 Then
                Me.VerID_OFERTA_FORMATIVA = False
                Me.VerID_SITIO_CAPACITACION = False
                Me.VerID_AREA_FORMACION = False
            Else
                Me.VerNOMBRE_ACCION_FORMATIVA = False
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlESTADO_REPROG1.Enabled = edicion
        Me.ddlOFERTA_FORMATIVA1.Enabled = edicion
        Me.ddlSITIO_CAPACITACION1.Enabled = edicion
        Me.ddlPROVEEDOR_AF1.Enabled = edicion
        Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = edicion
        Me.txtID_ACCION_FORMATIVA.Enabled = edicion
        Me.txtTEMA_CURSO.Enabled = edicion
        Me.ddlEJERCICIO1.Enabled = edicion
        Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = edicion
        Me.txtCODIGO_GRUPO.Enabled = edicion
        Me.txtNUMERO_PARTICIPANTES.Enabled = edicion
        Me.txtPARTICIPANTES_INSCRITOS.Enabled = edicion
        Me.txtHORARIO.Enabled = edicion
        Me.txtCODI_FORMADOR.Enabled = edicion
        Me.txtNOMBRE_FORMADOR.Enabled = False
        Me.txtDURACION_HORAS.Enabled = edicion
        Me.txtCOSTO_X_PARTICIPANTE.Enabled = edicion
        Me.txtLASTUPDATE.Enabled = False
        Me.txtUSERID.Enabled = False
        Me.txtMOTIVOREPROG.Enabled = True
        Me.txtMOTIVOREPROG.ReadOnly = True
        Me.txtMOTIVORECHAZO.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlEJERCICIO1.Recuperar()
        SeleccionarEjercicioActual()

        If Me.EstaEnRol("Administrador") Then
            MostrarCentrosFormacion()

        ElseIf Me.EstaEnRol("Proveedor") Then
            Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF.ToString
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.Enabled = True
            Me.ddlEJERCICIO1.Enabled = False

        ElseIf Me.EstaEnRol("CentroCapacitador") Then
            Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF.ToString
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.SelectedValue = Me.ObtenerIdSitioCapacitacion.ToString
            Me.ddlPROVEEDOR_AF1.Enabled = False
            Me.ddlSITIO_CAPACITACION1.Enabled = False
            Me.ddlEJERCICIO1.Enabled = False
        End If

        Me.ddlOFERTA_FORMATIVA1.Enabled = True
        Me.ddlAREA_FORMACION1.Enabled = True

        Me.ddlAREA_FORMACION1.RecuperarPorProveedorSitioEjercicio(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ddlSITIO_CAPACITACION1.SelectedValue, Me.ddlEJERCICIO1.SelectedValue)

        If ddlAREA_FORMACION1.SelectedValue <> "" Then
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO( _
                ddlAREA_FORMACION1.SelectedValue, ddlPROVEEDOR_AF1.SelectedValue, Me.ddlSITIO_CAPACITACION1.SelectedValue, ddlEJERCICIO1.SelectedValue)
        End If
        MostrarInfoOferta()

        Me.ddlESTADO_ACCION_FORMATIVA1.Recuperar()
        Me.ddlESTADO_REPROG1.Recuperar()

        Me.txtCODIGO_GRUPO.Text = ""
        Me.txtPARTICIPANTES_INSCRITOS.Enabled = False
        Me.txtPARTICIPANTES_INSCRITOS.Text = "0"
        Me.txtNUMERO_PARTICIPANTES.Text = ""
        Me.txtHORARIO.Text = ""
        Me.txtCODI_FORMADOR.Text = ""
        Me.txtNOMBRE_FORMADOR.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
        Me.txtMOTIVOREPROG.Text = ""
        Me.txtMOTIVORECHAZO.Text = ""

        Me.ddlESTADO_ACCION_FORMATIVA1.Enabled = False
        Me.txtTEMA_CURSO.Enabled = False
        Me.txtDURACION_HORAS.Enabled = False
        Me.txtCOSTO_X_PARTICIPANTE.Enabled = False
        Me.VerUSERID = True
        Me.VerLASTUPDATE = False
        Me.VerID_TEMA_CURSO = False
        Me.VerUSERID = False
    End Sub

    Public Function ValidarHorarioParaFormador(ByVal ID_ACCION_FORMATIVA As Int32, ByVal CODIFORMADOR As String) As String

        'Validar que el horario de la programación no esté conflicto con otro horario del formador
        Dim sErrorVal As String = Me.ucReProgramacion1.ValidarHorarioParaFormador(ID_ACCION_FORMATIVA, CODIFORMADOR)
        If sErrorVal <> "" Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & sErrorVal, True, True)
            Return "Alerta." & vbCrLf & sErrorVal
        Else
            Return ""
        End If
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ACCION_FORMATIVA_REPROG
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Alerta."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim Msj As New StringBuilder
        Dim lRet As Integer

        If Not (Me.txtCODIGO_GRUPO.IsValid AndAlso IsNumeric(Right(Me.txtCODIGO_GRUPO.Text, 3)) AndAlso Int32.Parse(Right(Me.txtCODIGO_GRUPO.Text, 3)) > 0) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "El Codigo de Curso no es valido. El correlativo debe tener 3 digitos, Ej: 001, 002, 003...", True, True)
            Return "Alerta."
        End If
        'If Me.txtHORARIO.Text.Trim = "" Or Me.txtHORARIO.Text.Trim.ToUpper = "PENDIENTE DE DEFINIR" Then
        '    Me.AsignarMensaje("Alerta. " & vbCrLf & "Horario del Curso es requerido", True, True)
        '    Return "Alerta."
        'End If
        If Me.txtCODI_FORMADOR.Text.Trim = "" AndAlso Not mComponenteAF.EsAccionFormativaOnline(Me.ID_ACCION_FORMATIVA) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "NIT del formador es requerido", True, True)
            Return "Alerta."
        End If
        If Me.ucReProgramacion1.dtASISTENCIA_AF_REPROG.Rows.Count = 0 Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Debe ingresar una Programación para el Curso", True, True)
            Return "Alerta."
        End If

        If Me.ucReProgramacion1.FECHA_INICIO_REAL Is Nothing Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe una Fecha de Inicio en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucReProgramacion1.FECHA_FIN_REAL Is Nothing Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe una Fecha de Finalizacion en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucReProgramacion1.HORARIO_REAL.Trim = "" Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "No existe un Horario en la Programacion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.ucReProgramacion1.MINUTOS_TOTALES <> (Decimal.Parse(Me.txtDURACION_HORAS.Text) * 60) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Las Horas Totales de la Programacion deben ser igual a la Duracion del Curso", True, True)
            Return "Alerta."
        End If
        If Me.txtMOTIVOREPROG.Text.Trim = "" Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "El motivo de la Reprogramación es requerido", True, True)
            Return "Alerta."
        End If

        If Not ExisteCambioEnReprogramacion() Then
            Msj.AppendLine("La Reprogramacion se puede aplicar solo cuando solicite algun cambio de:")
            Msj.Append("Codigo de grupo, ")
            Msj.Append("Cupo, ")
            Msj.Append("Programación de ejecución ")
            Msj.Append("o Instructor")

            Me.AsignarMensaje(Msj.ToString, True, True)
            Return "Alerta."
        End If

        Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(CDec(Me.txtID_ACCION_FORMATIVA.Text))
        If lContrato IsNot Nothing AndAlso lContrato.ID_CONTRATO > 0 AndAlso (Me.ucReProgramacion1.FECHA_INICIO_REAL < lContrato.FECHA_INI_EJEC OrElse Me.ucReProgramacion1.FECHA_FIN_REAL > lContrato.FECHA_FIN_EJEC) Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & "Las fechas de la reprogramacion estan fuera del periodo de ejecucion del contrato " & lContrato.NUM_CONTRATO & " que comprende del " & _
                              lContrato.FECHA_INI_EJEC.ToString("dd/MM/yyyy") & " al " + lContrato.FECHA_FIN_EJEC.ToString("dd/MM/yyyy"), True, True)
            Return "Alerta."
        End If

        mEntidad = New ACCION_FORMATIVA_REPROG
        If Me._nuevo Then
            mEntidad.ID_ACCION_FORMATIVA_REPROG = 0
            mEntidad.FECHA_SOLIC_REPROG = Today
        Else
            mEntidad.ID_ACCION_FORMATIVA_REPROG = CInt(Me.txtID_ACCION_FORMATIVA_REPROG.Text)
        End If
        mEntidad.ID_ESTADO_REPROG = Me.ddlESTADO_REPROG1.SelectedValue
        mEntidad.ID_ACCION_FORMATIVA = Val(Me.txtID_ACCION_FORMATIVA.Text)

        Dim lidProgramaFormacion As Decimal
        lidProgramaFormacion = mComponenteAF.ObtenerProgramaFormacionCurso(mEntidad.ID_ACCION_FORMATIVA)

        If lidProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso Me.ddlOFERTA_FORMATIVA1.SelectedValue <> "" Then
            mEntidad.ID_OFERTA_FORMATIVA = Me.ddlOFERTA_FORMATIVA1.SelectedValue
            mEntidad.ID_SITIO_CAPACITACION = Me.ddlSITIO_CAPACITACION1.SelectedValue
        Else
            mEntidad.ID_OFERTA_FORMATIVA = -1
            mEntidad.ID_SITIO_CAPACITACION = -1
        End If

        

        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AF1.SelectedValue
        mEntidad.ID_TEMA_CURSO = Me.txtTEMA_CURSO.Text
        mEntidad.ID_EJERCICIO = Me.ddlEJERCICIO1.SelectedValue
        mEntidad.NOMBRE_ACCION_FORMATIVA = Me.txtNOMBRE_ACCION_FORMATIVA.Text.ToUpper
        mEntidad.CODIGO_GRUPO = Me.txtCODIGO_GRUPO.Text.ToUpper
        mEntidad.NUMERO_PARTICIPANTES = Val(Me.txtNUMERO_PARTICIPANTES.Text)
        mEntidad.PARTICIPANTES_INSCRITOS = Val(Me.txtPARTICIPANTES_INSCRITOS.Text)
        mEntidad.FECHA_INICIO_REAL = CDate(Me.ucReProgramacion1.FECHA_INICIO_REAL)
        mEntidad.FECHA_FIN_REAL = CDate(Me.ucReProgramacion1.FECHA_FIN_REAL)
        mEntidad.HORARIO = Me.ucReProgramacion1.HORARIO_REAL
        mEntidad.CODI_FORMADOR = Me.txtCODI_FORMADOR.Text
        mEntidad.NOMBRE_FORMADOR = Me.txtNOMBRE_FORMADOR.Text
        mEntidad.NOTAS = Me.txtNOMBRE_FORMADOR.Text
        mEntidad.CODIGO_ESTADO_AF = Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue
        mEntidad.DURACION_HORAS = Val(Me.txtDURACION_HORAS.Text)
        mEntidad.COSTO_X_PARTICIPANTE = Val(Me.txtCOSTO_X_PARTICIPANTE.Text)
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        mEntidad.MOTIVOREPROG = Me.txtMOTIVOREPROG.Text.ToUpper
        mEntidad.MOTIVORECHAZO = ""


        lRet = mComponente.ActualizarACCION_FORMATIVA_REPROG(mEntidad)
        If lRet = -2 Then
            Me.AsignarMensaje(mComponente.sError, True, True)
        ElseIf lRet = -1 Then
            Me.AsignarMensaje("Alerta. " & vbCrLf & mComponente.sError, True, True)
            Return "Alerta." & vbCrLf & mComponente.sError
        End If

        Me.ucReProgramacion1.Actualizar(mEntidad.ID_ACCION_FORMATIVA_REPROG, Me._nuevo)
        Me.ucReProgramacion1.Limpiar()


        Me.AsignarMensaje("Reprogramacion procesada con Exito!." & vbCrLf & _
                    "Se ha enviado un correo electronico al Supervisor de INSAFORP para que evalue esta Reprogramacion", False, True)

        Me.txtID_ACCION_FORMATIVA_REPROG.Text = mEntidad.ID_ACCION_FORMATIVA_REPROG.ToString()
        Me._nuevo = False

        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub LocalActualizarASISTENCIA_AF(ByRef eASISTENCIA_AF As ASISTENCIA_AF, ByVal dr As SGAFP.DL.DS_DL.ASISTENCIA_AFRow)
        Dim AsistenciaAF As New cASISTENCIA_AF
        With eASISTENCIA_AF
            .FECHA = dr.FECHA
            .INSTRUCTOR = dr.INSTRUCTOR
            .NOTAS = dr.NOTAS
            .CANTIDAD_HORAS = dr.CANTIDAD_HORAS
        End With
        AsistenciaAF.ActualizarASISTENCIA_AF(eASISTENCIA_AF, TipoConcurrencia.Pesimistica)
    End Sub

    Protected Sub LocalAgregarASISTENCIA_AF_HORARIO(ByVal ID_ASISTENCIA_AF As Decimal, ByVal dtID_ASISTENCIA_AF As Decimal, ByVal dt As SGAFP.DL.DS_DL.ASISTENCIA_AF_HORARIODataTable)
        Dim AsistenciaAF_Horario As New cASISTENCIA_AF_HORARIO
        Dim eAsistenciaAF_Horario As ASISTENCIA_AF_HORARIO
        Dim Condicion As New StringBuilder

        Condicion.Append("ID_ASISTENCIA_AF = ")
        Condicion.Append(dtID_ASISTENCIA_AF.ToString)
        For Each dr As ASISTENCIA_AF_HORARIORow In dt.Select(Condicion.ToString, "HORA_INICIO ASC")
            eAsistenciaAF_Horario = New ASISTENCIA_AF_HORARIO

            With eAsistenciaAF_Horario
                .ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
                .ID_ASISTENCIA_AF_HORARIO = 0
                .HORA_INICIO = dr.HORA_INICIO
                .HORA_FIN = dr.HORA_FIN
                .CANTIDAD_MINUTOS = dr.CANTIDAD_MINUTOS
            End With

            AsistenciaAF_Horario.ActualizarASISTENCIA_AF_HORARIO(eAsistenciaAF_Horario, TipoConcurrencia.Pesimistica)
        Next
    End Sub

    Private Function ExisteCambioEnReprogramacion() As Boolean
        Dim mEntidad As ACCION_FORMATIVA
        mEntidad = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Val(Me.txtID_ACCION_FORMATIVA.Text))

        If mEntidad.CODIGO_GRUPO <> Me.txtCODIGO_GRUPO.Text.Trim OrElse _
            mEntidad.NUMERO_PARTICIPANTES <> Val(Me.txtNUMERO_PARTICIPANTES.Text) OrElse _
            mEntidad.HORARIO <> Me.txtHORARIO.Text.Trim OrElse _
            mEntidad.CODI_FORMADOR <> Me.txtCODI_FORMADOR.Text.Trim OrElse _
            ucReProgramacion1.TieneCambios Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub MostrarCentrosFormacion()
        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
    End Sub

    Sub MostrarAreas()
        Me.ddlAREA_FORMACION1.RecuperarPorProveedorSitioEjercicio(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ddlSITIO_CAPACITACION1.SelectedValue, Me.ddlEJERCICIO1.SelectedValue)
    End Sub

    Sub MostrarOfertas()
        If ddlAREA_FORMACION1.SelectedValue = "" Then
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO( _
            -1, ddlPROVEEDOR_AF1.SelectedValue, ddlSITIO_CAPACITACION1.SelectedValue, ddlEJERCICIO1.SelectedValue)
        Else
            Me.ddlOFERTA_FORMATIVA1.RecuperarPorAREA_FORMACION_PROVEEDOR_SITIO_EJERCICIO( _
            ddlAREA_FORMACION1.SelectedValue, ddlPROVEEDOR_AF1.SelectedValue, ddlSITIO_CAPACITACION1.SelectedValue, ddlEJERCICIO1.SelectedValue)
        End If

        MostrarInfoOferta()
    End Sub

    Sub SeleccionarEjercicioActual()
        If Not Me.ddlEJERCICIO1.Items.FindByValue("2010") Is Nothing Then
            Me.ddlEJERCICIO1.SelectedValue = "2010"
        End If
    End Sub

    Sub MostrarInfoOferta()
        If Not Me.ddlOFERTA_FORMATIVA1.SelectedValue = "" Then
            Dim mOferta As New SGAFP.EL.OFERTA_FORMATIVA
            mOferta = (New SGAFP.BL.cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(Me.ddlOFERTA_FORMATIVA1.SelectedValue)
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = Me.ddlOFERTA_FORMATIVA1.SelectedItem.Text
            Me.txtTEMA_CURSO.Text = mOferta.ID_TEMA_CURSO.ToString
            Me.txtCOSTO_X_PARTICIPANTE.Text = mOferta.COSTO_X_PARTICIPANTE.ToString("#.#0")
            Me.txtDURACION_HORAS.Text = mOferta.DURACION_HORAS.ToString
        Else
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
            Me.txtTEMA_CURSO.Text = ""
            Me.txtCOSTO_X_PARTICIPANTE.Text = ""
            Me.txtDURACION_HORAS.Text = ""
        End If
    End Sub

    Protected Sub txtCODI_FORMADOR_ValueChanged(sender As Object, e As EventArgs) Handles txtCODI_FORMADOR.ValueChanged
        Me.txtNOMBRE_FORMADOR.Text = ""

        If Me.txtCODI_FORMADOR.Text.Trim <> "" Then
            Dim lSrvFormadores As New ServicioFORMADOREScliente.ServicioFORMADORESClient
            Dim lEntidad As New ServicioFORMADOREScliente.FORMADOR

            lEntidad = lSrvFormadores.ObtenerFORMADOR_PorNIT(Me.txtCODI_FORMADOR.Text)
            If lEntidad IsNot Nothing Then
                If lEntidad.ID_ESTADO_FORMA <> 1 Then
                    Me.AsignarMensaje("El Formador " + lEntidad.NOMBRES + " " + lEntidad.APELLIDOS + " con numero de NIT: " + Me.txtCODI_FORMADOR.Text.Trim + " no esta acreditado", True, True)
                    Me.txtCODI_FORMADOR.Text = ""
                    Return
                End If
                Me.txtNOMBRE_FORMADOR.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            Else
                Me.txtCODI_FORMADOR.Text = ""
                Me.AsignarMensaje("No existe Formador con numero de NIT: " + Me.txtCODI_FORMADOR.Text.Trim, True, True)
            End If
        End If
    End Sub
End Class
