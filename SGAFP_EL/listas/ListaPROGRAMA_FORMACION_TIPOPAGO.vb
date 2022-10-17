''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPROGRAMA_FORMACION_TIPOPAGO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PROGRAMA_FORMACION_TIPOPAGO',
''' es una representación en memoria de los registros de la tabla PROGRAMA_FORMACION_TIPOPAGO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPROGRAMA_FORMACION_TIPOPAGO
    Inherits listaBase(Of PROGRAMA_FORMACION_TIPOPAGO)
    Public Function BuscarPorId(ByVal ID_TIPO_PAGO As Decimal) As PROGRAMA_FORMACION_TIPOPAGO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PROGRAMA_FORMACION_TIPOPAGO = Me(i)
            If s.ID_TIPO_PAGO = ID_TIPO_PAGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
