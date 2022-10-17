''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFUENTE_FINANCIAMIENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FUENTE_FINANCIAMIENTO',
''' es una representación en memoria de los registros de la tabla FUENTE_FINANCIAMIENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/07/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFUENTE_FINANCIAMIENTO
    Inherits listaBase(Of FUENTE_FINANCIAMIENTO)
    Public Function BuscarPorId(ByVal ID_FUENTE As Decimal) As FUENTE_FINANCIAMIENTO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FUENTE_FINANCIAMIENTO = Me(i)
            If s.ID_FUENTE = ID_FUENTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
