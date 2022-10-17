Imports System.Text
Imports System.Reflection

Partial Class dbACCION_FORMATIVA_REPROG
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created  
    ''' 	[ecarias]	12/05/2011	Se agrego parametro de busqueda por TDR
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosPeriodo(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal TDR As String, _
                                                    Optional ByVal ID_ESTADO_REPROG As Decimal = -1, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_ESTADO_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.MOTIVOREPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.MOTIVORECHAZO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_SOLIC_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOMBRE_FORMADOR ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA_REPROG ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA_REPROG.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.TecnicoGFIPATI) Then
            strSQL.AppendLine(" LEFT OUTER JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        Else
            strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        End If

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.ID_EJERCICIO) = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If
        If ID_ESTADO_REPROG <> -1 Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.ID_ESTADO_REPROG) = :ID_ESTADO_REPROG ")
            Dim op As OracleParameter = New OracleParameter(":ID_ESTADO_REPROG", OracleType.Number)
            op.Value = ID_ESTADO_REPROG
            args.Add(op)
        End If

        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM TERMINO_REFERENCIA_AF T WHERE T.ID_ACCION_FORMATIVA = ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA AND RTRIM(T.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.NVarChar)
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

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' Función que permite obtener por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/06/2010	Created  
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Function ObtenerACCION_FORMATIVA_REPROG_POR_ESTADO(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_REPROG As Integer) As ACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND ID_ESTADO_REPROG = :ID_ESTADO_REPROG ")
        strSQL.Append(" ORDER BY ID_ACCION_FORMATIVA_REPROG DESC")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":ID_ESTADO_REPROG", OracleType.Number)
        args(1).Value = ID_ESTADO_REPROG

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim mEntidad As New ACCION_FORMATIVA_REPROG

        Try
            If dr.HasRows Then
                dr.Read()
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/01/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal ID_ESTADO_REPROG As Decimal, _
                                                    ByVal listaID_PROGRAMA_FORMACION As List(Of Decimal), _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM AREA_FORMACION A, CURSO_TEMA C WHERE A.ID_AREA_FORMACION = C.ID_AREA_FORMACION AND C.ID_TEMA_CURSO = ACCION_FORMATIVA_REPROG.ID_TEMA_CURSO AND A.ID_AREA_FORMACION = :ID_AREA_FORMACION) ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA_REPROG.CODIGO_GRUPO) = :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = CODIGO_GRUPO.ToUpper
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If
        If ID_ESTADO_REPROG <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA_REPROG.ID_ESTADO_REPROG = :ID_ESTADO_REPROG ")
            Dim op As OracleParameter = New OracleParameter(":ID_ESTADO_REPROG", OracleType.Number)
            op.Value = ID_ESTADO_REPROG
            args.Add(op)
        End If
        If listaID_PROGRAMA_FORMACION IsNot Nothing AndAlso listaID_PROGRAMA_FORMACION.Count > 0 Then
            Dim strIN As New StringBuilder
            If listaID_PROGRAMA_FORMACION.Count = 1 Then
                strIN.Append(" EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION)  ")
                Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
                op.Value = listaID_PROGRAMA_FORMACION(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaID_PROGRAMA_FORMACION.Count - 1
                    If i = 0 Then
                        strIN.Append(" EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA AND D.ID_PROGRAMA_FORMACION IN(") : strIN.Append(listaID_PROGRAMA_FORMACION(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaID_PROGRAMA_FORMACION(i).ToString)
                    End If
                Next
                strIN.Append(")) ")
            End If
            AgregarCondicion(strSQLCondicion, strIN.ToString)
        End If

        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM TERMINO_REFERENCIA_AF T WHERE T.ID_ACCION_FORMATIVA = ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA AND RTRIM(T.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.NVarChar)
            op.Value = TDR
            args.Add(op)
        End If


        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
