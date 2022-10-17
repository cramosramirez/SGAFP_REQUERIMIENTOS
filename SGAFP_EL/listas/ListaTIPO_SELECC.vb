''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_SELECC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_SELECC',
''' es una representación en memoria de los registros de la tabla TIPO_SELECC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_SELECC
    Inherits listaBase(Of TIPO_SELECC)
    Public Function BuscarPorId(ByVal ID_TIPO_SELECC As Decimal) As TIPO_SELECC
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_SELECC = Me(i)
            If s.ID_TIPO_SELECC = ID_TIPO_SELECC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
