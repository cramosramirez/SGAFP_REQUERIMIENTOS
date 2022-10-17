Partial Public Class cACCION_CONTRATADA
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaACCION_CONTRATADA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, NUM_CONTRATO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposCapacitacionPATIparaAsociar(ByVal ID_FUENTE As Decimal, _
                                            ByVal NO_CONVOCATORIA As Decimal, _
                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                            ByVal CODIGO_MUNICIPIO As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerGruposCapacitacionPATIparaAsociar(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposCapacitacionPATIAsociados(ByVal ID_ACCION_CONTRATADA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerGruposCapacitacionPATIAsociados(ID_ACCION_CONTRATADA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposPorPROYECTOparaAsociar(ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal CODIGO_PROGRAMA As String, _
                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                            ByVal CODIGO_MUNICIPIO As String, _
                                            Optional ByVal asColumnaOrden As String = "S.ID_SOLICITUD", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerGruposPorPROYECTOparaAsociar(ID_PROGRAMA_FORMACION, CODIGO_PROGRAMA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGruposPorPROYECTOAsociados(ByVal ID_ACCION_CONTRATADA As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerGruposPorPROYECTOAsociados(ID_ACCION_CONTRATADA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' 	[cramos]	20/06/2013	Modificado: Se modifica la llamada al método actualizar
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_CONTRATADA(ByVal aEntidad As ACCION_CONTRATADA) As Integer
        Try
            Return Me.ActualizarACCION_CONTRATADA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' 	[cramos]	20/06/2013	Modificado: Se mueve al archivo al Partial para implementar lógica de Negocios
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_CONTRATADA(ByVal aEntidad As ACCION_CONTRATADA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lContratoBolpros As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
            Dim lListaAcciones As listaACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerListaPorCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
            Dim lListaGruposAsoc As listaGRUPO_ACCION_CONTRATADA
            Dim lAccionContraOLD As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(aEntidad.ID_ACCION_CONTRATADA)
            Dim montoAcciones As Decimal = aEntidad.MONTO

            If lContratoBolpros IsNot Nothing AndAlso lContratoBolpros.ES_PAGO_PARTICIPANTE <> 1 Then
                If lListaAcciones IsNot Nothing AndAlso lListaAcciones.Count > 0 Then
                    For i As Integer = 0 To lListaAcciones.Count - 1
                        If lListaAcciones(i).ID_ACCION_CONTRATADA <> aEntidad.ID_ACCION_CONTRATADA Then
                            montoAcciones += lListaAcciones(i).MONTO
                        End If
                    Next
                End If
                If lContratoBolpros IsNot Nothing Then
                    If lContratoBolpros.MONTO < montoAcciones Then
                        Me.sError = "El Monto Total de todas las Acciones Contratadas sobrepasa el Monto del Contrato"
                        Return -1
                    End If
                End If

                'No se puede actualizar una Accion Contratada si tiene asociada grupos de solicitudes
                lListaGruposAsoc = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(aEntidad.ID_ACCION_CONTRATADA)
                If lListaGruposAsoc IsNot Nothing AndAlso lListaGruposAsoc.Count > 0 Then
                    'Verificar si el costo por curso ha cambiado
                    If Math.Round(lAccionContraOLD.MONTO / lAccionContraOLD.CANT_CURSOS, 2) <> Math.Round(aEntidad.MONTO / aEntidad.CANT_CURSOS, 2) Then
                        Me.sError = "La Acción Contratada no puede actualizarse porque tiene asociada Solicitud(es) de Capacitación y su costo por curso ha cambiado"
                        Return -1
                    End If
                End If
            End If


            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    
End Class
