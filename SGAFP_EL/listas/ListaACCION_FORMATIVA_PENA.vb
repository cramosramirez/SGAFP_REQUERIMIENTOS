''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_FORMATIVA_PENA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_FORMATIVA_PENA',
''' es una representación en memoria de los registros de la tabla ACCION_FORMATIVA_PENA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_FORMATIVA_PENA
    Inherits listaBase(Of ACCION_FORMATIVA_PENA)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA_PENA As Decimal) As ACCION_FORMATIVA_PENA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_FORMATIVA_PENA = Me(i)
            If s.ID_ACCION_FORMATIVA_PENA = ID_ACCION_FORMATIVA_PENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
