''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PARTICIPANTE_EXONERADO_DOC',
''' es una representación en memoria de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPARTICIPANTE_EXONERADO_DOC
    Inherits listaBase(Of PARTICIPANTE_EXONERADO_DOC)
    Public Function BuscarPorId(ByVal ID_PARTICIPANTE As Decimal) As PARTICIPANTE_EXONERADO_DOC
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PARTICIPANTE_EXONERADO_DOC = Me(i)
            If s.ID_PARTICIPANTE = ID_PARTICIPANTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
