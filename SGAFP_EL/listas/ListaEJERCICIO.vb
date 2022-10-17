''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EJERCICIO',
''' es una representación en memoria de los registros de la tabla EJERCICIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEJERCICIO
    Inherits listaBase(Of EJERCICIO)
    Public Function BuscarPorId(ByVal ID_EJERCICIO As String) As EJERCICIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EJERCICIO = Me(i)
            If s.ID_EJERCICIO = ID_EJERCICIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
