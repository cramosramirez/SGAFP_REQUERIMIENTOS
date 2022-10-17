''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SUPERVISION_AF',
''' es una representación en memoria de los registros de la tabla SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSUPERVISION_AF
    Inherits listaBase(Of SUPERVISION_AF)
    Public Function BuscarPorId(ByVal ID_SUPERVISION_AF As Decimal) As SUPERVISION_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SUPERVISION_AF = Me(i)
            If s.ID_SUPERVISION_AF = ID_SUPERVISION_AF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
