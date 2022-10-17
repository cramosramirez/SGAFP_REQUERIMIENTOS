''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaASISTENCIA_PAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ASISTENCIA_PAGO',
''' es una representación en memoria de los registros de la tabla ASISTENCIA_PAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/01/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaASISTENCIA_PAGO
    Inherits listaBase(Of ASISTENCIA_PAGO)
    Public Function BuscarPorId(ByVal ID_ASISTE_PAGO As Decimal) As ASISTENCIA_PAGO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ASISTENCIA_PAGO = Me(i)
            If s.ID_ASISTE_PAGO = ID_ASISTE_PAGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
