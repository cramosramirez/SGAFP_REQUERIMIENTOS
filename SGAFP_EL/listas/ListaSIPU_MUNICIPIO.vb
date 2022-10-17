''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSIPU_MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SIPU_MUNICIPIO',
''' es una representación en memoria de los registros de la tabla SIPU_MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSIPU_MUNICIPIO
    Inherits listaBase(Of SIPU_MUNICIPIO)
    Public Function BuscarPorId(ByVal IDMUNICIPIO As Decimal) As SIPU_MUNICIPIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SIPU_MUNICIPIO = Me(i)
            If s.IDMUNICIPIO = IDMUNICIPIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
