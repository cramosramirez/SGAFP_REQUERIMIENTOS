''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIEMPO_NOTRAB
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIEMPO_NOTRAB',
''' es una representación en memoria de los registros de la tabla TIEMPO_NOTRAB
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	08/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIEMPO_NOTRAB
    Inherits listaBase(Of TIEMPO_NOTRAB)
    Public Function BuscarPorId(ByVal ID_TIEMPO_NOTRAB As Decimal) As TIEMPO_NOTRAB
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIEMPO_NOTRAB = Me(i)
            If s.ID_TIEMPO_NOTRAB = ID_TIEMPO_NOTRAB Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
