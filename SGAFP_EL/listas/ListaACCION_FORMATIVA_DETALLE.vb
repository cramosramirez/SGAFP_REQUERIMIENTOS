''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA_DETALLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA_DETALLE',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA_DETALLE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA_DETALLE
    Inherits listaBase(Of ACCION_FORMATIVA_DETALLE)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA As Decimal) As ACCION_FORMATIVA_DETALLE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA_DETALLE = Me(i)
            If s.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
