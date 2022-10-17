Imports DevExpress.Web
Imports System.Collections.Generic
Imports System.Configuration.ConfigurationManager
Imports Subgurim.Web
Imports System.Data

Partial Class Mapas_wfMapa
    Inherits System.Web.UI.Page

    Dim ds As DataSet
    Dim listaCentrosFormacion As New listaSITIO_CAPACITACION
    Dim listaMunicipiosSS As New listaMUNICIPIO
    Dim listaDeptosPresencia As New listaDEPARTAMENTO
    Dim listaFaseMunicipios As New listaFASE_MUNICIPIOS


#Region " Listas Tipo Diccionario "
    Dim diccCentrosLatLng As New Dictionary(Of String, String)
    Dim diccNombreCentros As New Dictionary(Of String, String)
    Dim diccDireccCentros As New Dictionary(Of String, String)

    Dim diccMunicipioSSLatLng As New Dictionary(Of String, String)
    Dim diccMunicipioSSNombre As New Dictionary(Of String, String)
    Dim diccMunicipioSSUrlImagen As New Dictionary(Of String, String)

    Dim diccAccesoInformeCentro As New Dictionary(Of String, String)
    Dim diccAccesoInformeProveedor As New Dictionary(Of String, String)
    Dim diccAccesoInformeGlobal As New Dictionary(Of String, String)
    Dim diccAccesoRecursosProveedor As New Dictionary(Of String, String)

    Dim diccDeptosPresenciaPoligono As New Dictionary(Of String, String)
    Dim diccDeptosSinPresenciaPoligono As New Dictionary(Of String, String)

    Dim diccMunicipiosLatLng As New Dictionary(Of String, String)
    Dim diccMunicipiosNombre As New Dictionary(Of String, String)
    Dim diccMunicipiosCantParticipantes As New Dictionary(Of String, Decimal)

    Dim diccFaseMunicipiosBM As New Dictionary(Of String, String)
    Dim diccFaseMunicipiosNombreBM As New Dictionary(Of String, String)
    Dim diccFaseMunicipiosUSAID As New Dictionary(Of String, String)
    Dim diccFaseMunicipiosNombreUSAID As New Dictionary(Of String, String)

    Dim diccIconos As New Dictionary(Of String, String)
