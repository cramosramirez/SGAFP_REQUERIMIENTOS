''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPAQUETE_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PAQUETE_INFORME',
''' es una representación en memoria de los registros de la tabla PAQUETE_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPAQUETE_INFORME
    Inherits listaBase(Of PAQUETE_INFORME)
    Public Function BuscarPorId(ByVal ID_PAQUETE As Decimal) As PAQUETE_INFORME
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PAQUETE_INFORME = Me(i)
            If s.ID_PAQUETE = ID_PAQUETE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
