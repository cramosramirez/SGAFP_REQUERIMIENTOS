''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSIPU_TIPOCAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SIPU_TIPOCAPACITACIONES',
''' es una representación en memoria de los registros de la tabla SIPU_TIPOCAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSIPU_TIPOCAPACITACIONES
    Inherits listaBase(Of SIPU_TIPOCAPACITACIONES)
    Public Function BuscarPorId(ByVal IDTIPOCAPACITACION As Decimal) As SIPU_TIPOCAPACITACIONES
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SIPU_TIPOCAPACITACIONES = Me(i)
            If s.IDTIPOCAPACITACION = IDTIPOCAPACITACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
