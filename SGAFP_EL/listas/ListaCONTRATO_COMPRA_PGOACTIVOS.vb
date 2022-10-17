''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_COMPRA_PGOACTIVOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_COMPRA_PGOACTIVOS',
''' es una representación en memoria de los registros de la tabla CONTRATO_COMPRA_PGOACTIVOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/09/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_COMPRA_PGOACTIVOS
    Inherits listaBase(Of CONTRATO_COMPRA_PGOACTIVOS)
    Public Function BuscarPorId(ByVal ID_PAGO As Decimal) As CONTRATO_COMPRA_PGOACTIVOS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_COMPRA_PGOACTIVOS = Me(i)
            If s.ID_PAGO = ID_PAGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
