Partial Public Class dbRANGO_PORC_PENA

    Public Function ObtenerRANGO_PORC_PENA_PorDIAS(ByVal DIAS_TRANSCURRIDOS As Integer, ByVal ID_TIPO_PENA As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal) As RANGO_PORC_PENA
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New RANGO_PORC_PENA))
        strSQL.Append(" WHERE RANGO_INI <= :DIAS_TRANSCURRIDOS AND RANGO_FIN >= :DIAS_TRANSCURRIDOS ")
        strSQL.Append(" AND ID_TIPO_PENA = :ID_TIPO_PENA AND ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION")

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":DIAS_TRANSCURRIDOS", OracleType.Number)
        args(0).Value = DIAS_TRANSCURRIDOS

        args(1) = New OracleParameter(":ID_TIPO_PENA", OracleType.Number)
        args(1).Value = ID_TIPO_PENA

        args(2) = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        args(2).Value = ID_PROGRAMA_FORMACION

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New RANGO_PORC_PENA

        Try
            If dr.HasRows() Then
                dr.Read()
                dbAsignarEntidades.AsignarRANGO_PORC_PENA(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function ObtenerListaPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As listaRANGO_PORC_PENA
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append(Me.QuerySelect(New RANGO_PORC_PENA))
        strSQL.Append(" WHERE ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ORDER BY ID_RANGO")

        arg = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        arg.Value = ID_PROGRAMA_FORMACION
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaRANGO_PORC_PENA

        Try
            While dr.Read()
                Dim mEntidad As New RANGO_PORC_PENA
                dbAsignarEntidades.AsignarRANGO_PORC_PENA(dr, mEntidad)
                lista.Add(mEntidad)
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
End Class
