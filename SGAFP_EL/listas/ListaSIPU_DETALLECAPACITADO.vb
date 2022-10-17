''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSIPU_DETALLECAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SIPU_DETALLECAPACITACIONES',
''' es una representación en memoria de los registros de la tabla SIPU_DETALLECAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class ListaSIPU_DETALLECAPACITADO
    Inherits listaBase(Of SIPU_DETALLECAPACITADO)
    Public Function BuscarPorId(ByVal IDDETALLECAPACITADO As Decimal) As SIPU_DETALLECAPACITADO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SIPU_DETALLECAPACITADO = Me(i)
            If s.IDDETALLECAPACITADO = IDDETALLECAPACITADO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
