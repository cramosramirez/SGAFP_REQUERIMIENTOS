''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaINGRESO_MES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'INGRESO_MES',
''' es una representación en memoria de los registros de la tabla INGRESO_MES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaINGRESO_MES
    Inherits listaBase(Of INGRESO_MES)
    Public Function BuscarPorId(ByVal ID_INGRESO_MES As Decimal) As INGRESO_MES
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As INGRESO_MES = Me(i)
            If s.ID_INGRESO_MES = ID_INGRESO_MES Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
