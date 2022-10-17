Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSITIO_CAPACITACION
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
Public Class ucDetalleSITIO_CAPACITACION

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

    Public ReadOnly Property Current() As SITIO_CAPACITACION
        Get
            Return CType(Me.ListaSITIO_CAPACITACIONBindingSource.Current, SITIO_CAPACITACION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSITIO_CAPACITACIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSITIO_CAPACITACIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSITIO_CAPACITACIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSITIO_CAPACITACIONBindingSource.CurrentChanged
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue, Me.CODIGO_DEPARTAMENTOCbxDEPARTAMENTO.SelectedValue)
        Me.CODIGO_MUNICIPIOcbxMUNICIPIO.SelectedValue = Me.Current.CODIGO_MUNICIPIO
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.Recuperar(Me.CODIGO_REGIONCbxREGION.SelectedValue)
        Me.CODIGO_DEPARTAMENTOcbxDEPARTAMENTO.SelectedValue = Me.Current.CODIGO_DEPARTAMENTO
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar()
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = Me.Current.ID_PROVEEDOR_AF
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
        Dim mEntidad As New SITIO_CAPACITACION 
        Me.ListaSITIO_CAPACITACIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSITIO_CAPACITACION 
    	   If mControl.ActualizarSITIO_CAPACITACION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_SITIO_CAPACITACIONTextBox.Text = mEntidad.ID_SITIO_CAPACITACION.ToString()
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
        Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Enabled = edicion
        Me.NOMBRE_SITIOTextBox.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.FAXTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.NUMERO_AULASTextBox.Enabled = edicion
        Me.FECHA_REGISTRODateTimePicker.Enabled = edicion
        Me.ENCARGADOTextBox.Enabled = edicion
        Me.TELEFONO_ENCARGADOTextBox.Enabled = edicion
        Me.EMAIL_ENCARGADOTextBox.Enabled = edicion
        Me.CARGO_ENCARGADOTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
