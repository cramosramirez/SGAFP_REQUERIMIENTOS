''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EVALUACIONES_AF_DET',
''' es una representación en memoria de los registros de la tabla EVALUACIONES_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEVALUACIONES_AF_DET
    Inherits listaBase(Of EVALUACIONES_AF_DET)
    Public Function BuscarPorId(ByVal ID_EVALUACION_DET As Decimal) As EVALUACIONES_AF_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EVALUACIONES_AF_DET = Me(i)
            If s.ID_EVALUACION_DET = ID_EVALUACION_DET Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
