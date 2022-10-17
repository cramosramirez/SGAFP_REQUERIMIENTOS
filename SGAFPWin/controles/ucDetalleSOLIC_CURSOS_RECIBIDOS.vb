Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSOLIC_CURSOS_RECIBIDOS
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
Public Class ucDetalleSOLIC_CURSOS_RECIBIDOS

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

    Public ReadOnly Property Current() As SOLIC_CURSOS_RECIBIDOS
        Get
            Return CType(Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.Current, SOLIC_CURSOS_RECIBIDOS)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSOLIC_CURSOS_RECIBIDOSBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSOLIC_CURSOS_RECIBIDOSBindingSource.CurrentChanged
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Recuperar()
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.SelectedValue = Me.Current.ID_SOLICITUD
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
        Dim mEntidad As New SOLIC_CURSOS_RECIBIDOS 
        Me.ListaSOLIC_CURSOS_RECIBIDOSBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSOLIC_CURSOS_RECIBIDOS 
    	   If mControl.ActualizarSOLIC_CURSOS_RECIBIDOS(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_CURSO_RECIBIDOTextBox.Text = mEntidad.ID_CURSO_RECIBIDO.ToString()
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
        Me.ID_SOLICITUDcbxSOLICITUD_INSCRIPCION_AF.Enabled = edicion
        Me.NOMBRE_CURSOTextBox.Enabled = edicion
        Me.INSTITUCION_CURSOTextBox.Enabled = edicion
        Me.APOYO_INSAFORPTextBox.Enabled = edicion
        Me.ANIOTextBox.Enabled = edicion
    End Sub

End Class
