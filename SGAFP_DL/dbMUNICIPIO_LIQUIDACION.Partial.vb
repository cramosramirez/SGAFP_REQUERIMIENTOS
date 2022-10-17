Partial Public Class dbMUNICIPIO_LIQUIDACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_LIQUIDACION
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New MUNICIPIO_LIQUIDACION))
        strSQL.AppendLine(" WHERE MUNICIPIO_LIQUIDACION.NO_CONVOCATORIA = :NO_CONVOCATORIA")
        strSQL.AppendLine(" AND EXISTS(SELECT 1 FROM FASE_MUNICIPIOS FM")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = MUNICIPIO_LIQUIDACION.CODIGO_DEPARTAMENTO")
        strSQL.AppendLine("              AND FM.CODIGO_MUNICIPIO = MUNICIPIO_LIQUIDACION.CODIGO_MUNICIPIO")
        strSQL.AppendLine("              AND FM.ID_FUENTE = :ID_FUENTE)")

        arg = New OracleParameter("ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter("NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaMUNICIPIO_LIQUIDACION

        Try
            Do While dr.Read()
                Dim mEntidad As New MUNICIPIO_LIQUIDACION
                dbAsignarEntidades.AsignarMUNICIPIO_LIQUIDACION(dr, mEntidad)
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
