''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaASISTENCIA_AF_HORARIO_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ASISTENCIA_AF_HORARIO_REPROG',
''' es una representación en memoria de los registros de la tabla ASISTENCIA_AF_HORARIO_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaASISTENCIA_AF_HORARIO_REPROG
    Inherits listaBase(Of ASISTENCIA_AF_HORARIO_REPROG)
    Public Function BuscarPorId(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal) As ASISTENCIA_AF_HORARIO_REPROG
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ASISTENCIA_AF_HORARIO_REPROG = Me(i)
            If s.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF _
            And s.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
