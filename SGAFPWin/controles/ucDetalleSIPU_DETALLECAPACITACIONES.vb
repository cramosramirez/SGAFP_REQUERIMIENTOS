Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSIPU_DETALLECAPACITACIONES
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
Public Class ucDetalleSIPU_DETALLECAPACITACIONES

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

    Public ReadOnly Property Current() As SIPU_DETALLECAPACITADO
        Get
            Return CType(Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.Current, SIPU_DETALLECAPACITADO)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource
        Get
            Return Me.ListaSIPU_DETALLECAPACITACIONESBindingSource
        End Get
        Set(ByVal value As System.Windows.Forms.BindingSource)
            Me.ListaSIPU_DETALLECAPACITACIONESBindingSource = value
        End Set
    End Property

    Private Sub ListaSIPU_DETALLECAPACITACIONESBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSIPU_DETALLECAPACITACIONESBindingSource.CurrentChanged
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.Recuperar()
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.SelectedValue = Me.Current.ID_CAPACITACION
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
        Dim mEntidad As New SIPU_DETALLECAPACITADO
        Me.ListaSIPU_DETALLECAPACITACIONESBindingSource.EndEdit()
        mEntidad = Me.Current
        Dim mControl As New cSIPU_DETALLECAPACITADO
        If mControl.ActualizarSIPU_DETALLECAPACITADO(mEntidad) < 1 Then
            Me.AsignarMensaje("No se pudo guardar el registro", True)
            Return -1
        End If
        Me.IDDETALLECAPACITACIONTextEdit.Text = mEntidad.IDDETALLECAPACITADO.ToString()
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
        Me.ID_CAPACITACIONcbxSIPU_CAPACITACIONES.Enabled = edicion
        Me.CONVENIOSpinEdit.Enabled = edicion
        Me.ESTADOTextEdit.Enabled = edicion
    End Sub

End Class
