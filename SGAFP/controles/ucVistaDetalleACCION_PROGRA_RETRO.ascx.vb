Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_PROGRA_RETRO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_PROGRA_RETRO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/09/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_PROGRA_RETRO
    Inherits ucBase

#Region "Propiedades"

    Private _ID_ACCION_PROGRA_RETRO As Decimal
    Public Property ID_ACCION_PROGRA_RETRO() As Decimal
        Get
            Return Me.txtID_ACCION_PROGRA_RETRO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_PROGRA_RETRO = Value
            Me.txtID_ACCION_PROGRA_RETRO.Text = CStr(Value)
            If Me._ID_ACCION_PROGRA_RETRO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property



    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cACCION_PROGRA_RETRO
    Private mEntidad As ACCION_PROGRA_RETRO
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
        If Not Me.ViewState("ID_ACCION_PROGRA_RETRO") Is Nothing Then Me._ID_ACCION_PROGRA_RETRO = Me.ViewState("ID_ACCION_PROGRA_RETRO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ACCION_PROGRA_RETRO
        mEntidad.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO

        If mComponente.ObtenerACCION_PROGRA_RETRO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ACCION_PROGRA_RETRO.Text = mEntidad.ID_ACCION_PROGRA_RETRO.ToString()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Recuperar()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue = mEntidad.ID_PROVEEDOR_AF
        Me.ddlEJERCICIOID_EJERCICIO.Recuperar()
        Me.ddlEJERCICIOID_EJERCICIO.SelectedValue = mEntidad.ID_EJERCICIO
        Me.ddlESTADO_ACCION_FORMATIVA.SelectedValue = mEntidad.CODIGO_ESTADO_AF_PROP
        Me.txtNOMBRE_ACCION_FORMATIVA.Text = mEntidad.NOMBRE_ACCION_FORMATIVA
        Me.txtCODIGO_GRUPO.Text = mEntidad.CODIGO_GRUPO
        Me.deFECHA_EXPIRA.Value = mEntidad.FECHA_EXPIRA
        Me.txtMOTIVO.Text = mEntidad.MOTIVO
        Me.chkACTIVO.Checked = IIf(mEntidad.ACTIVO = 1, True, False)
        Me.txtUSUARIO_CREACION.Text = mEntidad.USUARIO_CREACION
        Me.deFECHA_CREACION.Value = mEntidad.FECHA_CREACION
        Me.txtUSUARIO_PROGRAMO.Text = mEntidad.USUARIO_PROGRAMO
        Me.deFECHA_PROGRAMO.Value = mEntidad.FECHA_PROGRAMO
        Me.ConfigFechaExpira()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Enabled = Me._nuevo
        Me.ddlEJERCICIOID_EJERCICIO.Enabled = Me._nuevo
        Me.ddlESTADO_ACCION_FORMATIVA.Enabled = Me._nuevo
        Me.txtNOMBRE_ACCION_FORMATIVA.Enabled = Me._nuevo
        Me.txtCODIGO_GRUPO.Enabled = Me._nuevo
        Me.deFECHA_EXPIRA.Enabled = Me._nuevo
        Me.txtMOTIVO.Enabled = Me._nuevo
        Me.chkACTIVO.Enabled = Not Me._nuevo AndAlso edicion
        Me.txtUSUARIO_CREACION.Enabled = False
        Me.deFECHA_CREACION.Enabled = False
        Me.txtUSUARIO_PROGRAMO.Enabled = False
        Me.deFECHA_PROGRAMO.Enabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario)

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Recuperar()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.AgregarVacioNumerico()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedIndex = ddlPROVEEDOR_AFID_PROVEEDOR_AF.Items.Count - 1
        Me.ddlEJERCICIOID_EJERCICIO.Recuperar()
        Me.ddlEJERCICIOID_EJERCICIO.SelectedValue = Now.Year
        Me.ddlESTADO_ACCION_FORMATIVA.SelectedIndex = -1
        Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
        Me.txtCODIGO_GRUPO.Text = ""
        Me.deFECHA_EXPIRA.Value = Nothing
        Me.txtMOTIVO.Text = ""
        Me.chkACTIVO.Checked = True

        Me.txtUSUARIO_CREACION.Text = IIf(lUsuario IsNot Nothing, lUsuario.NOMBRE, "")
        Me.deFECHA_CREACION.Value = Now
        Me.txtUSUARIO_PROGRAMO.Text = ""
        Me.deFECHA_PROGRAMO.Value = Nothing
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ACCION_PROGRA_RETRO
        If Me._nuevo Then
            mEntidad.ID_ACCION_PROGRA_RETRO = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = Now
            mEntidad.USUARIO_PROGRAMO = Nothing
            mEntidad.FECHA_PROGRAMO = Nothing
            mEntidad.USERID = Me.ObtenerUsuario
            mEntidad.LASTUPDATE = Now
            mEntidad.ID_ACCION_FORMATIVA = -1
        Else
            mEntidad = mComponente.ObtenerACCION_PROGRA_RETRO(CInt(Me.txtID_ACCION_PROGRA_RETRO.Text))
            mEntidad.USERID = Me.ObtenerUsuario
            mEntidad.LASTUPDATE = Now

            If mEntidad.USUARIO_PROGRAMO IsNot Nothing AndAlso mEntidad.USUARIO_PROGRAMO <> "" Then
                Return "No se puede actualizar la autorizacion porque ya fue utilizada o esta inactiva"
            End If
            If mEntidad.ACTIVO = 0 Then
                Return "No se puede actualizar una autorizacion que esta inactiva"
            End If
        End If

        If Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue = -1 Then
            Return "Seleccione el proveedor"
        End If
        If Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper = "" Then
            Return "Ingrese la descripcion del curso"
        End If
        If Me.txtCODIGO_GRUPO.Text.Trim.ToUpper = "" Then
            Return "Ingrese el codigo del curso"
        End If
        If Me.ddlESTADO_ACCION_FORMATIVA.Text = "" Then
            Return "Seleccione el tipo de estado a autorizar"
        End If
        If Me.deFECHA_EXPIRA.Value = #12:00:00 AM# AndAlso _
            Not (ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoInstructor OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoParticipante _
                 OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.AplicarMontoLiquidacionContrato) Then
            Return "Ingrese la fecha en que expira la autorizacion"
        End If
        If Me.deFECHA_EXPIRA.Value < Today AndAlso _
            Not (ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoInstructor OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoParticipante _
                 OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.AplicarMontoLiquidacionContrato) Then
            Return "La fecha en que expira la autorizacion no puede ser menor a la fecha actual"
        End If
        If Me.txtMOTIVO.Text.Trim.ToUpper = "" Then
            Return "Ingrese el motivo de la autorizacion"
        End If
        If Me.txtMOTIVO.Text.Trim.ToUpper.Length > 2000 Then
            Return "El motivo supera los 2000 caracteres, resuma el motivo de la autorizacion"
        End If

        Dim lista As listaACCION_PROGRA_RETRO = mComponente.ObtenerACCION_PROGRA_RETRO_PorCriterios(Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue, _
                                                                                                    Me.ddlEJERCICIOID_EJERCICIO.SelectedValue, _
                                                                                                    Me.txtCODIGO_GRUPO.Text.Trim.ToUpper, Me.ddlESTADO_ACCION_FORMATIVA.SelectedValue, 1)
        If Me._nuevo AndAlso lista IsNot Nothing AndAlso lista.Count > 0 Then
            Return "Ya existe una autorizacion activa para el curso: " + Me.txtCODIGO_GRUPO.Text.Trim.ToUpper
        End If

        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue
        mEntidad.ID_EJERCICIO = Me.ddlEJERCICIOID_EJERCICIO.SelectedValue
        mEntidad.NOMBRE_ACCION_FORMATIVA = Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim.ToUpper
        mEntidad.CODIGO_GRUPO = Me.txtCODIGO_GRUPO.Text.Trim.ToUpper
        mEntidad.CODIGO_ESTADO_AF_PROP = Me.ddlESTADO_ACCION_FORMATIVA.SelectedValue

        If ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoInstructor OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoParticipante _
            OrElse ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.AplicarMontoLiquidacionContrato  Then
            mEntidad.FECHA_EXPIRA = #12:00:00 AM#
            mEntidad.ACTIVO = 1
        Else
            mEntidad.FECHA_EXPIRA = Me.deFECHA_EXPIRA.Value
            mEntidad.ACTIVO = IIf(Me.chkACTIVO.Checked, 1, 0)
        End If

        mEntidad.MOTIVO = Me.txtMOTIVO.Text.Trim.ToUpper

        If Me._nuevo Then
            'Verificar si se puede obtener el ID_ACCION_FORMATIVA
            Dim listaAccion As listaACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerListaPorCriteriosPeriodo(Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue, -1, -1, "", Me.txtCODIGO_GRUPO.Text, Me.ddlEJERCICIOID_EJERCICIO.SelectedValue)
            If listaAccion IsNot Nothing AndAlso listaAccion.Count > 0 Then
                If listaAccion(0).CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada AndAlso _
                    ddlESTADO_ACCION_FORMATIVA.SelectedValue = Enumeradores.EstadoAccionFormativa.EnMatricula Then
                    Return "El curso se encuentra en el estado FINALIZADO. Revierta el curso a Matricula para poder ingresar la autorización de inscripcion extemporanea de participantes"
                End If
                If listaAccion(0).CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada AndAlso _
                    ddlESTADO_ACCION_FORMATIVA.SelectedValue = Enumeradores.AutorizacionExcepcion.EliminarAccionFormativa Then
                    Return "El curso se encuentra en el estado FINALIZADO. No puede autorizar la eliminacion del curso en este estado"
                End If
                Dim lstInforme As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(listaAccion(0).ID_ACCION_FORMATIVA)
                If lstInforme IsNot Nothing AndAlso lstInforme.Count > 0 AndAlso ddlESTADO_ACCION_FORMATIVA.SelectedValue = Enumeradores.AutorizacionExcepcion.EliminarAccionFormativa Then
                    For i As Integer = 0 To lstInforme.Count - 1
                        If lstInforme(i).ID_ESTADO_INFORME <> EstadoInformeFinal.Emitido Then
                            Return "El curso posee informe(s) entregado(s) no es posible registrar la autorizacion"
                        End If
                    Next
                End If
                mEntidad.ID_ACCION_FORMATIVA = listaAccion(0).ID_ACCION_FORMATIVA
            End If
        End If

        If mComponente.ActualizarACCION_PROGRA_RETRO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ACCION_PROGRA_RETRO.Text = mEntidad.ID_ACCION_PROGRA_RETRO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlESTADO_ACCION_FORMATIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlESTADO_ACCION_FORMATIVA.SelectedIndexChanged
        Me.ConfigFechaExpira()
    End Sub

    Private Sub ConfigFechaExpira()
        If ddlESTADO_ACCION_FORMATIVA.SelectedValue IsNot Nothing AndAlso _
            (ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoInstructor OrElse _
            ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.HorarioSimultaneoParticipante OrElse _
            ddlESTADO_ACCION_FORMATIVA.SelectedValue = AutorizacionExcepcion.AplicarMontoLiquidacionContrato) Then
            Me.deFECHA_EXPIRA.Value = Nothing
            Me.deFECHA_EXPIRA.ClientEnabled = False
        Else
            Me.deFECHA_EXPIRA.ClientEnabled = True
        End If
    End Sub
End Class
