Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleTERMINO_REFERENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class ucDetalleTERMINO_REFERENCIA_AF

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

    Public ReadOnly Property Current() As TERMINO_REFERENCIA_AF
        Get
            Return CType(Me.ListaTERMINO_REFERENCIA_AFBindingSource.Current, TERMINO_REFERENCIA_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaTERMINO_REFERENCIA_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaTERMINO_REFERENCIA_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaTERMINO_REFERENCIA_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaTERMINO_REFERENCIA_AFBindingSource.CurrentChanged
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Recuperar()
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.SelectedValue = Me.Current.ID_ACCION_FORMATIVA
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.Recuperar()
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.SelectedValue = Me.Current.ID_SOLICITUD
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que sobreescribe y realiza la acción de Guardar en la Base de Datos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar() As Integer 
        Dim mEntidad As New TERMINO_REFERENCIA_AF 
        Me.ListaTERMINO_REFERENCIA_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cTERMINO_REFERENCIA_AF 
        If Me.EsNuevo Then 
            If mControl.AgregarTERMINO_REFERENCIA_AF(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo agregar el registro", True) 
                Return -1 
            End If 
        Else 
            If mControl.ActualizarTERMINO_REFERENCIA_AF(mEntidad) < 1 Then 
                Me.AsignarMensaje("No se pudo guardar el registro", True) 
                Return -1 
            End If 
        End If 
        Return 1 
    End Function 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.RESOLUCIONTextEdit.Enabled = edicion
        Me.TDRTextEdit.Enabled = edicion
        Me.MONTO_ADJUDICADOSpinEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
        Me.CORRELATIVO_GRUPOSpinEdit.Enabled = edicion
        Me.ID_SOLICITUDcbxSOLICITUD_CAPACITACION.Enabled = edicion
    End Sub

End Class
