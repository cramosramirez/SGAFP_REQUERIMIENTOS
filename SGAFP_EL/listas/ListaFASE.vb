''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFASE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FASE',
''' es una representación en memoria de los registros de la tabla FASE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/07/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFASE
    Inherits listaBase(Of FASE)
    Public Function BuscarPorId(ByVal ID_FASE As Decimal) As FASE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FASE = Me(i)
            If s.ID_FASE = ID_FASE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
