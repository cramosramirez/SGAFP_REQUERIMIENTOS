''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaRANGO_PORC_PENA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'RANGO_PORC_PENA',
''' es una representación en memoria de los registros de la tabla RANGO_PORC_PENA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/07/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaRANGO_PORC_PENA
    Inherits listaBase(Of RANGO_PORC_PENA)
    Public Function BuscarPorId(ByVal ID_RANGO As Decimal) As RANGO_PORC_PENA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As RANGO_PORC_PENA = Me(i)
            If s.ID_RANGO = ID_RANGO Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
