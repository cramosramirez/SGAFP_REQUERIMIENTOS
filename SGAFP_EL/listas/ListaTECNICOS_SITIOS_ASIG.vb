''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTECNICOS_SITIOS_ASIG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TECNICOS_SITIOS_ASIG',
''' es una representación en memoria de los registros de la tabla TECNICOS_SITIOS_ASIG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTECNICOS_SITIOS_ASIG
    Inherits listaBase(Of TECNICOS_SITIOS_ASIG)
    Public Function BuscarPorId(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal) As TECNICOS_SITIOS_ASIG
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TECNICOS_SITIOS_ASIG = Me(i)
            If s.USUARIO = USUARIO _
            And s.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF _
            And s.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
