Imports SGAFP.EL
Imports SGAFP.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCONTRATO_COMPRA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/05/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleCONTRATO_COMPRA

    Private _ContratoCompra As New CONTRATO_COMPRA
    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.HabilitarEdicion(Not value)
        End Set
    End Property


    Public Property CONTRATO_COMPRA() As CONTRATO_COMPRA
        Get
            Return _ContratoCompra
        End Get
        Set(ByVal value As CONTRATO_COMPRA)
            _ContratoCompra = value
            Me.CargarDatos()
        End Set
    End Property


    Private Sub CargarDatos()
        Inicializar()
        If _ContratoCompra IsNot Nothing AndAlso _ContratoCompra.ID_CONTRATO_COMPRA > 0 Then
            Me.ID_CONTRATO_COMPRATextBox.Text = _ContratoCompra.ID_CONTRATO_COMPRA
            Me.NO_CONTRATO_COMPRATextBox.Text = _ContratoCompra.NO_CONTRATO_COMPRA
            Me.FECHA_INGRESODateTimePicker.Value = _ContratoCompra.FECHA_INGRESO
            Me.FECHA_INI_EJECDateTimePicker.Value = _ContratoCompra.FECHA_INI_EJEC
            Me.FECHA_FIN_EJECDateTimePicker.Value = _ContratoCompra.FECHA_FIN_EJEC
            Me.PORC_ASISTENCIA_MINtxt.Text = _ContratoCompra.PORC_ASISTENCIA_MIN
            ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue = _ContratoCompra.ID_UNIDAD_ORGANIZATIVA
            Me.txtBaseParti.Text = ""
            Me.txtBaseParti.Visible = False
            Me.lblBaseParti.Visible = False
            Me.chkPAGO_EN_BASE_A.SetItemChecked(_ContratoCompra.PAGO_POR_PARTICIPACION, True)

            Select Case _ContratoCompra.PAGO_POR_PARTICIPACION
                Case CompraBasePago.PagoCursoIndependienteCapacitados
                Case CompraBasePago.PagoBaseDefinida
                    Me.txtBaseParti.Text = _ContratoCompra.BASE_PARTI
                    Me.txtBaseParti.Visible = True
                    Me.lblBaseParti.Visible = True
                Case CompraBasePago.PagoBaseInscritos
            End Select

            If Me.EstaEnRol(RolDeUsuario.Administrador) Then
                btnRecalculoPagoInformes.Visible = True
            End If
            
        End If
    End Sub

    Private Sub Inicializar()
        ID_CONTRATO_COMPRATextBox.Text = ""
        NO_CONTRATO_COMPRATextBox.Text = ""
        FECHA_INGRESODateTimePicker.Value = Today
        FECHA_INI_EJECDateTimePicker.Value = Today
        FECHA_FIN_EJECDateTimePicker.Value = Today
        ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.RecuperarPorProyectosEspeciales()
        ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedIndex = -1
        Me.PORC_ASISTENCIA_MINtxt.Text = ""
        Me.chkPAGO_EN_BASE_A.ClearSelected()
        Me.txtBaseParti.Text = ""
        Me.txtBaseParti.Visible = False
        Me.lblBaseParti.Visible = False
        For i As Int32 = 0 To chkPAGO_EN_BASE_A.Items.Count - 1
            chkPAGO_EN_BASE_A.SetItemChecked(i, False)
        Next
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer
        Dim mControl As New cCONTRATO_COMPRA
        Dim lista As New listaCONTRATO_COMPRA

        If Me.NO_CONTRATO_COMPRATextBox.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese el No. de Oferta de Compra", True)
            Return -1
        End If
        If Me.FECHA_INI_EJECDateTimePicker.Value = #12:00:00 AM# Then
            Me.AsignarMensaje("Ingrese la fecha de inicio de ejecución del contrato", True)
            Return -1
        End If
        If Me.FECHA_FIN_EJECDateTimePicker.Value = #12:00:00 AM# Then
            Me.AsignarMensaje("Ingrese la fecha de fin de ejecución del contrato", True)
            Return -1
        End If
        If Me.PORC_ASISTENCIA_MINtxt.Text.Trim = "" OrElse Not IsNumeric(Me.PORC_ASISTENCIA_MINtxt.Text) Then
            Me.AsignarMensaje("Ingrese el porcentaje mínimo de asistencia", True)
            Return -1
        End If
        If Me.chkPAGO_EN_BASE_A.CheckedItems.Count = 0 Then
            Me.AsignarMensaje("Seleccione una base para pago", True)
            Return -1
        End If
        If chkPAGO_EN_BASE_A.CheckedIndices(0) = CompraBasePago.PagoBaseDefinida AndAlso (Me.txtBaseParti.Text.Trim = "" OrElse Not IsNumeric(Me.txtBaseParti.Text.Trim)) Then
            Me.AsignarMensaje("Ingrese la cantidad base de participantes para pago", True)
            Return -1
        End If

        'Verificar si ya existe una oferta de compra con este número
        lista = mControl.ObtenerListaPorNO_CONTRATO_COMPRA(Me.NO_CONTRATO_COMPRATextBox.Text.Trim)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            If (_ContratoCompra.ID_CONTRATO_COMPRA = 0) OrElse (_ContratoCompra.ID_CONTRATO_COMPRA <> lista(0).ID_CONTRATO_COMPRA) Then
                Me.AsignarMensaje("Ya existe una Oferta de compra No. " + Me.NO_CONTRATO_COMPRATextBox.Text.Trim + " registrada en el sistema", True)
                Return -1
            End If
        End If
        _ContratoCompra.NO_CONTRATO_COMPRA = Me.NO_CONTRATO_COMPRATextBox.Text
        _ContratoCompra.FECHA_INGRESO = Me.FECHA_INGRESODateTimePicker.Value
        _ContratoCompra.FECHA_INI_EJEC = Me.FECHA_INI_EJECDateTimePicker.Value
        _ContratoCompra.FECHA_FIN_EJEC = Me.FECHA_FIN_EJECDateTimePicker.Value
        _ContratoCompra.PORC_ASISTENCIA_MIN = Convert.ToDecimal(Me.PORC_ASISTENCIA_MINtxt.Text)
        _ContratoCompra.PAGO_POR_PARTICIPACION = chkPAGO_EN_BASE_A.CheckedIndices(0)
        If chkPAGO_EN_BASE_A.CheckedIndices(0) = CompraBasePago.PagoBaseDefinida Then
            _ContratoCompra.BASE_PARTI = Convert.ToDecimal(Me.txtBaseParti.Text)
        Else
            _ContratoCompra.BASE_PARTI = -1
        End If
        If _ContratoCompra.ID_CONTRATO_COMPRA = 0 Then
            _ContratoCompra.USUARIO_CREA = Utilerias.ObtenerUsuario
            _ContratoCompra.FECHA_CREA = Now
            _ContratoCompra.USUARIO_ACT = Utilerias.ObtenerUsuario
            _ContratoCompra.FECHA_ACT = Now
        Else
            _ContratoCompra.USUARIO_ACT = Utilerias.ObtenerUsuario
            _ContratoCompra.FECHA_ACT = Now
        End If
        _ContratoCompra.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.SelectedValue


        If mControl.ActualizarCONTRATO_COMPRA(_ContratoCompra, TipoConcurrencia.Pesimistica) < 1 Then
            Me.AsignarMensaje(mControl.sError, True)
            Return -1
        End If
        Me.ID_CONTRATO_COMPRATextBox.Text = _ContratoCompra.ID_CONTRATO_COMPRA.ToString()
        Return 1
    End Function
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_CONTRATO_COMPRATextBox.Enabled = False
        Me.NO_CONTRATO_COMPRATextBox.Enabled = edicion
        Me.FECHA_INGRESODateTimePicker.Enabled = edicion
        Me.ID_UNIDAD_ORGANIZATIVAcbxUNIDAD_ORGANIZATIVA.Enabled = edicion
        Me.FECHA_INI_EJECDateTimePicker.Enabled = edicion
        Me.FECHA_FIN_EJECDateTimePicker.Enabled = edicion
        Me.PORC_ASISTENCIA_MINtxt.Enabled = edicion
        Me.chkPAGO_EN_BASE_A.Enabled = edicion
    End Sub

    Private Sub btnRecalculoPagoInformes_Click(sender As Object, e As EventArgs) Handles btnRecalculoPagoInformes.Click
        If CONTRATO_COMPRA IsNot Nothing AndAlso CONTRATO_COMPRA.ID_CONTRATO_COMPRA > 0 Then
            Dim bInformeFinal As New cINFORME_FINAL_AF
            Dim bInformeFinalHis As New cINFORME_FINAL_AF_HIS
            Dim listaInformes As listaINFORME_FINAL_AF = bInformeFinal.ObtenerListaPorCONTRATO_COMPRA(CONTRATO_COMPRA.ID_CONTRATO_COMPRA)
            Dim lInformeHis As INFORME_FINAL_AF_HIS
            Me.Cursor = Cursors.WaitCursor
            For i As Int32 = 0 To listaInformes.Count - 1
                Dim lEntidadOld As INFORME_FINAL_AF = bInformeFinal.ObtenerINFORME_FINAL_AF(listaInformes(i).ID_INFORME_FINAL)
                Dim lEntidad As INFORME_FINAL_AF = bInformeFinal.GenerarInformeParcial(listaInformes(i).ID_ACCION_FORMATIVA, listaInformes(i).FECHA_INICIAL, listaInformes(i).FECHA_FINAL, False)
                If lEntidad IsNot Nothing Then
                    lEntidad.ID_INFORME_FINAL = lEntidadOld.ID_INFORME_FINAL
                    lEntidad.ID_ESTADO_INFORME = lEntidadOld.ID_ESTADO_INFORME
                    lEntidad.ELABORADO_POR = lEntidadOld.ELABORADO_POR
                    lEntidad.USERID = lEntidadOld.USERID
                    lEntidad.LASTUPDATE = lEntidadOld.LASTUPDATE
                    bInformeFinal.ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Pesimistica, False, False, False)
                End If

                lInformeHis = New INFORME_FINAL_AF_HIS
                With lInformeHis
                    .ID_INFORME_FINAL_HIS = 0
                    .ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                    .ID_ACCION_FORMATIVA = lEntidad.ID_ACCION_FORMATIVA
                    .ID_PROVEEDOR_AF = lEntidad.ID_PROVEEDOR_AF
                    .FECHA_INFORME = lEntidad.FECHA_INFORME
                    .NUMERO_FACTURA = lEntidad.NUMERO_FACTURA
                    .ELABORADO_POR = lEntidad.ELABORADO_POR
                    .MONTO_FACTURA = lEntidad.MONTO_FACTURA
                    .MONTO_APROBADO = lEntidad.MONTO_APROBADO
                    .PARTICIPANTES_INSCRITOS = lEntidad.PARTICIPANTES_INSCRITOS
                    .PARTICIPANTES_FINALES = lEntidad.PARTICIPANTES_FINALES
                    .PORC_PROM_ASISTENCIA = lEntidad.PORC_PROM_ASISTENCIA
                    .NOTA_PROMEDIO = lEntidad.NOTA_PROMEDIO
                    .COMENTARIOS = "RECALCULO DE MONTO A PAGAR"
                    .USUARIO_APROBACION = lEntidad.USUARIO_APROBACION
                    .LASTUPDATE = Now
                    .USERID = usuarioActualizacion
                    .ID_ESTADO_INFORME = EstadoInformeFinal.RecalculoMontoPagar
                    .HORAS_DESARROLLADAS = lEntidad.HORAS_DESARROLLADAS
                    .FECHA_INICIAL = lEntidad.FECHA_INICIAL
                    .FECHA_FINAL = lEntidad.FECHA_FINAL
                    .HORARIO = lEntidad.HORARIO
                    .COSTO_X_HORA = lEntidad.COSTO_X_HORA
                    .USERID = usuarioActualizacion
                    .LASTUPDATE = Now
                End With
                bInformeFinalHis.ActualizarINFORME_FINAL_AF_HIS(lInformeHis)
            Next
            Me.Cursor = Cursors.Default
            Me.AsignarMensaje("Se ha finalizado el recalculo de informes", False)
        End If
    End Sub

    Private Sub chkPAGO_EN_BASE_A_ItemCheck(sender As Object, e As Windows.Forms.ItemCheckEventArgs) Handles chkPAGO_EN_BASE_A.ItemCheck
        For i As Int32 = 0 To chkPAGO_EN_BASE_A.Items.Count - 1
            If i <> e.Index Then chkPAGO_EN_BASE_A.SetItemChecked(i, False)
        Next
        Me.txtBaseParti.Visible = (e.Index = CompraBasePago.PagoBaseDefinida)
        Me.lblBaseParti.Visible = (e.Index = CompraBasePago.PagoBaseDefinida)
    End Sub
    
End Class
