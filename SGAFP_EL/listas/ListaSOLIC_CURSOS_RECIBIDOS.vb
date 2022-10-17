''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLIC_CURSOS_RECIBIDOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_CURSOS_RECIBIDOS',
''' es una representación en memoria de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_CURSOS_RECIBIDOS
    Inherits listaBase(Of SOLIC_CURSOS_RECIBIDOS)
    Public Function BuscarPorId(ByVal ID_CURSO_RECIBIDO As Decimal) As SOLIC_CURSOS_RECIBIDOS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLIC_CURSOS_RECIBIDOS = Me(i)
            If s.ID_CURSO_RECIBIDO = ID_CURSO_RECIBIDO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
