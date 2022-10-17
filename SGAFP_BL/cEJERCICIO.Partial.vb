Partial Public Class cEJERCICIO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona el Registro del Ejercicio Activo y lo Devuelve en una Entidad de la Tabla EJERCICIO.
    ''' </summary>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerEJERCICIOActual() As EJERCICIO
        Try
            Dim listaEjercicioActual As New listaEJERCICIO
            Dim Criterio(0) As Criteria

            Criterio(0) = New Criteria("NOTAS", "=", "1", "")
            listaEjercicioActual = Me.ObtenerListaPorBusqueda(Me.mEntidad, Criterio, "ID_EJERCICIO", "ASC")
            If listaEjercicioActual IsNot Nothing AndAlso listaEjercicioActual.Count > 0 Then
                Return listaEjercicioActual(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
