Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSIPU_CAPACITACIONES
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleSIPU_CAPACITACIONES

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

    Public ReadOnly Property Current() As SIPU_CAPACITACIONES
        Get
            Return CType(Me.ListaSIPU_CAPACITACIONESBindingSource.Current, SIPU_CAPACITACIONES)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSIPU_CAPACITACIONESBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSIPU_CAPACITACIONESBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSIPU_CAPACITACIONESBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_CAPACITACIONESBindingSource.CurrentChanged
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.Recuperar()
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.SelectedValue = Me.Current.IDTIPOCAPACITACION
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.Recuperar()
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.SelectedValue = Me.Current.IDMUNICIPIO
        Me.ID_GENERACIONcbxSIPU_GENERACION.Recuperar()
        Me.ID_GENERACIONcbxSIPU_GENERACION.SelectedValue = Me.Current.ID_GENERACION
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New SIPU_CAPACITACIONES 
        Me.ListaSIPU_CAPACITACIONESBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSIPU_CAPACITACIONES 
    	   If mControl.ActualizarSIPU_CAPACITACIONES(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.IDCAPACITACIONTextEdit.Text = mEntidad.IDCAPACITACION.ToString()
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.DESCRIPCIONTextEdit.Enabled = edicion
        Me.IDTIPOCAPACITACIONcbxSIPU_TIPOCAPACITACIONES.Enabled = edicion
        Me.IDESTADOSpinEdit.Enabled = edicion
        Me.FECHAINICIODateEdit.Enabled = edicion
        Me.FECHAFINDateEdit.Enabled = edicion
        Me.IDMUNICIPIOcbxSIPU_MUNICIPIO.Enabled = edicion
        Me.ID_GENERACIONcbxSIPU_GENERACION.Enabled = edicion
    End Sub

End Class
