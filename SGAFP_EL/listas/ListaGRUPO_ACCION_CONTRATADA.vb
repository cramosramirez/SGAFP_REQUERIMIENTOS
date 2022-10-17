''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaGRUPO_ACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'GRUPO_ACCION_CONTRATADA',
''' es una representación en memoria de los registros de la tabla GRUPO_ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaGRUPO_ACCION_CONTRATADA
    Inherits listaBase(Of GRUPO_ACCION_CONTRATADA)
    Public Function BuscarPorId(ByVal ID_GRUPO_ACCION As Decimal) As GRUPO_ACCION_CONTRATADA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As GRUPO_ACCION_CONTRATADA = Me(i)
            If s.ID_GRUPO_ACCION = ID_GRUPO_ACCION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
