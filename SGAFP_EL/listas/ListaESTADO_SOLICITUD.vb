''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaESTADO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_SOLICITUD',
''' es una representación en memoria de los registros de la tabla ESTADO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_SOLICITUD
    Inherits listaBase(Of ESTADO_SOLICITUD)
    Public Function BuscarPorId(ByVal ID_ESTADO_SOLICITUD As Decimal) As ESTADO_SOLICITUD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ESTADO_SOLICITUD = Me(i)
            If s.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
