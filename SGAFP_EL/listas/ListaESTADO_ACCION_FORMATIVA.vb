''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaESTADO_ACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_ACCION_FORMATIVA',
''' es una representación en memoria de los registros de la tabla ESTADO_ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_ACCION_FORMATIVA
    Inherits listaBase(Of ESTADO_ACCION_FORMATIVA)
    Public Function BuscarPorId(ByVal CODIGO_ESTADO_AF As String) As ESTADO_ACCION_FORMATIVA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ESTADO_ACCION_FORMATIVA = Me(i)
            If s.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
