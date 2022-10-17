''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCALE_FECHA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CALE_FECHA',
''' es una representación en memoria de los registros de la tabla CALE_FECHA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/05/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCALE_FECHA
    Inherits listaBase(Of CALE_FECHA)
    Public Function BuscarPorId(ByVal ID_CALE As Decimal) As CALE_FECHA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CALE_FECHA = Me(i)
            If s.ID_CALE = ID_CALE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
