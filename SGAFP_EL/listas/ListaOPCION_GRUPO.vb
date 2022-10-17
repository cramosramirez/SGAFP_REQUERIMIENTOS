''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaOPCION_GRUPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OPCION_GRUPO',
''' es una representación en memoria de los registros de la tabla OPCION_GRUPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOPCION_GRUPO
    Inherits listaBase(Of OPCION_GRUPO)
    Public Function BuscarPorId(ByVal ID_OPCION_GRUPO As Decimal) As OPCION_GRUPO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As OPCION_GRUPO = Me(i)
            If s.ID_OPCION_GRUPO = ID_OPCION_GRUPO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
