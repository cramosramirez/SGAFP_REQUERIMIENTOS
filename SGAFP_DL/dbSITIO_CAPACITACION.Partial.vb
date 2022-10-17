Partial Class dbSITIO_CAPACITACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTECNICO(ByVal ID_PROVEEDOR_AF As Decimal, ByVal USUARIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SITIO_CAPACITACION.* ")
        strSQL.Append("FROM SITIO_CAPACITACION ")
        strSQL.Append("WHERE EXISTS (SELECT * FROM TECNICOS_SITIOS_ASIG WHERE TECNICOS_SITIOS_ASIG.ID_PROVEEDOR_AF = SITIO_CAPACITACION.ID_PROVEEDOR_AF ")
        strSQL.Append("AND TECNICOS_SITIOS_ASIG.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        strSQL.Append("AND TECNICOS_SITIOS_ASIG.USUARIO = :USUARIO ")
        strSQL.Append("AND TECNICOS_SITIOS_ASIG.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF )")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF
        args(1) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(1).Value = USUARIO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSITIO_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SITIO_CAPACITACION
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
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
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerTECNICO_ASIGNADO(ByVal ID_SITIO_CAPACITACION As Decimal) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT USUARIO ")
        strSQL.Append("FROM TECNICOS_SITIOS_ASIG ")
        strSQL.Append("WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION")

        Dim mUsuario As String = ""
        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(0).Value = ID_SITIO_CAPACITACION


        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Try
            If dr.Read() Then
                mUsuario = dr.GetString(0)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mUsuario
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF_DEPARTAMENTO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                        ByVal CODIGO_DEPARTAMENTO As String, _
                                                        Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                                        Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION

        Dim strSQL As New StringBuilder
        Dim strSQLWHERE As New StringBuilder
        strSQL.Append("SELECT SITIO_CAPACITACION.* ")
        strSQL.Append("FROM SITIO_CAPACITACION ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 OrElse CODIGO_DEPARTAMENTO <> "" Then
            strSQLWHERE.Append("WHERE ")
        End If

        If ID_PROVEEDOR_AF <> -1 Then
            If CODIGO_DEPARTAMENTO <> "" Then
                strSQLWHERE.Append("ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF AND ")
            Else
                strSQLWHERE.Append("ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If

        If CODIGO_DEPARTAMENTO <> "" Then
            strSQLWHERE.Append("CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            op.Value = CODIGO_DEPARTAMENTO
            args.Add(op)
        End If

        strSQL.Append(strSQLWHERE.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaSITIO_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SITIO_CAPACITACION
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
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
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF_SITIO_CAPACITACION_DEPARTAMENTO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                        ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                        ByVal CODIGO_DEPARTAMENTO As String, _
                                                        Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                                        Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION

        Dim strSQL As New StringBuilder
        Dim strSQLWHERE As New StringBuilder
        strSQL.Append("SELECT SITIO_CAPACITACION.* ")
        strSQL.Append("FROM SITIO_CAPACITACION ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 OrElse CODIGO_DEPARTAMENTO <> "" Then
            strSQLWHERE.Append("WHERE ")
        End If

        If ID_PROVEEDOR_AF <> -1 Then
            If CODIGO_DEPARTAMENTO <> "" Or ID_SITIO_CAPACITACION <> -1 Then
                strSQLWHERE.Append("ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF AND ")
            Else
                strSQLWHERE.Append("ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If

        If ID_SITIO_CAPACITACION <> -1 Then
            If CODIGO_DEPARTAMENTO <> "" Then
                strSQLWHERE.Append("ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION AND ")
            Else
                strSQLWHERE.Append("ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If

        If CODIGO_DEPARTAMENTO <> "" Then
            strSQLWHERE.Append("CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            op.Value = CODIGO_DEPARTAMENTO
            args.Add(op)
        End If

        strSQL.Append(strSQLWHERE.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaSITIO_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SITIO_CAPACITACION
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
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
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorEJERCICIO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal CODIGO_DEPARTAMENTO As String, _
                                             ByVal ID_EJERCICIO As String, _
                                             Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                             Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION

        Dim strSQL As New StringBuilder
        Dim strSQLWHERE As New StringBuilder
        strSQL.Append("SELECT SITIO_CAPACITACION.* ")
        strSQL.Append("FROM SITIO_CAPACITACION ")
        strSQL.Append("WHERE EXISTS(SELECT * FROM SITIO_CAPACITACION_EJERCICIO ")
        strSQL.Append("     WHERE SITIO_CAPACITACION_EJERCICIO.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION AND ")
        strSQL.Append(" SITIO_CAPACITACION_EJERCICIO.ID_EJERCICIO = :ID_EJERCICIO) ")
        strSQL.Append(" AND NOT SITIO_CAPACITACION.LATITUD IS NULL ")
        strSQL.Append(" AND NOT SITIO_CAPACITACION.LONGITUD IS NULL ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_EJERCICIO <> "" Then
            Dim arg As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
        End If
        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.Append(" AND SITIO_CAPACITACION.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.Append(" AND SITIO_CAPACITACION.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim arg As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If
        If CODIGO_DEPARTAMENTO <> "" Then
            strSQL.Append(" AND SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
            Dim arg As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaSITIO_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SITIO_CAPACITACION
                dbAsignarEntidades.AsignarSITIO_CAPACITACION(dr, mEntidad)
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
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorEJERCICIO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal CODIGO_DEPARTAMENTO As String, _
                                             ByVal ID_EJERCICIO As String, _
                                             Optional ByVal asColumnaOrden As String = "DEPARTAMENTO.NOMBRE, PROVEEDOR_AF.NOMBRE_PROVEEDOR, SITIO_CAPACITACION.NOMBRE_SITIO", _
                                             Optional ByVal asTipoOrden As String = "ASC") As DataSet


        Try
            Dim strSQL As New StringBuilder
            Dim strSQLWHERE As New StringBuilder
            strSQL.Append("SELECT SITIO_CAPACITACION.ID_SITIO_CAPACITACION, DEPARTAMENTO.NOMBRE AS DEPARTAMENTO, PROVEEDOR_AF.NOMBRE_PROVEEDOR AS PROVEEDOR, SITIO_CAPACITACION.NOMBRE_SITIO AS CENTRO ")
            strSQL.Append("FROM SITIO_CAPACITACION, PROVEEDOR_AF, DEPARTAMENTO ")
            strSQL.Append("WHERE EXISTS(SELECT * FROM SITIO_CAPACITACION_EJERCICIO ")
            strSQL.Append("     WHERE SITIO_CAPACITACION_EJERCICIO.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION AND ")
            strSQL.Append(" SITIO_CAPACITACION_EJERCICIO.ID_EJERCICIO = :ID_EJERCICIO) ")
            strSQL.Append(" AND SITIO_CAPACITACION.ID_PROVEEDOR_AF = PROVEEDOR_AF.ID_PROVEEDOR_AF ")
            strSQL.Append(" AND SITIO_CAPACITACION.CODIGO_REGION = DEPARTAMENTO.CODIGO_REGION  ")
            strSQL.Append(" AND SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = DEPARTAMENTO.CODIGO_DEPARTAMENTO  ")

            Dim args As List(Of OracleParameter) = New List(Of OracleParameter)


            Dim argEjercicio As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            argEjercicio.Value = ID_EJERCICIO
            args.Add(argEjercicio)

            If ID_PROVEEDOR_AF <> -1 Then
                strSQL.Append(" AND SITIO_CAPACITACION.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF")
                Dim arg As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
                arg.Value = ID_PROVEEDOR_AF
                args.Add(arg)
            End If
            If ID_SITIO_CAPACITACION <> -1 Then
                strSQL.Append(" AND SITIO_CAPACITACION.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
                Dim arg As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
                arg.Value = ID_SITIO_CAPACITACION
                args.Add(arg)
            End If
            If CODIGO_DEPARTAMENTO <> "" Then
                strSQL.Append(" AND SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
                Dim arg As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
                arg.Value = CODIGO_DEPARTAMENTO
                args.Add(arg)
            End If

            If asColumnaOrden <> "" Then
                strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            Dim ds As DataSet

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

            Return ds

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	30/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As listaSITIO_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SITIO_CAPACITACION))
        strSQL.Append(" WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(0).Value = ID_SITIO_CAPACITACION

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSITIO_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SITIO_CAPACITACION
                dbAsignarEntidades.AsignarSITIO_CAPACITACION(dr, mEntidad)
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
