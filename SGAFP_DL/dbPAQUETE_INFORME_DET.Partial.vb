Partial Public Class dbPAQUETE_INFORME_DET

    Public Function ObtenerListaPorID_PAQUETE_CODIGO_ESTADO_AF(ByVal ID_PAQUETE As Decimal, ByVal ID_ESTADO_INFORME As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME_DET
        Dim strSQL As New StringBuilder
        strSQL.Append("select paquete_informe_det.* ")
        strSQL.Append("from paquete_informe_det, informe_final_af, accion_formativa ")
        strSQL.Append("where paquete_informe_det.id_informe_final = informe_final_af.id_informe_final ")
        strSQL.Append("and informe_final_af.id_accion_formativa = accion_formativa.id_accion_formativa ")

        Dim args As New List(Of OracleParameter)

        If ID_PAQUETE <> -1 Then
            Dim arg As New OracleParameter(":ID_PAQUETE", OracleType.Number)
            arg.Value = ID_PAQUETE
            args.Add(arg)

            strSQL.Append("and paquete_informe_det.id_paquete = :ID_PAQUETE ")
        End If
        If ID_ESTADO_INFORME <> -1 Then
            Dim arg As New OracleParameter(":ID_ESTADO_INFORME", OracleType.Number)
            arg.Value = ID_ESTADO_INFORME
            args.Add(arg)

            strSQL.Append("and informe_final_af.id_estado_informe = :ID_ESTADO_INFORME ")
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        Dim lista As New listaPAQUETE_INFORME_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New PAQUETE_INFORME_DET
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
                dbAsignarEntidades.AsignarPAQUETE_INFORME_DET(dr, mEntidad)
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
