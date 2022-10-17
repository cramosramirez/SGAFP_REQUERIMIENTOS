Imports SGAFP.EL.Enumeradores


''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cACCION_FORMATIVA_REPROG
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ACCION_FORMATIVA_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cACCION_FORMATIVA_REPROG
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbACCION_FORMATIVA_REPROG()
    Private mEntidad as New ACCION_FORMATIVA_REPROG
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New ListaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG in  mListaACCION_FORMATIVA_REPROG
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerACCION_FORMATIVA_REPROG(ByRef aEntidad As ACCION_FORMATIVA_REPROG, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ACCION_FORMATIVA_REPROG.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA_REPROG"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerACCION_FORMATIVA_REPROG(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As ACCION_FORMATIVA_REPROG
        Try
            Dim lEntidad As New ACCION_FORMATIVA_REPROG
            lEntidad.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_REPROG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA_REPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_REPROG(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal) As Integer
        Try
            mEntidad.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_REPROG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_REPROG(ByVal aEntidad As ACCION_FORMATIVA_REPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarACCION_FORMATIVA_REPROG(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal ID_ESTADO_REPROG As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal, ByVal ID_EJERCICIO As String, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal NUMERO_PARTICIPANTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal HORARIO As String, ByVal NOTAS As String, ByVal CODIGO_ESTADO_AF As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal FECHA_INICIO_REAL As DateTime, ByVal FECHA_FIN_REAL As DateTime, ByVal FECHA_SOLIC_REPROG As DateTime, ByVal CODI_FORMADOR As String, ByVal NOMBRE_FORMADOR As String) As Integer
        Try
            Dim lEntidad As New ACCION_FORMATIVA_REPROG
            lEntidad.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
            lEntidad.ID_ESTADO_REPROG = ID_ESTADO_REPROG
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_TEMA_CURSO = ID_TEMA_CURSO
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.NUMERO_PARTICIPANTES = NUMERO_PARTICIPANTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.HORARIO = HORARIO
            lEntidad.NOTAS = NOTAS
            lEntidad.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.FECHA_INICIO_REAL = FECHA_INICIO_REAL
            lEntidad.FECHA_FIN_REAL = FECHA_FIN_REAL
            lEntidad.FECHA_SOLIC_REPROG = FECHA_SOLIC_REPROG
            lEntidad.CODI_FORMADOR = CODI_FORMADOR
            lEntidad.NOMBRE_FORMADOR = NOMBRE_FORMADOR
            Return Me.ActualizarACCION_FORMATIVA_REPROG(lEntidad, "")
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_REPROG(ByVal aEntidad As ACCION_FORMATIVA_REPROG) As Integer
        Try
            Return Me.ActualizarACCION_FORMATIVA_REPROG(aEntidad, TipoConcurrencia.Pesimistica)

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
    ''' 	[GenApp]	01/06/2010	Created
    '''     [cramos]	12/08/2010	Se agrego Logica para enviar correo electrónico al técnico para notificarle de la reprogramación
    ''' 	[cramos]	12/12/2012	Se modifica lógica para utilizar Programa de Formación en lugar de Tipo de Solicitud
    ''' </history>
    ''' 
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_REPROG(ByVal aEntidad As ACCION_FORMATIVA_REPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim esNuevo As Boolean
            Dim aListaAccionFormativa As listaACCION_FORMATIVA
            Dim mEntidadReprog As ACCION_FORMATIVA_REPROG
            Dim lTerminoRef As TERMINO_REFERENCIA_AF

            If aEntidad.ID_ACCION_FORMATIVA_REPROG = 0 Then esNuevo = True
            aListaAccionFormativa = (New dbACCION_FORMATIVA).ObtenerListaPorCriteriosFijos( _
                    aEntidad.ID_PROVEEDOR_AF, aEntidad.CODIGO_GRUPO, aEntidad.ID_EJERCICIO)

            For Each cEntidadCurso As ACCION_FORMATIVA In aListaAccionFormativa
                If cEntidadCurso.ID_ACCION_FORMATIVA <> aEntidad.ID_ACCION_FORMATIVA Then
                    Me.sError = "Codigo de grupo ya esta asignado para el Ejercicio " + aEntidad.ID_EJERCICIO
                    Return -1
                End If
            Next

            If esNuevo Then
                'Verificar que no exista una reprogramación solicitada para la accion formativa
                mEntidadReprog = ObtenerACCION_FORMATIVA_REPROG_POR_ESTADO(aEntidad.ID_ACCION_FORMATIVA, Enumeradores.EstadoReprogramaciones.Solicitada)
                If mEntidadReprog.ID_ACCION_FORMATIVA_REPROG > 0 Then
                    Me.sError = "Ya existe una reprogramacion pendiente para este curso"
                    Return -1
                End If
            End If

            'El cupo no debe ser mayor de 22 participantes
            If aEntidad.NUMERO_PARTICIPANTES > 22 AndAlso aEntidad.ID_SITIO_CAPACITACION <> -1 Then
                Me.sError = "Cupo no puede ser mayor de 22 participantes"
                Return -1
            End If

            'Validar que la Fecha Inicial no sea menor que la Fecha Final
            If aEntidad.FECHA_INICIO_REAL > aEntidad.FECHA_FIN_REAL Then
                Me.sError = "La Fecha de Inicio no puede ser mayor que la Fecha de Finalizacion del Curso"
                Return -1
            End If

            lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(aEntidad.ID_ACCION_FORMATIVA)
            If lTerminoRef Is Nothing OrElse lTerminoRef.ID_ACCION_FORMATIVA <= 0 AndAlso aEntidad.ID_OFERTA_FORMATIVA > 0 Then
                'Validar que las fechas de la Accion Formativa se encuentren en el Rango de Fechas de la Oferta Formativa
                Dim lEntidadOferta As OFERTA_FORMATIVA = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(aEntidad.ID_OFERTA_FORMATIVA)
                If lEntidadOferta IsNot Nothing AndAlso lEntidadOferta.ID_OFERTA_FORMATIVA > 0 AndAlso Not (aEntidad.FECHA_INICIO_REAL >= lEntidadOferta.FECHA_INICIO AndAlso aEntidad.FECHA_FIN_REAL <= lEntidadOferta.FECHA_FIN) Then
                    Me.sError = "La Fechas de Inicio / Finalizacion de la Reprogramación deben estar comprendidas entre el " + _
                        lEntidadOferta.FECHA_INICIO.ToString("dd/MM/yyyy") + " al " + lEntidadOferta.FECHA_FIN.ToString("dd/MM/yyyy")
                    Return -1
                End If
            End If

            If mDb.Actualizar(aEntidad, aTipoConcurrencia) <> 1 Then
                Me.sError = "La Solicitud de Reprogramacion no se logro actualizar"
                Return -1
            End If

            If esNuevo AndAlso aEntidad.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Solicitada Then
                'Cambiar al estado en solicitud de reprogramación el curso
                Dim AccionFormativa As New cACCION_FORMATIVA
                Dim eAccionFormativa As ACCION_FORMATIVA

                eAccionFormativa = AccionFormativa.ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion
                eAccionFormativa.OBSERVACIONES = aEntidad.MOTIVOREPROG
                If AccionFormativa.ActualizarACCION_FORMATIVA(eAccionFormativa, TipoConcurrencia.Pesimistica, True, True, False) <> 1 Then
                    Me.sError = "Estado del Curso no se cambio a En Solicitud de Reprogramacion. Motivo: " + AccionFormativa.sError
                    Me.EliminarACCION_FORMATIVA_REPROG(aEntidad.ID_ACCION_FORMATIVA_REPROG)
                    Return -1
                End If

                If EnviarSolicitudPorCorreo(eAccionFormativa, ObtenerCuerpoCorreoSolicReprog(eAccionFormativa, aEntidad), Utilerias.ObtenerUsuario) <> 1 Then
                    Me.sError = "El supervisor de INSAFORP no pudo ser notificado por correo de la Solicitud de Reprogramacion."
                    Return -2
                End If
            ElseIf Not esNuevo Then
                    Dim EstadoAF As String = ""

                    If aEntidad.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Aprobada Then
                        EstadoAF = Enumeradores.EstadoAccionFormativa.ReprogramacionAprobada
                        'Enviar correo de resultado de la evaluación al centro de formación
                        If EnviarResultadoEvaluacionPorCorreo(Me.ObtenerCuerpoCorreoEvaluacionReprog(aEntidad), Utilerias.ObtenerUsuario, aEntidad.USERIDOld) <> 1 Then
                            Me.sError = "El Centro de Formacion no pudo ser notificado por correo del Resultado de la Evaluacion de la Reprogramacion."
                            Return -2
                        End If
                    End If
                    If aEntidad.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Rechazada Then
                        EstadoAF = Enumeradores.EstadoAccionFormativa.ReprogramacionRechazada
                        'Enviar correo de resultado de la evaluación al centro de formación
                        If EnviarResultadoEvaluacionPorCorreo(Me.ObtenerCuerpoCorreoEvaluacionReprog(aEntidad), Utilerias.ObtenerUsuario, aEntidad.USERIDOld) <> 1 Then
                            Me.sError = "El Centro de Formacion no pudo ser notificado por correo del Resultado de la Evaluacion de la Reprogramacion."
                            Return -2
                        End If
                    End If

                    If aEntidad.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Aprobada OrElse _
                        aEntidad.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Rechazada Then
                    If (New cACCION_FORMATIVA_HIST).AgregarACCION_FORMATIVA_HIST(0, aEntidad.ID_ACCION_FORMATIVA, _
                            aEntidad.ID_OFERTA_FORMATIVA, aEntidad.ID_SITIO_CAPACITACION, aEntidad.ID_PROVEEDOR_AF, _
                            aEntidad.ID_TEMA_CURSO, aEntidad.ID_EJERCICIO, aEntidad.NOMBRE_ACCION_FORMATIVA, _
                            aEntidad.CODIGO_GRUPO, aEntidad.NUMERO_PARTICIPANTES, aEntidad.PARTICIPANTES_INSCRITOS, _
                            aEntidad.HORARIO, aEntidad.NOTAS, EstadoAF, aEntidad.DURACION_HORAS, _
                            aEntidad.COSTO_X_PARTICIPANTE, Now, Utilerias.ObtenerUsuario, _
                            aEntidad.FECHA_INICIO_REAL, aEntidad.FECHA_FIN_REAL, aEntidad.MOTIVOREPROG, -1, aEntidad.CODI_FORMADOR, aEntidad.NOMBRE_FORMADOR) <> 1 Then
                    End If
                    End If
            End If
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_REPROG(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal, ByVal ID_ESTADO_REPROG As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal, ByVal ID_EJERCICIO As String, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal NUMERO_PARTICIPANTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal HORARIO As String, ByVal NOTAS As String, ByVal CODIGO_ESTADO_AF As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal FECHA_INICIO_REAL As DateTime, ByVal FECHA_FIN_REAL As DateTime, ByVal FECHA_SOLIC_REPROG As DateTime, ByVal CODI_FORMADOR As String, ByVal NOMBRE_FORMADOR As String) As Integer
        Try
            Dim lEntidad As New ACCION_FORMATIVA_REPROG
            lEntidad.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
            lEntidad.ID_ESTADO_REPROG = ID_ESTADO_REPROG
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_TEMA_CURSO = ID_TEMA_CURSO
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.NUMERO_PARTICIPANTES = NUMERO_PARTICIPANTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.HORARIO = HORARIO
            lEntidad.NOTAS = NOTAS
            lEntidad.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.FECHA_INICIO_REAL = FECHA_INICIO_REAL
            lEntidad.FECHA_FIN_REAL = FECHA_FIN_REAL
            lEntidad.FECHA_SOLIC_REPROG = FECHA_SOLIC_REPROG
            lEntidad.CODI_FORMADOR = CODI_FORMADOR
            lEntidad.NOMBRE_FORMADOR = NOMBRE_FORMADOR
            Return Me.ActualizarACCION_FORMATIVA_REPROG(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_REPROG .
    ''' </summary>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_REPROG(ByVal ID_ESTADO_REPROG As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New listaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorESTADO_REPROG(ID_ESTADO_REPROG, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG In mListaACCION_FORMATIVA_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla OFERTA_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New listaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG In mListaACCION_FORMATIVA_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SITIO_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New listaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG In mListaACCION_FORMATIVA_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New listaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG In mListaACCION_FORMATIVA_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_ACCION_FORMATIVA(ByVal CODIGO_ESTADO_AF As String, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim mListaACCION_FORMATIVA_REPROG As New listaACCION_FORMATIVA_REPROG
            mListaACCION_FORMATIVA_REPROG = mDb.ObtenerListaPorESTADO_ACCION_FORMATIVA(CODIGO_ESTADO_AF, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_FORMATIVA_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_FORMATIVA_REPROG In mListaACCION_FORMATIVA_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_FORMATIVA_REPROG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ACCION_FORMATIVA_REPROG)
        aEntidad.fkID_ESTADO_REPROG = (New cESTADO_REPROG).ObtenerESTADO_REPROG(aEntidad.ID_ESTADO_REPROG)
        aEntidad.fkID_OFERTA_FORMATIVA = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(aEntidad.ID_OFERTA_FORMATIVA)
        aEntidad.fkID_SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(aEntidad.ID_SITIO_CAPACITACION)
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkCODIGO_ESTADO_AF = (New cESTADO_ACCION_FORMATIVA).ObtenerESTADO_ACCION_FORMATIVA(aEntidad.CODIGO_ESTADO_AF)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ACCION_FORMATIVA_REPROG)
    End Sub

#End Region

End Class
