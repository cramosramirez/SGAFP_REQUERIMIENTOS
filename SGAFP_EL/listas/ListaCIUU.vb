''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCIUU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CIUU',
''' es una representación en memoria de los registros de la tabla CIUU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCIUU
    Inherits listaBase(Of CIUU)
    Public Function BuscarPorId(ByVal CIUU As String) As CIUU
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CIUU = Me(i)
            If s.CIUU = CIUU Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
