''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTERMINO_REFERENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TERMINO_REFERENCIA_AF',
''' es una representación en memoria de los registros de la tabla TERMINO_REFERENCIA_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTERMINO_REFERENCIA_AF
    Inherits listaBase(Of TERMINO_REFERENCIA_AF)
    Public Function BuscarPorId(ByVal ID_ACCION_FORMATIVA As Decimal) As TERMINO_REFERENCIA_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TERMINO_REFERENCIA_AF = Me(i)
            If s.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
