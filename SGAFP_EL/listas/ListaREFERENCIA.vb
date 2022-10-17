''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaREFERENCIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'REFERENCIA',
''' es una representación en memoria de los registros de la tabla REFERENCIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaREFERENCIA
    Inherits listaBase(Of REFERENCIA)
    Public Function BuscarPorId(ByVal ID_REFERENCIA As Decimal) As REFERENCIA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As REFERENCIA = Me(i)
            If s.ID_REFERENCIA = ID_REFERENCIA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
