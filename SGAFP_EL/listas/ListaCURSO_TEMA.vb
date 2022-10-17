''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCURSO_TEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CURSO_TEMA',
''' es una representación en memoria de los registros de la tabla CURSO_TEMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/12/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCURSO_TEMA
    Inherits listaBase(Of CURSO_TEMA)
    Public Function BuscarPorId(ByVal ID_TEMA_CURSO As Decimal) As CURSO_TEMA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CURSO_TEMA = Me(i)
            If s.ID_TEMA_CURSO = ID_TEMA_CURSO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
