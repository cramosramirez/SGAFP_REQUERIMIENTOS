Partial Public Class dbPAIS
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorEjercicioProveedorSitio(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaPAIS
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("select p.* ")
        strSQL.AppendLine("from pais p ")
        strSQL.AppendLine("where exists( ")
        strSQL.AppendLine(" select 1 ")
        strSQL.AppendLine(" from accion_formativa af, solicitud_inscripcion_af s ")
        strSQL.AppendLine(" where af.id_accion_formativa = s.id_accion_formativa ")
        strSQL.AppendLine(" and s.id_pais = p.id_pais ")
        strSQL.AppendLine(" and s.id_estado_solicitud in(3,4) ")
        strSQL.AppendLine(" and s.id_pais = p.id_pais ")

        If ID_EJERCICIO <> "" Then
            strSQL.AppendLine(" and af.id_ejercicio = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If
        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine(" and af.id_proveedor_af = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.AppendLine(" and af.id_sitio_capacitacion = :ID_SITIO_CAPACITACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        strSQL.AppendLine(") ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listaPAIS

        Try
            Do While dr.Read()
                Dim mEntidad As New PAIS
                dbAsignarEntidades.AsignarPAIS(dr, mEntidad)
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
