''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFASE_MUNICIPIOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FASE_MUNICIPIOS',
''' es una representación en memoria de los registros de la tabla FASE_MUNICIPIOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFASE_MUNICIPIOS
    Inherits listaBase(Of FASE_MUNICIPIOS)
    Public Function BuscarPorId(ByVal ID_FASE_MUNICIPIO As Decimal) As FASE_MUNICIPIOS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FASE_MUNICIPIOS = Me(i)
            If s.ID_FASE_MUNICIPIO = ID_FASE_MUNICIPIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
