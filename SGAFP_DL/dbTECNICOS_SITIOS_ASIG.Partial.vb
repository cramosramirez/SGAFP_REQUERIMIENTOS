Partial Public Class dbTECNICOS_SITIOS_ASIG


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerLista(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaTECNICOS_SITIOS_ASIG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If
        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaTECNICOS_SITIOS_ASIG

        Try
            Do While dr.Read()
                Dim mEntidad As New TECNICOS_SITIOS_ASIG
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, mEntidad)
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
