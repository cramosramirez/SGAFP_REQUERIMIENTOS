Partial Public Class cCONTRATO_BOLPROS
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
    ''' 	[cramos]	20/06/2013	Modificado: Se mueve al archivo Partial para implementar lógica de Negocios
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_BOLPROS(ByVal aEntidad As CONTRATO_BOLPROS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lListaAcciones As listaACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerListaPorCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
            Dim bGrupoAsociado As New cGRUPO_ACCION_CONTRATADA
            Dim lListaGrupos As listaGRUPO_ACCION_CONTRATADA
            Dim lMontoAcciones As Decimal = 0

            'If lListaAcciones IsNot Nothing AndAlso lListaAcciones.Count > 0 Then
            '    For i As Integer = 0 To lListaAcciones.Count - 1
            '        lMontoAcciones += lListaAcciones(i).MONTO
            '    Next
            '    If aEntidad.MONTO < lMontoAcciones Then
            '        Me.sError = "El Monto del contrato no puede ser menor al Monto Total de las Acciones Contratadas"
            '        Return -1
            '    End If
            'End If

            'Solo se puede actualizar cierta parte de un Contrato si tiene Acciones Contratadas asociadas a grupos de solicitudes            
            For i As Integer = 0 To lListaAcciones.Count - 1
                lListaGrupos = bGrupoAsociado.ObtenerListaPorACCION_CONTRATADA(lListaAcciones(i).ID_ACCION_CONTRATADA)
                If lListaGrupos IsNot Nothing AndAlso lListaGrupos.Count > 0 Then

                    If aEntidad.ID_CONTRATO > 0 Then
                        Dim lEntidadAntesAct As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
                        If lEntidadAntesAct IsNot Nothing Then
                            lEntidadAntesAct.ID_CONTRATO_COMPRA = aEntidad.ID_CONTRATO_COMPRA
                            lEntidadAntesAct.FECHA_INI_EJEC = aEntidad.FECHA_INI_EJEC
                            lEntidadAntesAct.FECHA_FIN_EJEC = aEntidad.FECHA_FIN_EJEC
                            lEntidadAntesAct.MONTO = aEntidad.MONTO
                            lEntidadAntesAct.LOTE = aEntidad.LOTE
                            lEntidadAntesAct.SUB_LOTE = aEntidad.SUB_LOTE
                            lEntidadAntesAct.USERID = aEntidad.USERID
                            lEntidadAntesAct.LASTUPDATE = aEntidad.LASTUPDATE
                            lEntidadAntesAct.ES_INCREMENTO = aEntidad.ES_INCREMENTO
                            lEntidadAntesAct.NO_PRODUCTO = aEntidad.NO_PRODUCTO

                            Return mDb.Actualizar(lEntidadAntesAct, aTipoConcurrencia)
                        End If
                    End If
                End If
            Next

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function EsContratacionBolpros(ByVal ID_ACCION_FORMATIVA As Int32) As Boolean
        Try
            Dim listaGrupoAccion As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            If listaGrupoAccion IsNot Nothing AndAlso listaGrupoAccion.Count > 0 Then
                Dim lAccionContratada As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(listaGrupoAccion(0).ID_ACCION_CONTRATADA)
                If lAccionContratada IsNot Nothing Then
                    Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)
                    If lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                        Return True
                    End If
                End If
            End If
            Return False

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
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
    Public Function ActualizarCONTRATO_BOLPROS(ByVal aEntidad As CONTRATO_BOLPROS) As Integer
        Try
            Return Me.ActualizarCONTRATO_BOLPROS(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            ByVal LOTE As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, NUM_CONTRATO, ID_CONTRATO_COMPRA, LOTE, asColumnaOrden, asTipoOrden)
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
    ''' 	[cramos]	16/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorContratoCompra(ByVal ID_CONTRATO_COMPRA As Decimal, _
                                            ByVal NUM_CONTRATO As String,
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS
        Try
            Return mDb.ObtenerListaPorContratoCompra(ID_CONTRATO_COMPRA, NUM_CONTRATO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_TIPO_CONTRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROGRAMA_TIPO_CONTRATACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_TIPO_CONTRA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Try
            Return mDb.ObtenerListaPorPROGRAMA_TIPO_CONTRATACION(ID_PROGRAMA_FORMACION, ID_TIPO_CONTRA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>    
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF_PAGO_PARTICIPANTE(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ES_PAGO_PARTICIPANTE As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_BOLPROS

        Try
            Return mDb.ObtenerListaPorPROVEEDOR_AF_PAGO_PARTICIPANTE(ID_PROVEEDOR_AF, ES_PAGO_PARTICIPANTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As CONTRATO_BOLPROS

        Try
            Return mDb.ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerMontoEjecutadoPorContrato(ByVal ID_CONTRATO As Decimal) As Decimal

        Try
            Return mDb.ObtenerMontoEjecutadoPorContrato(ID_CONTRATO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerParticipacionesEjecutadasPorContrato(ByVal ID_CONTRATO As Decimal) As Decimal

        Try
            Return mDb.ObtenerParticipacionesEjecutadasPorContrato(ID_CONTRATO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
