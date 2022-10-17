''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PARTICIPANTE',
''' es una representación en memoria de los registros de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPARTICIPANTE
    Inherits listaBase(Of PARTICIPANTE)
    Public Function BuscarPorId(ByVal ID_PARTICIPANTE As Decimal) As PARTICIPANTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PARTICIPANTE = Me(i)
            If s.ID_PARTICIPANTE = ID_PARTICIPANTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
