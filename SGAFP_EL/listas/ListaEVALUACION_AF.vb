''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaEVALUACION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'EVALUACION_AF',
''' es una representación en memoria de los registros de la tabla EVALUACION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaEVALUACION_AF
    Inherits listaBase(Of EVALUACION_AF)
    Public Function BuscarPorId(ByVal ID_EVALUACION_AF As Decimal) As EVALUACION_AF
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As EVALUACION_AF = Me(i)
            If s.ID_EVALUACION_AF = ID_EVALUACION_AF Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Function CountPorTipoEvaluacion(ByVal tipoEvaluacion As String) As Integer
        Dim numero As Integer = 0
        For Each lEntidad As EVALUACION_AF In Me
            If lEntidad.TIPO_EVALUACION = tipoEvaluacion Then numero += 1
        Next
        Return numero
    End Function

End Class
