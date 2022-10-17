Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSIPU_TIPOCAPACITACIONES
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
Public Class ucDetalleSIPU_TIPOCAPACITACIONES

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

    Public ReadOnly Property Current() As SIPU_TIPOCAPACITACIONES
        Get
            Return CType(Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.Current, SIPU_TIPOCAPACITACIONES)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSIPU_TIPOCAPACITACIONESBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSIPU_TIPOCAPACITACIONESBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSIPU_TIPOCAPACITACIONESBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_TIPOCAPACITACIONESBindingSource.CurrentChanged
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
        Dim mEntidad As New SIPU_TIPOCAPACITACIONES 
        Me.ListaSIPU_TIPOCAPACITACIONESBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSIPU_TIPOCAPACITACIONES 
    	   If mControl.ActualizarSIPU_TIPOCAPACITACIONES(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.IDTIPOCAPACITACIONTextEdit.Text = mEntidad.IDTIPOCAPACITACION.ToString()
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
    End Sub

End Class
