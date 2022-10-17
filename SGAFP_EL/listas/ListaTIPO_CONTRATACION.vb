''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaTIPO_CONTRATACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'TIPO_CONTRATACION',
''' es una representación en memoria de los registros de la tabla TIPO_CONTRATACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaTIPO_CONTRATACION
    Inherits listaBase(Of TIPO_CONTRATACION)
    Public Function BuscarPorId(ByVal ID_TIPO_CONTRA As Decimal) As TIPO_CONTRATACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As TIPO_CONTRATACION = Me(i)
            If s.ID_TIPO_CONTRA = ID_TIPO_CONTRA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

End Class
