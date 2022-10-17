Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleMETODO_EVALUACION
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
Public Class ucDetalleMETODO_EVALUACION

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

    Public ReadOnly Property Current() As METODO_EVALUACION
        Get
            Return CType(Me.ListaMETODO_EVALUACIONBindingSource.Current, METODO_EVALUACION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaMETODO_EVALUACIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaMETODO_EVALUACIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaMETODO_EVALUACIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaMETODO_EVALUACIONBindingSource.CurrentChanged
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
        Dim mEntidad As New METODO_EVALUACION 
        Me.ListaMETODO_EVALUACIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cMETODO_EVALUACION 
    	   If mControl.ActualizarMETODO_EVALUACION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_METODO_EVALUACIONTextBox.Text = mEntidad.ID_METODO_EVALUACION.ToString()
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
        Me.METODO_EVALUACIONTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
