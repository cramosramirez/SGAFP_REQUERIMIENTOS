''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaESTADO_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_REPROG',
''' es una representación en memoria de los registros de la tabla ESTADO_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_REPROG
    Inherits listaBase(Of ESTADO_REPROG)
    Public Function BuscarPorId(ByVal ID_ESTADO_REPROG As Decimal) As ESTADO_REPROG
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ESTADO_REPROG = Me(i)
            If s.ID_ESTADO_REPROG = ID_ESTADO_REPROG Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
