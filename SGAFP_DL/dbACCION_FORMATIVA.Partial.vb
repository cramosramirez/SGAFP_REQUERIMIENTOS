Imports System.Text
Imports System.Reflection


Partial Class dbACCION_FORMATIVA


    Public Function ObtenerCorrelativoCodigoEC(ByVal CODIGO_GRUPO As String) As Decimal

        Dim strSQL As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim lRet As Decimal = 1

        strSQL.Append("select max(to_number( nvl(replace(codigo_grupo,'" + CODIGO_GRUPO + "',''),0) )) + 1 from accion_formativa where codigo_grupo like '" + CODIGO_GRUPO + "%' ")

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If dr Is Nothing Then Return 1

        Try
            If dr.Read() Then
                If IsDBNull(dr(0)) Then
                    lRet = 1
                Else
                    lRet = CDec(dr(0))
                End If
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lRet

    End Function


    Public Function ObtenerPorcentajeAvancePorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As Dictionary(Of String, Decimal)
        Dim dicc As Dictionary(Of String, Decimal)
        Dim strSQL As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim lRet As Decimal = 1

        strSQL.Append("SELECT ")
        strSQL.Append("     ROUND((MINUTOS_EJECUTADOS/DURACION_MINUTOS) *100,2) AS PORCENTAJE_EJECUCION, MINUTOS_EJECUTADOS ")
        strSQL.Append("FROM (   ")
        strSQL.Append("     SELECT  AF.DURACION_HORAS * 60 AS DURACION_MINUTOS, ")
        strSQL.Append("         NVL( ")
        strSQL.Append("         (        SELECT SUM(CANTIDAD_HORAS) ")
        strSQL.Append("                  FROM ASISTENCIA_AF A ")
        strSQL.Append("                  WHERE A.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.Append("                  AND A.FECHA <= :FECHA ")
        strSQL.Append("         )        , 0) AS MINUTOS_EJECUTADOS ")
        strSQL.Append("     FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE D ")
        'strSQL.Append("     WHERE AF.FECHA_FIN_REAL > :FECHA AND AF.CODIGO_ESTADO_AF <> '04' AND AF.ID_EJERCICIO IN('2019','2020') AND ")
        strSQL.Append("     WHERE AF.FECHA_FIN_REAL > :FECHA AND AF.ID_EJERCICIO IN('2019','2020') AND ")
        strSQL.Append("     AF.ID_ACCION_FORMATIVA = D.ID_ACCION_FORMATIVA AND ")
        strSQL.Append("     AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.Append("    ) T ")

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        arg = New OracleParameter(":FECHA", OracleType.DateTime)
        arg.Value = FECHA
        args.Add(arg)

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                If IsDBNull(dr(0)) Then
                    dicc = Nothing
                Else
                    dicc = New Dictionary(Of String, Decimal)
                    dicc.Add("PORCENTAJE_EJECUCION", CDec(dr(0)))
                    dicc.Add("MINUTOS_EJECUCION", CDec(dr(1)))
                End If
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return dicc

    End Function



    Public Function ObtenerMontoCapacitacionHTP(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_EJERCICIO As String) As Dictionary(Of String, Decimal)

        Dim strSQL As New StringBuilder
        Dim args(1) As OracleParameter
        Dim lEntidad As New INFORME_FINAL_AF
        Dim lRet As Decimal = 0
        Dim diccMontoCant As Dictionary(Of String, Decimal)

        strSQL.Append("SELECT COSTO_TOTAL_PARTICIPANTE, CANT_CURSOS  ")
        strSQL.Append("FROM (  ")
        strSQL.Append("  SELECT SUM( AF.COSTO_X_PARTICIPANTE) AS COSTO_TOTAL_PARTICIPANTE, COUNT(P.ID_PARTICIPANTE) AS CANT_CURSOS  ")
        strSQL.Append("  FROM ACCION_FORMATIVA AF, PARTICIPANTE P, PARTICIPANTE_AF PAF, SOLICITUD_INSCRIPCION_AF S, PROVEEDOR_AF V, ACCION_FORMATIVA_DETALLE AD  ")
        strSQL.Append("  WHERE AF.ID_ACCION_FORMATIVA = S.ID_ACCION_FORMATIVA AND S.ID_PARTICIPANTE = P.ID_PARTICIPANTE")
        strSQL.Append("  AND PAF.ID_SOLICITUD = S.ID_SOLICITUD  ")
        strSQL.Append("  AND AF.ID_PROVEEDOR_AF = V.ID_PROVEEDOR_AF  ")
        strSQL.Append("  AND AF.ID_EJERCICIO = :ID_EJERCICIO  ")
        strSQL.Append("  AND PAF.ID_PARTICIPANTE = :ID_PARTICIPANTE  ")
        strSQL.Append("  AND PAF.ESTADO IN ('I','V')  ")
        strSQL.Append("  AND AF.ID_ACCION_FORMATIVA = AD.ID_ACCION_FORMATIVA  ")
        strSQL.Append("  AND AD.ID_PROGRAMA_FORMACION = 1  ")
        strSQL.Append("  GROUP BY P.ID_PARTICIPANTE, P.NOMBRES, P.APELLIDOS ")
        strSQL.Append(") S  ")


        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE

        args(1) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(1).Value = ID_EJERCICIO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return Nothing

        Try
            If dr.Read() Then
                diccMontoCant = New Dictionary(Of String, Decimal)
                diccMontoCant.Add("MONTO", CDec(dr(0)))
                diccMontoCant.Add("CANTIDAD", CDec(dr(1)))
            Else
                diccMontoCant = New Dictionary(Of String, Decimal)
                diccMontoCant.Add("MONTO", CDec(0))
                diccMontoCant.Add("CANTIDAD", CDec(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return diccMontoCant

    End Function


    Public Function EsAccionFormativaBolpros(ByVal ID_ACCION_FORMATIVA As Decimal) As Boolean

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter
        Dim lEntidad As New INFORME_FINAL_AF
        Dim lRet As Boolean = False
        strSQL.Append("SELECT A.*  ")
        strSQL.Append("FROM ACCION_FORMATIVA A, GRUPO_ACCION_CONTRATADA G, ACCION_CONTRATADA AC, CONTRATO_BOLPROS C ")
        strSQL.Append("WHERE A.ID_ACCION_FORMATIVA = G.ID_ACCION_FORMATIVA ")
        strSQL.Append("AND G.ID_ACCION_CONTRATADA = AC.ID_ACCION_CONTRATADA ")
        strSQL.Append("AND AC.ID_CONTRATO = C.ID_CONTRATO ")
        strSQL.Append("AND C.ID_TIPO_CONTRA = 1 ")
        strSQL.Append("AND A.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")

        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

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




    Public Function EsAccionFormativaPorSolicitudCapacitacion(ByVal ID_ACCION_FORMATIVA As Decimal) As Boolean

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter
        Dim lEntidad As New INFORME_FINAL_AF
        Dim lRet As Boolean = False
        strSQL.Append("SELECT A.*  ")
        strSQL.Append("FROM ACCION_FORMATIVA A, GRUPO_ACCION_CONTRATADA G, ACCION_CONTRATADA AC, CONTRATO_BOLPROS C ")
        strSQL.Append("WHERE A.ID_ACCION_FORMATIVA = G.ID_ACCION_FORMATIVA ")
        strSQL.Append("AND G.ID_ACCION_CONTRATADA = AC.ID_ACCION_CONTRATADA ")
        strSQL.Append("AND AC.ID_CONTRATO = C.ID_CONTRATO ")
        strSQL.Append("AND A.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")

        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

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
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ACCION_FORMATIVA
        lEntidad = CType(aEntidad, ACCION_FORMATIVA)

        Dim lID As Decimal
        If lEntidad.ID_ACCION_FORMATIVA = 0 _
            Or lEntidad.ID_ACCION_FORMATIVA = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ACCION_FORMATIVA = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overloads Function EliminarEnCascada(ByVal ID_ACCION_FORMATIVA As Integer) As Integer

        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        arg = New OracleParameter("var_id_accion_formativa", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.StoredProcedure, "ELIMINAR_ACCION_FORMATIVA", args.ToArray)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	05/02/2010	Created
    ''' 	[ecarias]	14/04/2010	Se agrego que el criterio de NOMBRE_ACCION_FORMATIVA
    '''                             se validara en mayuscula desde la Base
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA, SITIO_CAPACITACION ")
        strSQL.AppendLine(" WHERE ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        strSQL.AppendLine("   AND ACCION_FORMATIVA.CODIGO_ESTADO_AF = '02' ")


        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine(" AND ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            strSQL.AppendLine(" AND ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            strSQL.AppendLine(" AND UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
                mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/02/2010	Created
    ''' 	[ecarias]	14/04/2010	Se agrego que el criterio de NOMBRE_ACCION_FORMATIVA
    '''                             se validara en mayuscula desde la Base
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal ID_AREA_FORMACION As Decimal, _
                                             ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                             Optional ByVal asColumnaOrden As String = "", _
                                             Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
            strSQL.AppendLine(" LEFT OUTER JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        Else
            strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        End If

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            strSQL.AppendLine(" AND ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
                AgregarCondicion(strSQLCondicion, " (ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION OR ACCION_FORMATIVA.ID_SITIO_CAPACITACION IS NULL) ")
            Else
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
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

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
                mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/02/2010	Created
    ''' 	[ecarias]	14/04/2010	Se agrego que el criterio de NOMBRE_ACCION_FORMATIVA y CODIGO_GRUPO
    '''                             se validaran en mayuscula desde la Base
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosPeriodo(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal TDR As String, _
                                                    Optional ByVal CODIGO_ESTADO_AF As String = "", _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.JefeHTP)) Then
            strSQL.AppendLine(" LEFT OUTER JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        Else
            strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        End If

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
                AgregarCondicion(strSQLCondicion, " (ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION OR ACCION_FORMATIVA.ID_SITIO_CAPACITACION IS NULL) ")
            Else
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If
        If CODIGO_ESTADO_AF <> "" Then
            If CODIGO_ESTADO_AF.IndexOf(",") = -1 Then
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.CODIGO_ESTADO_AF = :CODIGO_ESTADO_AF ")
                Dim op As OracleParameter = New OracleParameter(":CODIGO_ESTADO_AF", OracleType.NVarChar)
                op.Value = CODIGO_ESTADO_AF
                args.Add(op)
            Else
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.CODIGO_ESTADO_AF in (" + CODIGO_ESTADO_AF.Replace("""", "'") + ")")
            End If
        End If

        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM TERMINO_REFERENCIA_AF T WHERE T.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND RTRIM(T.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.VarChar)
            op.Value = TDR
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

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                    mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                    mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
                End If
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	22/05/2012	Created  
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal CODIGO_ESTADO_AF As String, _
                                                    ByVal NUM_LICITACION As String) As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If NUM_LICITACION <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM OFERTA_FORMATIVA OFE, CONTRATO_PROVEEDOR_AF C WHERE OFE.ID_CONTRATO = C.ID_CONTRATO AND OFE.ID_OFERTA_FORMATIVA = ACCION_FORMATIVA.ID_OFERTA_FORMATIVA AND C.NUM_LICITACION = :NUM_LICITACION) ")
            Dim op As OracleParameter = New OracleParameter(":NUM_LICITACION", OracleType.VarChar)
            op.Value = NUM_LICITACION
            args.Add(op)
        End If
        If CODIGO_ESTADO_AF <> "" Then
            If CODIGO_ESTADO_AF.IndexOf(",") = -1 Then
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.CODIGO_ESTADO_AF = :CODIGO_ESTADO_AF ")
                Dim op As OracleParameter = New OracleParameter(":CODIGO_ESTADO_AF", OracleType.NVarChar)
                op.Value = CODIGO_ESTADO_AF
                args.Add(op)
            Else
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.CODIGO_ESTADO_AF in (" + CODIGO_ESTADO_AF.Replace("""", "'") + ")")
            End If
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                    mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                    mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
                End If
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/06/2010	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosPeriodoEstados(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal ESTADOS_AF As List(Of String), _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
            strSQL.AppendLine(" LEFT OUTER JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        Else
            strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        End If

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
                AgregarCondicion(strSQLCondicion, " (ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION OR ACCION_FORMATIVA.ID_SITIO_CAPACITACION IS NULL) ")
            Else
                AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            End If
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If

        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM TERMINO_REFERENCIA_AF T WHERE T.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND RTRIM(T.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.NVarChar)
            op.Value = TDR
            args.Add(op)
        End If

        If ESTADOS_AF.Count > 0 Then
            Dim strCondicionComp As New StringBuilder
            Dim conta As Integer = 0

            strCondicionComp.Append(" ACCION_FORMATIVA.CODIGO_ESTADO_AF in (")

            For Each EstadoAccion As String In ESTADOS_AF
                conta += 1
                If conta = ESTADOS_AF.Count Then strCondicionComp.AppendLine("'" + EstadoAccion + "')") _
                    Else strCondicionComp.AppendLine("'" + EstadoAccion + "',")
            Next
            AgregarCondicion(strSQLCondicion, strCondicionComp.ToString)
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                    mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                    mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
                End If
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
    ''' Función que permite buscar por los parametros recibidos sin usar cláusula LIKE en la búsqueda.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosFijos(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal CODIGO_GRUPO As String, _
                                            ByVal ID_EJERCICIO As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.OBSERVACIONES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA.NOMBRE_FORMADOR, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        If Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse (Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.Proveedor) AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador)) Then
            strSQL.AppendLine(" LEFT OUTER JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        Else
            strSQL.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")
        End If

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) = :CODIGO_GRUPO ")
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

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                    mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                    mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
                End If
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
    ''' Función que devuelve la cantidad de participantes inscritos para la Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	15/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadParticipantesInscritos(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT  COUNT(*) ")
        strSQL.AppendLine("FROM PARTICIPANTE_AF ")
        strSQL.AppendLine("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND ( ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "' OR ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "' OR ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "' ) ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de participantes participantes por los cuales se pagará para la Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadParticipantesParaPago(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(COUNT(ID_PARTICIPANTE),0) AS PARTICIPANTES_ACTIVOS ")
        strSQL.AppendLine("FROM PARTICIPANTE_AF PAF, ")
        strSQL.AppendLine("( SELECT AF.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine("  P.PORC_ASISTENCIA_MINIMA ")
        strSQL.AppendLine("  AS PORC_REQUERIDO ")
        strSQL.AppendLine("  FROM ACCION_FORMATIVA AF, ACCION_FORMATIVA_DETALLE AFD, PROGRAMA_FORMACION P ")
        strSQL.AppendLine("  WHERE AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND AF.ID_ACCION_FORMATIVA = AFD.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("  AND AFD.ID_PROGRAMA_FORMACION = P.ID_PROGRAMA_FORMACION ")
        strSQL.AppendLine(") T ")
        strSQL.AppendLine("WHERE PAF.ID_ACCION_FORMATIVA = T.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND PAF.PORC_ASISTENCIA >= T.PORC_REQUERIDO ")
        strSQL.AppendLine("AND PAF.ESTADO IN('I','V')")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function


    Public Function ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(COUNT(PAF.ID_PARTICIPANTE),0) AS ACTIVOS ")
        strSQL.AppendLine("FROM PARTICIPANTE_AF PAF ")
        strSQL.AppendLine("WHERE PAF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA AND PAF.ES_CAPACITADO = 1 ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Calcula el Porcentaje de Asistencia Promedio a una Accion Formativa de un Participante.
    ''' </summary>
    ''' <history>
    ''' 	[ecarias]	14/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorcentajeAsistenciaPromedio(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal FECHA_INICIO_ASISTENCIA As Date = #12:00:00 AM#, Optional ByVal FECHA_FIN_ASISTENCIA As Date = #12:00:00 AM#) As Decimal

        Dim HorasNoAsistidas As Decimal = 0
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("select nvl(sum(horas_inasistencia),0) ")
        strSQL.AppendLine("from ( ")
        strSQL.AppendLine("     select sum(a1.cantidad_horas) horas_inasistencia ")
        strSQL.AppendLine("     from asistencia_af a1, asistencia_af_det a2 ")
        strSQL.AppendLine("     where a1.id_asistencia_af = a2.id_asistencia_af ")
        strSQL.AppendLine("     and a1.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     and a2.id_participante = :ID_PARTICIPANTE")
        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            strSQL.AppendLine("     and a1.fecha >= :FECHA_INICIO_ASISTENCIA and a1.fecha <= :FECHA_FIN_ASISTENCIA")
        End If
        strSQL.AppendLine("     and a2.asistio = '0'")
        strSQL.AppendLine("     union all ")
        strSQL.AppendLine("     select sum(a1.cantidad_horas - a2.horas_asistencia) horas_inasistencia ")
        strSQL.AppendLine("     from asistencia_af a1, asistencia_af_det a2 ")
        strSQL.AppendLine("     where a1.id_asistencia_af = a2.id_asistencia_af ")
        strSQL.AppendLine("     and a1.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     and a2.id_participante = :ID_PARTICIPANTE ")
        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            strSQL.AppendLine("     and a1.fecha >= :FECHA_INICIO_ASISTENCIA and a1.fecha <= :FECHA_FIN_ASISTENCIA")
        End If
        strSQL.AppendLine("     and a2.asistio = '1'")
        strSQL.AppendLine("     ) ")

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        arg = New OracleParameter(":ID_PARTICIPANTE", OracleType.Double)
        arg.Value = ID_PARTICIPANTE
        args.Add(arg)

        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            arg = New OracleParameter(":FECHA_INICIO_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_INICIO_ASISTENCIA
            args.Add(arg)

            arg = New OracleParameter(":FECHA_FIN_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_FIN_ASISTENCIA
            args.Add(arg)
        End If

        HorasNoAsistidas = CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

        Dim HorasTotalesCurso As Decimal = 0

        args = New List(Of OracleParameter)
        strSQL = New StringBuilder
        strSQL.AppendLine("SELECT SUM(CANTIDAD_HORAS) ")
        strSQL.AppendLine("FROM ASISTENCIA_AF A ")
        strSQL.AppendLine("WHERE A.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")
        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            strSQL.AppendLine(" AND A.FECHA >= :FECHA_INICIO_ASISTENCIA AND A.FECHA <= :FECHA_FIN_ASISTENCIA")
        End If

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            arg = New OracleParameter(":FECHA_INICIO_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_INICIO_ASISTENCIA
            args.Add(arg)

            arg = New OracleParameter(":FECHA_FIN_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_FIN_ASISTENCIA
            args.Add(arg)
        End If

        HorasTotalesCurso = CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

        If HorasTotalesCurso = 0 Then
            Return 0
        End If
        Return Decimal.Round((100 - (HorasNoAsistidas / HorasTotalesCurso * 100)), 2)

    End Function


    Public Function ObtenerPorcentajeAsistenciaPartiAcumuladoInformes(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, ByVal FECHA_LIMITE As Date) As Decimal

        Dim Porcentaje As Decimal = 0
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(SUM(D.PORC_ASISTENCIA),0) ")
        strSQL.AppendLine("FROM INFORME_FINAL_DET D, INFORME_FINAL_AF I ")
        strSQL.AppendLine("WHERE D.ID_INFORME_FINAL = I.ID_INFORME_FINAL ")
        strSQL.AppendLine("AND I.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND D.ID_PARTICIPANTE = :ID_PARTICIPANTE ")
        strSQL.AppendLine("AND I.FECHA_FINAL < :FECHA_LIMITE ")


        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        arg = New OracleParameter(":ID_PARTICIPANTE", OracleType.Double)
        arg.Value = ID_PARTICIPANTE
        args.Add(arg)

        arg = New OracleParameter(":FECHA_LIMITE", OracleType.DateTime)
        arg.Value = FECHA_LIMITE
        args.Add(arg)

        Porcentaje = CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))


        Return Porcentaje
    End Function

    Public Function ObtenerInfoAsistenciaReal(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal FECHA_INICIO_ASISTENCIA As Date = #12:00:00 AM#, Optional ByVal FECHA_FIN_ASISTENCIA As Date = #12:00:00 AM#) As Dictionary(Of String, Decimal)
        Dim dicc As Dictionary(Of String, Decimal)
        Dim HorasTotalesCurso As Decimal = 0
        Dim HorasEjecutadasCurso As Decimal = 0
        Dim HorasAsistidas As Decimal = 0
        Dim HorasNoAsistidas As Decimal = 0
        Dim diccAsisReal As Dictionary(Of String, Decimal)
        Dim args As New List(Of OracleParameter)
        Dim arg As OracleParameter
        Dim lAccion As ACCION_FORMATIVA
        Dim lRet As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("select nvl(sum(horas_inasistencia),0) ")
        strSQL.AppendLine("from ( ")
        strSQL.AppendLine("     select sum(a1.cantidad_horas) horas_inasistencia ")
        strSQL.AppendLine("     from asistencia_af a1, asistencia_af_det a2 ")
        strSQL.AppendLine("     where a1.id_asistencia_af = a2.id_asistencia_af ")
        strSQL.AppendLine("     and a1.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     and a2.id_participante = :ID_PARTICIPANTE")
        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            strSQL.AppendLine("     and a1.fecha >= :FECHA_INICIO_ASISTENCIA and a1.fecha <= :FECHA_FIN_ASISTENCIA")
        End If
        strSQL.AppendLine("     and a2.asistio = '0'")
        strSQL.AppendLine("     union all ")
        strSQL.AppendLine("     select sum(a1.cantidad_horas - a2.horas_asistencia) horas_inasistencia ")
        strSQL.AppendLine("     from asistencia_af a1, asistencia_af_det a2 ")
        strSQL.AppendLine("     where a1.id_asistencia_af = a2.id_asistencia_af ")
        strSQL.AppendLine("     and a1.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     and a2.id_participante = :ID_PARTICIPANTE ")
        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            strSQL.AppendLine("     and a1.fecha >= :FECHA_INICIO_ASISTENCIA and a1.fecha <= :FECHA_FIN_ASISTENCIA")
        End If
        strSQL.AppendLine("     and a2.asistio = '1'")
        strSQL.AppendLine("     ) ")

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        arg.Value = ID_ACCION_FORMATIVA
        args.Add(arg)

        arg = New OracleParameter(":ID_PARTICIPANTE", OracleType.Double)
        arg.Value = ID_PARTICIPANTE
        args.Add(arg)

        If FECHA_INICIO_ASISTENCIA <> #12:00:00 AM# AndAlso FECHA_FIN_ASISTENCIA <> #12:00:00 AM# Then
            arg = New OracleParameter(":FECHA_INICIO_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_INICIO_ASISTENCIA
            args.Add(arg)

            arg = New OracleParameter(":FECHA_FIN_ASISTENCIA", OracleType.DateTime)
            arg.Value = FECHA_FIN_ASISTENCIA
            args.Add(arg)
        End If

        HorasNoAsistidas = CDec(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray))

        Dim diccEjecucion As Dictionary(Of String, Decimal) = (New dbACCION_FORMATIVA).ObtenerPorcentajeAvancePorAccionFormativa(ID_ACCION_FORMATIVA, FECHA_FIN_ASISTENCIA)
        If diccEjecucion IsNot Nothing Then
            HorasAsistidas = diccEjecucion("MINUTOS_EJECUCION") - HorasNoAsistidas
        End If

        lAccion = New ACCION_FORMATIVA
        lAccion.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        lRet = (New dbACCION_FORMATIVA).Recuperar(lAccion)

        HorasTotalesCurso = lAccion.DURACION_HORAS * 60


        If HorasTotalesCurso = 0 Then
            Return Nothing
        End If

        dicc = New Dictionary(Of String, Decimal)
        dicc.Add("PORCENTAJE_ASISTENCIA", Decimal.Round((HorasAsistidas / HorasTotalesCurso * 100), 2))
        dicc.Add("MINUTOS_ASISTENCIA", HorasAsistidas)
        Return dicc

    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que obtiene la Oferta Formativa de acuerdo a los parámetros especificados
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	20/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativa() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("")
        strSQL.Append("")


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que obtiene la Ejecucion de la Oferta Formativa de acuerdo a los parámetros especificados
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	20/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerEjecucionOfertaFormativa(ByVal TIPO_CONSULTA As Integer, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal CODIGO_GRUPO As String, _
                                                ByVal ID_TIPO_SOLICITUD As Decimal) As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("select id_ejercicio, id_proveedor_af, nombre_proveedor, id_sitio_capacitacion, nombre_sitio, area_formacion, id_accion_formativa, ")
        strSQL.Append("nombre_accion_formativa, codigo_grupo, horario, fecha_inicio_real, fecha_fin_real, ")
        strSQL.Append("genero, costo_x_participante, duracion_horas, participantes_inscritos, costo_total, ")
        strSQL.Append("porcentajeejec, direccion, encargado, telefono_encargado, nombre_estado_af, notas ")
        strSQL.Append("from vejecucion_oferta ")


        Select Case TIPO_CONSULTA
            Case 1
                strSQL.Append("where (fecha_inicio_real > to_char(sysdate,'dd/MON/yyyy')) ")

            Case 2
                strSQL.Append("where (fecha_inicio_real <= to_char(sysdate,'dd/MON/yyyy') and fecha_fin_real >= to_char(sysdate,'dd/MON/yyyy')) ")

            Case 3
                strSQL.Append("where (fecha_fin_real < to_char(sysdate,'dd/MON/yyyy')) ")
        End Select

        If ID_EJERCICIO <> "" Then
            If strSQL.ToString.Contains("where") Then strSQL.Append("and id_ejercicio = :ID_EJERCICIO ") Else strSQL.Append("where id_ejercicio = :ID_EJERCICIO ")
            Dim arg As New OracleParameter("ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
        End If

        If ID_PROVEEDOR_AF <> -1 Then
            If strSQL.ToString.Contains("where") Then strSQL.Append("and id_proveedor_af = :ID_PROVEEDOR_AF ") Else strSQL.Append("where id_proveedor_af = :ID_PROVEEDOR_AF ")
            Dim arg As New OracleParameter("ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
        End If

        If ID_SITIO_CAPACITACION <> -1 Then
            If strSQL.ToString.Contains("where") Then strSQL.Append("and id_sitio_capacitacion = :ID_SITIO_CAPACITACION ") Else strSQL.Append("where id_sitio_capacitacion = :ID_SITIO_CAPACITACION ")
            Dim arg As New OracleParameter("ID_SITIO_CAPACITACION", OracleType.Number)
            arg.Value = ID_SITIO_CAPACITACION
            args.Add(arg)
        End If

        If CODIGO_GRUPO IsNot Nothing AndAlso CODIGO_GRUPO.Trim <> "" Then
            If strSQL.ToString.Contains("where") Then strSQL.Append("and codigo_grupo = :CODIGO_GRUPO ") Else strSQL.Append("where codigo_grupo = :CODIGO_GRUPO ")
            Dim arg As New OracleParameter("CODIGO_GRUPO", OracleType.VarChar)
            arg.Value = CODIGO_GRUPO.Trim.ToUpper
            args.Add(arg)
        End If

        If ID_TIPO_SOLICITUD <> -1 Then
            If strSQL.ToString.Contains("where") Then strSQL.Append("and id_tipo_solicitud = :ID_TIPO_SOLICITUD ") Else strSQL.Append("where id_tipo_solicitud = :ID_TIPO_SOLICITUD ")
            Dim arg As New OracleParameter("ID_TIPO_SOLICITUD", OracleType.Number)
            arg.Value = ID_TIPO_SOLICITUD
            args.Add(arg)
        End If
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Return ds
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/10/2010	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosPeriodoEstadosTecnico(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal ESTADOS_AF As List(Of String), _
                                                    ByVal USUARIO_TECNICO As String, _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL1 As New StringBuilder
        Dim strSQL2 As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL1.AppendLine(" SELECT ACCION_FORMATIVA.*, ")
        strSQL1.AppendLine(" SITIO_CAPACITACION.NOMBRE_SITIO, ")
        strSQL1.AppendLine(" SITIO_CAPACITACION.CODIGO_DEPARTAMENTO, ")
        strSQL1.AppendLine(" SITIO_CAPACITACION.CODIGO_MUNICIPIO ")
        strSQL1.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL1.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        strSQL1.AppendLine(" JOIN SITIO_CAPACITACION ON ACCION_FORMATIVA.ID_SITIO_CAPACITACION = SITIO_CAPACITACION.ID_SITIO_CAPACITACION ")

        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If

        If ESTADOS_AF.Count > 0 Then
            Dim CondEstadosAF As New StringBuilder

            Dim conta As Integer = 0
            CondEstadosAF.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF in (")

            For Each EstadoAccion As String In ESTADOS_AF
                conta += 1
                If conta = ESTADOS_AF.Count Then CondEstadosAF.AppendLine("'" + EstadoAccion + "')") _
                    Else CondEstadosAF.AppendLine("'" + EstadoAccion + "',")
            Next
            AgregarCondicion(strSQLCondicion, CondEstadosAF.ToString)
        End If

        If USUARIO_TECNICO <> "" Then
            Dim CondSitiosMunicAsignados As New StringBuilder
            CondSitiosMunicAsignados.AppendLine(" EXISTS (")
            CondSitiosMunicAsignados.AppendLine("   SELECT 1")
            CondSitiosMunicAsignados.AppendLine("   FROM TECNICOS_SITIOS_ASIG T")
            CondSitiosMunicAsignados.AppendLine("   WHERE T.ID_PROVEEDOR_AF = ACCION_FORMATIVA.ID_PROVEEDOR_AF")
            CondSitiosMunicAsignados.AppendLine("   AND T.ID_SITIO_CAPACITACION = ACCION_FORMATIVA.ID_SITIO_CAPACITACION")
            CondSitiosMunicAsignados.AppendLine("   AND T.USUARIO = :USUARIO_TECNICO")
            CondSitiosMunicAsignados.AppendLine("   )")
            AgregarCondicion(strSQLCondicion, CondSitiosMunicAsignados.ToString)

            Dim op As OracleParameter = New OracleParameter(":USUARIO_TECNICO", OracleType.NVarChar)
            op.Value = USUARIO_TECNICO
            args.Add(op)
        End If
        strSQL1.AppendLine(strSQLCondicion.ToString)




        strSQLCondicion = New StringBuilder
        strSQL2.AppendLine(" UNION ALL ")
        strSQL2.AppendLine(" SELECT ACCION_FORMATIVA.*, ")
        strSQL2.AppendLine(" '' AS NOMBRE_SITIO, ")
        strSQL2.AppendLine(" '' AS CODIGO_DEPARTAMENTO, ")
        strSQL2.AppendLine(" '' AS CODIGO_MUNICIPIO ")
        strSQL2.AppendLine(" FROM ACCION_FORMATIVA ")
        strSQL2.AppendLine(" JOIN CURSO_TEMA ON ACCION_FORMATIVA.ID_TEMA_CURSO = CURSO_TEMA.ID_TEMA_CURSO ")
        strSQL2.AppendLine(" JOIN VACCION_FORMATIVA_PATI ON ACCION_FORMATIVA.ID_ACCION_FORMATIVA = VACCION_FORMATIVA_PATI.ID_ACCION_FORMATIVA  ")

        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " CURSO_TEMA.ID_AREA_FORMACION = :ID_AREA_FORMACION ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) LIKE :CODIGO_GRUPO ")
            Dim op As OracleParameter = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            op.Value = "%" + CODIGO_GRUPO.ToUpper + "%"
            args.Add(op)
        End If
        If ID_EJERCICIO <> "" AndAlso ID_EJERCICIO <> "0" Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO ")
            Dim op As OracleParameter = New OracleParameter(":ID_EJERCICIO", OracleType.NVarChar)
            op.Value = ID_EJERCICIO
            args.Add(op)
        End If

        If ESTADOS_AF.Count > 0 Then
            Dim CondEstadosAF As New StringBuilder

            Dim conta As Integer = 0
            CondEstadosAF.AppendLine(" ACCION_FORMATIVA.CODIGO_ESTADO_AF in (")

            For Each EstadoAccion As String In ESTADOS_AF
                conta += 1
                If conta = ESTADOS_AF.Count Then CondEstadosAF.AppendLine("'" + EstadoAccion + "')") _
                    Else CondEstadosAF.AppendLine("'" + EstadoAccion + "',")
            Next
            AgregarCondicion(strSQLCondicion, CondEstadosAF.ToString)
        End If

        If USUARIO_TECNICO <> "" Then
            Dim CondSitiosMunicAsignados As New StringBuilder
            CondSitiosMunicAsignados.AppendLine(" EXISTS (")
            CondSitiosMunicAsignados.AppendLine("   SELECT 1")
            CondSitiosMunicAsignados.AppendLine("   FROM TECNICOS_MUNICIPIOS_PATI_ASIG MPATI ")
            CondSitiosMunicAsignados.AppendLine("   WHERE MPATI.CODIGO_DEPARTAMENTO = VACCION_FORMATIVA_PATI.CODIGO_DEPARTAMENTO")
            CondSitiosMunicAsignados.AppendLine("   AND MPATI.CODIGO_MUNICIPIO = VACCION_FORMATIVA_PATI.CODIGO_MUNICIPIO")
            CondSitiosMunicAsignados.AppendLine("   AND MPATI.USUARIO = :USUARIO_TECNICO")
            CondSitiosMunicAsignados.AppendLine("   )")
            AgregarCondicion(strSQLCondicion, CondSitiosMunicAsignados.ToString)

            Dim op As OracleParameter = New OracleParameter(":USUARIO_TECNICO", OracleType.NVarChar)
            op.Value = USUARIO_TECNICO
            args.Add(op)
        End If

        If TDR <> "" Then
            Dim CondTdr As New StringBuilder
            CondTdr.AppendLine(" EXISTS (")
            CondTdr.AppendLine("   SELECT TREF.*")
            CondTdr.AppendLine("   FROM TERMINO_REFERENCIA_AF TREF")
            CondTdr.AppendLine("   WHERE TREF.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA")
            CondTdr.AppendLine("   AND RTRIM(TREF.TDR) = :TDR")
            CondTdr.AppendLine(" )")

            AgregarCondicion(strSQLCondicion, CondTdr.ToString)
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.VarChar)
            op.Value = TDR
            args.Add(op)
        End If
        strSQL2.AppendLine(strSQLCondicion.ToString)


        If asColumnaOrden <> "" Then
            strSQL2.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL1.ToString() + strSQL2.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL1.ToString() + strSQL2.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                If mEntidad.ID_SITIO_CAPACITACION <> -1 Then
                    mEntidad.fkID_SITIO_CAPACITACION = (New SITIO_CAPACITACION)
                    mEntidad.fkID_SITIO_CAPACITACION.NOMBRE_SITIO = dr("NOMBRE_SITIO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_DEPARTAMENTO = dr("CODIGO_DEPARTAMENTO").ToString()
                    mEntidad.fkID_SITIO_CAPACITACION.CODIGO_MUNICIPIO = dr("CODIGO_MUNICIPIO").ToString()
                End If

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
    ''' Función que devuelve el tipo de Programa de Formación
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/12/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerProgramaFormacionCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim liRet As Integer = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT ID_PROGRAMA_FORMACION ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA_DETALLE ")
        strSQL.AppendLine("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Try
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If dr.Read Then
                liRet = CInt(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return liRet
    End Function

    Public Function ObtenerModalidadFormacionCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Dim dr As OracleDataReader
        Dim liRet As Integer = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT ID_MODALIDAD_FORMACION ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA_DETALLE ")
        strSQL.AppendLine("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Try
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If dr.Read Then
                liRet = CInt(dr(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return liRet
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Horario por Dia para una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/04/2011	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerHorarioPorDia(ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Dim drHorarioPorDia As OracleDataReader
        Dim strSQL As New StringBuilder
        Dim lRet As String = ""
        strSQL.AppendLine("select horario_af_detalle(:ID_ACCION_FORMATIVA) ")
        strSQL.AppendLine("from dual")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Try
            drHorarioPorDia = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If drHorarioPorDia.Read Then
                lRet = CStr(drHorarioPorDia(0))
            End If

        Catch ex As Exception
            Throw ex
        Finally
            drHorarioPorDia.Close()
        End Try
        Return lRet
    End Function

    Public Function ObtenerInfoContratacion(ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Dim dr As OracleDataReader
        Dim strSQL As New StringBuilder
        Dim lRet As String = ""
        strSQL.AppendLine("SELECT NO_LICITACION AS NO_LICITACION, CONTRATO_LICITACION, CONTRATO_COMPRA, CONTRATO_BOLPROS, TDR FROM VACCION_FORMATIVA_CONTRATADA WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")


        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Try
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If dr.Read Then
                Dim lici As String
                Dim contrato As String

                If IsDBNull(dr("NO_LICITACION")) Then
                    If IsDBNull(dr("CONTRATO_BOLPROS")) Then
                        lRet = If(IsDBNull(dr("TDR")), "", "TDR:" & CStr(dr("TDR")))
                    Else
                        lici = If(IsDBNull(dr("CONTRATO_COMPRA")), "", "Oferta/Lic.:" & CStr(dr("CONTRATO_COMPRA")))
                        contrato = If(IsDBNull(dr("CONTRATO_BOLPROS")), "", " Contrato:" & CStr(dr("CONTRATO_BOLPROS")))
                        lRet = lici & contrato
                    End If
                Else
                    lici = If(IsDBNull(dr("NO_LICITACION")), "", "Oferta/Lic.:" & CStr(dr("NO_LICITACION")))
                    contrato = If(IsDBNull(dr("CONTRATO_LICITACION")), "", " Contrato:" & CStr(dr("CONTRATO_LICITACION")))
                    lRet = lici & contrato
                End If
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
    ''' Función que devuelve el Horario por Período para una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	27/07/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerHorarioPorPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIAL As Date, ByVal FECHA_FINAL As Date) As String
        Dim drHorarioPorPeriodo As OracleDataReader
        Dim strSQL As New StringBuilder
        Dim lRet As String = ""
        strSQL.AppendLine("select horario_af_detalle_periodo(:ID_ACCION_FORMATIVA,:FECHA_INICIAL,:FECHA_FINAL) ")
        strSQL.AppendLine("from dual")

        Dim args(3) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":FECHA_INICIAL", OracleType.DateTime)
        args(1).Value = FECHA_INICIAL

        args(2) = New OracleParameter(":FECHA_FINAL", OracleType.DateTime)
        args(2).Value = FECHA_FINAL

        Try
            drHorarioPorPeriodo = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If drHorarioPorPeriodo.Read Then
                lRet = CStr(drHorarioPorPeriodo(0))
            End If


        Catch ex As Exception
            Throw ex
        Finally
            drHorarioPorPeriodo.Close()
        End Try
        Return lRet
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el Depto y Municipio de la Accion Formativa que recibe de parametro
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	12/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDeptoMunicipio(ByVal ID_ACCION_FORMATIVA As Decimal) As Dictionary(Of String, String)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("select codigo_departamento, codigo_municipio ")
        strSQL.AppendLine("from accion_formativa_detalle ")
        strSQL.AppendLine("where id_accion_formativa = :ID_ACCION_FORMATIVA")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim valores As New Dictionary(Of String, String)
        Try
            If dr.Read() Then
                valores.Add("CODIGO_DEPARTAMENTO", dr("CODIGO_DEPARTAMENTO").ToString())
                valores.Add("CODIGO_MUNICIPIO", dr("CODIGO_MUNICIPIO").ToString())
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return valores

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el Depto y Municipio de la Accion Formativa que recibe de parametro
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	12/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFechaMinimaMaximaEjecucionPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal) As Dictionary(Of String, Date)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT MIN(AF.FECHA_INICIO_REAL) AS FECHA_MINIMA,  MAX(AF.FECHA_INICIO_REAL) AS FECHA_MAXIMA ")
        strSQL.AppendLine("FROM ACCION_CONTRATADA AC, GRUPO_ACCION_CONTRATADA G, ACCION_FORMATIVA AF ")
        strSQL.AppendLine("WHERE AC.ID_CONTRATO = :ID_CONTRATO ")
        strSQL.AppendLine("AND AC.ID_ACCION_CONTRATADA = G.ID_ACCION_CONTRATADA ")
        strSQL.AppendLine("AND G.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND AF.HORARIO <> 'PENDIENTE DE DEFINIR' ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_CONTRATO", OracleType.Double)
        args(0).Value = ID_CONTRATO

        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim valores As New Dictionary(Of String, Date)
        Try
            If dr.Read() Then
                If IsDate(dr("FECHA_MINIMA")) Then
                    valores.Add("FECHA_MINIMA", CDate(dr(0)))
                    valores.Add("FECHA_MAXIMA", CDate(dr(1)))
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return valores

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el N° de Convocatoria de la Accion Formativa que recibe de parametro
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerNoConvocatoria(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Dim NoConvocatoria As Integer = 0
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("select no_convocatoria ")
        strSQL.AppendLine("from vaccion_formativa_pati ")
        strSQL.AppendLine("where id_accion_formativa = :ID_ACCION_FORMATIVA")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim valores As New Dictionary(Of String, String)
        Try
            If dr.Read() Then
                NoConvocatoria = Convert.ToInt32(dr(0))
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return NoConvocatoria

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por Número de Resolución.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorResolucion(ByVal RESOLUCION As String, Optional ByVal asColumnaOrden As String = "CODIGO_GRUPO", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(V.NOMBRE_MUNICIPIO,'') AS MUNICIPIO, AF.ID_ACCION_FORMATIVA AS ID_ACCION_FORMATIVA, AF.NOMBRE_ACCION_FORMATIVA, AF.CODIGO_GRUPO, AF.FECHA_INICIO_REAL, AF.FECHA_FIN_REAL, ")
        strSQL.AppendLine("CASE ")
        strSQL.AppendLine("  WHEN NOT INF.PARTICIPANTES_FINALES IS NULL THEN INF.PARTICIPANTES_FINALES ")
        strSQL.AppendLine("  ELSE (SELECT COUNT(PAF.ID_PARTICIPANTE) FROM PARTICIPANTE_AF PAF WHERE PAF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA AND PAF.PORC_ASISTENCIA>=80) ")
        strSQL.AppendLine("END AS PARTICIPANTES_ACTIVOS, ")
        strSQL.AppendLine("AF.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine("CASE ")
        strSQL.AppendLine("  WHEN NOT INF.MONTO_FACTURA IS NULL THEN INF.MONTO_FACTURA ")
        strSQL.AppendLine("  WHEN INF.MONTO_FACTURA IS NULL AND V.ID_FUENTE = 1 THEN TDR.MONTO_ADJUDICADO ")
        strSQL.AppendLine("  ELSE (SELECT NVL(COUNT(PAF.ID_PARTICIPANTE),0) * AF.COSTO_X_PARTICIPANTE FROM PARTICIPANTE_AF PAF WHERE PAF.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA AND PAF.PORC_ASISTENCIA>=80) ")
        strSQL.AppendLine("END AS MONTO_FACTURA, ")
        strSQL.AppendLine("AF.CODIGO_ESTADO_AF, AF.HORARIO, NVL(TDR.CORRELATIVO_GRUPO,-1) AS CORRELATIVO_GRUPO ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA AF ")
        strSQL.AppendLine("JOIN TERMINO_REFERENCIA_AF TDR ON AF.ID_ACCION_FORMATIVA = TDR.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("LEFT OUTER JOIN INFORME_FINAL_AF INF ON AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("LEFT OUTER JOIN VACCION_FORMATIVA_PATI V ON AF.ID_ACCION_FORMATIVA = V.ID_ACCION_FORMATIVA ")

        If RESOLUCION <> "" Then
            strSQL.AppendLine("WHERE TRIM(TDR.RESOLUCION) = :RESOLUCION ")
            Dim arg As OracleParameter = New OracleParameter(":RESOLUCION", OracleType.VarChar)
            arg.Value = RESOLUCION
            args.Add(arg)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/08/2011	Created
    ''' 	[cramos]	29/03/2012	Modificado: Se implementa lógica para devolver Entidades por Tipo de Solicitud y Proveedor
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAccionFormativaFacturar(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA))
        strSQL.Append(" WHERE EXISTS(SELECT 1 FROM INFORME_FINAL_AF INF WHERE INF.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND INF.ID_ESTADO_INFORME = " + Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor.ToString + ") ")

        If ID_PROVEEDOR_AF <> -1 Then
            Dim arg As OracleParameter
            arg = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            arg.Value = ID_PROVEEDOR_AF
            args.Add(arg)
            strSQL.Append(" AND ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
        End If

        strSQL.Append(" AND EXISTS (SELECT 1 FROM SOLICITUD_INSCRIPCION_AF SOL WHERE SOL.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA ")
        strSQL.Append("             AND SOL.ID_TIPO_SOLICITUD IN(")
        strSQL.Append(ID_TIPO_SOLICITUD.ToString)
        strSQL.Append("))")
        strSQL.Append(" AND NOT EXISTS (SELECT 1 FROM FACTURA_AF FE, FACTURA_DET FD, INFORME_FINAL_AF INF WHERE FE.ID_FACTURA_AF = FD.ID_FACTURA_AF AND FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL AND INF.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND FE.ESTADO <> 'A') ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader

        If args.Count = 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        End If


        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
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
    ''' Función que Devuelve un DataSet filtrado por Número de Resolución.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorFactura(ByVal ID_FACTURA_AF As Decimal, Optional ByVal asColumnaOrden As String = "CODIGO_GRUPO", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT (SELECT M.NOMBRE FROM ACCION_FORMATIVA_DETALLE AFD, MUNICIPIO M ")
        strSQL.AppendLine(" WHERE AFD.CODIGO_DEPARTAMENTO = M.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine(" AND AFD.CODIGO_MUNICIPIO = M.CODIGO_MUNICIPIO ")
        strSQL.AppendLine(" AND AFD.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA) AS MUNICIPIO, ")
        strSQL.AppendLine("AF.ID_ACCION_FORMATIVA, AF.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine("AF.CODIGO_GRUPO, INF.FECHA_INICIAL, INF.FECHA_FINAL, ")
        strSQL.AppendLine("INF.PARTICIPANTES_FINALES AS PARTICIPANTES_ACTIVOS, ")
        strSQL.AppendLine("AF.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine("INF.MONTO_FACTURA, ")
        strSQL.AppendLine("INF.ID_ESTADO_INFORME, INF.HORARIO, ")
        strSQL.AppendLine("(SELECT TDR.CORRELATIVO_GRUPO FROM TERMINO_REFERENCIA_AF TDR WHERE TDR.ID_ACCION_FORMATIVA = AF.ID_ACCION_FORMATIVA) AS CORRELATIVO_GRUPO  ")
        strSQL.AppendLine("FROM ACCION_FORMATIVA AF, INFORME_FINAL_AF INF ")
        strSQL.AppendLine("WHERE AF.ID_ACCION_FORMATIVA = INF.ID_ACCION_FORMATIVA ")

        If ID_FACTURA_AF <> -1 Then
            strSQL.AppendLine("AND EXISTS(SELECT 1 FROM FACTURA_DET FD WHERE FD.ID_INFORME_FINAL = INF.ID_INFORME_FINAL AND FD.ID_FACTURA_AF = :ID_FACTURA_AF) ")
            Dim arg As OracleParameter = New OracleParameter(":ID_FACTURA_AF", OracleType.Number)
            arg.Value = ID_FACTURA_AF
            args.Add(arg)
        End If

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
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
    ''' Función que Devuelve una Colección de Strings de los Asentamientos Urbanos o 
    ''' Caserios de los Participantes de la Accion Formativa que recibe de parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/09/2011	Created    
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaAUPsPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As List(Of String)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT DISTINCT TRIM(NOMB_CASERIO_AUP) AS NOMB_CASERIO_AUP ")
        strSQL.AppendLine("FROM FICHA_PATI ")
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM PARTICIPANTE_AF PAF ")
        strSQL.AppendLine("   WHERE PAF.ID_PARTICIPANTE = FICHA_PATI.ID_PARTICIPANTE ")
        strSQL.AppendLine("   AND PAF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA) ")

        Dim arg As OracleParameter
        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), arg)

        Dim lista As New List(Of String)

        Try
            Do While dr.Read()
                lista.Add(dr("NOMB_CASERIO_AUP").ToString)
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
    ''' Función que devuelve una lista de Acciones Formativas filtrada por criterios.
    ''' </summary>
    ''' <param name="ID_CONTRATO">Id del Proveedor del registro seleccionado.</param>    
    ''' <param name="ID_SUBAREA_FORMACION">Id de la Sub Area a la que pertenece la Acción Formativa.</param>    
    ''' <param name="CODIGO_GRUPO">Código de Grupo de la Acción Formativa perteneciente al Contrato.</param>
    ''' <param name="ID_EJERCICIO">Id del Ejercicio de las Acciones Formativas pertenecientes al Contrato.</param>
    ''' <param name="listaEstadosInforme">Lista de estados del informe de ejecución.</param>
    ''' <history>
    ''' 	[cramos]	09/03/2012	Created
    '''  	[cramos]	12/12/2012	Modificado: Se adecua lógica para consultar por medio de estados del Informe de Ejecución
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosContratoSubAreaFormativa(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, Optional ByVal listaEstadosInforme As List(Of Decimal) = Nothing) As listaACCION_FORMATIVA
        Dim lista As New listaACCION_FORMATIVA
        Dim strSQL As New StringBuilder
        Dim strCondicion As New StringBuilder
        Dim args As New List(Of OracleParameter)
        Dim arg As New OracleParameter
        Dim lEntidad As New ACCION_FORMATIVA

        strSQL.Append(Me.QuerySelect(lEntidad))
        If CODIGO_GRUPO <> "" Then
            arg = New OracleParameter(":CODIGO_GRUPO", OracleType.VarChar)
            arg.Value = CODIGO_GRUPO.ToUpper
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ACCION_FORMATIVA.CODIGO_GRUPO = :CODIGO_GRUPO")
        End If
        If ID_EJERCICIO <> "" Then
            arg = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            arg.Value = ID_EJERCICIO
            args.Add(arg)
            Me.AgregarCondicion(strCondicion, "ACCION_FORMATIVA.ID_EJERCICIO = :ID_EJERCICIO")
        End If
        If listaEstadosInforme IsNot Nothing AndAlso listaEstadosInforme.Count > 0 Then
            Dim strEstados As New StringBuilder
            strEstados.Append("EXISTS (SELECT 1 FROM INFORME_FINAL_AF INF WHERE INF.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND INF.ID_ESTADO_INFORME IN(")
            For i As Integer = 0 To listaEstadosInforme.Count - 1
                strEstados.Append(listaEstadosInforme(i).ToString)
                If i = listaEstadosInforme.Count - 1 Then
                    strEstados.Append("))")
                Else
                    strEstados.Append(",")
                End If
            Next
            Me.AgregarCondicion(strCondicion, strEstados.ToString)
        End If

        If ID_CONTRATO <> -1 OrElse ID_SUBAREA_FORMACION <> -1 Then
            Dim strSubCondicion As New StringBuilder
            strSubCondicion.Append("EXISTS (SELECT 1 FROM OFERTA_FORMATIVA OFE, CURSO_TEMA CT WHERE ")
            strSubCondicion.Append("OFE.ID_TEMA_CURSO = CT.ID_TEMA_CURSO")
            If ID_CONTRATO <> -1 Then
                arg = New OracleParameter(":ID_CONTRATO", OracleType.Number)
                arg.Value = ID_CONTRATO
                args.Add(arg)
                strSubCondicion.Append(" AND OFE.ID_CONTRATO = :ID_CONTRATO")
            End If
            If ID_SUBAREA_FORMACION <> -1 Then
                arg = New OracleParameter(":ID_SUBAREA_FORMACION", OracleType.Number)
                arg.Value = ID_SUBAREA_FORMACION
                args.Add(arg)
                strSubCondicion.Append(" AND CT.ID_SUBAREA_FORMACION = :ID_SUBAREA_FORMACION")
            End If

            strSubCondicion.Append(" AND OFE.ID_OFERTA_FORMATIVA = ACCION_FORMATIVA.ID_OFERTA_FORMATIVA)")
            Me.AgregarCondicion(strCondicion, strSubCondicion.ToString)
        End If
        strSQL.Append(strCondicion.ToString)

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)

        If dr Is Nothing Then Return Nothing

        Try
            While dr.Read()
                lEntidad = New ACCION_FORMATIVA
                dbAsignarEntidades.AsignarACCION_FORMATIVA(dr, lEntidad)
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
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/01/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal listaCODIGO_ESTADO_AF As List(Of String), _
                                                    ByVal listaID_PROGRAMA_FORMACION As List(Of Decimal), _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder
        Dim args As List(Of OracleParameter) = New List(Of OracleParameter)

        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA))
        If CODIGO_GRUPO Is Nothing Then CODIGO_GRUPO = "" Else CODIGO_GRUPO = CODIGO_GRUPO.ToUpper
        If TDR Is Nothing Then TDR = ""
        If ID_PROVEEDOR_AF <> -1 Then
            AgregarCondicion(strSQLCondicion, " ACCION_FORMATIVA.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
            Dim op As OracleParameter = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            op.Value = ID_PROVEEDOR_AF
            args.Add(op)
        End If
        If ID_SITIO_CAPACITACION <> -1 AndAlso Not Utilerias.EstaEnRol(Enumeradores.RolDeUsuario.TecnicoCentroHTP) AndAlso Not (Left(CODIGO_GRUPO, 4) = "PATI" OrElse Left(CODIGO_GRUPO, 6) = "PROESP" OrElse Left(CODIGO_GRUPO, 8) = "HTPMOVIL" OrElse Left(CODIGO_GRUPO, 9) = "HTPCENTRO") AndAlso TDR = "" Then
            AgregarCondicion(strSQLCondicion, " (ACCION_FORMATIVA.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION OR (ACCION_FORMATIVA.ID_SITIO_CAPACITACION IS NULL AND (SELECT COUNT(1) FROM ACCION_FORMATIVA_DETALLE AD WHERE AD.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND AD.ID_PROGRAMA_FORMACION = 1) > 0) )")
            Dim op As OracleParameter = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            op.Value = ID_SITIO_CAPACITACION
            args.Add(op)
        End If
        If ID_AREA_FORMACION <> -1 Then
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM AREA_FORMACION A, CURSO_TEMA C WHERE A.ID_AREA_FORMACION = C.ID_AREA_FORMACION AND C.ID_TEMA_CURSO = ACCION_FORMATIVA.ID_TEMA_CURSO AND A.ID_AREA_FORMACION = :ID_AREA_FORMACION) ")
            Dim op As OracleParameter = New OracleParameter(":ID_AREA_FORMACION", OracleType.Number)
            op.Value = ID_AREA_FORMACION
            args.Add(op)
        End If
        If NOMBRE_ACCION_FORMATIVA <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.NOMBRE_ACCION_FORMATIVA) LIKE :NOMBRE_ACCION_FORMATIVA ")
            Dim op As OracleParameter = New OracleParameter(":NOMBRE_ACCION_FORMATIVA", OracleType.VarChar)
            op.Value = "%" + NOMBRE_ACCION_FORMATIVA.ToUpper + "%"
            args.Add(op)
        End If
        If CODIGO_GRUPO <> "" Then
            AgregarCondicion(strSQLCondicion, " UPPER(ACCION_FORMATIVA.CODIGO_GRUPO) = :CODIGO_GRUPO ")
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
        If listaCODIGO_ESTADO_AF IsNot Nothing AndAlso listaCODIGO_ESTADO_AF.Count > 0 Then
            Dim strIN As New StringBuilder
            If listaCODIGO_ESTADO_AF.Count = 1 Then
                strIN.Append(" ACCION_FORMATIVA.CODIGO_ESTADO_AF = :CODIGO_ESTADO_AF ")
                Dim op As OracleParameter = New OracleParameter(":CODIGO_ESTADO_AF", OracleType.VarChar)
                op.Value = listaCODIGO_ESTADO_AF(0)
                args.Add(op)
            Else
                For i As Integer = 0 To listaCODIGO_ESTADO_AF.Count - 1
                    If i = 0 Then
                        strIN.Append(" ACCION_FORMATIVA.CODIGO_ESTADO_AF IN(") : strIN.Append(listaCODIGO_ESTADO_AF(i).ToString)
                    Else
                        strIN.Append(",") : strIN.Append(listaCODIGO_ESTADO_AF(i).ToString)
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

        If TDR <> "" Then
            AgregarCondicion(strSQLCondicion, " EXISTS (SELECT 1 FROM TERMINO_REFERENCIA_AF T WHERE T.ID_ACCION_FORMATIVA = ACCION_FORMATIVA.ID_ACCION_FORMATIVA AND RTRIM(T.TDR) = :TDR) ")
            Dim op As OracleParameter = New OracleParameter(":TDR", OracleType.NVarChar)
            op.Value = TDR
            args.Add(op)
        End If


        strSQL.AppendLine(strSQLCondicion.ToString)
        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As OracleDataReader
        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaACCION_FORMATIVA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA
                AsignarACCION_FORMATIVA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerAccionFormativa_Horario_enConflicto(ByVal ID_PARTICIPANTE As Int32, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32) As DataSet
        Dim arg As OracleParameter
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.Append("WITH H_HORARIO AS(  ")
        strSQL.Append(" SELECT S.ID_PARTICIPANTE, A.ID_ACCION_FORMATIVA, AF.NOMBRE_ACCION_FORMATIVA, AF.CODIGO_GRUPO, AF.FECHA_INICIO_REAL, AF.FECHA_FIN_REAL, ")
        strSQL.Append("     TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_INICIO,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS INICIO, ")
        strSQL.Append("     TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_FIN,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS FIN ")
        strSQL.Append(" FROM ACCION_FORMATIVA AF, SOLICITUD_INSCRIPCION_AF S, ASISTENCIA_AF A, ASISTENCIA_AF_HORARIO H ")
        strSQL.Append(" WHERE AF.ID_ACCION_FORMATIVA = S.ID_ACCION_FORMATIVA ")
        strSQL.Append(" AND S.ID_ACCION_FORMATIVA = A.ID_ACCION_FORMATIVA ")
        strSQL.Append(" AND A.ID_ASISTENCIA_AF = H.ID_ASISTENCIA_AF ")
        strSQL.Append(" AND S.ID_ESTADO_SOLICITUD IN(2,3,4) ")
        strSQL.Append(" AND S.ID_PARTICIPANTE = :ID_PARTICIPANTE ")
        strSQL.Append("), ")

        strSQL.Append("C_HORARIO AS( ")
        strSQL.Append(" SELECT  A.ID_ACCION_FORMATIVA, ")
        strSQL.Append("     TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_INICIO,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS INICIO, ")
        strSQL.Append("     TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_FIN,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS FIN ")
        strSQL.Append(" FROM ASISTENCIA_AF A, ASISTENCIA_AF_HORARIO H ")
        strSQL.Append(" WHERE A.ID_ASISTENCIA_AF = H.ID_ASISTENCIA_AF ")
        strSQL.Append(" AND A.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.Append(") ")

        strSQL.Append("SELECT DISTINCT H.ID_ACCION_FORMATIVA, H.NOMBRE_ACCION_FORMATIVA, H.CODIGO_GRUPO, H.INICIO, H.FIN ")
        strSQL.Append("FROM H_HORARIO H ")
        strSQL.Append("WHERE H.ID_ACCION_FORMATIVA <> :ID_ACCION_FORMATIVA ")
        strSQL.Append(" AND ( SELECT COUNT(*) ")
        strSQL.Append("       FROM C_HORARIO C  ")
        strSQL.Append("       WHERE (C.INICIO <= H.INICIO AND C.FIN >= H.INICIO) OR (C.INICIO <= H.FIN AND C.FIN >= H.FIN) ")
        strSQL.Append("     ) > 0 ")

        arg = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        arg.Value = ID_PARTICIPANTE
        args.Add(arg)

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA_A_INSCRIBIR
        args.Add(arg)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Return ds
    End Function



    Public Function ObtenerAccionFormativa_Horario_enConflictoFormador(ByVal CODI_FORMADOR As String, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32) As DataSet
        Dim arg As OracleParameter
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("WITH H_HORARIO AS(  ")
        strSQL.AppendLine("     SELECT AF.CODI_FORMADOR, A.ID_ACCION_FORMATIVA, AF.NOMBRE_ACCION_FORMATIVA, AF.CODIGO_GRUPO, AF.FECHA_INICIO_REAL, AF.FECHA_FIN_REAL, ")
        strSQL.AppendLine("         TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_INICIO,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS INICIO, ")
        strSQL.AppendLine("         TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_FIN,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS FIN ")
        strSQL.AppendLine("     FROM ACCION_FORMATIVA AF, ASISTENCIA_AF A, ASISTENCIA_AF_HORARIO H ")
        strSQL.AppendLine("     WHERE AF.ID_ACCION_FORMATIVA = A.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     AND A.ID_ASISTENCIA_AF = H.ID_ASISTENCIA_AF          ")
        strSQL.AppendLine("     AND AF.CODI_FORMADOR = :CODI_FORMADOR")
        strSQL.AppendLine("    ), ")
        strSQL.AppendLine(" ")
        strSQL.AppendLine("    C_HORARIO AS( ")
        strSQL.AppendLine("     SELECT  A.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine("         TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_INICIO,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS INICIO, ")
        strSQL.AppendLine("         TO_DATE(TO_CHAR(A.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_FIN,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS FIN ")
        strSQL.AppendLine("     FROM ASISTENCIA_AF A, ASISTENCIA_AF_HORARIO H ")
        strSQL.AppendLine("     WHERE A.ID_ASISTENCIA_AF = H.ID_ASISTENCIA_AF ")
        strSQL.AppendLine("     AND A.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("    ) ")
        strSQL.AppendLine(" ")
        strSQL.AppendLine("    SELECT DISTINCT H.ID_ACCION_FORMATIVA, H.NOMBRE_ACCION_FORMATIVA, H.CODIGO_GRUPO, H.INICIO, H.FIN ")
        strSQL.AppendLine("    FROM H_HORARIO H ")
        strSQL.AppendLine("    WHERE H.ID_ACCION_FORMATIVA <> :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("     AND ( SELECT COUNT(*) ")
        strSQL.AppendLine("           FROM C_HORARIO C  ")
        strSQL.AppendLine("   WHERE (C.INICIO <= H.INICIO AND C.FIN >= H.INICIO) OR (C.INICIO <= H.FIN AND C.FIN >= H.FIN) ")
        strSQL.AppendLine("         ) > 0 ")

        arg = New OracleParameter(":CODI_FORMADOR", OracleType.VarChar)
        arg.Value = CODI_FORMADOR
        args.Add(arg)

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA_A_INSCRIBIR
        args.Add(arg)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Return ds
    End Function

    Public Function ObtenerAccionFormativa_Horario_enConflictoFormador(ByVal CODI_FORMADOR As String, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32, ByVal FECHA_HORA_INICIO As DateTime, ByVal FECHA_HORA_FIN As DateTime) As DataSet
        Dim arg As OracleParameter
        Dim args As New List(Of OracleParameter)
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT * ")
        strSQL.AppendLine("FROM ( ")
        strSQL.AppendLine("    SELECT AF.CODI_FORMADOR, AF.ID_ACCION_FORMATIVA, AF.NOMBRE_ACCION_FORMATIVA, AF.CODIGO_GRUPO, AF.FECHA_INICIO_REAL, AF.FECHA_FIN_REAL, ")
        strSQL.AppendLine("           TO_DATE(TO_CHAR(E.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_INICIO,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS INICIO, ")
        strSQL.AppendLine("           TO_DATE(TO_CHAR(E.FECHA,'DD/MM/YYYY') || ' ' || TO_CHAR(H.HORA_FIN,'HH24:MI'),'DD/MM/YYYY HH24:MI') AS FIN ")
        strSQL.AppendLine("    FROM ASISTENCIA_AF E, ASISTENCIA_AF_HORARIO H, ACCION_FORMATIVA AF ")
        strSQL.AppendLine("    WHERE AF.ID_ACCION_FORMATIVA = E.ID_ACCION_FORMATIVA AND E.ID_ASISTENCIA_AF = H.ID_ASISTENCIA_AF ")
        strSQL.AppendLine("    AND AF.CODI_FORMADOR = :CODI_FORMADOR ")
        strSQL.AppendLine("    AND AF.ID_ACCION_FORMATIVA <> :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine(") T ")
        strSQL.AppendLine("WHERE (:FECHA_HORA_INICIO <= INICIO AND :FECHA_HORA_FIN >= INICIO) OR (:FECHA_HORA_INICIO <= FIN AND :FECHA_HORA_FIN >= FIN)  ")

        arg = New OracleParameter(":CODI_FORMADOR", OracleType.VarChar)
        arg.Value = CODI_FORMADOR
        args.Add(arg)

        arg = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        arg.Value = ID_ACCION_FORMATIVA_A_INSCRIBIR
        args.Add(arg)

        arg = New OracleParameter(":FECHA_HORA_INICIO", OracleType.DateTime)
        arg.Value = FECHA_HORA_INICIO
        args.Add(arg)

        arg = New OracleParameter(":FECHA_HORA_FIN", OracleType.DateTime)
        arg.Value = FECHA_HORA_FIN
        args.Add(arg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
        Return ds
    End Function
End Class
