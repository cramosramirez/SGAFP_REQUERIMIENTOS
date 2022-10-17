Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleSUPERVISION_AF
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
Public Class ucDetalleSUPERVISION_AF

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

    Public ReadOnly Property Current() As SUPERVISION_AF
        Get
            Return CType(Me.ListaSUPERVISION_AFBindingSource.Current, SUPERVISION_AF)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaSUPERVISION_AFBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaSUPERVISION_AFBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaSUPERVISION_AFBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaSUPERVISION_AFBindingSource.CurrentChanged
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Recuperar()
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.SelectedValue = Me.Current.ID_MODALIDAD_FORMACION
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
        Dim mEntidad As New SUPERVISION_AF 
        Me.ListaSUPERVISION_AFBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cSUPERVISION_AF 
    	   If mControl.ActualizarSUPERVISION_AF(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_SUPERVISION_AFTextBox.Text = mEntidad.ID_SUPERVISION_AF.ToString()
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
        Me.ID_MODALIDAD_FORMACIONcbxMODALIDAD_DE_FORMACION.Enabled = edicion
        Me.ID_ACCION_FORMATIVAcbxACCION_FORMATIVA.Enabled = edicion
        Me.FECHADateTimePicker.Enabled = edicion
        Me.NOMBRE_AFTextBox.Enabled = edicion
        Me.CENTRO_FORMACIONTextBox.Enabled = edicion
        Me.OPCIONTextBox.Enabled = edicion
        Me.GRUPOTextBox.Enabled = edicion
        Me.HORARIOTextBox.Enabled = edicion
        Me.CODIGOTextBox.Enabled = edicion
        Me.COORDINADOR_CFPTextBox.Enabled = edicion
        Me.DIRECTOR_CFPTextBox.Enabled = edicion
        Me.PARTICIPANTES_PRESENTESTextBox.Enabled = edicion
        Me.PARTICIPANTES_AUSENTESTextBox.Enabled = edicion
        Me.PARTICIPANTES_INSCRITOSTextBox.Enabled = edicion
        Me.PARTICIPANTES_DESERTADOSTextBox.Enabled = edicion
        Me.PARTICIPANTES_SUPLENTESTextBox.Enabled = edicion
        Me.OBJETIVO_VISITATextBox.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.DURACION_VISITATextBox.Enabled = edicion
    End Sub

End Class
