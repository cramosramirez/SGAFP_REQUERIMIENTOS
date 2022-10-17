''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaPAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PAQUETE_INFORME_DET',
''' es una representación en memoria de los registros de la tabla PAQUETE_INFORME_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPAQUETE_INFORME_DET
    Inherits listaBase(Of PAQUETE_INFORME_DET)
    Public Function BuscarPorId(ByVal ID_PAQUETE As Decimal, ByVal ID_INFORME_FINAL As Decimal) As PAQUETE_INFORME_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As PAQUETE_INFORME_DET = Me(i)
            If s.ID_PAQUETE = ID_PAQUETE _
            And s.ID_INFORME_FINAL = ID_INFORME_FINAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
