''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaESTADO_CIVIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_CIVIL',
''' es una representación en memoria de los registros de la tabla ESTADO_CIVIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_CIVIL
    Inherits listaBase(Of ESTADO_CIVIL)
    Public Function BuscarPorId(ByVal ID_ESTADO_CIVIL As Decimal) As ESTADO_CIVIL
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ESTADO_CIVIL = Me(i)
            If s.ID_ESTADO_CIVIL = ID_ESTADO_CIVIL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
