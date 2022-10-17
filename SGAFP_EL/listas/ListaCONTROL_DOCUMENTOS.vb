''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTROL_DOCUMENTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTROL_DOCUMENTOS',
''' es una representación en memoria de los registros de la tabla CONTROL_DOCUMENTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTROL_DOCUMENTOS
    Inherits listaBase(Of CONTROL_DOCUMENTOS)
    Public Function BuscarPorId(ByVal NUMERO_DOCUMENTO As Decimal) As CONTROL_DOCUMENTOS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTROL_DOCUMENTOS = Me(i)
            If s.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
