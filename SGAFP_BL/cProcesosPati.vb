Public Class cProcesosPati
    Inherits controladorBase

    Public Function ProcesarAsignacionGanador(ByVal codigoArea As String, ByVal codigoPrograma As String, ByVal nombrePrograma As String, ByVal duracionHoras As Decimal, ByVal nombreProveedor As String, ByVal nitProveedor As String, ByVal codigoDepartamento As String, ByVal codigoMunicipio As String, ByVal tipoPersona As Integer, ByVal noDui As String, ByVal noNrc As String, ByVal direccion As String, ByVal email As String, ByVal telefono As String, ByVal fax As String, ByVal numeroParticipantes As Integer, ByVal tdr As String, ByVal montoAdjudicado As Decimal, ByVal userid As String, ByVal correlativoGrupo As Decimal, ByRef ID_ACCION_FORMATIVA As Decimal) As String
        codigoArea = codigoArea.ToUpper.Trim
        nombrePrograma = nombrePrograma.ToUpper.Trim
        sError = ""
        If tdr.Length < 20 Then tdr = tdr + Space(20 - tdr.Length)
        configuracion.usuarioActualiza = userid
        Dim iIdentity As New Security.Principal.GenericIdentity(userid)
        Dim iPrincipal As New Security.Principal.GenericPrincipal(iIdentity, Nothing)
        System.Threading.Thread.CurrentPrincipal = iPrincipal
        Dim ID_TEMA_CURSO As Decimal = CrearCursoTema(codigoArea, codigoPrograma, nombrePrograma.ToUpper().TrimEnd(), duracionHoras, userid)
        Dim ID_PROVEEDOR_AF As Decimal = CrearProveedor(nombreProveedor.ToUpper(), nitProveedor, codigoDepartamento, codigoMunicipio, tipoPersona, noDui, noNrc, direccion.ToUpper(), email, telefono, fax, userid)
        Dim list As New List(Of Criteria)
        list.Add(New Criteria("CORRELATIVO_GRUPO", "=", correlativoGrupo.ToString(), "AND"))
        list.Add(New Criteria("TDR", "=", tdr, ""))

        Dim listaTERMINO_REFERENCIA_AF As listaTERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorBusqueda(New TERMINO_REFERENCIA_AF, list.ToArray())

        If listaTERMINO_REFERENCIA_AF Is Nothing Then Return "Error al recuperar Terminos de Referencia"

        If listaTERMINO_REFERENCIA_AF IsNot Nothing AndAlso listaTERMINO_REFERENCIA_AF.Count() > 0 Then
            Dim i2 As Integer = ActualizarAF(listaTERMINO_REFERENCIA_AF(0), ID_TEMA_CURSO, ID_PROVEEDOR_AF, nombrePrograma.ToUpper().TrimEnd(New Char(0) {}), duracionHoras, numeroParticipantes, tdr, montoAdjudicado, userid, correlativoGrupo)
            ID_ACCION_FORMATIVA = listaTERMINO_REFERENCIA_AF(0).ID_ACCION_FORMATIVA
            If i2 >= 1 Then Return ""
        Else
            Dim i1 As Integer = CrearAF(ID_TEMA_CURSO, ID_PROVEEDOR_AF, nombrePrograma.ToUpper().TrimEnd(), duracionHoras, numeroParticipantes, tdr, montoAdjudicado, userid, correlativoGrupo, ID_ACCION_FORMATIVA)
            If i1 >= 1 Then Return ""
        End If

        Return sError
    End Function

    Private Function CrearCursoTema(ByVal codigoArea As String, ByVal codigoPrograma As String, ByVal nombreCurso As String, ByVal duracionHoras As Decimal, ByVal userid As String) As Decimal
        Dim listaCursoTema As listaCURSO_TEMA

        listaCursoTema = (New cCURSO_TEMA).ObtenerListaPorCODIGO_PROGRAMA(codigoPrograma.Trim)

        If listaCursoTema Is Nothing OrElse listaCursoTema.Count = 0 Then

            listaCursoTema = (New cCURSO_TEMA).ObtenerListaPorTEMA_CURSO(nombreCurso.Trim)

            If listaCursoTema Is Nothing OrElse listaCursoTema.Count = 0 Then
                Dim lCursoTema As New CURSO_TEMA
                lCursoTema.DURACION_HORAS = duracionHoras
                'lCursoTema.FECHA_ACREDITACION = fechaAcreditacion
                lCursoTema.LASTUPDATE = Now
                lCursoTema.NOTAS = ""
                lCursoTema.TEMA_CURSO = nombreCurso
                lCursoTema.USERID = userid
                lCursoTema.CODIGO_PROGRAMA = codigoPrograma
                lCursoTema.ID_SUBAREA_FORMACION = -1
                lCursoTema.REF_ID_TEMA_CURSO = -1

                Dim lAreaFormacion As New AREA_FORMACION
                Dim bAreaFormacion As New cAREA_FORMACION
                Dim listaAreas As listaAREA_FORMACION
                listaAreas = (New cAREA_FORMACION).ObtenerListaPorCODIGO_AREA(codigoArea)

                If listaAreas IsNot Nothing AndAlso listaAreas.Count > 0 Then
                    lAreaFormacion = listaAreas(0)
                Else
                    'Crear area formativa
                    Dim lAreaSIFP As SIFP.EL.Areas_formacion = (New SIFP.BL.cAreas_formacion).ObtenerAreas_formacion(codigoArea)
                    lAreaFormacion.ID_AREA_FORMACION = 0
                    If lAreaSIFP IsNot Nothing Then
                        lAreaFormacion.AREA_FORMACION = lAreaSIFP.nombre_area.ToUpper.Trim
                    End If
                    lAreaFormacion.NOTAS = ""
                    lAreaFormacion.CODIGO_AREA = codigoArea.Trim
                    lAreaFormacion.USERID = userid
                    lAreaFormacion.LASTUPDATE = Now

                    bAreaFormacion.ActualizarAREA_FORMACION(lAreaFormacion)
                End If
                lCursoTema.ID_AREA_FORMACION = lAreaFormacion.ID_AREA_FORMACION

                If (New cCURSO_TEMA).ActualizarCURSO_TEMA(lCursoTema) < 0 Then

                End If

                Return lCursoTema.ID_TEMA_CURSO
            Else
                'Me.ActualizarAREA_FORMACION(listaCursoTema(0), codigoArea, userid)
                Return listaCursoTema(0).ID_TEMA_CURSO
            End If
        Else
            'Me.ActualizarAREA_FORMACION(listaCursoTema(0), codigoArea, userid)
            Return listaCursoTema(0).ID_TEMA_CURSO
        End If

    End Function

    Private Sub ActualizarAREA_FORMACION(ByRef tema As CURSO_TEMA, ByVal codigoArea As String, ByVal userid As String)
        Dim lArea As AREA_FORMACION = (New cAREA_FORMACION).ObtenerAREA_FORMACION(tema.ID_AREA_FORMACION)
        Dim bArea As New cAREA_FORMACION
        Dim bcursoTema As New cCURSO_TEMA

        If lArea IsNot Nothing AndAlso lArea.CODIGO_AREA <> codigoArea Then
            Dim lAreaSIFP As SIFP.EL.Areas_formacion = (New SIFP.BL.cAreas_formacion).ObtenerAreas_formacion(codigoArea)
            If lAreaSIFP IsNot Nothing Then
                If lArea.AREA_FORMACION = lAreaSIFP.nombre_area.ToUpper Then
                    lArea.CODIGO_AREA = codigoArea
                    bArea.ActualizarAREA_FORMACION(lArea)
                Else
                    'Crear una nueva area

                    Dim lAreasxCodi As listaAREA_FORMACION = (New cAREA_FORMACION).ObtenerListaPorCODIGO_AREA(codigoArea)
                    Dim lNuevaArea As New AREA_FORMACION

                    If lAreasxCodi IsNot Nothing AndAlso lAreasxCodi.Count > 0 Then
                        tema.ID_AREA_FORMACION = lAreasxCodi(0).ID_AREA_FORMACION
                    Else
                        lNuevaArea.ID_AREA_FORMACION = 0
                        lNuevaArea.AREA_FORMACION = lAreaSIFP.nombre_area.ToUpper.Trim
                        lNuevaArea.NOTAS = ""
                        lNuevaArea.CODIGO_AREA = codigoArea.Trim
                        lNuevaArea.USERID = userid
                        lNuevaArea.LASTUPDATE = Now
                        bArea.ActualizarAREA_FORMACION(lNuevaArea)

                        tema.ID_AREA_FORMACION = lNuevaArea.ID_AREA_FORMACION
                    End If

                    bcursoTema.ActualizarCURSO_TEMA(tema)
                End If
            End If
        End If
    End Sub

    Private Function CrearProveedor(ByVal nombreProveedor As String, ByVal nitProveedor As String, ByVal codigoDepartamento As String, ByVal codigoMunicipio As String, ByVal tipoPersona As Integer, ByVal noDui As String, ByVal noNrc As String, ByVal direccion As String, ByVal email As String, ByVal telefono As String, ByVal fax As String, ByVal userid As String) As Decimal
        Dim listaProveedores As listaPROVEEDOR_AF
        Dim criterios(0) As Criteria
        criterios(0) = New Criteria("NIT", "=", nitProveedor, "")
        listaProveedores = (New cPROVEEDOR_AF).ObtenerListaPorBusqueda(New PROVEEDOR_AF, criterios)
        If listaProveedores Is Nothing OrElse listaProveedores.Count = 0 Then
            Dim lProveedor As New PROVEEDOR_AF
            'lProveedor.CARGO_CONTACTO
            lProveedor.CODIGO_DEPARTAMENTO = codigoDepartamento
            lProveedor.CODIGO_MUNICIPIO = codigoMunicipio
            'lProveedor.CONTACTO
            lProveedor.DIRECCION = direccion
            'lProveedor.DUI = noDui
            lProveedor.EMAIL = email
            'lProveedor.EMAIL_CONTACTO
            'lProveedor.ESTADO
            lProveedor.FAX = fax
            lProveedor.FECHA_ACREDITACION = Today
            lProveedor.FECHA_INGRESO = Today
            lProveedor.ID_TIPO_PERSONA = tipoPersona
            'lProveedor.ISSS
            lProveedor.LASTUPDATE = Now
            lProveedor.NIT = nitProveedor
            lProveedor.NOMBRE_PROVEEDOR = nombreProveedor
            lProveedor.NOTAS = ""
            lProveedor.NRC = noNrc
            lProveedor.RAZON_SOCIAL = nombreProveedor
            lProveedor.TELEFONO = telefono
            'lProveedor.TELEFONO_CONTACTO
            'lProveedor.URL
            lProveedor.USERID = userid

            If (New cPROVEEDOR_AF).ActualizarPROVEEDOR_AF(lProveedor) < 0 Then

            End If
            Return lProveedor.ID_PROVEEDOR_AF
        Else
            Return listaProveedores(0).ID_PROVEEDOR_AF
        End If
        Return 0
    End Function

    Private Function CrearAF(ByVal ID_TEMA_CURSO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal nombreAF As String, ByVal duracionHoras As Decimal, ByVal numeroParticipantes As Integer, ByVal tdr As String, ByVal montoAdjudicado As Decimal, ByVal userid As String, ByVal correlativoGrupo As Decimal, ByRef ID_ACCION_FORMATIVA As Decimal) As Integer
        Dim lAF As New ACCION_FORMATIVA
        lAF.CODIGO_ESTADO_AF = EL.Enumeradores.EstadoAccionFormativa.Ingresada
        lAF.CODIGO_GRUPO = Now.ToString("ddMMyyyyhhmmssfffffff")
        lAF.DURACION_HORAS = duracionHoras
        lAF.FECHA_FIN = Now
        lAF.FECHA_FIN_REAL = lAF.FECHA_FIN
        lAF.FECHA_INICIO = lAF.FECHA_FIN
        lAF.FECHA_INICIO_REAL = lAF.FECHA_FIN
        lAF.HORARIO = "PENDIENTE DE DEFINIR"
        lAF.ID_EJERCICIO = Now.Year.ToString()
        lAF.ID_OFERTA_FORMATIVA = -1
        lAF.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
        lAF.ID_SITIO_CAPACITACION = -1
        lAF.ID_TEMA_CURSO = ID_TEMA_CURSO
        lAF.NOMBRE_ACCION_FORMATIVA = nombreAF
        lAF.NUMERO_PARTICIPANTES = numeroParticipantes
        lAF.COSTO_X_PARTICIPANTE = Utilerias.Truncar(Decimal.Divide(montoAdjudicado, New Decimal(numeroParticipantes)), 4)
        lAF.PARTICIPANTES_INSCRITOS = 0
        lAF.USERID = userid
        lAF.LASTUPDATE = Now
        lAF.ID_ACCION_CONTRATADA = -1

        Dim liRet As Integer
        Dim lcACCION_FORMATIVA As New cACCION_FORMATIVA
        liRet = lcACCION_FORMATIVA.ActualizarACCION_FORMATIVA(lAF)

        Select Case liRet
            Case 1
                ID_ACCION_FORMATIVA = lAF.ID_ACCION_FORMATIVA

                Dim lTermino As New TERMINO_REFERENCIA_AF
                Dim bTermino As New cTERMINO_REFERENCIA_AF
                lTermino.ID_ACCION_FORMATIVA = lAF.ID_ACCION_FORMATIVA
                lTermino.TDR = tdr
                lTermino.MONTO_ADJUDICADO = montoAdjudicado
                lTermino.USERID = userid
                lTermino.LASTUPDATE = Now
                lTermino.CORRELATIVO_GRUPO = correlativoGrupo
                lTermino.ID_SOLICITUD = -1

                bTermino.AgregarTERMINO_REFERENCIA_AF(lTermino)


                'Crear ACCION_FORMATIVA_DETALLE
                Dim lAFD As New ACCION_FORMATIVA_DETALLE
                Dim bAFD As New cACCION_FORMATIVA_DETALLE
                Dim lstGrupo As listaGRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerListaPorCriterios(-1, tdr, correlativoGrupo)

                If lstGrupo IsNot Nothing AndAlso lstGrupo.Count > 0 Then
                    Dim lSolic As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(lstGrupo(0).ID_SOLICITUD)
                    lAFD.ID_ACCION_FORMATIVA = lAF.ID_ACCION_FORMATIVA
                    lAFD.ID_PROGRAMA_FORMACION = lSolic.ID_PROGRAMA_FORMACION
                    lAFD.ID_MODALIDAD_FORMACION = lstGrupo(0).ID_MODALIDAD_FORMACION
                    lAFD.ID_CONTRATO = -1
                    lAFD.ID_FUENTE = -1
                    lAFD.NO_CONVOCATORIA = -1
                    lAFD.CODIGO_DEPARTAMENTO = lstGrupo(0).CODIGO_DEPARTAMENTO
                    lAFD.CODIGO_MUNICIPIO = lstGrupo(0).CODIGO_MUNICIPIO
                    lAFD.LUGAR_EJECUCION = lstGrupo(0).LUGAR_EJECUCION
                    lAFD.TELEFONO = lSolic.TELEF1
                    lAFD.CONTACTO = Strings.Left(lSolic.NOMBRES_CONTACTO + " " + lSolic.APELLIDOS_CONTACTO, 50)
                    lAFD.USERID = userid
                    lAFD.LASTUPDATE = Now
                    lAFD.ID_UNIDAD_ORGANIZATIVA = lSolic.ID_UNIDAD_ORGANIZATIVA
                    bAFD.AgregarACCION_FORMATIVA_DETALLE(lAFD)


                    lAF.NOMBRE_ACCION_FORMATIVA = lstGrupo(0).NOMBRE_ACCION_FORMATIVA
                    lcACCION_FORMATIVA.ActualizarACCION_FORMATIVA(lAF)


                    lTermino = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAF.ID_ACCION_FORMATIVA)
                    If lTermino IsNot Nothing Then
                        lTermino.ID_SOLICITUD = lstGrupo(0).ID_SOLICITUD
                        bTermino.ActualizarTERMINO_REFERENCIA_AF(lTermino)
                    End If
                End If


                Return 1
            Case Else
                Me.sError = lcACCION_FORMATIVA.sError
                Return -1
        End Select

    End Function

    Private Function ActualizarAF(ByVal aTermino As TERMINO_REFERENCIA_AF, ByVal ID_TEMA_CURSO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal nombreAF As String, ByVal duracionHoras As Decimal, ByVal numeroParticipantes As Integer, ByVal tdr As String, ByVal montoAdjudicado As Decimal, ByVal userid As String, ByVal correlativoGrupo As Decimal) As Integer
        Dim accion_FORMATIVA1 As ACCION_FORMATIVA = New ACCION_FORMATIVA
        Dim caccion_FORMATIVA1 As cACCION_FORMATIVA = New cACCION_FORMATIVA
        accion_FORMATIVA1 = caccion_FORMATIVA1.ObtenerACCION_FORMATIVA(aTermino.ID_ACCION_FORMATIVA, False, False)
        If accion_FORMATIVA1.CODIGO_ESTADO_AF = EL.Enumeradores.EstadoAccionFormativa.Ingresada _
            And accion_FORMATIVA1.HORARIO = "PENDIENTE DE DEFINIR" _
            And accion_FORMATIVA1.PARTICIPANTES_INSCRITOS = 0 Then

            accion_FORMATIVA1.CODIGO_GRUPO = Now.ToString("ddMMyyyyhhmmssfffffff")
            accion_FORMATIVA1.FECHA_FIN = Now
            accion_FORMATIVA1.FECHA_FIN_REAL = accion_FORMATIVA1.FECHA_FIN
            accion_FORMATIVA1.FECHA_INICIO = accion_FORMATIVA1.FECHA_FIN
            accion_FORMATIVA1.FECHA_INICIO_REAL = accion_FORMATIVA1.FECHA_FIN
            accion_FORMATIVA1.ID_EJERCICIO = Now.Year.ToString
            accion_FORMATIVA1.ID_OFERTA_FORMATIVA = Decimal.MinusOne
            accion_FORMATIVA1.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            accion_FORMATIVA1.ID_SITIO_CAPACITACION = Decimal.MinusOne
        End If
        accion_FORMATIVA1.DURACION_HORAS = duracionHoras
        accion_FORMATIVA1.ID_TEMA_CURSO = ID_TEMA_CURSO
        accion_FORMATIVA1.NOMBRE_ACCION_FORMATIVA = nombreAF
        accion_FORMATIVA1.NUMERO_PARTICIPANTES = New Decimal(numeroParticipantes)
        accion_FORMATIVA1.COSTO_X_PARTICIPANTE = Utilerias.Truncar(Decimal.Divide(montoAdjudicado, New Decimal(numeroParticipantes)), 4)
        accion_FORMATIVA1.USERID = userid
        accion_FORMATIVA1.LASTUPDATE = DateAndTime.Now
        Dim i2 As Integer = caccion_FORMATIVA1.ActualizarACCION_FORMATIVA(accion_FORMATIVA1)
        Dim i4 As Integer = i2
        If i2 = 1 Then
            aTermino.MONTO_ADJUDICADO = montoAdjudicado
            aTermino.USERID = userid
            aTermino.LASTUPDATE = Now
            If (New cTERMINO_REFERENCIA_AF).ActualizarTERMINO_REFERENCIA_AF(aTermino) < 0 Then
            End If
            'Actualizar Informe Final si aplica
            Dim lbInformeFinal As New cINFORME_FINAL_AF
            Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(accion_FORMATIVA1.ID_ACCION_FORMATIVA)
            If lInformes IsNot Nothing AndAlso lInformes.Count > 0 Then
                lbInformeFinal.ActualizarINFORME_FINAL_AF(lInformes(0), TipoConcurrencia.Optimistica, True, False, False)
            End If
            Return 1
        Else
            sError = caccion_FORMATIVA1.sError
            Return -1
        End If
        Return i2
    End Function

    Public Function ProcesarCreacionOrdenCompra(ByVal tdr As String, ByVal nitProveedor As String, ByVal resolucion As String, ByVal userid As String) As String
        Me.sError = ""
        EL.configuracion.usuarioActualiza = userid

        Dim iIdentity As New Security.Principal.GenericIdentity(userid)
        Dim iPrincipal As New Security.Principal.GenericPrincipal(iIdentity, Nothing)
        System.Threading.Thread.CurrentPrincipal = iPrincipal

        Dim lcTermino As New cTERMINO_REFERENCIA_AF

        Dim lTerminos As listaTERMINO_REFERENCIA_AF
        lTerminos = lcTermino.ObtenerListaPorProveedorTDR(tdr, nitProveedor)

        If lTerminos.Count = 0 Then
            sError = "No se encontro ningun registro asociado al TDR '" + tdr + "'" + vbCrLf
        End If

        If lcTermino.sError <> "" Then
            sError += "Error: " + lcTermino.sError + vbCrLf
        End If

        For Each lTermino As TERMINO_REFERENCIA_AF In lTerminos
            lTermino.RESOLUCION = resolucion
            lTermino.LASTUPDATE = Now
            lTermino.USERID = userid
            If (New cTERMINO_REFERENCIA_AF).ActualizarTERMINO_REFERENCIA_AF(lTermino) < 0 Then

            End If
        Next

        Return sError
    End Function

