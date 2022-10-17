''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPAIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PAIS',
''' es una representación en memoria de los registros de la tabla PAIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPAIS
    Inherits listaBase(Of PAIS)
    Public Function BuscarPorId(ByVal ID_PAIS As Decimal) As PAIS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PAIS = Me(i)
            If s.ID_PAIS = ID_PAIS Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
