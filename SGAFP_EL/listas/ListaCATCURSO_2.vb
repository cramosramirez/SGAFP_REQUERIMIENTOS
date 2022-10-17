''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCATCURSO_2
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CATCURSO_2',
''' es una representación en memoria de los registros de la tabla CATCURSO_2
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCATCURSO_2
    Inherits listaBase(Of CATCURSO_2)
    Public Function BuscarPorId(ByVal ID_CURSO As Decimal) As CATCURSO_2
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CATCURSO_2 = Me(i)
            If s.ID_CURSO = ID_CURSO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
