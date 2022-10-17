Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleESTADO_ACCION_FORMATIVA
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
Public Class ucDetalleESTADO_ACCION_FORMATIVA

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

    Public ReadOnly Property Current() As ESTADO_ACCION_FORMATIVA
        Get
            Return CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource.Current, ESTADO_ACCION_FORMATIVA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaESTADO_ACCION_FORMATIVABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaESTADO_ACCION_FORMATIVABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaESTADO_ACCION_FORMATIVABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaESTADO_ACCION_FORMATIVABindingSource.CurrentChanged
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
        Dim mEntidad As New ESTADO_ACCION_FORMATIVA 
        Me.ListaESTADO_ACCION_FORMATIVABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cESTADO_ACCION_FORMATIVA 
    	   If mControl.ActualizarESTADO_ACCION_FORMATIVA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.CODIGO_ESTADO_AFTextBox.Text = mEntidad.CODIGO_ESTADO_AF.ToString()
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
        Me.NOMBRE_ESTADO_AFTextBox.Enabled = edicion
        Me.ESTADO_INICIALTextBox.Enabled = edicion
        Me.PERMITE_INSCRIPCIONTextBox.Enabled = edicion
        Me.ESTADO_FINALTextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
