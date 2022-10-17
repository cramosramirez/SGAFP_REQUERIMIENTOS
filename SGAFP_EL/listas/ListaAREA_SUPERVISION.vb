''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaAREA_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AREA_SUPERVISION',
''' es una representación en memoria de los registros de la tabla AREA_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAREA_SUPERVISION
    Inherits listaBase(Of AREA_SUPERVISION)
    Public Function BuscarPorId(ByVal ID_AREA_SUPERVISION As Decimal) As AREA_SUPERVISION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As AREA_SUPERVISION = Me(i)
            If s.ID_AREA_SUPERVISION = ID_AREA_SUPERVISION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing

    End Function

End Class
