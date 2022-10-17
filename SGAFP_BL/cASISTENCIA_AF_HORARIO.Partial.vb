Imports System.Text

Partial Public Class cASISTENCIA_AF_HORARIO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina todos los Registro de la Tabla ASISTENCIA_AF_HORARIO tomando como referencia los parámetros enviados.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Try

            Return mDb.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(ID_ASISTENCIA_AF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Horario como una cadena de acuerdo al valor pasado como parámetro
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ExpresionHorarioPorDia(ByVal ID_ASISTENCIA_AF As Decimal) As String
        Dim Detalle As listaASISTENCIA_AF_HORARIO
        Dim sHorario As New StringBuilder
        Dim Conta As Integer = 0

        Detalle = (New cASISTENCIA_AF_HORARIO).ObtenerListaPorASISTENCIA_AF(ID_ASISTENCIA_AF, , "HORA_INICIO")
        For Each eHorario As ASISTENCIA_AF_HORARIO In Detalle
            If Conta > 0 Then
                sHorario.Append(" Y ")
            End If
            sHorario.Append("DE ")
            sHorario.Append(eHorario.HORA_INICIO.ToString("h:mmtt").ToUpper)
            sHorario.Append(" A ")
            sHorario.Append(eHorario.HORA_FIN.ToString("h:mmtt").ToUpper)
            Conta += 1
        Next

        Return sHorario.ToString
    End Function

End Class
