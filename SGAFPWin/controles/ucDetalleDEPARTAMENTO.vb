Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleDEPARTAMENTO
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
Public Class ucDetalleDEPARTAMENTO

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

    Public ReadOnly Property Current() As DEPARTAMENTO
        Get
            Return CType(Me.ListaDEPARTAMENTOBindingSource.Current, DEPARTAMENTO)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaDEPARTAMENTOBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaDEPARTAMENTOBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaDEPARTAMENTOBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaDEPARTAMENTOBindingSource.CurrentChanged
        Me.CODIGO_REGIONcbxREGION.Recuperar()
        Me.CODIGO_REGIONcbxREGION.SelectedValue = Me.Current.CODIGO_REGION
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
        Dim mEntidad As New DEPARTAMENTO 
        Me.ListaDEPARTAMENTOBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cDEPARTAMENTO 
    	   If mControl.ActualizarDEPARTAMENTO(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.CODIGO_DEPARTAMENTOTextBox.Text = mEntidad.CODIGO_DEPARTAMENTO.ToString()
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
        Me.NOMBRETextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
