''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ACCION_CONTRATADA',
''' es una representación en memoria de los registros de la tabla ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaACCION_CONTRATADA
    Inherits listaBase(Of ACCION_CONTRATADA)
    Public Function BuscarPorId(ByVal ID_ACCION_CONTRATADA As Decimal) As ACCION_CONTRATADA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As ACCION_CONTRATADA = Me(i)
            If s.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
