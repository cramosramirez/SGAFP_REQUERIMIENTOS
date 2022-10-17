Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleETAPA
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
Public Class ucDetalleETAPA

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

    Public ReadOnly Property Current() As ETAPA
        Get
            Return CType(Me.ListaETAPABindingSource.Current, ETAPA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaETAPABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaETAPABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaETAPABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaETAPABindingSource.CurrentChanged
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
        Dim mEntidad As New ETAPA 
        Me.ListaETAPABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cETAPA 
    	   If mControl.ActualizarETAPA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.CODIGO_ETAPATextBox.Text = mEntidad.CODIGO_ETAPA.ToString()
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
        Me.ID_ESTADO_SOLICITUDcbxESTADO_SOLICITUD.Enabled = edicion
        Me.UNIDAD_DE_TIEMPOTextBox.Enabled = edicion
        Me.NOMBRE_ETAPATextBox.Enabled = edicion
        Me.ETAPA_ANTTextBox.Enabled = edicion
        Me.ETAPA_SIGTextBox.Enabled = edicion
        Me.TIPO_ETAPATextBox.Enabled = edicion
        Me.DURACIONTextBox.Enabled = edicion
        Me.ORDEN_EJECUCIONTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
