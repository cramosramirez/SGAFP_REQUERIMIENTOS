''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFACTURA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FACTURA_AF',
''' es una representación en memoria de los registros de la tabla FACTURA_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/08/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFACTURA_AF
    Inherits listaBase(Of FACTURA_AF)
    Public Function BuscarPorId(ByVal ID_FACTURA_AF As Decimal) As FACTURA_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FACTURA_AF = Me(i)
            If s.ID_FACTURA_AF = ID_FACTURA_AF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
