''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaDISCAPACIDAD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'DISCAPACIDAD',
''' es una representación en memoria de los registros de la tabla DISCAPACIDAD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaDISCAPACIDAD
    Inherits listaBase(Of DISCAPACIDAD)
    Public Function BuscarPorId(ByVal ID_DISCAPACIDAD As Decimal) As DISCAPACIDAD
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As DISCAPACIDAD = Me(i)
            If s.ID_DISCAPACIDAD = ID_DISCAPACIDAD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
