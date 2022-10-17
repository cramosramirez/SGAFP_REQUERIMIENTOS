''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaINFORME_PRESELECCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'INFORME_PRESELECCION_EC',
''' es una representación en memoria de los registros de la tabla INFORME_PRESELECCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaINFORME_PRESELECCION_EC
    Inherits listaBase(Of INFORME_PRESELECCION_EC)
    Public Function BuscarPorId(ByVal ID_INFORME_PRESE As Decimal) As INFORME_PRESELECCION_EC
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As INFORME_PRESELECCION_EC = Me(i)
            If s.ID_INFORME_PRESE = ID_INFORME_PRESE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
