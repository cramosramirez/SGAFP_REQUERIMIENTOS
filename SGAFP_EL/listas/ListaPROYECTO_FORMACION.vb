''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPROYECTO_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROYECTO_FORMACION',
''' es una representación en memoria de los registros de la tabla PROYECTO_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROYECTO_FORMACION
    Inherits listaBase(Of PROYECTO_FORMACION)
    Public Function BuscarPorId(ByVal ID_PROYECTO_FORMACION As Decimal) As PROYECTO_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PROYECTO_FORMACION = Me(i)
            If s.ID_PROYECTO_FORMACION = ID_PROYECTO_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
