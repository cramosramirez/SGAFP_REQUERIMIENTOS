Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership

Public Class frmFacturaCursos

    Public ReadOnly Property Current() As FACTURA_AF
        Get
            Return ListaFACTURA_AFBindingSource.Current
        End Get
    End Property

    Private Sub Inicializar()
        Me.InicializarVariables()

        Me.AgregarOpcion("Buscar", "Buscar", My.Resources.view, True)
        Me.AgregarOpcion("Aprobar", "Aprobar Factura", My.Resources.aprobar, True)
        Me.AgregarOpcion("Anular", "Anular Factura", My.Resources.Anular, True)
    End Sub

    Private Sub InicializarVariables()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        Me.CbxPROGRAMA_FORMACION1.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
    End Sub

    Private Sub frmFacturaCursos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Buscar"
                RecuperarDatos()
            Case "Aprobar"
                AprobarFactura()
            Case "Anular"
                AnularFactura()
        End Select
    End Sub

    Private Sub AnularFactura()
        Dim lEntidad As FACTURA_AF = Me.Current
        Dim bFacturaAF As New cFACTURA_AF
        If lEntidad IsNot Nothing Then
            If lEntidad.ESTADO <> Enumeradores.EstadoFactura.Anulada AndAlso _
                lEntidad.NUMERO_QUEDAN = -1 Then

                If Preguntar("¿Está seguro de Anular el Documento con N° " + lEntidad.NUMERO_DOCUMENTO.ToString.Trim + "?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim lMotivoAnulacion As String = ""
                    If IngresarMotivo("Motivo de la Anulación", "Escriba el motivo de la anulación", lMotivoAnulacion) = Windows.Forms.DialogResult.OK Then
                        lEntidad.ESTADO = Enumeradores.EstadoFactura.Anulada
                        lEntidad.OBSERVACION = lMotivoAnulacion.Trim
                        lEntidad.USERID = Utilerias.ObtenerUsuario
                        lEntidad.LASTUPDATE = Now
                        If bFacturaAF.ActualizarFACTURA_AF(lEntidad) <> 1 Then
                            AsignarMensaje("Error al Anular factura", True)
                            Return
                        End If
                        For Each lFactura As FACTURA_AF In ListaFACTURA_AFBindingSource.DataSource
                            If lFactura.ID_FACTURA_AF = lEntidad.ID_FACTURA_AF Then
                                lFactura.ESTADO = Enumeradores.EstadoFactura.Anulada
                                lFactura.OBSERVACION = lMotivoAnulacion
                                ListaFACTURA_AFBindingSource.EndEdit()
                            End If
                        Next
                        AsignarMensaje("La Factura se Anulo con exito!")
                    End If
                End If
            Else
                AsignarMensaje("La Factura debe estar Emitida o Aprobada y no debe poseer Quedan", True)
            End If
        Else
            AsignarMensaje("Seleccione una Factura", True)
        End If
    End Sub

    Private Sub AprobarFactura()
        Dim lEntidad As FACTURA_AF = Me.Current
        Dim bFacturaAF As New cFACTURA_AF
        If lEntidad IsNot Nothing Then
            If lEntidad.ESTADO = Enumeradores.EstadoFactura.Emitida Then
                If Preguntar("¿Está seguro de Aprobar el Documento con N° " + lEntidad.NUMERO_DOCUMENTO.ToString.Trim + "?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim lFactDetalle As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(lEntidad.ID_FACTURA_AF)

                    If lFactDetalle IsNot Nothing AndAlso lFactDetalle.Count > 0 Then
                        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lFactDetalle(0).ID_INFORME_FINAL)
                        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)

                        If lAccionDetalle IsNot Nothing Then
                            If lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE  Then
                                'Mostrar compromiso presupuestario si la factura proviene de un contrato
                                Dim fEjecucionPresSugerida As New frmFacturaCursos_EjecucionPresup
                                fEjecucionPresSugerida.CargarDatos(lEntidad.ID_FACTURA_AF)
                                If fEjecucionPresSugerida.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                    lEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada
                                    lEntidad.OBSERVACION = ""
                                    lEntidad.USERID = Utilerias.ObtenerUsuario
                                    lEntidad.LASTUPDATE = Now
                                    If bFacturaAF.ActualizarFACTURA_AF(lEntidad) <> 1 Then
                                        AsignarMensaje("Error al Aprobar factura", True)
                                        Return
                                    End If
                                    For Each lFactura As FACTURA_AF In ListaFACTURA_AFBindingSource.DataSource
                                        If lFactura.ID_FACTURA_AF = lEntidad.ID_FACTURA_AF Then
                                            lFactura.ESTADO = Enumeradores.EstadoFactura.Aprobada
                                            ListaFACTURA_AFBindingSource.EndEdit()
                                        End If
                                    Next
                                    AsignarMensaje("La Factura se Aprobo con exito!")
                                End If
                            Else
                                lEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada
                                lEntidad.OBSERVACION = ""
                                lEntidad.USERID = Utilerias.ObtenerUsuario
                                lEntidad.LASTUPDATE = Now
                                If bFacturaAF.ActualizarFACTURA_AF(lEntidad) <> 1 Then
                                    AsignarMensaje("Error al Aprobar factura", True)
                                    Return
                                End If
                                For Each lFactura As FACTURA_AF In ListaFACTURA_AFBindingSource.DataSource
                                    If lFactura.ID_FACTURA_AF = lEntidad.ID_FACTURA_AF Then
                                        lFactura.ESTADO = Enumeradores.EstadoFactura.Aprobada
                                        ListaFACTURA_AFBindingSource.EndEdit()
                                    End If
                                Next
                                AsignarMensaje("La Factura se Aprobo con exito!")
                            End If
                        End If
                    End If
                    
                End If
            Else
                AsignarMensaje("La Factura debe estar Emitida", True)
            End If
        Else
            AsignarMensaje("Seleccione una Factura", True)
        End If
    End Sub

    Private Sub RecuperarDatos()
        Dim listaFacturas As New listaFACTURA_AF
        Dim listaDetalleFactura As New listaFACTURA_DET
        Dim bFacturaAF As New cFACTURA_AF
        Dim bFacturaDet As New cFACTURA_DET
        Dim idProgramaFormacion As Decimal = -1
        Dim idProveedor As Decimal = -1
        Dim dFechaEmision As Object = Nothing

        If CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then idProgramaFormacion = CbxPROGRAMA_FORMACION1.SelectedValue
        If CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then idProveedor = CbxPROVEEDOR_AF1.SelectedValue
        If Me.dteFECHA_EMISION.DateTime <> #12:00:00 AM# Then
            dFechaEmision = Me.dteFECHA_EMISION.DateTime
        End If


        'Obtener Factura(s)
        listaFacturas = bFacturaAF.ObtenerListaPorCriterios(idProgramaFormacion, idProveedor, Me.txtNUMERO_DOCUMENTO.Text, dFechaEmision)

        If listaFacturas IsNot Nothing AndAlso listaFacturas.Count > 0 Then
            For i As Integer = 0 To listaFacturas.Count - 1
                'Obtener Detalle de la Factura 
                listaDetalleFactura = bFacturaDet.ObtenerListaPorFACTURA_AF(listaFacturas(i).ID_FACTURA_AF)
                If listaDetalleFactura IsNot Nothing AndAlso listaDetalleFactura.Count > 0 Then
                    'Obtener acciones formativas
                    listaFacturas(i).FACTURA_AF_INFORME_FINAL_AF = New listaINFORME_FINAL_AF
                    For j As Integer = 0 To listaDetalleFactura.Count - 1
                        Dim lInforme As INFORME_FINAL_AF
                        lInforme = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(listaDetalleFactura(j).ID_INFORME_FINAL)
                        listaFacturas(i).FACTURA_AF_INFORME_FINAL_AF.Add(lInforme)
                    Next
                End If
            Next
        End If

        Me.ListaFACTURA_AFBindingSource.DataSource = listaFacturas
    End Sub

    Private Sub GridViewFactura_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewFactura.CustomUnboundColumnData
        If e.IsGetData Then
            If e.Column.Name = "colReferencia" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)
                Dim listaTdr As listaTERMINO_REFERENCIA_AF
                Dim listaFacturaDet As listaFACTURA_DET

                listaFacturaDet = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(lEntidad.ID_FACTURA_AF)
                If listaFacturaDet IsNot Nothing AndAlso listaFacturaDet.Count > 0 Then
                    Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(listaFacturaDet(0).ID_INFORME_FINAL)
                    listaTdr = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                    If listaTdr IsNot Nothing AndAlso listaTdr.Count > 0 Then
                        e.Value = listaTdr(0).RESOLUCION
                    Else
                        Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
                        Dim lContrato As CONTRATO_PROVEEDOR_AF = (New cCONTRATO_PROVEEDOR_AF).ObtenerCONTRATO_PROVEEDOR_AF(lAccionFormativaDeta.ID_CONTRATO)
                        If lContrato IsNot Nothing Then e.Value = lContrato.NUM_CONTRATO
                    End If
                End If
            ElseIf e.Column.Name = "colNombreProveedor" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)
                Dim listaFacturaDet As listaFACTURA_DET
                Dim lAccionFormativa As ACCION_FORMATIVA

                listaFacturaDet = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(lEntidad.ID_FACTURA_AF)
                If listaFacturaDet IsNot Nothing AndAlso listaFacturaDet.Count > 0 Then
                    Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(listaFacturaDet(0).ID_INFORME_FINAL)
                    lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                    e.Value = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR
                End If
            ElseIf e.Column.Name = "colNombreTipoDocumento" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)

                If lEntidad.TIPO_DOCUMENTO = 1 Then
                    e.Value = "FACTURA"
                Else
                    e.Value = "RECIBO"
                End If
            ElseIf e.Column.Name = "colNUMERO_QUEDAN" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)
                If lEntidad.NUMERO_QUEDAN > -1 Then
                    e.Value = lEntidad.NUMERO_QUEDAN.ToString
                Else
                    e.Value = ""
                End If
            ElseIf e.Column.Name = "colNombreEstado" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)

                If lEntidad.ESTADO = Enumeradores.EstadoFactura.Emitida Then
                    e.Value = "EMITIDA"
                ElseIf lEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada Then
                    e.Value = "APROBADA"
                ElseIf lEntidad.ESTADO = Enumeradores.EstadoFactura.Anulada Then
                    e.Value = "ANULADA"
                End If
            ElseIf e.Column.Name = "colMonto" Then
                Dim lEntidad As FACTURA_AF = CType(e.Row, FACTURA_AF)
                Dim listaFacturaDet As listaFACTURA_DET
                Dim lMonto As Decimal = 0

                listaFacturaDet = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(lEntidad.ID_FACTURA_AF)
                If listaFacturaDet IsNot Nothing AndAlso listaFacturaDet.Count > 0 Then
                    For i As Integer = 0 To listaFacturaDet.Count - 1
                        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(listaFacturaDet(0).ID_INFORME_FINAL)
                        If lInforme IsNot Nothing Then
                            lMonto += lInforme.MONTO_FACTURA
                        End If
                    Next
                End If
                e.Value = lMonto
            End If
        End If
    End Sub

    Private Sub GridViewInformeFinal_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewInformeFinal.CustomUnboundColumnData
        Dim lEntidad As ACCION_FORMATIVA
        lEntidad = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(CType(e.Row, INFORME_FINAL_AF).ID_ACCION_FORMATIVA, False, True)
        If e.IsGetData Then
            If lEntidad IsNot Nothing Then
                If e.Column.FieldName = "colCurso" Then
                    e.Value = lEntidad.NOMBRE_ACCION_FORMATIVA
                ElseIf e.Column.FieldName = "colCodigoGrupo" Then
                    e.Value = lEntidad.CODIGO_GRUPO
                ElseIf e.Column.FieldName = "colDuracion" Then
                    e.Value = lEntidad.DURACION_HORAS
                End If
            End If
        End If
    End Sub
End Class