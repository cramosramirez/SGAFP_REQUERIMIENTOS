Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleHALLAZGO_SUPERVISION
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
Public Class ucDetalleHALLAZGO_SUPERVISION

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

    Public ReadOnly Property Current() As HALLAZGO_SUPERVISION
        Get
            Return CType(Me.ListaHALLAZGO_SUPERVISIONBindingSource.Current, HALLAZGO_SUPERVISION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaHALLAZGO_SUPERVISIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaHALLAZGO_SUPERVISIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaHALLAZGO_SUPERVISIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaHALLAZGO_SUPERVISIONBindingSource.CurrentChanged
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.Recuperar()
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.SelectedValue = Me.Current.ID_AREA_SUPERVISION
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Recuperar()
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.SelectedValue = Me.Current.ID_SUPERVISION_AF
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
        Dim mEntidad As New HALLAZGO_SUPERVISION 
        Me.ListaHALLAZGO_SUPERVISIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cHALLAZGO_SUPERVISION 
    	   If mControl.ActualizarHALLAZGO_SUPERVISION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_HALLAZGO_SUPERVISIONTextBox.Text = mEntidad.ID_HALLAZGO_SUPERVISION.ToString()
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
        Me.ID_AREA_SUPERVISIONcbxAREA_SUPERVISION.Enabled = edicion
        Me.ID_SUPERVISION_AFcbxSUPERVISION_AF.Enabled = edicion
        Me.HALLAZGO_SUPERVISIONTextBox.Enabled = edicion
        Me.FECHADateTimePicker.Enabled = edicion
        Me.TIPO_SANCIONTextBox.Enabled = edicion
        Me.TIEMPO_SANCIONTextBox.Enabled = edicion
        Me.MONTO_SANCIONTextBox.Enabled = edicion
        Me.TIEMPO_SUBSANACIONTextBox.Enabled = edicion
    End Sub

End Class
