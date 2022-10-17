''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ETAPA',
''' es una representación en memoria de los registros de la tabla ETAPA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaETAPA
    Inherits listaBase(Of ETAPA)
    Public Function BuscarPorId(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) As ETAPA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ETAPA = Me(i)
            If s.CODIGO_ETAPA = CODIGO_ETAPA _
            And s.CODIGO_PROCESO = CODIGO_PROCESO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
