﻿Partial Public Class dbCONTRATO_SUB_AREA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista de Sub Areas por Contrato filtrada por criterios.
    ''' </summary>
    ''' <param name="ID_CONTRATO">Id del Proveedor del registro seleccionado.</param>    
    ''' <param name="CODIGO_GRUPO">Código de Grupo de la Acción Formativa perteneciente al Contrato.</param>
    ''' <param name="ID_EJERCICIO_AF">Id del Ejercicio de las Acciones Formativas pertenecientes al Contrato.</param>
    ''' <history>
    ''' 	[cramos]	09/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_CONTRATO As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO_AF As String) As listaCONTRATO_SUB_AREA_FORMACION
        Dim lista As New listaCONTRATO_SUB_AREA_FORMACION
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim strSubCondicion As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As New OracleParameter
        Dim lEntidad As New CONTRATO_SUB_AREA_FORMACION

        strSQL.Append(Me.QuerySelect(lEntidad))

        If ID_CONTRATO <> -1 Then
            arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
            arg.Value = ID_CONTRATO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, " CONTRATO_SUB_AREA_FORMACION.ID_CONTRATO = :ID_CONTRATO ")
        End If
        If CODIGO_GRUPO <> "" OrElse ID_EJERCICIO_AF <> "" Then
            strSubCondicion.Append(" EXISTS (SELECT 1 FROM ACCION_FORMATIVA AF, OFERTA_FORMATIVA OFE, CURSO_TEMA CT WHERE ")
            If CODIGO_GRUPO <> "" Then
                arg = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
                arg.Value = CODIGO_GRUPO
                args.Add(arg)
                strSubCondicion.Append("AF.CODIGO_GRUPO = :CODIGO_GRUPO AND ")
            End If
            If ID_EJERCICIO_AF <> "" Then
                arg = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
                arg.Value = ID_EJERCICIO_AF
                args.Add(arg)
                strSubCondicion.Append("AF.ID_EJERCICIO = :ID_EJERCICIO AND ")
            End If

            strSubCondicion.Append("AF.ID_OFERTA_FORMATIVA = OFE.ID_OFERTA_FORMATIVA AND ")
            strSubCondicion.Append("OFE.ID_TEMA_CURSO = CT.ID_TEMA_CURSO AND ")
            strSubCondicion.Append("CT.ID_SUBAREA_FORMACION = CONTRATO_SUB_AREA_FORMACION.ID_SUBAREA_FORMACION AND ")
            strSubCondicion.Append("OFE.ID_CONTRATO = CONTRATO_SUB_AREA_FORMACION.ID_CONTRATO) ")
            Me.AgregarCondicion(strCondicion, strSubCondicion.ToString)
        End If
        strSQL.Append(strCondicion.ToString)

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            While dr.Read()
                lEntidad = New CONTRATO_SUB_AREA_FORMACION
                dbAsignarEntidades.AsignarCONTRATO_SUB_AREA_FORMACION(dr, lEntidad)
                lista.Add(lEntidad)
            End While

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto En Devengamiento en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoEnDevengamiento(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Decimal
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder


        strSQL.AppendLine("SELECT NVL(SUM(INF.MONTO_FACTURA),0) AS EJECUTADO ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D, INFORME_FINAL_AF INF, CURSO_TEMA CT  ")
        strSQL.AppendLine("WHERE AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_TEMA_CURSO = CT.ID_TEMA_CURSO ")
        strSQL.AppendLine("WHERE INF.ID_ESTADO_INFORME IN(")
        strSQL.Append(Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI) : strSQL.Append(",")
        strSQL.Append(Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor) : strSQL.Append(",")
        strSQL.Append(Enumeradores.EstadoInformeFinal.EnTramiteDePago) : strSQL.Append("') ")
        strSQL.AppendLine("AND NOT EXISTS(SELECT 1 FROM FACTURA_AF FE, FACTURA_DET FD WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF ")
        strSQL.AppendLine("AND FE.NUMERO_QUEDAN IS NOT NULL AND FE.ESTADO = 'P' ")
        strSQL.AppendLine("AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL) ")
        strSQL.AppendLine("AND CT.ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION ")
        strSQL.AppendLine("AND D.ID_CONTRATO = :ID_CONTRATO ")

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        arg = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
        arg.Value = ID_SUBAREA_FORMACION
        args.Add(arg)

        Return CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

    End Function
End Class
