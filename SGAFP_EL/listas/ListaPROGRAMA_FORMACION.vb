''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPROGRAMA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROGRAMA_FORMACION',
''' es una representación en memoria de los registros de la tabla PROGRAMA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROGRAMA_FORMACION
    Inherits listaBase(Of PROGRAMA_FORMACION)
    Public Function BuscarPorId(ByVal ID_PROGRAMA_FORMACION As Decimal) As PROGRAMA_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PROGRAMA_FORMACION = Me(i)
            If s.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
