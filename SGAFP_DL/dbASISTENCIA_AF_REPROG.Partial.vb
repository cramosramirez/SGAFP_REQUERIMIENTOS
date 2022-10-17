Partial Public Class dbASISTENCIA_AF_REPROG
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve un registro de la Asistencia por los parámetros enviados
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerASISTENCIA_AF_REPROG_PorIdAccionFormativaReprog_Fecha(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal FECHA As Date) As ASISTENCIA_AF_REPROG
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT * FROM ASISTENCIA_AF_REPROG WHERE ID_ACCION_FORMATIVA_REPROG = :ID_ACCION_FORMATIVA_REPROG AND FECHA = :FECHA")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA_REPROG", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA_REPROG
        args(1) = New OracleParameter(":FECHA", OracleType.DateTime)
        args(1).Value = FECHA

        Dim dr As IDataReader
        Dim aEntidad As entidadBase

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing
        Dim mEntidad As New ASISTENCIA_AF_REPROG

        Try
            If dr.Read() Then
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad
    End Function
End Class
