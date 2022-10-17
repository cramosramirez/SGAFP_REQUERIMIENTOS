''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLICITUD_INSCRIPCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLICITUD_INSCRIPCION_EC',
''' es una representación en memoria de los registros de la tabla SOLICITUD_INSCRIPCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/07/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLICITUD_INSCRIPCION_EC
    Inherits listaBase(Of SOLICITUD_INSCRIPCION_EC)
    Public Function BuscarPorId(ByVal ID_SOLICITUD As Decimal) As SOLICITUD_INSCRIPCION_EC
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLICITUD_INSCRIPCION_EC = Me(i)
            If s.ID_SOLICITUD = ID_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
