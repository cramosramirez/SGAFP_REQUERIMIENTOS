Imports SGAFP.DL.DS_DL

Partial Public Class dbDESEMBOLSO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	03/05/2012	Creado
    ''' 	[cramos]	09/05/2012	Se setean propiedades adicionales de la entidad: MONTO_APLICADO y MONTO_DIFERENCIA
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaDESEMBOLSO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO))
        strSQL.Append(" WHERE ID_FUENTE = :ID_FUENTE AND NO_CONVOCATORIA = :NO_CONVOCATORIA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_FUENTE", OracleType.Number)
        args(0).Value = ID_FUENTE

        args(1) = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        args(1).Value = NO_CONVOCATORIA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESEMBOLSO

        Try
            Do While dr.Read()
                Dim mEntidad As New DESEMBOLSO
                dbAsignarEntidades.AsignarDESEMBOLSO(dr, mEntidad)
                AsignarMontoAplicado(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Private Sub AsignarMontoAplicado(ByRef e As DESEMBOLSO)
        Dim dDesembolsoMuni As New dbDESEMBOLSO_MUNI_LIQUI_DET
        Dim listaDesembolsoMuni As listaDESEMBOLSO_MUNI_LIQUI_DET
        Dim totalAplicado As Decimal = 0
        listaDesembolsoMuni = dDesembolsoMuni.ObtenerListaPorDESEMBOLSO(e.ID_DESEMBOLSO)
        If listaDesembolsoMuni IsNot Nothing Then
            For i As Integer = 0 To listaDesembolsoMuni.Count - 1
                totalAplicado += listaDesembolsoMuni(i).MONTO_DESEMBOLSO
            Next
        End If

        e.MONTO_APLICADO = totalAplicado
        e.MONTO_DIFERENCIA = e.MONTO_AUTORIZADO - totalAplicado
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataTable filtrada por los parámetros de
    ''' que se pasan como criterios
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataTableCursosPendientesDesembolso(ByVal ID_FUENTE As Decimal, _
                                                                            ByVal NO_CONVOCATORIA As Decimal, _
                                                                            ByVal NUM_DESEMBOLSO As Decimal, _
                                                                            ByVal FECHA_INICIAL As Date, _
                                                                            ByVal FECHA_FINAL As Date, _
                                                                            ByVal lMunicipios As listaMUNICIPIO) As AplicacionDesembolsoPATIDataTable

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(" SELECT *")
        strSQL.AppendLine(" FROM( ")
        strSQL.AppendLine(" SELECT AF.ID_ACCION_FORMATIVA, MD.ID_LIQUIDACION_DET, FM.ID_FUENTE, ML.NO_CONVOCATORIA,")
        strSQL.AppendLine(" M.NOMBRE AS NOMBRE_MUNICIPIO, ML.NO_LIQUIDACION, ML.FECHA_ELABORACION, AF.NOMBRE_ACCION_FORMATIVA, P.NOMBRE_PROVEEDOR, ")
        strSQL.AppendLine(" (SELECT TRIM(FE.NUMERO_DOCUMENTO) AS NUMERO_DOCUMENTO FROM FACTURA_AF FE, FACTURA_DET FD ")
        strSQL.AppendLine("  WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF")
        strSQL.AppendLine("  AND FD.ID_ACCION_FORMATIVA = MD.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND FE.ESTADO = 'P') AS NUMERO_DOCUMENTO,")
        strSQL.AppendLine("  MD.TOTAL_PAGAR AS SOLICITADO,")
        strSQL.AppendLine(" (  SELECT NVL(SUM(D2.MONTO_DESEMBOLSO),0) ")
        strSQL.AppendLine("    FROM DESEMBOLSO_MUNI_LIQUI_DET D2, DESEMBOLSO D1 ")
        strSQL.AppendLine("    WHERE D2.ID_DESEMBOLSO = D1.ID_DESEMBOLSO ")
        strSQL.AppendLine("    AND D2.ID_LIQUIDACION_DET = MD.ID_LIQUIDACION_DET")
        strSQL.AppendLine("    AND D1.NUM_DESEMBOLSO <> :NUM_DESEMBOLSO) AS DESEMBOLSO_ANTERIOR,     ")
        strSQL.AppendLine("    0 AS ESTE_DESEMBOLSO ")
        strSQL.AppendLine(" FROM  MUNICIPIO_LIQUIDACION ML, MUNICIPIO_LIQUIDACION_DET MD, FASE_MUNICIPIOS FM, MUNICIPIO M, ACCION_FORMATIVA AF, PROVEEDOR_AF P")
        strSQL.AppendLine(" WHERE ML.ID_LIQUIDACION = MD.ID_LIQUIDACION")
        strSQL.AppendLine(" AND FM.CODIGO_DEPARTAMENTO = ML.CODIGO_DEPARTAMENTO")
        strSQL.AppendLine(" AND FM.CODIGO_MUNICIPIO = ML.CODIGO_MUNICIPIO")
        strSQL.AppendLine(" AND FM.ID_FUENTE = :ID_FUENTE ")
        strSQL.AppendLine(" AND ML.NO_CONVOCATORIA = :NO_CONVOCATORIA")
        strSQL.AppendLine(" AND FM.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO")
        strSQL.AppendLine(" AND FM.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO")
        strSQL.AppendLine(" AND AF.ID_ACCION_FORMATIVA = MD.ID_ACCION_FORMATIVA")
        strSQL.AppendLine(" AND AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF")
        strSQL.AppendLine(" AND (ML.FECHA_ELABORACION = :FECHA_INICIAL OR ML.FECHA_ELABORACION = :FECHA_FINAL)")
        If lMunicipios.Count > 0 Then
            strSQL.AppendLine(" AND (")
            For i As Integer = 0 To lMunicipios.Count - 1
                If i > 0 Then
                    strSQL.AppendLine(" OR ")
                End If
                strSQL.Append("(ML.CODIGO_DEPARTAMENTO = '")
                strSQL.Append(lMunicipios(i).CODIGO_DEPARTAMENTO)
                strSQL.Append("' ")
                strSQL.Append("AND ML.CODIGO_MUNICIPIO = '")
                strSQL.Append(lMunicipios(i).CODIGO_MUNICIPIO)
                strSQL.AppendLine("')")
            Next
            strSQL.AppendLine(")")
        End If
        strSQL.AppendLine(" )")
        strSQL.AppendLine(" WHERE SOLICITADO <> DESEMBOLSO_ANTERIOR ")
        strSQL.AppendLine(" ORDER BY NOMBRE_MUNICIPIO, NO_LIQUIDACION")

        Dim args(4) As OracleParameter
        args(0) = New OracleParameter(":ID_FUENTE", OracleType.Number)
        args(0).Value = ID_FUENTE
        args(1) = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        args(1).Value = NO_CONVOCATORIA
        args(2) = New OracleParameter(":NUM_DESEMBOLSO", OracleType.Number)
        args(2).Value = NUM_DESEMBOLSO
        args(3) = New OracleParameter(":FECHA_INICIAL", OracleType.DateTime)
        args(3).Value = FECHA_INICIAL
        args(4) = New OracleParameter(":FECHA_FINAL", OracleType.DateTime)
        args(4).Value = FECHA_FINAL

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim dt As New AplicacionDesembolsoPATIDataTable

        Try
            Do While dr.Read()
                Dim fila As AplicacionDesembolsoPATIRow
                fila = dt.NewAplicacionDesembolsoPATIRow

                With fila
                    .ID_ACCION_FORMATIVA = CDec(dr("ID_ACCION_FORMATIVA"))
                    .ID_LIQUIDACION_DET = CDec(dr("ID_LIQUIDACION_DET"))
                    .ID_FUENTE = CDec(dr("ID_FUENTE"))
                    .NO_CONVOCATORIA = CDec(dr("NO_CONVOCATORIA"))
                    .NOMBRE_MUNICIPIO = dr("NOMBRE_MUNICIPIO").ToString
                    .NO_LIQUIDACION = CDec(dr("NO_LIQUIDACION"))
                    .FECHA_ELABORACION = CDate(dr("FECHA_ELABORACION"))
                    .NOMBRE_ACCION_FORMATIVA = dr("NOMBRE_ACCION_FORMATIVA").ToString
                    .NOMBRE_PROVEEDOR = dr("NOMBRE_PROVEEDOR").ToString
                    .NUMERO_DOCUMENTO = dr("NUMERO_DOCUMENTO").ToString
                    .SOLICITADO = CDec(dr("SOLICITADO"))
                    .DESEMBOLSO_ANTERIOR = CDec(dr("DESEMBOLSO_ANTERIOR"))
                    .ESTE_DESEMBOLSO = CDec(dr("ESTE_DESEMBOLSO"))
                End With
                dt.AddAplicacionDesembolsoPATIRow(fila)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dt
    End Function
End Class
