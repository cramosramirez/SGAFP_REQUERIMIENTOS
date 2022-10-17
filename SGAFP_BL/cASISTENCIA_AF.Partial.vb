Partial Class cASISTENCIA_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As DateTime, ByVal INSTRUCTOR As String, ByVal NOTAS As String) As Integer
        Try
            Dim lEntidad As New ASISTENCIA_AF
            lEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.FECHA = FECHA
            lEntidad.INSTRUCTOR = INSTRUCTOR
            lEntidad.NOTAS = NOTAS
            Return Me.ActualizarASISTENCIA_AF(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	21/04/2010	Se agrego forma unica de guardar
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF(ByVal aEntidad As ASISTENCIA_AF) As Integer
        Try
            Dim lRet As Integer

            'Verificar si la Fecha de Asistencia está reportada en algún Informe de Ejecución
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Evaluación debido a que existe un Informe de Ejecución Entregado."
                Return -1
            End If

            lRet = Me.ActualizarASISTENCIA_AF(aEntidad, TipoConcurrencia.Pesimistica)

            If lRet > 0 Then
                If lInformeEjecucion IsNot Nothing Then
                    lRet = bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Pesimistica, True)
                End If
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <returns>
    '''   1 : Agregar o Actualizar realizado Satisfactoriamente
    '''  -2 : No se puede Agregar una Fecha de Asistencia repetida para el mismo Curso
    '''  -3 : No se puede Actualizar a una Fecha de Asistencia ya existente en el mismo Curso
    '''  -4 : No se puede Actualizar a una Fecha de Asistencia que no este entre la Fecha Inicial y Final del Curso
    ''' </returns>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	21/04/2010	Se agrego validación de que no se repitan Fechas de 
    '''                             Asistencia por Accion Formativa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF(ByVal aEntidad As ASISTENCIA_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Dim eAccionFormativa As ACCION_FORMATIVA

            If aEntidad.ID_ASISTENCIA_AF = 0 Then
                Dim registros As Integer
                registros = Me.ObtenerCantidadAsistenciaPorFecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA)
                If registros > 0 Then
                    Me.sError = "No se puede Agregar una Fecha de Asistencia repetida para el mismo Curso."
                    Return -2
                End If
            ElseIf aEntidad.FECHA <> aEntidad.FECHAOld Then
                Dim registros As Integer
                registros = Me.ObtenerCantidadAsistenciaPorFecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA)
                If registros > 0 Then
                    Me.sError = "No se puede Actualizar a una Fecha de Asistencia ya existente en el mismo Curso."
                    Return -3
                End If
            End If

            'eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            'If Not (aEntidad.FECHA >= eAccionFormativa.FECHA_INICIO_REAL AndAlso aEntidad.FECHA <= eAccionFormativa.FECHA_FIN_REAL) Then
            '    Me.sError = "No se puede Actualizar a una Fecha de Asistencia que no este entre la Fecha Inicial y Final del Curso."
            '    Return -4
            'End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve un registro de la Asistencia por los parámetros enviados
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As ASISTENCIA_AF
        Try
            Return mDb.ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(ID_ACCION_FORMATIVA, FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de Asistencia por Fecha y Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	21/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadAsistenciaPorFecha(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As Integer
        Try
            Return mDb.ObtenerCantidadAsistenciaPorFecha(ID_ACCION_FORMATIVA, FECHA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[cramos]	06/07/2010	Modificado
    '''    Se agregó eliminación del detalle de asistencia
    '''     [cramos]	07/08/2012	Modificado
    '''     Se agrega validación para no eliminar si existe informe de ejecución generado para la fecha de asistencia
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF(ByVal aEntidad As ASISTENCIA_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Integer
            Dim mEntidadAccionFormativa As ACCION_FORMATIVA

            mEntidad = Me.ObtenerASISTENCIA_AF(aEntidad.ID_ASISTENCIA_AF)

            'Verificar si la Evaluación está reportada en algún Informe de Ejecución
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(mEntidad.ID_ACCION_FORMATIVA, mEntidad.FECHA)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Evaluación debido a que existe un Informe de Ejecución Entregado."
                Return -1
            End If

            mEntidadAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(mEntidad.ID_ACCION_FORMATIVA)

            EliminarAsistenciaDetalle(aEntidad.ID_ASISTENCIA_AF)
            lRet = mDb.Eliminar(aEntidad, aTipoConcurrencia)

            If lRet > 0 Then
                If lInformeEjecucion IsNot Nothing Then bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Pesimistica, True)
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Try
            Dim lRet As Integer
            mEntidad = Me.ObtenerASISTENCIA_AF(ID_ASISTENCIA_AF)

            lRet = Me.EliminarASISTENCIA_AF(mEntidad, TipoConcurrencia.Pesimistica)
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1

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
    ''' 	[cramos]	07/06/2010	Función que elimina el detalle de las asistencia
    ''' 	[cramos]	25/03/2011	Se agrega lógica para eliminar el horario del día de As
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function EliminarAsistenciaDetalle(ByVal ID_ASISTENCIA_AF As Decimal) As Integer

        Dim cAsistenciaDet As New cASISTENCIA_AF_DET
        Dim lDetalle As listaASISTENCIA_AF_DET = cAsistenciaDet.ObtenerListaPorASISTENCIA_AF(ID_ASISTENCIA_AF)

        For Each lAsistenciaDet As ASISTENCIA_AF_DET In lDetalle
            cAsistenciaDet.EliminarASISTENCIA_AF_DET(lAsistenciaDet, TipoConcurrencia.Pesimistica)
        Next

        Dim cAsistenciaHorario As New cASISTENCIA_AF_HORARIO
        cAsistenciaHorario.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(ID_ASISTENCIA_AF)
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_HORARIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF">Id de la Asistencia.</param>
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/06/2010	Función que elimina el detalle de las asistencia
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function EliminarAsistenciaHorario(ByVal ID_ASISTENCIA_AF As Decimal)

        Dim cAsistenciaH As New cASISTENCIA_AF_HORARIO

        Try
            Return cAsistenciaH.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(ID_ASISTENCIA_AF)

        Catch ex As Exception
            Return -1

        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla INFORME_FINAL_AF .
    ''' </summary>
    ''' <param name="idInformeFinal"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorINFORME_FINAL_AF(ByVal idInformeFinal As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaASISTENCIA_AF
        Try
            Return mDb.ObtenerListaPorINFORME_FINAL_AF(idInformeFinal, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista de posibles fechas finales de cada mes de ejecución 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	22/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFechasFinalizacionPorMes(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIO_PERIODO As Date) As List(Of Date)
        Try
            Return mDb.ObtenerFechasFinalizacionPorMes(ID_ACCION_FORMATIVA, FECHA_INICIO_PERIODO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
