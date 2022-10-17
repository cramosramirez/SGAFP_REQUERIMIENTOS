''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_COMPRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_COMPRA',
''' es una representación en memoria de los registros de la tabla CONTRATO_COMPRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/05/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_COMPRA
    Inherits listaBase(Of CONTRATO_COMPRA)
    Public Function BuscarPorId(ByVal ID_CONTRATO_COMPRA As Decimal) As CONTRATO_COMPRA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_COMPRA = Me(i)
            If s.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function
End Class
