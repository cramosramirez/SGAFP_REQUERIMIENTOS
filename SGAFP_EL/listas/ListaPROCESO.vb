''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPROCESO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROCESO',
''' es una representación en memoria de los registros de la tabla PROCESO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROCESO
    Inherits listaBase(Of PROCESO)
    Public Function BuscarPorId(ByVal CODIGO_PROCESO As String) As PROCESO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PROCESO = Me(i)
            If s.CODIGO_PROCESO = CODIGO_PROCESO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
