Imports System.Collections.Generic
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.Configuration.ConfigurationManager
Imports System.IO
Imports System.Data

Partial Class controles_ucConsultarDisponibilidadCursos
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.UcBarraNavegacion1.CrearOpcion("Buscar Cursos", "Buscar Cursos", False, "~/imagenes/ButtonSearch.png")
        If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(RolDeUsuario.TecnicoGFI) Then
            Me.UcBarraNavegacion1.CrearOpcion("BaseCursosActivos", "Generar base en excel de cursos activos", False, "~/imagenes/excel.png")
        End If
        Me.UcBarraNavegacion1.CargarOpciones()
        Me.ucListaACCION_FORMATIVA1.AgregarHyperLinkField("ID_ACCION_FORMATIVA,ID_PROVEEDOR_AF,ID_TEMA_CURSO".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=1&ID_ACCION_FORMATIVA={0}&ID_PROVEEDOR_AF={1}&ID_TEMA_CURSO={2}", "Ingresar Solicitud", "_self")
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar Cursos" Then
            Me.BuscarCursos()
        End If
        If CommandName = "BaseCursosActivos" Then
            Dim adapter As New SGAFP.DL.DS_DLTableAdapters.REPORTE_EXCEL_CURSOSTableAdapter
            Dim dt As New SGAFP.DL.DS_DL.REPORTE_EXCEL_CURSOSDataTable

            adapter.FillCursosActivos(dt, Today)
            Me.ExportToExcel(dt, "CursosActivosSGAFP" + Now.ToString("dd-MM-yyyy") + ".xls")
        End If
    End Sub

    Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        Dim GridView1 As New GridView()
        GridView1.AllowPaging = False
        GridView1.DataSource = dt
        GridView1.DataBind()

        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
        Response.Charset = ""
        Response.ContentType = "application/vnd.ms-excel"
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)

        For i As Integer = 0 To GridView1.Rows.Count - 1
            'Apply text style to each Row
            GridView1.Rows(i).Attributes.Add("class", "textmode")
        Next
        GridView1.RenderControl(hw)

        'style to format numbers to string
        Dim style As String = "<style> .textmode{mso-number-format:\@;}</style>"
        Response.Write(style)
        Response.Output.Write(sw.ToString())
        Response.Flush()
        Response.End()
    End Sub

    Private Sub BuscarCursos()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim listaRoles As New List(Of String)
        Dim sbRoles As New StringBuilder

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)
        For i As Integer = 0 To listaRoles.Count - 1
            sbRoles.Append(listaRoles(i))
            If i < listaRoles.Count - 1 Then sbRoles.Append(";")
        Next

        Me.ucListaACCION_FORMATIVA1.CargarDatosPorCriteriosPeriodo(Me.ucCriteriosAccionFormativa1.idProveedor, _
                                                                   Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                                                                   Me.ucCriteriosAccionFormativa1.idAreaFormacion, _
                                                                   Me.ucCriteriosAccionFormativa1.nombreAccionFormativa, _
                                                                   Me.ucCriteriosAccionFormativa1.codigoGrupo, _
                                                                   Me.ucCriteriosAccionFormativa1.idEjercicio, _
                                                                   sbRoles.ToString, _
                                                                   Me.ucCriteriosAccionFormativa1.tdr)
    End Sub

    Protected Sub cDispoCURSOS_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cDispoCURSOS.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        Dim sMensaje As New StringBuilder
        cDispoCURSOS.JSProperties.Clear()
        cDispoCURSOS.JSProperties.Add("cpResultCallback", "")
        cDispoCURSOS.JSProperties.Add("cpAjustarAnchoPopup", False)
        cDispoCURSOS.JSProperties.Add("cpOcultarBotonMensaje", False)

        Select Case parametros(0)
            Case "IngresarSolicitud"
                Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(CDec(parametros(1)))
                Select Case lAccionDetalle.ID_PROGRAMA_FORMACION
                    Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                        Me.ucListaFICHA_PATI1.Limpiar()
                        Me.ucListaFICHA_PATI1.ID_ACCION_FORMATIVA = CDec(parametros(1))
                        cDispoCURSOS.JSProperties("cpResultCallback") = "MostrarFichasPATI"
                    Case Else
                        cDispoCURSOS.JSProperties("cpResultCallback") = "MostrarSolicitud"
                        cDispoCURSOS.JSProperties.Add("cpUrl", "wfSolicitudInscripcion.aspx?modoOp=1&ID_ACCION_FORMATIVA=" + parametros(1).ToString)
                End Select

            Case "BuscarFichasPATI"
                Me.ucListaFICHA_PATI1.CargarDatosPorCallback("BuscarDatos", parametros)

            Case "SolicitarCambioGrupo"
                Dim c As New cmembershipProvider
                Dim deptoMunic As Dictionary(Of String, String)
                Dim TecnicosAsignados As List(Of String)
                Dim listaUsuariosProveedorPartInscrito As New listaUSUARIO
                Dim CorreosProveedorPartInscrito As New List(Of String)
                Dim CorreosCC As New List(Of String)
                Dim CorreosCC0 As New List(Of String)
                Dim bAccionFormativa As New cACCION_FORMATIVA
                Dim bProveedorAF As New cPROVEEDOR_AF
                Dim eAccionFormativaActual As ACCION_FORMATIVA
                Dim eAccionFormativaInscrito As ACCION_FORMATIVA
                Dim listaSolicitudes As listaSOLICITUD_INSCRIPCION_AF
                Dim eFichaPati As PATI.EL.FICHA_PATI
                Dim strCuerpo As New StringBuilder
                Dim eAccionFormativaDetalleActual As ACCION_FORMATIVA_DETALLE

                eAccionFormativaDetalleActual = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(CDec(parametros(1)))

                c = CType(Membership.Provider, cmembershipProvider)
                eAccionFormativaActual = bAccionFormativa.ObtenerACCION_FORMATIVA(CDec(parametros(1)))
                eFichaPati = (New PATI.BL.cFICHA_PATI).ObtenerFICHAporFuenteConvocatoria(CDec(parametros(2)), eAccionFormativaDetalleActual.ID_FUENTE, eAccionFormativaDetalleActual.NO_CONVOCATORIA)

                If eAccionFormativaActual IsNot Nothing Then
                    deptoMunic = bAccionFormativa.ObtenerDeptoMunicipio(CDec(parametros(1)))

                    strCuerpo.AppendLine("Fecha de Notificacion de Solicitud: " + Date.Now.ToString("dd/MM/yyyy h:mm tt"))
                    strCuerpo.Append("El Proveedor de Capacitación " + (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(eAccionFormativaActual.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
                    strCuerpo.AppendLine(" solicita Cambio de Grupo para el participante:")
                    strCuerpo.AppendLine(Trim(eFichaPati.PRIMER_APELLIDO + " " + eFichaPati.SEGUNDO_APELLIDO + " " + eFichaPati.TERCER_APELLIDO) + ", " + Trim(eFichaPati.PRIMER_NOMBRE + " " + eFichaPati.SEGUNDO_NOMBRE + " " + eFichaPati.TERCER_NOMBRE))
                    Dim lDetafami As PATI.EL.DETA_FAMI
                    Dim NumConvenio As String = ""
                    lDetafami = (New PATI.BL.cDETA_FAMI).ObtenerDETA_FAMIPorFichaFuenteConvocatoria(eFichaPati.NUME_FICH, eAccionFormativaDetalleActual.ID_FUENTE, eAccionFormativaDetalleActual.NO_CONVOCATORIA)

                    If lDetafami IsNot Nothing Then
                        NumConvenio = lDetafami.NUME_FAMI.ToString
                    End If
                    strCuerpo.AppendLine("No. Convenio: " + NumConvenio)
                    strCuerpo.AppendLine("No. de Ficha: " + eFichaPati.NUME_FICH.ToString)
                    strCuerpo.Append("Debido a que se va a capacitar en el curso de: " + eAccionFormativaActual.NOMBRE_ACCION_FORMATIVA + " que este proveedor ejecuta en el municipio de ")
                    strCuerpo.Append((New cMUNICIPIO).ObtenerMUNICIPIO(deptoMunic("CODIGO_DEPARTAMENTO"), deptoMunic("CODIGO_MUNICIPIO")).NOMBRE + ", ")
                    strCuerpo.AppendLine((New cDEPARTAMENTO).ObtenerDEPARTAMENTO(deptoMunic("CODIGO_DEPARTAMENTO")).NOMBRE + ".")
                    strCuerpo.AppendLine("")

                    If eFichaPati IsNot Nothing Then
                        Dim listaProgramas As New List(Of Decimal)
                        listaProgramas.Add(Enumeradores.ProgramasFormacion.PATI_BM)
                        listaProgramas.Add(Enumeradores.ProgramasFormacion.PATI_USAID)
                        listaProgramas.Add(Enumeradores.ProgramasFormacion.PATI_2)
                        listaSolicitudes = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorPARTICIPANTE_INSCRITOS_TIPO_SOLICITUD(eFichaPati.ID_PARTICIPANTE, listaProgramas)

                        If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
                            For Each _Solic As SOLICITUD_INSCRIPCION_AF In listaSolicitudes
                                deptoMunic = bAccionFormativa.ObtenerDeptoMunicipio(_Solic.ID_ACCION_FORMATIVA)

                                eAccionFormativaInscrito = bAccionFormativa.ObtenerACCION_FORMATIVA(_Solic.ID_ACCION_FORMATIVA)
                                strCuerpo.AppendLine("El curso en el que actualmente se encuentra inscrito el participante es: ")
                                strCuerpo.AppendLine("Curso: " + eAccionFormativaInscrito.NOMBRE_ACCION_FORMATIVA)
                                strCuerpo.AppendLine("Codigo: " + eAccionFormativaInscrito.CODIGO_GRUPO)
                                strCuerpo.AppendLine("Id de Curso: " + eAccionFormativaInscrito.ID_ACCION_FORMATIVA.ToString)

                                'Obtener el(los) usuario(s) del Proveedor que tiene inscrito el Participante
                                listaUsuariosProveedorPartInscrito = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF((New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(_Solic.ID_ACCION_FORMATIVA).ID_PROVEEDOR_AF)
                            Next
                            strCuerpo.AppendLine("")
                            strCuerpo.AppendLine("Nota importante: ")
                            strCuerpo.Append("Si usted como Proveedor capacito o esta capacitando al Participante, comuniquese con la Gerencia de Formacion Inicial ")
                            strCuerpo.AppendLine("para evaluar el caso, de lo contrario debe registrar el cambio de grupo en el sistema.")

                            'Obtener correos de los usuarios pertenecientes al Proveedor que tiene inscrito el Participante
                            For Each _usuario As USUARIO In listaUsuariosProveedorPartInscrito
                                Dim Correo As String = c.ObtenerEmailPorNombreUsuario(_usuario.USUARIO, True)
                                If Correo <> "" Then
                                    Dim listaRolesDelUsuario As List(Of String)
                                    listaRolesDelUsuario = c.ObtenerRoles(_usuario.USUARIO)
                                    If listaRolesDelUsuario IsNot Nothing AndAlso listaRolesDelUsuario.Contains(RolDeUsuario.ProveedorPATI) Then _
                                        CorreosProveedorPartInscrito.Add(Correo)
                                End If
                            Next

                            'Obtener el usuario del técnico que tiene asignado el centro de formación
                            TecnicosAsignados = (New cMUNICIPIO).ObtenerTECNICO_ASIGNADOS(deptoMunic("CODIGO_DEPARTAMENTO"), deptoMunic("CODIGO_MUNICIPIO"))
                            For Each Tecnico As String In TecnicosAsignados
                                Dim Correo As String = c.ObtenerEmailPorNombreUsuario(Tecnico, True)
                                If Correo <> "" Then
                                    CorreosCC.Add(Correo)
                                End If
                            Next

                            c.EnviarCorreo(c.ObtenerEmailPorNombreUsuario(Me.ObtenerUsuario), _
                                           CorreosProveedorPartInscrito, _
                                           "PROGRAMA PATI - Solicitud de Cambio de Grupo", strCuerpo.ToString)

                            cDispoCURSOS.JSProperties("cpResultCallback") = "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">La solicitud de cambio de Grupo se envió con éxito al Proveedor!.</div>"
                            Return
                        End If
                    End If
                End If
                sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>ERROR</b><br><br>")
                sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">No se logró enviar la Solicitud de cambio de Grupo.</div>")
                cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString


            Case "InscribirParticipantePATI"
                Dim eAccionFormativa As ACCION_FORMATIVA


                eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ucListaFICHA_PATI1.ID_ACCION_FORMATIVA)
                If eAccionFormativa IsNot Nothing Then

                    Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE
                    lAccionFormativaDeta = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(eAccionFormativa.ID_ACCION_FORMATIVA)

                    '   Validar si el participante posee DNC
                    Dim lEntidad As PATI.EL.FICHA_PATI = (New PATI.BL.cFICHA_PATI).ObtenerFICHAporFuenteConvocatoria(CDec(parametros(1)), lAccionFormativaDeta.ID_FUENTE, lAccionFormativaDeta.NO_CONVOCATORIA)

                    If lEntidad IsNot Nothing Then
                        '   Validar que el participante resida en el mismo municipio y sea de la misma convocatoria
                        '   que los participantes del curso siempre y cuando no sea la primera inscripción
                        Dim lNoConvocatoria As Decimal = 0
                        If lAccionFormativaDeta IsNot Nothing Then
                            lNoConvocatoria = lAccionFormativaDeta.NO_CONVOCATORIA
                            If Not (lEntidad.DEPARTAMENTO_RESIDENCIA = lAccionFormativaDeta.CODIGO_DEPARTAMENTO And lEntidad.MUNICIPIO_RESIDENCIA = lAccionFormativaDeta.CODIGO_MUNICIPIO) Then
                                sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE PERTENECE A OTRO MUNICIPIO</b><br><br></div>")
                                sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">El Participante de la Ficha PATI pertenece a un Municipio diferente de los demás participantes del curso.</div>")
                                cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                                Return
                            End If
                        End If
                        Dim lDetaFami As PATI.EL.DETA_FAMI = (New PATI.BL.cDETA_FAMI).ObtenerDETA_FAMIPorFichaFuenteConvocatoria(lEntidad.NUME_FICH, lAccionFormativaDeta.ID_FUENTE, lAccionFormativaDeta.NO_CONVOCATORIA)
                        If lNoConvocatoria = 0 Then lNoConvocatoria = lDetaFami.NO_CONVOCATORIA
                        If lNoConvocatoria <> lDetaFami.NO_CONVOCATORIA Then
                            sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE PERTENECE A OTRA CONVOCATORIA</b><br><br></div>")
                            sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">El Participante de la Ficha PATI pertenece a una Convocatoria diferente de los demás participantes del curso.</div>")
                            cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                            Return
                        End If

                        If lEntidad.ID_PARTICIPANTE <> -1 Then
                            '   Comprobar si el participante esta inscrito en el curso
                            If ObtenerCantidadParticipanteEnCurso(eAccionFormativa.ID_ACCION_FORMATIVA, lEntidad.ID_PARTICIPANTE) > 0 Then
                                sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE ESTA INSCRITO EN ESTE CURSO</b><br><br></div>")
                                sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">El Participante de la Ficha PATI ya se encuentra inscrito en este Grupo. Por favor revise.</div>")
                                cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                                Return
                            End If

                            '   Evaluar al participante dentro del programa PATI
                            Dim lRet As Integer = EvaluarParticipantePATI(lEntidad.ID_PARTICIPANTE, CDec(parametros(1)), eAccionFormativa.ID_ACCION_FORMATIVA)
                            If lRet <> 1 Then
                                Return
                            End If
                        End If
                    Else
                        'Si la fecha de finalización del Curso es mayor o igual al 23/05/2011 el Proveedor debe completar la Ficha de Capacitación
                        If eAccionFormativa.FECHA_FIN_REAL >= #5/20/2011# Then
                            sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE NO POSEE FICHA DE CAPACITACION</b><br><br></div>")
                            sMensaje.Append("<div style=""text-align:justify; font-family:Verdana,Arial; font-size:xx-small;"">El Participante no posee Ficha de Capacitación de INSAFORP. Imprima el formato de Ficha que se encuentra en el menu Documentos opción Ficha PATI y completela con el Participante, despues Cargue nuevamente esta pantalla y Haga clic en la opción <b>Llenar Ficha PATI</b> para ingresar los datos capturados en la Ficha.<br></div>")
                            sMensaje.Append("<div style=""text-align:justify; font-family:Verdana,Arial; font-size:xx-small;"">Una vez que ingrese la Ficha PATI en el sistema podrá inscribir al participante en el curso.<br><br></div>")
                            sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:small;""><A HREF=""javascript:IngresarFichaDNC('" + AppSettings("urlpatidnc") + "?af=" + eAccionFormativa.ID_ACCION_FORMATIVA.ToString + "&nf=" + parametros(1) + "');"">Llenar Ficha PATI</A><br><br></div>")
                            cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                            cDispoCURSOS.JSProperties("cpOcultarBotonMensaje") = True
                            cDispoCURSOS.JSProperties("cpAjustarAnchoPopup") = True
                            Return
                        End If
                    End If

                    Dim Resultado As String = Me.CrearSolicitudFichaPATI(CInt(parametros(1)))
                    Select Case Resultado
                        Case "Participante no aprueba Evaluacion"
                            Return
                        Case ""
                            Me.ucListaFICHA_PATI1.ActualizarCargarDatosCallback()
                            cDispoCURSOS.JSProperties("cpResultCallback") = "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>El Participante de la Ficha PATI se inscribio exitosamente!</b></div>"
                        Case Else
                            cDispoCURSOS.JSProperties("cpResultCallback") = Resultado
                    End Select
                End If
        End Select
    End Sub

    Private Function EvaluarParticipantePATI(ByVal ID_PARTICIPANTE As Decimal, ByVal NUME_FICH As Decimal, ByVal ID_ACCION_FORMATIVA_INSCRIBIRSE As Decimal) As Integer
        Dim lAccionInscribirse As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA_INSCRIBIRSE)
        Dim lAccionInscribirseDeta As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA_INSCRIBIRSE)
        Dim sMensaje As New StringBuilder

        Select Case EstadoParticipanteProgramaPATI(ID_PARTICIPANTE, lAccionInscribirseDeta.ID_PROGRAMA_FORMACION)
            Case 1  '   En Informe Final (Asistencia >= 70%)
                If Me.AccionFormativaInscrito.ID_PROVEEDOR_AF = lAccionInscribirse.ID_PROVEEDOR_AF Then
                    sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE DEL PROGRAMA PATI HA SIDO CAPACITADO</b><br><br></div>")
                    sMensaje.Append("<div style=""text-align:justify; font-family:Verdana,Arial; font-size:xx-small;"">El Participante se ha reportado como capacitado en:<br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">Curso: <b>" + AccionFormativaInscrito.NOMBRE_ACCION_FORMATIVA + "</b><br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">Codigo Grupo: <b>" + AccionFormativaInscrito.CODIGO_GRUPO + "</b><br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">Inicio: <b>" + AccionFormativaInscrito.FECHA_INICIO_REAL.ToString("dd/MM/yyyy") + "</b><br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">Finalizacion: <b>" + AccionFormativaInscrito.FECHA_FIN_REAL.ToString("dd/MM/yyyy") + "</b></div>")
                    cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                    cDispoCURSOS.JSProperties("cpAjustarAnchoPopup") = True
                Else
                    sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE DEL PROGRAMA PATI HA SIDO CAPACITADO</b><br><br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">El Participante se ha reportado como capacitado.</div>")
                    cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                End If
                Return -1

            Case 2  '   Inscrito, sin Informe Final
                If Me.AccionFormativaInscrito.ID_PROVEEDOR_AF = lAccionInscribirse.ID_PROVEEDOR_AF Then
                    sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE ESTA INSCRITO EN ESTE CURSO</b><br><br></div>")
                    sMensaje.Append("<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;"">El Participante de la Ficha PATI se encuentra inscrito en el Grupo <b>" + Me.AccionFormativaInscrito.CODIGO_GRUPO + "</b>. Por favor revise.</div>")
                    cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                    cDispoCURSOS.JSProperties("cpAjustarAnchoPopup") = True
                Else
                    sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;""><b>PARTICIPANTE ESTA INSCRITO EN OTRO GRUPO</b><br><br></div>")
                    sMensaje.Append("<div style=""text-align:justify; font-family:Verdana,Arial; font-size:xx-small;"">El Participante de la Ficha PATI ya se encuentra inscrito en otro Grupo de Capacitacion. Haga clic en la opción <b>Solicitar Cambio de Grupo al Proveedor</b> para que el sistema envíe una solicitud de cambio al Proveedor: <b>" + (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(AccionFormativaInscrito.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR + "</b><br><br></div>")
                    sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:small;""><A HREF=""javascript:SolicitarCambioGrupo(" + lAccionInscribirse.ID_ACCION_FORMATIVA.ToString + "," + NUME_FICH.ToString + ");"">Solicitar Cambio de Grupo al Proveedor</A></div>")
                    cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                    cDispoCURSOS.JSProperties("cpOcultarBotonMensaje") = True
                    cDispoCURSOS.JSProperties("cpAjustarAnchoPopup") = True
                End If
                Return -1

            Case 3  '   En Informe Final (Asistencia < 70%)
                Dim lParticipanteAf As PARTICIPANTE_AF
                lParticipanteAf = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(ID_PARTICIPANTE, Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA)

                Dim eAccionFormativaDetalle As New ACCION_FORMATIVA_DETALLE
                eAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA)

                'Determinar la Convocatoria del Curso en la que se inscribió el participante y en la que se inscribirá                
                Dim lNo_ConvocatoriaInscribio As Decimal = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA).NO_CONVOCATORIA
                Dim lNo_ConvocatoriaInscribirse As Decimal = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA_INSCRIBIRSE).NO_CONVOCATORIA

                If lParticipanteAf IsNot Nothing AndAlso lParticipanteAf.ID_SOLICITUD > 0 AndAlso lParticipanteAf.PORC_ASISTENCIA < 70 Then
                    If lNo_ConvocatoriaInscribio = lNo_ConvocatoriaInscribirse Then
                        Dim lbSolicitud As New cSOLICITUD_INSCRIPCION_AF
                        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF = lbSolicitud.ObtenerSOLICITUD_INSCRIPCION_AF(lParticipanteAf.ID_SOLICITUD)
                        lSolicitud.ID_ESTADO_SOLICITUD = EstadoSolicitud.CambioDeCursoPorSistema
                        lSolicitud.LASTUPDATE = Now
                        lSolicitud.USERID = Me.ObtenerUsuario
                        If lbSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud, TipoConcurrencia.Pesimistica, "CAMBIO DE GRUPO GENERADO POR EL SISTEMA. PARTICIPANTE SE INSCRIBE EN CURSO: " + lAccionInscribirse.NOMBRE_ACCION_FORMATIVA + "  ID: " + lAccionInscribirse.ID_ACCION_FORMATIVA.ToString + "  CODIGO: " + lAccionInscribirse.CODIGO_GRUPO) <> 1 Then
                            sMensaje.Append("<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">Error al intentar Cambiar de Grupo al Participante</div>")
                            cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                            Return -1
                        End If
                    End If
                End If
        End Select
        Return 1
    End Function


    Private Function ObtenerCantidadParticipanteEnCurso(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal) As Decimal
        Dim Detalle As listaSOLICITUD_INSCRIPCION_AF
        Dim criterios As New List(Of SGAFP.EL.Criteria)

        criterios.Add(New SGAFP.EL.Criteria("ID_ACCION_FORMATIVA", "=", ID_ACCION_FORMATIVA, " AND "))
        criterios.Add(New SGAFP.EL.Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE, ""))
        Detalle = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorBusqueda(New SOLICITUD_INSCRIPCION_AF, criterios.ToArray)

        If Detalle IsNot Nothing Then
            Return Detalle.Count
        End If
        Return 0
    End Function

    Dim _AccionFormativaInscrito As ACCION_FORMATIVA
    Private Property AccionFormativaInscrito() As ACCION_FORMATIVA
        Get
            Return _AccionFormativaInscrito
        End Get
        Set(ByVal value As ACCION_FORMATIVA)
            _AccionFormativaInscrito = value
        End Set
    End Property

    'Devuelve el estado en el que se encuentra un participante en el Programa PATI
    '0: No capacitado
    '1: En Informe Final (Asistencia >= Asistencia Mínima Requerida)
    '2: Inscrito, sin Informe Final
    '3: En Informe Final (Asistencia < Asistencia Mínima Requerida)
    Private Function EstadoParticipanteProgramaPATI(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal) As Integer
        Dim bProgramaFormacion As New cPROGRAMA_FORMACION
        Dim lResultados As New Dictionary(Of Integer, ACCION_FORMATIVA)
        Dim listaSolicitudes As listaSOLICITUD_INSCRIPCION_AF
        Dim lTiposProgramas As New List(Of Decimal)
        Dim lCriterios As List(Of Criteria)
        If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_2 Then
            lTiposProgramas.Add(Enumeradores.ProgramasFormacion.PATI_2)
        Else
            lTiposProgramas.Add(Enumeradores.ProgramasFormacion.PATI_USAID)
            lTiposProgramas.Add(Enumeradores.ProgramasFormacion.PATI_BM)
            lTiposProgramas.Add(Enumeradores.ProgramasFormacion.PATI_2)
        End If
        listaSolicitudes = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorPARTICIPANTE_INSCRITOS_TIPO_SOLICITUD(ID_PARTICIPANTE, lTiposProgramas)

        If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
            For Each _Solic As SOLICITUD_INSCRIPCION_AF In listaSolicitudes
                Dim lAccionFormativaInscrito As ACCION_FORMATIVA
                Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE
                Dim lInformes As listaINFORME_FINAL_AF

                lAccionFormativaInscrito = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(_Solic.ID_ACCION_FORMATIVA)
                lAccionFormativaDeta = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(_Solic.ID_ACCION_FORMATIVA)
                lInformes = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(_Solic.ID_ACCION_FORMATIVA)

                'Si el Curso no se encuentra INGRESADO, MATRICULA, INICIADO, FINALIZADO, EN SOLIC. REPROGRAMACION
                'entonces el Centro ha presentado Informe Final, verificar si el % de Asistencia es mayor o igual al 80%
                If lInformes IsNot Nothing AndAlso lInformes.Count > 0 Then
                    lCriterios = New List(Of Criteria)
                    Dim lDetalleInformeFinal As listaINFORME_FINAL_DET

                    lCriterios.Add(New Criteria("ID_ACCION_FORMATIVA", "=", _Solic.ID_ACCION_FORMATIVA, "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", _Solic.ID_PARTICIPANTE, ""))
                    lDetalleInformeFinal = (New cINFORME_FINAL_DET).ObtenerListaPorBusqueda(New INFORME_FINAL_DET, lCriterios.ToArray)

                    If lDetalleInformeFinal IsNot Nothing AndAlso lDetalleInformeFinal.Count > 0 Then
                        For Each lDetaParticipante As INFORME_FINAL_DET In lDetalleInformeFinal
                            If (lAccionFormativaDeta.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_USAID AndAlso lDetaParticipante.PORC_ASISTENCIA >= bProgramaFormacion.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_USAID).PORC_ASISTENCIA_MINIMA) OrElse _
                               (lAccionFormativaDeta.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_BM AndAlso lDetaParticipante.PORC_ASISTENCIA >= bProgramaFormacion.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_BM).PORC_ASISTENCIA_MINIMA) OrElse _
                               (lAccionFormativaDeta.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_2 AndAlso lDetaParticipante.PORC_ASISTENCIA >= bProgramaFormacion.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_2).PORC_ASISTENCIA_MINIMA) Then
                                If Not lResultados.ContainsKey(1) Then lResultados.Add(1, lAccionFormativaInscrito)
                            Else
                                If Not lResultados.ContainsKey(3) Then lResultados.Add(3, lAccionFormativaInscrito)
                            End If
                        Next
                    End If
                Else
                    lCriterios = New List(Of Criteria)
                    Dim lDetalleParticipante As listaPARTICIPANTE_AF

                    lCriterios.Add(New Criteria("ID_ACCION_FORMATIVA", "=", _Solic.ID_ACCION_FORMATIVA, "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", _Solic.ID_PARTICIPANTE, ""))
                    lDetalleParticipante = (New cPARTICIPANTE_AF).ObtenerListaPorBusqueda(New PARTICIPANTE_AF, lCriterios.ToArray)

                    If lDetalleParticipante IsNot Nothing AndAlso lDetalleParticipante.Count > 0 Then
                        If Not lResultados.ContainsKey(2) Then lResultados.Add(2, lAccionFormativaInscrito)
                    End If
                End If
            Next
        End If

        If lResultados.ContainsKey(1) Then
            Me.AccionFormativaInscrito = lResultados(1)
            Return 1
        ElseIf lResultados.ContainsKey(2) Then
            Me.AccionFormativaInscrito = lResultados(2)
            Return 2
        ElseIf lResultados.ContainsKey(3) Then
            Me.AccionFormativaInscrito = lResultados(3)
            Return 3
        Else
            Return 0
        End If
    End Function

    Private Function CrearSolicitudFichaPATI(ByVal NUME_FICH As Integer) As String
        Dim bFichaPATI As New cFICHA_PATI
        Dim eFichaPATI As PATI.EL.FICHA_PATI
        Dim bDetaFAMI As New cDETA_FAMI
        Dim eDetaFAMI As PATI.EL.DETA_FAMI

        Dim bSolicitud As New cSOLICITUD_INSCRIPCION_AF
        Dim eSolicitud As New SOLICITUD_INSCRIPCION_AF
        Dim eParticipante As New PARTICIPANTE
        Dim eAccionFormativa As New ACCION_FORMATIVA
        Dim eAccionFormativaDetalle As New ACCION_FORMATIVA_DETALLE
        eAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.ucListaFICHA_PATI1.ID_ACCION_FORMATIVA)

        eDetaFAMI = bDetaFAMI.ObtenerDETA_FAMIPorFichaFuenteConvocatoria(NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA)
        eFichaPATI = bFichaPATI.ObtenerFICHAporFuenteConvocatoria(NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA)
        If eFichaPATI Is Nothing Then

            If bFichaPATI.AgregarFichaPatiDesdeFichaFISDL(eFichaPATI.NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA) <> 1 Then
                ExceptionManager.Publish(New Exception(bFichaPATI.sError + vbCrLf + bFichaPATI.sErrorTecnico))
                Return "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><center><b>Error al Agregar Ficha PATI.</b></center><br>" + _
                        bSolicitud.sError + "</div>"
            End If
            eFichaPATI = bFichaPATI.ObtenerFICHAporFuenteConvocatoria(NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA)
        End If

        With eSolicitud
            .ID_SOLICITUD = 0
            .ID_TIPO_SOLICITUD = Utilerias.ObtenerTipoSolicitudPorFuente(CInt(eDetaFAMI.ID_FUENTE))
            eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ucListaFICHA_PATI1.ID_ACCION_FORMATIVA)
            .FECHA_PRESENTACION = eAccionFormativa.FECHA_INICIO_REAL
            .ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
            .ID_ACCION_FORMATIVA = Me.ucListaFICHA_PATI1.ID_ACCION_FORMATIVA
            .ID_PARTICIPANTE = 0
            .NOMBRES = String.Concat(eFichaPATI.PRIMER_NOMBRE, " ", eFichaPATI.SEGUNDO_NOMBRE, " ", eFichaPATI.TERCER_NOMBRE).Trim
            .APELLIDOS = String.Concat(eFichaPATI.PRIMER_APELLIDO, " ", eFichaPATI.SEGUNDO_APELLIDO).Trim
            Select Case True
                Case eFichaPATI.ID_PARTICIPANTE > 0
                    eParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(eFichaPATI.ID_PARTICIPANTE)
                    If eParticipante IsNot Nothing AndAlso eParticipante.ID_PARTICIPANTE > 0 Then
                        .ID_PARTICIPANTE = eParticipante.ID_PARTICIPANTE
                    End If

                Case eDetaFAMI.NUME_DOCU_IDEN.Trim <> "" AndAlso eDetaFAMI.TIPO_DOCU_IDEN = CDec(1)
                    Dim listaPart As listaPARTICIPANTE
                    listaPart = (New cPARTICIPANTE).ObtenerListaPorDUI(eDetaFAMI.NUME_DOCU_IDEN.Trim)

                    If listaPart IsNot Nothing AndAlso listaPart.Count > 0 Then
                        If listaPart(0).NOMBRES.Trim <> .NOMBRES.Trim OrElse listaPart(0).APELLIDOS.Trim <> .APELLIDOS.Trim Then
                            Return "Ya existe un perfil de participante con el mismo DUI pero con diferente Nombre/Apellido"
                        End If
                        .ID_PARTICIPANTE = listaPart(0).ID_PARTICIPANTE
                    End If
            End Select

            If .ID_PARTICIPANTE > 0 Then
                Dim lRet As Integer = EvaluarParticipantePATI(.ID_PARTICIPANTE, NUME_FICH, .ID_ACCION_FORMATIVA)
                If lRet <> 1 Then
                    Return "Participante no aprueba Evaluacion"
                End If
            End If

            '   ***     SECCIÓN 1. DATOS DE IDENTIFICACIÓN                      
            .DUI = Leer_Valor(eFichaPATI.DUI).Trim
            .NIT = ""
            .ISSS = ""
            If eFichaPATI.CARNET_MINORIDAD IsNot Nothing AndAlso eFichaPATI.CARNET_MINORIDAD.Trim <> "" Then
                .NUM_DOCTO = eFichaPATI.CARNET_MINORIDAD.Trim
                .TIPO_DOCTO = 1
            ElseIf eFichaPATI.PASAPORTE IsNot Nothing AndAlso eFichaPATI.PASAPORTE.Trim <> "" Then
                .NUM_DOCTO = eFichaPATI.PASAPORTE.Trim
                .TIPO_DOCTO = 2
            Else
                .NUM_DOCTO = ""
                .TIPO_DOCTO = -1
            End If
            .ID_PAIS = eFichaPATI.PAIS
            .DEPARTAMENTO_NAC = eFichaPATI.DEPARTAMENTO_NACIMIENTO
            .MUNICIPIO_NAC = eFichaPATI.MUNICIPIO_NACIMIENTO
            .FECHA_NACIMIENTO = eFichaPATI.FECHA_NACIMIENTO
            If eFichaPATI.SEXO = 1 Then
                .GENERO = "M"
            Else
                .GENERO = "F"
            End If
            .EDAD = eFichaPATI.EDAD
            .MIEMBROS_GRUPO_FAMILIAR = eFichaPATI.PERSONAS_GRUPO_FAMILIAR
            .ID_ESTADO_CIVIL = eFichaPATI.ESTADO_FAMILIAR
            Select Case eFichaPATI.ES_JEFE_DE_HOGAR
                Case 1 To 3
                    .ES_JEFE_HOGAR = eFichaPATI.ES_JEFE_DE_HOGAR
                Case Else
                    .ES_JEFE_HOGAR = -1
            End Select
            Select Case eFichaPATI.TIENE_HIJOS
                Case 1
                    .TIENE_HIJOS = 1
                    .NO_DE_HIJOS = eFichaPATI.NO_DE_HIJOS
                Case 2
                    .TIENE_HIJOS = 2
                    .NO_DE_HIJOS = -1
                Case Else
                    .TIENE_HIJOS = -1
                    .NO_DE_HIJOS = -1
            End Select
            Select Case eFichaPATI.SE_DEDICA_ALGUNA_PROFESION
                Case 1
                    .SE_DEDICA_ALGUNA_PROFESION = 1
                    .PROFESION_OFICIO = Leer_Valor(eFichaPATI.PROFESION_SE_DEDICA).Trim
                Case Else
                    .SE_DEDICA_ALGUNA_PROFESION = 2
                    .PROFESION_OFICIO = ""
            End Select
            .DIRECCION = eFichaPATI.DIRECCION
            .CODIGO_DEPARTAMENTO = Leer_Valor(eFichaPATI.DEPARTAMENTO_RESIDENCIA)
            .CODIGO_MUNICIPIO = Leer_Valor(eFichaPATI.MUNICIPIO_RESIDENCIA)
            .TELEFONO = Leer_Valor(eFichaPATI.TELEFONO_FIJO).Trim
            .MOVIL = Leer_Valor(eFichaPATI.TELEFONO_MOVIL).Trim
            .EMAIL = Leer_Valor(eFichaPATI.CORREO_ELECTRONICO).Trim

            If eFichaPATI.DISCAPACITADO_PERMANENTE = 1 AndAlso _
              (eFichaPATI.DISCAP_MOVERSE_CAMINAR = 1 OrElse eFichaPATI.DISCAP_USAR_BRAZOS = 1 OrElse _
                eFichaPATI.DISCAP_VER = 1 OrElse eFichaPATI.DISCAP_OIR OrElse eFichaPATI.DISCAP_HABLAR = 1 OrElse _
                eFichaPATI.DISCAP_RETRASO = 1 OrElse eFichaPATI.DISCAP_BANARSE = 1 OrElse Leer_Valor(eFichaPATI.DISCAP_EXPLIQUE).Trim <> "") Then
                .CON_DISCAPACIDAD = 1
                .DISC_OTRA = Leer_Valor(eFichaPATI.DISCAP_EXPLIQUE).Trim
                .DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF = AsignarDiscapacidadesSeleccionadas(eFichaPATI)
            Else
                .CON_DISCAPACIDAD = 2
            End If

            '   ***     SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL
            If eFichaPATI.SABE_LEER_ESCRIBIR = 1 Then
                .ID_LEE_ESCRIBE = 1
            ElseIf eFichaPATI.SOLO_ESCRIBE = 1 AndAlso eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 6
            ElseIf eFichaPATI.SOLO_LEE = 1 AndAlso eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 5
            ElseIf eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 4
            ElseIf eFichaPATI.SOLO_ESCRIBE = 1 Then
                .ID_LEE_ESCRIBE = 3
            ElseIf eFichaPATI.SOLO_LEE = 1 Then
                .ID_LEE_ESCRIBE = 2
            Else
                .ID_LEE_ESCRIBE = 1
            End If

            If eFichaPATI.UNIVERSITARIA = 1 Then
                .ID_NIVEL_ACADEMICO = 23
            ElseIf eFichaPATI.UNIVERSITARIA = 2 Then
                .ID_NIVEL_ACADEMICO = 22
            ElseIf eFichaPATI.TECNOLOGICA = 1 Then
                .ID_NIVEL_ACADEMICO = 21
            ElseIf eFichaPATI.TECNOLOGICA = 2 Then
                .ID_NIVEL_ACADEMICO = 20
            ElseIf eFichaPATI.BACHILLERATO = 1 Then
                .ID_NIVEL_ACADEMICO = 19
            ElseIf eFichaPATI.BACHILLERATO = 2 Then
                .ID_NIVEL_ACADEMICO = 18
            ElseIf eFichaPATI.EDUCACION_BASICA >= 1 AndAlso eFichaPATI.EDUCACION_BASICA <= 10 Then
                .ID_NIVEL_ACADEMICO = eFichaPATI.EDUCACION_BASICA + 7
            Else
                .ID_NIVEL_ACADEMICO = 8
            End If

            .OTRA_EDUCACION_FORMAL = Leer_Valor(eFichaPATI.OTRA_EDUCACION_FORMAL).Trim
            .TITULO_CERTIFICADO_OBTENIDO = Leer_Valor(eFichaPATI.TITULO_OBTENIDO).Trim

            If eFichaPATI.HA_DEJADO_DE_ESTUDIAR = 1 Then
                .ESTUDIA_ACTUALMENTE = 2
                Select Case eFichaPATI.TIEMPO_DEJO_ESTUDIAR
                    Case 1
                        .ID_TIEMPO_DEJO_ESTUDIAR = 4
                    Case 2
                        .ID_TIEMPO_DEJO_ESTUDIAR = 5
                    Case 3
                        .ID_TIEMPO_DEJO_ESTUDIAR = 3
                    Case 4
                        .ID_TIEMPO_DEJO_ESTUDIAR = 6
                    Case Else
                        .ID_TIEMPO_DEJO_ESTUDIAR = 6
                End Select
            ElseIf eFichaPATI.HA_DEJADO_DE_ESTUDIAR = 2 Then
                .ESTUDIA_ACTUALMENTE = 1
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
            Else
                .ESTUDIA_ACTUALMENTE = 1
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
            End If

            If eFichaPATI.HA_RECIBIDO_CURSOS = 1 OrElse eFichaPATI.HA_RECIBIDO_CURSOS = 2 Then
                .RECIBIO_CURSO_ANTERIOR = eFichaPATI.HA_RECIBIDO_CURSOS
            Else
                .RECIBIO_CURSO_ANTERIOR = 2
            End If
            .BENEF_CAMB_EMP_X_CURSO = eFichaPATI.SIRVIO_CAPAC_CAMBIAR_EMPLEO
            .BENEF_OBT_EMPLEO = eFichaPATI.SIRVIO_CAPAC_OBTENER_EMPLEO
            .BENEF_OBT_ING_EXTRA = eFichaPATI.SIRVIO_CAPAC_OTROS_INGRESOS
            .BENEF_OTRO = eFichaPATI.SIRVIO_CAPAC_OTRO
            .BENEF_PROM_EMP_ACT = eFichaPATI.SIRVIO_CAPAC_PROMOCION
            .BENEF_TRAB_CTA_PROPIA = eFichaPATI.SIRVIO_CAPAC_TRAB_CTA_PROPIA
            .RAZON_NO_BENEFICIO = Leer_Valor(eFichaPATI.PORQUE_NO_RECIB_BENEFICIO).Trim

            '   ***     SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL
            .OCUACT_ESTUDIA = eFichaPATI.OTRA_ACTIVIDAD_ESTUDIA
            .OCUACT_OFICIO_HOGAR = eFichaPATI.OTRA_ACTIVIDAD_OFICIOS_HOGAR
            .OCUACT_TRABAJA = (eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT = 1 OrElse eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT_REM = 1)
            .OCUACT_BUSCA_TRABAJO = eFichaPATI.OTRA_ACTIVIDAD_BUSCA_TRABAJO
            .OCUACT_OTRA = Leer_Valor(eFichaPATI.OTRA_ACTIVIDAD_OTRA).Trim

            If eFichaPATI.TIPO_DE_EMPLEO_TIEMPO_COMP = 1 Then
                .ID_TIPO_EMPLEO = 1
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_MEDIO_TIEMPO = 1 Or eFichaPATI.TIPO_DE_EMPLEO_POR_HORAS = 1 Then
                .ID_TIPO_EMPLEO = 2
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_TEMPORAL = 1 Then
                .ID_TIPO_EMPLEO = 3
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_NEG_FAMILIAR = 1 Then
                .ID_TIPO_EMPLEO = 4
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_CTA_PROPIA = 1 Then
                .ID_TIPO_EMPLEO = 5
            ElseIf Leer_Valor(eFichaPATI.TIPO_DE_EMPLEO_OTRO).Trim <> "" Then
                .ID_TIPO_EMPLEO = 7
                .TIPO_EMPLEO_OTRO = Leer_Valor(eFichaPATI.TIPO_DE_EMPLEO_OTRO).Trim
            Else
                .ID_TIPO_EMPLEO = -1
            End If
            .SECTOR_EMPLEO = -1

            If eFichaPATI.HA_TRABAJADO_ANTES = 1 AndAlso eFichaPATI.TIEMPO_QUE_NO_TRABAJA <> -1 Then
                .TRABAJO_ANTERIOR = "S"
            Else
                .TRABAJO_ANTERIOR = "N"
            End If

            '   ***     SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS
            Select Case CInt(eFichaPATI.RECIBE_INGRESOS)
                Case 1, 2
                    .RECIBE_INGRESOS = eFichaPATI.RECIBE_INGRESOS
                Case Else
                    .RECIBE_INGRESOS = -1
            End Select
            .MANERA_OBT_ING_AYUDA_FAM = eFichaPATI.MAN_OBTIENE_ING_AYUDA_FAM
            .MANERA_OBT_ING_PENSION = eFichaPATI.MAN_OBTIENE_ING_PENSION
            .MANERA_OBT_ING_REMESA = eFichaPATI.MAN_OBTIENE_ING_REMESA
            .MANERA_OBT_ING_TRABAJO = eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT
            .MANERA_OBT_ING_OTRO = Leer_Valor(eFichaPATI.MAN_OBTIENE_ING_OTRA).Trim

            '   ***     SECCIÓN 5. EXPECTATIVAS RESPECTO A LA FORMACIÓN - EXPECTATIVAS LABORALES
            .EXPFOR_OBTENER_EMPLEO = eFichaPATI.LOGROS_ESPERADOS_EMPLEO_FORMAL
            .EXPFOR_TRABAJAR_CTA_PROPIA = eFichaPATI.LOGROS_ESPERADOS_CUENTA_PROPIA
            .EXPFOR_OTRO = Leer_Valor(eFichaPATI.LOGROS_ESPERADOS_OTRO).Trim

            .CURSO_REL_TRAB_NUEVO = 1

            '   ***     SECCIÓN 6. SEGUIMIENTO
            .NOMBRE_REFERENCIA = eFichaPATI.NOMBRES_CONOCIDO
            Select Case eFichaPATI.PARENTESCO
                Case 1
                    .ID_REFERENCIA = 26
                Case 2
                    .ID_REFERENCIA = 2
                Case Else
                    .ID_REFERENCIA = 16
            End Select
            .DIRECCION_REFERENCIA = Leer_Valor(eFichaPATI.DIRECCION_CONOCIDO).Trim
            .DEPARTAMENTO_REFERENCIA = Leer_Valor(eFichaPATI.DEPARTAMENTO_CONOCIDO).Trim
            .MUNICIPIO_REFERENCIA = Leer_Valor(eFichaPATI.MUNICIPIO_CONOCIDO)
            .TELEFONO_REFERENCIA = Leer_Valor(eFichaPATI.TELEFONO_FIJO_CONOCIDO).Trim
            .MOVIL_REFERENCIA = Leer_Valor(eFichaPATI.TELEFONO_MOVIL).Trim
            .EMAIL_REFERENCIA = Leer_Valor(eFichaPATI.EMAIL_CONOCIDO).Trim
            .SUGERENCIAS = Leer_Valor(eFichaPATI.OBSERVACIONES_SUGERENCIAS).Trim
            .USERID = ObtenerUsuario()
            .LASTUPDATE = Now

            If bSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(eSolicitud, TipoConcurrencia.Pesimistica, .SUGERENCIAS) <> 1 Then
                ExceptionManager.Publish(New Exception(bSolicitud.sError + vbCrLf + bSolicitud.sErrorTecnico))
                Return "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><center><b>Error al Inscribir al Participante.</b></center><br>" + _
                        bSolicitud.sError + "</div>"
            Else
                'Dim lbAccionPATI As New cACCION_FORMATIVA_PATI
                'Dim lAccionPATI As ACCION_FORMATIVA_PATI = lbAccionPATI.ObtenerACCION_FORMATIVA_PATI(.ID_ACCION_FORMATIVA)
                'If lAccionPATI Is Nothing Then
                '    lbAccionPATI.AgregarACCION_FORMATIVA_PATI(.ID_ACCION_FORMATIVA, eDetaFAMI.ID_FUENTE, _
                '            .CODIGO_DEPARTAMENTO, .CODIGO_MUNICIPIO, (New PATI.BL.cDETA_FAMI).ObtenerDETA_FAMI(NUME_FICH).NO_CONVOCATORIA, _
                '             Me.ObtenerUsuario, Now)
                'End If
                eFichaPATI.ID_PARTICIPANTE = eSolicitud.ID_PARTICIPANTE
                eFichaPATI.USERID = Me.ObtenerUsuario
                eFichaPATI.LASTUPDATE = Now
                bFichaPATI.ActualizarFICHA_PATI(eFichaPATI)
            End If

            '       Cursos de capacitación recibidos
            GuardarCursoRecibidos(eSolicitud.ID_SOLICITUD, eFichaPATI)

            '       Empleo Anterior
            GuardarEmpleoAnterior(eSolicitud.ID_SOLICITUD, eFichaPATI)
        End With

        Return ""
    End Function

    Private Function Leer_Valor(ByVal valor As String) As String
        If valor Is Nothing Then
            valor = ""
        End If
        Return valor
    End Function

    Private Sub GuardarEmpleoAnterior(ByVal ID_SOLICITUD As Decimal, ByVal eFichaPATI As PATI.EL.FICHA_PATI)
        If eFichaPATI.TIEMPO_QUE_NO_TRABAJA <> -1 Then
            Dim bEmpleoAnterior As New cSOLIC_EMPLEO_ANTERIOR
            Dim eEmpleoAnterior As New SOLIC_EMPLEO_ANTERIOR

            eEmpleoAnterior.ID_SOLICITUD = ID_SOLICITUD
            eEmpleoAnterior.ID_EMPLEO_ANT = 0
            Select Case eFichaPATI.TIEMPO_QUE_NO_TRABAJA
                Case 1 To 4
                    eEmpleoAnterior.TIEMPO_NO_TRABAJA = eFichaPATI.TIEMPO_QUE_NO_TRABAJA
                Case Else
                    eEmpleoAnterior.TIEMPO_NO_TRABAJA = -1
            End Select

            If bEmpleoAnterior.ActualizarSOLIC_EMPLEO_ANTERIOR(eEmpleoAnterior) <> 1 Then
                ExceptionManager.Publish(New Exception(bEmpleoAnterior.sError + vbCrLf + bEmpleoAnterior.sErrorTecnico))
                Me.AsignarMensaje("Error al Guardar Empleo Anterior. " + vbCrLf + bEmpleoAnterior.sError, True, True)
            End If
        End If
    End Sub

    Private Sub GuardarCursoRecibidos(ByVal ID_SOLICITUD As Decimal, ByVal eFichaPATI As PATI.EL.FICHA_PATI)
        Dim bCursos As New cSOLIC_CURSOS_RECIBIDOS
        Dim eCurso As SOLIC_CURSOS_RECIBIDOS

        If eFichaPATI.HA_RECIBIDO_CURSOS = 1 AndAlso (eFichaPATI.CURSO_1 <> "" OrElse eFichaPATI.CURSO_2 <> "" OrElse eFichaPATI.CURSO_3 <> "") Then
            If eFichaPATI.CURSO_1 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_1 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_CURSO_RECIBIDO = 0
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_1
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_1
                eCurso.ANIO = eFichaPATI.ANO_CURSO_1
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If

            If eFichaPATI.CURSO_2 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_2 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_2
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_2
                eCurso.ANIO = eFichaPATI.ANO_CURSO_2
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If

            If eFichaPATI.CURSO_3 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_3 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_3
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_3
                eCurso.ANIO = eFichaPATI.ANO_CURSO_3
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If
        End If
    End Sub

    Private Function AsignarDiscapacidadesSeleccionadas(ByVal eFichaPATI As PATI.EL.FICHA_PATI) As listaDISCA_POR_SOLICITUD
        Dim listaDiscapacidades As New listaDISCA_POR_SOLICITUD
        Dim DiscSeleccionada As Boolean

        For IdDiscap As Integer = 1 To 8
            Select Case IdDiscap
                Case 1
                    DiscSeleccionada = (eFichaPATI.DISCAP_MOVERSE_CAMINAR = 1)
                Case 2
                    DiscSeleccionada = (eFichaPATI.DISCAP_USAR_BRAZOS = 1)
                Case 3
                    DiscSeleccionada = (eFichaPATI.DISCAP_VER = 1)
                Case 4
                    DiscSeleccionada = (eFichaPATI.DISCAP_OIR = 1)
                Case 5
                    DiscSeleccionada = (eFichaPATI.DISCAP_HABLAR = 1)
                Case 6
                    DiscSeleccionada = (eFichaPATI.DISCAP_RETRASO = 1)
                Case 7
                    DiscSeleccionada = (eFichaPATI.DISCAP_BANARSE = 1)
                Case 8
                    DiscSeleccionada = (eFichaPATI.DISCAP_EXPLIQUE.Trim <> "")
                Case Else
                    DiscSeleccionada = False
            End Select

            If DiscSeleccionada Then
                Dim DiscapSolic As New DISCA_POR_SOLICITUD
                DiscapSolic.ID_SOLICITUD = 0
                DiscapSolic.ID_DISCAPACIDAD = IdDiscap

                listaDiscapacidades.Add(DiscapSolic)
            End If
        Next

        Return listaDiscapacidades
    End Function

End Class
