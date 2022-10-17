Partial Public Class cGRUPO_ACCION_CONTRATADA
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
    ''' 	[cramos]	10/07/2013	Modificado: Se implementa lógica de negocios antes de invocar el método Actualizar de la capa de datos
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_ACCION_CONTRATADA(ByVal aEntidad As GRUPO_ACCION_CONTRATADA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Verificar para los programas que no sean PATI que el monto del contrato al que pertenece el ítem 
            'sea igual a la sumatoria de los montos de los ítems del contrato 
            Dim lAccionContratada As ACCION_CONTRATADA

            lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(aEntidad.ID_ACCION_CONTRATADA)
            If lAccionContratada IsNot Nothing Then
                Dim lContratoBolpros As CONTRATO_BOLPROS
                Dim listaItems As listaACCION_CONTRATADA
                Dim lMontoItems As Decimal = 0

                lContratoBolpros = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)
                listaItems = (New cACCION_CONTRATADA).ObtenerListaPorCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)
                For i As Integer = 0 To listaItems.Count - 1
                    lMontoItems += listaItems(i).MONTO
                Next
                If lContratoBolpros.MONTO <> lMontoItems AndAlso Not Utilerias.EsProgramaPATI(lContratoBolpros.ID_PROGRAMA_FORMACION) AndAlso lContratoBolpros.ID_TIPO_ADJ = Enumeradores.TipoAdjudicacionBolpros.AdjudicacionPorCurso Then
                    Me.sError = "El monto del contrato debe ser igual a la sumatoria del monto de los ítems"
                    Return -1
                End If
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
