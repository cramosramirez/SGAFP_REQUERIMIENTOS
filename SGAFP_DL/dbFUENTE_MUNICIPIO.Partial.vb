Partial Public Class dbFUENTE_MUNICIPIO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorFUENTE_FINANCIAMIENTO_CONV_DEPARTAMENTO(ByVal ID_FUENTE As Decimal, _
                                                            ByVal NO_CONVOCATORIA As Decimal, _
                                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                                            ByVal CODIGO_MUNICIPIO As String) As FUENTE_MUNICIPIO

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT FUENTE_MUNICIPIO.* ")
        strSQL.Append("FROM FUENTE_MUNICIPIO ")

        If ID_FUENTE <> -1 Then
            Dim arg As New OracleParameter(":ID_FUENTE", OracleType.Number)
            arg.Value = ID_FUENTE
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, " ID_FUENTE = :ID_FUENTE ")
        End If

        If NO_CONVOCATORIA <> -1 Then
            Dim arg As New OracleParameter(":NO_CONVOCATORIA", OracleType.Number)
            arg.Value = NO_CONVOCATORIA
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, " NO_CONVOCATORIA = :NO_CONVOCATORIA ")
        End If

        If CODIGO_DEPARTAMENTO <> "" Then
            Dim arg As New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
            arg.Value = CODIGO_DEPARTAMENTO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, " CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ")
        End If

        If CODIGO_MUNICIPIO <> "" Then
            Dim arg As New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
            arg.Value = CODIGO_MUNICIPIO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, " CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ")
        End If
        If strCondicion.Length > 0 Then strSQL.AppendLine(strCondicion.ToString)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New FUENTE_MUNICIPIO

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarFUENTE_MUNICIPIO(dr, mEntidad)
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
End Class
