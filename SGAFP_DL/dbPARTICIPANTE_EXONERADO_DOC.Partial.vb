Partial Public Class dbPARTICIPANTE_EXONERADO_DOC

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE_EXONERADO_DOC.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ESTADO"></param>
    ''' <param name="FECHA_NACIMIENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ESTADO As Decimal, ByVal FECHA_NACIMIENTO As Object, ByVal NOMBRES As String, ByVal APELLIDOS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As New OracleParameter

        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))

        If ID_PROVEEDOR_AF <> -1 Then
            Me.AgregarCondicion(strCondicion, "ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF")
            arg = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            Me.AgregarCondicion(strCondicion, "ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION")
            arg = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If
        If ESTADO <> -1 Then
            Me.AgregarCondicion(strCondicion, "ESTADO = :ESTADO")
            arg = New OracleParameter(":ESTADO", OracleType.Number)
            arg.Value = ESTADO
            args.Add(arg)
        End If
        If FECHA_NACIMIENTO IsNot Nothing AndAlso IsDate(FECHA_NACIMIENTO) Then
            Me.AgregarCondicion(strCondicion, "FECHA_NACIMIENTO = :FECHA_NACIMIENTO")
            arg = New OracleParameter(":FECHA_NACIMIENTO", OracleType.DateTime)
            arg.Value = CDate(FECHA_NACIMIENTO)
            args.Add(arg)
        End If
        If NOMBRES <> String.Empty Then
            Me.AgregarCondicion(strCondicion, "NOMBRES = :NOMBRES")
            arg = New OracleParameter(":NOMBRES", OracleType.VarChar)
            arg.Value = NOMBRES
            args.Add(arg)
        End If
        If APELLIDOS <> String.Empty Then
            Me.AgregarCondicion(strCondicion, "APELLIDOS = :APELLIDOS")
            arg = New OracleParameter(":APELLIDOS", OracleType.VarChar)
            arg.Value = APELLIDOS
            args.Add(arg)
        End If
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.TecnicoCentroHTP) Then
            Me.AgregarCondicion(strCondicion, "EXISTS (SELECT 1 FROM TECNICOS_SITIOS_ASIG T WHERE T.USUARIO = :USUARIO AND T.ID_PROVEEDOR_AF = PARTICIPANTE_EXONERADO_DOC.ID_PROVEEDOR_AF AND T.ID_SITIO_CAPACITACION = PARTICIPANTE_EXONERADO_DOC.ID_SITIO_CAPACITACION)")
            arg = New OracleParameter(":USUARIO", OracleType.VarChar)
            arg.Value = Utilerias.ObtenerUsuario
            args.Add(arg)
        End If

        strSQL.Append(strCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE_EXONERADO_DOC.
    ''' </summary>
    ''' <param name="mPARTICIPANTE_EXONERADO_DOC"></param>
    ''' <param name="duplicadoPorFonetico"></param> 
    ''' <param name="asColumnaOrden"></param> 
    ''' <param name="asTipoOrden"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParticipantesSemejantes(ByVal mPARTICIPANTE_EXONERADO_DOC As PARTICIPANTE_EXONERADO_DOC, ByRef duplicadoPorFonetico As Integer, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As New OracleParameter

        strSQL.Append("SELECT * FROM ")
        strSQL.Append("(SELECT PARTICIPANTE_EXONERADO_DOC.*, SOUNDEX(REPLACE(NOMBRES,' ','')) AS CODIGO1, SOUNDEX(REPLACE(APELLIDOS,' ','')) AS CODIGO2 ")
        strSQL.Append("FROM PARTICIPANTE_EXONERADO_DOC) ")

        If mPARTICIPANTE_EXONERADO_DOC IsNot Nothing Then
            If mPARTICIPANTE_EXONERADO_DOC.NOMBRES <> String.Empty Then
                Me.AgregarCondicion(strCondicion, "CODIGO1 = SOUNDEX(:NOMBRES)")
                arg = New OracleParameter(":NOMBRES", OracleType.VarChar)
                arg.Value = Replace(Utilerias.ReemplazarAcentos(mPARTICIPANTE_EXONERADO_DOC.NOMBRES.Trim.ToUpper), " ", String.Empty)
                args.Add(arg)
            End If

            If mPARTICIPANTE_EXONERADO_DOC.APELLIDOS <> String.Empty Then
                Me.AgregarCondicion(strCondicion, "CODIGO2 = SOUNDEX(:APELLIDOS)")
                arg = New OracleParameter(":APELLIDOS", OracleType.VarChar)
                arg.Value = Replace(Utilerias.ReemplazarAcentos(mPARTICIPANTE_EXONERADO_DOC.APELLIDOS.Trim.ToUpper), " ", String.Empty)
                args.Add(arg)
            End If
        End If

        strSQL.Append(strCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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
