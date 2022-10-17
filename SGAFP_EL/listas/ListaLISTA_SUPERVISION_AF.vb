''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaLISTA_SUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'LISTA_SUPERVISION_AF',
''' es una representación en memoria de los registros de la tabla LISTA_SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaLISTA_SUPERVISION_AF
    Inherits listaBase(Of LISTA_SUPERVISION_AF)
    Public Function BuscarPorId(ByVal ID_LISTA_SUPERVISION As Decimal) As LISTA_SUPERVISION_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As LISTA_SUPERVISION_AF = Me(i)
            If s.ID_LISTA_SUPERVISION = ID_LISTA_SUPERVISION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
