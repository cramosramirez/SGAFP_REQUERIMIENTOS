''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROVEEDOR_AF',
''' es una representación en memoria de los registros de la tabla PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROVEEDOR_AF
    Inherits listaBase(Of PROVEEDOR_AF)
    Public Function BuscarPorId(ByVal ID_PROVEEDOR_AF As Decimal) As PROVEEDOR_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PROVEEDOR_AF = Me(i)
            If s.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
