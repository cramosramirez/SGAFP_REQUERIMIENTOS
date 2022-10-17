Partial Public Class cSUB_AREA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto Adjudicado en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoAdjudicadoPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Double
        Try
            Return mDb.ObtenerMontoAdjudicadoPorContratoSubAreaFormacion(ID_CONTRATO, ID_SUBAREA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve las Participaciones Adjudicadas en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionAdjudicadaPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As Integer
        Try
            Return mDb.ObtenerParticipacionAdjudicadaPorContratoSubAreaFormacion(ID_CONTRATO, ID_SUBAREA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto Ejecutado en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMontoEjecutadoPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Double
        Try
            Return mDb.ObtenerMontoEjecutadoPorContratoSubAreaFormacion(ID_CONTRATO, ID_SUBAREA_FORMACION, ID_ACCION_FORMATIVA_NO_INCLUIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Monto Ejecutado en Sub Area Formativa en un Contrato para un Proveedor 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionEjecutadaPorContratoSubAreaFormacion(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Integer
        Try
            Return mDb.ObtenerParticipacionEjecutadaPorContratoSubAreaFormacion(ID_CONTRATO, ID_SUBAREA_FORMACION, ID_ACCION_FORMATIVA_NO_INCLUIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try

    End Function
   
End Class
