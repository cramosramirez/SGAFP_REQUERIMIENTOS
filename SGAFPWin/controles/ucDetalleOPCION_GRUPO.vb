Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleOPCION_GRUPO
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
Public Class ucDetalleOPCION_GRUPO

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

    Public ReadOnly Property Current() As OPCION_GRUPO
        Get
            Return CType(Me.ListaOPCION_GRUPOBindingSource.Current, OPCION_GRUPO)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaOPCION_GRUPOBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaOPCION_GRUPOBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaOPCION_GRUPOBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaOPCION_GRUPOBindingSource.CurrentChanged
        Me.ID_OPCION_MENUcbxOPCION_MENU.Recuperar()
        Me.ID_OPCION_MENUcbxOPCION_MENU.SelectedValue = Me.Current.ID_OPCION_MENU
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.Recuperar()
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.SelectedValue = Me.Current.ID_GRUPO_USUARIO
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
        Dim mEntidad As New OPCION_GRUPO 
        Me.ListaOPCION_GRUPOBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cOPCION_GRUPO 
    	   If mControl.ActualizarOPCION_GRUPO(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_OPCION_GRUPOTextBox.Text = mEntidad.ID_OPCION_GRUPO.ToString()
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
        Me.ID_OPCION_MENUcbxOPCION_MENU.Enabled = edicion
        Me.ID_GRUPO_USUARIOcbxGRUPO_USUARIO.Enabled = edicion
        Me.FECHA_INGRESODateTimePicker.Enabled = edicion
        Me.ESTADOTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
