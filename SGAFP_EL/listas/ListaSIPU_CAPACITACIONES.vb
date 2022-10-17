''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSIPU_CAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SIPU_CAPACITACIONES',
''' es una representación en memoria de los registros de la tabla SIPU_CAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSIPU_CAPACITACIONES
    Inherits listaBase(Of SIPU_CAPACITACIONES)
    Public Function BuscarPorId(ByVal IDCAPACITACION As Decimal) As SIPU_CAPACITACIONES
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SIPU_CAPACITACIONES = Me(i)
            If s.IDCAPACITACION = IDCAPACITACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
