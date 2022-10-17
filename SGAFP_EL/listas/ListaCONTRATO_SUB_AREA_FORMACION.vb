''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaCONTRATO_SUB_AREA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'CONTRATO_SUB_AREA_FORMACION',
''' es una representación en memoria de los registros de la tabla CONTRATO_SUB_AREA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaCONTRATO_SUB_AREA_FORMACION
    Inherits listaBase(Of CONTRATO_SUB_AREA_FORMACION)
    Public Function BuscarPorId(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal) As CONTRATO_SUB_AREA_FORMACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_SUB_AREA_FORMACION = Me(i)
            If s.ID_CONTRATO = ID_CONTRATO _
            And s.ID_SUBAREA_FORMACION = ID_SUBAREA_FORMACION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
