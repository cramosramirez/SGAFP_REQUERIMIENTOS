Partial Public Class cFUENTE_MUNICIPIO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorFUENTE_FINANCIAMIENTO_CONV_DEPARTAMENTO(ByVal ID_FUENTE As Decimal, _
                                                            ByVal NO_CONVOCATORIA As Decimal, _
                                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                                            ByVal CODIGO_MUNICIPIO As String) As FUENTE_MUNICIPIO
        Try
            Return mDb.ObtenerPorFUENTE_FINANCIAMIENTO_CONV_DEPARTAMENTO(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
