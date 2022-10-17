''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_BOLPROS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_BOLPROS',
''' es una representación en memoria de los registros de la tabla CONTRATO_BOLPROS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_BOLPROS
    Inherits listaBase(Of CONTRATO_BOLPROS)
    Public Function BuscarPorId(ByVal ID_CONTRATO As Decimal) As CONTRATO_BOLPROS
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_BOLPROS = Me(i)
            If s.ID_CONTRATO = ID_CONTRATO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
