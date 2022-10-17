''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLIC_EMPLEO_ACTUAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_EMPLEO_ACTUAL',
''' es una representación en memoria de los registros de la tabla SOLIC_EMPLEO_ACTUAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_EMPLEO_ACTUAL
    Inherits listaBase(Of SOLIC_EMPLEO_ACTUAL)
    Public Function BuscarPorId(ByVal ID_EMPLEO_ACTUAL As Decimal) As SOLIC_EMPLEO_ACTUAL
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLIC_EMPLEO_ACTUAL = Me(i)
            If s.ID_EMPLEO_ACTUAL = ID_EMPLEO_ACTUAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
