Partial Public Class dbSOLICITUD_CAPACITACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/02/2013	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_REFERENTE As Decimal, ByVal ID_PROYECTO_FORMACION As Decimal, _
                                             ByVal FECHA_SOLICITUD As System.Nullable(Of Date), ByVal TDR As String, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT * ")
        strSQL.AppendLine(" FROM SOLICITUD_CAPACITACION ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_REFERENTE <> -1 Then
            AgregarCondicion(strSQLCondicion, " SOLICITUD_CAPACITACION.ID_REFERENTE = :ID_REFERENTE ")
            Dim op As OracleParameter = New OracleParameter(":ID_REFERENTE", OracleType.Number)
            op.Value = ID_REFERENTE
            args.Add(op)
        End If
        If ID_PROYECTO_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " SOLICITUD_CAPACITACION.ID_PROYECTO_FORMACION = :ID_PROYECTO_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROYECTO_FORMACION", OracleType.Number)
            op.Value = ID_PROYECTO_FORMACION
            args.Add(op)
        End If
        If FECHA_SOLICITUD IsNot Nothing Then
            AgregarCondicion(strSQLCondicion, " SOLICITUD_CAPACITACION.FECHA_SOLICITUD = :FECHA_SOLICITUD ")
            Dim op As OracleParameter = New OracleParameter(":FECHA_SOLICITUD", OracleType.DateTime)
            op.Value = FECHA_SOLICITUD
            args.Add(op)
        End If
        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM GRUPO_SOLICITUD G WHERE G.ID_SOLICITUD = SOLICITUD_CAPACITACION.ID_SOLICITUD AND RTRIM(G.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.VarChar)
            op.Value = TDR
            args.Add(op)
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/02/2013	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As SOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT SC.* FROM SOLICITUD_CAPACITACION SC ")
        strSQL.AppendLine(" WHERE (SELECT COUNT(1) FROM GRUPO_SOLICITUD GS, GRUPO_ACCION_CONTRATADA GC WHERE GS.ID_SOLICITUD = SC.ID_SOLICITUD AND GS.ID_GRUPO_SOLICITUD = GC.ID_GRUPO_AF AND GC.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA) > 0 ")
        strSQL.AppendLine(" OR ")
        strSQL.AppendLine(" (SELECT COUNT(1) FROM TERMINO_REFERENCIA_AF TDR, GRUPO_SOLICITUD GS WHERE TDR.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND GS.ID_SOLICITUD = SC.ID_SOLICITUD AND GS.TDR = TDR.TDR AND TDR.CORRELATIVO_GRUPO = GS.CORRELATIVO_GRUPO ) > 0 ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        Dim op As OracleParameter = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        op.Value = ID_ACCION_FORMATIVA
        args.Add(op)
        
        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim mEntidad As New SOLICITUD_CAPACITACION

        Try
            If dr.Read() Then
                AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
            Else
                mEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function
End Class
