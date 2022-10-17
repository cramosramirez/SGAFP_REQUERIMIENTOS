Partial Public Class cTECNICOS_SITIOS_ASIG
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>   
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaTECNICOS_SITIOS_ASIG
        Try
            Dim mListaTECNICOS_SITIOS_ASIG As New listaTECNICOS_SITIOS_ASIG
            mListaTECNICOS_SITIOS_ASIG = mDb.ObtenerLista(asColumnaOrden, asTipoOrden)
            Return mListaTECNICOS_SITIOS_ASIG
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
