Imports System.Text
Imports System.Reflection

Partial Public Class dbCONTRATO_COMPRA

    Public Function ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As CONTRATO_COMPRA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine("SELECT F.* ")
        strSQL.AppendLine("FROM CONTRATO_COMPRA F ")
        strSQL.AppendLine("WHERE (SELECT COUNT(1) FROM CONTRATO_BOLPROS C,  ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA G WHERE F.ID_CONTRATO_COMPRA = C.ID_CONTRATO_COMPRA AND AC.ID_CONTRATO = C.ID_CONTRATO AND AC.ID_ACCION_CONTRATADA = G.ID_ACCION_CONTRATADA AND G.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA) > 0 ")

        Dim op As OracleParameter = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        op.Value = ID_ACCION_FORMATIVA
        args.Add(op)

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())

        Dim mEntidad As New CONTRATO_COMPRA

        Try
            If dr.Read() Then
                AsignarCONTRATO_COMPRA(dr, mEntidad)
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

    Public Function ObtenerListaPorNO_CONTRATO_COMPRA(ByVal NO_CONTRATO_COMPRA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_COMPRA
        Dim strSQL As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.AppendLine(" SELECT * FROM CONTRATO_COMPRA ")
        strSQL.AppendLine("WHERE NO_CONTRATO_COMPRA = :NO_CONTRATO_COMPRA ")

        Dim op As OracleParameter = New OracleParameter(":NO_CONTRATO_COMPRA", OracleType.VarChar)
        op.Value = NO_CONTRATO_COMPRA
        args.Add(op)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaCONTRATO_COMPRA

        Try
            Do While dr.Read()
                Dim mEntidad As New CONTRATO_COMPRA
                dbAsignarEntidades.AsignarCONTRATO_COMPRA(dr, mEntidad)
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
