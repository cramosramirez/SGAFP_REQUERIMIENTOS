Partial Public Class cCONTRATO_PROVEEDOR_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista de Contratos filtrada por criterios.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF">Id del Proveedor del registro seleccionado.</param>
    ''' <param name="NUM_CONTRATO">Número de Contrato del registro seleccionado.</param>
    ''' <param name="NUM_LICITACION">Número de Licitación del registro seleccionado.</param>
    ''' <param name="CODIGO_GRUPO">Código de Grupo de la Acción Formativa perteneciente al Contrato.</param>
    ''' <param name="ID_EJERCICIO_AF">Id del Ejercicio de las Acciones Formativas pertenecientes al Contrato.</param>
    ''' <history>
    ''' 	[cramos]	09/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal NUM_CONTRATO As String, ByVal NUM_LICITACION As String, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO_AF As String) As listaCONTRATO_PROVEEDOR_AF
        Try
            Dim lista As New listaCONTRATO_PROVEEDOR_AF
            lista = mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, NUM_CONTRATO, NUM_LICITACION, CODIGO_GRUPO, ID_EJERCICIO_AF)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto En Devengamiento en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoEnDevengamiento(ByVal ID_CONTRATO As Decimal) As Decimal
        Try
            Dim lValor As Decimal
            lValor = mDb.ObtenerMontoEnDevengamiento(ID_CONTRATO)
            Return lValor
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
