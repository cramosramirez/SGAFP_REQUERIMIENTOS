Partial Public Class dbACCION_CONTRATADA
    
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
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaACCION_CONTRATADA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT A.* FROM ACCION_CONTRATADA A, CONTRATO_BOLPROS C WHERE C.ID_CONTRATO =  A.ID_CONTRATO ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine("AND C.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            strSQL.AppendLine("AND C.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            op.Value = ID_PROGRAMA_FORMACION
            args.Add(op)
        End If
        If NUM_CONTRATO <> "" Then
            strSQL.AppendLine("AND C.NUM_CONTRATO LIKE :NUM_CONTRATO || '%' ")
            Dim op As OracleParameter = New OracleParameter(":NUM_CONTRATO", OracleType.VarChar)
            op.Value = NUM_CONTRATO
            args.Add(op)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_CONTRATADA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_CONTRATADA
                AsignarACCION_CONTRATADA(dr, mEntidad)
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
    ''' 	[cramos]	18/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposCapacitacionPATIparaAsociar(ByVal ID_FUENTE As Decimal, _
                                            ByVal NO_CONVOCATORIA As Decimal, _
                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                            ByVal CODIGO_MUNICIPIO As String, _
                                            Optional ByVal asColumnaOrden As String = "S.ID_SOLICITUD", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT 0 AS ID_GRUPO_ACCION, 0 AS VALOR, S.ID_SOLICITUD, GA.ID_GRUPO_AF, GA.NOMBRE_AF, GA.DURACION_HORAS, ")
        strSQL.AppendLine("(SELECT D.NOMBRE FROM DEPARTAMENTO D WHERE D.CODIGO_DEPARTAMENTO = S.CODIGO_DEPARTAMENTO) AS DEPARTAMENTO, (SELECT M.NOMBRE FROM MUNICIPIO M WHERE M.CODIGO_DEPARTAMENTO = S.CODIGO_DEPARTAMENTO AND M.CODIGO_MUNICIPIO = S.CODIGO_MUNICIPIO) AS MUNICIPIO ")
        strSQL.AppendLine("FROM PATI_CLIENTE.SOLICITUD_CAPACITACION_PATI S, PATI_CLIENTE.GRUPO_POR_SOLICITUD GS, PATI.GRUPO_ACCION_FORMATIVA GA ")
        AgregarCondicion(strSQLCondicion, " S.ID_SOLICITUD = GS.ID_SOLICITUD ")
        AgregarCondicion(strSQLCondicion, " GS.ID_GRUPO_AF = GA.ID_GRUPO_AF ")
        AgregarCondicion(strSQLCondicion, " NOT EXISTS(SELECT 1 FROM GRUPO_ACCION_CONTRATADA GC, ACCION_CONTRATADA AC, CONTRATO_BOLPROS CB WHERE GC.ID_ACCION_CONTRATADA = AC.ID_ACCION_CONTRATADA AND AC.ID_CONTRATO = CB.ID_CONTRATO AND GC.ID_GRUPO_AF = GA.ID_GRUPO_AF AND CB.ID_FUENTE = " + ID_FUENTE.ToString + " AND AC.NO_CONVOCATORIA = " + NO_CONVOCATORIA.ToString + ") ")

        If ID_FUENTE <> -1 Then
            AgregarCondicion(strSQLCondicion, " S.ID_FUENTE = :ID_FUENTE ")
            Dim op As OracleParameter = New OracleParameter(":ID_FUENTE", OracleType.Number)
            op.Value = ID_FUENTE
            args.Add(op)
        End If
        If NO_CONVOCATORIA <> -1 Then
            AgregarCondicion(strSQLCondicion, " S.NO_CONVOCATORIA = :NO_CONVOCATORIA ")
            Dim op As OracleParameter = New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
            op.Value = NO_CONVOCATORIA
            args.Add(op)
        End If
        If CODIGO_DEPARTAMENTO <> "" Then
            AgregarCondicion(strSQLCondicion, " S.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            op.Value = CODIGO_DEPARTAMENTO
            args.Add(op)
        End If
        If CODIGO_MUNICIPIO <> "" Then
            AgregarCondicion(strSQLCondicion, " S.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            op.Value = CODIGO_MUNICIPIO
            args.Add(op)
        End If
        'AgregarCondicion(strSQLCondicion, " S.TDR IS NULL AND S.ID_ESTADO_SOLIC_PATI = 2 ")

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return ds

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposCapacitacionPATIAsociados(ByVal ID_ACCION_CONTRATADA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "S.ID_SOLICITUD", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT 0 AS VALOR, S.ID_SOLICITUD, GA.ID_GRUPO_AF, GA.NOMBRE_AF, ")
        strSQL.AppendLine("(SELECT D.NOMBRE FROM DEPARTAMENTO D WHERE D.CODIGO_DEPARTAMENTO = S.CODIGO_DEPARTAMENTO) AS DEPARTAMENTO, (SELECT M.NOMBRE FROM MUNICIPIO M WHERE M.CODIGO_DEPARTAMENTO = S.CODIGO_DEPARTAMENTO AND M.CODIGO_MUNICIPIO = S.CODIGO_MUNICIPIO) AS MUNICIPIO, ")
        strSQL.AppendLine("(SELECT GC.ID_GRUPO_ACCION FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GA.ID_GRUPO_AF AND GC.ID_ACCION_CONTRATADA = " + ID_ACCION_CONTRATADA.ToString + ") AS ID_GRUPO_ACCION, ")
        strSQL.AppendLine("(SELECT GC.HABILITADO FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GA.ID_GRUPO_AF AND GC.ID_ACCION_CONTRATADA = " + ID_ACCION_CONTRATADA.ToString + ") AS HABILITADO ")
        strSQL.AppendLine("FROM PATI_CLIENTE.SOLICITUD_CAPACITACION_PATI S, PATI_CLIENTE.GRUPO_POR_SOLICITUD GS, PATI.GRUPO_ACCION_FORMATIVA GA ")
        AgregarCondicion(strSQLCondicion, " S.ID_SOLICITUD = GS.ID_SOLICITUD ")
        AgregarCondicion(strSQLCondicion, " GS.ID_GRUPO_AF = GA.ID_GRUPO_AF ")
        AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GA.ID_GRUPO_AF AND GC.ID_ACCION_CONTRATADA = " + ID_ACCION_CONTRATADA.ToString + ") ")

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return ds

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposPorPROYECTOparaAsociar(ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal CODIGO_PROGRAMA As String, _
                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                            ByVal CODIGO_MUNICIPIO As String, _
                                            Optional ByVal asColumnaOrden As String = "S.ID_SOLICITUD", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT 0 AS ID_GRUPO_ACCION, 0 AS VALOR, S.ID_SOLICITUD, S.FECHA_SOLICITUD, GS.ID_GRUPO_SOLICITUD, TRIM(GS.CODIGO_PROGRAMA) AS CODIGO_PROGRAMA, GS.DURACION_HORAS, GS.NUM_PARTICIPANTES, ")
        strSQL.AppendLine("(SELECT D.NOMBRE FROM DEPARTAMENTO D WHERE D.CODIGO_DEPARTAMENTO = GS.CODIGO_DEPARTAMENTO) AS DEPARTAMENTO, (SELECT M.NOMBRE FROM MUNICIPIO M WHERE M.CODIGO_DEPARTAMENTO = GS.CODIGO_DEPARTAMENTO AND M.CODIGO_MUNICIPIO = GS.CODIGO_MUNICIPIO) AS MUNICIPIO ")
        strSQL.AppendLine("FROM SOLICITUD_CAPACITACION S, GRUPO_SOLICITUD GS ")

        AgregarCondicion(strSQLCondicion, " S.ID_SOLICITUD = GS.ID_SOLICITUD ")
        AgregarCondicion(strSQLCondicion, " NOT EXISTS(SELECT 1 FROM GRUPO_ACCION_CONTRATADA GC, ACCION_CONTRATADA AC, CONTRATO_BOLPROS CB WHERE GC.ID_ACCION_CONTRATADA = AC.ID_ACCION_CONTRATADA AND AC.ID_CONTRATO = CB.ID_CONTRATO AND GC.ID_GRUPO_AF = GS.ID_GRUPO_SOLICITUD AND CB.ID_PROGRAMA_FORMACION = " + ID_PROGRAMA_FORMACION.ToString + ") ")

        If ID_PROGRAMA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " S.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            op.Value = ID_PROGRAMA_FORMACION
            args.Add(op)
        End If
        If CODIGO_PROGRAMA <> "" Then
            AgregarCondicion(strSQLCondicion, " GS.CODIGO_PROGRAMA = :CODIGO_PROGRAMA ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_PROGRAMA", OracleType.VarChar)
            op.Value = CODIGO_PROGRAMA.Trim
            args.Add(op)
        End If
        If CODIGO_DEPARTAMENTO <> "" Then
            AgregarCondicion(strSQLCondicion, " GS.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            op.Value = CODIGO_DEPARTAMENTO
            args.Add(op)
        End If
        If CODIGO_MUNICIPIO <> "" Then
            AgregarCondicion(strSQLCondicion, " GS.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            op.Value = CODIGO_MUNICIPIO
            args.Add(op)
        End If
        AgregarCondicion(strSQLCondicion, " GS.TDR IS NULL ")

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return ds

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposPorPROYECTOAsociados(ByVal ID_ACCION_CONTRATADA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "S.ID_SOLICITUD", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT 0 AS VALOR, S.ID_SOLICITUD, S.FECHA_SOLICITUD, GS.ID_GRUPO_SOLICITUD, TRIM(GS.CODIGO_PROGRAMA) AS CODIGO_PROGRAMA, GS.DURACION_HORAS, GS.NUM_PARTICIPANTES, ")
        strSQL.AppendLine("(SELECT D.NOMBRE FROM DEPARTAMENTO D WHERE D.CODIGO_DEPARTAMENTO = GS.CODIGO_DEPARTAMENTO) AS DEPARTAMENTO, (SELECT M.NOMBRE FROM MUNICIPIO M WHERE M.CODIGO_DEPARTAMENTO = GS.CODIGO_DEPARTAMENTO AND M.CODIGO_MUNICIPIO = GS.CODIGO_MUNICIPIO) AS MUNICIPIO, ")
        strSQL.AppendLine("(SELECT GC.HABILITADO FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GS.ID_GRUPO_SOLICITUD AND GC.ID_ACCION_CONTRATADA = " + ID_ACCION_CONTRATADA.ToString + ") AS HABILITADO, ")
        strSQL.AppendLine("(SELECT GC.ID_GRUPO_ACCION FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GS.ID_GRUPO_SOLICITUD AND GC.ID_ACCION_CONTRATADA = " + ID_ACCION_CONTRATADA.ToString + ") AS ID_GRUPO_ACCION ")
        strSQL.AppendLine("FROM SOLICITUD_CAPACITACION S, GRUPO_SOLICITUD GS ")
        AgregarCondicion(strSQLCondicion, " S.ID_SOLICITUD = GS.ID_SOLICITUD ")
        AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM GRUPO_ACCION_CONTRATADA GC WHERE GC.ID_GRUPO_AF = GS.ID_GRUPO_SOLICITUD AND GC.ID_ACCION_CONTRATADA  = " + ID_ACCION_CONTRATADA.ToString + ") ")

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
            Return ds

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function
End Class
