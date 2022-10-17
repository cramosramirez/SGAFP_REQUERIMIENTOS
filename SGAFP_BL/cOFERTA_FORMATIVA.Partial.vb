Partial Class cOFERTA_FORMATIVA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro de la tabla OFERTA FORMATIVA para el Curso y 
    ''' el proveedor que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	11/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorTemaCurso(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal) As OFERTA_FORMATIVA
        Try
            Return Me.mDb.ObtenerOfertaFormativaPorTemaCurso(ID_PROVEEDOR_AF, ID_TEMA_CURSO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro de la tabla OFERTA FORMATIVA para el área de formación, proveedor, sitio de capacitación y 
    ''' el ejercicio que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[cramos]	15/03/2010	Created
    ''' 	[cramos]	23/04/2010	Modify
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorAreaFormacion_Proveedor_Sitio_Ejercicio(ByVal ID_AREA_FORMACION As Decimal, ByVal ID_PROVEEDOR As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String) As listaOFERTA_FORMATIVA
        Try
            Return Me.mDb.ObtenerOfertaFormativaPorAreaFormacion_Proveedor_Sitio_Ejercicio(ID_AREA_FORMACION, ID_PROVEEDOR, ID_SITIO_CAPACITACION, ID_EJERCICIO, "TEMA_CURSO")
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera registros de la tabla OFERTA FORMATIVA para el Curso y 
    ''' el proveedor que recibe de parametro.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	15/03/2010	Created
    ''' 	[ecarias]	24/06/2010	Se agrego para Recuperar detallar por Sitio de Capacitacion la Oferta
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativaPorCriterios(ByVal aCriterios() As Criteria, Optional ByVal porSitio As Boolean = False) As listaOFERTA_FORMATIVA
        Try
            Return mDb.ObtenerOfertaFormativaPorCriterios(aCriterios, porSitio)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que obtiene la Oferta Formativa de acuerdo a los parámetros especificados
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	20/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOfertaFormativa(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_AREA_FORMACION As Decimal) As DataSet
        Try
            Return mDb.ObtenerOfertaFormativa(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, ID_AREA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function


    Public Function ObtenerOfertaFormativaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_AREA_FORMACION As Decimal) As listaOFERTA_FORMATIVA
        Try
            Return mDb.ObtenerOfertaFormativaPorCriterios(ID_PROVEEDOR_AF, ID_EJERCICIO, ID_AREA_FORMACION)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
