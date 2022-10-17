''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLICITUD_INSCRIPCION_AF_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLICITUD_INSCRIPCION_AF_HIST',
''' es una representación en memoria de los registros de la tabla SOLICITUD_INSCRIPCION_AF_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/09/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLICITUD_INSCRIPCION_AF_HIST
    Inherits listaBase(Of SOLICITUD_INSCRIPCION_AF_HIST)
    Public Function BuscarPorId(ByVal ID_SOLICITUD_HIST As Decimal) As SOLICITUD_INSCRIPCION_AF_HIST
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLICITUD_INSCRIPCION_AF_HIST = Me(i)
            If s.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
