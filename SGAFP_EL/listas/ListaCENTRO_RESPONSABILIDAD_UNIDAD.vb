''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCENTRO_RESPONSABILIDAD_UNIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CENTRO_RESPONSABILIDAD_UNIDAD',
''' es una representación en memoria de los registros de la tabla CENTRO_RESPONSABILIDAD_UNIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCENTRO_RESPONSABILIDAD_UNIDAD
    Inherits listaBase(Of CENTRO_RESPONSABILIDAD_UNIDAD)
    Public Function BuscarPorId(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As CENTRO_RESPONSABILIDAD_UNIDAD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CENTRO_RESPONSABILIDAD_UNIDAD = Me(i)
            If s.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD _
            And s.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
