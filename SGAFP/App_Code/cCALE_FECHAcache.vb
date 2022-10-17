Imports Microsoft.VisualBasic
Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cCALE_FECHAcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion_ucListaCALE_FECHA As String) As listaCALE_FECHA
        Try
            Dim lista As listaCALE_FECHA
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_ucListaCALE_FECHA) Is Nothing Then Return New listaCALE_FECHA
            lista = TryCast(_SESION(nombreSesion_ucListaCALE_FECHA), listaCALE_FECHA)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_CALE As Int32, ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCALE_FECHA = _SESION(REFERENCIA)

            If ID_CALE > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CALE = ID_CALE Then
                        mDetalle.RemoveAt(i)
                        Exit For
                    End If
                Next
            End If
            _SESION(REFERENCIA) = mDetalle
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_CALE As Int32, _
                            ByVal FECHA As DateTime, ByVal listaHorario As listaCALE_HORARIO, ByVal MINUTOS As Integer, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaCALE_FECHA = _SESION(REFERENCIA)
            Dim iMinutos As Integer = 0
            Dim sHorario As New StringBuilder

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CALE = ID_CALE Then

                        mDetalle(i).FECHA = FECHA
                        mDetalle(i).HORARIO = ""
                        mDetalle(i).MINUTOS = 0

                        If listaHorario IsNot Nothing AndAlso listaHorario.Count > 0 Then
                            listaHorario.SortByColum("HORA_INI", ComponentModel.ListSortDirection.Ascending)
                            For j As Integer = 0 To listaHorario.Count - 1
                                If j > 0 Then sHorario.Append(" Y ")
                                sHorario.Append("DE " + listaHorario(j).HORA_INI.ToString("h:mmtt").ToUpper + " A " + listaHorario(j).HORA_FIN.ToString("h:mmtt").ToUpper)
                                iMinutos += Math.Abs(DateDiff(DateInterval.Minute, listaHorario(j).HORA_FIN, listaHorario(j).HORA_INI))
                            Next
                            mDetalle(i).HORARIO = sHorario.ToString
                            mDetalle(i).MINUTOS = iMinutos
                        End If
                        mDetalle(i).REFERENCIA = REFERENCIA
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mDetalle
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
