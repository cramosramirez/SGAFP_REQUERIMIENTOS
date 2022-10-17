''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaUNIDAD_ORGANIZATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'UNIDAD_ORGANIZATIVA',
''' es una representación en memoria de los registros de la tabla UNIDAD_ORGANIZATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaUNIDAD_ORGANIZATIVA
    Inherits listaBase(Of UNIDAD_ORGANIZATIVA)
    Public Function BuscarPorId(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As UNIDAD_ORGANIZATIVA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As UNIDAD_ORGANIZATIVA = Me(i)
            If s.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
