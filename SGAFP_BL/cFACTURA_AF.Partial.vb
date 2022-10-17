Partial Public Class cFACTURA_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por parámetros la Tabla FACTURA_AF.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="NIT"></param>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <param name="FECHA_DOCUMENTO"></param>
    ''' <param name="RESOLUCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NIT As String, ByVal NUMERO_DOCUMENTO As String,
                                               ByVal FECHA_DOCUMENTO As Object, ByVal RESOLUCION As String, ByVal CODIGO_GRUPO As String, _
                                               ByVal ID_INFORME_FINAL As Decimal) As DataSet
        Try
            Return mDb.ObtenerDataSetPorCriterios(ID_PROGRAMA_FORMACION, ID_PROVEEDOR_AF, NIT, NUMERO_DOCUMENTO, FECHA_DOCUMENTO, RESOLUCION, CODIGO_GRUPO, ID_INFORME_FINAL)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	25/08/2011	Created
    ''' 	[cramos]	06/09/2012	Modificado, se implementa facturación por Informe de Ejecución
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACTURA_AF(ByVal aEntidad As FACTURA_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As Integer
            Dim lEntidad As FACTURA_AF = Me.ObtenerFACTURA_AF(aEntidad.ID_FACTURA_AF)

            If lEntidad IsNot Nothing Then
                Select Case True
                    Case lEntidad.ESTADO = Enumeradores.EstadoFactura.Emitida AndAlso aEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada
                        'Crear registro en SIFP
                        Dim bFacturaSifp As New SIFP.BL.cFACTURA_AF
                        Dim lDetalleFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                        Dim lValorDocumento As Decimal = 0
                        Dim lCentroResponsabilidad As String = ""
                        Dim lCodigoConvenio As String = ""
                        If lDetalleFactura IsNot Nothing AndAlso lDetalleFactura.Count > 0 Then
                            For Each _Deta As FACTURA_DET In lDetalleFactura
                                Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(_Deta.ID_INFORME_FINAL)
                                Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
                                lValorDocumento += lInforme.MONTO_FACTURA
                                Select Case lAccionDetalle.ID_PROGRAMA_FORMACION
                                    Case Enumeradores.ProgramasFormacion.PATI_2
                                        lCentroResponsabilidad = "319"
                                        lCodigoConvenio = "PATI-FASE II-PACSES-FISDL/INSAFORP"
                                    Case Enumeradores.ProgramasFormacion.PATI_USAID
                                        lCentroResponsabilidad = "316"
                                        Dim lFuenteMunicipio As FUENTE_MUNICIPIO = _
                                            (New cFUENTE_MUNICIPIO).ObtenerPorFUENTE_FINANCIAMIENTO_CONV_DEPARTAMENTO(lAccionDetalle.ID_FUENTE, lAccionDetalle.NO_CONVOCATORIA, lAccionDetalle.CODIGO_DEPARTAMENTO, lAccionDetalle.CODIGO_MUNICIPIO)
                                        If lFuenteMunicipio IsNot Nothing AndAlso lFuenteMunicipio.CODIGO_FINANCIAMIENTO <> "" Then
                                            lCodigoConvenio = lFuenteMunicipio.CODIGO_FINANCIAMIENTO
                                        Else
                                            lCodigoConvenio = "FISDL/PATI-USAID/INSAFORP 0462"
                                        End If
                                    Case Enumeradores.ProgramasFormacion.PATI_BM
                                        lCentroResponsabilidad = "317"
                                        lCodigoConvenio = "FISDL/PATI-BIRF/INSAFORP 7811"
                                    Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                                        lCentroResponsabilidad = "311"
                                        lCodigoConvenio = "HABIL TÉCNICO PERMANENTE"
                                    Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                                        Dim lTermino As listaTERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lAccionDetalle.ID_ACCION_FORMATIVA)
                                        If lTermino IsNot Nothing AndAlso lTermino.Count > 0 Then
                                            Dim lSolicitudCap As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(lTermino(0).ID_SOLICITUD)
                                            If lSolicitudCap IsNot Nothing Then
                                                lCentroResponsabilidad = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(lSolicitudCap.ID_CENTRO_RESPONSABILIDAD).CODIGO_CENTRO_RESPONSABILIDAD.Trim
                                                lCodigoConvenio = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lSolicitudCap.ID_PROGRAMA_FORMACION).NOMBRE_PROGRAMA_FORMACION
                                            End If
                                        End If
                                End Select
                            Next
                        End If

                        'Actualizar entidad
                        lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

                        If lRet >= 1 Then
                            'Actualizar Acciones Formativas
                            Dim lListaFacturas As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                            If lListaFacturas IsNot Nothing AndAlso lListaFacturas.Count > 0 Then
                                For Each _Item As FACTURA_DET In lListaFacturas
                                    Dim lInforme As INFORME_FINAL_AF
                                    Dim bInforme As New cINFORME_FINAL_AF
                                    lInforme = bInforme.ObtenerINFORME_FINAL_AF(_Item.ID_INFORME_FINAL)
                                    lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.EnTramiteDePago
                                    lInforme.USERID = Utilerias.ObtenerUsuario
                                    lInforme.LASTUPDATE = Now
                                    If bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, True) <= 0 Then
                                        aEntidad.ESTADO = Enumeradores.EstadoFactura.Emitida
                                        mDb.Actualizar(aEntidad, aTipoConcurrencia)
                                        bFacturaSifp.EliminarFACTURA_AF(aEntidad.ID_FACTURA_AF)
                                        Return -3
                                    End If
                                Next
                            End If

                            SIFP.EL.configuracion.usuarioActualiza = Utilerias.ObtenerUsuario
                            If bFacturaSifp.AgregarFACTURA_AF(lEntidad.ID_FACTURA_AF, (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lEntidad.ID_PROVEEDOR_AF).NIT, _
                                                             lEntidad.NUMERO_DOCUMENTO, lEntidad.TIPO_DOCUMENTO, lEntidad.FECHA_DOCUMENTO, _
                                                             lEntidad.NUMERO_QUEDAN, lEntidad.NUMERO_CHEQUE, Nothing, Enumeradores.EstadoFactura.Aprobada, _
                                                             lValorDocumento, lCentroResponsabilidad, lCodigoConvenio, Utilerias.ObtenerUsuario, Now) <> 1 Then
                                'Return -2
                            End If

                        Else
                            bFacturaSifp.EliminarFACTURA_AF(aEntidad.ID_FACTURA_AF)
                        End If

                    Case aEntidad.ESTADO = Enumeradores.EstadoFactura.Anulada AndAlso lEntidad.ESTADO <> Enumeradores.EstadoFactura.Anulada
                        'Actualizar registro en SIFP
                        Dim lbFacturaSIFP As New SIFP.BL.cFACTURA_AF
                        Dim lFacturaSIFP As SIFP.EL.FACTURA_AF

                        lFacturaSIFP = lbFacturaSIFP.ObtenerFACTURA_AF(lEntidad.ID_FACTURA_AF)
                        If lFacturaSIFP IsNot Nothing AndAlso lEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada Then
                            lFacturaSIFP.ESTADO = Enumeradores.EstadoFactura.Anulada
                            lFacturaSIFP.USERID = Utilerias.ObtenerUsuario
                            lFacturaSIFP.LASTUPDATE = Now
                            If lbFacturaSIFP.ActualizarFACTURA_AF(lFacturaSIFP) <> 1 Then
                                Return -4
                            End If
                        End If

                        'Actualizar entidad
                        lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

                        If lRet = 1 Then
                            'Actualizar Acciones Formativas
                            Dim lListaFacturas As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                            If lListaFacturas IsNot Nothing AndAlso lListaFacturas.Count > 0 Then
                                For Each _Item As FACTURA_DET In lListaFacturas
                                    Dim lInforme As INFORME_FINAL_AF
                                    Dim bInforme As New cINFORME_FINAL_AF
                                    lInforme = bInforme.ObtenerINFORME_FINAL_AF(_Item.ID_INFORME_FINAL)
                                    lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor
                                    lInforme.USERID = Utilerias.ObtenerUsuario
                                    lInforme.LASTUPDATE = Now
                                    bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, True)
                                Next
                            End If
                        Else
                            'Revertir Anulacion en SIFP
                            lFacturaSIFP = lbFacturaSIFP.ObtenerFACTURA_AF(lEntidad.ID_FACTURA_AF)
                            lFacturaSIFP.ESTADO = Enumeradores.EstadoFactura.Aprobada
                            lFacturaSIFP.USERID = Utilerias.ObtenerUsuario
                            lFacturaSIFP.LASTUPDATE = Now
                            lbFacturaSIFP.ActualizarFACTURA_AF(lFacturaSIFP)
                        End If

                    Case (aEntidad.ESTADO = Enumeradores.EstadoFactura.Anulada AndAlso lEntidad.ESTADO <> Enumeradores.EstadoFactura.Anulada)
                        lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                        'Actualizar a Estado 'FacturaSolicitadaProveedor' las Acciones Formativas de la Factura
                        If lRet = 1 Then
                            Dim lDetalleFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                            Dim bInforme As New cINFORME_FINAL_AF
                            Dim lInforme As INFORME_FINAL_AF
                            For Each lDetalle As FACTURA_DET In lDetalleFactura
                                lInforme = bInforme.ObtenerINFORME_FINAL_AF(lDetalle.ID_INFORME_FINAL)
                                lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor
                                lInforme.USERID = Utilerias.ObtenerUsuario
                                lInforme.LASTUPDATE = Now
                                bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, True)
                            Next
                        End If

                    Case (lEntidad.NUMERO_CHEQUE = String.Empty AndAlso aEntidad.NUMERO_CHEQUE <> String.Empty)
                        lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                        'Actualizar a Estado 'Pagado' las Acciones Formativas de la Factura
                        If lRet = 1 Then
                            Dim lDetalleFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                            Dim bInforme As New cINFORME_FINAL_AF
                            Dim lInforme As INFORME_FINAL_AF
                            For Each lDetalle As FACTURA_DET In lDetalleFactura
                                lInforme = bInforme.ObtenerINFORME_FINAL_AF(lDetalle.ID_INFORME_FINAL)
                                lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Pagado
                                lInforme.USERID = Utilerias.ObtenerUsuario
                                lInforme.LASTUPDATE = Now
                                bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, True)
                            Next
                        End If

                    Case (lEntidad.NUMERO_CHEQUE <> String.Empty AndAlso aEntidad.NUMERO_CHEQUE = String.Empty)
                        lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                        'Actualizar a Estado 'EnTramiteDePagoUFI' las Acciones Formativas de la Factura
                        If lRet = 1 Then
                            Dim lDetalleFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aEntidad.ID_FACTURA_AF)
                            Dim bInforme As New cINFORME_FINAL_AF
                            Dim lInforme As INFORME_FINAL_AF
                            For Each lDetalle As FACTURA_DET In lDetalleFactura
                                lInforme = bInforme.ObtenerINFORME_FINAL_AF(lDetalle.ID_INFORME_FINAL)
                                lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.EnTramiteDePago
                                lInforme.USERID = Utilerias.ObtenerUsuario
                                lInforme.LASTUPDATE = Now
                                bInforme.ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, False)
                            Next
                        End If
                End Select
            Else
                'Actualizar entidad
                lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
            End If

            Return lRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una lista de Entidades filtrado por parámetros.
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <param name="FECHA_DOCUMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/04/2012	Created
    ''' 	[cramos]	11/09/2012	Modificado, Se reemplaza parámetro ID_TIPO_SOLICITUD por ID_PROGRAMA_FORMACION
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NUMERO_DOCUMENTO As String, ByVal FECHA_DOCUMENTO As Object) As listaFACTURA_AF
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROGRAMA_FORMACION, ID_PROVEEDOR_AF, NUMERO_DOCUMENTO, FECHA_DOCUMENTO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una lista de Diccionario con los valores de Monto Factura y Retencion por quedan
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMonto_IVARetenido(ByVal ID_FACTURA_AF As Decimal) As Dictionary(Of Decimal, Decimal)
        Try
            Dim sifpFactura_af As New SIFP.BL.cFACTURA_AF
            Return sifpFactura_af.ObtenerMonto_IVARetenido(ID_FACTURA_AF)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve la entidad Contrato a la que está asociada la Factura .
    ''' </summary>
    ''' <param name="ID_FACTURA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerContratoProveedor(ByVal ID_FACTURA_AF As Decimal) As CONTRATO_PROVEEDOR_AF
        Try

            Return mDb.ObtenerContratoProveedor(ID_FACTURA_AF)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
