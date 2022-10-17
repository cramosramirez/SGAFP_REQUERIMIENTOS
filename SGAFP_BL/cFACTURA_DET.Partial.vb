Partial Public Class cFACTURA_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' Fuente, Convocatoria, Departamento y Municipio .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorFACTURA_AF_ParaLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As listaFACTURA_DET
        Try
            Dim mListaFACTURA_DET As New listaFACTURA_DET
            mListaFACTURA_DET = mDb.ObtenerListaPorFACTURA_AF_ParaLiquidacion(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
            Return mListaFACTURA_DET
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve DataSet filtrado por los parámetros de
    ''' Fuente, Convocatoria, Departamento y Municipio .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	20/12/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorFACTURA_AF_ParaLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As DataSet
        Try
            Return mDb.ObtenerDataSetPorFACTURA_AF_ParaLiquidacion(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el Monto Total a Liquidarse para una Convocatoria de un Municipio PATI.
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMontoParaLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Decimal
        Dim mListaFACTURA_DETparaLiquidacion As listaFACTURA_DET = Me.ObtenerListaPorFACTURA_AF_ParaLiquidacion(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Dim lListaFaseMunicipio As listaFASE_MUNICIPIOS
        Dim lFuenteFto As New FUENTE_FINANCIAMIENTO
        Dim lMontoLiquidacion As Decimal = 0
        Dim lCostoxParticipante As Decimal = 0

        'Obtener Costo x Participante de la Fuente de Financiamiento
        lListaFaseMunicipio = (New cFASE_MUNICIPIOS).ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If lListaFaseMunicipio IsNot Nothing AndAlso lListaFaseMunicipio.Count > 0 Then
            lFuenteFto = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(lListaFaseMunicipio(0).ID_FUENTE)
            lCostoxParticipante = lFuenteFto.COSTO_X_PARTICIPANTE
        End If

        If mListaFACTURA_DETparaLiquidacion IsNot Nothing AndAlso mListaFACTURA_DETparaLiquidacion.Count > 0 Then
            For Each lDetalleFactura As FACTURA_DET In mListaFACTURA_DETparaLiquidacion
                Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lDetalleFactura.ID_INFORME_FINAL)
                If lInforme IsNot Nothing Then
                    Select Case lFuenteFto.ID_FUENTE
                        Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM
                            lMontoLiquidacion += (lInforme.PARTICIPANTES_FINALES * lCostoxParticipante)
                        Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
                            lMontoLiquidacion += (80 * lCostoxParticipante)
                    End Select
                End If
            Next
        End If
        Return lMontoLiquidacion
    End Function

End Class
