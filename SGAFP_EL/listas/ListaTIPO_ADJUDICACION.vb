''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_ADJUDICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_ADJUDICACION',
''' es una representación en memoria de los registros de la tabla TIPO_ADJUDICACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_ADJUDICACION
    Inherits listaBase(Of TIPO_ADJUDICACION)
    Public Function BuscarPorId(ByVal ID_TIPO_ADJ As Decimal) As TIPO_ADJUDICACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_ADJUDICACION = Me(i)
            If s.ID_TIPO_ADJ = ID_TIPO_ADJ Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
