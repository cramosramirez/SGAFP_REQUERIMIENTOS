Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleTIPO_SOLICITUD
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
Public Class ucDetalleTIPO_SOLICITUD

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

    Public ReadOnly Property Current() As TIPO_SOLICITUD
        Get
            Return CType(Me.ListaTIPO_SOLICITUDBindingSource.Current, TIPO_SOLICITUD)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaTIPO_SOLICITUDBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaTIPO_SOLICITUDBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaTIPO_SOLICITUDBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTIPO_SOLICITUDBindingSource.CurrentChanged
        Me.CODIGO_PROCESOcbxPROCESO.Recuperar()
        Me.CODIGO_PROCESOcbxPROCESO.SelectedValue = Me.Current.CODIGO_PROCESO
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
        Dim mEntidad As New TIPO_SOLICITUD 
        Me.ListaTIPO_SOLICITUDBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cTIPO_SOLICITUD 
    	   If mControl.ActualizarTIPO_SOLICITUD(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_TIPO_SOLICITUDTextBox.Text = mEntidad.ID_TIPO_SOLICITUD.ToString()
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
        Me.CODIGO_PROCESOcbxPROCESO.Enabled = edicion
        Me.TIPO_SOLICITUDTextBox.Enabled = edicion
        Me.TABLA_RELACIONALTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
