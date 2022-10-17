Partial Class dbAREA_FORMACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor y Ejercicio,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor y Ejercicio enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedorEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM AREA_FORMACION ")
        strSQL.AppendLine("WHERE (SELECT COUNT(1) FROM CURSO_TEMA CT, OFERTA_FORMATIVA OFE WHERE CT.ID_TEMA_CURSO = OFE.ID_TEMA_CURSO AND CT.ID_AREA_FORMACION = AREA_FORMACION.ID_AREA_FORMACION ")

        If ID_PROVEEDOR_AF <> -1 OrElse ID_EJERCICIO <> "" Then
            If ID_PROVEEDOR_AF <> -1 Then
                strSQL.AppendLine(" AND OFE.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
                Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
                op.Value = ID_PROVEEDOR_AF
                args.Add(op)
            End If
            If ID_EJERCICIO <> "" Then
                strSQL.AppendLine(" AND OFE.ID_EJERCICIO = :ID_EJERCICIO ")
                Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
                op.Value = ID_EJERCICIO
                args.Add(op)
            End If
        End If
        strSQL.AppendLine(") > 0")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If
       
        Dim lista As New listaAREA_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New AREA_FORMACION
                dbAsignarEntidades.AsignarAREA_FORMACION(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor, Sitio de Capacitación y Ejercicio,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor, Sitio de Capacitación y Ejercicio enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	20/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedorSitioEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New AREA_FORMACION))
        strSQL.AppendLine(" WHERE EXISTS ( ")
        strSQL.AppendLine(" SELECT 1 FROM CURSO_TEMA CT, OFERTA_FORMATIVA OFE, OFERTA_FORMATIVA_SITIO OFES ")
        strSQL.AppendLine(" WHERE CT.ID_TEMA_CURSO = OFE.ID_TEMA_CURSO ")
        strSQL.AppendLine(" AND CT.ID_AREA_FORMACION = AREA_FORMACION.ID_AREA_FORMACION ")
        strSQL.AppendLine(" AND OFE.ID_OFERTA_FORMATIVA = OFES.ID_OFERTA_FORMATIVA ")
        strSQL.AppendLine(" AND OFE.ESTADO = 'A' ")

        Dim args As New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine(" AND OFES.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim arg As New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.AppendLine(" AND OFES.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim arg As New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If
        If ID_EJERCICIO <> "" Then
            strSQL.AppendLine(" AND OFES.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim arg As New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
        End If
        
        strSQL.AppendLine(")")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaAREA_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New AREA_FORMACION
                dbAsignarEntidades.AsignarAREA_FORMACION(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New AREA_FORMACION))
        strSQL.AppendLine(" WHERE EXISTS ( SELECT 1 FROM CURSO_TEMA CT, OFERTA_FORMATIVA OFE WHERE CT.ID_TEMA_CURSO = OFE.ID_TEMA_CURSO AND CT.ID_AREA_FORMACION = AREA_FORMACION.ID_AREA_FORMACION ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine(" AND OFE.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        strSQL.AppendLine(")")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaAREA_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New AREA_FORMACION
                dbAsignarEntidades.AsignarAREA_FORMACION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorCODIGO_AREA(ByVal CODIGO_AREA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM AREA_FORMACION ")
        strSQL.Append("WHERE CODIGO_AREA = :CODIGO_AREA ")

        Dim op As OracleParameter = New OracleParameter(":CODIGO_AREA", OracleType.VarChar)
        op.Value = CODIGO_AREA
        args.Add(op)


        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaAREA_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New AREA_FORMACION
                dbAsignarEntidades.AsignarAREA_FORMACION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorNOMBRE(ByVal AREA_FORMACION As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM AREA_FORMACION ")
        strSQL.Append("WHERE AREA_FORMACION = :AREA_FORMACION ")

        Dim op As OracleParameter = New OracleParameter(":AREA_FORMACION", OracleType.VarChar)
        op.Value = Trim(AREA_FORMACION)
        args.Add(op)


        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaAREA_FORMACION

        Try
            Do While dr.Read()
                Dim mEntidad As New AREA_FORMACION
                dbAsignarEntidades.AsignarAREA_FORMACION(dr, mEntidad)
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
