''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMETODO_EVALUACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'METODO_EVALUACION',
''' es una representación en memoria de los registros de la tabla METODO_EVALUACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMETODO_EVALUACION
    Inherits listaBase(Of METODO_EVALUACION)
    Public Function BuscarPorId(ByVal ID_METODO_EVALUACION As Decimal) As METODO_EVALUACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As METODO_EVALUACION = Me(i)
            If s.ID_METODO_EVALUACION = ID_METODO_EVALUACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
