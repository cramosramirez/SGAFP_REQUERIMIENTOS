Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetallePROVEEDOR_AF
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
Public Class ucDetallePROVEEDOR_AF

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

    Public ReadOnly Property Current() As PROVEEDOR_AF
        Get
            Return CType(Me.ListaPROVEEDOR_AFBindingSource.Current, PROVEEDOR_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaPROVEEDOR_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaPROVEEDOR_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaPROVEEDOR_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPROVEEDOR_AFBindingSource.CurrentChanged
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue, Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Recuperar()
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.SelectedValue = Me.Current.ID_TIPO_PERSONA
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
        Dim mEntidad As New PROVEEDOR_AF 
        Me.ListaPROVEEDOR_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cPROVEEDOR_AF 
    	   If mControl.ActualizarPROVEEDOR_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_PROVEEDOR_AFTextBox.Text = mEntidad.ID_PROVEEDOR_AF.ToString()
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
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Enabled = edicion
        Me.CODIGO_REGIONcbxREGION.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Enabled = edicion
        Me.ID_TIPO_PERSONAcbxTIPO_PERSONA.Enabled = edicion
        Me.NOMBRE_PROVEEDORTextBox.Enabled = edicion
        Me.RAZON_SOCIALTextBox.Enabled = edicion
        Me.NITTextBox.Enabled = edicion
        Me.DUITextBox.Enabled = edicion
        Me.NRCTextBox.Enabled = edicion
        Me.ISSSTextBox.Enabled = edicion
        Me.FECHA_INGRESODateTimePicker.Enabled = edicion
        Me.FECHA_ACREDITACIONDateTimePicker.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.FAXTextBox.Enabled = edicion
        Me.URLTextBox.Enabled = edicion
        Me.CONTACTOTextBox.Enabled = edicion
        Me.TELEFONO_CONTACTOTextBox.Enabled = edicion
        Me.EMAIL_CONTACTOTextBox.Enabled = edicion
        Me.CARGO_CONTACTOTextBox.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
