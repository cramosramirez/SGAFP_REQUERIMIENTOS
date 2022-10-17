Partial Public Class dbCURSO_TEMA


    Public Function ObtenerListaPorCODIGO_PROGRAMA(ByVal CODIGO_PROGRAMA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCURSO_TEMA
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM CURSO_TEMA ")
        strSQL.Append("WHERE RTRIM(CODIGO_PROGRAMA) = :CODIGO_PROGRAMA")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        arg = New OracleParameter(":CODIGO_PROGRAMA", OracleType.VarChar)
        arg.Value = Trim(CODIGO_PROGRAMA)
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCURSO_TEMA

        Try
            Do While dr.Read()
                Dim mEntidad As New CURSO_TEMA
                dbAsignarEntidades.AsignarCURSO_TEMA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorTEMA_CURSO(ByVal TEMA_CURSO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCURSO_TEMA
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT * FROM CURSO_TEMA ")
        strSQL.Append("WHERE RTRIM(TEMA_CURSO) = :TEMA_CURSO")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        arg = New OracleParameter(":TEMA_CURSO", OracleType.VarChar)
        arg.Value = Trim(TEMA_CURSO)
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaCURSO_TEMA

        Try
            Do While dr.Read()
                Dim mEntidad As New CURSO_TEMA
                dbAsignarEntidades.AsignarCURSO_TEMA(dr, mEntidad)
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
