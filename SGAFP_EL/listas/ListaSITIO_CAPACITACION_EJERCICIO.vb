''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSITIO_CAPACITACION_EJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SITIO_CAPACITACION_EJERCICIO',
''' es una representación en memoria de los registros de la tabla SITIO_CAPACITACION_EJERCICIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSITIO_CAPACITACION_EJERCICIO
    Inherits listaBase(Of SITIO_CAPACITACION_EJERCICIO)
    Public Function BuscarPorId(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String) As SITIO_CAPACITACION_EJERCICIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SITIO_CAPACITACION_EJERCICIO = Me(i)
            If s.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION _
            And s.ID_EJERCICIO = ID_EJERCICIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
