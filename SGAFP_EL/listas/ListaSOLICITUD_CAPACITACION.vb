''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLICITUD_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLICITUD_CAPACITACION',
''' es una representación en memoria de los registros de la tabla SOLICITUD_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLICITUD_CAPACITACION
    Inherits listaBase(Of SOLICITUD_CAPACITACION)
    Public Function BuscarPorId(ByVal ID_SOLICITUD As Decimal) As SOLICITUD_CAPACITACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLICITUD_CAPACITACION = Me(i)
            If s.ID_SOLICITUD = ID_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
