''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA_SEGUI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA_SEGUI',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA_SEGUI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA_SEGUI
    Inherits listaBase(Of ACCION_FORMATIVA_SEGUI)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA_SEGUI As Decimal) As ACCION_FORMATIVA_SEGUI
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA_SEGUI = Me(i)
            If s.ID_ACCION_FORMATIVA_SEGUI = ID_ACCION_FORMATIVA_SEGUI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
