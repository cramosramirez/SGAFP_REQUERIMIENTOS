''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCOMPROMISO_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'COMPROMISO_AF',
''' es una representación en memoria de los registros de la tabla COMPROMISO_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCOMPROMISO_AF
    Inherits listaBase(Of COMPROMISO_AF)
    Public Function BuscarPorId(ByVal ID_COMPROMISO As Decimal, ByVal ID_INFORME_FINAL As Decimal) As COMPROMISO_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As COMPROMISO_AF = Me(i)
            If s.ID_COMPROMISO = ID_COMPROMISO _
            And s.ID_INFORME_FINAL = ID_INFORME_FINAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
