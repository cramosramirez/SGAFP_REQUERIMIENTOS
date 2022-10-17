Partial Public Class dbGRUPO_SOLICITUD

    Public Function ObtenerListaPorCriterios(ByVal ID_SOLICITUD As Decimal, ByVal TDR As String, ByVal CORRELATIVO_GRUPO As Decimal, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SOLICITUD

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT * ")
        strSQL.AppendLine(" FROM GRUPO_SOLICITUD ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_SOLICITUD <> -1 Then
            AgregarCondicion(strSQLCondicion, " ID_SOLICITUD = :ID_SOLICITUD ")
            Dim op As OracleParameter = New OracleParameter(":ID_SOLICITUD", OracleType.Number)
            op.Value = ID_SOLICITUD
            args.Add(op)
        End If
        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " TDR = :TDR ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.VarChar)
            op.Value = TDR
            args.Add(op)
        End If
        If CORRELATIVO_GRUPO <> -1 Then
            AgregarCondicion(strSQLCondicion, " CORRELATIVO_GRUPO = :CORRELATIVO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CORRELATIVO_GRUPO", OracleType.Number)
            op.Value = CORRELATIVO_GRUPO
            args.Add(op)
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaGRUPO_SOLICITUD

        Try
            Do While dr.Read()
                Dim mEntidad As New GRUPO_SOLICITUD
                AsignarGRUPO_SOLICITUD(dr, mEntidad)
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
