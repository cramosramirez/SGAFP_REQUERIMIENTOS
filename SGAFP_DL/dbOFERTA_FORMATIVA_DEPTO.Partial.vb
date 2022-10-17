Partial Public Class dbOFERTA_FORMATIVA_DEPTO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participacion y el Monto Adjudicado por Oferta Formativa y Departamento
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionMontoAdjudicadoPorOfertaDepartamento(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal CODIGO_DEPARTAMENTO As String) As Dictionary(Of String, Decimal)
        Dim dr As OracleDataReader
        Dim dicResultado As New Dictionary(Of String, Decimal)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(PARTI_ADJUDICADA,0) AS PARTICIPACION, NVL(MONTO_ADJUDICADO,0) AS MONTO ")
        strSQL.AppendLine("FROM OFERTA_FORMATIVA_DEPTO ")
        strSQL.AppendLine("WHERE ID_OFERTA_FORMATIVA = :ID_OFERTA_FORMATIVA AND CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_OFERTA_FORMATIVA", OracleType.Number)
        args(0).Value = ID_OFERTA_FORMATIVA

        args(1) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(1).Value = CODIGO_DEPARTAMENTO
        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args)

        Try
            If dr.Read Then
                dicResultado.Add("PARTICIPACION", CDec(dr(0)))
                dicResultado.Add("MONTO", CDec(dr(1)))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dicResultado
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participacion y el Monto Ejecutado por Oferta Formativa y Departamento  
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	04/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionMontoEjecutadoPorOfertaDepartamento(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Dictionary(Of String, Decimal)
        Dim dr As OracleDataReader
        Dim dicResultado As New Dictionary(Of String, Decimal)
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(COUNT(PAF.ID_PARTICIPANTE),0) AS PARTICIPACION, NVL(SUM(AF.COSTO_X_PARTICIPANTE),0) AS MONTO ")
        strSQL.AppendLine("FROM PARTICIPANTE_AF PAF, ACCION_FORMATIVA AF, SITIO_CAPACITACION SC ")
        strSQL.AppendLine("WHERE PAF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_SITIO_CAPACITACION = SC.ID_SITIO_CAPACITACION ")
        strSQL.AppendLine("AND AF.ID_OFERTA_FORMATIVA = :ID_OFERTA_FORMATIVA  ")
        strSQL.AppendLine("AND SC.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("AND PAF.PORC_ASISTENCIA >= (SELECT P.PORC_ASISTENCIA_MINIMA FROM PROGRAMA_FORMACION P WHERE P.ID_PROGRAMA_FORMACION = 1) ")
        strSQL.AppendLine("AND PAF.ESTADO IN(")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoParticipanteEnCurso.Inscrito) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoParticipanteEnCurso.Evaluado) : strSQL.Append("') ")
        strSQL.AppendLine("AND EXISTS( ")
        strSQL.Append("                 SELECT 1 FROM ESTADO_ACCION_FORMATIVA E WHERE E.CODIGO_ESTADO_AF NOT IN(")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Ingresada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnMatricula) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Iniciada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion) : strSQL.Append("') AND E.CODIGO_ESTADO_AF = AF.CODIGO_ESTADO_AF ")
        strSQL.AppendLine(") ")

        arg = New OracleParameter(":ID_OFERTA_FORMATIVA", OracleType.Number)
        arg.Value = ID_OFERTA_FORMATIVA
        args.Add(arg)

        arg = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        arg.Value = CODIGO_DEPARTAMENTO
        args.Add(arg)

        If ID_ACCION_FORMATIVA_NO_INCLUIR <> -1 Then
            strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA <> :ID_ACCION_FORMATIVA ")
            arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA_NO_INCLUIR
            args.Add(arg)
        End If
        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Try
            If dr.Read Then
                dicResultado.Add("PARTICIPACION", CDec(dr(0)))
                dicResultado.Add("MONTO", CDec(dr(1)))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dicResultado

    End Function

End Class
