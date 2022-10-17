Partial Public Class dbFACTURA_AF


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por parámetros la Tabla FACTURA_AF.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="NIT"></param>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <param name="FECHA_DOCUMENTO"></param>
    ''' <param name="RESOLUCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NIT As String, ByVal NUMERO_DOCUMENTO As String, ByVal FECHA_DOCUMENTO As Object, ByVal RESOLUCION As String, ByVal CODIGO_GRUPO As String, ByVal ID_INFORME_FINAL As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder

        strSQL.AppendLine("SELECT FE.ID_FACTURA_AF, ")
        strSQL.AppendLine("(SELECT MIN(TDR.RESOLUCION) ")
        strSQL.AppendLine("      FROM TERMINO_REFERENCIA_AF TDR, FACTURA_DET FD, INFORME_FINAL_AF INF ")
        strSQL.AppendLine("      WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF ")
        strSQL.AppendLine("      AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
        strSQL.AppendLine("      AND INF.ID_ACCION_FORMATIVA = TDR.ID_ACCION_FORMATIVA) AS RESOLUCION, ")
        strSQL.AppendLine("P.NOMBRE_PROVEEDOR, FE.NUMERO_DOCUMENTO, DECODE(FE.TIPO_DOCUMENTO,'1','FACTURA','RECIBO','') AS TIPO_DOCUMENTO, FE.FECHA_DOCUMENTO, ")
        strSQL.AppendLine("FE.ESTADO, DECODE(FE.ESTADO,'E','EMITIDA','P','APROBADA','A','ANULADA','') AS NOMBRE_ESTADO, ")
        strSQL.AppendLine("(SELECT SUM(INF.MONTO_FACTURA) FROM FACTURA_DET FD, INFORME_FINAL_AF INF WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL) AS MONTO, ")
        strSQL.AppendLine("FE.NUMERO_QUEDAN, FE.NUMERO_CHEQUE ")
        strSQL.AppendLine("FROM FACTURA_AF FE, PROVEEDOR_AF P ")
        strSQL.AppendLine("WHERE FE.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine("AND P.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If NIT <> "" Then
            strSQL.AppendLine("AND P.NIT = :NIT ")
            Dim arg As OracleParameter = New OracleParameter(":NIT", OracleType.VarChar)
            arg.Value = NIT
            args.Add(arg)
        End If
        If NUMERO_DOCUMENTO <> "" Then
            strSQL.AppendLine("AND TRIM(FE.NUMERO_DOCUMENTO) = :NUMERO_DOCUMENTO ")
            Dim arg As OracleParameter = New OracleParameter(":NUMERO_DOCUMENTO", OracleType.VarChar)
            arg.Value = NUMERO_DOCUMENTO
            args.Add(arg)
        End If
        If FECHA_DOCUMENTO IsNot Nothing Then
            strSQL.AppendLine("AND FE.FECHA_DOCUMENTO = :FECHA_DOCUMENTO ")
            Dim arg As OracleParameter = New OracleParameter(":FECHA_DOCUMENTO", OracleType.DateTime)
            arg.Value = DateTime.Parse(FECHA_DOCUMENTO.ToString, New System.Globalization.CultureInfo("fr-FR", False))
            args.Add(arg)
        End If
        If RESOLUCION <> "" Then
            If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_BM OrElse ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_USAID OrElse ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_2 Then
                strSQL.AppendLine("AND EXISTS(SELECT 1 ")
                strSQL.AppendLine("      FROM TERMINO_REFERENCIA_AF TDR, FACTURA_DET FD, INFORME_FINAL_AF INF ")
                strSQL.AppendLine("      WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF ")
                strSQL.AppendLine("      AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
                strSQL.AppendLine("      AND INF.ID_ACCION_FORMATIVA = TDR.ID_ACCION_FORMATIVA ")
                strSQL.AppendLine("      AND TRIM(TDR.RESOLUCION) = :RESOLUCION) ")
                Dim arg As OracleParameter = New OracleParameter(":RESOLUCION", OracleType.VarChar)
                arg.Value = RESOLUCION
                args.Add(arg)
            End If
        End If
        If CODIGO_GRUPO <> "" Then
            strSQL.AppendLine("AND EXISTS(SELECT 1 ")
            strSQL.AppendLine("      FROM ACCION_FORMATIVA AF, FACTURA_DET FD, INFORME_FINAL_AF INF ")
            strSQL.AppendLine("      WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF ")
            strSQL.AppendLine("      AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
            strSQL.AppendLine("      AND INF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
            strSQL.AppendLine("      AND AF.CODIGO_GRUPO = :CODIGO_GRUPO) ")
            Dim arg As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            arg.Value = CODIGO_GRUPO
            args.Add(arg)
        End If
        If ID_INFORME_FINAL <> -1 Then
            strSQL.AppendLine("AND EXISTS(SELECT 1 ")
            strSQL.AppendLine("      FROM FACTURA_DET FD ")
            strSQL.AppendLine("      WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF ")
            strSQL.AppendLine("      AND FD.ID_INFORME_FINAL = :ID_INFORME_FINAL) ")
            Dim arg As OracleParameter = New OracleParameter(":ID_INFORME_FINAL", OracleType.Number)
            arg.Value = ID_INFORME_FINAL
            args.Add(arg)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            strSQL.AppendLine("AND EXISTS(SELECT 1 ")
            strSQL.AppendLine("      FROM FACTURA_DET FD, INFORME_FINAL_AF INF, ACCION_FORMATIVA_DETALLE AD ")
            strSQL.AppendLine("      WHERE FD.ID_FACTURA_AF = FE.ID_FACTURA_AF ")
            strSQL.AppendLine("      AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
            strSQL.AppendLine("      AND INF.ID_ACCION_FORMATIVA = AD.ID_ACCION_FORMATIVA ")
            strSQL.AppendLine("      AND AD.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION) ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            arg.Value = ID_PROGRAMA_FORMACION
            args.Add(arg)
        End If

        Dim ds As DataSet

        If args.Count > 0 Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If
        Return ds

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una lista de Entidades filtrado por parámetros.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <param name="FECHA_DOCUMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/04/2012	Created
    ''' 	[cramos]	11/09/2012	Modificado, Se reemplaza parámetro ID_TIPO_SOLICITUD por ID_PROGRAMA_FORMACION
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NUMERO_DOCUMENTO As String, ByVal FECHA_DOCUMENTO As Object) As listaFACTURA_AF
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder

        strSQL.AppendLine("SELECT DISTINCT FE.* ")
        strSQL.AppendLine("FROM FACTURA_AF FE, FACTURA_DET FD, INFORME_FINAL_AF INF, ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D, PROVEEDOR_AF P ")
        strSQL.AppendLine("WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF ")
        strSQL.AppendLine("AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL ")
        strSQL.AppendLine("AND INF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_PROVEEDOR_AF = P.ID_PROVEEDOR_AF ")

        If NUMERO_DOCUMENTO <> "" Then
            strSQL.AppendLine("AND TRIM(FE.NUMERO_DOCUMENTO) = :NUMERO_DOCUMENTO ")
            Dim arg As OracleParameter = New OracleParameter(":NUMERO_DOCUMENTO", OracleType.VarChar)
            arg.Value = NUMERO_DOCUMENTO
            args.Add(arg)
        End If
        If FECHA_DOCUMENTO IsNot Nothing AndAlso IsDate(FECHA_DOCUMENTO) Then
            strSQL.AppendLine("AND FE.FECHA_DOCUMENTO = :FECHA_DOCUMENTO ")
            Dim arg As OracleParameter = New OracleParameter(":FECHA_DOCUMENTO", OracleType.DateTime)
            arg.Value = FECHA_DOCUMENTO
            args.Add(arg)
        End If
        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine("AND P.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If
        If ID_PROGRAMA_FORMACION <> -1 Then
            strSQL.AppendLine("AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
            Dim arg As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            arg.Value = ID_PROGRAMA_FORMACION
            args.Add(arg)
        End If

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaFACTURA_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New FACTURA_AF
                dbAsignarEntidades.AsignarFACTURA_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function ObtenerContratoProveedor(ByVal ID_FACTURA_AF As Decimal) As CONTRATO_PROVEEDOR_AF
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder

        strSQL.AppendLine("SELECT * ")
        strSQL.AppendLine("FROM CONTRATO_PROVEEDOR_AF C ")
        strSQL.AppendLine("WHERE EXISTS(SELECT 1 FROM FACTURA_DET D, INFORME_FINAL_AF I, ACCION_FORMATIVA_DETALLE AFD  ")
        strSQL.AppendLine("             WHERE D.ID_FACTURA_AF = :ID_FACTURA_AF AND D.ID_INFORME_FINAL = I.ID_INFORME_FINAL AND I.ID_ACCION_FORMATIVA = AFD.ID_ACCION_FORMATIVA AND AFD.ID_CONTRATO = C.ID_CONTRATO ")
        strSQL.AppendLine("             ) ")


        Dim arg As OracleParameter = New OracleParameter(":ID_FACTURA_AF", OracleType.Int32)
        arg.Value = ID_FACTURA_AF
        args.Add(arg)
        
        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim mEntidad As New CONTRATO_PROVEEDOR_AF

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCONTRATO_PROVEEDOR_AF(dr, mEntidad)
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
