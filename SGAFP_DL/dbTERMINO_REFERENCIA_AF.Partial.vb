Partial Class dbTERMINO_REFERENCIA_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' TDR y NIT de Proveedor
    ''' </summary>
    ''' <param name="tdr"></param>
    ''' <param name="nitProveedor"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	08/07/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedorTDR(ByVal tdr As String, ByVal nitProveedor As String) As listaTERMINO_REFERENCIA_AF

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT TR.*")
        strSQL.AppendLine("FROM TERMINO_REFERENCIA_AF TR,")
        strSQL.AppendLine("  ACCION_FORMATIVA AF,")
        strSQL.AppendLine("  PROVEEDOR_AF P")
        strSQL.AppendLine("WHERE TR.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA")
        strSQL.AppendLine("  AND AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF")
        strSQL.AppendLine("  AND TRIM(TR.TDR) = TRIM(:TDR)")
        strSQL.AppendLine("  AND P.NIT = :NIT")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":TDR", OracleType.VarChar)
        args(0).Value = tdr
        args(1) = New OracleParameter(":NIT", OracleType.VarChar)
        args(1).Value = nitProveedor

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaTERMINO_REFERENCIA_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New TERMINO_REFERENCIA_AF
                dbAsignarEntidades.AsignarTERMINO_REFERENCIA_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por el parámetros Resolucion de la Tabla TERMINO_REFERENCIA.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="RESOLUCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2011	Created
    ''' 	[cramos]	07/09/2012	Modificado: Se implementa filtro de DataSet por ID_PROGRAMA_FORMACION 

    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal RESOLUCION As String) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT TDR.RESOLUCION, TDR.TDR, P.NOMBRE_PROVEEDOR, COUNT(AF.ID_ACCION_FORMATIVA) AS GRUPOS, ")
        strSQL.AppendLine("SUM(MONTO_ADJUDICADO) AS MONTO_ADJUDICADO, D.ID_PROGRAMA_FORMACION, ")
        strSQL.AppendLine("NVL(SUM((  SELECT NVL(SUM(SQA.MONTO_ADJUDICADO),0) ")
        strSQL.AppendLine("   FROM TERMINO_REFERENCIA_AF SQA, ACCION_FORMATIVA SQB, INFORME_FINAL_AF SQC ")
        strSQL.AppendLine("   WHERE SQA.ID_ACCION_FORMATIVA = SQB.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     AND SQA.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     AND SQA.ID_ACCION_FORMATIVA = SQC.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     AND SQC.ID_ESTADO_INFORME IN('" + Enumeradores.EstadoInformeFinal.EnTramiteDePago.ToString + "','" + Enumeradores.EstadoInformeFinal.Pagado.ToString + "'))),0) AS FACTURADO ")
        strSQL.AppendLine("FROM TERMINO_REFERENCIA_AF TDR, ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D, PROVEEDOR_AF P ")
        strSQL.AppendLine("WHERE TDR.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF ")


        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine("AND TRIM(P.ID_PROVEEDOR_AF) = :ID_PROVEEDOR_AF  ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If RESOLUCION <> "" Then
            strSQL.AppendLine("AND TRIM(TDR.RESOLUCION) = :RESOLUCION  ")
            Dim arg As OracleParameter = New OracleParameter(":RESOLUCION", OracleType.VarChar)
            arg.Value = RESOLUCION.Trim
            args.Add(arg)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            strSQL.AppendLine("AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION  ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            arg.Value = ID_PROGRAMA_FORMACION
            args.Add(arg)
        End If

        strSQL.AppendLine("GROUP BY TDR.RESOLUCION, TDR.TDR, P.NOMBRE_PROVEEDOR, D.ID_PROGRAMA_FORMACION")

        Dim ds As DataSet

        If args.Count > 0 Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If
        Return ds

    End Function

End Class
