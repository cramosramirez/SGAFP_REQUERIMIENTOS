''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEMPRESAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EMPRESAS',
''' es una representación en memoria de los registros de la tabla EMPRESAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEMPRESAS
    Inherits listaBase(Of EMPRESAS)
    Public Function BuscarPorId(ByVal NUMERO_PATRONAL As String) As EMPRESAS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EMPRESAS = Me(i)
            If s.NUMERO_PATRONAL = NUMERO_PATRONAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
