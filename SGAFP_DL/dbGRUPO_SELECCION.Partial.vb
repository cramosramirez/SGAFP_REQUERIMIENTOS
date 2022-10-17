Partial Public Class dbGRUPO_SELECCION


    Public Function ObtenerTotalHorasCalendarizadas(ByVal ID_GRUPO_SELEC As Decimal) As Object

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT NVL(SUM(AF.DURACION_HORAS),0) AS HORAS ")
        strSQL.Append("FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D ")
        strSQL.Append("WHERE AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA AND D.ID_GRUPO_SELEC = :ID_GRUPO_SELEC ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_GRUPO_SELEC", OracleType.Number)
        args(0).Value = ID_GRUPO_SELEC

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerUltimaFechaInicioCalendarizada(ByVal ID_GRUPO_SELEC As Decimal) As Object

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT MAX(AF.FECHA_INICIO_REAL) AS ULT_FECHA_INICIO ")
        strSQL.Append("FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D ")
        strSQL.Append("WHERE AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA AND D.ID_GRUPO_SELEC = :ID_GRUPO_SELEC ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_GRUPO_SELEC", OracleType.Number)
        args(0).Value = ID_GRUPO_SELEC

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            ByVal CON_INFORME_PRESELECCION As Integer, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SELECCION

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT G.* FROM GRUPO_SELECCION G, ACCION_CONTRATADA A, CONTRATO_BOLPROS C WHERE G.ID_ACCION_CONTRATADA = A.ID_ACCION_CONTRATADA AND A.ID_CONTRATO = C.ID_CONTRATO ")

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
            strSQL.AppendLine("AND C.NUM_CONTRATO LIKE :NUM_CONTRATO || '%' ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO
            args.Add(op)
        End If
        If CON_INFORME_PRESELECCION <> -1 AndAlso CON_INFORME_PRESELECCION = 1 Then
            strSQL.AppendLine("AND (SELECT COUNT(1) FROM INFORME_PRESELECCION_EC I WHERE I.ID_GRUPO_SELEC = G.ID_GRUPO_SELEC) > 0 ")
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

        Dim lista As New listaGRUPO_SELECCION

        Try
            Do While dr.Read()
                Dim mEntidad As New GRUPO_SELECCION
                AsignarGRUPO_SELECCION(dr, mEntidad)
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
