Partial Class cEVALUACION_AF

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
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarEVALUACION_AF(ByVal aEntidad As EVALUACION_AF) As Integer
        Try
            Return Me.ActualizarEVALUACION_AF(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	13/05/2010	Se agrego logica para creacion de Evaluaciones por Participante Inscrito
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarEVALUACION_AF(ByVal aEntidad As EVALUACION_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim liRet As Integer
            Dim esNuevo As Boolean = (aEntidad.ID_EVALUACION_AF = 0)
            Dim lEntidadAsistencia As ASISTENCIA_AF

            'La fecha de la evaluación debe ser una fecha de la programación del curso
            lEntidadAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA_EVALUACION)
            If lEntidadAsistencia Is Nothing Then
                Me.sError = "La Fecha de la Evaluacion debe ser una Fecha de la Programacion del Curso."
                Return -1
            End If

            If aEntidad.TEMA_EVALUACION.Trim = String.Empty Then
                Me.sError = "El Tema de la Evaluacion es obligatorio."
                Return -1
            End If

            If aEntidad.TIPO_EVALUACION <> "P" AndAlso aEntidad.TIPO_EVALUACION <> "T" Then
                Me.sError = "El Tipo de Evaluacion debe ser Practica o Teorica."
                Return -1
            End If

            'Verificar si la Evaluación está reportada en algún Informe de Ejecución
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA_EVALUACION)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "La Fecha de la Evaluacion esta comprendida en las Fechas de Ejecucion de un Infome que se encuentra entregado."
                Return -1
            End If

            liRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If liRet = 1 And esNuevo Then
                'Crear Evaluaciones de Detalle para la Accion Formativa que se recibe
                Dim listaParticipantesInscritos As listaPARTICIPANTE_AF
                listaParticipantesInscritos = (New cPARTICIPANTE_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)

                Dim lcEVALUACIONES_AF_DET As New cEVALUACIONES_AF_DET

                For Each lParticipante As PARTICIPANTE_AF In listaParticipantesInscritos

                    If lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Inscrito OrElse _
                       lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Evaluado Then
                        Dim lEntidad As New EVALUACIONES_AF_DET
                        lEntidad.ID_EVALUACION_AF = aEntidad.ID_EVALUACION_AF
                        lEntidad.ID_EVALUACION_DET = 0
                        lEntidad.ID_PARTICIPANTE = lParticipante.ID_PARTICIPANTE
                        lEntidad.NOTA_OBTENIDA = 0
                        If lcEVALUACIONES_AF_DET.ActualizarEVALUACIONES_AF_DET(lEntidad) <> 1 Then
                            Me.sError = "Error al Crear Detalle de Evaluacion."
                            Return -2
                        End If
                    End If

                Next
            End If

            If lInformeEjecucion IsNot Nothing Then bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion, TipoConcurrencia.Optimistica, True)
            Return liRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla EVALUACION_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[cramos]	07/06/2010	Se agrego borrado de Detalle de la Evaluacion
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal) As Integer
        Try
            Dim lRet As Integer
            Dim lEntidad As EVALUACION_AF
            lEntidad = Me.ObtenerEVALUACION_AF(ID_EVALUACION_AF)

            lRet = EliminarEVALUACION_AF(lEntidad, TipoConcurrencia.Pesimistica)
            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla EVALUACION_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[cramos]	07/06/2010	Se agrego eliminación del detalle de la Evaluacion
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarEVALUACION_AF(ByVal aEntidad As EVALUACION_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Integer

            'Verificar si la Fecha de Asistencia está reportada en algún Informe de Ejecución
            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA_EVALUACION)
            If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                 lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.sError = "Error al Actualizar Evaluación debido a que existe un Informe de Ejecución Entregado."
                Return -1
            End If

            If EliminarEvaluacionDetalle(aEntidad.ID_EVALUACION_AF) < 1 Then
                Me.sError = "Error al eliminar Detalle de Evaluacion."
                Return -2
            End If

            lRet = mDb.Eliminar(aEntidad, aTipoConcurrencia)

            '   Actualizar informe final si existiese
            If lRet > 0 Then
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
    ''' Función que Elimina un Registro de la Tabla EVALUACION_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF">Id de la Evaluación.</param>
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/06/2010	Función que elimina el detalle de una Evaluación
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function EliminarEvaluacionDetalle(ByVal ID_EVALUACION_AF As Decimal)

        Dim cEvaluacionDet As New cEVALUACIONES_AF_DET
        Dim lDetalle As listaEVALUACIONES_AF_DET = cEvaluacionDet.ObtenerListaPorEVALUACION_AF_TODO(ID_EVALUACION_AF)

        For Each lEvaluacionDet As EVALUACIONES_AF_DET In lDetalle
            If cEvaluacionDet.EliminarEVALUACIONES_AF_DET(lEvaluacionDet, TipoConcurrencia.Pesimistica) < 0 Then
                Return -2
            End If
        Next

        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVAPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIO_EVALUACION As Date, ByVal FECHA_FIN_EVALUACION As Date, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACION_AF
        Try
            Dim mListaEVALUACION_AF As New listaEVALUACION_AF
            mListaEVALUACION_AF = mDb.ObtenerListaPorACCION_FORMATIVAPeriodo(ID_ACCION_FORMATIVA, FECHA_INICIO_EVALUACION, FECHA_FIN_EVALUACION, asColumnaOrden, asTipoOrden)
            Return mListaEVALUACION_AF
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
