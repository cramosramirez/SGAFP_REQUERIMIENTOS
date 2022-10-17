Partial Public Class cCONTRATO_SUB_AREA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista de Sub Areas por Contrato filtrada por criterios.
    ''' </summary>
    ''' <param name="ID_CONTRATO">Id del Proveedor del registro seleccionado.</param>    
    ''' <param name="CODIGO_GRUPO">Código de Grupo de la Acción Formativa perteneciente al Contrato.</param>
    ''' <param name="ID_EJERCICIO_AF">Id del Ejercicio de las Acciones Formativas pertenecientes al Contrato.</param>
    ''' <history>
    ''' 	[cramos]	09/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_CONTRATO As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO_AF As String) As listaCONTRATO_SUB_AREA_FORMACION
        Try
            Dim lista As New listaCONTRATO_SUB_AREA_FORMACION
            lista = mDb.ObtenerListaPorCriterios(ID_CONTRATO, CODIGO_GRUPO, ID_EJERCICIO_AF)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto En Devengamiento en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoEnDevengamiento(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Decimal
        Try
            Dim lValor As Decimal
            lValor = mDb.ObtenerMontoEnDevengamiento(ID_CONTRATO, ID_SUBAREA_FORMACION)
            Return lValor
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
