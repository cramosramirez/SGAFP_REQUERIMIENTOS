Partial Public Class dbDESEMBOLSO_MUNI_LIQUI_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDESEMBOLSO_LIQUIDACION_DET(ByVal ID_DESEMBOLSO As Decimal, ByVal ID_LIQUIDACION_DET As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaDESEMBOLSO_MUNI_LIQUI_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        strSQL.Append(" WHERE ID_DESEMBOLSO = :ID_DESEMBOLSO AND ID_LIQUIDACION_DET = :ID_LIQUIDACION_DET")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_DESEMBOLSO", OracleType.Number)
        args(0).Value = ID_DESEMBOLSO

        args(1) = New OracleParameter(":ID_LIQUIDACION_DET", OracleType.Number)
        args(1).Value = ID_LIQUIDACION_DET

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESEMBOLSO_MUNI_LIQUI_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, mEntidad)
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
