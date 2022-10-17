Imports SGAFP.DL.DS_DL

Partial Public Class cDESEMBOLSO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	03/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaDESEMBOLSO
        Try
            Return mDb.ObtenerListaPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataTable filtrada por los parámetros de
    ''' que se pasan como criterios
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataTableCursosPendientesDesembolso(ByVal ID_FUENTE As Decimal, _
                                                                            ByVal NO_CONVOCATORIA As Decimal, _
                                                                            ByVal NUM_DESEMBOLSO As Decimal, _
                                                                            ByVal FECHA_INCIAL As Date, _
                                                                            ByVal FECHA_FINAL As Date, _
                                                                            ByVal lMunicipios As listaMUNICIPIO) As AplicacionDesembolsoPATIDataTable
        Try
            Return mDb.ObtenerDataTableCursosPendientesDesembolso(ID_FUENTE, NO_CONVOCATORIA, NUM_DESEMBOLSO, FECHA_INCIAL, FECHA_FINAL, lMunicipios)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
