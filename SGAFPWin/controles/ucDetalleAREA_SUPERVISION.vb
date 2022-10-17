Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleAREA_SUPERVISION
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
Public Class ucDetalleAREA_SUPERVISION

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

    Public ReadOnly Property Current() As AREA_SUPERVISION
        Get
            Return CType(Me.ListaAREA_SUPERVISIONBindingSource.Current, AREA_SUPERVISION)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaAREA_SUPERVISIONBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaAREA_SUPERVISIONBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaAREA_SUPERVISIONBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaAREA_SUPERVISIONBindingSource.CurrentChanged
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
        Dim mEntidad As New AREA_SUPERVISION 
        Me.ListaAREA_SUPERVISIONBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cAREA_SUPERVISION 
    	   If mControl.ActualizarAREA_SUPERVISION(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_AREA_SUPERVISIONTextBox.Text = mEntidad.ID_AREA_SUPERVISION.ToString()
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
        Me.AREA_SUPERVISIONTextBox.Enabled = edicion
        Me.SANCIONATORIATextBox.Enabled = edicion
        Me.MONTO_SANCIONTextBox.Enabled = edicion
        Me.TIEMPO_SANCIONTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
