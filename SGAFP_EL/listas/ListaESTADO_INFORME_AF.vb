''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaESTADO_INFORME_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ESTADO_INFORME_AF',
''' es una representación en memoria de los registros de la tabla ESTADO_INFORME_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaESTADO_INFORME_AF
    Inherits listaBase(Of ESTADO_INFORME_AF)
    Public Function BuscarPorId(ByVal ID_ESTADO_INFORME As Decimal) As ESTADO_INFORME_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ESTADO_INFORME_AF = Me(i)
            If s.ID_ESTADO_INFORME = ID_ESTADO_INFORME Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
