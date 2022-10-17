''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFUENTE_MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FUENTE_MUNICIPIO',
''' es una representación en memoria de los registros de la tabla FUENTE_MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFUENTE_MUNICIPIO
    Inherits listaBase(Of FUENTE_MUNICIPIO)
    Public Function BuscarPorId(ByVal ID_FUENTE_MUNICIPIO As Decimal) As FUENTE_MUNICIPIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FUENTE_MUNICIPIO = Me(i)
            If s.ID_FUENTE_MUNICIPIO = ID_FUENTE_MUNICIPIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
