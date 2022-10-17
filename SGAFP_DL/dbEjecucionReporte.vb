Public Class dbEjecucionReporte
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As EL.entidadBase) As Object

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Function RecuperarParticipantesActivos(ByVal NO_CONVOCATORIA As Decimal, ByVal ID_FUENTE As Decimal, ByVal ds As DS_DL) As Integer

        Dim tables(0) As String
        tables(0) = "PATIParticipantesActivosYNoActivos"
        Dim args(2) As OracleParameter
        args(0) = New OracleParameter("NUMERO_CONVOCATORIA", OracleType.Number)
        args(0).Value = NO_CONVOCATORIA
        args(1) = New OracleParameter("FUENTE", OracleType.Number)
        args(1).Value = ID_FUENTE
        args(2) = New OracleParameter("curparticipantes", OracleType.Cursor)
        args(2).Direction = ParameterDirection.Output

        Me.sql.FillDataset(Me.cnnStr, CommandType.StoredProcedure, "participantes_activos", ds, tables, args)

        If ds Is Nothing Then Return -1

        'If ds.PATIParticipantesActivosYNoActivos Is Nothing Then Return -1

        Return 1

    End Function

End Class
