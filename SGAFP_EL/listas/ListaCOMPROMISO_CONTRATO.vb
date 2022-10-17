''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCOMPROMISO_CONTRATO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPROMISO_CONTRATO',
''' es una representación en memoria de los registros de la tabla COMPROMISO_CONTRATO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPROMISO_CONTRATO
    Inherits listaBase(Of COMPROMISO_CONTRATO)
    Public Function BuscarPorId(ByVal ID_COMPROMISO As Decimal) As COMPROMISO_CONTRATO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As COMPROMISO_CONTRATO = Me(i)
            If s.ID_COMPROMISO = ID_COMPROMISO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
