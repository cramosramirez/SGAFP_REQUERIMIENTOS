Imports System.Web.Security.Membership
Imports SQLMembershipProvider.BL
Imports SGAFP.EL
Imports SGAFP.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCONTRATO_BOLPROS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleCONTRATO_BOLPROS

    Private _ContratoBolpros As New CONTRATO_BOLPROS
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

    Public Property CONTRATO_BOLPROS() As CONTRATO_BOLPROS
        Get
            Return _ContratoBolpros
        End Get
        Set(ByVal value As CONTRATO_BOLPROS)
            _ContratoBolpros = value
            Me.CargarDatos()
        End Set
    End Property

    Private Sub CargarDatos()
        Inicializar()
        If _ContratoBolpros IsNot Nothing AndAlso _ContratoBolpros.ID_CONTRATO > 0 Then
            Me.ID_CONTRATOTextEdit.Text = _ContratoBolpros.ID_CONTRATO
            Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = _ContratoBolpros.ID_PROVEEDOR_AF
            Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = _ContratoBolpros.ID_PROGRAMA_FORMACION
            Me.ID_TIPO_CONTRACbxTIPO_CONTRATACION1.SelectedValue = _ContratoBolpros.ID_TIPO_CONTRA
            Me.cbxCONTRATO_COMPRA1.SelectedValue = _ContratoBolpros.ID_CONTRATO_COMPRA
            Me.NUM_CONTRATOTextEdit.Text = _ContratoBolpros.NUM_CONTRATO
            Me.MONTOSpinEdit.Value = _ContratoBolpros.MONTO
            Me.LOTETextEdit.Text = _ContratoBolpros.LOTE
            Me.SUB_LOTETextEdit.Text = _ContratoBolpros.SUB_LOTE
            Me.FECHA_INI_EJECDateTimePicker.Value = If(_ContratoBolpros.FECHA_INI_EJEC = Nothing, Today, _ContratoBolpros.FECHA_INI_EJEC)
            Me.FECHA_FIN_EJECDateTimePicker.Value = If(_ContratoBolpros.FECHA_FIN_EJEC = Nothing, Today, _ContratoBolpros.FECHA_FIN_EJEC)
            If _ContratoBolpros.ES_PAGO_PARTICIPANTE = 1 Then
                Me.ES_PAGO_PARTICIPANTECheck.Checked = True
            Else
                Me.ES_PAGO_PARTICIPANTECheck.Checked = False
            End If
            Me.cbxTIPO_ADJUDICACION1.SelectedValue = _ContratoBolpros.ID_TIPO_ADJ
            Me.COSTO_X_PARTICIPANTESpinEdit.Value = If(_ContratoBolpros.COSTO_X_PARTICIPANTE = -1, Nothing, _ContratoBolpros.COSTO_X_PARTICIPANTE)
            Me.PARTICIPACIONESSpinEdit.Value = If(_ContratoBolpros.PARTICIPACIONES = -1, Nothing, _ContratoBolpros.PARTICIPACIONES)
            Me.chkES_INCREMENTO.Checked = If(_ContratoBolpros.ES_INCREMENTO = 1, True, False)
            Me.speNO_PRODUCTO.Value = If(_ContratoBolpros.NO_PRODUCTO = -1, Nothing, _ContratoBolpros.NO_PRODUCTO)
            Me.HabilitarCostoParti_Participaciones()
        End If
    End Sub

    Private Sub Inicializar()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        ID_CONTRATOTextEdit.Enabled = False
        ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar(False, False)
        ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedIndex = -1
        ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedIndex = -1
        ID_TIPO_CONTRACbxTIPO_CONTRATACION1.Recuperar()
        ID_TIPO_CONTRACbxTIPO_CONTRATACION1.SelectedIndex = -1
        cbxCONTRATO_COMPRA1.Recuperar()
        cbxCONTRATO_COMPRA1.SelectedIndex = -1
        Me.cbxTIPO_ADJUDICACION1.Recuperar()
        Me.cbxTIPO_ADJUDICACION1.SelectedIndex = -1
        Me.FECHA_INI_EJECDateTimePicker.Value = Today
        Me.FECHA_FIN_EJECDateTimePicker.Value = Today
        'NO_CONVOCATORIASpinEdit.Enabled = False
        ID_CONTRATOTextEdit.Text = ""
        'NO_CONVOCATORIASpinEdit.Value = 0
        NUM_CONTRATOTextEdit.Text = ""
        MONTOSpinEdit.Value = 0
        LOTETextEdit.Text = ""
        SUB_LOTETextEdit.Text = ""
        ES_PAGO_PARTICIPANTECheck.Checked = False
        'If Utilerias.ObtenerFuentePorProgramaFormacion(ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue) > -1 Then
        '    Me.NO_CONVOCATORIASpinEdit.Enabled = True
        'End If        
        Me.cbxTIPO_ADJUDICACION1.SelectedIndex = -1
        Me.COSTO_X_PARTICIPANTESpinEdit.Value = Nothing
        

        Me.HabilitarCostoParti_Participaciones()
        Me.ES_PAGO_PARTICIPANTECheck.Enabled = False

        If ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue IsNot Nothing AndAlso _
            ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO Then
            Me.COSTO_X_PARTICIPANTESpinEdit.Enabled = True
        Else
            Me.COSTO_X_PARTICIPANTESpinEdit.Value = Nothing
            Me.COSTO_X_PARTICIPANTESpinEdit.Enabled = False
        End If
        Me.chkES_INCREMENTO.Checked = False
        ' Me.speNO_PRODUCTO.Value = Nothing
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer
        Dim mControl As New cCONTRATO_BOLPROS

        If Me.ID_TIPO_CONTRACbxTIPO_CONTRATACION1.SelectedValue Is Nothing OrElse Me.ID_TIPO_CONTRACbxTIPO_CONTRATACION1.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el tipo de contratación", True)
            Return -1
        End If
        If Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue Is Nothing OrElse Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el proveedor", True)
            Return -1
        End If
        If Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue Is Nothing OrElse Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el programa de formación", True)
            Return -1
        End If
        If Me.cbxCONTRATO_COMPRA1.SelectedValue Is Nothing OrElse Me.cbxCONTRATO_COMPRA1.SelectedValue = -1 Then
            Me.AsignarMensaje("Seleccione el N° de Oferta de Compra", True)
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

        'Si hay cursos programados las fechas de ejecución no podrán quedar fuera del período de validez
        Dim lfechas As Dictionary(Of String, Date) = (New cACCION_FORMATIVA).ObtenerFechaMinimaMaximaEjecucionPorCONTRATO_BOLPROS(_ContratoBolpros.ID_CONTRATO)
        If lfechas IsNot Nothing AndAlso lfechas.Count > 0 Then
            If lfechas("FECHA_MINIMA") < Me.FECHA_INI_EJECDateTimePicker.Value Then
                Me.AsignarMensaje("Se han detectado cursos en ejecución para este contrato que tienen fecha de inicio menor a la fecha inicial del periodo de validez del contrato. La fecha mínima de ejecución debe ser menor o igual al: " + lfechas("FECHA_MINIMA").ToString("dd/MM/yyyy"), True)
                Return -1
            End If
            If lfechas("FECHA_MAXIMA") > Me.FECHA_FIN_EJECDateTimePicker.Value Then
                Me.AsignarMensaje("Se han detectado cursos en ejecución para este contrato que tienen fecha de finalización mayor a la fecha final del periodo de validez del contrato. La fecha maxima de ejecución debe ser mayor o igual al: " + lfechas("FECHA_MAXIMA").ToString("dd/MM/yyyy"), True)
                Return -1
            End If
        End If
        If Me.cbxTIPO_ADJUDICACION1.SelectedValue Is Nothing Then
            Me.AsignarMensaje("Seleccione el tipo de adjudicación", True)
            Return -1
        End If
        If Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante AndAlso _
            Me.COSTO_X_PARTICIPANTESpinEdit.Value = 0 Then
            Me.AsignarMensaje("Ingrese el costo por participante para el tipo de adjudicación", True)
            Return -1
        End If
        If Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante AndAlso _
            Me.PARTICIPACIONESSpinEdit.Value = 0 Then
            Me.AsignarMensaje("Ingrese la cantidad de participaciones para el tipo de adjudicación", True)
            Return -1
        End If

        If Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO AndAlso _
            Me.COSTO_X_PARTICIPANTESpinEdit.Value = 0 Then
            Me.AsignarMensaje("Ingrese el costo por participante", True)
            Return -1
        End If

        If _ContratoBolpros.ID_CONTRATO <= 0 Then
            _ContratoBolpros.USUARIO_CREACION = Utilerias.ObtenerUsuario
            _ContratoBolpros.FECHA_CREACION = Now
        End If

        _ContratoBolpros.ID_PROVEEDOR_AF = Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue
        _ContratoBolpros.ID_PROGRAMA_FORMACION = Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue
        _ContratoBolpros.ID_TIPO_CONTRA = Me.ID_TIPO_CONTRACbxTIPO_CONTRATACION1.SelectedValue
        _ContratoBolpros.ID_FUENTE = Utilerias.ObtenerFuentePorProgramaFormacion(_ContratoBolpros.ID_PROGRAMA_FORMACION)
        _ContratoBolpros.ID_CONTRATO_COMPRA = If(Me.cbxCONTRATO_COMPRA1.SelectedValue Is Nothing, -1, cbxCONTRATO_COMPRA1.SelectedValue)
        _ContratoBolpros.FECHA_INI_EJEC = Me.FECHA_INI_EJECDateTimePicker.Value
        _ContratoBolpros.FECHA_FIN_EJEC = Me.FECHA_FIN_EJECDateTimePicker.Value
        _ContratoBolpros.NUM_CONTRATO = Me.NUM_CONTRATOTextEdit.Text
        _ContratoBolpros.MONTO = Me.MONTOSpinEdit.Value
        _ContratoBolpros.LOTE = Me.LOTETextEdit.Text
        _ContratoBolpros.SUB_LOTE = Me.SUB_LOTETextEdit.Text
        _ContratoBolpros.USERID = EL.Utilerias.ObtenerUsuario
        _ContratoBolpros.LASTUPDATE = Now
        _ContratoBolpros.ID_TIPO_ADJ = Me.cbxTIPO_ADJUDICACION1.SelectedValue
        _ContratoBolpros.COSTO_X_PARTICIPANTE = If(Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante, Me.COSTO_X_PARTICIPANTESpinEdit.Value, -1)
        _ContratoBolpros.PARTICIPACIONES = If(Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante, Me.PARTICIPACIONESSpinEdit.Value, -1)
        _ContratoBolpros.ES_PAGO_PARTICIPANTE = If(Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online, 1, 0)
        _ContratoBolpros.ES_INCREMENTO = If(chkES_INCREMENTO.Checked, 1, 0)
        _ContratoBolpros.NO_PRODUCTO = If(speNO_PRODUCTO.Value = Nothing, -1, speNO_PRODUCTO.Value)

        If Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante OrElse _
            Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO Then
            _ContratoBolpros.PARTICIPACIONES = Me.PARTICIPACIONESSpinEdit.Value
        End If

        _ContratoBolpros.COSTO_X_PARTICIPANTE = If(Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.SelectedValue = ProgramasFormacion.EMPRESA_CENTRO OrElse _
                                                   Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante, Me.COSTO_X_PARTICIPANTESpinEdit.Value, -1)
        If mControl.ActualizarCONTRATO_BOLPROS(_ContratoBolpros, TipoConcurrencia.Pesimistica) < 1 Then
            Me.AsignarMensaje(mControl.sError, True)
            Return -1
        End If
        Me.ID_CONTRATOTextEdit.Text = _ContratoBolpros.ID_CONTRATO.ToString()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ID_TIPO_CONTRACbxTIPO_CONTRATACION1.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.ID_PROGRAMA_FORMACIONcbxPROGRAMA_FORMACION.Enabled = edicion
        Me.cbxCONTRATO_COMPRA1.Enabled = edicion
        'Me.NO_CONVOCATORIASpinEdit.Enabled = edicion
        Me.NUM_CONTRATOTextEdit.Enabled = edicion
        Me.MONTOSpinEdit.Enabled = edicion
        Me.LOTETextEdit.Enabled = edicion
        Me.SUB_LOTETextEdit.Enabled = edicion
        Me.FECHA_INI_EJECDateTimePicker.Enabled = edicion
        Me.FECHA_FIN_EJECDateTimePicker.Enabled = edicion

        Me.cbxTIPO_ADJUDICACION1.Enabled = EsNuevo
        Me.COSTO_X_PARTICIPANTESpinEdit.Enabled = False
        Me.PARTICIPACIONESSpinEdit.Enabled = False
        Me.ES_PAGO_PARTICIPANTECheck.Enabled = False
        Me.chkES_INCREMENTO.Enabled = edicion
        Me.speNO_PRODUCTO.Enabled = edicion
    End Sub


    Private Sub cbxCONTRATO_COMPRA1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCONTRATO_COMPRA1.SelectedIndexChanged
        If Me.cbxCONTRATO_COMPRA1.SelectedValue IsNot Nothing Then
            Dim lOfertaCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(Me.cbxCONTRATO_COMPRA1.SelectedValue)
            If lOfertaCompra IsNot Nothing Then
                Me.FECHA_INI_EJECDateTimePicker.Value = If(lOfertaCompra.FECHA_INI_EJEC = Nothing, Today, lOfertaCompra.FECHA_INI_EJEC)
                Me.FECHA_FIN_EJECDateTimePicker.Value = If(lOfertaCompra.FECHA_FIN_EJEC = Nothing, Today, lOfertaCompra.FECHA_FIN_EJEC)
            End If
        Else
            Me.FECHA_INI_EJECDateTimePicker.Value = Today
            Me.FECHA_FIN_EJECDateTimePicker.Value = Today
        End If
    End Sub

    Private Sub cbxTIPO_ADJUDICACION1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_ADJUDICACION1.SelectedValueChanged
        Me.HabilitarCostoParti_Participaciones()
    End Sub

    Private Sub HabilitarCostoParti_Participaciones()
        If Me.cbxTIPO_ADJUDICACION1.SelectedValue = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
            Me.MONTOSpinEdit.Enabled = False
            Me.COSTO_X_PARTICIPANTESpinEdit.Enabled = True
            Me.PARTICIPACIONESSpinEdit.Enabled = True
            Me.MONTOSpinEdit.Value = Math.Round(Me.PARTICIPACIONESSpinEdit.Value * Me.COSTO_X_PARTICIPANTESpinEdit.Value, 2)
        Else
            Me.MONTOSpinEdit.Enabled = True
            Me.COSTO_X_PARTICIPANTESpinEdit.Enabled = False
            Me.PARTICIPACIONESSpinEdit.Enabled = False
            Me.PARTICIPACIONESSpinEdit.Value = Nothing
            Me.COSTO_X_PARTICIPANTESpinEdit.Value = Nothing
        End If
    End Sub

    Private Sub COSTO_X_PARTICIPANTESpinEdit_ValueChanged(sender As Object, e As EventArgs) Handles COSTO_X_PARTICIPANTESpinEdit.ValueChanged
        Me.HabilitarCostoParti_Participaciones()
    End Sub

    Private Sub PARTICIPACIONESSpinEdit_TextChanged(sender As Object, e As EventArgs) Handles PARTICIPACIONESSpinEdit.TextChanged
        Me.HabilitarCostoParti_Participaciones()
    End Sub


End Class
