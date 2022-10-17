Partial Public Class cFUENTE_FINANCIAMIENTO


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una Entidad filtrada por municipio
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>    
    ''' <param name="CODIGO_MUNICIPIO"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFUENTE_FINANCIAMIENTO_PorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As FUENTE_FINANCIAMIENTO
        Try
            Dim lListaFaseMunicipio As listaFASE_MUNICIPIOS
            lListaFaseMunicipio = (New cFASE_MUNICIPIOS).ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
            If lListaFaseMunicipio IsNot Nothing AndAlso lListaFaseMunicipio.Count > 0 Then
                Return Me.ObtenerFUENTE_FINANCIAMIENTO(lListaFaseMunicipio(0).ID_FUENTE)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Integers de las Convocatorias en las que están activos
    ''' los participantes del programa PATI filtrada por Tipo de Solicitud.
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/10/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaConvocatoriasPorTipoSolicitud(ByVal ID_TIPO_SOLICITUD As Decimal) As List(Of Integer)
        Try
            Return mDb.ObtenerListaConvocatoriasPorTipoSolicitud(ID_TIPO_SOLICITUD)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por MUNICIPIO.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	11/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMunicipio(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaFUENTE_FINANCIAMIENTO
        Try
            Dim mListaFUENTE_FINANCIAMIENTO As New listaFUENTE_FINANCIAMIENTO
            mListaFUENTE_FINANCIAMIENTO = mDb.ObtenerListaPorMunicipio(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaFUENTE_FINANCIAMIENTO
            If Not mListaFUENTE_FINANCIAMIENTO Is Nothing Then
                For Each lEntidad As FUENTE_FINANCIAMIENTO In mListaFUENTE_FINANCIAMIENTO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFUENTE_FINANCIAMIENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Integers de las Convocatorias en las que están activos
    ''' los participantes del programa PATI filtrada por Tipo de Programa.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/10/2011	Created
    ''' 	[cramos]	25/10/2012	Modificado: Se cambia la firma del método de TipoSolicitud a Programa Formación
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaConvocatoriasPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Decimal) As List(Of Integer)
        Try
            Return mDb.ObtenerListaConvocatoriasPorProgramaFormacion(ID_PROGRAMA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por TecnicoMunicipio.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTecnico(ByVal USUARIO_TECNICO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaFUENTE_FINANCIAMIENTO
        Try
            Dim mListaFUENTE_FINANCIAMIENTO As New listaFUENTE_FINANCIAMIENTO
            mListaFUENTE_FINANCIAMIENTO = mDb.ObtenerListaPorTecnico(USUARIO_TECNICO, asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaFUENTE_FINANCIAMIENTO
            If Not mListaFUENTE_FINANCIAMIENTO Is Nothing Then
                For Each lEntidad As FUENTE_FINANCIAMIENTO In mListaFUENTE_FINANCIAMIENTO
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFUENTE_FINANCIAMIENTO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
