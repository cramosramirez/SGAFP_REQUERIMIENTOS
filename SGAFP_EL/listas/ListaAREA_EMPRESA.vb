''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaAREA_EMPRESA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AREA_EMPRESA',
''' es una representación en memoria de los registros de la tabla AREA_EMPRESA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAREA_EMPRESA
    Inherits listaBase(Of AREA_EMPRESA)
    Public Function BuscarPorId(ByVal ID_AREA_EMPRESA As Decimal) As AREA_EMPRESA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As AREA_EMPRESA = Me(i)
            If s.ID_AREA_EMPRESA = ID_AREA_EMPRESA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
