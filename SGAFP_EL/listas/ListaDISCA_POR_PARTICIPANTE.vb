''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDISCA_POR_PARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DISCA_POR_PARTICIPANTE',
''' es una representación en memoria de los registros de la tabla DISCA_POR_PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDISCA_POR_PARTICIPANTE
    Inherits listaBase(Of DISCA_POR_PARTICIPANTE)
    Public Function BuscarPorId(ByVal ID_DISCAPACIDAD As Decimal, ByVal ID_PARTICIPANTE As Decimal) As DISCA_POR_PARTICIPANTE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DISCA_POR_PARTICIPANTE = Me(i)
            If s.ID_DISCAPACIDAD = ID_DISCAPACIDAD _
            And s.ID_PARTICIPANTE = ID_PARTICIPANTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
