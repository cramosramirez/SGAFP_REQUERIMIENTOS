Partial Public Class dbINFORME_FINAL_DET

    Public Function ObtenerListaPorInformeIdParticipante(ByVal ID_INFORME_FINAL As Decimal, _
                                            ByVal ID_PARTICIPANTE As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_DET

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        strSQL.AppendLine(QuerySelect(New INFORME_FINAL_DET))


        AgregarCondicion(strSQLCondicion, " INFORME_FINAL_DET.ID_INFORME_FINAL = :ID_INFORME_FINAL ")
        op = New OracleParameter(":ID_INFORME_FINAL", OracleType.Number)
        op.Value = ID_INFORME_FINAL
        args.Add(op)

        AgregarCondicion(strSQLCondicion, " INFORME_FINAL_DET.ID_PARTICIPANTE = :ID_PARTICIPANTE ")
        op = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        op.Value = ID_PARTICIPANTE
        args.Add(op)

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaINFORME_FINAL_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_DET
                AsignarINFORME_FINAL_DET(dr, mEntidad)
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
