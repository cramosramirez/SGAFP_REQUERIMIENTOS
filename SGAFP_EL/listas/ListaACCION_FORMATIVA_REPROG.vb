''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA_REPROG',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA_REPROG
    Inherits listaBase(Of ACCION_FORMATIVA_REPROG)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal) As ACCION_FORMATIVA_REPROG
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA_REPROG = Me(i)
            If s.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
