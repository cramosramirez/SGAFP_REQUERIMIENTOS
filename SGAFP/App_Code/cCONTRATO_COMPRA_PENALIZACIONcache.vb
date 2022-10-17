Imports Microsoft.VisualBasic
Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class cCONTRATO_COMPRA_PENALIZACIONcache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal nombreSesion_uclistaCONTRATO_COMPRA_PENALIZACION As String) As ListaCONTRATO_COMPRA_PENALIZACION
        Try
            Dim lista As ListaCONTRATO_COMPRA_PENALIZACION
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion_uclistaCONTRATO_COMPRA_PENALIZACION) Is Nothing Then Return New ListaCONTRATO_COMPRA_PENALIZACION
            lista = TryCast(_SESION(nombreSesion_uclistaCONTRATO_COMPRA_PENALIZACION), ListaCONTRATO_COMPRA_PENALIZACION)

            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_CONTRA_PENA As Decimal, _
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As ListaCONTRATO_COMPRA_PENALIZACION = _SESION(REFERENCIA)

            If ID_CONTRA_PENA > 0 AndAlso mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_PENA = ID_CONTRA_PENA Then
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
    Public Function Actualizar(ByVal ID_CONTRA_PENA As Decimal, ByVal ID_CONTRATO_COMPRA As Decimal, _
                            ByVal ID_TIPO_PENA As Decimal, ByVal RANGO_INI As Decimal, ByVal RANGO_FIN As Decimal, ByVal PORC_PENA As Decimal, _
                            ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mDetalle As ListaCONTRATO_COMPRA_PENALIZACION = _SESION(REFERENCIA)

            If mDetalle IsNot Nothing Then
                For i As Integer = 0 To mDetalle.Count - 1
                    If mDetalle(i).ID_CONTRA_PENA = ID_CONTRA_PENA Then
                        mDetalle(i).ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
                        mDetalle(i).ID_TIPO_PENA = ID_TIPO_PENA
                        mDetalle(i).RANGO_INI = RANGO_INI
                        mDetalle(i).RANGO_FIN = RANGO_FIN
                        mDetalle(i).PORC_PENA = Math.Round(PORC_PENA, 2)
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
