''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIEMPO_DEJO_ESTUDIAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIEMPO_DEJO_ESTUDIAR',
''' es una representación en memoria de los registros de la tabla TIEMPO_DEJO_ESTUDIAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIEMPO_DEJO_ESTUDIAR
    Inherits listaBase(Of TIEMPO_DEJO_ESTUDIAR)
    Public Function BuscarPorId(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal) As TIEMPO_DEJO_ESTUDIAR
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIEMPO_DEJO_ESTUDIAR = Me(i)
            If s.ID_TIEMPO_DEJO_ESTUDIAR = ID_TIEMPO_DEJO_ESTUDIAR Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
