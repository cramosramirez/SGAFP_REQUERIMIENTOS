''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSUB_AREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SUB_AREA_FORMACION',
''' es una representación en memoria de los registros de la tabla SUB_AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSUB_AREA_FORMACION
    Inherits listaBase(Of SUB_AREA_FORMACION)
    Public Function BuscarPorId(ByVal ID_SUBAREA_FORMACION As Decimal) As SUB_AREA_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SUB_AREA_FORMACION = Me(i)
            If s.ID_SUBAREA_FORMACION = ID_SUBAREA_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
