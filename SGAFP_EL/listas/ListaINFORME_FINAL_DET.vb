''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.listaINFORME_FINAL_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'INFORME_FINAL_DET',
''' es una representación en memoria de los registros de la tabla INFORME_FINAL_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaINFORME_FINAL_DET
    Inherits listaBase(Of INFORME_FINAL_DET)
    Public Function BuscarPorId(ByVal ID_INFORME_FINAL_DET As Decimal) As INFORME_FINAL_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As INFORME_FINAL_DET = Me(i)
            If s.ID_INFORME_FINAL_DET = ID_INFORME_FINAL_DET Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Function BuscarPorInformeParticipante(ByVal ID_INFORME_FINAL_AF As Decimal, ByVal ID_PARTICIPANTE As Decimal) As INFORME_FINAL_DET
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As INFORME_FINAL_DET = Me(i)
            If s.ID_INFORME_FINAL = ID_INFORME_FINAL_AF AndAlso s.ID_PARTICIPANTE = ID_PARTICIPANTE Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Function DevolverCursosPagados() As List(Of INFORME_FINAL_DET)
        Return Me.FindAll(Function(ifd As INFORME_FINAL_DET) ifd.PORC_ASISTENCIA > 80)
    End Function
End Class
