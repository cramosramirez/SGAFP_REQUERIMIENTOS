''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_PROGRA_RETRO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_PROGRA_RETRO',
''' es una representación en memoria de los registros de la tabla ACCION_PROGRA_RETRO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/09/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_PROGRA_RETRO
    Inherits listaBase(Of ACCION_PROGRA_RETRO)
    Public Function BuscarPorId(ByVal ID_ACCION_PROGRA_RETRO As Decimal) As ACCION_PROGRA_RETRO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_PROGRA_RETRO = Me(i)
            If s.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
