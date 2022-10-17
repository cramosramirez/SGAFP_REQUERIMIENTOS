Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleSOLICITUD_INSCRIPCION_AF

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

    Public ReadOnly Property Current() As SOLICITUD_INSCRIPCION_AF
        Get
            Return CType(Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.Current, SOLICITUD_INSCRIPCION_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSOLICITUD_INSCRIPCION_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLICITUD_INSCRIPCION_AFBindingSource.CurrentChanged
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Recuperar()
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.SelectedValue = Me.Current.ID_ESTADO_SOLICITUD
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Recuperar()
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.SelectedValue = Me.Current.ID_TIPO_SOLICITUD
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.Recuperar()
        Me.NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.SelectedValue = Me.Current.ID_NIVEL_ACADEMICO
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New SOLICITUD_INSCRIPCION_AF 
        Me.ListaSOLICITUD_INSCRIPCION_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSOLICITUD_INSCRIPCION_AF 
    	   If mControl.ActualizarSOLICITUD_INSCRIPCION_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_SOLICITUDTextBox.Text = mEntidad.ID_SOLICITUD.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.FECHA_PRESENTACIONDateTimePicker.Enabled = edicion
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Enabled = edicion
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Enabled = edicion
        Me.NUMERO_DOCUMENTOcbxCONTROL_DOCUMENTOS.Enabled = edicion
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Enabled = edicion
        Me.NIT_EMPRESATextBox.Enabled = edicion
        Me.NOMBRE_EMPRESATextBox.Enabled = edicion
        Me.CARGOTextBox.Enabled = edicion
        Me.NUMERO_PATRONALcbxEMPRESAS.Enabled = edicion
        Me.NOMBRESTextBox.Enabled = edicion
        Me.APELLIDOSTextBox.Enabled = edicion
        Me.LUGAR_NACIMIENTOTextBox.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.CODIGO_REGIONcbxREGION.Enabled = edicion
        Me.ZONATextBox.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.MOVILTextBox.Enabled = edicion
        Me.FAXTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.NITTextBox.Enabled = edicion
        Me.ISSSTextBox.Enabled = edicion
        Me.CIUOcbxCIUO.Enabled = edicion
        Me.EDADTextBox.Enabled = edicion
        Me.DEPARTAMENTO_NACTextBox.Enabled = edicion
        Me.MUNICIPIO_NACTextBox.Enabled = edicion
        Me.FECHA_NACIMIENTODateTimePicker.Enabled = edicion
        Me.DUITextBox.Enabled = edicion
        Me.GENEROTextBox.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.PROFESION_OFICIOTextBox.Enabled = edicion
        Me.ESTADO_CIVILTextBox.Enabled = edicion
        Me.NOMBRE_FAMILIARTextBox.Enabled = edicion
        Me.PARENTESCOTextBox.Enabled = edicion
        Me.DIRECCION_FAMILIARTextBox.Enabled = edicion
        Me.TELEFONO_FAMILIARTextBox.Enabled = edicion
        Me.OCUACT_TRABAJATextBox.Enabled = edicion
        Me.OCUACT_ESTUDIATextBox.Enabled = edicion
        Me.OCUACT_DESOCUPADOTextBox.Enabled = edicion
        Me.OCUACT_OFICIO_HOGARTextBox.Enabled = edicion
        Me.TIPTRA_EMPLEADO_EMPRESATextBox.Enabled = edicion
        Me.TIPTRA_EMPRESA_PROPIATextBox.Enabled = edicion
        Me.TIPTRA_EVENTUALTextBox.Enabled = edicion
        Me.TIPTRA_MEDIO_TIEMPOTextBox.Enabled = edicion
        Me.TIPTRA_INDEPENDIENTETextBox.Enabled = edicion
        Me.RTC_OCUPACION_EMPRESATextBox.Enabled = edicion
        Me.RTC_PROPIA_EMPRESATextBox.Enabled = edicion
        Me.RTC_TRABAJO_EVENTUALTextBox.Enabled = edicion
        Me.RTC_TRABAJO_MEDIO_TIEMPOTextBox.Enabled = edicion
        Me.RTC_INDEPENDIENTETextBox.Enabled = edicion
        Me.RTC_NO_OCUPACION_EMPRESATextBox.Enabled = edicion
        Me.RTC_NO_PROPIA_EMPRESATextBox.Enabled = edicion
        Me.RTC_NO_TRABAJO_EVENTUALTextBox.Enabled = edicion
        Me.RTC_NO_TRABAJO_MEDIO_TIEMPOTextBox.Enabled = edicion
        Me.RTC_NO_INDEPENDIENTETextBox.Enabled = edicion
        Me.NIVEL_ACADEMICOcbxNIVEL_ACADEMICO.Enabled = edicion
        Me.TITULO_CERTIFICADO_OBTENIDOTextBox.Enabled = edicion
        Me.TIEMPO_DEJO_ESTUDIARTextBox.Enabled = edicion
        Me.RECIBIO_CURSO_ANTERIORTextBox.Enabled = edicion
        Me.OBTUVO_BENEFICIOS_CURSOTextBox.Enabled = edicion
        Me.BENEF_PROM_EMP_ACTTextBox.Enabled = edicion
        Me.BENEF_OBT_EMPLEOTextBox.Enabled = edicion
        Me.BENEF_OBT_ING_EXTRATextBox.Enabled = edicion
        Me.BENEF_CAMB_EMP_X_CURSOTextBox.Enabled = edicion
        Me.BENEF_TRAB_CTA_PROPIATextBox.Enabled = edicion
        Me.BENEF_OTROTextBox.Enabled = edicion
        Me.RAZON_NO_BENEFICIOTextBox.Enabled = edicion
        Me.TRABAJA_ACTUALMENTETextBox.Enabled = edicion
        Me.TRABAJO_ANTERIORTextBox.Enabled = edicion
        Me.EXPFOR_PROMOCION_EMPLEOTextBox.Enabled = edicion
        Me.EXPFOR_CAMBIAR_EMPLEOTextBox.Enabled = edicion
        Me.EXPFOR_OBTENER_EMPLEOTextBox.Enabled = edicion
        Me.EXPFOR_TRABAJAR_CTA_PROPIATextBox.Enabled = edicion
        Me.EXPFOR_INGRESOS_EXTRASTextBox.Enabled = edicion
        Me.EXPFOR_OTROTextBox.Enabled = edicion
        Me.INGRESO_MENSUAL_INDIVIDUALTextBox.Enabled = edicion
        Me.INGRESO_MENSUAL_FAMILIARTextBox.Enabled = edicion
        Me.MIEMBROS_GRUPO_FAMILIARTextBox.Enabled = edicion
        Me.SUGERENCIASTextBox.Enabled = edicion
        Me.LUGAR_PRESENTACIONTextBox.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
    End Sub

End Class
