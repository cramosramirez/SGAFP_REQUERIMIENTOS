Partial Public Class dbSIPU_DETALLECAPACITADO
    Private Function SQL_SIPU_DETALLECAPACITADO() As String
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT IDINICIAL + ROWNUM AS IDDETALLECAPACITADO, IDCAPACITACION, CASE WHEN NUMEROCONVENIO IS NULL THEN (SELECT MAX(DF.NUME_FAMI) FROM FICHA_PATI FP, DETA_FAMI DF WHERE FP.ID_PARTICIPANTE = T.ID_PARTICIPANTE AND FP.NUME_FICH = DF.NUME_FICH_PATI) ELSE NUMEROCONVENIO END AS NUMEROCONVENIO, IDESTADO ")
        strSQL.AppendLine("FROM ")
        strSQL.AppendLine("( ")
        strSQL.AppendLine("  SELECT (SELECT NVL(MAX(IDDETALLECAPACITADO),0) FROM SIPU_DETALLECAPACITADO) as IDINICIAL, AF.ID_ACCION_FORMATIVA AS IDCAPACITACION, ")
        strSQL.AppendLine("  ( SELECT MAX(DF.NUME_FAMI) FROM FICHA_PATI FP, DETA_FAMI DF ")
        strSQL.AppendLine("    WHERE FP.ID_FUENTE = DF.ID_FUENTE ")
        strSQL.AppendLine("    AND FP.NO_CONVOCATORIA = DF.NO_CONVOCATORIA ")
        strSQL.AppendLine("    AND FP.ID_PARTICIPANTE = IND.ID_PARTICIPANTE ")
        strSQL.AppendLine("    AND FP.ID_FUENTE = AD.ID_FUENTE ")
        strSQL.AppendLine("    AND FP.NO_CONVOCATORIA = AD.NO_CONVOCATORIA ")
        strSQL.AppendLine("    AND FP.NUME_FICH = DF.NUME_FICH_PATI ")
        strSQL.AppendLine("   ) AS NUMEROCONVENIO, ")
        strSQL.AppendLine("   CASE ")
        strSQL.AppendLine("   WHEN IND.PORC_ASISTENCIA >= (SELECT PF.PORC_ASISTENCIA_MINIMA FROM PROGRAMA_FORMACION PF WHERE PF.ID_PROGRAMA_FORMACION = AD.ID_PROGRAMA_FORMACION) THEN 1009 ")
        strSQL.AppendLine("   ELSE 1010 ")
        strSQL.AppendLine("   END AS IDESTADO, ")
        strSQL.AppendLine("   IND.ID_PARTICIPANTE ")
        strSQL.AppendLine("  FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE AD, INFORME_FINAL_AF INF, INFORME_FINAL_DET IND ")
        strSQL.AppendLine("  WHERE AF.ID_ACCION_FORMATIVA = AD.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND INF.ID_INFORME_FINAL = IND.ID_INFORME_FINAL ")
        strSQL.AppendLine("  AND AD.ID_FUENTE = :ID_FUENTE ")
        strSQL.AppendLine("  AND AD.NO_CONVOCATORIA = :NO_CONVOCATORIA ")
        strSQL.AppendLine("  AND EXISTS(SELECT 1 FROM PARTICIPANTE_AF PAF ")
        strSQL.AppendLine("  WHERE PAF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND PAF.ID_PARTICIPANTE = IND.ID_PARTICIPANTE ")
        strSQL.AppendLine("  AND PAF.ESTADO IN('I','V')) ")
        strSQL.AppendLine(") T ")
        Return strSQL.ToString
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetSIPU_DETALLECAPACITADO(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, Me.SQL_SIPU_DETALLECAPACITADO(), args.ToArray)
        Return ds
    End Function

    Public Function AgregarLotePorFuenteConvocatoria(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As Integer
        Dim strSQL As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        strSQL.AppendLine("INSERT INTO SIPU_DETALLECAPACITADO ")
        strSQL.AppendLine(Me.SQL_SIPU_DETALLECAPACITADO)

        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)
    End Function

End Class
