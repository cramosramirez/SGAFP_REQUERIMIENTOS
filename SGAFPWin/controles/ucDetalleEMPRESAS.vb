Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleEMPRESAS
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
Public Class ucDetalleEMPRESAS

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

    Public ReadOnly Property Current() As EMPRESAS
        Get
            Return CType(Me.ListaEMPRESASBindingSource.Current, EMPRESAS)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaEMPRESASBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaEMPRESASBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaEMPRESASBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEMPRESASBindingSource.CurrentChanged
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
        Dim mEntidad As New EMPRESAS 
        Me.ListaEMPRESASBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cEMPRESAS 
    	   If mControl.ActualizarEMPRESAS(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.NUMERO_PATRONALTextBox.Text = mEntidad.NUMERO_PATRONAL.ToString()
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
        Me.NIT_EMPRESATextBox.Enabled = edicion
        Me.CIUUTextBox.Enabled = edicion
        Me.SECTOR_PRODUCTIVOTextBox.Enabled = edicion
        Me.CODIGO_ASESORTextBox.Enabled = edicion
        Me.CODIGO_MUNICIPIOTextBox.Enabled = edicion
        Me.CODIGO_DEPARTAMENTOTextBox.Enabled = edicion
        Me.CODIGO_REGIONTextBox.Enabled = edicion
        Me.NOMBRE_EMPRESATextBox.Enabled = edicion
        Me.TIPO_EMPRESATextBox.Enabled = edicion
        Me.CONTACTO_EMPRESATextBox.Enabled = edicion
        Me.TELEFONO_CONTACTOTextBox.Enabled = edicion
        Me.CARGO_CONTACTOTextBox.Enabled = edicion
        Me.DIRECCION_EMPRESATextBox.Enabled = edicion
        Me.TELEFONO_EMPRESATextBox.Enabled = edicion
        Me.FAX_EMPRESATextBox.Enabled = edicion
        Me.EMAIL_EMPRESATextBox.Enabled = edicion
        Me.ESPECIALIDAD_EMPRESATextBox.Enabled = edicion
        Me.TOTAL_PERSONATextBox.Enabled = edicion
        Me.TOTAL_PLANILLATextBox.Enabled = edicion
        Me.REPRESENTANTE_LEGALTextBox.Enabled = edicion
        Me.FECHA_REGISTRODateTimePicker.Enabled = edicion
        Me.TOTAL_TRABAJADORESTextBox.Enabled = edicion
        Me.FEMENINOSTextBox.Enabled = edicion
        Me.MASCULINOSTextBox.Enabled = edicion
        Me.TAMANO_EMPRESATextBox.Enabled = edicion
        Me.CON_MANDOTextBox.Enabled = edicion
        Me.SIN_MANDOTextBox.Enabled = edicion
        Me.ADMINISTRATIVOSTextBox.Enabled = edicion
        Me.MANDOS_MEDIOSTextBox.Enabled = edicion
        Me.OPERATIVOSTextBox.Enabled = edicion
        Me.GERENCIALTextBox.Enabled = edicion
        Me.SIGLASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
        Me.OBSERVACIONTextBox.Enabled = edicion
        Me.NUM_PAT_ISSSTextBox.Enabled = edicion
        Me.TIPOPERSONTextBox.Enabled = edicion
        Me.NUMTextBox.Enabled = edicion
        Me.REPRESENTANTE_PROFESIONTextBox.Enabled = edicion
        Me.CONTACTO_EMAILTextBox.Enabled = edicion
        Me.APORTE_INSAFORPTextBox.Enabled = edicion
        Me.ZONATextBox.Enabled = edicion
    End Sub

End Class
