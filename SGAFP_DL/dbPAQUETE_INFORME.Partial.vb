Partial Public Class dbPAQUETE_INFORME

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTecnico(ByVal USUARIO_TECNICO As String, Optional ByVal asColumnaOrden As String = "ID_PAQUETE", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME
        Dim listaArg As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PAQUETE_INFORME ")


        If USUARIO_TECNICO <> "" Then
            Dim arg As New OracleParameter("USERID", OracleType.VarChar)
            arg.Value = USUARIO_TECNICO
            listaArg.Add(arg)

            strSQL.Append("WHERE USUARIO_TECNICO = :USERID ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), listaArg.ToArray)

        Dim lista As New listaPAQUETE_INFORME

        Try
            Do While dr.Read()
                Dim mEntidad As New PAQUETE_INFORME
                dbAsignarEntidades.AsignarPAQUETE_INFORME(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PAQUETE As Decimal, ByVal FECHA As Object, ByVal USUARIO_TECNICO As String, Optional ByVal asColumnaOrden As String = "ID_PAQUETE", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME
        Dim listaArg As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM PAQUETE_INFORME ")
        
        If ID_PAQUETE <> -1 Then
            Dim arg As New OracleParameter("ID_PAQUETE", OracleType.Number)
            arg.Value = ID_PAQUETE
            If listaArg.Count = 0 Then strSQL.Append(" WHERE ID_PAQUETE = :ID_PAQUETE ") Else strSQL.Append(" AND ID_PAQUETE = :ID_PAQUETE ")
            listaArg.Add(arg)
        End If

        If FECHA IsNot Nothing Then
            Dim arg As New OracleParameter("FECHA", OracleType.DateTime)
            arg.Value = CDate(FECHA)
            If listaArg.Count = 0 Then strSQL.Append("WHERE FECHA = :FECHA ") Else strSQL.Append("AND FECHA = :FECHA ")
            listaArg.Add(arg)
        End If

        If USUARIO_TECNICO <> "" Then
            Dim arg As New OracleParameter("USERID", OracleType.VarChar)
            arg.Value = USUARIO_TECNICO
            If listaArg.Count = 0 Then strSQL.Append("WHERE USUARIO_TECNICO = :USERID ") Else strSQL.Append("AND USUARIO_TECNICO = :USERID ")
            listaArg.Add(arg)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), listaArg.ToArray)

        Dim lista As New listaPAQUETE_INFORME

        Try
            Do While dr.Read()
                Dim mEntidad As New PAQUETE_INFORME
                dbAsignarEntidades.AsignarPAQUETE_INFORME(dr, mEntidad)
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
