''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPARTICIPANTE_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PARTICIPANTE_AF',
''' es una representación en memoria de los registros de la tabla PARTICIPANTE_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPARTICIPANTE_AF
    Inherits listaBase(Of PARTICIPANTE_AF)
    Public Function BuscarPorId(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) As PARTICIPANTE_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PARTICIPANTE_AF = Me(i)
            If s.ID_PARTICIPANTE = ID_PARTICIPANTE _
            And s.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
