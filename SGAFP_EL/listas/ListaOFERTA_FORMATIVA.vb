''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaOFERTA_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OFERTA_FORMATIVA',
''' es una representación en memoria de los registros de la tabla OFERTA_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOFERTA_FORMATIVA
    Inherits listaBase(Of OFERTA_FORMATIVA)
    Public Function BuscarPorId(ByVal ID_OFERTA_FORMATIVA As Decimal) As OFERTA_FORMATIVA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As OFERTA_FORMATIVA = Me(i)
            If s.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
