Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleNIVEL_ACADEMICO
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
Public Class ucDetalleNIVEL_ACADEMICO

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

    Public ReadOnly Property Current() As NIVEL_ACADEMICO
        Get
            Return CType(Me.ListaNIVEL_ACADEMICOBindingSource.Current, NIVEL_ACADEMICO)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaNIVEL_ACADEMICOBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaNIVEL_ACADEMICOBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaNIVEL_ACADEMICOBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaNIVEL_ACADEMICOBindingSource.CurrentChanged
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
        Dim mEntidad As New NIVEL_ACADEMICO 
        Me.ListaNIVEL_ACADEMICOBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cNIVEL_ACADEMICO 
    	   If mControl.ActualizarNIVEL_ACADEMICO(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.NIVEL_ACADEMICOTextBox.Text = mEntidad.ID_NIVEL_ACADEMICO.ToString()
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
        Me.DESCRIPCIONTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
