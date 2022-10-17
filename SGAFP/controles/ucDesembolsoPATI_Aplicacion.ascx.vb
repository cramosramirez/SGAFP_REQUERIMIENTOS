Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters

Partial Class controles_ucDesembolsoPATI_Aplicacion
    Inherits ucBase

    Dim mEntidad As DESEMBOLSO
    Dim mIdDesembolso As Decimal


    Public ReadOnly Property EsDesembolsoAplicado() As Boolean
        Get
            If Session("EsDesembolsoAplicado") IsNot Nothing Then
                Return Convert.ToBoolean(Session("EsDesembolsoAplicado"))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub Nuevo()
        lblNOMBRE_FUENTE.Text = String.Empty
        lblNO_CONVOCATORIA.Text = String.Empty
        lblNUM_DESEMBOLSO.Text = String.Empty
        lblFECHA_DESEMBOLSO.Text = String.Empty
        lblMONTO_AUTORIZADO.Text = (0).ToString("#,##0.00")
        lblMONTO_APLICADO.Text = (0).ToString("#,##0.00")
        lblMONTO_DIFERENCIA.Text = (0).ToString("#,##0.00")
        dxgvAplicacion.DataBind()
    End Sub

    Private Sub CargarMunicipios(ByVal ID_FUENTE As Decimal)
        Me.odsMunicipio.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE
        Me.odsMunicipio.DataBind()
        Me.lsbMunicipio.DataBind()
    End Sub

    Public Function Actualizar() As String
        Dim dtAplicacion As AplicacionDesembolsoPATIDataTable = CType(Session("dtListaAplicacionDesembolso"), AplicacionDesembolsoPATIDataTable)
        For Each dr As AplicacionDesembolsoPATIRow In dtAplicacion
            Dim lEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
            Dim bDesembolsoLiquidacionDet As New cDESEMBOLSO_MUNI_LIQUI_DET
            Dim listaDesembolsoLiqui As listaDESEMBOLSO_MUNI_LIQUI_DET = bDesembolsoLiquidacionDet.ObtenerListaPorDESEMBOLSO_LIQUIDACION_DET(DESEMBOLSO.ID_DESEMBOLSO, dr.ID_LIQUIDACION_DET)
            If listaDesembolsoLiqui IsNot Nothing AndAlso listaDesembolsoLiqui.Count > 0 Then
                If dr.ESTE_DESEMBOLSO = 0 Then
                    If bDesembolsoLiquidacionDet.EliminarDESEMBOLSO_MUNI_LIQUI_DET(listaDesembolsoLiqui(0).ID_DESEMBOLSO_MUNI) <> 1 Then
                        Me.AsignarMensaje("Error al Eliminar registro. " & vbCrLf & bDesembolsoLiquidacionDet.sError, True, True)
                        Return "Error al Eliminar registro."
                    End If
                Else
                    lEntidad = listaDesembolsoLiqui(0)
                    lEntidad.MONTO_DESEMBOLSO = dr.ESTE_DESEMBOLSO
                    lEntidad.USERID = Me.ObtenerUsuario
                    lEntidad.LASTUPDATE = Now
                    If bDesembolsoLiquidacionDet.ActualizarDESEMBOLSO_MUNI_LIQUI_DET(lEntidad) <> 1 Then
                        Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & bDesembolsoLiquidacionDet.sError, True, True)
                        Return "Error al Guardar registro."
                    End If
                End If

            Else
                lEntidad.ID_DESEMBOLSO_MUNI = 0
                lEntidad.ID_DESEMBOLSO = Me.DESEMBOLSO.ID_DESEMBOLSO
                lEntidad.ID_LIQUIDACION_DET = dr.ID_LIQUIDACION_DET
                lEntidad.MONTO_DESEMBOLSO = dr.ESTE_DESEMBOLSO
                lEntidad.USERID = Me.ObtenerUsuario
                lEntidad.LASTUPDATE = Now
                If bDesembolsoLiquidacionDet.ActualizarDESEMBOLSO_MUNI_LIQUI_DET(lEntidad) <> 1 Then
                    Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & bDesembolsoLiquidacionDet.sError, True, True)
                    Return "Error al Guardar registro."
                End If
            End If
        Next
        Return String.Empty
    End Function

    Public Property ID_DESEMBOLSO() As Decimal
        Get
            Return mIdDesembolso
        End Get
        Set(ByVal value As Decimal)
            mIdDesembolso = value
            mEntidad = (New cDESEMBOLSO).ObtenerDESEMBOLSO(mIdDesembolso)
            Session.Remove("Desembolso")
            Session.Remove("EsDesembolsoAplicado")
            Me.Nuevo()
            If mEntidad IsNot Nothing Then
                Session.Add("Desembolso", mEntidad)
                Me.lblNOMBRE_FUENTE.Text = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(mEntidad.ID_FUENTE).NOMBRE_FUENTE
                Me.lblNO_CONVOCATORIA.Text = mEntidad.NO_CONVOCATORIA.ToString
                Me.lblNUM_DESEMBOLSO.Text = mEntidad.NUM_DESEMBOLSO.ToString
                Me.lblFECHA_DESEMBOLSO.Text = mEntidad.FECHA_DESEMBOLSO.ToString("dd/MM/yyy")
                Me.lblMONTO_AUTORIZADO.Text = mEntidad.MONTO_AUTORIZADO.ToString("#,##0.00")
                Me.lblMONTO_APLICADO.Text = (0).ToString("#,##0.00")
                Me.lblMONTO_DIFERENCIA.Text = (0).ToString("#,##0.00")

                'Verificar si este desembolso se ha aplicado a alguna liquidación
                Dim listaDesembolsoMuni As listaDESEMBOLSO_MUNI_LIQUI_DET
                listaDesembolsoMuni = (New cDESEMBOLSO_MUNI_LIQUI_DET).ObtenerListaPorDESEMBOLSO(mIdDesembolso)
                If listaDesembolsoMuni IsNot Nothing AndAlso listaDesembolsoMuni.Count > 0 Then
                    Session.Add("EsDesembolsoAplicado", True)
                Else
                    Session.Add("EsDesembolsoAplicado", False)
                End If
            End If
        End Set
    End Property

    Public ReadOnly Property DESEMBOLSO() As DESEMBOLSO
        Get
            If Session("Desembolso") IsNot Nothing Then
                Return TryCast(Session("Desembolso"), DESEMBOLSO)
            Else
                Return Nothing
            End If
        End Get
    End Property

