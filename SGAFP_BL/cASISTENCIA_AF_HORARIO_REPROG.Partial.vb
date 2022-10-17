Partial Public Class cASISTENCIA_AF_HORARIO_REPROG
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina todos los Registro de la Tabla ASISTENCIA_AF_HORARIO tomando como referencia los parámetros enviados.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_HORARIO_REPROGPorID_ASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Try

            Return mDb.EliminarASISTENCIA_AF_HORARIO_REPROGPorID_ASISTENCIA_AF(ID_ASISTENCIA_AF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
