Partial Public Class dbCOMPRA_EX_PAGO_ASISTE

    Public Function ObtenerCOMPRA_EX_PAGO_ASISTE_PorCriterios(ByVal REFERENCIA As String, _
                                                            ByVal ID_TIPO_CONTRA As Decimal) As listaCOMPRA_EX_PAGO_ASISTE

        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        Dim sCondicion As New StringBuilder
        strSQL.Append("SELECT * FROM COMPRA_EX_PAGO_ASISTE ")


        If REFERENCIA IsNot Nothing AndAlso REFERENCIA <> "" Then
            Dim arg As OracleParameter
            arg = New OracleParameter("REFERENCIA", OracleType.VarChar)
            arg.Value = REFERENCIA
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "REFERENCIA = :REFERENCIA ")
        End If

        If ID_TIPO_CONTRA <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter("ID_TIPO_CONTRA", OracleType.Number)
            arg.Value = ID_TIPO_CONTRA
            args.Add(arg)
            Me.AgregarCondicion(sCondicion, "ID_TIPO_CONTRA = :ID_TIPO_CONTRA ")
        End If

        strSQL.Append(sCondicion.ToString)

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Dim lista As New listaCOMPRA_EX_PAGO_ASISTE

        Try
            Do While dr.Read()
                Dim mEntidad As New COMPRA_EX_PAGO_ASISTE
                dbAsignarEntidades.AsignarCOMPRA_EX_PAGO_ASISTE(dr, mEntidad)
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
