Partial Public Class dbACCION_FORMATIVA_HIST
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el histórico de una Accion Formativa tomando como parámetro el Id de la Acción Formativa.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ByRef ID_ACCION_FORMATIVA As Integer, Optional ByVal asColumnaOrden As String = "ACCION_FORMATIVA_HIST.ID_ACCION_FORMATIVA_HIST", Optional ByVal asTipoOrden As String = "DESC") As listaACCION_FORMATIVA_HIST

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        strSQL.Append("SELECT ID_ACCION_FORMATIVA_HIST, ID_ACCION_FORMATIVA, ID_OFERTA_FORMATIVA, ID_SITIO_CAPACITACION, ")
        strSQL.Append("ID_PROVEEDOR_AF, ID_TEMA_CURSO, ID_EJERCICIO, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, NUMERO_PARTICIPANTES, ")
        strSQL.Append("PARTICIPANTES_INSCRITOS, HORARIO, NOTAS, CODIGO_ESTADO_AF, DURACION_HORAS, COSTO_X_PARTICIPANTE, ")
        strSQL.Append("LASTUPDATE, USERID, FECHA_INICIO_REAL, FECHA_FIN_REAL, OBSERVACIONES, ID_ACCION_CONTRATADA, CODI_FORMADOR, NOMBRE_FORMADOR ")
        strSQL.Append("FROM ACCION_FORMATIVA_HIST ")

        If ID_ACCION_FORMATIVA <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter("ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA
            args.Add(arg)
            strSQL.Append("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaACCION_FORMATIVA_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_HIST
                dbAsignarEntidades.AsignarACCION_FORMATIVA_HIST(dr, mEntidad)
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
    ''' Función que devuelve último movimiento histórico de una Accion Formativa tomando como parámetro el Id de la Acción Formativa.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerUltima_ACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ByRef ID_ACCION_FORMATIVA As Integer) As ACCION_FORMATIVA_HIST

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        strSQL.Append("SELECT * FROM ACCION_FORMATIVA_HIST ")
        strSQL.Append("WHERE ROWNUM = 1 AND ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.Append("ORDER BY ID_ACCION_FORMATIVA_HIST DESC")


        Dim arg As OracleParameter
        arg = New OracleParameter("ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New ACCION_FORMATIVA_HIST

        Try
            If dr.Read() Then
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function
End Class