#End Region

    Private Sub CargarDepartamentos()
        Me.cmbDepartamento.DataBind()
        Me.cmbDepartamento.Items.Add(New ASPxEditors.ListEditItem("[Todos]", ""))
    End Sub

    Private Sub CargarProcedencia()
        Me.cmbDeptoProcedencia.DataBind()
        Me.cmbDeptoProcedencia.Items.Add(New ASPxEditors.ListEditItem("[Todos]", ""))
    End Sub

    Private Sub CargarProveedoresHTP(ByVal ID_EJERCICIO As String)
        Me.odsProveedor.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
        Me.cmbProveedor.DataBind()
        Me.cmbProveedor.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Private Sub CargarCentros(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal IdSeleccion As Integer = -1)
        Me.odsCentroFormacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.cmbCentroFormacion.DataBind()
        Me.cmbCentroFormacion.Items.Add(New ASPxEditors.ListEditItem("[Todos]", -1))
        Me.cmbCentroFormacion.SelectedItem = Me.cmbCentroFormacion.Items.FindByValue(IdSeleccion)
    End Sub

    Private Sub CargarAreaFormacion(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal IdSeleccion As Integer = -1)
        Me.odsAreaFormacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString
        Me.odsAreaFormacion.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
        Me.cmbAreaFormacion.DataBind()
        Me.cmbAreaFormacion.Items.Add(New ASPxEditors.ListEditItem("[Todos]", -1))
        Me.cmbAreaFormacion.SelectedItem = Me.cmbAreaFormacion.Items.FindByValue(IdSeleccion)
    End Sub

    Private Sub CargarEntidadPATI()
        Me.cmbEntidadPati.DataBind()
        Me.cmbEntidadPati.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Private Sub CargarFasePATI()
        Me.cmbFasePati.DataBind()
        Me.cmbFasePati.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Private Sub CargarEjercicio()
        Me.cmbEjercicio.DataBind()
        Me.cmbEjercicio.SelectedIndex = Me.cmbEjercicio.Items.Count - 1
    End Sub

    Private Sub SetearTodosHTP()
        Me.cmbProveedor.Text = "[Todos]"
        Me.cmbCentroFormacion.Text = "[Todos]"
        Me.cmbDepartamento.Text = "[Todos]"
        Me.cmbDeptoProcedencia.Text = "[Todos]"
        Me.spnPorcentajeParticipantes.Value = 100
        Me.cmbEjercicio.SelectedItem = Me.cmbEjercicio.Items.FindByText(Today.Year.ToString)
        Me.cmbAreaFormacion.Text = "[Todos]"

        hf("HabilitarCriteriosHTP") = False
        hf("IdProveedorAF") = -1
        hf("IdSitioCapacitacion_Select") = -1
        hf("IdAreaFormacion_Select") = -1
    End Sub

    Private Sub SetearTodosPATI()
        Me.cmbEntidadPati.Text = "[Todos]"
        Me.cmbFasePati.Text = "[Todos]"
    End Sub

    Private Sub RegistrarClaveGoogleMaps()
        Try
            Dim script As New StringBuilder
            script.Append("<script src=""")
            script.Append(AppSettings("clavegooglemaps"))
            script.Append(""" type=""text/javascript"">")
            script.Append("</script>")

            Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "ScriptGoogleMaps", script.ToString, False)

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Sub

    Private Sub InicializarCriteriosHTP(Optional ByVal Habilitar As Boolean = False)
        cmbDeptoProcedencia.ClientEnabled = Habilitar AndAlso chkhtpProcedencia.Checked

        chkhtpSexo.ClientEnabled = Habilitar
        rdbTodos.ClientEnabled = Habilitar AndAlso chkhtpSexo.Checked
        rdbMasculino.ClientEnabled = Habilitar AndAlso chkhtpSexo.Checked
        rdbFemenino.ClientEnabled = Habilitar AndAlso chkhtpSexo.Checked
        spnPorcentajeParticipantes.ClientEnabled = Habilitar AndAlso chkhtpSexo.Checked

        chkhtpAreaFormativa.ClientEnabled = Habilitar
        cmbAreaFormacion.ClientEnabled = Habilitar AndAlso chkhtpAreaFormativa.Checked
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsCallback Then
            '   Registrar clave de GoogleMaps
            'RegistrarClaveGoogleMaps()

            '   Criterios HTP
            Me.InicializarCriteriosHTP()
            Me.CargarEjercicio()
            Me.CargarProveedoresHTP(Me.cmbEjercicio.Value)
            Me.CargarDepartamentos()
            Me.CargarProcedencia()
            'Me.CargarPaises(Me.cmbEjercicio.Value, -1, -1)
            Me.SetearTodosHTP()

            '   Criterios PATI
            Me.CargarEntidadPATI()
            Me.CargarFasePATI()
            Me.SetearTodosPATI()

            '   Criterios ISSS
        Else
            Me.InicializarCriteriosHTP(hf("HabilitarCriteriosHTP"))
            Me.CargarCentros(hf("IdProveedorAF"), hf("IdSitioCapacitacion_Select"))
            Me.CargarAreaFormacion(hf("IdProveedorAF"), Me.cmbEjercicio.Value, hf("IdAreaFormacion_Select"))
        End If
    End Sub

    Protected Sub cmbCentroFormacion_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cmbCentroFormacion.Callback
        If e.Parameter = "Limpiar" Then
            Me.CargarCentros(-1)
        Else
            Me.CargarCentros(e.Parameter)
        End If
    End Sub

    Protected Sub cmbDepartamento_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cmbDepartamento.Callback
        If e.Parameter = "Limpiar" Then
            Me.CargarDepartamentos()
        End If
    End Sub

    Protected Sub cpMapa_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cpMapa.Callback
        Dim Parametros As String()
        Parametros = e.Parameter.Split(";")
        If Not Me.cpMapa.JSProperties.ContainsKey("cpResultCallback") Then Me.cpMapa.JSProperties.Add("cpResultCallback", "") Else Me.cpMapa.JSProperties("cpResultCallback") = ""

        Select Case Parametros(0)
            Case "ProcesarMapa"
                Dim listaMuni As listaMUNICIPIO = (New cMUNICIPIO).ObtenerLista("")
                Dim listaDepto As listaDEPARTAMENTO = (New cDEPARTAMENTO).ObtenerLista()
                Dim i As Int32
                Dim tipoMapa As String = "gfc_gfi"

                i = 0
                For Each lEntidad As DEPARTAMENTO In listaDepto
                    If lEntidad.CODIGO_DEPARTAMENTO <> "15" Then
                        diccDeptosPresenciaPoligono.Add(i, lEntidad.COOR_POLIGONO)
                    End If
                    i += 1
                Next

                i = 0
                For Each lEntidad As MUNICIPIO In listaMuni
                    If lEntidad.USERID = "C" Or lEntidad.USERID = "CI" OrElse lEntidad.USERID = "I" Then
                        If tipoMapa = "gfc" AndAlso (lEntidad.USERID = "C" OrElse lEntidad.USERID = "CI") Then
                            diccMunicipiosNombre.Add(i, lEntidad.NOMBRE)
                            diccMunicipiosLatLng.Add(i, _
                                 "(" + lEntidad.LATITUD.ToString + ", " + lEntidad.LONGITUD.ToString + ")")
                            diccIconos.Add(i, "http://localhost:65146/SGAFP/imagenes/Mapa/gfc.png")

                        ElseIf tipoMapa = "gfi" AndAlso (lEntidad.USERID = "I" OrElse lEntidad.USERID = "CI") Then
                            diccMunicipiosNombre.Add(i, lEntidad.NOMBRE)
                            diccMunicipiosLatLng.Add(i, _
                                 "(" + lEntidad.LATITUD.ToString + ", " + lEntidad.LONGITUD.ToString + ")")
                            diccIconos.Add(i, "http://localhost:65146/SGAFP/imagenes/Mapa/gfi.png")

                        ElseIf tipoMapa = "gfc_gfi" Then
                            If lEntidad.USERID = "C" Then
                                diccMunicipiosNombre.Add(i, lEntidad.NOMBRE)
                                diccMunicipiosLatLng.Add(i, _
                                     "(" + lEntidad.LATITUD.ToString + ", " + lEntidad.LONGITUD.ToString + ")")
                                diccIconos.Add(i, "http://localhost:65146/SGAFP/imagenes/Mapa/gfc.png")

                            ElseIf lEntidad.USERID = "I" Then
                                diccMunicipiosNombre.Add(i, lEntidad.NOMBRE)
                                diccMunicipiosLatLng.Add(i, _
                                     "(" + lEntidad.LATITUD.ToString + ", " + lEntidad.LONGITUD.ToString + ")")
                                diccIconos.Add(i, "http://localhost:65146/SGAFP/imagenes/Mapa/gfi.png")

                            ElseIf lEntidad.USERID = "CI" Then
                                diccMunicipiosNombre.Add(i, lEntidad.NOMBRE)
                                diccMunicipiosLatLng.Add(i, _
                                     "(" + lEntidad.LATITUD.ToString + ", " + lEntidad.LONGITUD.ToString + ")")
                                diccIconos.Add(i, "http://localhost:65146/SGAFP/imagenes/Mapa/gfc_gfi.png")

                            End If
                        End If

                        i += 1
                    End If
                Next

                Me.cpMapa.JSProperties.Add("cpMunicipiosNombre", diccMunicipiosNombre)
                Me.cpMapa.JSProperties.Add("cpMunicipiosLatLng", diccMunicipiosLatLng)
                Me.cpMapa.JSProperties.Add("cpIconos", diccIconos)
                Me.cpMapa.JSProperties.Add("cpDepartamentosPresencia", diccDeptosPresenciaPoligono)
                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"

            Case "CargarProveedores"
                Me.CargarProveedoresHTP(Parametros(1))
                Me.cmbProveedor.SelectedItem = Me.cmbProveedor.Items.FindByText("[Todos]")
                Me.CargarCentros(-1)
                Me.cmbCentroFormacion.SelectedItem = Me.cmbCentroFormacion.Items.FindByText("[Todos]")
                Me.CargarAreaFormacion(-1, Parametros(1))
                hf("IdProveedorAF") = -1
                hf("IdSitioCapacitacion_Select") = -1
                hf("IdAreaFormacion_Select") = -1

            Case "CargarCentros"
                Me.CargarCentros(Parametros(1))
                Me.cmbCentroFormacion.SelectedItem = Me.cmbCentroFormacion.Items.FindByText("[Todos]")
                Me.CargarAreaFormacion(Parametros(1), Me.cmbEjercicio.Value)
                hf("IdProveedorAF") = Parametros(1)
                hf("IdSitioCapacitacion_Select") = -1
                hf("IdAreaFormacion_Select") = -1

            Case "LimpiarCriteriosHTP"
                Me.CargarEjercicio()
                Me.CargarProveedoresHTP(Me.cmbEjercicio.Value)
                Me.CargarDepartamentos()
                Me.CargarCentros(-1)
                Me.CargarAreaFormacion(-1, Me.cmbEjercicio.Value)
                Me.rdbTodos.Checked = True
                Me.SetearTodosHTP()

            Case "ProcesarMapaHTP"
                Dim _Ejercicio As String = Parametros(1)
                Dim _Proveedor As Decimal = Convert.ToDecimal(Parametros(2))
                Dim _CentroFormacion As Decimal = hf("IdSitioCapacitacion_Select")
                Dim _Departamento As String = Parametros(4)

                Dim _DepartamentoProcedencia As String = Parametros(5)
                Dim _Genero = Parametros(6)
                Dim _PorcentajeConcentracion As Decimal = Convert.ToDecimal(Parametros(7))
                Dim _AreaFormacion As Decimal = hf("IdAreaFormacion_Select")

                Dim i As Integer
                cpMapa.JSProperties.Clear()

                If Not chkhtpProcedencia.Checked Then
                    '1. Obtener los Centros de Formación de acuerdo a los criterios seleccionados
                    listaCentrosFormacion = _
                       (New cMAPA.HTP).ObtenerSITIOS_CAPACITACION(_Proveedor, _CentroFormacion, _Departamento, _Ejercicio)

                    For Each eSitio As SITIO_CAPACITACION In listaCentrosFormacion
                        If eSitio.ID_SITIO_CAPACITACION <> 13 Then
                            diccCentrosLatLng.Add(i, _
                                "(" + eSitio.LATITUD + ", " + eSitio.LONGITUD + ")")
                            diccNombreCentros.Add(i, eSitio.NOMBRE_SITIO)
                            diccDireccCentros.Add(i, eSitio.DIRECCION)
                            diccAccesoInformeCentro.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=3&e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "&c=" + eSitio.ID_SITIO_CAPACITACION.ToString + "')"">Ver informe del Centro de Formacion</a>")
                            diccAccesoInformeProveedor.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=2&e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "')"">Ver informe del Proveedor</a>")
                            diccAccesoInformeGlobal.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=1&e=" + Me.cmbEjercicio.Value + "')"">Ver informe Global</a>")
                            diccAccesoRecursosProveedor.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteUtilizacionRecursos.aspx?e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "')"">Ver recursos utilizados del Proveedor</a>")
                            i += 1
                        End If
                    Next

                    'MUNICIPIOS GRAN SS
                    Dim lMunicipios As listaMUNICIPIO
                    lMunicipios = (New cMUNICIPIO).ObtenerListaPorDEPARTAMENTO("06")
                    i = 0
                    For Each eEntidad As MUNICIPIO In lMunicipios
                        diccMunicipioSSLatLng.Add(i, _
                                "(" + eEntidad.LATITUD.ToString + ", " + eEntidad.LONGITUD.ToString + ")")
                        diccMunicipioSSNombre.Add(i, eEntidad.NOMBRE)
                        i += 1
                    Next
                    diccMunicipioSSLatLng.Add(i, _
                               "(13.698976,-89.191453)")
                    diccMunicipioSSNombre.Add(i, "Centro_Gran_San_Salvador")
                    'Seteando variables JSProperties de Municipios
                    cpMapa.JSProperties.Add("cpMunicipioSSNombre", diccMunicipioSSNombre)
                    cpMapa.JSProperties.Add("cpMunicipioSSLatLng", diccMunicipioSSLatLng)

                    '2°     Obtener los departamentos en los que hay presencia de los Centros de Formación del criterio
                    listaDeptosPresencia = _
                        (New cMAPA.HTP).ObtenerDEPARTAMENTOS(listaCentrosFormacion)
                    i = 0

                    Dim listaDeptosSinPresencia As New listaDEPARTAMENTO
                    If listaDeptosPresencia.Count > 0 Then
                        For Each d As DEPARTAMENTO In (New cDEPARTAMENTO).ObtenerLista()
                            If d.CODIGO_DEPARTAMENTO <> "15" Then
                                If Not listaDeptosPresencia.Contains(d) Then
                                    listaDeptosSinPresencia.Add(d)
                                End If
                            End If
                        Next
                    End If
                    i = 0
                    For Each eDepartamento As DEPARTAMENTO In listaDeptosPresencia
                        diccDeptosPresenciaPoligono.Add(i, eDepartamento.COOR_POLIGONO)
                        i += 1
                    Next

                    i = 0
                    For Each eDepartamento As DEPARTAMENTO In listaDeptosSinPresencia
                        diccDeptosSinPresenciaPoligono.Add(i, eDepartamento.COOR_POLIGONO)
                        i += 1
                    Next
                Else
                    'Obtener DataSet con datos de Municipios y Sitios de Capacitacion
                    i = 0

                    'ds = (New cMAPA.HTP).ObtenerDataSetMunicipiosRelacionSitios( _
                    '    Enumeradores.TipoSolicitud.HabilTecnicoPermanente, _Proveedor, _
                    '    _CentroFormacion, _Departamento, _Ejercicio, _AreaFormacion, _Genero, _
                    '    _DepartamentoProcedencia, _PorcentajeConcentracion)

                    If ds IsNot Nothing Then
                        If ds.Tables.Contains("MUNICIPIOS") AndAlso ds.Tables.Contains("SITIOS_CAPACITACION") Then
                            For Each drMunicipio As DataRow In ds.Tables("MUNICIPIOS").Rows
                                'Obtener los Sitios de Formación en los que se capacitaron los participantes de los Departamentos
                                Dim drSitios() As DataRow = ds.Tables("SITIOS_CAPACITACION").Select( _
                                                                                            "CODIGO_DEPTO_RESIDENCIA = '" + drMunicipio("CODIGO_DEPTO_RESIDENCIA").ToString + "' " + _
                                                                                            "AND CODIGO_MUNI_RESIDENCIA = '" + drMunicipio("CODIGO_MUNI_RESIDENCIA").ToString + "'")
                                For Each drSitio As DataRow In drSitios
                                    Dim eMunicipio As MUNICIPIO
                                    Dim eSitio As SITIO_CAPACITACION
                                    eMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIO(drMunicipio("CODIGO_DEPTO_RESIDENCIA").ToString, drMunicipio("CODIGO_MUNI_RESIDENCIA").ToString)
                                    eSitio = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(drSitio("ID_SITIO_CAPACITACION"))

                                    Me.diccMunicipiosNombre.Add(i, eMunicipio.NOMBRE + ", " + (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eMunicipio.CODIGO_DEPARTAMENTO).NOMBRE)
                                    Me.diccMunicipiosLatLng.Add(i, _
                                        "(" + eMunicipio.LATITUD.ToString + ", " + eMunicipio.LONGITUD.ToString + ")(" + eSitio.LATITUD + ", " + eSitio.LONGITUD + ")")
                                    Me.diccMunicipiosCantParticipantes.Add(i, drMunicipio("TOTAL"))


                                    'Diccionarios a convertir en variables JSProperties
                                    diccCentrosLatLng.Add(i, _
                                        "(" + eSitio.LATITUD + ", " + eSitio.LONGITUD + ")")
                                    diccNombreCentros.Add(i, eSitio.NOMBRE_SITIO)
                                    diccDireccCentros.Add(i, eSitio.DIRECCION)
                                    diccAccesoInformeCentro.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=3&e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "&c=" + eSitio.ID_SITIO_CAPACITACION.ToString + "')"">Ver informe del Centro de Formacion</a>")
                                    diccAccesoInformeProveedor.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=2&e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "')"">Ver informe del Proveedor</a>")
                                    diccAccesoInformeGlobal.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteEjecucion.aspx?modo=1&e=" + Me.cmbEjercicio.Value + "')"">Ver informe Global</a>")
                                    diccAccesoRecursosProveedor.Add(i, "<a href=""javascript:MostrarReporte('../Consultas/wfReporteUtilizacionRecursos.aspx?e=" + Me.cmbEjercicio.Value + "&p=" + eSitio.ID_PROVEEDOR_AF.ToString + "')"">Ver recursos utilizados del Proveedor</a>")

                                    i += 1
                                Next
                            Next
                        End If
                    End If

                End If
                'Seteando variables JSProperties de Sitios de Capacitacion
                cpMapa.JSProperties.Add("cpCentrosLatLng", diccCentrosLatLng)
                cpMapa.JSProperties.Add("cpCentros", diccNombreCentros)
                cpMapa.JSProperties.Add("cpCentrosDir", diccDireccCentros)
                cpMapa.JSProperties.Add("cpCentrosInfCentro", diccAccesoInformeCentro)
                cpMapa.JSProperties.Add("cpCentrosInfProveedor", diccAccesoInformeProveedor)
                cpMapa.JSProperties.Add("cpCentrosInfGlobal", diccAccesoInformeGlobal)
                cpMapa.JSProperties.Add("cpCentrosRecProveedor", diccAccesoRecursosProveedor)

                'Seteando variables JSProperties de Municipios
                cpMapa.JSProperties.Add("cpMunicipiosNombre", diccMunicipiosNombre)
                cpMapa.JSProperties.Add("cpMunicipiosLatLng", diccMunicipiosLatLng)
                cpMapa.JSProperties.Add("cpMunicipiosCantParticipantes", diccMunicipiosCantParticipantes)

                cpMapa.JSProperties.Add("cpDepartamentosPresencia", diccDeptosPresenciaPoligono)
                cpMapa.JSProperties.Add("cpDepartamentosSinPresencia", diccDeptosSinPresenciaPoligono)

                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"

            Case "ProcesarMapaPATI"
                Dim _Entidad As Decimal = Convert.ToDecimal(Parametros(1))
                Dim _Fase As Decimal = Convert.ToDecimal(Parametros(2))

                listaFaseMunicipios = (New cMAPA.PATI).ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(_Entidad, _Fase)
                listaDeptosPresencia = (New cMAPA.PATI).ObtenerDEPARTAMENTOS(listaFaseMunicipios)
                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"
        End Select
    End Sub

    Protected Sub cpMapa_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CustomJSPropertiesEventArgs) Handles cpMapa.CustomJSProperties

        Select Case Me.TabMapas.ActiveTabIndex
            Case 0

            Case 1
                InfoMapaPATI(e)
            Case 2
                InfoMapaISSS(e)
        End Select

        '   Iconos
        'SetIconos()
        'e.Properties.Add("cpIconos", Me.diccIconos)
    End Sub

    Private Sub InfoMapaPATI(ByVal e As DevExpress.Web.ASPxClasses.CustomJSPropertiesEventArgs)
        Dim i As Integer = 0
        For Each eFaseMunicipio As FASE_MUNICIPIOS In listaFaseMunicipios
            Dim eMunicipio As MUNICIPIO

            eMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIO(eFaseMunicipio.CODIGO_DEPARTAMENTO, eFaseMunicipio.CODIGO_MUNICIPIO)

            If eFaseMunicipio.ID_FUENTE = 1 Then
                diccFaseMunicipiosBM.Add(i, "(" + eMunicipio.LATITUD.ToString + ", " + eMunicipio.LONGITUD.ToString + ")")
                diccFaseMunicipiosNombreBM.Add(i, eMunicipio.NOMBRE + ", " + (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eMunicipio.CODIGO_DEPARTAMENTO).NOMBRE)
            Else
                diccFaseMunicipiosUSAID.Add(i, "(" + eMunicipio.LATITUD.ToString + ", " + eMunicipio.LONGITUD.ToString + ")")
                Me.diccFaseMunicipiosNombreUSAID.Add(i, eMunicipio.NOMBRE + ", " + (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eMunicipio.CODIGO_DEPARTAMENTO).NOMBRE)
            End If
            i += 1
        Next

        '   Diccionario de Departamentos
        Dim listaDeptosSinPresencia As New listaDEPARTAMENTO
        If listaDeptosPresencia.Count > 0 Then
            For Each d As DEPARTAMENTO In (New cDEPARTAMENTO).ObtenerLista("01")
                If d.CODIGO_DEPARTAMENTO <> "15" Then
                    If Not listaDeptosPresencia.Contains(d) Then
                        listaDeptosSinPresencia.Add(d)
                    End If
                End If
            Next
        End If
        i = 0
        For Each eDepartamento As DEPARTAMENTO In listaDeptosPresencia
            diccDeptosPresenciaPoligono.Add(i, eDepartamento.COOR_POLIGONO)
            i += 1
        Next
        e.Properties.Add("cpDepartamentosPresencia", diccDeptosPresenciaPoligono)
        i = 0
        For Each eDepartamento As DEPARTAMENTO In listaDeptosSinPresencia
            diccDeptosSinPresenciaPoligono.Add(i, eDepartamento.COOR_POLIGONO)
            i += 1
        Next
        e.Properties.Add("cpDepartamentosSinPresencia", diccDeptosSinPresenciaPoligono)

        e.Properties.Add("cpBMLatLng", diccFaseMunicipiosBM)
        e.Properties.Add("cpMunicipioNombreBM", diccFaseMunicipiosNombreBM)
        e.Properties.Add("cpUSAIDLatLng", diccFaseMunicipiosUSAID)
        e.Properties.Add("cpMunicipioNombreUSAID", diccFaseMunicipiosNombreUSAID)
        e.Properties.Add("cpMunicipiosNombre", diccMunicipiosNombre)
    End Sub

    Private Sub InfoMapaISSS(ByVal e As DevExpress.Web.ASPxClasses.CustomJSPropertiesEventArgs)

    End Sub

    Private Sub SetIconos()
        Dim i As Integer = 0

        diccIconos = New Dictionary(Of String, String)
        diccIconos.Add(i, AppSettings("iconocentro")) : i += 1
        diccIconos.Add(i, AppSettings("iconom1")) : i += 1
        diccIconos.Add(i, AppSettings("iconom2")) : i += 1
        diccIconos.Add(i, AppSettings("iconom3")) : i += 1
        diccIconos.Add(i, AppSettings("iconobm")) : i += 1
        diccIconos.Add(i, AppSettings("iconousaid")) : i += 1
        diccIconos.Add(i, AppSettings("iconomuniSS1")) : i += 1
        diccIconos.Add(i, AppSettings("iconomuniSS2")) : i += 1
        diccIconos.Add(i, AppSettings("iconomuniSS3")) : i += 1
        diccIconos.Add(i, AppSettings("iconomuniSS4")) : i += 1
        diccIconos.Add(i, AppSettings("iconomuniSS5")) : i += 1
    End Sub
End Class
