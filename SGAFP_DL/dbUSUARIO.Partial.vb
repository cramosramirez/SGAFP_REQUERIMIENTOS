
Partial Public Class dbUSUARIO

    Public Sub New()

    End Sub

    Public Sub New(ByVal aConnectionStringName As String)
        ConnectionStringName = aConnectionStringName
    End Sub

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
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal USUARIOS As List(Of String), _
                                             Optional ByVal asColumnaOrden As String = "USUARIO", _
                                             Optional ByVal asTipoOrden As String = "ASC") As listaUSUARIO
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New USUARIO))


        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        If ID_PROVEEDOR_AF <> -1 Then
            If strSQL.ToString.Contains("WHERE") Then strSQL.Append(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF") Else strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            arg = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If

        If ID_SITIO_CAPACITACION <> -1 Then
            If strSQL.ToString.Contains("WHERE") Then strSQL.Append(" AND ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION") Else strSQL.Append(" WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            arg = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If

        Dim i As Integer = 0
        If USUARIOS.Count > 0 Then
            If strSQL.ToString.Contains("WHERE") Then strSQL.Append(" AND ( USUARIO = :USUARIO" + i.ToString) Else strSQL.Append(" WHERE ( USUARIO = :USUARIO" + i.ToString)

            arg = New OracleParameter(":USUARIO" + i.ToString, OracleType.VarChar)
            arg.Value = USUARIOS(i)
            args.Add(arg)

            If USUARIOS.Count > 1 Then
                For i = 1 To USUARIOS.Count - 1
                    strSQL.Append(" OR USUARIO = :USUARIO" + i.ToString)
                    arg = New OracleParameter(":USUARIO" + i.ToString, OracleType.VarChar)
                    arg.Value = USUARIOS(i)
                    args.Add(arg)
                Next
            End If
            strSQL.Append(" ) ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaUSUARIO

        Try
            Do While dr.Read()
                Dim mEntidad As New USUARIO
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
