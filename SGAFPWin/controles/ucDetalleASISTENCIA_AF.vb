Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleASISTENCIA_AF
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
Public Class ucDetalleASISTENCIA_AF

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

    Public ReadOnly Property Current() As ASISTENCIA_AF
        Get
            Return CType(Me.ListaASISTENCIA_AFBindingSource.Current, ASISTENCIA_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaASISTENCIA_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaASISTENCIA_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaASISTENCIA_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaASISTENCIA_AFBindingSource.CurrentChanged
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
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
        Dim mEntidad As New ASISTENCIA_AF 
        Me.ListaASISTENCIA_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cASISTENCIA_AF 
    	   If mControl.ActualizarASISTENCIA_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_ASISTENCIA_AFTextBox.Text = mEntidad.ID_ASISTENCIA_AF.ToString()
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
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.FECHADateTimePicker.Enabled = edicion
        Me.INSTRUCTORTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
