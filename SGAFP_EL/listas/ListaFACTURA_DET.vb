''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFACTURA_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FACTURA_DET',
''' es una representación en memoria de los registros de la tabla FACTURA_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/08/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFACTURA_DET
    Inherits listaBase(Of FACTURA_DET)
    Public Function BuscarPorId(ByVal ID_FACTURA_DET As Decimal) As FACTURA_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FACTURA_DET = Me(i)
            If s.ID_FACTURA_DET = ID_FACTURA_DET Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
