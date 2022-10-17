''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaGRUPO_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'GRUPO_USUARIO',
''' es una representación en memoria de los registros de la tabla GRUPO_USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaGRUPO_USUARIO
    Inherits listaBase(Of GRUPO_USUARIO)
    Public Function BuscarPorId(ByVal ID_GRUPO_USUARIO As Decimal) As GRUPO_USUARIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As GRUPO_USUARIO = Me(i)
            If s.ID_GRUPO_USUARIO = ID_GRUPO_USUARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
