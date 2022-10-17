''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaAREA_FORMACION_CONTRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'AREA_FORMACION_CONTRA',
''' es una representación en memoria de los registros de la tabla AREA_FORMACION_CONTRA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/06/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaAREA_FORMACION_CONTRA
    Inherits listaBase(Of AREA_FORMACION_CONTRA)
    Public Function BuscarPorId(ByVal ID_AREA_CONTRA As Decimal) As AREA_FORMACION_CONTRA
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As AREA_FORMACION_CONTRA = Me(i)
            If s.ID_AREA_CONTRA = ID_AREA_CONTRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
