''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaROL_PROGRAMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ROL_PROGRAMA',
''' es una representación en memoria de los registros de la tabla ROL_PROGRAMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/12/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaROL_PROGRAMA
    Inherits listaBase(Of ROL_PROGRAMA)
    Public Function BuscarPorId(ByVal ID_ROL_PROGRAMA As Decimal) As ROL_PROGRAMA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ROL_PROGRAMA = Me(i)
            If s.ID_ROL_PROGRAMA = ID_ROL_PROGRAMA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
