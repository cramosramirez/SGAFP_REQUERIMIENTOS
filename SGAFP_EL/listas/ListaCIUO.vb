''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCIUO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CIUO',
''' es una representación en memoria de los registros de la tabla CIUO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCIUO
    Inherits listaBase(Of CIUO)
    Public Function BuscarPorId(ByVal CIUO As String) As CIUO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CIUO = Me(i)
            If s.CIUO = CIUO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
