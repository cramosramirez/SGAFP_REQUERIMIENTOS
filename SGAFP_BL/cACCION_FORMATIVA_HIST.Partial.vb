Partial Public Class cACCION_FORMATIVA_HIST
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el histórico de una Accion Formativa tomando como parámetro el Id de la Acción Formativa.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ByRef ID_ACCION_FORMATIVA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_HIST
        Try
            Dim mListaACCION_FORMATIVA_HIST As New listaACCION_FORMATIVA_HIST
            mListaACCION_FORMATIVA_HIST = mDb.ObtenerACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            Return mListaACCION_FORMATIVA_HIST

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve último movimiento histórico de una Accion Formativa tomando como parámetro el Id de la Acción Formativa.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[cramos]	16/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerUltima_ACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ByRef ID_ACCION_FORMATIVA As Decimal) As ACCION_FORMATIVA_HIST
        Try
            Dim eACCION_FORMATIVA_HIST As New ACCION_FORMATIVA_HIST
            eACCION_FORMATIVA_HIST = mDb.ObtenerUltima_ACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            Return eACCION_FORMATIVA_HIST

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
