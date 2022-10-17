Partial Class cASISTENCIA_AF_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet del Listado de Asistencia de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetListadoAsistencia(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal EsCursosFinalizado As Boolean) As DataSet
        Try
            Return mDb.ObtenerDataSetListadoAsistencia(ID_ASISTENCIA_AF, ID_ACCION_FORMATIVA, EsCursosFinalizado)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet del Listado de Asistencia de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetListaAsistencia(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) As DataSet
        Try
            Return mDb.ObtenerDataSetListaAsistencia(ID_ASISTENCIA_AF, ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	08/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Try
            'Verificar si la Fecha de Asistencia está reportada en algún Informe de Ejecución
            Dim lRet As Integer

            Dim bAsistenciaAF As New cASISTENCIA_AF
            Dim lAsistenciaAF As ASISTENCIA_AF = bAsistenciaAF.ObtenerASISTENCIA_AF(ID_ASISTENCIA_AF)
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(lAsistenciaAF.ID_ACCION_FORMATIVA, lAsistenciaAF.FECHA)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Asistencia debido a que existe un Informe de Ejecución Entregado."
                Return -1
            End If

            lRet = mDb.EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(ID_ASISTENCIA_AF)
            If lRet > 0 Then
                If lInformeEjecucion IsNot Nothing Then bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Optimistica, True)
            End If
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_DET"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    '''  	[cramos]	28/09/2010	Modificado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_DET(ByVal ID_ASISTENCIA_DET As Decimal) As Integer
        Try
            Dim lEntidad As ASISTENCIA_AF_DET
            lEntidad = Me.ObtenerASISTENCIA_AF_DET(ID_ASISTENCIA_DET)

            Return Me.EliminarASISTENCIA_AF_DET(lEntidad, TipoConcurrencia.Pesimistica)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_DET que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    '''     [cramos]	28/09/2010	Modificado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_DET(ByVal aEntidad As ASISTENCIA_AF_DET, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Verificar si la Fecha de Asistencia está reportada en algún Informe de Ejecución
            Dim bAsistenciaAF As New cASISTENCIA_AF
            Dim lAsistenciaAF As ASISTENCIA_AF = bAsistenciaAF.ObtenerASISTENCIA_AF(aEntidad.ID_ASISTENCIA_AF)
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(lAsistenciaAF.ID_ACCION_FORMATIVA, lAsistenciaAF.FECHA)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Asistencia debido a que existe un Informe de Ejecución Entregado."
                Return -1
            End If

            Dim lRet As Integer = mDb.Eliminar(aEntidad, aTipoConcurrencia)
            If lRet > 0 Then
                Me.ActualizarPorcentajeAsistencia(aEntidad)
                If lInformeEjecucion IsNot Nothing Then
                    lRet = bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Optimistica, True)
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
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.
    ''' Al mismo tiempo la inserción o actualización de este componente actualiza el Informe Final
    ''' si se encuentra creado
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    '''  	[cramos]	06/07/2010	Modificado
    '''     [cramos]	09/06/2011	Modificado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF_DET(ByVal aEntidad As ASISTENCIA_AF_DET) As Integer
        Try
            Return Me.ActualizarASISTENCIA_AF_DET(aEntidad, TipoConcurrencia.Pesimistica)

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
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Create
    ''' 	[cramos]	09/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF_DET(ByVal aEntidad As ASISTENCIA_AF_DET, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Integer = 0
            If aEntidad.ID_ASISTENCIA_DET = 0 Then
                'Verificar que no se haya creado asistencia para el participante
                Dim listaDetalleAsistencia As New listaASISTENCIA_AF_DET
                listaDetalleAsistencia = (New cASISTENCIA_AF_DET).ObtenerListaPorASISTENCIA_AF(aEntidad.ID_ASISTENCIA_AF)

                If Not listaDetalleAsistencia Is Nothing Then
                    If listaDetalleAsistencia.Count > 0 Then
                        For Each Inasistencia As ASISTENCIA_AF_DET In listaDetalleAsistencia
                            If Inasistencia.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE Then
                                Return 1
                            End If
                        Next
                    End If
                End If
            End If

            'Verificar si la Asistencia está reportada en algún Informe de Ejecución
            Dim bAsistenciaAF As New cASISTENCIA_AF
            Dim lAsistenciaAF As ASISTENCIA_AF = bAsistenciaAF.ObtenerASISTENCIA_AF(aEntidad.ID_ASISTENCIA_AF)
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(lAsistenciaAF.ID_ACCION_FORMATIVA, lAsistenciaAF.FECHA)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Asistencia debido a que existe un Informe Final Entregado."
                Return -1
            End If

            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            If lRet > 0 Then
                ActualizarPorcentajeAsistencia(aEntidad)
                If lInformeEjecucion IsNot Nothing Then
                    lRet = bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Optimistica, True)
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
    ''' Función que Actualiza el Porcentaje de Asistencia en PARTICIPANTE_AF por los parámetros recibidos
    ''' </summary>
    ''' <history>    
    '''     [cramos]	28/09/2011	Creado
    ''' </history>
    Public Sub ActualizarPorcentajeAsistencia(ByVal aEntidad As ASISTENCIA_AF_DET)
        Dim eParticipanteAf As New PARTICIPANTE_AF
        Dim bParticipanteAf As New cPARTICIPANTE_AF

        eParticipanteAf = bParticipanteAf.ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, (New cASISTENCIA_AF).ObtenerASISTENCIA_AF(aEntidad.ID_ASISTENCIA_AF).ID_ACCION_FORMATIVA)
        eParticipanteAf.PORC_ASISTENCIA = (New cACCION_FORMATIVA).ObtenerPorcentajeAsistenciaPromedio(eParticipanteAf.ID_ACCION_FORMATIVA, eParticipanteAf.ID_PARTICIPANTE)
        bParticipanteAf.ActualizarPARTICIPANTE_AF(eParticipanteAf)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza el Porcentaje de Asistencia en PARTICIPANTE_AF por los parámetros recibidos
    ''' </summary>
    ''' <history>    
    '''     [cramos]	28/09/2011	Creado
    ''' </history>
    Public Sub ActualizarPorcentajeAsistencia(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim eParticipanteAf As New PARTICIPANTE_AF
        Dim bParticipanteAf As New cPARTICIPANTE_AF

        eParticipanteAf = bParticipanteAf.ObtenerPARTICIPANTE_AF(ID_PARTICIPANTE, ID_ACCION_FORMATIVA)
        eParticipanteAf.PORC_ASISTENCIA = (New cACCION_FORMATIVA).ObtenerPorcentajeAsistenciaPromedio(eParticipanteAf.ID_ACCION_FORMATIVA, eParticipanteAf.ID_PARTICIPANTE)
        bParticipanteAf.ActualizarPARTICIPANTE_AF(eParticipanteAf)
    End Sub

End Class
