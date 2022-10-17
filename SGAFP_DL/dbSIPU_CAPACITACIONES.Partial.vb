Partial Public Class dbSIPU_CAPACITACIONES

    Private Function SQL_SIPU_CAPACITACIONES(Optional ID_GENERACION As Decimal = -1) As String

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT AF.ID_ACCION_FORMATIVA AS IDCAPACITACION, AF.NOMBRE_ACCION_FORMATIVA AS DESCRIPCION, ")
        strSQL.AppendLine("NULL AS IDTIPOCAPACITACION, NULL AS IDESTADO, ")
        strSQL.AppendLine("AF.FECHA_INICIO_REAL AS FECHAINICIO, AF.FECHA_FIN_REAL AS FECHAFIN, ")
        strSQL.AppendLine("( SELECT SM.IDMUNICIPIO ")
        strSQL.AppendLine("  FROM SIPU_MUNICIPIO SM ")
        strSQL.AppendLine("  WHERE SM.CODIGO_DEPTO_INSAFORP = AD.CODIGO_DEPARTAMENTO AND SM.CODIGO_MUNI_INSAFORP = AD.CODIGO_MUNICIPIO) AS IDMUNICIPIO ")
        If ID_GENERACION > -1 Then
            strSQL.AppendLine(" ," + ID_GENERACION.ToString + " AS ID_GENERACION ")
        End If
        strSQL.AppendLine("FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE AD, INFORME_FINAL_AF INF ")
        strSQL.AppendLine("WHERE AF.ID_ACCION_FORMATIVA = AD.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AD.ID_FUENTE = :ID_FUENTE ")
        strSQL.AppendLine("AND AD.NO_CONVOCATORIA = :NO_CONVOCATORIA ")
        strSQL.AppendLine("AND INF.PARTICIPANTES_FINALES > 0 ")
        Return strSQL.ToString
    End Function

    
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetSIPU_CAPACITACIONES(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, Me.SQL_SIPU_CAPACITACIONES(), args.ToArray)
        Return ds
    End Function

    Public Function AgregarLotePorFuenteConvocatoria(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal ID_GENERACION As Decimal) As Integer
        Dim strSQL As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        strSQL.AppendLine("INSERT INTO SIPU_CAPACITACIONES ")
        strSQL.AppendLine(Me.SQL_SIPU_CAPACITACIONES(ID_GENERACION))

        arg = New OracleParameter(":ID_FUENTE", OracleType.Number)
        arg.Value = ID_FUENTE
        args.Add(arg)

        arg = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
        arg.Value = NO_CONVOCATORIA
        args.Add(arg)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)
    End Function

End Class
