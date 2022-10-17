Partial Class dbASISTENCIA_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ASISTENCIA_AF
        lEntidad = CType(aEntidad, ASISTENCIA_AF)

        Dim lID As Decimal
        If lEntidad.ID_ASISTENCIA_AF = 0 _
            Or lEntidad.ID_ASISTENCIA_AF = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ASISTENCIA_AF = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, ASISTENCIA_AF).USERID = Utilerias.ObtenerUsuario()
        CType(aEntidad, ASISTENCIA_AF).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, ASISTENCIA_AF).USERID = Utilerias.ObtenerUsuario()
        CType(aEntidad, ASISTENCIA_AF).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de Asistencia por Fecha y Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	21/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadAsistenciaPorFecha(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT count(*) FROM ASISTENCIA_AF WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND FECHA = :FECHA")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA
        args(1) = New OracleParameter(":FECHA", OracleType.DateTime)
        args(1).Value = FECHA

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve un registro de la Asistencia por los parámetros enviados
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As ASISTENCIA_AF
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT * FROM ASISTENCIA_AF WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND FECHA = :FECHA")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA
        args(1) = New OracleParameter(":FECHA", OracleType.DateTime)
        args(1).Value = FECHA

        Dim dr As IDataReader
        Dim aEntidad As entidadBase

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing
        Dim mEntidad As New ASISTENCIA_AF

        Try
            If dr.Read() Then
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
            Else
                Return Nothing
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorINFORME_FINAL_AF(ByVal idInformeFinal As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaASISTENCIA_AF
        Dim strSQL As New StringBuilder
        Dim lEntidadInforme As New INFORME_FINAL_AF
        Dim dEntidadInforme As New dbINFORME_FINAL_AF
        lEntidadInforme.ID_INFORME_FINAL = idInformeFinal
        dEntidadInforme.Recuperar(lEntidadInforme)

        strSQL.Append(Me.QuerySelect(New ASISTENCIA_AF))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")
        strSQL.Append(" AND FECHA BETWEEN :FECHA_INICIAL AND :FECHA_FINAL")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = lEntidadInforme.ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":FECHA_INICIAL", OracleType.DateTime)
        args(1).Value = lEntidadInforme.FECHA_INICIAL

        args(2) = New OracleParameter(":FECHA_FINAL", OracleType.DateTime)
        args(2).Value = lEntidadInforme.FECHA_FINAL

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaASISTENCIA_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New ASISTENCIA_AF
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
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFechasFinalizacionPorMes(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIO_PERIODO As Date) As List(Of Date)
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT EXTRACT(YEAR FROM FECHA) AS AÑO, EXTRACT(MONTH FROM FECHA) AS MES, MAX(FECHA) AS FECHA_FIN_PERIODO ")
        strSQL.Append("FROM ASISTENCIA_AF ")
        strSQL.Append("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND FECHA >= :FECHA_INICIO_PERIODO ")
        strSQL.Append("GROUP BY EXTRACT(YEAR FROM FECHA), EXTRACT(MONTH FROM FECHA) ")
        strSQL.Append("ORDER BY MAX(FECHA)")

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":FECHA_INICIO_PERIODO", OracleType.DateTime)
        args(1).Value = FECHA_INICIO_PERIODO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New List(Of Date)

        Try
            Do While dr.Read()
                lista.Add(CDate(dr("FECHA_FIN_PERIODO")))
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
 
End Class
