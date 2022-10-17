Imports SGAFP.EL
Imports System.Text

Public Class ucMantACCION_CONTRATADA

    Private mListaACCION_CONTRATADA As listaACCION_CONTRATADA

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaACCION_CONTRATADA1.EsConsulta = value
            Me.UcDetalleACCION_CONTRATADA1.EsConsulta = value
        End Set
    End Property


    Private _IdContrato As Decimal
    Public Property ID_CONTRATO() As Decimal
        Get
            Return Me._IdContrato
        End Get
        Set(ByVal value As Decimal)
            Me._IdContrato = value
        End Set
    End Property

    'Public Overrides ReadOnly Property EnEdicion() As Boolean
    '    Get
    '        If Me.UcListaACCION_CONTRATADA1.Current Is Nothing Then Return False
    '        Return Me.UcListaACCION_CONTRATADA1.Current.IsDirty
    '    End Get
    'End Property

    'Private Sub CargarACCION_CONTRATADA()
    '    Me.UcListaACCION_CONTRATADA1.CargarDatos()
    '    If Me.UcListaACCION_CONTRATADA1.Current Is Nothing Then
    '        Me.UcDetalleACCION_CONTRATADA1.DataSource.DataSource = (New ACCION_CONTRATADA)
    '    Else
    '        Me.UcDetalleACCION_CONTRATADA1.DataSource.DataSource = Me.UcListaACCION_CONTRATADA1.Current
    '    End If
    'End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaACCION_CONTRATADA1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    'Public Overrides Function Guardar() As Integer
    '    Me.UcDetalleACCION_CONTRATADA1.DataSource.EndEdit()
    '    Dim liRet As Integer = Me.UcListaACCION_CONTRATADA1.Guardar()
    '    If liRet <> 1 Then
    '        Me.sError = Me.UcListaACCION_CONTRATADA1.sError
    '    Else
    '        Me.sError = ""
    '    End If
    '    Return liRet
    'End Function

    Private Sub UcListaACCION_CONTRATADA1_CambioRegistro() Handles UcListaACCION_CONTRATADA1.CambioRegistro
        If Not Me.UcListaACCION_CONTRATADA1.Current Is Nothing Then 
            Me.ToolStripButtonEditar.Visible = True
        End If 
    End Sub

    Public Sub Inicializar()
        Me.UcListaACCION_CONTRATADA1.EsConsulta = True
        'Me.UcListaACCION_CONTRATADA1.CbxPROGRAMA_FORMACION1.SelectedIndex = 0
        Me.UcListaACCION_CONTRATADA1.TextEditNUM_CONTRATO.Text = ""
        Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.ConfigurarMenu("Iniciar")
    End Sub

    Private Sub ConfigurarMenu(ByVal opcion As String)
        Select Case opcion
            Case "Agregar", "Editar"
                Me.ToolStripButtonBuscar.Visible = False
                Me.ToolStripButtonAgregar.Visible = False
                Me.ToolStripButtonEditar.Visible = False
                Me.ToolStripButtonGuardar.Visible = True
                Me.ToolStripButtonCancelar.Visible = True
                Me.ToolStripButtonEliminar.Visible = False
                Me.ToolStripButtonAsociarGrupos.Visible = False
                Me.ToolStripButtonHabilitarGrupos.Visible = False
                Me.ToolStripButtonCopiar.Visible = False
            Case "Guardar", "Cancelar"
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                If Not Me.UcListaACCION_CONTRATADA1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                End If
                Me.ToolStripButtonAsociarGrupos.Visible = True
                Me.ToolStripButtonHabilitarGrupos.Visible = True
                Me.ToolStripButtonCopiar.Visible = True
            Case "Eliminar"
                If Not Me.UcListaACCION_CONTRATADA1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                End If
            Case Else
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                Me.ToolStripButtonAsociarGrupos.Visible = True
                Me.ToolStripButtonHabilitarGrupos.Visible = True
                Me.ToolStripButtonCopiar.Visible = True
        End Select
    End Sub

    Private Function ObtenerPrecioGrupoAccion(ByVal idAccionContratada As Decimal) As Decimal
        Dim lAccionContratada As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(idAccionContratada)
        Dim lListaGruposAsociados As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(idAccionContratada)
        Dim totalAsociado As Decimal = 0
        Dim precioUnitario As Decimal = Math.Round(lAccionContratada.MONTO / lAccionContratada.CANT_CURSOS, 2)

        If lAccionContratada IsNot Nothing Then
            For i As Integer = 0 To lListaGruposAsociados.Count - 1
                totalAsociado += lListaGruposAsociados(i).MONTO
            Next
        End If
        If (lAccionContratada.MONTO - totalAsociado) < precioUnitario Then precioUnitario = lAccionContratada.MONTO - totalAsociado

        Return precioUnitario
    End Function

    Private Sub ToolStripMantto_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMantto.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Agregar"
                Me.UcDetalleACCION_CONTRATADA1.ACCION_CONTRATADA = New ACCION_CONTRATADA
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            Case "Editar"
                If Me.UcListaACCION_CONTRATADA1.Current IsNot Nothing Then
                    Me.UcDetalleACCION_CONTRATADA1.ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(Me.UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                    Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If
            Case "Buscar"
                Me.Cursor = Cursors.WaitCursor
                Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
                Me.Cursor = Cursors.Default
            Case "Guardar"
                If Me.UcDetalleACCION_CONTRATADA1.Actualizar() <> 1 Then Exit Sub
                Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Cancelar"
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Eliminar"
                Me.UcListaACCION_CONTRATADA1.Eliminar()
                Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
            Case "Copiar"
                If UcListaACCION_CONTRATADA1.Current IsNot Nothing Then
                    Dim sNumItem As String = InputBox("Ingrese el N° de Item:")
                    If sNumItem.Trim = "" OrElse Not IsNumeric(sNumItem) Then
                        AsignarMensaje("N° de Item no válido", True)
                        Return
                    End If
                    Dim lAccionOrigen As ACCION_CONTRATADA = UcListaACCION_CONTRATADA1.Current
                    Dim lAccionDestino As New ACCION_CONTRATADA
                    Dim bAccionContratada As New cACCION_CONTRATADA
                    lAccionDestino = lAccionOrigen
                    lAccionDestino.ID_ACCION_CONTRATADA = 0
                    lAccionDestino.NUM_ITEM = CDec(sNumItem)
                    lAccionDestino.USUARIO_CREACION = Me.usuarioActualizacion
                    lAccionDestino.FECHA_CREACION = Now
                    lAccionDestino.USERID = Me.usuarioActualizacion
                    lAccionDestino.LASTUPDATE = Now
                    If bAccionContratada.ActualizarACCION_CONTRATADA(lAccionDestino) <> 1 Then
                        AsignarMensaje("Error al copiar accion contratada: " + bAccionContratada.sError)
                        Return
                    End If
                    Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
                End If

            Case "Asociar a Grupos"
                If UcListaACCION_CONTRATADA1.Current IsNot Nothing Then
                    Dim bGrupoAccion As New cGRUPO_ACCION_CONTRATADA
                    Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(UcListaACCION_CONTRATADA1.Current.ID_CONTRATO)
                    Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
                    Dim lGrupoSolicitud As New GRUPO_SOLICITUD
                    Dim lTdr As String


                    If lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                        lTdr = lContrato.NUM_CONTRATO.ToString + "-" + UcListaACCION_CONTRATADA1.Current.NUM_ITEM.ToString
                    Else
                        lTdr = lContrato.NUM_CONTRATO.ToString
                    End If

                    If Utilerias.EsProgramaPATI(lContrato.ID_PROGRAMA_FORMACION) Then
                        'Grupos de capacitación PATI
                        Dim frmAsociacion As New frmAsociacionGruposPATI
                        frmAsociacion.CargarGruposDisponibles(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA, lContrato.ID_FUENTE, UcListaACCION_CONTRATADA1.Current.NO_CONVOCATORIA, UcListaACCION_CONTRATADA1.Current.CODIGO_DEPARTAMENTO, UcListaACCION_CONTRATADA1.Current.CODIGO_MUNICIPIO)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            For Each lIdGrupoAF As Decimal In frmAsociacion.GruposSeleccionados
                                Dim lGrupoAccion As New GRUPO_ACCION_CONTRATADA
                                lGrupoAccion.ID_GRUPO_ACCION = 0
                                lGrupoAccion.ID_ACCION_CONTRATADA = UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA
                                lGrupoAccion.ID_GRUPO_AF = lIdGrupoAF
                                lGrupoAccion.ID_ACCION_FORMATIVA = -1
                                lGrupoAccion.USUARIO_CREACION = Utilerias.ObtenerUsuario
                                lGrupoAccion.FECHA_CREACION = Now
                                lGrupoAccion.USERID = SGAFP.EL.Utilerias.ObtenerUsuario
                                lGrupoAccion.LASTUPDATE = Now
                                lGrupoAccion.MONTO = ObtenerPrecioGrupoAccion(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                                If bGrupoAccion.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAccion, TipoConcurrencia.Pesimistica) <> 1 Then
                                    AsignarMensaje("Error al asociar el grupo de capacitación: " + bGrupoAccion.sError)
                                    Return
                                End If
                            Next
                        End If
                    Else
                        Dim frmAsociacion As New frmAsociacionPROYECTOESP
                        frmAsociacion.CargarGruposDisponibles(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA, lContrato.ID_PROGRAMA_FORMACION, UcListaACCION_CONTRATADA1.Current.CODIGO_PROGRAMA, String.Empty, String.Empty)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            For Each lIdGrupoAF As Decimal In frmAsociacion.GruposSeleccionados
                                Dim lGrupoAccion As New GRUPO_ACCION_CONTRATADA
                                lGrupoAccion.ID_GRUPO_ACCION = 0
                                lGrupoAccion.ID_ACCION_CONTRATADA = UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA
                                lGrupoAccion.ID_GRUPO_AF = lIdGrupoAF
                                lGrupoAccion.ID_ACCION_FORMATIVA = -1
                                lGrupoAccion.USUARIO_CREACION = Utilerias.ObtenerUsuario
                                lGrupoAccion.FECHA_CREACION = Now
                                lGrupoAccion.USERID = SGAFP.EL.Utilerias.ObtenerUsuario
                                lGrupoAccion.LASTUPDATE = Now
                                lGrupoAccion.MONTO = ObtenerPrecioGrupoAccion(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                                If bGrupoAccion.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAccion, TipoConcurrencia.Pesimistica) <> 1 Then
                                    AsignarMensaje("Error al asociar el grupo de capacitación: " + bGrupoAccion.sError)
                                    Return
                                End If
                                lGrupoSolicitud = bGrupoSolicitud.ObtenerGRUPO_SOLICITUD(lIdGrupoAF)
                                If lGrupoSolicitud IsNot Nothing Then
                                    lGrupoSolicitud.CORRELATIVO_GRUPO = lGrupoAccion.ID_GRUPO_ACCION
                                    lGrupoSolicitud.TDR = lTdr
                                    bGrupoSolicitud.ActualizarGRUPO_SOLICITUD(lGrupoSolicitud)
                                End If
                            Next
                        End If
                    End If
                    Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
                End If

            Case "Desasociar Grupos"
                If UcListaACCION_CONTRATADA1.Current IsNot Nothing Then
                    Dim bGrupoAccion As New cGRUPO_ACCION_CONTRATADA
                    Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(UcListaACCION_CONTRATADA1.Current.ID_CONTRATO)
                    Dim bGrupoSolicitud As New cGRUPO_SOLICITUD
                    Dim lGrupoSolicitud As New GRUPO_SOLICITUD

                    If Utilerias.EsProgramaPATI(lContrato.ID_PROGRAMA_FORMACION) Then
                        Dim frmAsociacion As New frmAsociacionGruposPATI
                        frmAsociacion.CargarGruposPorDesasociar(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            For i As Integer = 0 To frmAsociacion.AccionesSeleccionadas.Count - 1
                                If bGrupoAccion.EliminarGRUPO_ACCION_CONTRATADA(frmAsociacion.AccionesSeleccionadas(i)) <> 1 Then
                                    AsignarMensaje("No se logro eliminar la asociacion de grupo accion con ID: " + frmAsociacion.AccionesSeleccionadas(i).ToString)
                                    Return
                                End If
                            Next
                        End If
                    Else
                        Dim frmAsociacion As New frmAsociacionPROYECTOESP
                        frmAsociacion.CargarGruposPorDesasociar(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            For i As Integer = 0 To frmAsociacion.AccionesSeleccionadas.Count - 1
                                If bGrupoAccion.EliminarGRUPO_ACCION_CONTRATADA(frmAsociacion.AccionesSeleccionadas(i)) <> 1 Then
                                    AsignarMensaje("No se logro eliminar la asociacion de grupo accion con ID: " + frmAsociacion.AccionesSeleccionadas(i).ToString)
                                    Return
                                End If
                                lGrupoSolicitud = bGrupoSolicitud.ObtenerGRUPO_SOLICITUD(frmAsociacion.GruposSeleccionados(i))
                                If lGrupoSolicitud IsNot Nothing Then
                                    lGrupoSolicitud.CORRELATIVO_GRUPO = -1
                                    lGrupoSolicitud.TDR = ""
                                    bGrupoSolicitud.ActualizarGRUPO_SOLICITUD(lGrupoSolicitud)
                                End If
                            Next
                        End If
                    End If
                    Me.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
                End If

            Case "Habilitar Grupos"
                If UcListaACCION_CONTRATADA1.Current IsNot Nothing Then
                    Dim lAccionContratada As ACCION_CONTRATADA = UcListaACCION_CONTRATADA1.Current
                    Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)
                    Dim lListaGruposAsoc As listaGRUPO_ACCION_CONTRATADA
                    Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccionContratada.CODIGO_PROGRAMA)
                    Dim lAreas As SIFP.EL.Areas = (New SIFP.BL.cAreas).ObtenerAreas(lPrograma.codigo_area)
                    Dim lProveedor As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lContrato.ID_PROVEEDOR_AF)
                    Dim listaBeneficiarios As New PATI.EL.listaPARTICIPANTE_POR_AF
                    Dim lListaGrupoPorSolicitud As PATI.EL.listaGRUPO_POR_SOLICITUD
                    Dim Criterios As New List(Of PATI.EL.Criteria)
                    Dim lRet As String
                    Dim lTdr As String
                    Dim bGrupoAFPATI As New PATI.BL.cGRUPO_ACCION_FORMATIVA
                    Dim lGrupoAFPATI As PATI.EL.GRUPO_ACCION_FORMATIVA
                    Dim lGrupoAsociado As GRUPO_ACCION_CONTRATADA
                    Dim ws As New srvSGAFP.wsSGAFPSoapClient
                    Dim lResolucionA As New StringBuilder()
                    Dim listaGruposSeleccionados As List(Of Decimal)
                    Dim cantidadBeneficiarios As Integer
                    Dim nombreAccionFormativa As String = ""

                    lListaGruposAsoc = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                    If lListaGruposAsoc Is Nothing OrElse lListaGruposAsoc.Count = 0 Then
                        AsignarMensaje("No existen Grupos asociados", True)
                        Return
                    End If

                    If lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                        lResolucionA.Append("C")
                        lResolucionA.Append(lContrato.NUM_CONTRATO)
                        If lContrato.LOTE IsNot Nothing AndAlso lContrato.LOTE <> "" Then
                            lResolucionA.Append(" L")
                            lResolucionA.Append(lContrato.LOTE)
                        End If
                        If lContrato.SUB_LOTE IsNot Nothing AndAlso lContrato.SUB_LOTE <> "" Then
                            lResolucionA.Append(" S")
                            lResolucionA.Append(lContrato.SUB_LOTE)
                        End If
                        lTdr = lContrato.NUM_CONTRATO + "-" + lAccionContratada.NUM_ITEM.ToString
                    Else
                        lResolucionA.Append(lContrato.NUM_CONTRATO)
                        lTdr = lContrato.NUM_CONTRATO
                    End If

                    If Utilerias.EsProgramaPATI(lContrato.ID_PROGRAMA_FORMACION) Then
                        Dim frmAsociacion As New frmAsociacionGruposPATI
                        frmAsociacion.CargarGruposPorHabilitar(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            listaGruposSeleccionados = frmAsociacion.AccionesSeleccionadas
                        Else
                            Return
                        End If
                    Else
                        Dim frmAsociacion As New frmAsociacionPROYECTOESP
                        frmAsociacion.CargarGruposPorHabilitar(UcListaACCION_CONTRATADA1.Current.ID_ACCION_CONTRATADA)
                        If frmAsociacion.ShowDialog = DialogResult.OK Then
                            listaGruposSeleccionados = frmAsociacion.AccionesSeleccionadas
                        Else
                            Return
                        End If
                    End If
                    For i As Integer = 0 To listaGruposSeleccionados.Count - 1
                        Me.Cursor = Cursors.WaitCursor
                        lGrupoAsociado = (New cGRUPO_ACCION_CONTRATADA).ObtenerGRUPO_ACCION_CONTRATADA(listaGruposSeleccionados(i))

                        If Utilerias.EsProgramaPATI(lContrato.ID_PROGRAMA_FORMACION) Then
                            lGrupoAFPATI = bGrupoAFPATI.ObtenerGRUPO_ACCION_FORMATIVA(lGrupoAsociado.ID_GRUPO_AF)
                            listaBeneficiarios = (New PATI.BL.cPARTICIPANTE_POR_AF).ObtenerListaPorGRUPO_ACCION_FORMATIVA(lGrupoAsociado.ID_GRUPO_AF)
                            If listaBeneficiarios IsNot Nothing Then cantidadBeneficiarios = listaBeneficiarios.Count
                            lGrupoAFPATI.CORRELATIVO_SIFP = lGrupoAsociado.ID_GRUPO_ACCION
                            If bGrupoAFPATI.ActualizarGRUPO_ACCION_FORMATIVA(lGrupoAFPATI, PATI.EL.TipoConcurrencia.Pesimistica) <> 1 Then
                                Me.Cursor = Cursors.Default
                                AsignarMensaje("No se logro actualizar el grupo con ID_GRUPO_AF: " + lGrupoAsociado.ID_GRUPO_AF.ToString)
                                Return
                            End If

                            'Asignar TDR a la Solicitud de Capacitación PATI a la que hace referencia el Grupo Asociado
                            Criterios.Add(New PATI.EL.Criteria("ID_GRUPO_AF", "=", lGrupoAFPATI.ID_GRUPO_AF, ""))
                            lListaGrupoPorSolicitud = (New PATI.BL.cGRUPO_POR_SOLICITUD).ObtenerListaPorBusqueda(New PATI.EL.GRUPO_POR_SOLICITUD, Criterios.ToArray)
                            If lListaGrupoPorSolicitud IsNot Nothing AndAlso lListaGrupoPorSolicitud.Count > 0 Then
                                Dim lSolicitudCap As PATI.EL.SOLICITUD_CAPACITACION_PATI
                                Dim bSolicitudCap As New PATI.BL.cSOLICITUD_CAPACITACION_PATI
                                Dim lRetAct As Integer
                                lSolicitudCap = bSolicitudCap.ObtenerSOLICITUD_CAPACITACION_PATI(lListaGrupoPorSolicitud(0).ID_SOLICITUD)
                                lSolicitudCap.TDR = lTdr
                                lSolicitudCap.ID_ESTADO_SOLIC_PATI = 3
                                lRetAct = bSolicitudCap.ActualizarSOLICITUD_CAPACITACION_PATI(lSolicitudCap, PATI.EL.TipoConcurrencia.Pesimistica, "ASOCIACIÓN DE SOLICITUD EN BOLPROS")
                                If lRetAct <> 1 AndAlso lRetAct <> 0 Then
                                    Me.Cursor = Cursors.Default
                                    AsignarMensaje("No se logro actualizar la Solicitud de Capacitación al que pertenece el grupo con ID_GRUPO_AF: " + lGrupoAsociado.ID_GRUPO_AF.ToString, True)
                                    Return
                                End If
                            End If
                        Else
                            Dim lGrupoSolicitud As GRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerGRUPO_SOLICITUD(lGrupoAsociado.ID_GRUPO_AF)
                            If lGrupoSolicitud IsNot Nothing Then
                                cantidadBeneficiarios = lGrupoSolicitud.NUM_PARTICIPANTES
                                nombreAccionFormativa = lGrupoSolicitud.NOMBRE_ACCION_FORMATIVA
                            End If
                        End If

                        lRet = ws.ProcesarAsignacionGanador(lAreas.codigo, lPrograma.codigo_programa, lPrograma.nombre_programa, _
                                    lAccionContratada.DURACION, lProveedor.NOMBRE_PROVEEDOR, lProveedor.NIT, _
                                    lAccionContratada.CODIGO_DEPARTAMENTO, lAccionContratada.CODIGO_MUNICIPIO, _
                                    lProveedor.ID_TIPO_PERSONA, lProveedor.DUI, lProveedor.NRC, lProveedor.DIRECCION, _
                                    lProveedor.EMAIL, lProveedor.TELEFONO, lProveedor.FAX, cantidadBeneficiarios, _
                                    lTdr, lGrupoAsociado.MONTO, Utilerias.ObtenerUsuario, _
                                    lGrupoAsociado.ID_GRUPO_ACCION)

                        If lRet <> "" Then
                            Me.Cursor = Cursors.Default
                            AsignarMensaje(lRet, True)
                            Return
                        Else
                            Dim lTdrs As listaTERMINO_REFERENCIA_AF
                            Dim lResolucionB As New StringBuilder(lResolucionA.ToString)
                            Dim bGrupoAsociado As New cGRUPO_ACCION_CONTRATADA
                            Dim bTdr As New cTERMINO_REFERENCIA_AF

                            'Actualizar RESOLUCION en Termino de Referencia
                            If lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                                lResolucionB.Append(" I")
                                lResolucionB.Append(lAccionContratada.NUM_ITEM.ToString)
                            End If

                            If Utilerias.EsProgramaPATI(lContrato.ID_PROGRAMA_FORMACION) Then
                                lGrupoAFPATI = bGrupoAFPATI.ObtenerGRUPO_ACCION_FORMATIVA(lGrupoAsociado.ID_GRUPO_AF)
                                lTdrs = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lGrupoAFPATI.ID_ACCION_FORMATIVA)
                                lTdrs(0).RESOLUCION = lResolucionB.ToString
                                bTdr.ActualizarTERMINO_REFERENCIA_AF(lTdrs(0), TipoConcurrencia.Pesimistica)

                                'Actualizar ID_ACCION_FORMATIVA en GrupoAccionContratada
                                lGrupoAFPATI = bGrupoAFPATI.ObtenerGRUPO_ACCION_FORMATIVA(lGrupoAsociado.ID_GRUPO_AF)
                                lGrupoAsociado.ID_ACCION_FORMATIVA = lGrupoAFPATI.ID_ACCION_FORMATIVA
                                lGrupoAsociado.HABILITADO = 1
                                bGrupoAsociado.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAsociado, TipoConcurrencia.Pesimistica)
                            Else
                                If lTdr.Length < 20 Then lTdr = lTdr + Space(20 - lTdr.Length)
                                Dim lCriterios As New List(Of Criteria)
                                lCriterios.Add(New Criteria("CORRELATIVO_GRUPO", "=", lGrupoAsociado.ID_GRUPO_ACCION, "AND"))
                                lCriterios.Add(New Criteria("TDR", "=", lTdr, ""))
                                lTdrs = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorBusqueda(New TERMINO_REFERENCIA_AF, lCriterios.ToArray)
                                If lTdrs IsNot Nothing AndAlso lTdrs.Count = 1 Then
                                    lTdrs(0).RESOLUCION = lResolucionB.ToString
                                    bTdr.ActualizarTERMINO_REFERENCIA_AF(lTdrs(0), TipoConcurrencia.Pesimistica)

                                    'Actualizar ID_ACCION_FORMATIVA en GrupoAccionContratada
                                    lGrupoAsociado.ID_ACCION_FORMATIVA = lTdrs(0).ID_ACCION_FORMATIVA
                                    lGrupoAsociado.HABILITADO = 1
                                    bGrupoAsociado.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAsociado, TipoConcurrencia.Pesimistica)

                                    'Actualizar nombre de accion formativa
                                    Dim bAccionFormativa As New cACCION_FORMATIVA
                                    Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lTdrs(0).ID_ACCION_FORMATIVA)
                                    If lAccionFormativa IsNot Nothing AndAlso nombreAccionFormativa <> "" Then
                                        lAccionFormativa.NOMBRE_ACCION_FORMATIVA = nombreAccionFormativa
                                        bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)
                                    End If
                                Else
                                    Me.Cursor = Cursors.Default
                                    AsignarMensaje("No se logro realizar la habilitación.", True)
                                    Return
                                End If
                            End If

                        End If
                    Next

                    Me.Cursor = Cursors.Default
                    AsignarMensaje("La habilitación se completo con éxito!")
                End If
        End Select
        ConfigurarMenu(e.ClickedItem.Text)
    End Sub

    Private Sub ucMantACCION_CONTRATADA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub
End Class

