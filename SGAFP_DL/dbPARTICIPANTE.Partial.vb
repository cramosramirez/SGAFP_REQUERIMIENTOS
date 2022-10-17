Imports System.Text

Partial Class dbPARTICIPANTE

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes Repetidos por Nombre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorNombres() As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(" SELECT * FROM PARTICIPANTE P1 ")
        strSQL.AppendLine(" WHERE REPLACE(P1.NOMBRES,' ', '') || REPLACE(P1.APELLIDOS, ' ','') IN (SELECT REPLACE(P2.NOMBRES,' ', '') || REPLACE(P2.APELLIDOS, ' ','') ")
        strSQL.AppendLine(" FROM PARTICIPANTE P2 ")
        strSQL.AppendLine(" GROUP BY REPLACE(P2.NOMBRES,' ', '') || REPLACE(P2.APELLIDOS, ' ','') ")
        strSQL.AppendLine(" HAVING COUNT(*) > 1) ")
        strSQL.AppendLine(" order by REPLACE(P1.NOMBRES,' ', '') || REPLACE(P1.APELLIDOS, ' ',''), P1.ID_PARTICIPANTE  ")

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
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
    ''' Función que Devuelve Participantes Repetidos por DUI.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorDUI() As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(" SELECT * FROM PARTICIPANTE P1 ")
        strSQL.AppendLine(" WHERE to_number(P1.DUI) IN (SELECT to_number(P2.DUI) ")
        strSQL.AppendLine(" FROM PARTICIPANTE P2 ")
        strSQL.AppendLine(" WHERE NVL(P2.DUI, 0) > 0 ")
        strSQL.AppendLine(" GROUP BY to_number(P2.DUI) ")
        strSQL.AppendLine(" HAVING COUNT(*) > 1) ")
        strSQL.AppendLine(" order by to_number(P1.DUI), P1.ID_PARTICIPANTE ")

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
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
    ''' Función que Devuelve Participantes Repetidos por NIT.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorNIT() As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(" SELECT * FROM PARTICIPANTE P1 ")
        strSQL.AppendLine(" WHERE to_number(P1.NIT) IN (SELECT to_number(P2.NIT) ")
        strSQL.AppendLine(" FROM PARTICIPANTE P2 ")
        strSQL.AppendLine(" WHERE NVL(P2.NIT, 0) > 0 ")
        strSQL.AppendLine(" GROUP BY to_number(P2.NIT) ")
        strSQL.AppendLine(" HAVING COUNT(*) > 1) ")
        strSQL.AppendLine(" order by to_number(P1.NIT), P1.ID_PARTICIPANTE ")

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
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

    Public Function CorregirDatosParticipante(ByVal aParticipante As PARTICIPANTES_REPETIDOS, ByVal aParticipanteEliminar As PARTICIPANTE) As Integer

        Dim strSQL As New StringBuilder
        Dim args(1) As OracleParameter
        Dim liRet As Integer

        'Actualizar la Inscripcion en Cursos del Participante

        strSQL.AppendLine(" UPDATE PARTICIPANTE_AF ")
        strSQL.AppendLine(" SET ID_PARTICIPANTE = :ID_NUEVO_PARTICIPANTE ")
        strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

        args(0) = New OracleParameter(":ID_NUEVO_PARTICIPANTE", OracleType.Number)
        args(0).Value = aParticipante.ID_PARTICIPANTE_NUEVO
        args(1) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(1).Value = aParticipante.ID_PARTICIPANTE

        Try
            liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Catch ex As Exception

            Dim listPARTICIPANTE_AF As New listaPARTICIPANTE_AF

            listPARTICIPANTE_AF = (New dbPARTICIPANTE_AF).ObtenerListaPorPARTICIPANTE(aParticipante.ID_PARTICIPANTE)

            For Each lPARTICIPANTE_AF As PARTICIPANTE_AF In listPARTICIPANTE_AF
                lPARTICIPANTE_AF.ID_PARTICIPANTE = aParticipante.ID_PARTICIPANTE_NUEVO
                If (New dbPARTICIPANTE_AF).Agregar(lPARTICIPANTE_AF) < 1 Then

                End If
            Next

            Dim listINFORME_FINAL_DET As New listaINFORME_FINAL_DET
            listINFORME_FINAL_DET = (New dbINFORME_FINAL_DET).ObtenerListaPorPARTICIPANTE(aParticipante.ID_PARTICIPANTE)

            For Each lINFORME_FINAL_DET As INFORME_FINAL_DET In listINFORME_FINAL_DET
                lINFORME_FINAL_DET.ID_INFORME_FINAL_DET = 0
                lINFORME_FINAL_DET.ID_PARTICIPANTE = aParticipante.ID_PARTICIPANTE_NUEVO
                lINFORME_FINAL_DET.NOTA_OBTENIDA = -1
                lINFORME_FINAL_DET.PORC_ASISTENCIA = -1
                lINFORME_FINAL_DET.MONTO_SOLICITADO = -1
                lINFORME_FINAL_DET.MONTO_APROBADO = -1
                If (New dbINFORME_FINAL_DET).Actualizar(lINFORME_FINAL_DET) < 1 Then

                End If
            Next

            'Sucedio porque hay mas de una solicitud para el mismo curso
            strSQL = New StringBuilder
            strSQL.AppendLine(" INSERT INTO PARTICIPANTE_AF_REPETIDOS ")
            strSQL.AppendLine(" SELECT * FROM PARTICIPANTE_AF ")
            strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

            ReDim args(0)
            args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
            args(0).Value = aParticipante.ID_PARTICIPANTE

            liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

            strSQL = New StringBuilder
            strSQL.AppendLine(" DELETE FROM INFORME_FINAL_DET ")
            strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

            liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

            strSQL = New StringBuilder
            strSQL.AppendLine(" DELETE FROM PARTICIPANTE_AF ")
            strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

            liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        End Try

        'Actualizar Asistencia del Participante
        strSQL = New StringBuilder()
        strSQL.AppendLine(" UPDATE ASISTENCIA_AF_DET ")
        strSQL.AppendLine(" SET ID_PARTICIPANTE = :ID_NUEVO_PARTICIPANTE ")
        strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

        ReDim args(1)
        args(0) = New OracleParameter(":ID_NUEVO_PARTICIPANTE", OracleType.Number)
        args(0).Value = aParticipante.ID_PARTICIPANTE_NUEVO
        args(1) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(1).Value = aParticipante.ID_PARTICIPANTE

        liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        'Actualizar Solicitudes del Participante

        strSQL = New StringBuilder()
        strSQL.AppendLine(" UPDATE SOLICITUD_INSCRIPCION_AF ")
        strSQL.AppendLine(" SET ID_PARTICIPANTE = :ID_NUEVO_PARTICIPANTE ")
        strSQL.AppendLine(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")

        ReDim args(1)
        args(0) = New OracleParameter(":ID_NUEVO_PARTICIPANTE", OracleType.Number)
        args(0).Value = aParticipante.ID_PARTICIPANTE_NUEVO
        args(1) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(1).Value = aParticipante.ID_PARTICIPANTE

        liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        'Insertar registro en Historico (PARTICIPANTES_REPETIDOS)
        strSQL = New StringBuilder()
        ReDim args(0)
        strSQL.Append(Me.QueryInsert(aParticipante, args))
        liRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        liRet = Me.Eliminar(aParticipanteEliminar)

        Return liRet

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por NOMBRES y APELLIDOS.
    ''' </summary>
    ''' <param name="NOMBRES_APELLIDOS"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS(ByVal NOMBRES_APELLIDOS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE NOMBRES || ' ' || APELLIDOS LIKE '%' || :NOMBRES_APELLIDOS || '%' ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":NOMBRES_APELLIDOS", OracleType.VarChar)
        args(0).Value = NOMBRES_APELLIDOS.Replace(" ", "%").ToUpper

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por NOMBRES, APELLIDOS y FECHA_NACIMIENTO.
    ''' </summary>
    ''' <param name="NOMBRES"></param>
    ''' <param name="APELLIDOS"></param>
    ''' <param name="FECHA_NACIMIENTO"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS_FECHANAC(ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As Date, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE REPLACE(NOMBRES,' ','') = :NOMBRES AND REPLACE(APELLIDOS,' ','') = :APELLIDOS AND FECHA_NACIMIENTO = :FECHA_NACIMIENTO ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":NOMBRES", OracleType.VarChar)
        args(0).Value = NOMBRES.Replace(" ", "")

        args(1) = New OracleParameter(":APELLIDOS", OracleType.VarChar)
        args(1).Value = APELLIDOS.Replace(" ", "")

        args(2) = New OracleParameter(":FECHA_NACIMIENTO", OracleType.DateTime)
        args(2).Value = FECHA_NACIMIENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As String, ByVal ID_PARTICIPANTE As Int32, ByVal DUI As String, ByVal NIT As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        Dim sCondicion As New StringBuilder

        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
       
        If NOMBRES <> "" Then
            arg = New OracleParameter(":NOMBRES", OracleType.VarChar)
            arg.Value = NOMBRES.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(sCondicion, "NOMBRES LIKE '%' || :NOMBRES || '%'")
        End If
        If APELLIDOS <> "" Then
            arg = New OracleParameter(":APELLIDOS", OracleType.VarChar)
            arg.Value = APELLIDOS.Replace(" ", "%")
            args.Add(arg)
            AgregarCondicion(sCondicion, "APELLIDOS LIKE '%' || :APELLIDOS || '%'")
        End If
        If FECHA_NACIMIENTO <> "" Then
            arg = New OracleParameter(":FECHA_NACIMIENTO", OracleType.DateTime)
            arg.Value = New DateTime(CInt(Right(FECHA_NACIMIENTO, 4)), CInt(FECHA_NACIMIENTO.Substring(3, 2)), CInt(Left(FECHA_NACIMIENTO, 2)))
            args.Add(arg)
            AgregarCondicion(sCondicion, "FECHA_NACIMIENTO = :FECHA_NACIMIENTO")
        End If
        If ID_PARTICIPANTE <> -1 Then
            arg = New OracleParameter(":ID_PARTICIPANTE", OracleType.Int32)
            arg.Value = ID_PARTICIPANTE
            args.Add(arg)
            AgregarCondicion(sCondicion, "ID_PARTICIPANTE = :ID_PARTICIPANTE")
        End If
        If DUI <> "" Then
            arg = New OracleParameter(":DUI", OracleType.VarChar)
            arg.Value = DUI
            args.Add(arg)
            AgregarCondicion(sCondicion, "DUI = :DUI")
        End If
        If NIT <> "" Then
            arg = New OracleParameter(":NIT", OracleType.VarChar)
            arg.Value = DUI
            args.Add(arg)
            AgregarCondicion(sCondicion, "NIT = :NIT")
        End If

        strSQL.Append(sCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por DUI.
    ''' </summary>
    ''' <param name="DUI"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDUI(ByVal DUI As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE DUI = :DUI ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":DUI", OracleType.VarChar)
        args(0).Value = DUI

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por NIT.
    ''' </summary>
    ''' <param name="NIT"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIT(ByVal NIT As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE NIT = :NIT ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":NIT", OracleType.VarChar)
        args(0).Value = NIT

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por DUI.
    ''' </summary>
    ''' <param name="DUI"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorExoneradoDocumentos(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE EXISTS(SELECT 1 FROM PARTICIPANTE_EXONERADO_DOC E WHERE E.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE)")
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <param name="mPARTICIPANTE"></param>
    ''' <param name="duplicadoPorFonetico"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParticipantesSemejantes(ByVal mPARTICIPANTE As PARTICIPANTE, ByRef duplicadoPorFonetico As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As New OracleParameter

        strSQL.Append("SELECT * FROM ")
        strSQL.Append("(SELECT PARTICIPANTE.*, SOUNDEX(REPLACE(NOMBRES,' ','')) AS CODIGO1, SOUNDEX(REPLACE(APELLIDOS,' ','')) AS CODIGO2 ")
        strSQL.Append("FROM PARTICIPANTE) ")

        If mPARTICIPANTE IsNot Nothing Then
            If mPARTICIPANTE.NOMBRES <> String.Empty Then
                Me.AgregarCondicion(strCondicion, "CODIGO1 = SOUNDEX(:NOMBRES)")
                arg = New OracleParameter(":NOMBRES", OracleType.VarChar)
                arg.Value = Replace(Utilerias.ReemplazarAcentos(mPARTICIPANTE.NOMBRES.Trim.ToUpper), " ", String.Empty)
                args.Add(arg)
            End If

            If mPARTICIPANTE.APELLIDOS <> String.Empty Then
                Me.AgregarCondicion(strCondicion, "CODIGO2 = SOUNDEX(:APELLIDOS)")
                arg = New OracleParameter(":APELLIDOS", OracleType.VarChar)
                arg.Value = Replace(Utilerias.ReemplazarAcentos(mPARTICIPANTE.APELLIDOS.Trim.ToUpper), " ", String.Empty)
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

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por NOMBRES y APELLIDOS.
    ''' </summary>
    ''' <param name="NOMBRES_APELLIDOS"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS_InscritosPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, ByVal NOMBRES_APELLIDOS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE))
        strSQL.Append(" WHERE NOMBRES || ' ' || APELLIDOS LIKE '%' || :NOMBRES_APELLIDOS || '%' ")
        strSQL.Append(" AND EXISTS(SELECT 1 FROM SOLICITUD_INSCRIPCION_AF S, ACCION_FORMATIVA A WHERE S.ID_ACCION_FORMATIVA = A.ID_ACCION_FORMATIVA AND S.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE AND A.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF) ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":NOMBRES_APELLIDOS", OracleType.VarChar)
        args(0).Value = NOMBRES_APELLIDOS.Replace(" ", "%").ToUpper

        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(1).Value = ID_PROVEEDOR_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE
                dbAsignarEntidades.AsignarPARTICIPANTE(dr, mEntidad)
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
