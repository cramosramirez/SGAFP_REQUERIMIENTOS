''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA_HIST',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/05/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA_HIST
    Inherits listaBase(Of ACCION_FORMATIVA_HIST)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA_HIST As Decimal) As ACCION_FORMATIVA_HIST
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA_HIST = Me(i)
            If s.ID_ACCION_FORMATIVA_HIST = ID_ACCION_FORMATIVA_HIST Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
