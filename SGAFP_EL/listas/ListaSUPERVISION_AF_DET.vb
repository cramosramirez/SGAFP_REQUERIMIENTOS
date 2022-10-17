''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SUPERVISION_AF_DET',
''' es una representación en memoria de los registros de la tabla SUPERVISION_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSUPERVISION_AF_DET
    Inherits listaBase(Of SUPERVISION_AF_DET)
    Public Function BuscarPorId(ByVal ID_SUPERVISION_DET As Decimal) As SUPERVISION_AF_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SUPERVISION_AF_DET = Me(i)
            If s.ID_SUPERVISION_DET = ID_SUPERVISION_DET Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
