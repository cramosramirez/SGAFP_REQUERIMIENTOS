Partial Public Class dbNIVEL_ACADEMICO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve los registros a partir del ID_NIVEL_ACADEMICO mayor o igual a 8.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaActualizada(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaNIVEL_ACADEMICO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New NIVEL_ACADEMICO))
        strSQL.Append(" WHERE NIVEL_ACADEMICO.ID_NIVEL_ACADEMICO >= 8 ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaNIVEL_ACADEMICO

        Try
            Do While dr.Read()
                Dim mEntidad As New NIVEL_ACADEMICO
                dbAsignarEntidades.AsignarNIVEL_ACADEMICO(dr, mEntidad)
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
