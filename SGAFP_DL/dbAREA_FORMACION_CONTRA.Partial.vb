Partial Public Class dbAREA_FORMACION_CONTRA


    Public Function ObtenerAREA_FORMACION_CONTRAPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As AREA_FORMACION_CONTRA
        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT AC.* ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA AF, OFERTA_FORMATIVA FF, CURSO_TEMA CT, AREA_FORMACION_CONTRA AC ")
        strSQL.AppendLine("WHERE AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND  ")
        strSQL.AppendLine("AF.ID_OFERTA_FORMATIVA = FF.ID_OFERTA_FORMATIVA AND ")
        strSQL.AppendLine("FF.ID_TEMA_CURSO = CT.ID_TEMA_CURSO AND ")
        strSQL.AppendLine("CT.ID_AREA_FORMACION = AC.ID_AREA_FORMACION AND ")
        strSQL.AppendLine("AC.ID_CONTRATO = FF.ID_CONTRATO ")

        Dim op As OracleParameter = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        op.Value = ID_ACCION_FORMATIVA
        args.Add(op)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())

        Dim mEntidad As New AREA_FORMACION_CONTRA

        Try
            If dr.Read() Then
                AsignarAREA_FORMACION_CONTRA(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function


    Public Function ObtenerMontoEjecutadoPorAreaContratada(ByVal ID_AREA_CONTRA As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim lRet As Decimal = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(SUM(I.MONTO_FACTURA),0) AS MONTO_EJECUTADO ")
        strSQL.AppendLine("FROM AREA_FORMACION_CONTRA AC, OFERTA_FORMATIVA FF, CURSO_TEMA CT, ACCION_FORMATIVA AF, INFORME_FINAL_AF I ")
        strSQL.AppendLine("WHERE AC.ID_AREA_CONTRA = :ID_AREA_CONTRA AND ")
        strSQL.AppendLine("AC.ID_CONTRATO = FF.ID_CONTRATO AND ")
        strSQL.AppendLine("FF.ID_TEMA_CURSO = CT.ID_TEMA_CURSO AND ")
        strSQL.AppendLine("CT.ID_AREA_FORMACION = AC.ID_AREA_FORMACION AND ")
        strSQL.AppendLine("FF.ID_OFERTA_FORMATIVA = AF.ID_OFERTA_FORMATIVA AND ")
        strSQL.AppendLine("AF.ID_ACCION_FORMATIVA = I.ID_ACCION_FORMATIVA ")

        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_AREA_CONTRA", OracleType.Number)
        arg.Value = ID_AREA_CONTRA
        args.Add(arg)

        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Try
            If dr.Read Then
                lRet = CDec(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    Public Function ObtenerParticipacionesEjecutadasPorAreaContratada(ByVal ID_AREA_CONTRA As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim lRet As Decimal = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(SUM(I.PARTICIPANTES_FINALES),0) AS PARTICIPACIONES_EJECUTADAS ")
        strSQL.AppendLine("FROM AREA_FORMACION_CONTRA AC, OFERTA_FORMATIVA FF, CURSO_TEMA CT, ACCION_FORMATIVA AF, INFORME_FINAL_AF I ")
        strSQL.AppendLine("WHERE AC.ID_AREA_CONTRA = :ID_AREA_CONTRA AND ")
        strSQL.AppendLine("AC.ID_CONTRATO = FF.ID_CONTRATO AND ")
        strSQL.AppendLine("FF.ID_TEMA_CURSO = CT.ID_TEMA_CURSO AND ")
        strSQL.AppendLine("CT.ID_AREA_FORMACION = AC.ID_AREA_FORMACION AND ")
        strSQL.AppendLine("FF.ID_OFERTA_FORMATIVA = AF.ID_OFERTA_FORMATIVA AND ")
        strSQL.AppendLine("AF.ID_ACCION_FORMATIVA = I.ID_ACCION_FORMATIVA ")

        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_AREA_CONTRA", OracleType.Number)
        arg.Value = ID_AREA_CONTRA
        args.Add(arg)

        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Try
            If dr.Read Then
                lRet = CDec(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

End Class
