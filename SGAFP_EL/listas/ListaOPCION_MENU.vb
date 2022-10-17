''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaOPCION_MENU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OPCION_MENU',
''' es una representación en memoria de los registros de la tabla OPCION_MENU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOPCION_MENU
    Inherits listaBase(Of OPCION_MENU)
    Public Function BuscarPorId(ByVal ID_OPCION_MENU As Decimal) As OPCION_MENU
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As OPCION_MENU = Me(i)
            If s.ID_OPCION_MENU = ID_OPCION_MENU Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
