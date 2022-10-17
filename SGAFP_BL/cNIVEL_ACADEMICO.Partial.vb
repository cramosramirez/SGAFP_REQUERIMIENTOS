Partial Public Class cNIVEL_ACADEMICO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve los registros a partir del ID_NIVEL_ACADEMICO mayor o igual a 8.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaActualizada(Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaNIVEL_ACADEMICO
        Try
            Dim mListaNIVEL_ACADEMICO As New listaNIVEL_ACADEMICO
            mListaNIVEL_ACADEMICO = mDb.ObtenerListaActualizada(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaNIVEL_ACADEMICO
            If Not mListaNIVEL_ACADEMICO Is Nothing Then
                For Each lEntidad As NIVEL_ACADEMICO In mListaNIVEL_ACADEMICO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaNIVEL_ACADEMICO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
