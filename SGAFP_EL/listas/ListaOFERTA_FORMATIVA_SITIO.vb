''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaOFERTA_FORMATIVA_SITIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OFERTA_FORMATIVA_SITIO',
''' es una representación en memoria de los registros de la tabla OFERTA_FORMATIVA_SITIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOFERTA_FORMATIVA_SITIO
    Inherits listaBase(Of OFERTA_FORMATIVA_SITIO)
    Public Function BuscarPorId(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String) As OFERTA_FORMATIVA_SITIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As OFERTA_FORMATIVA_SITIO = Me(i)
            If s.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA _
            And s.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF _
            And s.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION _
            And s.ID_EJERCICIO = ID_EJERCICIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
