''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DESEMBOLSO_MUNI_LIQUI_DET',
''' es una representación en memoria de los registros de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDESEMBOLSO_MUNI_LIQUI_DET
    Inherits listaBase(Of DESEMBOLSO_MUNI_LIQUI_DET)
    Public Function BuscarPorId(ByVal ID_DESEMBOLSO_MUNI As Decimal) As DESEMBOLSO_MUNI_LIQUI_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DESEMBOLSO_MUNI_LIQUI_DET = Me(i)
            If s.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
