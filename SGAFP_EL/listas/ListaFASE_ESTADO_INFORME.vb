''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaFASE_ESTADO_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'FASE_ESTADO_INFORME',
''' es una representación en memoria de los registros de la tabla FASE_ESTADO_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaFASE_ESTADO_INFORME
    Inherits listaBase(Of FASE_ESTADO_INFORME)
    Public Function BuscarPorId(ByVal ID_FASE_ESTADO As Decimal) As FASE_ESTADO_INFORME
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As FASE_ESTADO_INFORME = Me(i)
            If s.ID_FASE_ESTADO = ID_FASE_ESTADO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
