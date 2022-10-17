Partial Public Class dbCONTRATO_BOLPROS
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CONTRATO_BOLPROS
        lEntidad = CType(aEntidad, CONTRATO_BOLPROS)

        Dim lID As Decimal
        If lEntidad.ID_CONTRATO = 0 _
            Or lEntidad.ID_CONTRATO = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_CONTRATO = lID
            lEntidad.USUARIO_CREACION = EL.configuracion.usuarioActualiza
            lEntidad.FECHA_CREACION = Now
            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, CONTRATO_BOLPROS).LASTUPDATE = Now
        CType(aEntidad, CONTRATO_BOLPROS).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            ByVal LOTE As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine(QuerySelect(New CONTRATO_BOLPROS))

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            op.Value = ID_PROGRAMA_FORMACION
            args.Add(op)
        End If
        If ID_CONTRATO_COMPRA <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA ")
            Dim op As OracleParameter = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
            op.Value = ID_CONTRATO_COMPRA
            args.Add(op)
        End If
        If NUM_CONTRATO.Trim IsNot Nothing AndAlso NUM_CONTRATO.Trim <> "" Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.NUM_CONTRATO = :NUM_CONTRATO ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO.Trim
            args.Add(op)
        End If
        If LOTE.Trim IsNot Nothing AndAlso LOTE.Trim <> "" Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.LOTE = :LOTE ")
            Dim op As OracleParameter = New OracleParameter(":LOTE", OracleType.VarChar)
            op.Value = LOTE.Trim
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

        Dim lista As New listaCONTRATO_BOLPROS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_BOLPROS
                AsignarCONTRATO_BOLPROS(dr, mEntidad)
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorContratoCompra(ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            ByVal NUM_CONTRATO As String,
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine(QuerySelect(New CONTRATO_BOLPROS))

        If ID_CONTRATO_COMPRA <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_CONTRATO_COMPRA = :ID_CONTRATO_COMPRA ")
            Dim op As OracleParameter = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
            op.Value = ID_CONTRATO_COMPRA
            args.Add(op)
        End If
        If NUM_CONTRATO.Trim IsNot Nothing AndAlso NUM_CONTRATO.Trim <> "" Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.NUM_CONTRATO = :NUM_CONTRATO ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO
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

        Dim lista As New listaCONTRATO_BOLPROS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_BOLPROS
                AsignarCONTRATO_BOLPROS(dr, mEntidad)
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String,
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine(QuerySelect(New CONTRATO_BOLPROS))

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            op.Value = ID_PROGRAMA_FORMACION
            args.Add(op)
        End If
        If NUM_CONTRATO.Trim IsNot Nothing AndAlso NUM_CONTRATO.Trim <> "" Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.NUM_CONTRATO = :NUM_CONTRATO ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO
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

        Dim lista As New listaCONTRATO_BOLPROS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_BOLPROS
                AsignarCONTRATO_BOLPROS(dr, mEntidad)
                mEntidad.DESCRIPCION_CONTRATO = AsignarDescripcionContrato(mEntidad.ID_CONTRATO_COMPRA, mEntidad.NUM_CONTRATO, mEntidad.LOTE)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorPROVEEDOR_AF_PAGO_PARTICIPANTE(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ES_PAGO_PARTICIPANTE As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine(QuerySelect(New CONTRATO_BOLPROS))

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ES_PAGO_PARTICIPANTE <> -1 Then
            AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ID_TIPO_ADJ IN(2,3)")
            'Dim op As OracleParameter = New OracleParameter(":ID_TIPO_ADJ", OracleType.Number)
            'op.Value = ES_PAGO_PARTICIPANTE
            'args.Add(op)
        End If
        'If ES_PAGO_PARTICIPANTE <> -1 Then
        '    AgregarCondicion(strSQLCondicion, " CONTRATO_BOLPROS.ES_PAGO_PARTICIPANTE = :ES_PAGO_PARTICIPANTE ")
        '    Dim op As OracleParameter = New OracleParameter(":ES_PAGO_PARTICIPANTE", OracleType.Number)
        '    op.Value = ES_PAGO_PARTICIPANTE
        '    args.Add(op)
        'End If

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

        Dim lista As New listaCONTRATO_BOLPROS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_BOLPROS
                AsignarCONTRATO_BOLPROS(dr, mEntidad)
                mEntidad.DESCRIPCION_CONTRATO = AsignarDescripcionContrato(mEntidad.ID_CONTRATO_COMPRA, mEntidad.NUM_CONTRATO, mEntidad.LOTE)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As CONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT C.* ")
        strSQL.AppendLine("FROM CONTRATO_BOLPROS C ")
        strSQL.AppendLine("WHERE (SELECT COUNT(1) FROM ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA G WHERE AC.ID_CONTRATO = C.ID_CONTRATO AND AC.ID_ACCION_CONTRATADA = G.ID_ACCION_CONTRATADA AND G.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA) > 0 ")

        Dim op As OracleParameter = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        op.Value = ID_ACCION_FORMATIVA
        args.Add(op)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())

        Dim mEntidad As New CONTRATO_BOLPROS

        Try
            If dr.Read() Then
                AsignarCONTRATO_BOLPROS(dr, mEntidad)
                mEntidad.DESCRIPCION_CONTRATO = AsignarDescripcionContrato(mEntidad.ID_CONTRATO_COMPRA, mEntidad.NUM_CONTRATO, mEntidad.LOTE)
            Else
                mEntidad = Nothing
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
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_TIPO_CONTRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROGRAMA_TIPO_CONTRATACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_TIPO_CONTRA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CONTRATO_BOLPROS))
        strSQL.Append(" WHERE ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION AND ID_TIPO_CONTRA = :ID_TIPO_CONTRA ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        args(0).Value = ID_PROGRAMA_FORMACION

        args(1) = New OracleParameter(":ID_TIPO_CONTRA", OracleType.Number)
        args(1).Value = ID_TIPO_CONTRA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCONTRATO_BOLPROS

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_BOLPROS
                dbAsignarEntidades.AsignarCONTRATO_BOLPROS(dr, mEntidad)
                mEntidad.DESCRIPCION_CONTRATO = AsignarDescripcionContrato(mEntidad.ID_CONTRATO_COMPRA, mEntidad.NUM_CONTRATO, mEntidad.LOTE)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerMontoEjecutadoPorContrato(ByVal ID_CONTRATO As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim lRet As Decimal = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(SUM(INF.MONTO_FACTURA),0) AS MONTO_EJECUTADO ")
        strSQL.AppendLine("FROM CONTRATO_BOLPROS CB, ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA GA, INFORME_FINAL_AF INF ")
        strSQL.AppendLine("WHERE CB.ID_CONTRATO = AC.ID_CONTRATO AND AC.ID_ACCION_CONTRATADA = GA.ID_ACCION_CONTRATADA ")
        strSQL.AppendLine("AND GA.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND CB.ID_CONTRATO = :ID_CONTRATO ")

        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Try
            If dr.Read Then
                lRet = CDec(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    Public Function ObtenerParticipacionesEjecutadasPorContrato(ByVal ID_CONTRATO As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim lRet As Decimal = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(COUNT(PAF.ID_PARTICIPANTE),0) AS PARTICIPACIONES_EJECUTADAS  ")
        strSQL.AppendLine("FROM CONTRATO_BOLPROS CB, ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA GA, PARTICIPANTE_AF PAF ")
        strSQL.AppendLine("WHERE CB.ID_CONTRATO = AC.ID_CONTRATO AND AC.ID_ACCION_CONTRATADA = GA.ID_ACCION_CONTRATADA ")
        strSQL.AppendLine("AND GA.ID_ACCION_FORMATIVA = PAF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND PAF.ES_CAPACITADO = 1 ")
        strSQL.AppendLine("AND (SELECT COUNT(1) FROM INFORME_FINAL_AF F WHERE F.ID_ACCION_FORMATIVA = PAF.ID_ACCION_FORMATIVA) > 0 ")
        strSQL.AppendLine("AND CB.ID_CONTRATO = :ID_CONTRATO ")

        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        dr = sql.ExecuteReader(cnnStr, CommandType.Text, strSQL.ToString, args.ToArray)

        Try
            If dr.Read Then
                lRet = CDec(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet
    End Function

    Private Function AsignarDescripcionContrato(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal NUM_CONTRATO As String, ByVal LOTE As String) As String
        Dim lContratoCompra As New CONTRATO_COMPRA
        Dim d As New dbCONTRATO_COMPRA
        Dim descrip As String = ""

        lContratoCompra.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
        d.Recuperar(lContratoCompra)

        If lContratoCompra IsNot Nothing Then
            descrip = "Oferta No.: " + lContratoCompra.NO_CONTRATO_COMPRA + " Contrato: " + NUM_CONTRATO + If(LOTE <> Nothing, " Lote: " + LOTE, "")
        End If

        Return descrip
    End Function
End Class
