''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA
    Inherits listaBase(Of ACCION_FORMATIVA)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA As Decimal) As ACCION_FORMATIVA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA = Me(i)
            If s.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
