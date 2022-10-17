''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaSOLIC_PRESELE_CURREC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_PRESELE_CURREC',
''' es una representación en memoria de los registros de la tabla SOLIC_PRESELE_CURREC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_PRESELE_CURREC
    Inherits listaBase(Of SOLIC_PRESELE_CURREC)
    Public Function BuscarPorId(ByVal ID_PRESELE_CURREC As Decimal) As SOLIC_PRESELE_CURREC
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As SOLIC_PRESELE_CURREC = Me(i)
            If s.ID_PRESELE_CURREC = ID_PRESELE_CURREC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
