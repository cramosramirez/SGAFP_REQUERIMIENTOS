Partial Public Class dbMUNICIPIO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un Dataset con tablas: MUNICIPIOS y SITIOS_CAPACITACION 
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetMunicipiosRelacionSitios(ByVal ID_TIPO_SOLICITUD As Integer, _
                                                            ByVal ID_PROVEEDOR_AF As Decimal, _
                                                            ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                            ByVal CODIGO_DEPTO_SITIO As String, _
                                                            ByVal ID_EJERCICIO As String, _
                                                            ByVal ID_AREA_FORMACION As Decimal, _
                                                            ByVal GENERO As String, _
                                                            ByVal CODIGO_DEPTO_RESIDENCIA As String, _
                                                            ByVal PORCENTAJE_PROCEDENCIA As Integer, _
                                                            Optional ByVal FECHA_INICIAL As Date = #1/1/1900#, _
                                                            Optional ByVal FECHA_FINAL As Date = #1/1/1900#) As DataSet

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQLBase As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        Dim strSQL As New StringBuilder

        Try
            ' ESTA ES LA CONSULTA BASE QUE DEVUELVE LOS ELEMENTOS MUNICIPIOS PARA GRAFICAR EN EL MAPA,
            ' EN BASE AL RESULTADO DE ESTA CONSULTA OBTENDREMOS LOS SITIOS DE CAPACITACIÓN A LOS QUE LOS MUNICIPIOS SE RELACIONAN
            strSQLBase.AppendLine("SELECT B.CODIGO_DEPTO_RESIDENCIA, B.CODIGO_MUNI_RESIDENCIA, B.TOTAL ")
            strSQLBase.AppendLine("FROM ")
            strSQLBase.AppendLine("( ")
            strSQLBase.AppendLine("  SELECT A.CODIGO_DEPTO_RESIDENCIA, A.CODIGO_MUNI_RESIDENCIA, A.TOTAL, ")
            strSQLBase.AppendLine("  SUM(A.PORCENTAJE) OVER(ORDER BY A.TOTAL DESC RANGE UNBOUNDED PRECEDING) AS PORCENTAJE_ACUMULADO ")
            strSQLBase.AppendLine("  FROM ")
            strSQLBase.AppendLine("  ( ")
            strSQLBase.AppendLine("    SELECT CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA, COUNT(ID_SOLICITUD) TOTAL, ")
            strSQLBase.AppendLine("    ROUND(RATIO_TO_REPORT (COUNT(ID_SOLICITUD)) OVER() * 100,3) AS PORCENTAJE ")
            strSQLBase.AppendLine("    FROM VSOLIC_INGRESADAS_HTP ")
            strSQLBase.AppendLine("    WHERE ID_TIPO_SOLICITUD = " + CStr(ID_TIPO_SOLICITUD) + " ")

            If ID_PROVEEDOR_AF <> -1 Then
                strSQLCondicion.Append("  AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
                op = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
                op.Value = ID_PROVEEDOR_AF
                args.Add(op)
            End If

            If ID_SITIO_CAPACITACION <> -1 Then
                strSQLCondicion.Append("  AND ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
                op = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
                op.Value = ID_SITIO_CAPACITACION
                args.Add(op)
            End If

            If CODIGO_DEPTO_SITIO <> "" Then
                strSQLCondicion.Append("  AND CODIGO_DEPTO_SITIO = :CODIGO_DEPTO_SITIO ")
                op = New OracleParameter(":CODIGO_DEPTO_SITIO", OracleType.VarChar)
                op.Value = CODIGO_DEPTO_SITIO
                args.Add(op)
            End If

            If ID_EJERCICIO <> "" Then
                strSQLCondicion.Append("  AND EJERCICIO = :ID_EJERCICIO ")
                op = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
                op.Value = ID_EJERCICIO
                args.Add(op)
            End If

            If ID_AREA_FORMACION <> -1 Then
                strSQLCondicion.Append(" AND ID_AREA_FORMATIVA = :ID_AREA_FORMACION ")
                op = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
                op.Value = ID_AREA_FORMACION
                args.Add(op)
            End If

            If GENERO <> "" Then
                strSQLCondicion.Append("  AND SEXO = :GENERO ")
                op = New OracleParameter(":GENERO", OracleType.VarChar)
                op.Value = GENERO
                args.Add(op)
            End If

            If CODIGO_DEPTO_RESIDENCIA <> "" Then
                strSQLCondicion.Append("  AND CODIGO_DEPTO_RESIDENCIA = :CODIGO_DEPTO_RESIDENCIA ")
                op = New OracleParameter(":CODIGO_DEPTO_RESIDENCIA", OracleType.VarChar)
                op.Value = CODIGO_DEPTO_RESIDENCIA
                args.Add(op)
            End If

            strSQLBase.AppendLine(strSQLCondicion.ToString)
            strSQLBase.AppendLine("    GROUP BY CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA ")
            If PORCENTAJE_PROCEDENCIA >= 50 AndAlso PORCENTAJE_PROCEDENCIA <= 100 Then
                strSQLBase.AppendLine("    ORDER BY COUNT(ID_SOLICITUD) DESC, CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA ")
            ElseIf PORCENTAJE_PROCEDENCIA < 50 Then
                strSQLBase.AppendLine("    ORDER BY COUNT(ID_SOLICITUD) ASC, CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA ")
            End If
            strSQLBase.AppendLine("  ) A ")
            strSQLBase.AppendLine(") B ")

            If PORCENTAJE_PROCEDENCIA < 100 Then
                strSQLBase.AppendLine("WHERE B.PORCENTAJE_ACUMULADO <= " + PORCENTAJE_PROCEDENCIA.ToString + " ")
            End If

            Dim dsResult As New DataSet
            Dim ds As DataSet

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQLBase.ToString(), args.ToArray)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                ds.Tables(0).TableName = "MUNICIPIOS"

                dsResult.Tables.Add(ds.Tables(0).Copy)
                ds.Tables.Clear()
            End If



            ' ESTA ES LA CONSULTA QUE DEVUELVE LOS ELEMENTOS SITIOS DE CAPACITACION PARA GRAFICAR EN EL MAPA,
            ' TOMANDO COMO SUBQUERY LA CONSULTA BASE
            strSQL.AppendLine("SELECT ID_SITIO_CAPACITACION, CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA ")
            strSQL.AppendLine("FROM VSOLIC_INGRESADAS_HTP ")
            strSQL.AppendLine("WHERE ID_TIPO_SOLICITUD = " + CStr(ID_TIPO_SOLICITUD) + " ")

            ' SE AGREGA LA CONDICION FORMADA DE LOS PARÁMETROS PASADOS AL PROCEDIMIENTO
            strSQL.AppendLine(strSQLCondicion.ToString)

            ' SE VALIDA QUE LOS SITIOS DE CAPACITACION DEVUELTOS - ADEMAS DE CUMPLIR CON LOS PARÁMETROS PASADOS -
            ' SEA LOS CORRESPONDIENTES AL UNIVERSO DE MUNICIPIOS DE LA CONSULTA BASE
            strSQL.AppendLine("AND ")
            strSQL.AppendLine("EXISTS ")
            strSQL.AppendLine("( ")
            strSQL.AppendLine(strSQLBase.ToString)
            If PORCENTAJE_PROCEDENCIA < 100 Then
                strSQL.AppendLine("  AND B.CODIGO_DEPTO_RESIDENCIA = VSOLIC_INGRESADAS_HTP.CODIGO_DEPTO_RESIDENCIA AND B.CODIGO_MUNI_RESIDENCIA = VSOLIC_INGRESADAS_HTP.CODIGO_MUNI_RESIDENCIA ")
            Else
                strSQL.AppendLine("  WHERE B.CODIGO_DEPTO_RESIDENCIA = VSOLIC_INGRESADAS_HTP.CODIGO_DEPTO_RESIDENCIA AND B.CODIGO_MUNI_RESIDENCIA = VSOLIC_INGRESADAS_HTP.CODIGO_MUNI_RESIDENCIA ")
            End If
            strSQL.AppendLine(") ")
            strSQL.AppendLine("GROUP BY ID_SITIO_CAPACITACION, CODIGO_DEPTO_RESIDENCIA, CODIGO_MUNI_RESIDENCIA ")
            strSQL.AppendLine("ORDER BY ID_SITIO_CAPACITACION ")

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                ds.Tables(0).TableName = "SITIOS_CAPACITACION"

                dsResult.Tables.Add(ds.Tables(0).Copy)
                ds.Tables.Clear()
            End If

            Return dsResult

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros 
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetCantidadParticipantesPorGenero(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                            ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                                            ByVal CODIGO_MUNICIPIO As String, _
                                                            ByVal ID_AREA_FORMACION As Decimal, _
                                                            ByVal ID_EJERCICIO As String) As DataSet

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SOLICITUD_INSCRIPCION_AF.GENERO AS GENERO, ")
        strSQL.Append("COUNT(DISTINCT SOLICITUD_INSCRIPCION_AF.ID_PARTICIPANTE) AS CANTIDAD ")
        strSQL.Append("FROM SOLICITUD_INSCRIPCION_AF, ACCION_FORMATIVA, MUNICIPIO, CURSO_TEMA ")
        strSQL.Append("WHERE ")
        strSQL.Append("ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO AND ")
        strSQL.Append("MUNICIPIO.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO AND ")
        strSQL.Append("MUNICIPIO.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF AND ")
        strSQL.Append("MUNICIPIO.NOMBRE <> 'DESCONOCIDO-NO UTILIZAR' AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_ACCION_FORMATIVA = SOLICITUD_INSCRIPCION_AF.ID_ACCION_FORMATIVA AND ")
        strSQL.Append("MUNICIPIO.CODIGO_DEPARTAMENTO = SOLICITUD_INSCRIPCION_AF.CODIGO_DEPARTAMENTO AND ")
        strSQL.Append("MUNICIPIO.CODIGO_MUNICIPIO = SOLICITUD_INSCRIPCION_AF.CODIGO_MUNICIPIO ")

        op = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        op.Value = ID_PROVEEDOR_AF
        args.Add(op)

        op = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        op.Value = ID_SITIO_CAPACITACION
        args.Add(op)

        op = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        op.Value = CODIGO_DEPARTAMENTO
        args.Add(op)

        op = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
        op.Value = CODIGO_MUNICIPIO
        args.Add(op)

        If ID_AREA_FORMACION <> -1 Then
            strSQL.Append("AND CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim arg As New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            arg.Value = ID_AREA_FORMACION
            args.Add(arg)
        End If

        op = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        op.Value = ID_EJERCICIO
        args.Add(op)

        strSQL.Append("GROUP BY SOLICITUD_INSCRIPCION_AF.GENERO ")
        strSQL.Append("ORDER BY SOLICITUD_INSCRIPCION_AF.GENERO ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try

        Catch ex As Exception
            Throw ex

        End Try

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros 
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetCantidadParticipantesPorGenero(ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                            ByVal ID_EJERCICIO As String) As DataSet

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SOLICITUD_INSCRIPCION_AF.GENERO AS GENERO, ")
        strSQL.Append("COUNT(DISTINCT SOLICITUD_INSCRIPCION_AF.ID_PARTICIPANTE) AS CANTIDAD ")
        strSQL.Append("FROM SOLICITUD_INSCRIPCION_AF, ACCION_FORMATIVA, MUNICIPIO ")
        strSQL.Append("WHERE ")
        strSQL.Append("ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO AND ")
        strSQL.Append("MUNICIPIO.NOMBRE <> 'DESCONOCIDO-NO UTILIZAR' AND ")
        strSQL.Append("ACCION_FORMATIVA.ID_ACCION_FORMATIVA = SOLICITUD_INSCRIPCION_AF.ID_ACCION_FORMATIVA AND ")
        strSQL.Append("MUNICIPIO.CODIGO_DEPARTAMENTO = SOLICITUD_INSCRIPCION_AF.CODIGO_DEPARTAMENTO AND ")
        strSQL.Append("MUNICIPIO.CODIGO_MUNICIPIO = SOLICITUD_INSCRIPCION_AF.CODIGO_MUNICIPIO ")
        strSQL.Append("GROUP BY SOLICITUD_INSCRIPCION_AF.GENERO ")
        strSQL.Append("ORDER BY SOLICITUD_INSCRIPCION_AF.GENERO ")

        op = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        op.Value = ID_SITIO_CAPACITACION
        args.Add(op)

        op = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        op.Value = ID_EJERCICIO
        args.Add(op)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Try

        Catch ex As Exception
            Throw ex

        End Try

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Entidad filtrada por los parámetros 
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="NOMBRE_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	08/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMUNICIPIOPorNOMBRE(ByVal CODIGO_DEPARTAMENTO As String, ByVal NOMBRE_MUNICIPIO As String) As MUNICIPIO

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM MUNICIPIO ")
        strSQL.Append("WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO AND NOMBRE = :NOMBRE_MUNICIPIO ")

        op = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        op.Value = CODIGO_DEPARTAMENTO
        args.Add(op)

        op = New OracleParameter(":NOMBRE_MUNICIPIO", OracleType.VarChar)
        op.Value = NOMBRE_MUNICIPIO
        args.Add(op)

        Dim dr As IDataReader
        Dim aEntidad As MUNICIPIO

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex

        End Try

        Return aEntidad

    End Function

    Public Function ObtenerMUNICIPIOPorNOMBRE_NOMBRE_DEPTO(ByVal NOMBRE_DEPARTAMENTO As String, ByVal NOMBRE_MUNICIPIO As String) As MUNICIPIO

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT M.* ")
        strSQL.Append("FROM MUNICIPIO M ")
        strSQL.Append("WHERE M.NOMBRE = :NOMBRE_MUNICIPIO ")
        strSQL.Append("AND (SELECT COUNT(1) FROM DEPARTAMENTO D WHERE D.NOMBRE = :NOMBRE_DEPARTAMENTO AND D.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO) > 0")

        op = New OracleParameter(":NOMBRE_DEPARTAMENTO", OracleType.VarChar)
        op.Value = NOMBRE_DEPARTAMENTO
        args.Add(op)

        op = New OracleParameter(":NOMBRE_MUNICIPIO", OracleType.VarChar)
        op.Value = NOMBRE_MUNICIPIO
        args.Add(op)

        Dim dr As IDataReader
        Dim aEntidad As MUNICIPIO

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return aEntidad

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Strings de los tecnicos asociados.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	12/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerTECNICO_ASIGNADOS(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As List(Of String)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(" SELECT USUARIO ")
        strSQL.AppendLine(" FROM TECNICOS_MUNICIPIOS_PATI_ASIG ")
        strSQL.AppendLine(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine(" AND CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ")

        Dim mUsuario As String = ""
        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO
        args(1) = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
        args(1).Value = CODIGO_MUNICIPIO

        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim usuarios As New List(Of String)
        Try
            If dr.Read() Then
                usuarios.Add(dr.GetString(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return usuarios

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento que recibe de parametro
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As listaMUNICIPIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO))
        strSQL.AppendLine(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("   AND EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = MUNICIPIO.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("              AND FM.CODIGO_MUNICIPIO = MUNICIPIO.CODIGO_MUNICIPIO ) ")
        strSQL.AppendLine(" ORDER BY MUNICIPIO.NOMBRE ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMUNICIPIO

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO
                dbAsignarEntidades.AsignarMUNICIPIO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento que recibe de parametro
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE(ByVal ID_FUENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String) As listaMUNICIPIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO))
        strSQL.AppendLine(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("   AND EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = MUNICIPIO.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("              AND FM.CODIGO_MUNICIPIO = MUNICIPIO.CODIGO_MUNICIPIO ")
        strSQL.AppendLine("              AND FM.ID_FUENTE = :ID_FUENTE) ")
        strSQL.AppendLine(" ORDER BY MUNICIPIO.NOMBRE ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_FUENTE", OracleType.Number)
        args(0).Value = ID_FUENTE

        args(1) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(1).Value = CODIGO_DEPARTAMENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMUNICIPIO

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO
                dbAsignarEntidades.AsignarMUNICIPIO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento y Tecnico que recibe de parametro
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="USUARIO_TECNICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorDepartamentoTecnico(ByVal CODIGO_DEPARTAMENTO As String, ByVal USUARIO_TECNICO As String) As listaMUNICIPIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO))
        strSQL.AppendLine(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("   AND EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = MUNICIPIO.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("              AND FM.CODIGO_MUNICIPIO = MUNICIPIO.CODIGO_MUNICIPIO )")
        strSQL.AppendLine("  AND EXISTS (SELECT 1 FROM TECNICOS_MUNICIPIOS_PATI_ASIG TMPA")
        strSQL.AppendLine("              WHERE TMPA.CODIGO_DEPARTAMENTO = MUNICIPIO.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("              AND TMPA.CODIGO_MUNICIPIO = MUNICIPIO.CODIGO_MUNICIPIO")
        strSQL.AppendLine("              AND TMPA.USUARIO = :USUARIO)")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO
        args(1) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(1).Value = USUARIO_TECNICO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMUNICIPIO

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO
                dbAsignarEntidades.AsignarMUNICIPIO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por la Fuente de Financiamiento que recibe de parametro
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorFUENTE(ByVal ID_FUENTE As Decimal) As listaMUNICIPIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO))
        strSQL.AppendLine(" WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.ID_FUENTE = :ID_FUENTE ")
        strSQL.AppendLine("              AND FM.CODIGO_DEPARTAMENTO = MUNICIPIO.CODIGO_DEPARTAMENTO AND FM.CODIGO_MUNICIPIO = MUNICIPIO.CODIGO_MUNICIPIO) ")
        strSQL.AppendLine(" ORDER BY MUNICIPIO.NOMBRE ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_FUENTE", OracleType.Number)
        args(0).Value = ID_FUENTE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaMUNICIPIO

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO
                dbAsignarEntidades.AsignarMUNICIPIO(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
End Class
