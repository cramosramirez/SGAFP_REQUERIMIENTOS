''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaGRUPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'GRUPO_SOLICITUD',
''' es una representación en memoria de los registros de la tabla GRUPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaGRUPO_SOLICITUD
    Inherits listaBase(Of GRUPO_SOLICITUD)
    Public Function BuscarPorId(ByVal ID_GRUPO_SOLICITUD As Decimal) As GRUPO_SOLICITUD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As GRUPO_SOLICITUD = Me(i)
            If s.ID_GRUPO_SOLICITUD = ID_GRUPO_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
