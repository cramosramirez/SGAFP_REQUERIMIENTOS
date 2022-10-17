''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FACILITADOR_CAPACITADOR',
''' es una representación en memoria de los registros de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFACILITADOR_CAPACITADOR
    Inherits listaBase(Of FACILITADOR_CAPACITADOR)
    Public Function BuscarPorId(ByVal ID_FACILITADOR As Decimal) As FACILITADOR_CAPACITADOR
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FACILITADOR_CAPACITADOR = Me(i)
            If s.ID_FACILITADOR = ID_FACILITADOR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
