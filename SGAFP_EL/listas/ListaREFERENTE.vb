''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaREFERENTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REFERENTE',
''' es una representación en memoria de los registros de la tabla REFERENTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREFERENTE
    Inherits listaBase(Of REFERENTE)
    Public Function BuscarPorId(ByVal ID_REFERENTE As Decimal) As REFERENTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As REFERENTE = Me(i)
            If s.ID_REFERENTE = ID_REFERENTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
