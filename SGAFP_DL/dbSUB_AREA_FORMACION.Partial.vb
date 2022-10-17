Partial Public Class dbSUB_AREA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto Adjudicado en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoAdjudicadoPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Decimal

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(MONTO_ADJUDICADO,0) ")
        strSQL.AppendLine("FROM CONTRATO_SUB_AREA_FORMACION  ")
        strSQL.AppendLine("WHERE ID_CONTRATO = :ID_CONTRATO AND ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        args(0).Value = ID_CONTRATO

        args(1) = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
        args(1).Value = ID_SUBAREA_FORMACION

        Return CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participación Adjudicada en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionAdjudicadaPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(PARTICIP_ADJUDICADA,0) ")
        strSQL.AppendLine("FROM CONTRATO_SUB_AREA_FORMACION  ")
        strSQL.AppendLine("WHERE ID_CONTRATO = :ID_CONTRATO AND ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        args(0).Value = ID_CONTRATO

        args(1) = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
        args(1).Value = ID_SUBAREA_FORMACION

        Return Convert.ToInt32(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto Ejecutado en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' 	[cramos]	09/02/2012	Modificado, Se agrega parámetro ID_ACCION_FORMATIVA_NO_INCLUIR para no incluir en lo ejecutado una accion formativa
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoEjecutadoPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Decimal
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(SUM(VSOLIC_INGRESADAS_HTP.COSTO_X_PARTICIPANTE),0) AS EJECUTADO ")
        strSQL.AppendLine("FROM OFERTA_FORMATIVA ")
        strSQL.AppendLine("INNER JOIN VSOLIC_INGRESADAS_HTP ")
        strSQL.AppendLine("ON OFERTA_FORMATIVA.ID_OFERTA_FORMATIVA = VSOLIC_INGRESADAS_HTP.ID_OFERTA_FORMATIVA ")
        strSQL.AppendLine("WHERE EXISTS ( ")
        strSQL.Append("                 SELECT 1 FROM ESTADO_ACCION_FORMATIVA E WHERE E.CODIGO_ESTADO_AF NOT IN(")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Ingresada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnMatricula) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Iniciada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion) : strSQL.Append("') AND E.CODIGO_ESTADO_AF = VSOLIC_INGRESADAS_HTP.CODIGO_ESTADO_AF ")
        strSQL.AppendLine("              ) ")
        strSQL.AppendLine("AND VSOLIC_INGRESADAS_HTP.ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION ")
        strSQL.AppendLine("AND OFERTA_FORMATIVA.ID_CONTRATO = :ID_CONTRATO ")

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        arg = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
        arg.Value = ID_SUBAREA_FORMACION
        args.Add(arg)

        If ID_ACCION_FORMATIVA_NO_INCLUIR <> -1 Then
            strSQL.AppendLine("AND VSOLIC_INGRESADAS_HTP.ID_CURSO <> :ID_ACCION_FORMATIVA ")
            arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA_NO_INCLUIR
            args.Add(arg)
        End If

        Return CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Cantidad de Participaciones Ejecutadas en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionEjecutadaPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Integer
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(COUNT(VSOLIC_INGRESADAS_HTP.ID_SOLICITUD),0) AS EJECUTADO ")
        strSQL.AppendLine("FROM OFERTA_FORMATIVA ")
        strSQL.AppendLine("INNER JOIN VSOLIC_INGRESADAS_HTP ")
        strSQL.AppendLine("ON OFERTA_FORMATIVA.ID_OFERTA_FORMATIVA = VSOLIC_INGRESADAS_HTP.ID_OFERTA_FORMATIVA ")
        strSQL.AppendLine("WHERE EXISTS ( ")
        strSQL.Append("                 SELECT 1 FROM ESTADO_ACCION_FORMATIVA E WHERE E.CODIGO_ESTADO_AF NOT IN(")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Ingresada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnMatricula) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.Iniciada) : strSQL.Append("',")
        strSQL.Append("'") : strSQL.Append(Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion) : strSQL.Append("') AND E.CODIGO_ESTADO_AF = VSOLIC_INGRESADAS_HTP.CODIGO_ESTADO_AF ")
        strSQL.AppendLine("              ) ")
        strSQL.AppendLine("AND VSOLIC_INGRESADAS_HTP.ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION ")
        strSQL.AppendLine("AND OFERTA_FORMATIVA.ID_CONTRATO = :ID_CONTRATO ")

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        arg = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
        arg.Value = ID_SUBAREA_FORMACION
        args.Add(arg)

        If ID_ACCION_FORMATIVA_NO_INCLUIR <> -1 Then
            strSQL.AppendLine("AND VSOLIC_INGRESADAS_HTP.ID_CURSO <> :ID_ACCION_FORMATIVA ")
            arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA_NO_INCLUIR
            args.Add(arg)
        End If

        Return Convert.ToInt32(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

    End Function
   
End Class
