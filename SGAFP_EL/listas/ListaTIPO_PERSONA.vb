''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_PERSONA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_PERSONA',
''' es una representación en memoria de los registros de la tabla TIPO_PERSONA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_PERSONA
    Inherits listaBase(Of TIPO_PERSONA)
    Public Function BuscarPorId(ByVal ID_TIPO_PERSONA As Decimal) As TIPO_PERSONA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_PERSONA = Me(i)
            If s.ID_TIPO_PERSONA = ID_TIPO_PERSONA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
