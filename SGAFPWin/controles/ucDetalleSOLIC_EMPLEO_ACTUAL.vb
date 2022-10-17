Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSOLIC_EMPLEO_ACTUAL
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
Public Class ucDetalleSOLIC_EMPLEO_ACTUAL

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

    Public ReadOnly Property Current() As SOLIC_EMPLEO_ACTUAL
        Get
            Return CType(Me.ListaSOLIC_EMPLEO_ACTUALBindingSource.Current, SOLIC_EMPLEO_ACTUAL)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSOLIC_EMPLEO_ACTUALBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSOLIC_EMPLEO_ACTUALBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSOLIC_EMPLEO_ACTUALBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLIC_EMPLEO_ACTUALBindingSource.CurrentChanged
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Recuperar()
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.SelectedValue = Me.Current.ID_SOLICITUD
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue, Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
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
        Dim mEntidad As New SOLIC_EMPLEO_ACTUAL 
        Me.ListaSOLIC_EMPLEO_ACTUALBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSOLIC_EMPLEO_ACTUAL 
    	   If mControl.ActualizarSOLIC_EMPLEO_ACTUAL(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_EMPLEO_ACTUALTextBox.Text = mEntidad.ID_EMPLEO_ACTUAL.ToString()
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
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Enabled = edicion
        Me.NOMBRE_EMPRESATextBox.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.ZONATextBox.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.FAXTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.ISSSTextBox.Enabled = edicion
        Me.JEFE_INMEDIATOTextBox.Enabled = edicion
        Me.ACTIVIDAD_ECONOMICAcbxCIUU.Enabled = edicion
        Me.PUESTO_CONTRATADOTextBox.Enabled = edicion
        Me.PUESTO_ACTUALTextBox.Enabled = edicion
        Me.TIEMPO_TRABAJOTextBox.Enabled = edicion
        Me.AREA_TRABAJOTextBox.Enabled = edicion
        Me.AREA_OTROTextBox.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.CODIGO_REGIONcbxREGION.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
    End Sub

End Class
