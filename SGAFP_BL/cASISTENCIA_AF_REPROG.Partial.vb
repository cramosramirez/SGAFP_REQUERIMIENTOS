Partial Public Class cASISTENCIA_AF_REPROG
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve un registro de la Asistencia_Reprog por los parámetros enviados
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerASISTENCIA_AFPorIdAccionFormativaReprog_Fecha(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal FECHA As Date) As ASISTENCIA_AF_REPROG
        Try
            Return mDb.ObtenerASISTENCIA_AF_REPROG_PorIdAccionFormativaReprog_Fecha(ID_ACCION_FORMATIVA_REPROG, FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_DET, ASISTENCIA_AF_HORARIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF">Id de la Asistencia.</param>
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/03/2011	Función que elimina el horario del día de AsistenciaReprog
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function EliminarHorarioReprog(ByVal ID_ASISTENCIA_AF As Decimal) As Integer

        Dim cAsistenciaHorario As New cASISTENCIA_AF_HORARIO_REPROG
        cAsistenciaHorario.EliminarASISTENCIA_AF_HORARIO_REPROGPorID_ASISTENCIA_AF(ID_ASISTENCIA_AF)
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_REPROG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    '''     [cramos]	25/03/2011	Se agrega lógica para eliminar el horario del día Reprogramado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_REPROG(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Try
            mEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            EliminarHorarioReprog(ID_ASISTENCIA_AF)

            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_REPROG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    '''     [cramos]	25/03/2011	Se agrega lógica para eliminar el horario del día Reprogramado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_REPROG(ByVal aEntidad As ASISTENCIA_AF_REPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Me.EliminarHorarioReprog(aEntidad.ID_ASISTENCIA_AF)

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


End Class
