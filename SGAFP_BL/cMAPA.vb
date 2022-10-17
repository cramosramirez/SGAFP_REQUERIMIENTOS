Public Class cMAPA
    Inherits controladorBase



    Public Class HTP
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Función que permite buscar por los parametros recibidos.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cramos]	17/09/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerSITIOS_CAPACITACION(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal CODIGO_DEPARTAMENTO As String, _
                                                ByVal ID_EJERCICIO As String) As listaSITIO_CAPACITACION
            Try
                Dim lSitiosCapacitacion As listaSITIO_CAPACITACION

                lSitiosCapacitacion = (New cSITIO_CAPACITACION).ObtenerListaPorEJERCICIO(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPARTAMENTO, ID_EJERCICIO)

                Return lSitiosCapacitacion

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
        ''' 	[cramos]	20/09/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerDEPARTAMENTOS(ByVal Sitios As listaSITIO_CAPACITACION) As listaDEPARTAMENTO
            Try
                Dim lista As New List(Of String)
                Dim lDepartamentos As New listaDEPARTAMENTO

                For Each eSitio As SITIO_CAPACITACION In Sitios
                    If Not lista.Contains(eSitio.CODIGO_DEPARTAMENTO) Then
                        lista.Add(eSitio.CODIGO_DEPARTAMENTO)
                        lDepartamentos.Add((New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eSitio.CODIGO_DEPARTAMENTO))
                    End If
                Next

                Return lDepartamentos

            Catch ex As Exception
                ExceptionManager.Publish(ex)
                Return Nothing
            End Try
        End Function


        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Función que Devuelve una Colección de Entidades filtrada por el parámetro de
        ''' usuario perteneciente al técnico .
        ''' </summary>
        ''' <param name="ID_PROVEEDOR_AF"></param>
        ''' <param name="ID_SITIO_CAPACITACION"></param>
        ''' <param name="CODIGO_DEPARTAMENTO"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cramos]	20/09/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerSITIOS_CAPACITACION(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal CODIGO_DEPARTAMENTO As String, _
                                                Optional ByVal recuperarHijas As Boolean = False, _
                                                Optional ByVal recuperarForaneas As Boolean = False, _
                                                Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                                Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION
            Try
                Dim mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
                mListaSITIO_CAPACITACION = (New dbSITIO_CAPACITACION).ObtenerListaPorPROVEEDOR_AF_SITIO_CAPACITACION_DEPARTAMENTO(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)

                Return mListaSITIO_CAPACITACION

            Catch ex As Exception
                ExceptionManager.Publish(ex)
                Return Nothing
            End Try
        End Function


        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Función que Devuelve un Dataset con tablas: MUNICIPIOS y SITIOS_CAPACITACION
        ''' </summary>
        ''' <param name="ID_PROVEEDOR_AF"></param>
        ''' <param name="ID_SITIO_CAPACITACION"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cramos]	17/06/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerDataSetMunicipiosRelacionSitios(ByVal ID_TIPO_SOLICITUD As Integer, _
                                                                ByVal ID_PROVEEDOR_AF As Decimal, _
                                                                ByVal ID_SITIO_CAPACITACION As String, _
                                                                ByVal CODIGO_DEPTO_SITIO As String, _
                                                                ByVal ID_EJERCICIO As String, _
                                                                ByVal ID_AREA_FORMACION As Decimal, _
                                                                ByVal GENERO As String, _
                                                                ByVal CODIGO_DEPTO_RESIDENCIA As String, _
                                                                ByVal PORCENTAJE_PROCEDENCIA As Decimal, _
                                                                Optional ByVal FECHA_INICIAL As Date = #1/1/1900#, _
                                                                Optional ByVal FECHA_FINAL As Date = #1/1/1900#) As DataSet
            Try
                Dim ds As DataSet
                ds = (New dbMUNICIPIO).ObtenerDataSetMunicipiosRelacionSitios( _
                        ID_TIPO_SOLICITUD, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPTO_SITIO, ID_EJERCICIO, ID_AREA_FORMACION, GENERO, CODIGO_DEPTO_RESIDENCIA, PORCENTAJE_PROCEDENCIA, FECHA_INICIAL, FECHA_FINAL)

                Return ds

            Catch ex As Exception
                ExceptionManager.Publish(ex)
                Return Nothing
            End Try
        End Function


        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
        ''' la Tabla PROVEEDOR_AF y SITIO_CAPACITACION .
        ''' </summary>
        ''' <param name="ID_PROVEEDOR_AF"></param>
        ''' <param name="ID_SITIO_CAPACITACION"></param>
        ''' <param name="ID_EJERCICIO"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[cramos]	07/07/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerDataSetCantidadParticipantesPorGenero(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                                ByVal CODIGO_DEPARTAMENTO As String, _
                                                                ByVal CODIGO_MUNICIPIO As String, _
                                                                ByVal ID_AREA_FORMACION As Decimal, _
                                                                ByVal ID_EJERCICIO As String) As DataSet
            Try
                Dim ds As DataSet
                ds = (New dbMUNICIPIO).ObtenerDataSetCantidadParticipantesPorGenero( _
                            ID_PROVEEDOR_AF, _
                            ID_SITIO_CAPACITACION, _
                            CODIGO_DEPARTAMENTO, _
                            CODIGO_MUNICIPIO, _
                            ID_AREA_FORMACION, _
                            ID_EJERCICIO)

                Return ds

            Catch ex As Exception
                ExceptionManager.Publish(ex)
                Return Nothing
            End Try
        End Function
    End Class


    Public Class PATI
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
        ''' la Tabla FUENTE_FINANCIAMIENTO, FASE, DEPARTAMENTO .
        ''' </summary>
        ''' <param name="ID_FUENTE"></param>
        ''' <param name="ID_FASE"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[GenApp]	20/09/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(ByVal ID_FUENTE As Decimal, _
                                                                ByVal ID_FASE As Decimal) As listaFASE_MUNICIPIOS
            Try
                Dim mListaFASE_MUNICIPIOS As New listaFASE_MUNICIPIOS
                mListaFASE_MUNICIPIOS = (New cFASE_MUNICIPIOS).ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(ID_FUENTE, ID_FASE, "", "")
                Return mListaFASE_MUNICIPIOS

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
        ''' 	[cramos]	21/09/2010	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
        Public Function ObtenerDEPARTAMENTOS(ByVal FaseMunicipios As listaFASE_MUNICIPIOS) As listaDEPARTAMENTO
            Try
                Dim lista As New List(Of String)
                Dim lDepartamentos As New listaDEPARTAMENTO

                For Each eFaseMunicipio As FASE_MUNICIPIOS In FaseMunicipios
                    If Not lista.Contains(eFaseMunicipio.CODIGO_DEPARTAMENTO) Then
                        lista.Add(eFaseMunicipio.CODIGO_DEPARTAMENTO)
                        lDepartamentos.Add((New cDEPARTAMENTO).ObtenerDEPARTAMENTO(eFaseMunicipio.CODIGO_DEPARTAMENTO))
                    End If
                Next

                Return lDepartamentos

            Catch ex As Exception
                ExceptionManager.Publish(ex)
                Return Nothing
            End Try
        End Function
    End Class

    Public Class ISSS

    End Class
   


    
End Class
