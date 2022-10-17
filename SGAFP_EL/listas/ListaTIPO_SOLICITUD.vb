''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_SOLICITUD',
''' es una representación en memoria de los registros de la tabla TIPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_SOLICITUD
    Inherits listaBase(Of TIPO_SOLICITUD)
    Public Function BuscarPorId(ByVal ID_TIPO_SOLICITUD As Decimal) As TIPO_SOLICITUD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_SOLICITUD = Me(i)
            If s.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
