Partial Public Class dbUNIDAD_ORGANIZATIVA

    Function ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As UNIDAD_ORGANIZATIVA
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT U.* ")
        strSQL.Append("FROM UNIDAD_ORGANIZATIVA U ")
        strSQL.Append("WHERE ( ")
        strSQL.Append("     SELECT COUNT(1) FROM ACCION_FORMATIVA AF, GRUPO_ACCION_CONTRATADA GA, GRUPO_SOLICITUD GS, SOLICITUD_CAPACITACION SC ")
        strSQL.Append("     WHERE AF.ID_ACCION_FORMATIVA = GA.ID_ACCION_FORMATIVA ")
        strSQL.Append("     AND GA.ID_GRUPO_AF = GS.ID_GRUPO_SOLICITUD ")
        strSQL.Append("     AND GS.ID_SOLICITUD = SC.ID_SOLICITUD ")
        strSQL.Append("     AND SC.ID_UNIDAD_ORGANIZATIVA = U.ID_UNIDAD_ORGANIZATIVA ")
        strSQL.Append("     AND AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.Append(" ) > 0 ")

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim mEntidad As New UNIDAD_ORGANIZATIVA

        Try
            If dr.HasRows Then
                dr.Read()
                dbAsignarEntidades.AsignarUNIDAD_ORGANIZATIVA(dr, mEntidad)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return mEntidad

    End Function

    Public Function ObtenerListaPorActivas(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaUNIDAD_ORGANIZATIVA

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM UNIDAD_ORGANIZATIVA WHERE ESTADO = 1")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaUNIDAD_ORGANIZATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New UNIDAD_ORGANIZATIVA
                dbAsignarEntidades.AsignarUNIDAD_ORGANIZATIVA(dr, mEntidad)
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
