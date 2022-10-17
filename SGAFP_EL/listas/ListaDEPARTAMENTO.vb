''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDEPARTAMENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DEPARTAMENTO',
''' es una representación en memoria de los registros de la tabla DEPARTAMENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDEPARTAMENTO
    Inherits listaBase(Of DEPARTAMENTO)
    Public Function BuscarPorId(ByVal CODIGO_DEPARTAMENTO As String) As DEPARTAMENTO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DEPARTAMENTO = Me(i)
            If s.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
