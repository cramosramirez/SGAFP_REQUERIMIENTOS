Partial Public Class cDEPARTAMENTO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorProveedor_Presencia_Sitio(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "DEPARTAMENTO.NOMBRE", Optional ByVal asTipoOrden As String = "ASC") As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaPorProveedor_Presencia_Sitio(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaDEPARTAMENTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As DEPARTAMENTO In mListaDEPARTAMENTO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDEPARTAMENTO
            If Not mListaDEPARTAMENTO Is Nothing Then
                For Each lEntidad As DEPARTAMENTO In mListaDEPARTAMENTO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSitio_Capacitacion(ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "DEPARTAMENTO.NOMBRE", Optional ByVal asTipoOrden As String = "ASC") As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaPorSitio_Capacitacion(ID_SITIO_CAPACITACION, asColumnaOrden, asTipoOrden)
            If Not mListaDEPARTAMENTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As DEPARTAMENTO In mListaDEPARTAMENTO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaDEPARTAMENTO
            If Not mListaDEPARTAMENTO Is Nothing Then
                For Each lEntidad As DEPARTAMENTO In mListaDEPARTAMENTO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
  Public Function ObtenerDataSetProcedenciaPorEjercicioRangoFechas(ByVal ID_EJERCICIO As String, ByVal FECHA_INICIAL As Date, ByVal FECHA_FINAL As Date) As DataSet
        Try
            Return mDb.ObtenerDataSetProcedenciaPorEjercicioRangoFechas(ID_EJERCICIO, FECHA_INICIAL, FECHA_FINAL)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el Programa PATI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATI() As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaParaPATI()
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el Programa PATI
    ''' y filtrado por la Fuente de Financiamiento
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATIPorFuente(ByVal ID_FUENTE As Decimal) As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaParaPATIPorFuente(ID_FUENTE)
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Departamentos que sean validos para el 
    ''' Programa PATI y filtrada por el Tecnico asignado
    ''' </summary>
    ''' <param name="USUARIO_TECNICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	24/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaPATITecnico(ByVal USUARIO_TECNICO As String) As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaParaPATITecnico(USUARIO_TECNICO)
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Departamentos sin el DESCONOCIDO-NO-UTILIZAR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaSinDesconocido() As listaDEPARTAMENTO
        Try
            Dim mListaDEPARTAMENTO As New listaDEPARTAMENTO
            mListaDEPARTAMENTO = mDb.ObtenerListaPorID()
            Dim lDeptoDesconocido As DEPARTAMENTO = mListaDEPARTAMENTO.BuscarPorId("15")
            mListaDEPARTAMENTO.Remove(lDeptoDesconocido)
            Return mListaDEPARTAMENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Entidad filtrada por los parámetros de
    ''' la Tabla NOMBRE Departamento.
    ''' </summary>
    ''' <param name="NOMBRE_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDEPARTAMENTOPorNOMBRE(ByVal NOMBRE_DEPARTAMENTO As String) As DEPARTAMENTO
        Try
            Dim lEntidad As New DEPARTAMENTO
            lEntidad = mDb.ObtenerDEPARTAMENTOPorNOMBRE(NOMBRE_DEPARTAMENTO)
            Return lEntidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
