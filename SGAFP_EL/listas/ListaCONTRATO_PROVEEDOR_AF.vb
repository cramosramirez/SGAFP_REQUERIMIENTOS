''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_PROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_PROVEEDOR_AF',
''' es una representación en memoria de los registros de la tabla CONTRATO_PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_PROVEEDOR_AF
    Inherits listaBase(Of CONTRATO_PROVEEDOR_AF)
    Public Function BuscarPorId(ByVal ID_CONTRATO As Decimal) As CONTRATO_PROVEEDOR_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_PROVEEDOR_AF = Me(i)
            If s.ID_CONTRATO = ID_CONTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
