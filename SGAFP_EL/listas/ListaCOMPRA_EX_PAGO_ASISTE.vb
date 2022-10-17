''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCOMPRA_EX_PAGO_ASISTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPRA_EX_PAGO_ASISTE',
''' es una representación en memoria de los registros de la tabla COMPRA_EX_PAGO_ASISTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/04/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPRA_EX_PAGO_ASISTE
    Inherits listaBase(Of COMPRA_EX_PAGO_ASISTE)
    Public Function BuscarPorId(ByVal ID_CONTRATACION_EX As Decimal) As COMPRA_EX_PAGO_ASISTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As COMPRA_EX_PAGO_ASISTE = Me(i)
            If s.ID_CONTRATACION_EX = ID_CONTRATACION_EX Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