#Region " Lógica implementada "
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de Aplicación de Desembolsos a las Solicitudes de Liquidación
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorIdDesembolso(ByVal ID_DESEMBOLSO As Decimal) As Integer
        Dim adapter As New AplicacionDesembolsoPATITableAdapter
        Session("dtListaAplicacionDesembolso") = adapter.GetDataByIdDesembolso(ID_DESEMBOLSO)
        ActualizarCargarDatos()
        Return 1
    End Function

    Public Sub ActualizarCargarDatos()
        If Session("dtListaAplicacionDesembolso") IsNot Nothing Then
            Dim totalAplicado As Decimal = TotalAplicadoDesembolso(Session("dtListaAplicacionDesembolso"))
            Me.lblMONTO_APLICADO.Text = totalAplicado.ToString("#,##0.00")
            Me.lblMONTO_DIFERENCIA.Text = (Me.DESEMBOLSO.MONTO_AUTORIZADO - totalAplicado).ToString("#,##0.00")

            Me.dxgvAplicacion.DataSource = Session("dtListaAplicacionDesembolso")
            Me.dxgvAplicacion.Selection.UnselectAll()
            Me.dxgvAplicacion.Visible = True
            Me.dxgvAplicacion.DataBind()
        End If
    End Sub

    Protected Sub chkAPLICA_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim chk As ASPxCheckBox = TryCast(sender, ASPxCheckBox)
        Dim container As GridViewDataItemTemplateContainer = TryCast(chk.NamingContainer, GridViewDataItemTemplateContainer)

        chk.ClientInstanceName = "chk" + container.KeyValue.ToString
        chk.ClientSideEvents.ValueChanged = String.Format("function (s, e) {{ cpDesembolsoPATI_Aplicacion.PerformCallback(""{0};{1};{2};"" + {3}); }}", "CambiarAplicacion", container.KeyValue, _
            container.Column.FieldName, "s.GetValue()")
    End Sub

    Protected Sub txtESTE_DESEMBOLSO_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim txt As ASPxTextBox = TryCast(sender, ASPxTextBox)
        Dim container As GridViewDataItemTemplateContainer = TryCast(txt.NamingContainer, GridViewDataItemTemplateContainer)

        txt.ClientInstanceName = "txt" + container.KeyValue.ToString
        txt.ClientSideEvents.ValueChanged = String.Format("function (s, e) {{ cpDesembolsoPATI_Aplicacion.PerformCallback(""{0};{1};{2};"" + {3}); }}", "CambiarAplicacion", container.KeyValue, _
            container.Column.FieldName, "s.GetValue()")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActualizarCargarDatos()
    End Sub

    Private Function TotalAplicadoDesembolso(ByRef dt As AplicacionDesembolsoPATIDataTable) As Decimal
        Dim sumObject As Object
        Dim total As Decimal

        sumObject = dt.Compute("SUM(ESTE_DESEMBOLSO)", "ID_LIQUIDACION_DET>0")
        If Not IsDBNull(sumObject) Then
            total = CDec(sumObject)
            Return total
        Else
            Return 0
        End If
    End Function

    Protected Sub cpDesembolsoPATI_Aplicacion_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cpDesembolsoPATI_Aplicacion.Callback
        cpDesembolsoPATI_Aplicacion.JSProperties.Clear()
        cpDesembolsoPATI_Aplicacion.JSProperties.Add("cpResultCallback", "")
        Dim p() As String = e.Parameter.Split(";")

        Select Case p(0)
            Case "CambiarAplicacion"
                Dim idLiquidacionDet As Decimal = Convert.ToDecimal(p(1))
                Dim columna As String = p(2)
                Dim valor As Object = p(3)

                If Session("dtListaAplicacionDesembolso") IsNot Nothing Then
                    Dim dtAplicacion As AplicacionDesembolsoPATIDataTable = CType(Session("dtListaAplicacionDesembolso"), AplicacionDesembolsoPATIDataTable)
                    Dim dr As AplicacionDesembolsoPATIRow = dtAplicacion.FindByID_LIQUIDACION_DET(idLiquidacionDet)
                    Dim totalAplicado As Decimal = 0

                    If columna = "ESTE_DESEMBOLSO" Then
                        If valor.ToString() = "null" Then valor = 0

                        If dr IsNot Nothing Then
                            If CDec(valor) < (dr.SOLICITADO - dr.DESEMBOLSO_ANTERIOR) Then
                                dr.ESTE_DESEMBOLSO = CDec(valor)
                            Else
                                dr.ESTE_DESEMBOLSO = 0
                            End If
                            dtAplicacion.AcceptChanges()
                        End If

                    ElseIf columna = "APLICA" Then
                        If dr IsNot Nothing Then
                            If CBool(valor) Then
                                dr.ESTE_DESEMBOLSO = dr.SOLICITADO - dr.DESEMBOLSO_ANTERIOR
                            Else
                                dr.ESTE_DESEMBOLSO = 0
                            End If
                            dtAplicacion.AcceptChanges()
                        End If
                    End If
                    totalAplicado = TotalAplicadoDesembolso(dtAplicacion)
                    Me.lblMONTO_APLICADO.Text = totalAplicado.ToString("#,##0.00")
                    Me.lblMONTO_DIFERENCIA.Text = (Me.DESEMBOLSO.MONTO_AUTORIZADO - totalAplicado).ToString("#,##0.00")
                    cpDesembolsoPATI_Aplicacion.JSProperties("cpResultCallback") = "ActualizarGrid"
                End If

            Case "MostrarPopup"
                CargarMunicipios(DESEMBOLSO.ID_FUENTE)
                dteFECHA_LIQUIDACION_INICIAL.Value = #12:00:00 AM#
                dteFECHA_LIQUIDACION_FINAL.Value = #12:00:00 AM#
                cpDesembolsoPATI_Aplicacion.JSProperties("cpResultCallback") = "MostrarPopup"

            Case "ProcesarLiquidaciones"
                Dim bOcurrioAdicion As Boolean = False
                Dim adapter As New AplicacionDesembolsoPATITableAdapter
                Dim dtNuevaLiquidacion As AplicacionDesembolsoPATIDataTable
                Dim dtActual As New AplicacionDesembolsoPATIDataTable
                Dim lMunicipios As New listaMUNICIPIO
                For i As Integer = 1 To p.Length - 1
                    If p(i) <> String.Empty Then
                        Dim pMunicipio() As String = p(i).Split("|")
                        Dim lEntidadMunicipio As MUNICIPIO
                        lEntidadMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIOPorNOMBRE(pMunicipio(1), pMunicipio(0))
                        If lEntidadMunicipio IsNot Nothing Then lMunicipios.Add(lEntidadMunicipio)
                    End If
                Next
                dtNuevaLiquidacion = (New cDESEMBOLSO).ObtenerDataTableCursosPendientesDesembolso(DESEMBOLSO.ID_FUENTE, _
                                                                            DESEMBOLSO.NO_CONVOCATORIA, _
                                                                            DESEMBOLSO.NUM_DESEMBOLSO, _
                                                                            dteFECHA_LIQUIDACION_INICIAL.Date, _
                                                                            dteFECHA_LIQUIDACION_FINAL.Date, lMunicipios)
                If dtNuevaLiquidacion.Rows.Count = 0 Then
                    cpDesembolsoPATI_Aplicacion.JSProperties("cpResultCallback") = "No se encontraron cursos pendientes de desembolso con los criterios ingresados"
                    Return
                End If
                If Session("dtListaAplicacionDesembolso") IsNot Nothing Then dtActual = CType(Session("dtListaAplicacionDesembolso"), AplicacionDesembolsoPATIDataTable)
                For Each dr As AplicacionDesembolsoPATIRow In dtNuevaLiquidacion
                    If dtActual.FindByID_LIQUIDACION_DET(dr.ID_LIQUIDACION_DET) Is Nothing Then
                        Dim drRegistro As AplicacionDesembolsoPATIRow
                        drRegistro = dtActual.NewAplicacionDesembolsoPATIRow
                        With drRegistro
                            .ID_ACCION_FORMATIVA = dr.ID_ACCION_FORMATIVA
                            .ID_LIQUIDACION_DET = dr.ID_LIQUIDACION_DET
                            .ID_FUENTE = dr.ID_FUENTE
                            .NO_CONVOCATORIA = dr.NO_CONVOCATORIA
                            .NOMBRE_MUNICIPIO = dr.NOMBRE_MUNICIPIO
                            .NO_LIQUIDACION = dr.NO_LIQUIDACION
                            .FECHA_ELABORACION = dr.FECHA_ELABORACION
                            .NOMBRE_ACCION_FORMATIVA = dr.NOMBRE_ACCION_FORMATIVA
                            .NOMBRE_PROVEEDOR = dr.NOMBRE_PROVEEDOR
                            .NUMERO_DOCUMENTO = dr.NUMERO_DOCUMENTO
                            .SOLICITADO = dr.SOLICITADO
                            .DESEMBOLSO_ANTERIOR = dr.DESEMBOLSO_ANTERIOR
                            .ESTE_DESEMBOLSO = dr.SOLICITADO - dr.DESEMBOLSO_ANTERIOR
                        End With

                        dtActual.AddAplicacionDesembolsoPATIRow(drRegistro)
                        bOcurrioAdicion = True
                    End If
                Next
                If Not bOcurrioAdicion Then
                    cpDesembolsoPATI_Aplicacion.JSProperties("cpResultCallback") = "No se agregó ninguna liquidación"
                    Return
                End If
                Me.ActualizarCargarDatos()
                cpDesembolsoPATI_Aplicacion.JSProperties("cpResultCallback") = "Liquidacion agregada con exito!"
        End Select
    End Sub
#End Region

    Protected Sub dxgvAplicacion_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs) Handles dxgvAplicacion.HtmlDataCellPrepared
        If e.DataColumn.FieldName = "APLICA" Then
            Dim chkAplica As ASPxCheckBox = dxgvAplicacion.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "chkAPLICA")

            If Convert.ToDecimal(dxgvAplicacion.GetRowValues(e.VisibleIndex, "ESTE_DESEMBOLSO")) > 0 Then
                chkAplica.Checked = True
            Else
                chkAplica.Checked = False
            End If
        End If
    End Sub
End Class
