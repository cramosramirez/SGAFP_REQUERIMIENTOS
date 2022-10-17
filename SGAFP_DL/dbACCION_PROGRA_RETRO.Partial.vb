Partial Public Class dbACCION_PROGRA_RETRO


    Public Function InhabilitarPorFechaExpiraACCION_PROGRA_RETRO() As Int32
        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim sCondicion As New StringBuilder
        strSQL.Append("UPDATE ACCION_PROGRA_RETRO SET ACTIVO = 0 WHERE FECHA_EXPIRA < TO_DATE(TO_CHAR(SYSDATE,'DD-MM-YYYY'),'DD-MM-YYYY')")

        Dim lRet As Int32 = 0

        lRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Try
            lRet = sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return lRet

    End Function


    Public Function ObtenerACCION_PROGRA_RETRO_PorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                            ByVal ID_EJERCICIO As String, _
                                                            ByVal CODIGO_GRUPO As String, _
                                                            ByVal CODIGO_ESTADO_AF_PROP As String, _
                                                            ByVal ACTIVO As Decimal) As listaACCION_PROGRA_RETRO

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim sCondicion As New StringBuilder
        strSQL.Append("SELECT * FROM ACCION_PROGRA_RETRO ")


        If ID_PROVEEDOR_AF <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter("ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
        End If

        If ID_EJERCICIO IsNot Nothing AndAlso ID_EJERCICIO <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter("ID_EJERCICIO", OracleType.Char)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "ID_EJERCICIO = :ID_EJERCICIO ")
        End If

        If CODIGO_GRUPO IsNot Nothing AndAlso CODIGO_GRUPO <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter("CODIGO_GRUPO", OracleType.VarChar)
            arg.Value = CODIGO_GRUPO.Trim.ToUpper
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "CODIGO_GRUPO = :CODIGO_GRUPO ")
        End If

        If CODIGO_ESTADO_AF_PROP IsNot Nothing AndAlso CODIGO_ESTADO_AF_PROP <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter("CODIGO_ESTADO_AF_PROP", OracleType.VarChar)
            arg.Value = CODIGO_ESTADO_AF_PROP
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "CODIGO_ESTADO_AF_PROP = :CODIGO_ESTADO_AF_PROP ")
        End If

        If ACTIVO <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter("ACTIVO", OracleType.Number)
            arg.Value = ACTIVO
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "ACTIVO = :ACTIVO ")
        End If
        strSQL.Append(sCondicion.ToString)

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaACCION_PROGRA_RETRO

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_PROGRA_RETRO
                dbAsignarEntidades.AsignarACCION_PROGRA_RETRO(dr, mEntidad)
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
