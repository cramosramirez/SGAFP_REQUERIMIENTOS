''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MUNICIPIO',
''' es una representación en memoria de los registros de la tabla MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMUNICIPIO
    Inherits listaBase(Of MUNICIPIO)
    Public Function BuscarPorId(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As MUNICIPIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As MUNICIPIO = Me(i)
            If s.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO _
            And s.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
