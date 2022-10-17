Partial Public Class dbASISTENCIA_PAGO_DET

    Public Function ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ByVal ID_EJERCICIO As String, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTENCIA As Decimal) As ASISTENCIA_PAGO_DET
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
        strSQL.Append(" WHERE PORC_ASISTE_INI <= :PORC_ASISTENCIA AND PORC_ASISTE_FIN >= :PORC_ASISTENCIA ")
        strSQL.Append(" AND ID_MODALIDAD_FORMACION = :ID_MODALIDAD_FORMACION ")
        strSQL.Append(" AND (SELECT COUNT(1) FROM ASISTENCIA_PAGO WHERE ASISTENCIA_PAGO.ID_ASISTE_PAGO = ASISTENCIA_PAGO_DET.ID_ASISTE_PAGO AND ASISTENCIA_PAGO.ID_EJERCICIO = :ID_EJERCICIO) > 0 ")

        Dim args(3) As OracleParameter
        args(0) = New OracleParameter(":ID_MODALIDAD_FORMACION", OracleType.Number)
        args(0).Value = ID_MODALIDAD_FORMACION

        args(1) = New OracleParameter(":PORC_ASISTENCIA", OracleType.Number)
        args(1).Value = PORC_ASISTENCIA

        args(2) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(2).Value = ID_EJERCICIO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New ASISTENCIA_PAGO_DET

        Try
            If dr.HasRows() Then
                dr.Read()
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function EliminarlistaASISTENCIA_PAGO_DET(ByVal ID_ASISTE_PAGO As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter
        Dim lResult As Integer

        strSQL.AppendLine("DELETE FROM ASISTENCIA_PAGO_DET WHERE ID_ASISTE_PAGO = :ID_ASISTE_PAGO")

        op = New OracleParameter(":ID_ASISTE_PAGO", OracleType.Number)
        op.Value = ID_ASISTE_PAGO
        args.Add(op)

        Try
            lResult = OracleHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return lResult

        Catch ex As Exception
            Throw ex
        End Try

        Return -1

    End Function
End Class
