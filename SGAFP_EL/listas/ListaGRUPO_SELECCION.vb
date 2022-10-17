''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaGRUPO_SELECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'GRUPO_SELECCION',
''' es una representación en memoria de los registros de la tabla GRUPO_SELECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaGRUPO_SELECCION
    Inherits listaBase(Of GRUPO_SELECCION)
    Public Function BuscarPorId(ByVal ID_GRUPO_SELEC As Decimal) As GRUPO_SELECCION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As GRUPO_SELECCION = Me(i)
            If s.ID_GRUPO_SELEC = ID_GRUPO_SELEC Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
