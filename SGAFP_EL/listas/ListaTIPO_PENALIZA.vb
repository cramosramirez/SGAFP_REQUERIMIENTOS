''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_PENALIZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_PENALIZA',
''' es una representación en memoria de los registros de la tabla TIPO_PENALIZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/07/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_PENALIZA
    Inherits listaBase(Of TIPO_PENALIZA)
    Public Function BuscarPorId(ByVal ID_TIPO_PENA As Decimal) As TIPO_PENALIZA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_PENALIZA = Me(i)
            If s.ID_TIPO_PENA = ID_TIPO_PENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
