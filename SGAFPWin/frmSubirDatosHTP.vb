Imports Microsoft.Office.Interop

Public Class frmSubirDatosHTP

    Private listaSitioCapacitacion As listaSITIO_CAPACITACION

    Private Sub frmSubirDatosHTP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        'Me.AgregarOpcion("CargarArchivoContratos", "Cargar Contratos", My.Resources.DB, True)
        'Me.AgregarOpcion("CargarArchivoSubAreas", "Cargar Sub Areas", My.Resources.DB, True)
        'Me.AgregarOpcion("CargarArchivoCursos", "Cargar Cursos", My.Resources.DB, True)
        Me.AgregarOpcion("ProcesarContratos", "Procesar Contratos", My.Resources.DB, True)
        Me.AgregarOpcion("ProcesarSubAreas", "Procesar Sub Areas", My.Resources.DB, True)
        Me.AgregarOpcion("ProcesarCursos", "Procesar Cursos", My.Resources.DB, True)

        listaSitioCapacitacion = (New cSITIO_CAPACITACION).ObtenerLista
    End Sub


    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "CargarArchivoContratos"
                CargarArchivoContratos()
            Case "CargarArchivoSubAreas"
                CargarArchivoSubAreas()
            Case "CargarArchivoCursos"
                CargarArchivoCursos()
            Case "ProcesarContratos"
                ProcesarContratos()
            Case "ProcesarSubAreas"
                ProcesarSubAreas()
            Case "ProcesarCursos"
                ProcesarCursos()
        End Select
    End Sub

    Private Sub CargarArchivoContratos()
        Dim asRutaArchivo As String
        Me.OpenFileDialog1.Filter = "Excel|*.xlsx"
        If Not Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        asRutaArchivo = Me.OpenFileDialog1.FileName

        Try
            Dim cadenaCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + asRutaArchivo + ";Extended Properties=HTML Import;"
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(cadenaCon)
            con.Open()
            Dim adaptador1 = New OleDb.OleDbDataAdapter("SELECT * FROM [Contrato$]", con)
            Dim datos1 As New DataSet
            adaptador1.Fill(datos1, "importedData")

            'Dim cadenaCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + asRutaArchivo + ";Extended Properties=Excel 8.0;"
            'Dim con As Odbc.OdbcConnection = New Odbc.OdbcConnection("dsn=")
            'con.Open()
            'Dim adaptador1 As New Odbc.OdbcDataAdapter("SELECT * FROM [Contrato$]", con)
            'Dim datos1 As New DataSet
            'adaptador1.Fill(datos1, "importedData")

            If datos1 Is Nothing Then
                con.Close()
                Return
            End If
            If datos1.Tables(0).Rows.Count = 0 Then
                con.Close()
                Return
            End If

            Me.GridControl1.DataSource = datos1
        Catch ex As Exception
            Me.AsignarMensaje(ex.Message)
        End Try



        'Me.GridControl1.DataMember = "importedData"


    End Sub


    Private Sub ProcesarArchivo(ByVal aFile As String, ByVal hoja As Integer)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        Dim listaContrato As listaCONTRATO_PROVEEDOR_AF
        listaContrato = (New cCONTRATO_PROVEEDOR_AF).ObtenerListaPorEJERCICIO("2012")

        EL.configuracion.usuarioActualiza = "INSAFORP01"

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(aFile)

        xlsSheet = xlsWB.Worksheets(hoja)

        Dim i As Integer = 2

        Do
            Select Case hoja
                Case 1 'Contratos
                    Dim ID_PROVEEDOR, PARTICIPACION As Integer
                    Dim NOMBRE_PROVEEDOR, CONTRATO As String
                    Dim MONTO As Decimal
                    ID_PROVEEDOR = xlsSheet.Cells(i, 1).Value
                    NOMBRE_PROVEEDOR = xlsSheet.Cells(i, 2).Value
                    CONTRATO = xlsSheet.Cells(i, 3).Value
                    PARTICIPACION = xlsSheet.Cells(i, 4).Value
                    MONTO = xlsSheet.Cells(i, 5).Value
                    Dim lContrato As New CONTRATO_PROVEEDOR_AF
                    lContrato.ID_EJERCICIO = "2012"
                    lContrato.ID_PROVEEDOR_AF = ID_PROVEEDOR
                    lContrato.LASTUPDATE = Now
                    lContrato.MONTO_ADJUDICADO = MONTO
                    lContrato.MONTO_DEVENGADO = 0
                    lContrato.NUM_CONTRATO = CONTRATO
                    lContrato.NUM_LICITACION = "6/2012"
                    lContrato.USERID = "INSAFORP01"
                    If (New cCONTRATO_PROVEEDOR_AF).ActualizarCONTRATO_PROVEEDOR_AF(lContrato) < 1 Then

                    End If
                Case 2 'SubAreas
                    Dim ID_PROVEEDOR, PARTICIPACION As Integer
                    Dim AREA, SUBAREA As String
                    Dim MONTO As Decimal
                    ID_PROVEEDOR = xlsSheet.Cells(i, 1).Value
                    AREA = xlsSheet.Cells(i, 2).Value
                    SUBAREA = xlsSheet.Cells(i, 3).Value
                    PARTICIPACION = xlsSheet.Cells(i, 4).Value
                    MONTO = xlsSheet.Cells(i, 5).Value

                    Dim lContratoSubArea As New CONTRATO_SUB_AREA_FORMACION
                    lContratoSubArea.ID_CONTRATO = listaContrato.Find(Function(e) e.ID_PROVEEDOR_AF = ID_PROVEEDOR And e.MONTO_DEVENGADO = 0).ID_CONTRATO
                    lContratoSubArea.LASTUPDATE = Now
                    lContratoSubArea.MONTO_ADJUDICADO = MONTO
                    lContratoSubArea.MONTO_DEVENGADO = 0
                    lContratoSubArea.PARTICIP_ADJUDICADA = PARTICIPACION
                    lContratoSubArea.USERID = Me.usuarioActualizacion

                    Dim lArea_SubArea As Area_SubArea = Me.CrearSubArea(AREA, SUBAREA)

                    lContratoSubArea.ID_SUBAREA_FORMACION = lArea_SubArea.ID_SUBAREA_FORMACION

                    If (New cCONTRATO_SUB_AREA_FORMACION).AgregarCONTRATO_SUB_AREA_FORMACION(lContratoSubArea) < 1 Then

                    End If

                Case 3 'Cursos
                    Dim ID_PROVEEDOR, PARTICIPACION, DURACION As Integer
                    Dim SITIO, SUBAREA, CURSO As String
                    Dim MONTO, COSTO_POR_PART As Decimal
                    ID_PROVEEDOR = xlsSheet.Cells(i, 1).Value
                    SITIO = xlsSheet.Cells(i, 2).Value
                    SUBAREA = xlsSheet.Cells(i, 3).Value
                    CURSO = xlsSheet.Cells(i, 4).Value
                    DURACION = xlsSheet.Cells(i, 5).Value
                    COSTO_POR_PART = xlsSheet.Cells(i, 6).Value
                    PARTICIPACION = xlsSheet.Cells(i, 7).Value
                    MONTO = xlsSheet.Cells(i, 8).Value

                    Dim lArea_SubArea As Area_SubArea = Me.ObtenerSubArea(SUBAREA)

                    Dim lOferta As New OFERTA_FORMATIVA
                    Dim lOfertaSitio As New OFERTA_FORMATIVA_SITIO
                    
                    lOferta.COSTO_X_PARTICIPANTE = COSTO_POR_PART
                    lOferta.DURACION_HORAS = DURACION
                    lOferta.ESTADO = "A"
                    lOferta.FECHA_APROBACION = Now
                    lOferta.FECHA_FIN = "31/12/2012"
                    lOferta.FECHA_INICIO = "01/09/2012"
                    lOferta.ID_CONTRATO = listaContrato.Find(Function(e) e.ID_PROVEEDOR_AF = ID_PROVEEDOR And e.MONTO_DEVENGADO = 0).ID_CONTRATO
                    lOferta.ID_EJERCICIO = "2012"
                    lOferta.ID_PROVEEDOR_AF = ID_PROVEEDOR
                    lOferta.ID_TEMA_CURSO = Me.CrearCursoTema(lArea_SubArea.ID_AREA_FORMACION, lArea_SubArea.ID_SUBAREA_FORMACION, CURSO, DURACION)
                    lOferta.LASTUPDATE = Now
                    lOferta.USERID = Me.usuarioActualizacion
                    lOferta.USUARIO_APROBACION = Me.usuarioActualizacion



                    Dim listaOferta As listaOFERTA_FORMATIVA

                    Dim criterios As New List(Of Criteria)
                    criterios.Add(New Criteria("ID_EJERCICIO", "=", "2012", "AND"))
                    criterios.Add(New Criteria("ID_CONTRATO", "=", lOferta.ID_CONTRATO, "AND"))
                    criterios.Add(New Criteria("ID_PROVEEDOR_AF", "=", lOferta.ID_PROVEEDOR_AF, "AND"))
                    criterios.Add(New Criteria("ID_TEMA_CURSO", "=", lOferta.ID_TEMA_CURSO, "AND"))

                    listaOferta = (New cOFERTA_FORMATIVA).ObtenerListaPorBusqueda(New OFERTA_FORMATIVA, criterios.ToArray())
                    If listaOferta.Count = 0 Then
                        If (New cOFERTA_FORMATIVA).ActualizarOFERTA_FORMATIVA(lOferta) < 0 Then
                            Me.AsignarMensaje("No se agrego Oferta")
                        End If
                    Else
                        lOferta = listaOferta(0)
                    End If

                    lOfertaSitio.COSTO_X_PARTICIPANTE = COSTO_POR_PART
                    lOfertaSitio.DURACION_HORAS = DURACION
                    lOfertaSitio.ID_EJERCICIO = "2012"
                    lOfertaSitio.ID_OFERTA_FORMATIVA = lOferta.ID_OFERTA_FORMATIVA
                    lOfertaSitio.ID_PROVEEDOR_AF = ID_PROVEEDOR
                    lOfertaSitio.ID_SITIO_CAPACITACION = listaSitioCapacitacion.Find(Function(e) e.ID_PROVEEDOR_AF = ID_PROVEEDOR And e.NOMBRE_SITIO = SITIO).ID_SITIO_CAPACITACION
                    lOfertaSitio.LASTUPDATE = Now
                    lOfertaSitio.USER_ID = Me.usuarioActualizacion

                    If (New cOFERTA_FORMATIVA_SITIO).AgregarOFERTA_FORMATIVA_SITIO(lOfertaSitio) < 0 Then
                        Me.AsignarMensaje("No se agrego Oferta Sitio")
                    End If


                    Dim listaSitioCapacitacionEjercicio As listaSITIO_CAPACITACION_EJERCICIO

                    criterios = New List(Of Criteria)
                    criterios.Add(New Criteria("ID_EJERCICIO", "=", "2012", "AND"))
                    criterios.Add(New Criteria("ID_SITIO_CAPACITACION", "=", lOfertaSitio.ID_SITIO_CAPACITACION, "AND"))

                    listaSitioCapacitacionEjercicio = (New cSITIO_CAPACITACION_EJERCICIO).ObtenerListaPorBusqueda(New SITIO_CAPACITACION_EJERCICIO, criterios.ToArray)

                    If listaSitioCapacitacionEjercicio Is Nothing OrElse listaSitioCapacitacionEjercicio.Count = 0 Then
                        Dim lSitioCapacitacionEjercicio As New SITIO_CAPACITACION_EJERCICIO
                        lSitioCapacitacionEjercicio.ID_EJERCICIO = "2012"
                        lSitioCapacitacionEjercicio.ID_SITIO_CAPACITACION = lOfertaSitio.ID_SITIO_CAPACITACION
                        If (New cSITIO_CAPACITACION_EJERCICIO).AgregarSITIO_CAPACITACION_EJERCICIO(lSitioCapacitacionEjercicio) < 1 Then
                            Me.AsignarMensaje("No se agrego Sitio Ejericion")
                        End If
                    End If

            End Select
            'Try
            '    strSQL = "select CORR_PERS_COBR from REDU_PAGO_PLAN where CODI_PLAN = " + CODI_PLAN + " and NUME_FAMI = " + NUME_FAMI

            '    Dim CORR_PERS_COBR As String
            '    CORR_PERS_COBR = AseHelper.ExecuteScalar(cnnStr, CommandType.Text, strSQL)

            '    xlsSheet.Cells(i, 2).Value = CORR_PERS_COBR
            '    xlsSheet.Cells(i, 3).Value = 1
            '    xlsSheet.Cells(i, 4).Value = 1

            'Catch ex1 As Exception
            'End Try
            i += 1

        Loop While Not xlsSheet.Cells(i, 1).Value Is Nothing

        'xlsWB.SaveAs(aFile.Substring(0, aFile.LastIndexOf(".") - 1) + ".xls", Excel.XlFileFormat.xlWorkbookNormal)
        xlsWB.Close(False)
        xlsApp.Quit()
        xlsApp = Nothing
        xlsWB = Nothing
        xlsSheet = Nothing

    End Sub


    Private Sub CargarArchivoSubAreas()

    End Sub

    Private Sub CargarArchivoCursos()

    End Sub

    Private Sub ProcesarContratos()

        Dim asRutaArchivo As String
        Me.OpenFileDialog1.Filter = "Excel|*.xlsx"
        If Not Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        asRutaArchivo = Me.OpenFileDialog1.FileName

        Me.ProcesarArchivo(asRutaArchivo, 1)

    End Sub

    Private Sub ProcesarSubAreas()
        Dim asRutaArchivo As String
        Me.OpenFileDialog1.Filter = "Excel|*.xlsx"
        If Not Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        asRutaArchivo = Me.OpenFileDialog1.FileName

        Me.ProcesarArchivo(asRutaArchivo, 2)
    End Sub

    Private Sub ProcesarCursos()
        Dim asRutaArchivo As String
        Me.OpenFileDialog1.Filter = "Excel|*.xlsx"
        If Not Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return
        End If

        asRutaArchivo = Me.OpenFileDialog1.FileName

        Me.ProcesarArchivo(asRutaArchivo, 3)
    End Sub

    Private Function CrearSubArea(ByVal nombreArea As String, ByVal nombreSubArea As String) As Area_SubArea
        nombreArea = Me.FixString(nombreArea)

        Dim lAreaFormacion As AREA_FORMACION
        Dim listaAreas As listaAREA_FORMACION
        listaAreas = (New cAREA_FORMACION).ObtenerLista()

        lAreaFormacion = listaAreas.Find(Function(e) FixString(e.AREA_FORMACION) = nombreArea)

        If lAreaFormacion Is Nothing Then 'No existe Area de Formación - Crearla

            lAreaFormacion = New AREA_FORMACION
            lAreaFormacion.AREA_FORMACION = nombreArea
            lAreaFormacion.LASTUPDATE = Now
            lAreaFormacion.USERID = EL.configuracion.usuarioActualiza

            If (New cAREA_FORMACION).ActualizarAREA_FORMACION(lAreaFormacion) < 0 Then

            End If

        End If

        Dim lSubAreaFormacion As SUB_AREA_FORMACION
        Dim listaSubAreas As listaSUB_AREA_FORMACION
        listaSubAreas = (New cSUB_AREA_FORMACION).ObtenerListaPorAREA_FORMACION(lAreaFormacion.ID_AREA_FORMACION)

        nombreSubArea = Me.FixString(nombreSubArea)

        'li = listaSubAreas.FindByColum("NOMBRE_SUBAREA", nombreSubArea)

        lSubAreaFormacion = listaSubAreas.Find(Function(e) FixString(e.NOMBRE_SUBAREA) = nombreSubArea)

        If lSubAreaFormacion Is Nothing Then 'No existe SubArea de Formación - Crearla
            lSubAreaFormacion = New SUB_AREA_FORMACION
            lSubAreaFormacion.ID_AREA_FORMACION = lAreaFormacion.ID_AREA_FORMACION
            lSubAreaFormacion.NOMBRE_SUBAREA = nombreSubArea
            lSubAreaFormacion.LASTUPDATE = Now
            lSubAreaFormacion.USERID = EL.configuracion.usuarioActualiza

            If (New cSUB_AREA_FORMACION).ActualizarSUB_AREA_FORMACION(lSubAreaFormacion) < 0 Then

            End If

        End If

        Dim lArea_SubArea As New Area_SubArea
        lArea_SubArea.ID_AREA_FORMACION = lSubAreaFormacion.ID_AREA_FORMACION
        lArea_SubArea.ID_SUBAREA_FORMACION = lSubAreaFormacion.ID_SUBAREA_FORMACION

        Return lArea_SubArea

    End Function

    Private Function ObtenerSubArea(ByVal nombreSubArea As String) As Area_SubArea


        Dim lSubAreaFormacion As SUB_AREA_FORMACION
        Dim listaSubAreas As listaSUB_AREA_FORMACION
        listaSubAreas = (New cSUB_AREA_FORMACION).ObtenerLista(False, False, "ID_SUBAREA_FORMACION")

        nombreSubArea = Me.FixString(nombreSubArea)

        Dim lista As List(Of SUB_AREA_FORMACION) = listaSubAreas.FindAll(Function(e) FixString(e.NOMBRE_SUBAREA) = nombreSubArea)
        'li = listaSubAreas.FindByColum("NOMBRE_SUBAREA", nombreSubArea)
        If lista.Count > 1 Then
            lSubAreaFormacion = lista.Last()
        Else
            lSubAreaFormacion = lista.Last()
        End If


        'lSubAreaFormacion = listaSubAreas(listaSubAreas.Count - 1)

        Dim lArea_SubArea As New Area_SubArea
        lArea_SubArea.ID_AREA_FORMACION = lSubAreaFormacion.ID_AREA_FORMACION
        lArea_SubArea.ID_SUBAREA_FORMACION = lSubAreaFormacion.ID_SUBAREA_FORMACION

        Return lArea_SubArea

    End Function

    Private Function CrearCursoTema(ByVal idArea As Decimal, ByVal idSubArea As Decimal, ByVal nombreCurso As String, ByVal duracionHoras As Decimal) As Decimal
        Dim listaCursoTema As listaCURSO_TEMA
        Dim criterios(2) As Criteria

        nombreCurso = Me.FixString(nombreCurso)

        criterios(0) = New Criteria("TEMA_CURSO", "=", nombreCurso, "AND")
        criterios(1) = New Criteria("ID_AREA_FORMACION", "=", idArea, "AND")
        criterios(2) = New Criteria("ID_SUBAREA_FORMACION", "=", idSubArea, "AND")

        listaCursoTema = (New cCURSO_TEMA).ObtenerListaPorBusqueda(New CURSO_TEMA, criterios)

        If listaCursoTema Is Nothing OrElse listaCursoTema.Count = 0 Then
            Dim lCursoTema As New CURSO_TEMA
            lCursoTema.DURACION_HORAS = duracionHoras
            'lCursoTema.FECHA_ACREDITACION = fechaAcreditacion
            lCursoTema.LASTUPDATE = Now
            lCursoTema.NOTAS = ""
            lCursoTema.TEMA_CURSO = nombreCurso
            lCursoTema.USERID = EL.configuracion.usuarioActualiza
            lCursoTema.CODIGO_PROGRAMA = ""
            lCursoTema.ID_SUBAREA_FORMACION = idSubArea
            lCursoTema.REF_ID_TEMA_CURSO = -1

            lCursoTema.ID_AREA_FORMACION = idArea

            If (New cCURSO_TEMA).ActualizarCURSO_TEMA(lCursoTema) < 0 Then

            End If
            Return lCursoTema.ID_TEMA_CURSO
        Else
            Return listaCursoTema(0).ID_TEMA_CURSO
        End If
        Return -1
    End Function

    Private Function ObtenerSitioCapacitacion(ByVal nombreSitio As String) As Decimal

    End Function

    Private Function FixString(ByVal str As String) As String
        str = str.Replace("á", "a")
        str = str.Replace("ó", "o")
        str = str.Replace("í", "i")
        str = str.Replace("ú", "u")
        str = str.Replace("é", "e")
        str = str.Replace("Á", "a")
        str = str.Replace("Ó", "o")
        str = str.Replace("Í", "i")
        str = str.Replace("Ú", "u")
        str = str.Replace("É", "e")
        str = str.Replace("ñ", "Ñ")
        Return str.ToUpper
    End Function

End Class

Public Structure Area_Curso
    Public ID_TEMA_CURSO As Decimal
    Public ID_SUBAREA_FORMACION As Decimal
End Structure

Public Structure Area_SubArea
    Public ID_AREA_FORMACION As Decimal
    Public ID_SUBAREA_FORMACION As Decimal
End Structure

