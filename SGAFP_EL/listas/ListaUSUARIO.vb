''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'USUARIO',
''' es una representación en memoria de los registros de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUSUARIO
    Inherits listaBase(Of USUARIO)
    Public Function BuscarPorId(ByVal USUARIO As String) As USUARIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As USUARIO = Me(i)
            If s.USUARIO = USUARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
