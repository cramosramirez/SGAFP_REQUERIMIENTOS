Partial Class dbPROVEEDOR_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por técnico
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTecnico(ByVal USUARIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT PROVEEDOR_AF.* ")
        strSQL.Append("FROM PROVEEDOR_AF ")
        strSQL.Append("WHERE EXISTS (SELECT * FROM TECNICOS_SITIOS_ASIG WHERE TECNICOS_SITIOS_ASIG.ID_PROVEEDOR_AF = PROVEEDOR_AF.ID_PROVEEDOR_AF ")
        strSQL.Append("AND TECNICOS_SITIOS_ASIG.USUARIO = :USUARIO )")
       
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.NVarChar)
        args(0).Value = USUARIO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF
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
    ''' Función que Devuelve una Colección de Entidades filtrada por técnico
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDepartamento_Presencia_Sitio(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF

        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT PROVEEDOR_AF.ID_PROVEEDOR_AF, PROVEEDOR_AF.NOMBRE_PROVEEDOR ")
        strSQL.Append("FROM PROVEEDOR_AF, SITIO_CAPACITACION ")
        strSQL.Append("WHERE PROVEEDOR_AF.ID_PROVEEDOR_AF = SITIO_CAPACITACION.ID_PROVEEDOR_AF ")

        If CODIGO_DEPARTAMENTO <> "" Then
            strSQL.Append("AND SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO AND SITIO_CAPACITACION.CODIGO_REGION = :CODIGO_REGION ")

            Dim args(1) As OracleParameter
            args(0) = New OracleParameter(":CODIGO_REGION", OracleType.NVarChar)
            args(0).Value = CODIGO_REGION

            args(1) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.NVarChar)
            args(1).Value = CODIGO_DEPARTAMENTO

            strSQL.Append("GROUP BY PROVEEDOR_AF.ID_PROVEEDOR_AF, PROVEEDOR_AF.NOMBRE_PROVEEDOR ")
            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            strSQL.Append("GROUP BY PROVEEDOR_AF.ID_PROVEEDOR_AF, PROVEEDOR_AF.NOMBRE_PROVEEDOR ")
            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If

            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF

                mEntidad.ID_PROVEEDOR_AF = dr.GetDecimal(0)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por técnico
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSitio_Capacitacion(ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal asColumnaOrden As String = "PROVEEDOR_AF.NOMBRE_PROVEEDOR", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF

        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT PROVEEDOR_AF.ID_PROVEEDOR_AF, PROVEEDOR_AF.NOMBRE_PROVEEDOR ")
        strSQL.Append("FROM PROVEEDOR_AF, SITIO_CAPACITACION ")
        strSQL.Append("WHERE PROVEEDOR_AF.ID_PROVEEDOR_AF = SITIO_CAPACITACION.ID_PROVEEDOR_AF ")

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


        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF

                mEntidad.ID_PROVEEDOR_AF = dr.GetDecimal(0)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por técnico
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaProveedoresHTP(ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Dim args(0) As OracleParameter
        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT P.* ")
        strSQL.Append("FROM PROVEEDOR_AF P ")
        strSQL.Append("WHERE EXISTS (SELECT 1 FROM OFERTA_FORMATIVA F WHERE F.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF ")

        If ID_EJERCICIO <> "" Then
            strSQL.Append("AND F.ID_EJERCICIO = :ID_EJERCICIO )")
            args(0) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            args(0).Value = ID_EJERCICIO

            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            strSQL.Append(")")
            If asColumnaOrden <> "" Then
                strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
            End If
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF
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


    Public Function ObtenerListaPorCriterios(ByVal NIT As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT P.* ")
        strSQL.Append("FROM PROVEEDOR_AF P ")

        If NIT <> "" Then
            arg = New OracleParameter(":NIT", OracleType.VarChar)
            arg.Value = NIT
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "P.NIT = :NIT")
        End If
        strSQL.Append(strCondicion.ToString())

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF
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
    ''' Función que Devuelve una Colección de Entidades filtrada por Tipo de Programa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaProveedoresPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Dim args(0) As OracleParameter
        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder

        If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
            strSQL.Append("SELECT P.* ")
            strSQL.Append("FROM PROVEEDOR_AF P ")
            strSQL.Append("WHERE EXISTS (SELECT 1 FROM OFERTA_FORMATIVA F WHERE F.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF) ")
        Else
            strSQL.Append("SELECT P.* ")
            strSQL.Append("FROM PROVEEDOR_AF P ")
            strSQL.Append("WHERE EXISTS (SELECT 1 FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE AD WHERE AF.ID_ACCION_FORMATIVA = AD.ID_ACCION_FORMATIVA ")
            strSQL.Append("AND AD.ID_PROGRAMA_FORMACION = " + ID_PROGRAMA_FORMACION.ToString + " ")
            strSQL.Append("AND AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF
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
    ''' Función que Devuelve una Colección de Entidades filtrada por técnico
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	22/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaProveedoresPorProgramaFormacion(ByVal listaProgramasFormacion As List(Of Integer), Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Dim args(0) As OracleParameter
        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        Dim strIdsProgramaFormacion As New StringBuilder

        strSQL.Append("SELECT P.* ")
        strSQL.Append("FROM PROVEEDOR_AF P")

        If listaProgramasFormacion.Count > 0 Then
            strSQL.Append(" WHERE EXISTS(SELECT 1 FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D WHERE AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF AND AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA AND ")
            For Each tipo As Integer In listaProgramasFormacion
                If strIdsProgramaFormacion.ToString.Length = 0 Then
                    strIdsProgramaFormacion.Append("D.ID_PROGRAMA_FORMACION IN(")
                    strIdsProgramaFormacion.Append(tipo.ToString)
                Else
                    strIdsProgramaFormacion.Append(",")
                    strIdsProgramaFormacion.Append(tipo.ToString)
                End If
            Next
            strIdsProgramaFormacion.Append(")")
            strSQL.Append(strIdsProgramaFormacion.ToString)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPROVEEDOR_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New PROVEEDOR_AF
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
End Class
