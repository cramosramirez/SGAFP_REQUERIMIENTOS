''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_VISITAS_SEGUI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_VISITAS_SEGUI',
''' es una representación en memoria de los registros de la tabla ACCION_VISITAS_SEGUI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_VISITAS_SEGUI
    Inherits listaBase(Of ACCION_VISITAS_SEGUI)
    Public Function BuscarPorId(ByVal ID_ACCION_VISITA As Decimal) As ACCION_VISITAS_SEGUI
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_VISITAS_SEGUI = Me(i)
            If s.ID_ACCION_VISITA = ID_ACCION_VISITA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
