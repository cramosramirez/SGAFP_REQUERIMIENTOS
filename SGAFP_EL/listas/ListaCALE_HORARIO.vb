''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCALE_HORARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CALE_HORARIO',
''' es una representación en memoria de los registros de la tabla CALE_HORARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/05/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCALE_HORARIO
    Inherits listaBase(Of CALE_HORARIO)
    Public Function BuscarPorId(ByVal ID_HORA As Decimal) As CALE_HORARIO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CALE_HORARIO = Me(i)
            If s.ID_HORA = ID_HORA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
