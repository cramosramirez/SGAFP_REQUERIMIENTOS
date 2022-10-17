Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucDetalleCENTRO_RESPONSABILIDAD
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
Public Class ucDetalleCENTRO_RESPONSABILIDAD

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

    Public ReadOnly Property Current() As CENTRO_RESPONSABILIDAD
        Get
            Return CType(Me.ListaCENTRO_RESPONSABILIDADBindingSource.Current, CENTRO_RESPONSABILIDAD)
        End Get
    End Property

    Public Overrides Property DataSource() As System.Windows.Forms.BindingSource 
        Get 
            Return Me.ListaCENTRO_RESPONSABILIDADBindingSource 
        End Get 
        Set(ByVal value As System.Windows.Forms.BindingSource) 
            Me.ListaCENTRO_RESPONSABILIDADBindingSource = value 
        End Set 
    End Property 

    Private Sub ListaCENTRO_RESPONSABILIDADBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaCENTRO_RESPONSABILIDADBindingSource.CurrentChanged
        Me.ID_CENTRO_RESPONSABILIDAD_PADRcbxCENTRO_RESPONSABILIDAD.Recuperar()
        Me.ID_CENTRO_RESPONSABILIDAD_PADRcbxCENTRO_RESPONSABILIDAD.SelectedValue = Me.Current.ID_CENTRO_RESPONSABILIDAD_PADR
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
        Dim mEntidad As New CENTRO_RESPONSABILIDAD 
        Me.ListaCENTRO_RESPONSABILIDADBindingSource.EndEdit() 
        mEntidad = Me.Current 
        Dim mControl As New cCENTRO_RESPONSABILIDAD 
    	   If mControl.ActualizarCENTRO_RESPONSABILIDAD(mEntidad) < 1 Then 
            Me.AsignarMensaje("No se pudo guardar el registro", True) 
            Return -1 
        End If 
        Me.ID_CENTRO_RESPONSABILIDADTextEdit.Text = mEntidad.ID_CENTRO_RESPONSABILIDAD.ToString()
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
        Me.ID_CENTRO_RESPONSABILIDAD_PADRcbxCENTRO_RESPONSABILIDAD.Enabled = edicion
        Me.CODIGO_CENTRO_RESPONSABILIDADTextEdit.Enabled = edicion
        Me.NOMBRE_CENTRO_RESPONSABILIDADTextEdit.Enabled = edicion
        Me.USERIDTextEdit.Enabled = edicion
        Me.LASTUPDATEDateEdit.Enabled = edicion
    End Sub

End Class
