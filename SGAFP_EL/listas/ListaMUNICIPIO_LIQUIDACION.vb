''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMUNICIPIO_LIQUIDACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MUNICIPIO_LIQUIDACION',
''' es una representación en memoria de los registros de la tabla MUNICIPIO_LIQUIDACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMUNICIPIO_LIQUIDACION
    Inherits listaBase(Of MUNICIPIO_LIQUIDACION)
    Public Function BuscarPorId(ByVal ID_LIQUIDACION As Decimal) As MUNICIPIO_LIQUIDACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As MUNICIPIO_LIQUIDACION = Me(i)
            If s.ID_LIQUIDACION = ID_LIQUIDACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
