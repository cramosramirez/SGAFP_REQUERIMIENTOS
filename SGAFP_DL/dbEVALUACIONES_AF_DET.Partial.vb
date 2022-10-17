Partial Class dbEVALUACIONES_AF_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	16/05/2011	Se agrego que filtrara solo los Participantes Validos(Inscrito y Evaluado)
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACIONES_AF_DET

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT EVALUACIONES_AF_DET.* ")
        strSQL.Append("FROM EVALUACIONES_AF_DET, PARTICIPANTE ")
        strSQL.Append("WHERE EVALUACIONES_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.Append("AND EVALUACIONES_AF_DET.ID_EVALUACION_AF = :ID_EVALUACION_AF ")
        strSQL.Append("AND EXISTS (SELECT 1 FROM PARTICIPANTE_AF PAF, EVALUACION_AF E ")
        strSQL.Append("             WHERE E.ID_EVALUACION_AF = EVALUACIONES_AF_DET.ID_EVALUACION_AF ")
        strSQL.Append("             AND PAF.ID_PARTICIPANTE = EVALUACIONES_AF_DET.ID_PARTICIPANTE ")
        strSQL.Append("             AND PAF.ESTADO IN (")
        strSQL.Append("'" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "',")
        strSQL.Append("'" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "',")
        strSQL.Append("'" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "')")
        strSQL.Append("            )")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        Else
            strSQL.Append(" ORDER BY PARTICIPANTE.APELLIDOS, PARTICIPANTE.NOMBRES " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_EVALUACION_AF", OracleType.Number)
        args(0).Value = ID_EVALUACION_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaEVALUACIONES_AF_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New EVALUACIONES_AF_DET
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


    Public Function ObtenerListaPorEVALUACION_AF_TODO(ByVal ID_EVALUACION_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACIONES_AF_DET

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM EVALUACIONES_AF_DET ")
        strSQL.Append("WHERE ID_EVALUACION_AF = :ID_EVALUACION_AF ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_EVALUACION_AF", OracleType.Number)
        args(0).Value = ID_EVALUACION_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaEVALUACIONES_AF_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New EVALUACIONES_AF_DET
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/12/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerlistaPorACCION_FORMATIVA_PorPARTICIPANTE(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACIONES_AF_DET

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT EVALUACIONES_AF_DET.* ")
        strSQL.Append("FROM EVALUACIONES_AF_DET, PARTICIPANTE ")
        strSQL.Append("WHERE EVALUACIONES_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.Append("AND EVALUACIONES_AF_DET.ID_EVALUACION_AF = :ID_EVALUACION_AF ")

        If asColumnaOrden <> "" Then
            strSQL.Append(" ORDER BY " + asColumnaOrden + " " + asTipoOrden)
        Else
            strSQL.Append(" ORDER BY PARTICIPANTE.APELLIDOS, PARTICIPANTE.NOMBRES " + asTipoOrden)
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        args(1) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(1).Value = ID_PARTICIPANTE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaEVALUACIONES_AF_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New EVALUACIONES_AF_DET
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
