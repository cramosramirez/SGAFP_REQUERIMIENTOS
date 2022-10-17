''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSITIO_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SITIO_CAPACITACION',
''' es una representación en memoria de los registros de la tabla SITIO_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSITIO_CAPACITACION
    Inherits listaBase(Of SITIO_CAPACITACION)
    Public Function BuscarPorId(ByVal ID_SITIO_CAPACITACION As Decimal) As SITIO_CAPACITACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SITIO_CAPACITACION = Me(i)
            If s.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
