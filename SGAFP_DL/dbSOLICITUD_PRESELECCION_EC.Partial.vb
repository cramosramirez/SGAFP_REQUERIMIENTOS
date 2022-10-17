Partial Public Class dbSOLICITUD_PRESELECCION_EC


    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                              ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                              ByVal NUM_CONTRATO As String, _
                                              ByVal CODIGO As String, _
                                              ByVal NO_GRUPO As Decimal, _
                                              Optional ByVal asColumnaOrden As String = "", _
                                              Optional ByVal asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT S.* FROM SOLICITUD_PRESELECCION_EC S, GRUPO_SELECCION G, ACCION_CONTRATADA A, CONTRATO_BOLPROS C WHERE G.ID_ACCION_CONTRATADA = A.ID_ACCION_CONTRATADA AND A.ID_CONTRATO = C.ID_CONTRATO AND G.ID_GRUPO_SELEC = S.ID_GRUPO_SELEC ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine("AND C.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            strSQL.AppendLine("AND C.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            op.Value = ID_PROGRAMA_FORMACION
            args.Add(op)
        End If
        If NUM_CONTRATO <> "" Then
            strSQL.AppendLine("AND C.NUM_CONTRATO = :NUM_CONTRATO ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO
            args.Add(op)
        End If
        If CODIGO <> "" Then
            strSQL.AppendLine("AND G.CODIGO = :CODIGO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO", OracleType.VarChar)
            op.Value = CODIGO
            args.Add(op)
        End If
        If NO_GRUPO <> -1 Then
            strSQL.AppendLine("AND G.NO_GRUPO = :NO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":NO_GRUPO", OracleType.Number)
            op.Value = NO_GRUPO
            args.Add(op)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
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
