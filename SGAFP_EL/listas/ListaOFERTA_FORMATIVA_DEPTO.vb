''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaOFERTA_FORMATIVA_DEPTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OFERTA_FORMATIVA_DEPTO',
''' es una representación en memoria de los registros de la tabla OFERTA_FORMATIVA_DEPTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/12/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOFERTA_FORMATIVA_DEPTO
    Inherits listaBase(Of OFERTA_FORMATIVA_DEPTO)
    Public Function BuscarPorId(ByVal ID_OFERTA_FORMATIVA_DEPTO As Decimal) As OFERTA_FORMATIVA_DEPTO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As OFERTA_FORMATIVA_DEPTO = Me(i)
            If s.ID_OFERTA_FORMATIVA_DEPTO = ID_OFERTA_FORMATIVA_DEPTO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
