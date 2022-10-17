Partial Public Class cMUNICIPIO

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
    ''' 	[cramos]	22/06/2011	Modificado
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
                                                            ByVal PORCENTAJE_PROCEDENCIA As Integer, _
                                                            Optional ByVal FECHA_INICIAL As Date = #1/1/1900#, _
                                                            Optional ByVal FECHA_FINAL As Date = #1/1/1900#) As DataSet
        Try
            Dim ds As DataSet
            ds = mDb.ObtenerDataSetMunicipiosRelacionSitios( _
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
            ds = mDb.ObtenerDataSetCantidadParticipantesPorGenero( _
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetCantidadParticipantesPorGenero(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String) As DataSet
        Try
            Dim ds As DataSet
            ds = mDb.ObtenerDataSetCantidadParticipantesPorGenero(ID_SITIO_CAPACITACION, ID_EJERCICIO)

            Return ds

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Entidad filtrada por los parámetros de
    ''' la Tabla DEPARTAMENTO y NOMBRE Municipio.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="NOMBRE_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	08/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMUNICIPIOPorNOMBRE(ByVal CODIGO_DEPARTAMENTO As String, ByVal NOMBRE_MUNICIPIO As String) As MUNICIPIO
        Try
            Dim lEntidad As New MUNICIPIO
            lEntidad = mDb.ObtenerMUNICIPIOPorNOMBRE(CODIGO_DEPARTAMENTO, NOMBRE_MUNICIPIO)
            Return lEntidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMUNICIPIOPorNOMBRE_NOMBRE_DEPTO(ByVal NOMBRE_DEPARTAMENTO As String, ByVal NOMBRE_MUNICIPIO As String) As MUNICIPIO
        Try
            Dim lEntidad As New MUNICIPIO
            lEntidad = mDb.ObtenerMUNICIPIOPorNOMBRE_NOMBRE_DEPTO(NOMBRE_DEPARTAMENTO, NOMBRE_MUNICIPIO)
            Return lEntidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Strings de los tecnicos asociados.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	12/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerTECNICO_ASIGNADOS(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As List(Of String)
        Try
            Return mDb.ObtenerTECNICO_ASIGNADOS(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento que recibe de parametro
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATIPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As listaMUNICIPIO
        Try
            Dim mListaMUNICIPIO As New listaMUNICIPIO
            mListaMUNICIPIO = mDb.ObtenerListaParaPATIPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
            Return mListaMUNICIPIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento que recibe de parametro
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE(ByVal ID_FUENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String) As listaMUNICIPIO
        Try
            Dim mListaMUNICIPIO As New listaMUNICIPIO
            mListaMUNICIPIO = mDb.ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE(ID_FUENTE, CODIGO_DEPARTAMENTO)
            Return mListaMUNICIPIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por el Departamento y Tecnico que recibe de parametro
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="USUARIO_TECNICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATIPorDepartamentoTecnico(ByVal CODIGO_DEPARTAMENTO As String, ByVal USUARIO_TECNICO As String) As listaMUNICIPIO
        Try
            Dim mListaMUNICIPIO As New listaMUNICIPIO
            mListaMUNICIPIO = mDb.ObtenerListaParaPATIPorDepartamentoTecnico(CODIGO_DEPARTAMENTO, USUARIO_TECNICO)
            Return mListaMUNICIPIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Municipios que sean validos para el Programa PATI
    ''' filtrada por la Fuente de Financiamiento que recibe de parametro
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParaPATIPorFUENTE(ByVal ID_FUENTE As Decimal) As listaMUNICIPIO
        Try
            Dim mListaMUNICIPIO As New listaMUNICIPIO
            mListaMUNICIPIO = mDb.ObtenerListaParaPATIPorFUENTE(ID_FUENTE)
            Return mListaMUNICIPIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
