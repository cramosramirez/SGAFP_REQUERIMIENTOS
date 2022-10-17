''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_EMPLEO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_EMPLEO',
''' es una representación en memoria de los registros de la tabla TIPO_EMPLEO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_EMPLEO
    Inherits listaBase(Of TIPO_EMPLEO)
    Public Function BuscarPorId(ByVal ID_TIPO_EMPLEO As Decimal) As TIPO_EMPLEO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_EMPLEO = Me(i)
            If s.ID_TIPO_EMPLEO = ID_TIPO_EMPLEO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
