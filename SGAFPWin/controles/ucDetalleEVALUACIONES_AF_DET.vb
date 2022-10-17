Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleEVALUACIONES_AF_DET
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
Public Class ucDetalleEVALUACIONES_AF_DET

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

    Public ReadOnly Property Current() As EVALUACIONES_AF_DET
        Get
            Return CType(Me.ListaEVALUACIONES_AF_DETBindingSource.Current, EVALUACIONES_AF_DET)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaEVALUACIONES_AF_DETBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaEVALUACIONES_AF_DETBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaEVALUACIONES_AF_DETBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaEVALUACIONES_AF_DETBindingSource.CurrentChanged
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Recuperar()
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = Me.Current.ID_PARTICIPANTE
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.Recuperar()
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.SelectedValue = Me.Current.ID_EVALUACION_AF
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
        Dim mEntidad As New EVALUACIONES_AF_DET 
        Me.ListaEVALUACIONES_AF_DETBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cEVALUACIONES_AF_DET 
    	   If mControl.ActualizarEVALUACIONES_AF_DET(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_EVALUACION_DETTextBox.Text = mEntidad.ID_EVALUACION_DET.ToString()
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
        Me.ID_PARTICIPANTEcbxPARTICIPANTE.Enabled = edicion
        Me.ID_EVALUACION_AFcbxEVALUACION_AF.Enabled = edicion
        Me.NOTA_OBTENIDATextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
    End Sub

End Class
