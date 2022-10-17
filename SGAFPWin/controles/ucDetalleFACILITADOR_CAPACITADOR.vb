Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleFACILITADOR_CAPACITADOR
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
Public Class ucDetalleFACILITADOR_CAPACITADOR

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

    Public ReadOnly Property Current() As FACILITADOR_CAPACITADOR
        Get
            Return CType(Me.ListaFACILITADOR_CAPACITADORBindingSource.Current, FACILITADOR_CAPACITADOR)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaFACILITADOR_CAPACITADORBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaFACILITADOR_CAPACITADORBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaFACILITADOR_CAPACITADORBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaFACILITADOR_CAPACITADORBindingSource.CurrentChanged
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Recuperar()
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.SelectedValue = Me.Current.ID_TIPO_PERSONA
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF
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
        Dim mEntidad As New FACILITADOR_CAPACITADOR 
        Me.ListaFACILITADOR_CAPACITADORBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cFACILITADOR_CAPACITADOR 
    	   If mControl.ActualizarFACILITADOR_CAPACITADOR(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_FACILITADORTextBox.Text = mEntidad.ID_FACILITADOR.ToString()
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
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Enabled = edicion
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.CODIGO_REGIONcbxREGION.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.NOMBRE_FACILITADORTextBox.Enabled = edicion
        Me.NITTextBox.Enabled = edicion
        Me.DUITextBox.Enabled = edicion
        Me.ISSSTextBox.Enabled = edicion
        Me.FECHA_INGRESODateTimePicker.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
