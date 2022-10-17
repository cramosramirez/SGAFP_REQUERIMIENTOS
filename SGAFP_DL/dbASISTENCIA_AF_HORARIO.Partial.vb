﻿Partial Public Class dbASISTENCIA_AF_HORARIO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_HORARIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF">ID de la ASISTENCIA de la cual se desea eliminar el horario </param>  
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer

        Dim strSQL As New StringBuilder
        Dim args As New List(Of OracleParameter)

        strSQL.Append("DELETE FROM ASISTENCIA_AF_HORARIO ")
        strSQL.Append("WHERE ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF")

        Dim arg As OracleParameter = New OracleParameter(":ID_ASISTENCIA_AF", OracleType.Number)
        arg.Value = ID_ASISTENCIA_AF
        args.Add(arg)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray)
    End Function


End Class
