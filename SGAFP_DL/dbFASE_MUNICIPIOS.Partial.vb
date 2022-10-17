Partial Public Class dbFASE_MUNICIPIOS


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="ID_FASE"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(ByVal ID_FUENTE As Decimal, _
                                                            ByVal ID_FASE As Decimal, _
                                                            ByVal CODIGO_REGION As String, _
                                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                                            Optional ByVal asColumnaOrden As String = "FASE_MUNICIPIOS.ID_FUENTE", _
                                                            Optional ByVal asTipoOrden As String = "ASC") As listaFASE_MUNICIPIOS

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim addPrimeraCondicion As Boolean = False
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT FASE_MUNICIPIOS.* ")
        strSQL.Append("FROM FASE_MUNICIPIOS ")

        If ID_FUENTE <> -1 OrElse ID_FASE <> -1 OrElse CODIGO_REGION <> "" OrElse CODIGO_DEPARTAMENTO <> "" Then
            strSQL.Append("WHERE ")
        End If

        If ID_FUENTE <> -1 Then
            Dim arg As New OracleParameter(":ID_FUENTE", OracleType.Number)
            arg.Value = ID_FUENTE
            args.Add(arg)
            If Not addPrimeraCondicion Then strSQL.Append("ID_FUENTE = :ID_FUENTE") Else strSQL.Append(" AND ID_FUENTE = :ID_FUENTE")
            addPrimeraCondicion = True
        End If

        If ID_FASE <> -1 Then
            Dim arg As New OracleParameter(":ID_FASE", OracleType.Number)
            arg.Value = ID_FASE
            args.Add(arg)
            If Not addPrimeraCondicion Then strSQL.Append("ID_FASE = :ID_FASE") Else strSQL.Append(" AND ID_FASE = :ID_FASE")
            addPrimeraCondicion = True
        End If

        If CODIGO_REGION <> "" Then
            Dim arg As New OracleParameter(":CODIGO_REGION", OracleType.VarChar)
            arg.Value = CODIGO_REGION
            args.Add(arg)
            If Not addPrimeraCondicion Then strSQL.Append("CODIGO_REGION = :CODIGO_REGION") Else strSQL.Append(" AND CODIGO_REGION = :CODIGO_REGION")
            addPrimeraCondicion = True
        End If

        If CODIGO_DEPARTAMENTO <> "" Then
            Dim arg As New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
            If Not addPrimeraCondicion Then strSQL.Append("CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO") Else strSQL.Append(" AND CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO")
            addPrimeraCondicion = True
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaFASE_MUNICIPIOS

        Try
            Do While dr.Read()
                Dim mEntidad As New FASE_MUNICIPIOS
                dbAsignarEntidades.AsignarFASE_MUNICIPIOS(dr, mEntidad)
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
