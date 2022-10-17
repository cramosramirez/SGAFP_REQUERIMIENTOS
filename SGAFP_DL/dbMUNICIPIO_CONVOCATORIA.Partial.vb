Partial Public Class dbMUNICIPIO_CONVOCATORIA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_FUENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_CONVOCATORIA
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO_CONVOCATORIA))

        If ID_FUENTE <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
            arg.Value = ID_FUENTE
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ID_FUENTE = :ID_FUENTE")
        End If
        If CODIGO_DEPARTAMENTO <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO")
        End If
        If CODIGO_MUNICIPIO <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            arg.Value = CODIGO_MUNICIPIO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO")
        End If
        If NO_CONVOCATORIA <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
            arg.Value = NO_CONVOCATORIA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "NO_CONVOCATORIA = :NO_CONVOCATORIA")
        End If

        strSQL.Append(strCondicion.ToString)
        strSQL.Append(" ORDER BY CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, NO_CONVOCATORIA")

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaMUNICIPIO_CONVOCATORIA

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO_CONVOCATORIA
                dbAsignarEntidades.AsignarMUNICIPIO_CONVOCATORIA(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strTablaTemp1 As New StringBuilder
        Dim condTablaTemp1 As New StringBuilder
        strTablaTemp1.AppendLine("WITH CONVOCATORIA AS")
        strTablaTemp1.AppendLine("  (")
        strTablaTemp1.AppendLine("  SELECT TO_CHAR(MC.ID_FUENTE) || '-' || TO_CHAR(MC.NO_CONVOCATORIA) ")
        strTablaTemp1.AppendLine("  || '-' ")
        strTablaTemp1.AppendLine("  || MC.CODIGO_DEPARTAMENTO ")
        strTablaTemp1.AppendLine("  || '-' ")
        strTablaTemp1.AppendLine("  || MC.CODIGO_MUNICIPIO AS CLAVE_COMPUESTA, ")
        strTablaTemp1.AppendLine("  MC.ID_FUENTE, ")
        strTablaTemp1.AppendLine("  MC.NO_CONVOCATORIA, ")
        strTablaTemp1.AppendLine("  MC.CODIGO_DEPARTAMENTO, ")
        strTablaTemp1.AppendLine("  MC.CODIGO_MUNICIPIO, ")
        strTablaTemp1.AppendLine("  MC.APORTE_FISDL, ")
        strTablaTemp1.AppendLine("  MC.MONTO_LIQUIDADO, ")
        strTablaTemp1.AppendLine("  MC.APORTE_FISDL - MC.MONTO_LIQUIDADO AS SALDO_LIQUIDAR, ")
        strTablaTemp1.AppendLine("  MC.CODIGO_PROYECTO, ")
        strTablaTemp1.AppendLine("  MC.NOMBRE_PROYECTO,   ")
        strTablaTemp1.AppendLine("  D.NOMBRE AS NOMBRE_DEPARTAMENTO, ")
        strTablaTemp1.AppendLine("  M.NOMBRE AS NOMBRE_MUNICIPIO, ")
        strTablaTemp1.AppendLine("  MC.ASESOR_MUNICIPAL, ")
        strTablaTemp1.AppendLine("  (SELECT NVL(COUNT(ML.ID_LIQUIDACION),0) FROM MUNICIPIO_LIQUIDACION ML WHERE ML.ID_FUENTE = MC.ID_FUENTE AND ML.NO_CONVOCATORIA = MC.NO_CONVOCATORIA AND ML.CODIGO_DEPARTAMENTO = MC.CODIGO_DEPARTAMENTO AND ML.CODIGO_MUNICIPIO = MC.CODIGO_MUNICIPIO) AS NUM_LIQUIDACIONES ")
        strTablaTemp1.AppendLine("  FROM MUNICIPIO_CONVOCATORIA MC, MUNICIPIO M, DEPARTAMENTO D ")
        strTablaTemp1.AppendLine("  WHERE MC.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO  ")
        strTablaTemp1.AppendLine("  AND MC.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO   ")
        strTablaTemp1.AppendLine("  AND D.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO ")

        Dim strTablaTemp2 As New StringBuilder
        Dim condTablaTemp2 As New StringBuilder
        strTablaTemp2.AppendLine("  MONTO_CUBIERTO AS (")
        strTablaTemp2.AppendLine("    SELECT T.ID_FUENTE, T.NO_CONVOCATORIA, T.CODIGO_DEPARTAMENTO, T.CODIGO_MUNICIPIO, SUM(T.MONTO_CUBIERTO) AS MONTO_CUBIERTO ")
        strTablaTemp2.AppendLine("    FROM ( ")
        strTablaTemp2.AppendLine("            SELECT")
        strTablaTemp2.AppendLine("            V.ID_FUENTE, V.NO_CONVOCATORIA, V.CODIGO_DEPARTAMENTO, V.CODIGO_MUNICIPIO,")
        strTablaTemp2.AppendLine("            CASE ")
        strTablaTemp2.AppendLine("             WHEN V.ID_FUENTE = 1 OR V.ID_FUENTE = 3 THEN (INF.PARTICIPANTES_FINALES * (SELECT COSTO_X_PARTICIPANTE FROM FUENTE_FINANCIAMIENTO FF WHERE FF.ID_FUENTE = V.ID_FUENTE)) ")
        strTablaTemp2.AppendLine("             WHEN V.ID_FUENTE = 2 THEN (AF.DURACION_HORAS * (SELECT COSTO_X_PARTICIPANTE FROM FUENTE_FINANCIAMIENTO FF WHERE FF.ID_FUENTE = V.ID_FUENTE)) ")
        strTablaTemp2.AppendLine("             ELSE 0 ")
        strTablaTemp2.AppendLine("            END AS MONTO_CUBIERTO ")
        strTablaTemp2.AppendLine("            FROM FACTURA_AF FE, FACTURA_DET FD, ACCION_FORMATIVA_DETALLE V, INFORME_FINAL_AF INF, ACCION_FORMATIVA AF ")
        strTablaTemp2.AppendLine("         WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF ")
        strTablaTemp2.AppendLine("         AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
        strTablaTemp2.AppendLine("         AND INF.ID_ACCION_FORMATIVA = V.ID_ACCION_FORMATIVA ")
        strTablaTemp2.AppendLine("         AND V.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strTablaTemp2.AppendLine("         AND NOT FE.NUMERO_QUEDAN IS NULL ")
        strTablaTemp2.AppendLine("         AND NOT EXISTS( SELECT 1 FROM MUNICIPIO_LIQUIDACION_DET ML WHERE ML.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA) ")
        strTablaTemp2.AppendLine("     ) T ")
        strTablaTemp2.AppendLine("    GROUP BY T.ID_FUENTE, T.NO_CONVOCATORIA, T.CODIGO_DEPARTAMENTO, T.CODIGO_MUNICIPIO ")

        Dim strTablaRet As New StringBuilder
        strTablaRet.AppendLine(" SELECT C.CLAVE_COMPUESTA,")
        strTablaRet.AppendLine("  C.ID_FUENTE, ")
        strTablaRet.AppendLine("  C.NO_CONVOCATORIA, ")
        strTablaRet.AppendLine("  C.CODIGO_DEPARTAMENTO, ")
        strTablaRet.AppendLine("  C.CODIGO_MUNICIPIO, ")
        strTablaRet.AppendLine("  C.APORTE_FISDL, ")
        strTablaRet.AppendLine("  C.MONTO_LIQUIDADO, ")
        strTablaRet.AppendLine("  C.APORTE_FISDL - C.MONTO_LIQUIDADO AS SALDO_LIQUIDAR, ")
        strTablaRet.AppendLine("  C.CODIGO_PROYECTO, ")
        strTablaRet.AppendLine("  C.NOMBRE_PROYECTO,   ")
        strTablaRet.AppendLine("  C. NOMBRE_DEPARTAMENTO, ")
        strTablaRet.AppendLine("  C.NOMBRE_MUNICIPIO, ")
        strTablaRet.AppendLine("  C.ASESOR_MUNICIPAL,")
        strTablaRet.AppendLine("  NVL(M.MONTO_CUBIERTO,0) AS MONTO_CUBIERTO,")
        strTablaRet.AppendLine("  CASE WHEN (C.APORTE_FISDL - C.MONTO_LIQUIDADO)<=0 THEN 100 ELSE ROUND(NVL(M.MONTO_CUBIERTO,0)/(C.APORTE_FISDL - C.MONTO_LIQUIDADO)*100,2) END AS PORC_MONTO_CUBIERTO,")
        strTablaRet.AppendLine("  C.NUM_LIQUIDACIONES")
        strTablaRet.AppendLine("  FROM CONVOCATORIA C")
        strTablaRet.AppendLine("  LEFT OUTER JOIN MONTO_CUBIERTO M ")
        strTablaRet.AppendLine("  ON C.ID_FUENTE = M.ID_FUENTE AND C.NO_CONVOCATORIA = M.NO_CONVOCATORIA AND C.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO AND C.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO")


        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)
        Me.AgregarCondicion(strTablaTemp1, "MC.ID_FUENTE = :ID_FUENTE")
        Me.AgregarCondicion(condTablaTemp2, "T.ID_FUENTE = :ID_FUENTE", " HAVING ")

        If CODIGO_DEPARTAMENTO IsNot Nothing AndAlso CODIGO_DEPARTAMENTO <> "" Then
            arg = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
            Me.AgregarCondicion(strTablaTemp1, "FM.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO")
            Me.AgregarCondicion(condTablaTemp2, "T.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO", " HAVING ")
        End If
        If CODIGO_MUNICIPIO IsNot Nothing AndAlso CODIGO_MUNICIPIO <> "" Then
            arg = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            arg.Value = CODIGO_MUNICIPIO
            args.Add(arg)
            Me.AgregarCondicion(strTablaTemp1, "FM.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO")
            Me.AgregarCondicion(condTablaTemp2, "T.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO", " HAVING ")
        End If
        If NO_CONVOCATORIA <> -1 Then
            arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
            arg.Value = NO_CONVOCATORIA
            args.Add(arg)
            Me.AgregarCondicion(strTablaTemp1, "MC.NO_CONVOCATORIA = :NO_CONVOCATORIA")
            Me.AgregarCondicion(condTablaTemp2, "T.NO_CONVOCATORIA = :NO_CONVOCATORIA", " HAVING ")
        End If
        strTablaRet.AppendLine(" ORDER BY C.NOMBRE_DEPARTAMENTO, C.NOMBRE_MUNICIPIO ")
        strTablaTemp1.AppendLine("), ")
        strTablaTemp2.AppendLine(condTablaTemp2.ToString + ") ")

        strTablaTemp1.AppendLine(strTablaTemp2.ToString)
        strTablaTemp1.AppendLine(strTablaRet.ToString)

        Dim ds As New DataSet
        Try
            If args.Count = 0 Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strTablaTemp1.ToString())
            Else
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strTablaTemp1.ToString(), args.ToArray)
            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	27/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_CONVOCATORIA
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO_CONVOCATORIA))
        strSQL.AppendLine(" WHERE MUNICIPIO_CONVOCATORIA.NO_CONVOCATORIA = :NO_CONVOCATORIA")
        strSQL.AppendLine(" AND MUNICIPIO_CONVOCATORIA.ID_FUENTE = :ID_FUENTE")
        strSQL.AppendLine(" ORDER BY MUNICIPIO_CONVOCATORIA.CODIGO_DEPARTAMENTO, MUNICIPIO_CONVOCATORIA.CODIGO_MUNICIPIO")

        arg = New OracleParameter("ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter("NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaMUNICIPIO_CONVOCATORIA

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO_CONVOCATORIA
                dbAsignarEntidades.AsignarMUNICIPIO_CONVOCATORIA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Devuelve las Fechas de Elaboración de la Liquidación filtrada por los parámetros siguientes
    '''' </summary>
    '''' <param name="ID_FUENTE"></param>
    '''' <param name="NO_CONVOCATORIA"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[cramos]	27/09/2011	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    Public Function ObtenerFechasLiquidacionPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.AppendLine(" SELECT TO_CHAR(MUNICIPIO_LIQUIDACION.FECHA_ELABORACION,'dd/mm/yyyy') AS FECHA_ELABORACION")
        strSQL.AppendLine(" FROM MUNICIPIO_LIQUIDACION ")
        strSQL.AppendLine(" WHERE MUNICIPIO_LIQUIDACION.ID_FUENTE = :ID_FUENTE")
        strSQL.AppendLine(" AND MUNICIPIO_LIQUIDACION.NO_CONVOCATORIA = :NO_CONVOCATORIA")
        strSQL.AppendLine(" GROUP BY MUNICIPIO_LIQUIDACION.FECHA_ELABORACION")
        strSQL.AppendLine(" ORDER BY MUNICIPIO_LIQUIDACION.FECHA_ELABORACION DESC")


        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)
       
        Dim ds As New DataSet
        Try

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function
End Class
