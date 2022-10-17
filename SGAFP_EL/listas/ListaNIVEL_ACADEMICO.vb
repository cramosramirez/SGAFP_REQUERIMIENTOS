''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaNIVEL_ACADEMICO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'NIVEL_ACADEMICO',
''' es una representación en memoria de los registros de la tabla NIVEL_ACADEMICO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaNIVEL_ACADEMICO
    Inherits listaBase(Of NIVEL_ACADEMICO)
    Public Function BuscarPorId(ByVal ID_NIVEL_ACADEMICO As Decimal) As NIVEL_ACADEMICO
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As NIVEL_ACADEMICO = Me(i)
            If s.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
