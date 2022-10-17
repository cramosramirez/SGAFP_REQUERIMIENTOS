Partial Public Class dbEVALUACION_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVAPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIO_EVALUACION As Date, ByVal FECHA_FIN_EVALUACION As Date, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACION_AF
        Dim lParametros As New List(Of OracleParameter)
        Dim lParametro As OracleParameter
        Dim strSQL As New StringBuilder
        Dim codicion As New StringBuilder
        strSQL.Append(Me.QuerySelect(New EVALUACION_AF))


        If ID_ACCION_FORMATIVA <> -1 Then
            lParametro = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            lParametro.Value = ID_ACCION_FORMATIVA
            lParametros.Add(lParametro)
            Me.AgregarCondicion(codicion, "ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")
        End If
        If FECHA_INICIO_EVALUACION <> #12:00:00 AM# AndAlso FECHA_FIN_EVALUACION <> #12:00:00 AM# Then
            lParametro = New OracleParameter(":FECHA_INICIO_EVALUACION", OracleType.DateTime)
            lParametro.Value = FECHA_INICIO_EVALUACION
            lParametros.Add(lParametro)

            lParametro = New OracleParameter(":FECHA_FIN_EVALUACION", OracleType.DateTime)
            lParametro.Value = FECHA_FIN_EVALUACION
            lParametros.Add(lParametro)
            Me.AgregarCondicion(codicion, "FECHA_EVALUACION >= :FECHA_INICIO_EVALUACION AND FECHA_EVALUACION <= :FECHA_FIN_EVALUACION")
        End If
        strSQL.Append(codicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader

        If lParametros.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), lParametros.ToArray)
        End If


        Dim lista As New listaEVALUACION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New EVALUACION_AF
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
