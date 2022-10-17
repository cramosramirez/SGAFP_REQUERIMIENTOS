''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_PARTI_SINDOCTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_PARTI_SINDOCTOS',
''' es una representación en memoria de los registros de la tabla ACCION_PARTI_SINDOCTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/05/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_PARTI_SINDOCTOS
    Inherits listaBase(Of ACCION_PARTI_SINDOCTOS)
    Public Function BuscarPorId(ByVal ID_ACCION_PARTI As Decimal) As ACCION_PARTI_SINDOCTOS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_PARTI_SINDOCTOS = Me(i)
            If s.ID_ACCION_PARTI = ID_ACCION_PARTI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
