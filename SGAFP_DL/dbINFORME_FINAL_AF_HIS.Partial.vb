Partial Public Class dbINFORME_FINAL_AF_HIS

    Public Function ObtenerUltimoRegistroEstado(ByVal ID_INFORME_FINAL As Decimal, ByVal ID_ESTADO_INFORME As Decimal) As INFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT I.* ")
        strSQL.AppendLine("FROM INFORME_FINAL_AF_HIS I ")
        strSQL.AppendLine("WHERE ID_INFORME_FINAL = :ID_INFORME_FINAL ")
        strSQL.AppendLine("AND ID_ESTADO_INFORME = " + CStr(ID_ESTADO_INFORME) + " ")
        strSQL.AppendLine("ORDER BY LASTUPDATE DESC")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_INFORME_FINAL", OracleType.Double)
        args(0).Value = ID_INFORME_FINAL

        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New INFORME_FINAL_AF_HIS

        Try
            If dr.Read() Then
                AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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

End Class
