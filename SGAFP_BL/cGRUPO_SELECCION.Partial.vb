Partial Public Class cGRUPO_SELECCION

    Public Function ObtenerTotalHorasCalendarizadas(ByVal ID_GRUPO_SELEC As Decimal) As Integer
        Try
            Dim s As Object = mDb.ObtenerTotalHorasCalendarizadas(ID_GRUPO_SELEC)

            If IsDBNull(s) Then
                s = 0
            End If

            Return CInt(s)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try
    End Function


    Public Function ObtenerUltimaFechaInicioCalendarizada(ByVal ID_GRUPO_SELEC As Decimal) As Date
        Try
            Dim s As Object = mDb.ObtenerUltimaFechaInicioCalendarizada(ID_GRUPO_SELEC)

            If IsDBNull(s) Then
                s = #12:00:00 AM#
            End If

            Return s
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            ByVal CON_INFORME_PRESELECCION As Integer, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SELECCION
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, NUM_CONTRATO, CON_INFORME_PRESELECCION, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


End Class