#Region "   Métodos para asignar N° Quedan y N° de Cheque a Facturas de Cursos del Programa PATI "
    Public Function ProcesarQuedanFactura(ByVal idFacturaAF As Decimal, ByVal numeroQuedan As Decimal, ByVal userid As String) As String
        Me.sError = ""
        EL.configuracion.usuarioActualiza = userid
        Dim iIdentity As New Security.Principal.GenericIdentity(userid)
        Dim iPrincipal As New Security.Principal.GenericPrincipal(iIdentity, Nothing)
        System.Threading.Thread.CurrentPrincipal = iPrincipal

        Dim liRet As Integer
        Dim lcFACTURA_AF As New cFACTURA_AF
        Dim lFactura As FACTURA_AF = lcFACTURA_AF.ObtenerFACTURA_AF(idFacturaAF)

        If lFactura IsNot Nothing Then
            lFactura.NUMERO_QUEDAN = numeroQuedan
            If numeroQuedan = -1 Then
                lFactura.FECHA_QUEDAN = #12:00:00 AM#
            Else
                lFactura.FECHA_QUEDAN = Today
            End If
            lFactura.USERID = userid
            lFactura.LASTUPDATE = Now
            liRet = lcFACTURA_AF.ActualizarFACTURA_AF(lFactura)
        End If

        If liRet <> 1 Then
            Me.sError = lcFACTURA_AF.sError
        End If

        Return Me.sError
    End Function

    Public Function ProcesarChequeFactura(ByVal idFacturaAF As Decimal, ByVal numeroCheque As String, ByVal fechaEmision As Date, ByVal userid As String) As String
        Me.sError = ""
        EL.configuracion.usuarioActualiza = userid
        Dim iIdentity As New Security.Principal.GenericIdentity(userid)
        Dim iPrincipal As New Security.Principal.GenericPrincipal(iIdentity, Nothing)
        System.Threading.Thread.CurrentPrincipal = iPrincipal

        Dim liRet As Integer
        Dim lcFACTURA_AF As New cFACTURA_AF
        Dim lFactura As FACTURA_AF = lcFACTURA_AF.ObtenerFACTURA_AF(idFacturaAF)

        If lFactura IsNot Nothing Then
            lFactura.NUMERO_CHEQUE = numeroCheque
            lFactura.FECHA_CHEQUE = fechaEmision
            lFactura.USERID = userid
            lFactura.LASTUPDATE = Now
            liRet = lcFACTURA_AF.ActualizarFACTURA_AF(lFactura)
        End If

        If liRet <> 1 Then
            Me.sError = lcFACTURA_AF.sError
        End If

        Return Me.sError
    End Function

#End Region

End Class
