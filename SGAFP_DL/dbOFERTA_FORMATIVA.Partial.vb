Imports System.Text
Imports System.Reflection

Partial Class dbOFERTA_FORMATIVA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro de la tabla OFERTA FORMATIVA para el Curso y 
    ''' el proveedor que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	11/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorTemaCurso(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal) As OFERTA_FORMATIVA
        Dim lEntidad As New OFERTA_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Double)
        args(0).Value = ID_PROVEEDOR_AF
        args(1) = New OracleParameter(":ID_TEMA_CURSO", OracleType.Double)
        args(1).Value = ID_TEMA_CURSO

        strSQL.Append(Me.QuerySelect(lEntidad))
        strSQL.AppendLine(" WHERE ID_TEMA_CURSO = :ID_TEMA_CURSO")
        strSQL.AppendLine(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF")
        strSQL.AppendLine(" AND ID_OFERTA_FORMATIVA = (SELECT MAX(ID_OFERTA_FORMATIVA) FROM OFERTA_FORMATIVA")
        strSQL.AppendLine("                             WHERE ID_TEMA_CURSO = :ID_TEMA_CURSO ")
        strSQL.AppendLine("                               AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF)")

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                Me.CargarEntidad(dr, CType(lEntidad, entidadBase))
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro de la tabla OFERTA FORMATIVA para el para el área de formación, proveedor y 
    ''' el ejercicio que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[cramos]	15/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorAreaFormacion_Proveedor_Sitio_Ejercicio(ByVal ID_AREA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, _
                                                                                    Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA
        Dim lEntidad As New OFERTA_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim args(4) As OracleParameter
        args(0) = New OracleParameter(":ID_AREA_FORMACION", OracleType.Double)
        args(0).Value = ID_AREA_FORMACION
        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Double)
        args(1).Value = ID_PROVEEDOR_AF
        args(2) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Double)
        args(2).Value = ID_SITIO_CAPACITACION
        args(3) = New OracleParameter(":ID_EJERCICIO", OracleType.Double)
        args(3).Value = ID_EJERCICIO

        strSQL.AppendLine("SELECT F.*, TEMA_CURSO FROM OFERTA_FORMATIVA F, CURSO_TEMA T, OFERTA_FORMATIVA_SITIO FS ")
        strSQL.AppendLine(" WHERE T.ID_AREA_FORMACION = :ID_AREA_FORMACION AND")
        strSQL.AppendLine(" F.ID_TEMA_CURSO = T.ID_TEMA_CURSO AND")
        strSQL.AppendLine(" F.ID_OFERTA_FORMATIVA = FS.ID_OFERTA_FORMATIVA AND")
        strSQL.AppendLine(" F.ESTADO = 'A' AND")
        strSQL.AppendLine(" FS.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF AND")
        strSQL.AppendLine(" FS.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION AND")
        strSQL.AppendLine(" FS.ID_EJERCICIO = :ID_EJERCICIO")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If


        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera registros de la tabla OFERTA FORMATIVA para el Curso y 
    ''' el proveedor que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	15/03/2010	Created
    ''' 	[ecarias]	24/06/2010	Se agrego para Recuperar detallar por Sitio de Capacitacion la Oferta
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorCriterios(ByVal aCriterios() As Criteria, Optional ByVal porSitio As Boolean = False) As listaOFERTA_FORMATIVA

        Dim lEntidad As New OFERTA_FORMATIVA

        Dim tipoEntidad As Type = lEntidad.GetType()

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If porSitio Then
            strSQL.AppendLine("SELECT DISTINCT F.*, T.TEMA_CURSO, P.NOMBRE_PROVEEDOR, S.NOMBRE_SITIO, D.NOMBRE AS NOMBRE_DEPARTAMENTO, M.NOMBRE AS NOMBRE_MUNICIPIO ")
            strSQL.AppendLine(" FROM OFERTA_FORMATIVA F, ")
            strSQL.AppendLine(" CURSO_TEMA T, ")
            strSQL.AppendLine(" PROVEEDOR_AF P, ")
            strSQL.AppendLine(" SITIO_CAPACITACION S, ")
            strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO OS, ")
            strSQL.AppendLine(" DEPARTAMENTO D, ")
            strSQL.AppendLine(" MUNICIPIO M ")
            strSQL.AppendLine(" WHERE F.ID_TEMA_CURSO = T.ID_TEMA_CURSO ")
            strSQL.AppendLine(" AND P.ID_PROVEEDOR_AF = F.ID_PROVEEDOR_AF ")
            strSQL.AppendLine(" AND F.ID_PROVEEDOR_AF = OS.ID_PROVEEDOR_AF ")
            strSQL.AppendLine(" AND F.ID_EJERCICIO = OS.ID_EJERCICIO ")
            strSQL.AppendLine(" AND F.ID_OFERTA_FORMATIVA = OS.ID_OFERTA_FORMATIVA ")
            strSQL.AppendLine(" AND OS.ID_SITIO_CAPACITACION = S.ID_SITIO_CAPACITACION ")
            strSQL.AppendLine(" AND S.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO ")
            strSQL.AppendLine(" AND S.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO ")
            strSQL.AppendLine(" AND D.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO ")
        Else
            strSQL.AppendLine("SELECT F.*, TEMA_CURSO, P.NOMBRE_PROVEEDOR ")
            strSQL.AppendLine(" FROM OFERTA_FORMATIVA F, ")
            strSQL.AppendLine(" CURSO_TEMA T, ")
            strSQL.AppendLine(" PROVEEDOR_AF P ")
            strSQL.AppendLine(" WHERE F.ID_TEMA_CURSO = T.ID_TEMA_CURSO ")
            strSQL.AppendLine(" AND P.ID_PROVEEDOR_AF = F.ID_PROVEEDOR_AF ")
        End If

        Dim countArgs As Integer = 0
        Dim strWhere As String = ""

        For Each lCriteria As Criteria In aCriterios

            If lCriteria.ColumnName = "ID_SITIO_CAPACITACION" Then
                Dim paramName As String
                paramName = "param" + countArgs.ToString()

                strWhere += " AND (OS.ID_SITIO_CAPACITACION = :" + paramName + " OR :" + paramName + " = -1)"

                countArgs += 1
                Dim i As Integer = 0
                If countArgs - 1 > 0 Then
                    Dim tempArgs As Object = args
                    ReDim args(countArgs - 1)
                    For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                        args(i) = CType(arg, OracleParameter)
                        i += 1
                    Next
                End If
                args(i) = New OracleParameter
                args(i).OracleType = Me.TipoParametro("System.Decimal")
                args(i).ParameterName = paramName
                args(i).Value = CDec(lCriteria.DataValue)
            ElseIf lCriteria.ColumnName = "CODIGO_DEPARTAMENTO" Then
                Dim paramName As String
                paramName = "param" + countArgs.ToString()

                strWhere += " AND M.CODIGO_DEPARTAMENTO = :" + paramName

                countArgs += 1
                Dim i As Integer = 0
                If countArgs - 1 > 0 Then
                    Dim tempArgs As Object = args
                    ReDim args(countArgs - 1)
                    For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                        args(i) = CType(arg, OracleParameter)
                        i += 1
                    Next
                End If
                args(i) = New OracleParameter
                args(i).OracleType = Me.TipoParametro("System.String")
                args(i).ParameterName = paramName
                args(i).Value = lCriteria.DataValue
            ElseIf lCriteria.ColumnName = "CODIGO_MUNICIPIO" Then
                Dim paramName As String
                paramName = "param" + countArgs.ToString()

                strWhere += " AND M.CODIGO_MUNICIPIO = :" + paramName

                countArgs += 1
                Dim i As Integer = 0
                If countArgs - 1 > 0 Then
                    Dim tempArgs As Object = args
                    ReDim args(countArgs - 1)
                    For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                        args(i) = CType(arg, OracleParameter)
                        i += 1
                    Next
                End If
                args(i) = New OracleParameter
                args(i).OracleType = Me.TipoParametro("System.String")
                args(i).ParameterName = paramName
                args(i).Value = lCriteria.DataValue
            Else
                Dim atributoColumna As ColumnAttribute
                Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(lCriteria.ColumnName)

                Dim paramName As String
                paramName = "param" + countArgs.ToString()

                atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadDestino, GetType(ColumnAttribute)), ColumnAttribute)

                If strWhere = "" Then
                    strWhere += " AND "
                Else
                    strWhere += " " + lCriteria.QueryOperator + " "
                End If

                If atributoColumna Is Nothing Then
                    Select Case lCriteria.Compare
                        Case "%*%", "*%", "%*"
                            strWhere += IIf(lCriteria.TableAlias <> "", lCriteria.TableAlias + ".", "").ToString() + lCriteria.ColumnName + " LIKE :" + paramName + " " + vbCrLf
                        Case Else
                            strWhere += IIf(lCriteria.TableAlias <> "", lCriteria.TableAlias + ".", "").ToString() + lCriteria.ColumnName + " " + lCriteria.Compare + " :" + paramName + " " + vbCrLf
                    End Select
                Else
                    Select Case lCriteria.Compare
                        Case "%*%", "*%", "%*"
                            strWhere += IIf(lCriteria.TableAlias <> "", lCriteria.TableAlias + ".", "").ToString() + atributoColumna.Storage + " LIKE :" + paramName + " " + vbCrLf
                        Case Else
                            strWhere += IIf(lCriteria.TableAlias <> "", lCriteria.TableAlias + ".", "").ToString() + atributoColumna.Storage + " " + lCriteria.Compare + " :" + paramName + " " + vbCrLf
                    End Select
                End If

                countArgs += 1
                Dim i As Integer = 0
                If countArgs - 1 > 0 Then
                    Dim tempArgs As Object = args
                    ReDim args(countArgs - 1)
                    For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                        args(i) = CType(arg, OracleParameter)
                        i += 1
                    Next
                End If
                args(i) = New OracleParameter
                args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                args(i).ParameterName = paramName
                Select Case lCriteria.Compare
                    Case "%*%"
                        args(i).Value = "%" + lCriteria.DataValue + "%"
                    Case "*%"
                        args(i).Value = lCriteria.DataValue + "%"
                    Case "%*"
                        args(i).Value = "%" + lCriteria.DataValue
                    Case Else
                        args(i).Value = lCriteria.DataValue
                End Select
            End If

        Next

        If strWhere <> "" Then
            strSQL.AppendLine(strWhere)
        End If

        Dim dr As OracleDataReader
        If aCriterios.Length > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaOFERTA_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA
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


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que obtiene la Oferta Formativa de acuerdo a los parámetros especificados
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	20/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativa(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_AREA_FROMACION As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("select p.nombre_proveedor, sc.nombre_sitio, a.area_formacion, ct.tema_curso, of1.duracion_horas, of1.costo_x_participante, dep.nombre as NOMBRE_DEPARTAMENTO, ")
        strSQL.Append("(select c.num_contrato from contrato_proveedor_af c where c.id_contrato = of1.id_contrato ) as CONTRATO ")
        strSQL.Append("from oferta_formativa of1, oferta_formativa_sitio of2, curso_tema ct, proveedor_af p, sitio_capacitacion sc, area_formacion a, departamento dep ")
        strSQL.Append("where of1.id_oferta_formativa = of2.id_oferta_formativa ")
        strSQL.Append("and ct.id_tema_curso = of1.id_tema_curso ")
        strSQL.Append("and of2.id_proveedor_af = sc.id_proveedor_af ")
        strSQL.Append("and of2.id_sitio_capacitacion = sc.id_sitio_capacitacion ")
        strSQL.Append("and p.id_proveedor_af = of1.id_proveedor_af ")
        strSQL.Append("and a.id_area_formacion = ct.id_area_formacion ")
        strSQL.Append("and sc.codigo_departamento = dep.codigo_departamento ")


        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.Append("and p.id_proveedor_af = :ID_PROVEEDOR_AF ")
            Dim arg As New OracleParameter("ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If

        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.Append("and sc.id_sitio_capacitacion = :ID_SITIO_CAPACITACION ")
            Dim arg As New OracleParameter("ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If

        If ID_EJERCICIO <> "" Then
            strSQL.Append("and of1.id_ejercicio = :ID_EJERCICIO ")
            Dim arg As New OracleParameter("ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
        End If

        If ID_AREA_FROMACION <> -1 Then
            strSQL.Append("and a.id_area_formacion = :ID_AREA_FORMACION ")
            Dim arg As New OracleParameter("ID_AREA_FORMACION", OracleType.Number)
            arg.Value = ID_AREA_FROMACION
            args.Add(arg)
        End If

        strSQL.Append("order by p.nombre_proveedor, sc.nombre_sitio, a.area_formacion, ct.tema_curso ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Return ds
    End Function


    Public Function ObtenerOfertaFormativaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_AREA_FORMACION As Decimal) As listaOFERTA_FORMATIVA
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("select f.*, ct.tema_curso ")
        strSQL.Append("from oferta_formativa f, curso_tema ct where f.id_tema_curso = ct.id_tema_curso ")

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.Append(" and f.id_proveedor_af = :ID_PROVEEDOR_AF")
            Dim arg As New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If

        If ID_EJERCICIO <> "" Then
            strSQL.Append(" and f.id_ejercicio = :ID_EJERCICIO")
            Dim arg As New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
        End If

        If ID_AREA_FORMACION <> -1 Then
            strSQL.Append(" and ct.id_area_formacion = :ID_AREA_FORMACION")
            Dim arg As New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            arg.Value = ID_AREA_FORMACION
            args.Add(arg)
        End If

        strSQL.Append(" order by ct.tema_curso ")

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaOFERTA_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA(dr, mEntidad)

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
