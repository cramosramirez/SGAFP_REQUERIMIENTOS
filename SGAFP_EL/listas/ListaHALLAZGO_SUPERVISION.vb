''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaHALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'HALLAZGO_SUPERVISION',
''' es una representación en memoria de los registros de la tabla HALLAZGO_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaHALLAZGO_SUPERVISION
    Inherits listaBase(Of HALLAZGO_SUPERVISION)
    Public Function BuscarPorId(ByVal ID_HALLAZGO_SUPERVISION As Decimal) As HALLAZGO_SUPERVISION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As HALLAZGO_SUPERVISION = Me(i)
            If s.ID_HALLAZGO_SUPERVISION = ID_HALLAZGO_SUPERVISION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
