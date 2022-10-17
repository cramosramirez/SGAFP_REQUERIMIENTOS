''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMODALIDAD_DE_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MODALIDAD_DE_FORMACION',
''' es una representación en memoria de los registros de la tabla MODALIDAD_DE_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMODALIDAD_DE_FORMACION
    Inherits listaBase(Of MODALIDAD_DE_FORMACION)
    Public Function BuscarPorId(ByVal ID_MODALIDAD_FORMACION As Decimal) As MODALIDAD_DE_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As MODALIDAD_DE_FORMACION = Me(i)
            If s.ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
