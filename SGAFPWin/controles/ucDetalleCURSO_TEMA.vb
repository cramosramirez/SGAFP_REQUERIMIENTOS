Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCURSO_TEMA
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
Public Class ucDetalleCURSO_TEMA

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

    Public ReadOnly Property Current() As CURSO_TEMA
        Get
            Return CType(Me.ListaCURSO_TEMABindingSource.Current, CURSO_TEMA)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaCURSO_TEMABindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaCURSO_TEMABindingSource = value 
        End Set 
    End Property 

    Private Sub ListaCURSO_TEMABindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCURSO_TEMABindingSource.CurrentChanged
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.Recuperar()
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.SelectedValue = Me.Current.ID_AREA_FORMACION
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
        Dim mEntidad As New CURSO_TEMA 
        Me.ListaCURSO_TEMABindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cCURSO_TEMA 
    	   If mControl.ActualizarCURSO_TEMA(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_TEMA_CURSOTextBox.Text = mEntidad.ID_TEMA_CURSO.ToString()
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
        Me.ID_AREA_FORMACIONcbxAREA_FORMACION.Enabled = edicion
        Me.TEMA_CURSOTextBox.Enabled = edicion
        Me.DURACION_HORASTextBox.Enabled = edicion
        Me.FECHA_ACREDITACIONDateTimePicker.Enabled = edicion
        Me.NOTASTextBox.Enabled = edicion
        Me.USERIDTextBox.Enabled = edicion
        Me.LASTUPDATEDateTimePicker.Enabled = edicion
    End Sub

End Class
