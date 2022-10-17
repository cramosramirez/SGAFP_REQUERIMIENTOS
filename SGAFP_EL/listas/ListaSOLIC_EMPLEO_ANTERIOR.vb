''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_EMPLEO_ANTERIOR',
''' es una representación en memoria de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_EMPLEO_ANTERIOR
    Inherits listaBase(Of SOLIC_EMPLEO_ANTERIOR)
    Public Function BuscarPorId(ByVal ID_EMPLEO_ANT As Decimal) As SOLIC_EMPLEO_ANTERIOR
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLIC_EMPLEO_ANTERIOR = Me(i)
            If s.ID_EMPLEO_ANT = ID_EMPLEO_ANT Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
