Partial Class cTERMINO_REFERENCIA_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' TDR y NIT de Proveedor
    ''' </summary>
    ''' <param name="tdr"></param>
    ''' <param name="nitProveedor"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	08/07/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorProveedorTDR(ByVal tdr As String, ByVal nitProveedor As String) As listaTERMINO_REFERENCIA_AF
        Try
            Dim mListaTERMINO_REFERENCIA_AF As New listaTERMINO_REFERENCIA_AF
            mListaTERMINO_REFERENCIA_AF = mDb.ObtenerListaPorProveedorTDR(tdr, nitProveedor)
            Return mListaTERMINO_REFERENCIA_AF
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por el parámetros Resolucion, Código de Grupo o Estado de la Tabla TERMINO_REFERENCIA.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="RESOLUCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2011	Created
    ''' 	[cramos]	07/09/2012	Modificado: Se implementa filtro de DataSet por ID_PROGRAMA_FORMACION 
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal RESOLUCION As String) As DataSet
        Try
            Return mDb.ObtenerDataSetPorCriterios(ID_PROGRAMA_FORMACION, ID_PROVEEDOR_AF, RESOLUCION)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
