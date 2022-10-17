Partial Public Class cMUNICIPIO_LIQUIDACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Genera una Liquidación para un Municipio en un Convocatoria.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function GenerarMunicipioLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal ListaIDsAccionesFormativas As List(Of Decimal)) As Integer
        Dim lFuenteFto As New FUENTE_FINANCIAMIENTO
        Dim lCostoxParticipante As Decimal = 0
        Dim lListaMunicipios As New listaMUNICIPIO

        'Obtener Costo x Participante de la Fuente de Financiamiento        
        lFuenteFto = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(ID_FUENTE)
        lCostoxParticipante = lFuenteFto.COSTO_X_PARTICIPANTE

        'Obtener Municipios en los que aplica liquidación en base a la Fuente, Convocatoria y lista de Acciones Formativas
        For Each IdAccionFormativa As Decimal In ListaIDsAccionesFormativas
            Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE
            lAccionFormativaDeta = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(IdAccionFormativa)
            If lListaMunicipios.BuscarPorId(lAccionFormativaDeta.CODIGO_DEPARTAMENTO, lAccionFormativaDeta.CODIGO_MUNICIPIO) Is Nothing Then
                lListaMunicipios.Add((New cMUNICIPIO).ObtenerMUNICIPIO(lAccionFormativaDeta.CODIGO_DEPARTAMENTO, lAccionFormativaDeta.CODIGO_MUNICIPIO))
            End If
        Next

        For Each eMunicipio As MUNICIPIO In lListaMunicipios
            Dim lbLiquidacionDetalle As New cMUNICIPIO_LIQUIDACION_DET
            Dim lEntidadLiquidacion As New MUNICIPIO_LIQUIDACION
            Dim lListaDetalleFacturas As New listaFACTURA_DET
            Dim lMontoLiquidacion As Decimal = 0

            'Obtener las Facturas correspondientes a los criterios: Fuente, Convocatoria, Municipio y Acciones Formativas
            Dim lListaFacturasCandidatas As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF_ParaLiquidacion(ID_FUENTE, NO_CONVOCATORIA, eMunicipio.CODIGO_DEPARTAMENTO, eMunicipio.CODIGO_MUNICIPIO)
            For Each lDetalleFactura As FACTURA_DET In lListaFacturasCandidatas
                Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lDetalleFactura.ID_INFORME_FINAL)
                If ListaIDsAccionesFormativas.Contains(lInforme.ID_ACCION_FORMATIVA) Then
                    lListaDetalleFacturas.Add(lDetalleFactura)
                End If
            Next

            If lListaDetalleFacturas IsNot Nothing AndAlso lListaDetalleFacturas.Count > 0 Then
                'Obtener Monto Total Liquidacion
                For Each lDetalleFactura As FACTURA_DET In lListaDetalleFacturas
                    Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lDetalleFactura.ID_INFORME_FINAL)
                    Dim lListaInformeFinal As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                    If lListaInformeFinal IsNot Nothing AndAlso lListaInformeFinal.Count > 0 Then
                        Select Case lFuenteFto.ID_FUENTE
                            Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM, Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
                                lMontoLiquidacion += (lListaInformeFinal(0).PARTICIPANTES_FINALES * lCostoxParticipante)
                            Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
                                lMontoLiquidacion += (80 * lCostoxParticipante)
                        End Select
                    End If
                Next

                'Generar Liquidacion
                With lEntidadLiquidacion
                    .ID_LIQUIDACION = 0
                    .ID_FUENTE = ID_FUENTE
                    .NO_CONVOCATORIA = NO_CONVOCATORIA
                    .CODIGO_DEPARTAMENTO = eMunicipio.CODIGO_DEPARTAMENTO
                    .CODIGO_MUNICIPIO = eMunicipio.CODIGO_MUNICIPIO
                    .NO_LIQUIDACION = ObtenerCorrelativoLiquidacion(ID_FUENTE, NO_CONVOCATORIA, eMunicipio.CODIGO_DEPARTAMENTO, eMunicipio.CODIGO_MUNICIPIO)
                    .FECHA_ELABORACION = Today
                    .MONTO_LIQUIDADO = lMontoLiquidacion
                    .ASESOR_MUNICIPAL = (New cMUNICIPIO_CONVOCATORIA).ObtenerMUNICIPIO_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA, eMunicipio.CODIGO_DEPARTAMENTO, eMunicipio.CODIGO_MUNICIPIO).ASESOR_MUNICIPAL
                    .USERID = Utilerias.ObtenerUsuario
                    .LASTUPDATE = Now
                End With
                If Me.ActualizarMUNICIPIO_LIQUIDACION(lEntidadLiquidacion) = 1 Then
                    'Generar Detalle de liquidación
                    For Each lDetalleFactura As FACTURA_DET In lListaDetalleFacturas
                        Dim lEntidadDetalleLiq As New MUNICIPIO_LIQUIDACION_DET
                        With lEntidadDetalleLiq
                            .ID_LIQUIDACION = lEntidadLiquidacion.ID_LIQUIDACION
                            Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lDetalleFactura.ID_INFORME_FINAL)
                            .ID_ACCION_FORMATIVA = lInforme.ID_ACCION_FORMATIVA
                            .COSTO_X_PARTICIPANTE = lCostoxParticipante
                            Dim lListaInformeFinal As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                            If lListaInformeFinal IsNot Nothing AndAlso lListaInformeFinal.Count > 0 Then
                                Select Case lFuenteFto.ID_FUENTE
                                    Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM, Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
                                        .TOTAL_PAGAR = lListaInformeFinal(0).PARTICIPANTES_FINALES * lCostoxParticipante
                                    Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
                                        .TOTAL_PAGAR = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA).DURACION_HORAS * lCostoxParticipante
                                End Select
                            End If
                            .USERID = Utilerias.ObtenerUsuario
                            .LASTUPDATE = Now
                        End With
                        If lbLiquidacionDetalle.ActualizarMUNICIPIO_LIQUIDACION_DET(lEntidadDetalleLiq) <> 1 Then
                            Return -2
                        End If
                    Next
                Else
                    Return -1
                End If
            Else
                Return 0
            End If

            'Actualizar Municipio Convocatoria
            Dim lbMunicipioConv As New cMUNICIPIO_CONVOCATORIA
            Dim lMunicipioConv As MUNICIPIO_CONVOCATORIA = lbMunicipioConv.ObtenerMUNICIPIO_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA, eMunicipio.CODIGO_DEPARTAMENTO, eMunicipio.CODIGO_MUNICIPIO)
            If lMunicipioConv IsNot Nothing Then
                lMunicipioConv.MONTO_LIQUIDADO += lMontoLiquidacion
                lMunicipioConv.USERID = Utilerias.ObtenerUsuario
                lMunicipioConv.LASTUPDATE = Now
                If lbMunicipioConv.ActualizarMUNICIPIO_CONVOCATORIA(lMunicipioConv) <> 1 Then
                    Return -4
                End If
            Else
                Return -3
            End If
        Next

        Return 1
    End Function

    Private Function ObtenerCorrelativoLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Decimal
        Dim lListaMunicipioLiquidacion As listaMUNICIPIO_LIQUIDACION
        Dim Criterios As New List(Of Criteria)

        Criterios.Add(New Criteria("ID_FUENTE", "=", ID_FUENTE, "AND"))
        Criterios.Add(New Criteria("NO_CONVOCATORIA", "=", NO_CONVOCATORIA, "AND"))
        Criterios.Add(New Criteria("CODIGO_DEPARTAMENTO", "=", CODIGO_DEPARTAMENTO, "AND"))
        Criterios.Add(New Criteria("CODIGO_MUNICIPIO", "=", CODIGO_MUNICIPIO, ""))

        lListaMunicipioLiquidacion = (New cMUNICIPIO_LIQUIDACION).ObtenerListaPorBusqueda(New MUNICIPIO_LIQUIDACION, Criterios.ToArray)
        If lListaMunicipioLiquidacion IsNot Nothing Then
            Return lListaMunicipioLiquidacion.Count + 1
        Else
            Return 1
        End If
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MUNICIPIO_LIQUIDACION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_LIQUIDACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMUNICIPIO_LIQUIDACION(ByVal ID_LIQUIDACION As Decimal) As Integer
        Try
            mEntidad.ID_LIQUIDACION = ID_LIQUIDACION
            Return Me.EliminarMUNICIPIO_LIQUIDACION(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla MUNICIPIO_LIQUIDACION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarMUNICIPIO_LIQUIDACION(ByVal aEntidad As MUNICIPIO_LIQUIDACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.ID_LIQUIDACION > 0 Then
                'Eliminar detalle de la liquidación
                Dim lbDetalleLiquidacion As New cMUNICIPIO_LIQUIDACION_DET
                Dim lDetalleLiquidacion As listaMUNICIPIO_LIQUIDACION_DET = lbDetalleLiquidacion.ObtenerListaPorMUNICIPIO_LIQUIDACION(aEntidad.ID_LIQUIDACION)
                If lDetalleLiquidacion IsNot Nothing Then
                    For Each _Detalle As MUNICIPIO_LIQUIDACION_DET In lDetalleLiquidacion
                        lbDetalleLiquidacion.EliminarMUNICIPIO_LIQUIDACION_DET(_Detalle.ID_LIQUIDACION_DET)
                    Next
                End If
            End If
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_LIQUIDACION
        Try
            Return mDb.ObtenerListaPorFUENTE_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
