''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMUNICIPIO_CONVOCATORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MUNICIPIO_CONVOCATORIA',
''' es una representación en memoria de los registros de la tabla MUNICIPIO_CONVOCATORIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMUNICIPIO_CONVOCATORIA
    Inherits listaBase(Of MUNICIPIO_CONVOCATORIA)
    Public Function BuscarPorId(ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As MUNICIPIO_CONVOCATORIA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As MUNICIPIO_CONVOCATORIA = Me(i)
            If s.NO_CONVOCATORIA = NO_CONVOCATORIA _
            And s.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO _
            And s.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
