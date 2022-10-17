Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCONTROL_DOCUMENTOS
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
Public Class ucDetalleCONTROL_DOCUMENTOS

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

    Public ReadOnly Property Current() As CONTROL_DOCUMENTOS
        Get
            Return CType(Me.ListaCONTROL_DOCUMENTOSBindingSource.Current, CONTROL_DOCUMENTOS)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaCONTROL_DOCUMENTOSBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaCONTROL_DOCUMENTOSBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaCONTROL_DOCUMENTOSBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCONTROL_DOCUMENTOSBindingSource.CurrentChanged
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Recuperar()
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.SelectedValue = Me.Current.ID_TIPO_SOLICITUD
        Me.CODIGO_ETAPAcbxETAPA.Recuperar(Me.CODIGO_PROCESOCbxPROCESO.SelectedValue)
        Me.CODIGO_ETAPAcbxETAPA.SelectedValue = Me.Current.CODIGO_ETAPA
        Me.CODIGO_PROCESOcbxPROCESO.Recuperar()
        Me.CODIGO_PROCESOcbxPROCESO.SelectedValue = Me.Current.CODIGO_PROCESO
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Recuperar()
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.SelectedValue = Me.Current.ID_ESTADO_SOLICITUD
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
        Dim mEntidad As New CONTROL_DOCUMENTOS 
        Me.ListaCONTROL_DOCUMENTOSBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cCONTROL_DOCUMENTOS 
    	   If mControl.ActualizarCONTROL_DOCUMENTOS(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.NUMERO_DOCUMENTOTextBox.Text = mEntidad.NUMERO_DOCUMENTO.ToString()
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
        Me.NUMERO_PATRONALTextBox.Enabled = edicion
        Me.NUMERO_FOLIOTextBox.Enabled = edicion
        Me.ID_TIPO_SOLICITUDcbxTIPO_SOLICITUD.Enabled = edicion
        Me.CODIGO_ETAPAcbxETAPA.Enabled = edicion
        Me.CODIGO_PROCESOcbxPROCESO.Enabled = edicion
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Enabled = edicion
        Me.NITTextBox.Enabled = edicion
        Me.PRESENTADO_PORTextBox.Enabled = edicion
        Me.FECHA_RECEPCIONDateTimePicker.Enabled = edicion
        Me.RESPONSABLE_ACTUALTextBox.Enabled = edicion
        Me.RESPONSABLE_ANTERIORTextBox.Enabled = edicion
        Me.PRIORIDADTextBox.Enabled = edicion
        Me.NO_DOCUMENTO_ORIGENTextBox.Enabled = edicion
        Me.NO_DOCUMENTO_PADRETextBox.Enabled = edicion
        Me.FECHA_REQUERIDA_FINDateTimePicker.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
