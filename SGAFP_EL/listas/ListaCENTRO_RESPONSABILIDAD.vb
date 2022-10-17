''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCENTRO_RESPONSABILIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CENTRO_RESPONSABILIDAD',
''' es una representación en memoria de los registros de la tabla CENTRO_RESPONSABILIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCENTRO_RESPONSABILIDAD
    Inherits listaBase(Of CENTRO_RESPONSABILIDAD)
    Public Function BuscarPorId(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) As CENTRO_RESPONSABILIDAD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CENTRO_RESPONSABILIDAD = Me(i)
            If s.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
