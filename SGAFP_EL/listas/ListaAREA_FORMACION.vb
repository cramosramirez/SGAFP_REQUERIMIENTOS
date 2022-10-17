''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaAREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AREA_FORMACION',
''' es una representación en memoria de los registros de la tabla AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/12/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAREA_FORMACION
    Inherits listaBase(Of AREA_FORMACION)
    Public Function BuscarPorId(ByVal ID_AREA_FORMACION As Decimal) As AREA_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As AREA_FORMACION = Me(i)
            If s.ID_AREA_FORMACION = ID_AREA_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
