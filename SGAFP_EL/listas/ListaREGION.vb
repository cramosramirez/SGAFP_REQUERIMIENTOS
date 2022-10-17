''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaREGION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REGION',
''' es una representación en memoria de los registros de la tabla REGION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREGION
    Inherits listaBase(Of REGION)
    Public Function BuscarPorId(ByVal CODIGO_REGION As String) As REGION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As REGION = Me(i)
            If s.CODIGO_REGION = CODIGO_REGION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
