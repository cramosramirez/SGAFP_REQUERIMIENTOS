''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDISCA_POR_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DISCA_POR_SOLICITUD',
''' es una representación en memoria de los registros de la tabla DISCA_POR_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDISCA_POR_SOLICITUD
    Inherits listaBase(Of DISCA_POR_SOLICITUD)
    Public Function BuscarPorId(ByVal ID_DISCAPACIDAD As Decimal, ByVal ID_SOLICITUD As Decimal) As DISCA_POR_SOLICITUD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DISCA_POR_SOLICITUD = Me(i)
            If s.ID_DISCAPACIDAD = ID_DISCAPACIDAD _
            And s.ID_SOLICITUD = ID_SOLICITUD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
