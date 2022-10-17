Partial Public Class dbINFORME_FINAL_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA">Indica la Acción Formativa a la que pertenece el Informe</param>
    ''' <param name="FECHA_REPORTADA">Indica la fecha que se encuentra en el período reportado del Informe</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[cramos]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_REPORTADA As Date) As entidadBase

        Dim strSQL As New StringBuilder
        Dim args(1) As OracleParameter
        Dim lEntidad As New INFORME_FINAL_AF

        Me.SelectTabla(strSQL)
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND :FECHA_REPORTADA BETWEEN FECHA_INICIAL AND FECHA_FINAL")

        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":FECHA_REPORTADA", OracleType.DateTime)
        args(1).Value = FECHA_REPORTADA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarINFORME_FINAL_AF(dr, lEntidad)
            Else
                lEntidad = Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lEntidad

    End Function


    Public Function EsInformeBolpros(ByVal ID_INFORME_FINAL As Decimal) As Boolean

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter
        Dim lEntidad As New INFORME_FINAL_AF
        Dim lRet As Boolean = False
        strSQL.Append("SELECT I.*  ")
        strSQL.Append("FROM INFORME_FINAL_AF I, GRUPO_ACCION_CONTRATADA G, ACCION_CONTRATADA AC, CONTRATO_BOLPROS C ")
        strSQL.Append("WHERE I.ID_ACCION_FORMATIVA = G.ID_ACCION_FORMATIVA ")
        strSQL.Append("AND G.ID_ACCION_CONTRATADA = AC.ID_ACCION_CONTRATADA ")
        strSQL.Append("AND AC.ID_CONTRATO = C.ID_CONTRATO ")
        strSQL.Append("AND C.ID_TIPO_CONTRA = 1 ")
        strSQL.Append("AND I.ID_INFORME_FINAL = :ID_INFORME_FINAL ")

        args(0) = New OracleParameter(":ID_INFORME_FINAL", OracleType.Number)
        args(0).Value = ID_INFORME_FINAL

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                lRet = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosPeriodo(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal listaID_ESTADO_INFORME As List(Of Decimal), _
                                                    ByVal listaID_PROGRAMA_FORMACION As List(Of Decimal), _
                                                    ByVal ID_CONTRATO As Decimal, _
                                                    ByVal NUM_LICITACION As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim aEntidad As entidadBase

        strSQL.AppendLine("SELECT INFORME_FINAL_AF.* ")
        strSQL.AppendLine("FROM INFORME_FINAL_AF ")
        strSQL.AppendLine("JOIN ACCION_FORMATIVA ON INFORME_FINAL_AF.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA ")

        If CODIGO_GRUPO Is Nothing Then CODIGO_GRUPO = "" Else CODIGO_GRUPO = CODIGO_GRUPO.ToUpper
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)
        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.TecnicoCentroHTP) Then
            If (Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor)) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
                AgregarCondicion(strSQLCondicion, " (ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION OR ACCION_FORMATIVA.ID_SITIO_CAPACITACION IS NULL) ")
                Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
                op.Value = ID_SITIO_CAPACITACION
                args.Add(op)
            Else
                If Not (Left(CODIGO_GRUPO, 4) = "PATI" OrElse Left(CODIGO_GRUPO, 6) = "PROESP" OrElse Left(CODIGO_GRUPO, 8) = "HTPMOVIL" OrElse Left(CODIGO_GRUPO, 9) = "HTPCENTRO") Then
                    AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
                    Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
                    op.Value = ID_SITIO_CAPACITACION
                    args.Add(op)
                End If
            End If
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.CODIGO_GRUPO = :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = CODIGO_GRUPO.ToUpper
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If
        If listaID_ESTADO_INFORME IsNot Nothing AndAlso listaID_ESTADO_INFORME.Count > 0 Then
            Dim strIN As New StringBuilder
            If listaID_ESTADO_INFORME.Count = 1 Then
                strIN.Append(" INFORME_FINAL_AF.ID_ESTADO_INFORME = :ID_ESTADO_INFORME ")
                Dim op As OracleParameter = New OracleParameter(":ID_ESTADO_INFORME", OracleType.Number)
                op.Value = listaID_ESTADO_INFORME(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaID_ESTADO_INFORME.Count - 1
                    If i = 0 Then
                        strIN.Append(" INFORME_FINAL_AF.ID_ESTADO_INFORME IN(") : strIN.Append(listaID_ESTADO_INFORME(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaID_ESTADO_INFORME(i).ToString)
                    End If
                Next
                strIN.Append(") ")
            End If
            AgregarCondicion(strSQLCondicion, strIN.ToString)
        End If
        If listaID_PROGRAMA_FORMACION IsNot Nothing AndAlso listaID_PROGRAMA_FORMACION.Count > 0 Then
            Dim strIN As New StringBuilder
            If listaID_PROGRAMA_FORMACION.Count = 1 Then
                strIN.Append(" EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION)  ")
                Dim op As OracleParameter = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
                op.Value = listaID_PROGRAMA_FORMACION(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaID_PROGRAMA_FORMACION.Count - 1
                    If i = 0 Then
                        strIN.Append(" EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND D.ID_PROGRAMA_FORMACION IN(") : strIN.Append(listaID_PROGRAMA_FORMACION(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaID_PROGRAMA_FORMACION(i).ToString)
                    End If
                Next
                strIN.Append(")) ")
            End If
            AgregarCondicion(strSQLCondicion, strIN.ToString)
        End If
        If ID_CONTRATO <> -1 Then
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND D.ID_CONTRATO = :ID_CONTRATO) ")
            Dim op As OracleParameter = New OracleParameter(":ID_CONTRATO", OracleType.Number)
            op.Value = ID_CONTRATO
            args.Add(op)
        End If
        If NUM_LICITACION <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE D, CONTRATO_PROVEEDOR_AF C WHERE D.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION AND D.ID_CONTRATO = C.ID_CONTRATO AND C.NUM_LICITACION = :NUM_LICITACION) ")
            Dim op As OracleParameter = New OracleParameter(":NUM_LICITACION", OracleType.VarChar)
            op.Value = NUM_LICITACION
            args.Add(op)
        End If
        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaINFORME_FINAL_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF
                AsignarINFORME_FINAL_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorInformeFacturar(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT I.* ")
        strSQL.Append("FROM INFORME_FINAL_AF I, ACCION_FORMATIVA E, ACCION_FORMATIVA_DETALLE D ")
        strSQL.Append("WHERE I.ID_ACCION_FORMATIVA = E.ID_ACCION_FORMATIVA AND E.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA ")
        strSQL.Append("AND I.ID_ESTADO_INFORME IN(" + Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor.ToString + "," _
                      + Enumeradores.EstadoInformeFinal.FacturaRecibida.ToString + "," _
                      + Enumeradores.EstadoInformeFinal.FacturaEnRevision.ToString + "," _
                      + Enumeradores.EstadoInformeFinal.FacturaObservada.ToString + ")")

        If ID_PROGRAMA_FORMACION <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
            arg.Value = ID_PROGRAMA_FORMACION
            args.Add(arg)
            strSQL.Append("AND D.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ")
        End If

        If ID_PROVEEDOR_AF <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
            strSQL.Append("AND E.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
        End If
        strSQL.Append("AND NOT EXISTS (SELECT 1 FROM FACTURA_AF FE, FACTURA_DET FD WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF AND FE.ESTADO <> 'A' AND FD.ID_INFORME_FINAL = I.ID_INFORME_FINAL) ")

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If


        Dim lista As New listaINFORME_FINAL_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF
                AsignarINFORME_FINAL_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por Número de Resolución.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorResolucion(ByVal RESOLUCION As String, Optional ByVal asColumnaOrden As String = "CODIGO_GRUPO", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NOMBRE AS MUNICIPIO, AF.ID_ACCION_FORMATIVA, I.ID_INFORME_FINAL AS ID_INFORME_FINAL, AF.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine("AF.CODIGO_GRUPO, I.FECHA_INICIAL, I.FECHA_FINAL, I.PARTICIPANTES_FINALES, AF.COSTO_X_PARTICIPANTE, I.MONTO_FACTURA,")
        strSQL.AppendLine("I.ID_ESTADO_INFORME, I.HORARIO, NVL(T.CORRELATIVO_GRUPO,-1) AS CORRELATIVO_GRUPO ")
        strSQL.AppendLine("FROM TERMINO_REFERENCIA_AF T, ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D, INFORME_FINAL_AF I, MUNICIPIO M ")
        strSQL.AppendLine("WHERE T.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.ID_ACCION_FORMATIVA = I.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND D.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("AND D.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO ")

        If RESOLUCION <> "" Then
            strSQL.AppendLine("AND TRIM(T.RESOLUCION) = :RESOLUCION ")
            Dim arg As OracleParameter = New OracleParameter(":RESOLUCION", OracleType.VarChar)
            arg.Value = RESOLUCION
            args.Add(arg)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim ds As DataSet

        If args.Count = 0 Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros ID_ACCION_FORMATIVA y ID_ESTADO_INFORME.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_INFORME As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM INFORME_FINAL_AF ")

        If ID_ACCION_FORMATIVA <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
            arg.Value = ID_ACCION_FORMATIVA
            args.Add(arg)
            AgregarCondicion(strCondicion, "INFORME_FINAL_AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")
        End If

        If ID_ESTADO_INFORME <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_ESTADO_INFORME", OracleType.Number)
            arg.Value = ID_ESTADO_INFORME
            args.Add(arg)
            AgregarCondicion(strCondicion, "INFORME_FINAL_AF.ID_ESTADO_INFORME = :ID_ESTADO_INFORME")
        End If

        strSQL.Append(strCondicion.ToString)

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If


        Dim lista As New listaINFORME_FINAL_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF
                AsignarINFORME_FINAL_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_CONTRATO"></param>
    ''' <param name="NUM_ITEM"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	29/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaFacturarContratoItemBolpros(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_CONTRATO As Decimal, ByVal NUM_ITEM As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT I.* FROM INFORME_FINAL_AF I ")
        strSQL.Append("WHERE EXISTS( ")
        strSQL.Append(" SELECT 1 FROM CONTRATO_BOLPROS C, ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA GA")
        strSQL.Append(" WHERE C.ID_CONTRATO = AC.ID_CONTRATO")
        strSQL.Append(" AND C.ID_TIPO_CONTRA = " + CStr(Enumeradores.TipoContratacion.BOLPROS))
        strSQL.Append(" AND AC.ID_ACCION_CONTRATADA = GA.ID_ACCION_CONTRATADA")
        strSQL.Append(" AND GA.ID_ACCION_FORMATIVA = I.ID_ACCION_FORMATIVA")
        strSQL.Append(" AND C.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION  AND C.ID_CONTRATO = :ID_CONTRATO AND AC.NUM_ITEM = :NUM_ITEM")
        strSQL.Append(" AND I.ID_ESTADO_INFORME = ")
        strSQL.Append(Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI.ToString)
        strSQL.Append(" )")
        strSQL.Append("AND NOT EXISTS (SELECT 1 FROM FACTURA_AF FE, FACTURA_DET FD WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF AND FE.ESTADO <> 'A' AND FD.ID_INFORME_FINAL = I.ID_INFORME_FINAL) ")

        arg = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        arg.Value = ID_PROGRAMA_FORMACION
        args.Add(arg)

        arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        arg.Value = ID_CONTRATO
        args.Add(arg)

        arg = New OracleParameter(":NUM_ITEM", OracleType.Number)
        arg.Value = NUM_ITEM
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If


        Dim lista As New listaINFORME_FINAL_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF
                AsignarINFORME_FINAL_AF(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim strSQL As New StringBuilder

        strSQL.Append("select i.* from informe_final_af i ")
        strSQL.Append("where  ")
        strSQL.Append(" (select count(1) from grupo_accion_contratada g, accion_contratada ac, contrato_bolpros cb ")
        strSQL.Append(" where g.id_accion_formativa = i.id_accion_formativa and g.id_accion_contratada = ac.id_accion_contratada and ac.id_contrato = cb.id_contrato ")
        strSQL.Append(" and cb.id_contrato_compra = :ID_CONTRATO_COMPRA ")
        strSQL.Append("  ) > 0 ")


        arg = New OracleParameter(":ID_CONTRATO_COMPRA", OracleType.Number)
        arg.Value = ID_CONTRATO_COMPRA
        args.Add(arg)

        If asColumnaOrden <> "" Then
            strSQL.Append("ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If


        Dim lista As New listaINFORME_FINAL_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF
                AsignarINFORME_FINAL_AF(dr, mEntidad)
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
