''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEDUC_LEE_ESCRIBE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EDUC_LEE_ESCRIBE',
''' es una representación en memoria de los registros de la tabla EDUC_LEE_ESCRIBE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEDUC_LEE_ESCRIBE
    Inherits listaBase(Of EDUC_LEE_ESCRIBE)
    Public Function BuscarPorId(ByVal ID_LEE_ESCRIBE As Decimal) As EDUC_LEE_ESCRIBE
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EDUC_LEE_ESCRIBE = Me(i)
            If s.ID_LEE_ESCRIBE = ID_LEE_ESCRIBE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
