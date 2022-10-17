Imports Microsoft.VisualBasic
Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cASISTENCIA_PAGO_DETcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaASISTENCIA_PAGO_DET As String) As listaASISTENCIA_PAGO_DET
        Try
            Dim lista As listaASISTENCIA_PAGO_DET
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaASISTENCIA_PAGO_DET) Is Nothing Then Return New listaASISTENCIA_PAGO_DET
            lista = TryCast(_SESION(nombreSesion_uclistaASISTENCIA_PAGO_DET), listaASISTENCIA_PAGO_DET)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_ASISTE_PAGO_DET As Decimal, _
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaASISTENCIA_PAGO_DET = _SESION(REFERENCIA)

            If ID_ASISTE_PAGO_DET > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ASISTE_PAGO_DET = ID_ASISTE_PAGO_DET Then
                        mDetalle.RemoveAt(i)
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
    Public Function Actualizar(ByVal ID_ASISTE_PAGO_DET As Decimal, ByVal ID_ASISTE_PAGO As Decimal, _
                            ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTE_INI As Decimal, ByVal PORC_ASISTE_FIN As Decimal, ByVal PORC_PAGO_COSTO_PARTI As Decimal, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As listaASISTENCIA_PAGO_DET = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_ASISTE_PAGO_DET = ID_ASISTE_PAGO_DET Then
                        mDetalle(i).ID_ASISTE_PAGO = ID_ASISTE_PAGO
                        mDetalle(i).ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
                        mDetalle(i).PORC_ASISTE_INI = PORC_ASISTE_INI
                        mDetalle(i).PORC_ASISTE_FIN = PORC_ASISTE_FIN
                        mDetalle(i).PORC_PAGO_COSTO_PARTI = Math.Round(PORC_PAGO_COSTO_PARTI, 2)
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
