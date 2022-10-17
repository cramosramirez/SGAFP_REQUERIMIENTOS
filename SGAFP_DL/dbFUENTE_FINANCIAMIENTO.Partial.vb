Partial Public Class dbFUENTE_FINANCIAMIENTO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Integers de las Convocatorias en las que están activos
    ''' los participantes del programa PATI filtrada por Tipo de Solicitud.
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/10/2011	Created    
    '''  	[cramos]	11/10/2011	Modificada: Se cambia firma del método de tipo de Solicitud a Programa Formación   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaConvocatoriasPorTipoSolicitud(ByVal ID_TIPO_SOLICITUD As Decimal) As List(Of Integer)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT DISTINCT NO_CONVOCATORIA ")
        strSQL.AppendLine("FROM DETA_FAMI F ")
        strSQL.AppendLine("WHERE EXISTS( ")
        strSQL.AppendLine("  SELECT 1 FROM FICHA_PATI FP ")
        strSQL.AppendLine("  WHERE FP.NUME_FICH = F.NUME_FICH_PATI ")
        strSQL.AppendLine("  AND EXISTS(SELECT 1 FROM SOLICITUD_INSCRIPCION_AF S, FASE_MUNICIPIOS FM ")
        strSQL.AppendLine("            WHERE S.ID_PARTICIPANTE = FP.ID_PARTICIPANTE ")
        strSQL.AppendLine("            AND S.CODIGO_DEPARTAMENTO = FM.CODIGO_DEPARTAMENTO ")
        strSQL.AppendLine("            AND S.CODIGO_MUNICIPIO = FM.CODIGO_MUNICIPIO ")
        strSQL.AppendLine("            AND S.ID_TIPO_SOLICITUD = :ID_TIPO_SOLICITUD) ")
        strSQL.AppendLine(") ORDER BY NO_CONVOCATORIA")

        Dim arg As OracleParameter
        arg = New OracleParameter(":ID_TIPO_SOLICITUD", OracleType.Number)
        arg.Value = ID_TIPO_SOLICITUD

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), arg)

        Dim lista As New List(Of Integer)

        Try
            Do While dr.Read()
                lista.Add(CInt(dr("NO_CONVOCATORIA")))
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
    ''' Función que Devuelve una Colección de Integers de las Convocatorias en las que están activos
    ''' los participantes del programa PATI filtrada por Tipo de Programa.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/10/2012	Created    
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaConvocatoriasPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Decimal) As List(Of Integer)

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT DISTINCT NO_CONVOCATORIA ")
        strSQL.AppendLine("FROM DETA_FAMI F ")
        strSQL.AppendLine("WHERE EXISTS( ")
        strSQL.AppendLine("  SELECT 1 FROM FICHA_PATI FP ")
        strSQL.AppendLine("  WHERE FP.NUME_FICH = F.NUME_FICH_PATI ")
        strSQL.AppendLine("  AND EXISTS(SELECT 1 FROM ACCION_FORMATIVA_DETALLE AD, SOLICITUD_INSCRIPCION_AF S ")
        strSQL.AppendLine("            WHERE AD.ID_ACCION_FORMATIVA = S.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("            AND S.ID_PARTICIPANTE = FP.ID_PARTICIPANTE ")
        strSQL.AppendLine("            AND AD.ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION) ")
        strSQL.AppendLine(") ORDER BY NO_CONVOCATORIA")

        Dim arg As OracleParameter
        arg = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        arg.Value = ID_PROGRAMA_FORMACION

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), arg)

        Dim lista As New List(Of Integer)

        Try
            Do While dr.Read()
                lista.Add(CInt(dr("NO_CONVOCATORIA")))
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
    ''' Función que Devuelve una Colección de Entidades filtrada por MUNICIPIO.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	11/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMunicipio(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaFUENTE_FINANCIAMIENTO

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(Me.QuerySelect(New FUENTE_FINANCIAMIENTO))
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM")
        strSQL.AppendLine("               WHERE FM.ID_FUENTE = FUENTE_FINANCIAMIENTO.ID_FUENTE")
        strSQL.AppendLine("                 AND FM.CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO")
        strSQL.AppendLine("                 AND FM.CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO)")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO
        args(1) = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
        args(1).Value = CODIGO_MUNICIPIO

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaFUENTE_FINANCIAMIENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New FUENTE_FINANCIAMIENTO
                dbAsignarEntidades.AsignarFUENTE_FINANCIAMIENTO(dr, mEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por TecnicoMunicipio.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTecnico(ByVal USUARIO_TECNICO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaFUENTE_FINANCIAMIENTO

        Dim strSQL As New StringBuilder
        strSQL.AppendLine(Me.QuerySelect(New FUENTE_FINANCIAMIENTO))
        strSQL.AppendLine("WHERE EXISTS (SELECT 1 FROM FASE_MUNICIPIOS FM, TECNICOS_MUNICIPIOS_PATI_ASIG T")
        strSQL.AppendLine("               WHERE FM.ID_FUENTE = FUENTE_FINANCIAMIENTO.ID_FUENTE")
        strSQL.AppendLine("                 AND FM.CODIGO_DEPARTAMENTO = T.CODIGO_DEPARTAMENTO")
        strSQL.AppendLine("                 AND FM.CODIGO_MUNICIPIO = T.CODIGO_MUNICIPIO")
        strSQL.AppendLine("                 AND T.USUARIO = :USUARIO_TECNICO)")

        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":USUARIO_TECNICO", OracleType.VarChar)
        args(0).Value = USUARIO_TECNICO

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaFUENTE_FINANCIAMIENTO

        Try
            Do While dr.Read()
                Dim mEntidad As New FUENTE_FINANCIAMIENTO
                dbAsignarEntidades.AsignarFUENTE_FINANCIAMIENTO(dr, mEntidad)
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
