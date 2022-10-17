''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDESEMBOLSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DESEMBOLSO',
''' es una representación en memoria de los registros de la tabla DESEMBOLSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDESEMBOLSO
    Inherits listaBase(Of DESEMBOLSO)
    Public Function BuscarPorId(ByVal ID_DESEMBOLSO As Decimal) As DESEMBOLSO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DESEMBOLSO = Me(i)
            If s.ID_DESEMBOLSO = ID_DESEMBOLSO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
