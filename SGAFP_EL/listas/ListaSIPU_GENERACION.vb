''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSIPU_GENERACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SIPU_GENERACION',
''' es una representación en memoria de los registros de la tabla SIPU_GENERACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSIPU_GENERACION
    Inherits listaBase(Of SIPU_GENERACION)
    Public Function BuscarPorId(ByVal ID_GENERACION As Decimal) As SIPU_GENERACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SIPU_GENERACION = Me(i)
            If s.ID_GENERACION = ID_GENERACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
