''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACTI_ECONOMICA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACTI_ECONOMICA',
''' es una representación en memoria de los registros de la tabla ACTI_ECONOMICA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACTI_ECONOMICA
    Inherits listaBase(Of ACTI_ECONOMICA)
    Public Function BuscarPorId(ByVal ID_ACTI_ECONOMICA As Decimal) As ACTI_ECONOMICA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACTI_ECONOMICA = Me(i)
            If s.ID_ACTI_ECONOMICA = ID_ACTI_ECONOMICA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
