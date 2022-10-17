Partial Public Class dbPROGRAMA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una cadena que representa los programas a los que se tiene acceso por una Lista de Roles
    ''' </summary>
    ''' <param name="listaRoles"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorROLES(ByVal listaRoles As List(Of String)) As listaPROGRAMA_FORMACION
        Dim strSQL As New StringBuilder
        Dim strRoles As New StringBuilder
        Dim lista As New listaPROGRAMA_FORMACION

        strSQL.Append(Me.QuerySelect(New PROGRAMA_FORMACION))

        If listaRoles IsNot Nothing AndAlso listaRoles.Count > 0 Then
            For i As Integer = 0 To listaRoles.Count - 1
                If i = 0 Then
                    strRoles.Append("'") : strRoles.Append(listaRoles(i).ToString) : strRoles.Append("'")
                Else
                    strRoles.Append(",") : strRoles.Append("'") : strRoles.Append(listaRoles(i).ToString) : strRoles.Append("'")
                End If
            Next
            strSQL.Append("WHERE EXISTS(SELECT 1 FROM ROL_PROGRAMA R WHERE R.ROL_USUARIO IN(")
            strSQL.Append(strRoles.ToString)
            strSQL.Append(") ")
            strSQL.Append("AND R.ID_PROGRAMA_FORMACION = PROGRAMA_FORMACION.ID_PROGRAMA_FORMACION) ")
            strSQL.Append("ORDER BY PROGRAMA_FORMACION.NOMBRE_PROGRAMA_FORMACION")
        Else
            Return lista
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Try
            Do While dr.Read()
                Dim mEntidad As New PROGRAMA_FORMACION
                dbAsignarEntidades.AsignarPROGRAMA_FORMACION(dr, mEntidad)
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
