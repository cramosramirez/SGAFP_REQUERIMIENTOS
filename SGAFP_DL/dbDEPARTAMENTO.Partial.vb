Partial Public Class dbDEPARTAMENTO

    Public Function ObtenerListaPorProveedor_Presencia_Sitio(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaDEPARTAMENTO

        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DEPARTAMENTO.CODIGO_REGION, DEPARTAMENTO.CODIGO_DEPARTAMENTO, DEPARTAMENTO.NOMBRE ")
        strSQL.Append("FROM DEPARTAMENTO, SITIO_CAPACITACION ")
        strSQL.Append("WHERE DEPARTAMENTO.CODIGO_DEPARTAMENTO = SITIO_CAPACITACION.CODIGO_DEPARTAMENTO ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.Append("AND SITIO_CAPACITACION.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")

            Dim args(0) As OracleParameter
            args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            args(0).Value = ID_PROVEEDOR_AF

            strSQL.Append("GROUP BY DEPARTAMENTO.CODIGO_REGION, DEPARTAMENTO.CODIGO_DEPARTAMENTO, DEPARTAMENTO.NOMBRE ")
            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            strSQL.Append("GROUP BY DEPARTAMENTO.CODIGO_REGION, DEPARTAMENTO.CODIGO_DEPARTAMENTO, DEPARTAMENTO.NOMBRE ")
            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaDEPARTAMENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New DEPARTAMENTO
                mEntidad.CODIGO_REGION = dr.GetString(0)
                mEntidad.CODIGO_DEPARTAMENTO = dr.GetString(1)

                Me.Recuperar(mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorSitio_Capacitacion(ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", Optional ByVal asTipoOrden As String = "ASC") As listaDEPARTAMENTO

        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT DEPARTAMENTO.CODIGO_REGION, DEPARTAMENTO.CODIGO_DEPARTAMENTO, DEPARTAMENTO.NOMBRE ")
        strSQL.Append("FROM DEPARTAMENTO, SITIO_CAPACITACION ")
        strSQL.Append("WHERE DEPARTAMENTO.CODIGO_DEPARTAMENTO = SITIO_CAPACITACION.CODIGO_DEPARTAMENTO ")

        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.Append("AND SITIO_CAPACITACION.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")

            Dim args(0) As OracleParameter
            args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            args(0).Value = ID_SITIO_CAPACITACION

            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        End If

        Dim lista As New listaDEPARTAMENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New DEPARTAMENTO
                mEntidad.CODIGO_REGION = dr.GetString(0)
                mEntidad.CODIGO_DEPARTAMENTO = dr.GetString(1)

                Me.Recuperar(mEntidad)
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
    ''' Función que Devuelve un DataSet en base a los parámetros pasados
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="FECHA_INICIAL"></param>
    ''' <param name="FECHA_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetProcedenciaPorEjercicioRangoFechas(ByVal ID_EJERCICIO As String, ByVal FECHA_INICIAL As Date, ByVal FECHA_FINAL As Date) As DataSet


        Try
            Dim strSQL As New StringBuilder
            Dim strSQLWHERE As New StringBuilder
            strSQL.Append("SELECT DEPARTAMENTO.NOMBRE AS DEPARTAMENTO, MUNICIPIO.NOMBRE AS MUNICIPIO, ")
            strSQL.Append("COUNT(DISTINCT SOLICITUD_INSCRIPCION_AF.ID_PARTICIPANTE) AS CANTIDAD ")
            strSQL.Append("FROM SOLICITUD_INSCRIPCION_AF, ACCION_FORMATIVA, DEPARTAMENTO, MUNICIPIO, CURSO_TEMA  ")
            strSQL.Append("WHERE ")
            strSQL.Append("EXISTS( SELECT * FROM ESTADO_SOLICITUD WHERE ESTADO_SOLICITUD.ID_ESTADO_SOLICITUD IN(3,4) AND ESTADO_SOLICITUD.ID_ESTADO_SOLICITUD = SOLICITUD_INSCRIPCION_AF.ID_ESTADO_SOLICITUD)  ")
            strSQL.Append("AND ACCION_FORMATIVA.CODIGO_ESTADO_AF NOT IN('01','02','03') ")
            strSQL.Append("AND MUNICIPIO.NOMBRE <> 'DESCONOCIDO-NO UTILIZAR' ")
            strSQL.Append("AND ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
            strSQL.Append("AND ACCION_FORMATIVA.ID_ACCION_FORMATIVA = SOLICITUD_INSCRIPCION_AF.ID_ACCION_FORMATIVA ")
            strSQL.Append("AND MUNICIPIO.CODIGO_DEPARTAMENTO = SOLICITUD_INSCRIPCION_AF.CODIGO_DEPARTAMENTO ")
            strSQL.Append("AND MUNICIPIO.CODIGO_MUNICIPIO = SOLICITUD_INSCRIPCION_AF.CODIGO_MUNICIPIO ")
            strSQL.Append("AND MUNICIPIO.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO ")
            strSQL.Append("AND MUNICIPIO.CODIGO_REGION = DEPARTAMENTO.CODIGO_REGION ")

            Dim args As List(Of OracleParameter) = New List(Of OracleParameter)


            If ID_EJERCICIO <> "" Then
                Dim arg1 As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
                arg1.Value = ID_EJERCICIO
                args.Add(arg1)
                strSQL.Append("AND ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            End If

            If FECHA_INICIAL <> #1/1/1900# AndAlso FECHA_FINAL <> #1/1/1900# Then
                Dim arg1 As OracleParameter = New OracleParameter(":FECHA_INICIAL", OracleType.VarChar)
                arg1.Value = Format(FECHA_INICIAL, "dd/MM/yyyy")
                args.Add(arg1)

                Dim arg2 As OracleParameter = New OracleParameter(":FECHA_FINAL", OracleType.VarChar)
                arg2.Value = Format(FECHA_FINAL, "dd/MM/yyyy")
                args.Add(arg2)

                strSQL.Append("AND ACCION_FORMATIVA.FECHA_FIN_REAL BETWEEN TO_DATE(:FECHA_INICIAL,'dd/mm/yyyy') AND TO_DATE(:FECHA_FINAL,'dd/mm/yyyy') ")
            End If

            strSQL.Append("GROUP BY DEPARTAMENTO.NOMBRE, MUNICIPIO.NOMBRE ")

            Dim ds As DataSet

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

            Return ds

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el Programa PATI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATI() As listaDEPARTAMENTO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DEPARTAMENTO))
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO ) ")
        strSQL.AppendLine("ORDER BY DEPARTAMENTO.NOMBRE ")

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaDEPARTAMENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New DEPARTAMENTO
                dbAsignarEntidades.AsignarDEPARTAMENTO(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el Programa PATI 
    ''' y filtrado por la Fuente de Financiamiento
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorFuente(ByVal ID_FUENTE As Decimal) As listaDEPARTAMENTO
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DEPARTAMENTO))
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO ")

        If ID_FUENTE <> -1 Then
            Dim arg1 As OracleParameter = New OracleParameter(":ID_FUENTE", OracleType.VarChar)
            arg1.Value = ID_FUENTE
            args.Add(arg1)
            strSQL.AppendLine("AND FM.ID_FUENTE = :ID_FUENTE) ")
        Else
            strSQL.AppendLine(") ")
        End If
        strSQL.AppendLine("ORDER BY DEPARTAMENTO.NOMBRE ")

        Dim dr As OracleDataReader
        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaDEPARTAMENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New DEPARTAMENTO
                dbAsignarEntidades.AsignarDEPARTAMENTO(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el 
    ''' Programa PATI y filtrada por el Tecnico asignado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATITecnico(ByVal USUARIO_TECNICO As String) As listaDEPARTAMENTO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DEPARTAMENTO))
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("              WHERE FM.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO )")
        strSQL.AppendLine("  AND EXISTS (SELECT 1 FROM TECNICOS_MUNICIPIOS_PATI_ASIG TMPA")
        strSQL.AppendLine("              WHERE TMPA.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("              AND TMPA.USUARIO = :USUARIO)")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = USUARIO_TECNICO

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDEPARTAMENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New DEPARTAMENTO
                dbAsignarEntidades.AsignarDEPARTAMENTO(dr, mEntidad)
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
    ''' Función que Devuelve una Entidad filtrada por los parámetros 
    ''' <param name="NOMBRE_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDEPARTAMENTOPorNOMBRE(ByVal NOMBRE_DEPARTAMENTO As String) As DEPARTAMENTO

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim op As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM DEPARTAMENTO ")
        strSQL.Append("WHERE NOMBRE = :NOMBRE_DEPARTAMENTO")

        op = New OracleParameter(":NOMBRE_DEPARTAMENTO", OracleType.VarChar)
        op.Value = NOMBRE_DEPARTAMENTO
        args.Add(op)

        Dim dr As IDataReader
        Dim aEntidad As DEPARTAMENTO

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex

        End Try

        Return aEntidad

    End Function
End Class
