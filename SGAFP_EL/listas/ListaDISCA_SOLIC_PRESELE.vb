''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDISCA_SOLIC_PRESELE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DISCA_SOLIC_PRESELE',
''' es una representación en memoria de los registros de la tabla DISCA_SOLIC_PRESELE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDISCA_SOLIC_PRESELE
    Inherits listaBase(Of DISCA_SOLIC_PRESELE)
    Public Function BuscarPorId(ByVal ID_DISCA_SOLIC As Decimal) As DISCA_SOLIC_PRESELE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DISCA_SOLIC_PRESELE = Me(i)
            If s.ID_DISCA_SOLIC = ID_DISCA_SOLIC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
