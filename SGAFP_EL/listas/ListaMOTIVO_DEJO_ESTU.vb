''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaMOTIVO_DEJO_ESTU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'MOTIVO_DEJO_ESTU',
''' es una representación en memoria de los registros de la tabla MOTIVO_DEJO_ESTU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaMOTIVO_DEJO_ESTU
    Inherits listaBase(Of MOTIVO_DEJO_ESTU)
    Public Function BuscarPorId(ByVal ID_MOTIVO_DEJO_ESTU As Decimal) As MOTIVO_DEJO_ESTU
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As MOTIVO_DEJO_ESTU = Me(i)
            If s.ID_MOTIVO_DEJO_ESTU = ID_MOTIVO_DEJO_ESTU Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
