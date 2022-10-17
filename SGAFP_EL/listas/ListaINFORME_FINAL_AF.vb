''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaINFORME_FINAL_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'INFORME_FINAL_AF',
''' es una representación en memoria de los registros de la tabla INFORME_FINAL_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaINFORME_FINAL_AF
    Inherits listaBase(Of INFORME_FINAL_AF)
    Public Function BuscarPorId(ByVal ID_INFORME_FINAL As Decimal) As INFORME_FINAL_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As INFORME_FINAL_AF = Me(i)
            If s.ID_INFORME_FINAL = ID_INFORME_FINAL Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
