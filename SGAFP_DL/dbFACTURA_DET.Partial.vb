Partial Public Class dbFACTURA_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' Convocatoria, Departamento y Municipio .
    ''' </summary>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorFACTURA_AF_ParaLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As listaFACTURA_DET
        Dim lista As New listaFACTURA_DET
        Dim ds As DataSet
        ds = ObtenerDataSetPorFACTURA_AF_ParaLiquidacion(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)

        Try
            For Each fila As DataRow In ds.Tables(0).Rows
                Dim mEntidad As New FACTURA_DET
                mEntidad.ID_FACTURA_DET = Convert.ToDecimal(fila("ID_FACTURA_DET"))
                Dim lRet As Integer = Me.Recuperar(mEntidad)
                If lRet > 0 Then
                    lista.Add(mEntidad)
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try

        Return lista
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrada por los parámetros de
    ''' Fuente, Convocatoria, Departamento y Municipio .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/12/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorFACTURA_AF_ParaLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.AppendLine("SELECT ")
        strSQL.AppendLine("FD.ID_FACTURA_DET, ")
        strSQL.AppendLine("M.NOMBRE AS NOMBRE_MUNICIPIO, ")
        strSQL.AppendLine("P.NOMBRE_PROVEEDOR, ")
        strSQL.AppendLine("AF.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine("AF.CODIGO_GRUPO, ")
        strSQL.AppendLine("FE.NUMERO_DOCUMENTO, ")
        strSQL.AppendLine("FE.NUMERO_QUEDAN, ")
        strSQL.AppendLine("FE.NUMERO_CHEQUE, ")
        strSQL.AppendLine("INF.PARTICIPANTES_FINALES, ")
        strSQL.AppendLine("AF.DURACION_HORAS, ")
        strSQL.AppendLine("CASE  ")
        strSQL.AppendLine("  WHEN V.ID_FUENTE = 1 OR V.ID_FUENTE = 3 THEN INF.PARTICIPANTES_FINALES * (SELECT FTE.COSTO_X_PARTICIPANTE FROM FUENTE_FINANCIAMIENTO FTE WHERE FTE.ID_FUENTE = V.ID_FUENTE) ")
        strSQL.AppendLine("  WHEN V.ID_FUENTE = 2 THEN AF.DURACION_HORAS * (SELECT FTE.COSTO_X_PARTICIPANTE FROM FUENTE_FINANCIAMIENTO FTE WHERE FTE.ID_FUENTE = V.ID_FUENTE) ")
        strSQL.AppendLine("  ELSE 0 ")
        strSQL.AppendLine("END TOTAL, ")
        strSQL.AppendLine("AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("FROM FACTURA_AF FE, FACTURA_DET FD, ACCION_FORMATIVA_DETALLE V, ACCION_FORMATIVA AF, PROVEEDOR_AF P, INFORME_FINAL_AF INF, MUNICIPIO M ")
        strSQL.AppendLine("WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF ")
        strSQL.AppendLine("AND FE.ESTADO = 'P' ")
        strSQL.AppendLine("AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
        strSQL.AppendLine("AND FE.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = V.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND M.CODIGO_DEPARTAMENTO = V.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("AND M.CODIGO_MUNICIPIO = V.CODIGO_MUNICIPIO ")
        strSQL.AppendLine(" AND NOT FE.NUMERO_QUEDAN IS NULL ")
        strSQL.AppendLine(" AND NOT EXISTS( SELECT 1 FROM MUNICIPIO_LIQUIDACION_DET ML WHERE ML.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA) ")

        If ID_FUENTE <> -1 Then
            arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
            arg.Value = ID_FUENTE
            args.Add(arg)
            strSQL.Append(" AND V.ID_FUENTE = :ID_FUENTE ")
        End If
        If NO_CONVOCATORIA <> -1 Then
            arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
            arg.Value = NO_CONVOCATORIA
            args.Add(arg)
            strSQL.Append(" AND V.NO_CONVOCATORIA = :NO_CONVOCATORIA ")
        End If
        If CODIGO_DEPARTAMENTO <> "" Then
            arg = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
            strSQL.Append(" AND V.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        End If
        If CODIGO_MUNICIPIO <> "" Then
            arg = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            arg.Value = CODIGO_MUNICIPIO
            args.Add(arg)
            strSQL.Append(" AND V.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ")
        End If
        strSQL.Append(" ORDER BY M.NOMBRE, P.NOMBRE_PROVEEDOR, AF.NOMBRE_ACCION_FORMATIVA, AF.ID_ACCION_FORMATIVA")

        Dim ds As DataSet
        If args.Count = 0 Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        End If

        Return ds
    End Function

End Class
